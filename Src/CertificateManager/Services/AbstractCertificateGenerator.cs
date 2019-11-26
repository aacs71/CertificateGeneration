using System;
using System.Collections.Generic;
using CertificateManager.Infrastructure;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509;

namespace CertificateManager.Services
{
    public class CertificateEndPoints
    {
        public string CaDistributionEndPoint { get; set; }
        public string CrlDistributionEndPoint { get; set; }
        public string OcspEndPoint { get; set; }
    }

    public class CertificateResult
    {
        public CertificateResult(X509Certificate certificate, AsymmetricCipherKeyPair keyPair)
        {
            Certificate = certificate;
            KeyPair = keyPair;
        }

        public X509Certificate Certificate { get; private set; }
        public AsymmetricCipherKeyPair KeyPair { get; private set; }
    }

    public abstract class AbstractCertificateGenerator
    {
        private readonly IUrlEvaluator _urlEvaluator;

        protected AbstractCertificateGenerator(IUrlEvaluator urlEvaluator)
        {
            _urlEvaluator = urlEvaluator;
        }

        protected abstract void Setup(X509V3CertificateGenerator generator, CertificateEndPoints endPoints);

        protected X509Certificate GenerateCertificate(
            SecureRandom random,
            string algorithm,
            string subjectName,
            AsymmetricCipherKeyPair subjectKeyPair,
            BigInteger subjectSerialNumber,
            string[] subjectAlternativeNames,
            DateTime notBefore,
            DateTime notAfter,
            string issuerName,
            AsymmetricCipherKeyPair issuerKeyPair,
            KeyUsage keyUsage,
            KeyPurposeID[] usages,
            CertificateEndPoints certificateEndPoints)
        {
            var certificateGenerator = new X509V3CertificateGenerator();

            certificateGenerator.SetSerialNumber(subjectSerialNumber);

            // Key emite o certificado
            X509Name issuerDN = BuildDistinguishedName(issuerName);
            certificateGenerator.SetIssuerDN(issuerDN);

            // Nota: Pode ser omitido se for indicado o 'subject alternative name' (SAN).
            certificateGenerator.SetSubjectDN(BuildDistinguishedName(subjectName));

            // CIUDADO !!!! tempo em UTC!!!!!!
            certificateGenerator.SetNotBefore(notBefore);
            // CIUDADO !!!! tempo em UTC!!!!!!
            certificateGenerator.SetNotAfter(notAfter);

            // A chave pública do emissor é incluida no certificado..
            certificateGenerator.SetPublicKey(subjectKeyPair.Public);

            // Secção 4.2.1.1, Authority Key Identifier pode ser omitido em CA´s. 
            // No nosso caso para as CA's emitidas, o KeyId será igual ao seu subjectid
            AddAuthorityKeyIdentifier(certificateGenerator, issuerKeyPair);
            AddSubjectKeyIdentifier(certificateGenerator, subjectKeyPair);

            if (certificateEndPoints != null)
            {
                CertificateUrlTemplateBindModel urlTemplateBindModel = BuildUrlTemplateBindModel(
                    subjectName,
                    subjectName,
                    issuerName,
                    new SubjectKeyIdentifier(
                        SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(subjectKeyPair.Public)),
                    new AuthorityKeyIdentifier(
                        SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(issuerKeyPair.Public)),
                    subjectSerialNumber,
                    notBefore,
                    notAfter
                    );
                certificateEndPoints.CaDistributionEndPoint = EvaluateUrl(urlTemplateBindModel,
                    certificateEndPoints.CaDistributionEndPoint);
                certificateEndPoints.CrlDistributionEndPoint = EvaluateUrl(urlTemplateBindModel,
                    certificateEndPoints.CrlDistributionEndPoint);
                certificateEndPoints.OcspEndPoint = EvaluateUrl(urlTemplateBindModel,
                    certificateEndPoints.OcspEndPoint);
            }

            // VER
            AddPolicies(certificateGenerator);

            Setup(certificateGenerator, certificateEndPoints);

            if (keyUsage != null)
            {
                AddKeyUsage(certificateGenerator, keyUsage);
            }

            if (!usages.IsNullOrEmpty())
            {
                AddExtendedKeyUsage(certificateGenerator, usages);
            }

            if (!subjectAlternativeNames.IsStringListNullOrEmpty())
            {
                AddSubjectAlternativeNames(certificateGenerator, subjectAlternativeNames);
            }

            // Assinar o certificado com a chave privada do emissor.
            return certificateGenerator.Generate(
                new Asn1SignatureFactory(
                    algorithm,
                    issuerKeyPair.Private
                    ));
        }

