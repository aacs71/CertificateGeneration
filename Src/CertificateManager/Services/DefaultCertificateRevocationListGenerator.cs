using System;
using CertificateManager.Infrastructure;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace CertificateManager.Services
{
    public class DefaultCertificateRevocationListGenerator
    {
        // LISTA vazia .....
        public X509Crl Create(
            string algorithm,
            X509Certificate caCert,
            AsymmetricCipherKeyPair caKey,
            DateTime thisUpdate,
            DateTime nextUpdate)
        {
            var crlGenerator = new X509V2CrlGenerator();

            crlGenerator.SetIssuerDN(PrincipalUtilities.GetSubjectX509Principal(caCert));

            crlGenerator.SetThisUpdate(thisUpdate);
            crlGenerator.SetNextUpdate(nextUpdate);

            var signatureFactory = new Asn1SignatureFactory(
                algorithm,
                caKey.Private);

            crlGenerator.AddExtension(X509Extensions.AuthorityKeyIdentifier, false,
                new AuthorityKeyIdentifierStructure(caCert));
            crlGenerator.AddExtension(X509Extensions.CrlNumber, false, new CrlNumber(BigInteger.One));

            return crlGenerator.Generate(signatureFactory);
        }

        public X509Crl Update(
            string algorithm,
            X509Crl existingCrl,
            X509Certificate[] certificates,
            X509Certificate caCert,
            AsymmetricCipherKeyPair caKey,
            DateTime thisUpdate,
            DateTime nextUpdate,
            int /*CrlReason*/ reason)
        {
            var crlGenerator = new X509V2CrlGenerator();

            crlGenerator.SetIssuerDN(PrincipalUtilities.GetSubjectX509Principal(caCert));

            crlGenerator.SetThisUpdate(thisUpdate);
            crlGenerator.SetNextUpdate(nextUpdate);

            var signatureFactory = new Asn1SignatureFactory(
                algorithm,
                caKey.Private);

            crlGenerator.AddCrl(existingCrl);

            if (!certificates.IsNullOrEmpty())
            {
                foreach (X509Certificate certificate in certificates)
                {
                    // a ver... a questão da CrlRerason... pode ser individual ?!?!?!
                    crlGenerator.AddCrlEntry(certificate.SerialNumber, thisUpdate, reason);
                }
            }

            crlGenerator.AddExtension(X509Extensions.AuthorityKeyIdentifier, false,
                new AuthorityKeyIdentifierStructure(caCert));

            BigInteger existingCrlNumber = DerInteger.GetInstance(
                Asn1Object.FromByteArray(existingCrl.GetExtensionValue(X509Extensions.CrlNumber).GetOctets())
                ).PositiveValue;

            crlGenerator.AddExtension(
                X509Extensions.CrlNumber, false, new CrlNumber(existingCrlNumber.Add(BigInteger.One)));

            return crlGenerator.Generate(signatureFactory);
        }

        public SecureRandom GetSecureRandom()
        {
            // Uso do CryptoAPI windows para geração de aleatórios.
            // À partide será mais eficaz que o BouncyCastle. 
            // Provavelmente usa hadware como fonte de entropia da geração
            return new SecureRandom(new CryptoApiRandomGenerator());
        }
    }
}