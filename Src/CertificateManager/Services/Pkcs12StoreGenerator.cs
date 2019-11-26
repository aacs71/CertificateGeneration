using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CertificateManager.Infrastructure;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509.Extension;
using X509Certificate = Org.BouncyCastle.X509.X509Certificate;

namespace CertificateManager.Services
{
    public class DefaultPkcs12StoreGenerator
    {
        // o pkcs12, tem o certificado e a chave privada
        public byte[] Create(
            X509Certificate certificate,
            AsymmetricCipherKeyPair subjectKeyPair,
            string pkcs12Password
            )
        {
            Pkcs12Store store = new Pkcs12StoreBuilder().Build();

            string friendlyName = certificate.SubjectDN.ToString();
            store.SetKeyEntry(
                friendlyName,
                new AsymmetricKeyEntry(subjectKeyPair.Private),
                new[]
                {
                    new X509CertificateEntry(certificate)
                });

            using (var memoryStream = new MemoryStream())
            {
                store.Save(memoryStream, pkcs12Password.ToCharArray(), GetSecureRandom());
                return memoryStream.ToArray();
            }
        }

        public byte[] Create(
            X509Certificate certificate,
            AsymmetricCipherKeyPair subjectKeyPair,
            string pkcs12Password,
            IList<string> authoritiesFiles
            )
        {
            var chain = new HashSet<X509CertificateEntry>
            {
                new X509CertificateEntry(certificate)
            };

            if (!authoritiesFiles.IsStringListNullOrEmpty())
            {
                List<X509Certificate> authorities = authoritiesFiles.Select(IOPEMUtils.LoadPemCertificate).ToList();

                X509Certificate cert = certificate;
                foreach (X509Certificate authority in authorities)
                {
                    if (!IsCA(authority))
                    {
                        throw new Exception("Apenas podem ser incluidas CA's");
                    }

                    X509Certificate founded = GetIssuerFromList(cert, authorities);
                    if (founded == null)
                    {
                        throw new Exception(String.Format("Não foi encontrado quem assinou {0}", cert.SubjectDN));
                    }
                    chain.Add(new X509CertificateEntry(founded));
                    cert = founded;
                }

                if ((chain.Count - 1) != authorities.Count)
                {
                    throw new Exception("Nem todos os certificados foram incluidos");
                }
                X509Certificate last = chain.Last().Certificate;
                if (!IsRootCA(last))
                {
                    throw new Exception("A cadeira de CA's não está completa");
                }
            }

            Pkcs12Store store = new Pkcs12StoreBuilder().Build();

            string friendlyName = certificate.SubjectDN.ToString();
            store.SetKeyEntry(
                friendlyName,
                new AsymmetricKeyEntry(subjectKeyPair.Private),
                chain.ToArray()
                );

            using (var memoryStream = new MemoryStream())
            {
                store.Save(memoryStream,
                    String.IsNullOrWhiteSpace(pkcs12Password) ? null : pkcs12Password.ToCharArray(),
                    GetSecureRandom());
                return memoryStream.ToArray();
            }
        }

        private X509Certificate GetIssuerFromList(X509Certificate certificate, IList<X509Certificate> authorities)
        {
            X509Name issuerId = certificate.IssuerDN;

            if (!authorities.IsNullOrEmpty())
            {
                return authorities.FirstOrDefault(authority => authority.SubjectDN.Equals(issuerId));
            }

            return null;
        }

        private bool IsCA(X509Certificate certificate)
        {
            Asn1OctetString extension = certificate.GetExtensionValue(X509Extensions.BasicConstraints);
            if (extension != null)
            {
                BasicConstraints constraint = BasicConstraints.GetInstance(
                    X509ExtensionUtilities.FromExtensionValue(extension));
                if (constraint != null)
                {
                    return constraint.IsCA();
                }
            }

            return false;
        }

        private bool IsRootCA(X509Certificate certificate)
        {
            return IsCA(certificate) && certificate.SubjectDN.Equals(certificate.IssuerDN);
        }