        protected X509Name BuildDistinguishedName(string name)
        {
            return name.Contains("=") // presume-se que o formato está do tipo: "CN=teste, dc=teste2"
                ? new X509Name(name)
                : new X509Name(new[] {X509Name.CN}, new[] {name});
        }

        protected SecureRandom GenerateSecureRandom()
        {
            // Uso do CryptoAPI windows para geração de aleatórios.
            // À partide será mais eficaz que o BouncyCastle. 
            // Provavelmente usa hadware como fonte de entropia da geração
            return new SecureRandom(new CryptoApiRandomGenerator());
        }

        protected AsymmetricCipherKeyPair GenerateKeyPair(SecureRandom random, int strength)
        {
            // Geração do par de chaves (privada e pública)
            // atenção para a "strength" da classe 'KeyGenerationParameters'. Deverá ser forte. 2048 ou superior.
            var keyPairGenerator = new RsaKeyPairGenerator();
            keyPairGenerator.Init(new KeyGenerationParameters(random, strength));

            return keyPairGenerator.GenerateKeyPair();
        }

        protected BigInteger GenerateSerialNumber(SecureRandom random)
        {
            // Nº série obrigatório. Especialmente para revogações.
            // Em geral é um número sequencial para facilitar revogações em lote.
            // Não havendo um mecanismo para persistir o número, geramos um aleatório.
            return BigIntegers.CreateRandomInRange(BigInteger.One, BigInteger.ValueOf(Int64.MaxValue), random);
        }

        #region Add Extensions

        protected void AddAuthorityKeyIdentifier(
            X509V3CertificateGenerator certificateGenerator,
            X509Name issuerDN,
            AsymmetricCipherKeyPair issuerKeyPair,
            BigInteger issuerSerialNumber)
        {
            // Indica qual a CA que assinou o certificado. Apenas faz sentido para certificados que não sejam CA's
            // RFC2459, Secção 4.2.1.1. Neste caso foi adoptado IssuerName + SerialNumber
            // Nota: pode ser um problema no caso de se recriar a CA
            // Ver: https://www.v13.gr/blog/?p=293

            // Add the Authority Key Identifier. According to http://www.alvestrand.no/objectid/2.5.29.35.html, this
            // identifies the public key to be used to verify the signature on this certificate.
            // In a certificate chain, this corresponds to the "Subject Key Identifier" on the *issuer* certificate.
            // The Bouncy Castle documentation, at http://www.bouncycastle.org/wiki/display/JA1/X.509+Public+Key+Certificate+and+Certification+Request+Generation,
            // shows how to create this from the issuing certificate. Since we're creating a self-signed certificate, we have to do this slightly differently.

            var authorityKeyIdentifierExtension =
                new AuthorityKeyIdentifier(
                    SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(issuerKeyPair.Public),
                    new GeneralNames(new GeneralName(issuerDN)), issuerSerialNumber);
            certificateGenerator.AddExtension(
                X509Extensions.AuthorityKeyIdentifier.Id, false, authorityKeyIdentifierExtension);
        }

        protected void AddAuthorityKeyIdentifier(
            X509V3CertificateGenerator certificateGenerator,
            AsymmetricCipherKeyPair issuerKeyPair)
        {
            // Apenas adicionando KeyId.
            // Razões: ver outra implementação 
            // a maioria das entidades certificadoras apenas usam KeyID
            certificateGenerator.AddExtension(
                X509Extensions.AuthorityKeyIdentifier.Id,
                false,
                new AuthorityKeyIdentifier(
                    SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(issuerKeyPair.Public))
                );
        }