        // usando o "exportable" nativo da MS
        public X509Certificate2 CreateNative(
            X509Certificate certificate,
            AsymmetricCipherKeyPair subjectKeyPair,
            string pkcs12Password)
        {
            return
                new X509Certificate2(Create(certificate, subjectKeyPair, pkcs12Password),
                    pkcs12Password,
                    X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
        }

        public byte[] ExportableNative(
            X509Certificate certificate,
            AsymmetricCipherKeyPair subjectKeyPair,
            string pkcs12Password)
        {
            return
                CreateNative(certificate, subjectKeyPair, pkcs12Password)
                    .Export(X509ContentType.Pkcs12, (string) null);
        }

        // http://stackoverflow.com/questions/12679533/how-do-i-use-bouncycastle-to-generate-a-root-certificate-and-then-a-site-certifi
        // PARA REVER... Algo não está correcto....
        //public byte[] CreateChain(
        //    AsymmetricCipherKeyPair certKeyPair,
        //    X509Certificate certificate,
        //    string pkcs12Password,
        //    IList<X509Certificate> chainWithCas
        //    )
        //{
        //    string friendlyName = certificate.SubjectDN.ToString();

        //    // Create the PKCS12 store
        //    Pkcs12Store store = new Pkcs12StoreBuilder().Build();

        //    // Add a Certificate entry
        //    var certEntry = new X509CertificateEntry(certificate);
        //    store.SetCertificateEntry(friendlyName, certEntry); // use DN as the Alias.
        //    //chainCerts.Add(certEntry);

        //    // Add chain entries
        //    var additionalCertsAsBytes = new List<byte[]>();
        //    if (!chainWithCas.IsNullOrEmpty())
        //    {
        //        additionalCertsAsBytes.AddRange(chainWithCas.Select(additionalCert => additionalCert.GetEncoded()));
        //    }

        //    var chainCerts = new List<X509CertificateEntry>();
        //    if (!chainWithCas.IsNullOrEmpty())
        //    {
        //        IEnumerable<X509Certificate> addicionalCertsAsX09Chain =
        //            BuildCertificateChainBc(certificate.GetEncoded(), additionalCertsAsBytes);

        //        foreach (X509Certificate addCertAsX09 in addicionalCertsAsX09Chain)
        //        {
        //            chainCerts.Add(new X509CertificateEntry(addCertAsX09));
        //        }
        //    }

        //    // Add a key entry
        //    var keyEntry = new AsymmetricKeyEntry(certKeyPair.Private);

        //    // no chain
        //    store.SetKeyEntry(friendlyName, keyEntry, new[] {certEntry});

        //    using (var memoryStream = new MemoryStream())
        //    {
        //        store.Save(memoryStream, pkcs12Password.ToCharArray(), GetSecureRandom());
        //        return memoryStream.ToArray();
        //    }
        //}

        //private static IEnumerable<X509Certificate> BuildCertificateChainBc(
        //    byte[] primary,
        //    IEnumerable<byte[]> additional)
        //{
        //    var parser = new X509CertificateParser();
        //    var builder = new PkixCertPathBuilder();

        //    // Separate root from itermediate
        //    var intermediateCerts = new List<X509Certificate>();
        //    var rootCerts = new HashSet();

        //    foreach (var cert in additional)
        //    {
        //        X509Certificate x509Cert = parser.ReadCertificate(cert);

        //        // Separate root and subordinate certificates
        //        if (x509Cert.IssuerDN.Equivalent(x509Cert.SubjectDN))
        //        {
        //            rootCerts.Add(new TrustAnchor(x509Cert, null));
        //        }
        //        else
        //        {
        //            intermediateCerts.Add(x509Cert);
        //        }
        //    }

        //    // Create chain for this certificate
        //    var holder = new X509CertStoreSelector
        //    {
        //        Certificate = parser.ReadCertificate(primary)
        //    };

        //    // WITHOUT THIS LINE BUILDER CANNOT BEGIN BUILDING THE CHAIN
        //    intermediateCerts.Add(holder.Certificate);

        //    var builderParams = new PkixBuilderParameters(rootCerts, holder)
        //    {
        //        IsRevocationEnabled = false
        //    };


        //    builderParams.AddStore(X509StoreFactory.Create("Certificate/Collection",
        //        new X509CollectionStoreParameters(intermediateCerts)));

        //    PkixCertPathBuilderResult result = builder.Build(builderParams);

        //    return result.CertPath.Certificates.Cast<X509Certificate>();
        //}

        public SecureRandom GetSecureRandom()
        {
            // Uso do CryptoAPI windows para geração de aleatórios.
            // À partide será mais eficaz que o BouncyCastle. 
            // Provavelmente usa hadware como fonte de entropia da geração
            return new SecureRandom(new CryptoApiRandomGenerator());
        }
    }
}