        protected void AddSubjectKeyIdentifier(X509V3CertificateGenerator certificateGenerator,
            AsymmetricCipherKeyPair subjectKeyPair)
        {
            // Subject Key Identifier, usado para facilitar a validação de certificados.
            // Em CA são gerados, em geral, a partir da sua chave pública.
            // Secção 4.2.1.2 do http://www.ietf.org/rfc/rfc3280.txt
            var subjectKeyIdentifierExtension =
                new SubjectKeyIdentifier(
                    SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(subjectKeyPair.Public));
            certificateGenerator.AddExtension(
                X509Extensions.SubjectKeyIdentifier.Id, false, subjectKeyIdentifierExtension);
        }

        protected abstract void AddSubjectAlternativeNames(X509V3CertificateGenerator certificateGenerator,
            IEnumerable<string> subjectAlternativeNames);


        protected void AddKeyUsage(X509V3CertificateGenerator certificateGenerator, KeyUsage keyUsage)
        {
            // Adição de 'Key Usage'. Por Ex: 'server authentication'
            certificateGenerator.AddExtension(
                X509Extensions.KeyUsage.Id, true, keyUsage);
        }

        protected void AddExtendedKeyUsage(X509V3CertificateGenerator certificateGenerator, KeyPurposeID[] usages)
        {
            // Adição de 'Extended Key Usage'. Por Ex: 'server authentication'
            certificateGenerator.AddExtension(
                X509Extensions.ExtendedKeyUsage.Id, false, new ExtendedKeyUsage(usages));
        }

        protected void AddPathLengthBasicConstraints(X509V3CertificateGenerator certificateGenerator,
            int lengthContraint)
        {
            // Adição de 'BasicConstraints'. 
            // NOTA: o path length constraint que se pode definir (parametro int) define a profundidade máxima da cadeia de sub CA's
            certificateGenerator.AddExtension(
                X509Extensions.BasicConstraints.Id, true, new BasicConstraints(lengthContraint));
        }


        protected void AddEndEntityBasicConstraints(X509V3CertificateGenerator certificateGenerator)
        {
            // Adição de 'BasicConstraints'. 
            // NOTA: neste caso a 'BasicConstraint' é CA = false para indicar que o certificado é uma entidade final
            certificateGenerator.AddExtension(
                X509Extensions.BasicConstraints.Id, true, new BasicConstraints(false));
        }

        protected void AddCrlDistributionPoint(X509V3CertificateGenerator certificateGenerator, string uri)
        {
            if (!String.IsNullOrWhiteSpace(uri))
            {
                // Adição de Ponto de distribuição da crl. 
                var crlDistributionPoint = new CrlDistPoint(new[]
                {
                    new DistributionPoint(
                        new DistributionPointName(
                            new GeneralNames(
                                new GeneralName(
                                    GeneralName.UniformResourceIdentifier, uri))),
                        null, null)
                });

                certificateGenerator.AddExtension(
                    X509Extensions.CrlDistributionPoints.Id, false, crlDistributionPoint);
            }
        }

        protected void AddAuthorityDistributionEndPoint(X509V3CertificateGenerator certificateGenerator, string uriCA,
            string uriOcsp)
        {
            // tem que ser colocada de uma só vez....
            var info = new Asn1EncodableVector();
            if (!String.IsNullOrWhiteSpace(uriCA))
            {
                var ca = new AccessDescription(AccessDescription.IdADCAIssuers,
                    new GeneralName(GeneralName.UniformResourceIdentifier, uriCA));
                info.Add(ca);
            }
            if (!String.IsNullOrWhiteSpace(uriOcsp))
            {
                var ocsp = new AccessDescription(AccessDescription.IdADOcsp,
                    new GeneralName(GeneralName.UniformResourceIdentifier, uriOcsp));
                info.Add(ocsp);
            }

            if (info.Count > 0)
            {
                certificateGenerator.AddExtension(
                    X509Extensions.AuthorityInfoAccess,
                    false,
                    new DerSequence(info));
            }
        }

        protected void AddPolicies(X509V3CertificateGenerator certificateGenerator)
        {
            //var certPolicies = new PolicyInformation[2];
            //certPolicies[0] = new PolicyInformation(new DerObjectIdentifier("2.16.840.1.101.2.1.11.5"));
            //certPolicies[1] = new PolicyInformation(new DerObjectIdentifier("2.16.840.1.101.2.1.11.18"));

            //certificateGenerator.AddExtension(X509Extensions.CertificatePolicies, false,
            //    new CertificatePolicies(certPolicies));
        }

        protected void AddCustomComment(X509V3CertificateGenerator certificateGenerator, string comment)
        {
            certificateGenerator.AddExtension(
                MiscObjectIdentifiers.NetscapeCertComment,
                false, new DerIA5String(comment));
        }

        #endregion

        #region UrlEvaluation

        private CertificateUrlTemplateBindModel BuildUrlTemplateBindModel(
            string name,
            string subject,
            string issuer,
            SubjectKeyIdentifier keyId,
            AuthorityKeyIdentifier issuerId,
            BigInteger serialNumber,
            DateTime notBefore,
            DateTime notAfter)
        {
            string idSubject = Hex.ToHexString(new BigInteger(keyId.GetKeyIdentifier()).ToByteArray());
            string idIssuer = Hex.ToHexString(new BigInteger(issuerId.GetKeyIdentifier()).ToByteArray());
            return new CertificateUrlTemplateBindModel(
                name,
                subject,
                issuer,
                idSubject,
                idIssuer,
                serialNumber.ToString(),
                notBefore,
                notAfter);
        }

        private string EvaluateUrl(
            CertificateUrlTemplateBindModel model,
            string uri
            )
        {
            return _urlEvaluator == null
                ? uri
                : (String.IsNullOrWhiteSpace(uri) ? null : _urlEvaluator.Evaluate(uri, model));
        }

        #endregion
    }

    public abstract class AbstractCACertificateGenerator : AbstractCertificateGenerator
    {
        protected AbstractCACertificateGenerator(IUrlEvaluator urlEvaluator) : base(urlEvaluator)
        {
        }

        protected override void Setup(X509V3CertificateGenerator generator, CertificateEndPoints certificateEndPoints)
        {
            AddCertificateAuthorityBasicConstraints(generator);
            if (certificateEndPoints != null)
            {
                AddCrlDistributionPoint(generator, certificateEndPoints.CrlDistributionEndPoint);
                AddAuthorityDistributionEndPoint(generator, null, certificateEndPoints.OcspEndPoint);
            }
        }

        protected void AddCertificateAuthorityBasicConstraints(X509V3CertificateGenerator certificateGenerator)
        {
            // Adição de 'BasicConstraints'. 
            // NOTA: neste caso a 'BasicConstraint' é CA = true para indicar que o certificado é uma CA
            certificateGenerator.AddExtension(
                X509Extensions.BasicConstraints.Id, true, new BasicConstraints(true));
        }
    }

    public abstract class AbstractNonCACertificateGenerator : AbstractCertificateGenerator
    {
        protected AbstractNonCACertificateGenerator(IUrlEvaluator urlEvaluator) : base(urlEvaluator)
        {
        }

        protected override void Setup(X509V3CertificateGenerator generator, CertificateEndPoints certificateEndPoints)
        {
            AddEndEntityBasicConstraints(generator);
            if (certificateEndPoints != null)
            {
                AddCrlDistributionPoint(generator, certificateEndPoints.CrlDistributionEndPoint);
                AddAuthorityDistributionEndPoint(
                    generator,
                    certificateEndPoints.CaDistributionEndPoint,
                    certificateEndPoints.OcspEndPoint);
            }
        }
    }
}