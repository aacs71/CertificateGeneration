using System;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace CertificateManager.Services
{
    public class DefaultSelfSignedCertificateGenerator : AbstractNonCACertificateGenerator
    {
        public DefaultSelfSignedCertificateGenerator() : base(null)
        {
        }

        protected override void AddSubjectAlternativeNames(X509V3CertificateGenerator certificateGenerator,
            IEnumerable<string> subjectAlternativeNames)
        {
            // Adição de 'Subject Alternative Names'
            // NOTA: tem que se repetir o 'Subject Name'
            // Serve para wildcards certificates. Tipo '*.dominio.com', 'dominio.com'
            var subjectAlternativeNamesExtension =
                new DerSequence(
                    subjectAlternativeNames.Select(name => new GeneralName(GeneralName.DnsName, name))
                        .ToArray<Asn1Encodable>());

            certificateGenerator.AddExtension(
                X509Extensions.SubjectAlternativeName.Id, false, subjectAlternativeNamesExtension);
        }


        public CertificateResult Create(
            string algorithm,
            int keyLength,
            string subjectName,
            DateTime notBefore,
            DateTime notAfter,
            KeyUsage keyUsage,
            KeyPurposeID[] extendedUsages
            )
        {
            SecureRandom random = GenerateSecureRandom();
            AsymmetricCipherKeyPair subjectKeyPair = GenerateKeyPair(random, keyLength);
            BigInteger serialNumber = GenerateSerialNumber(random);

            // É auto-assinado, então são iguais.
            // a diferença para uma CA's é que o 'BasicConstraint' CA=false
            string issuerName = subjectName;
            AsymmetricCipherKeyPair issuerKeyPair = subjectKeyPair;

            X509Certificate certificate = GenerateCertificate(
                random,
                algorithm,
                subjectName,
                subjectKeyPair,
                serialNumber,
                null,
                notBefore,
                notAfter,
                issuerName,
                issuerKeyPair,
                keyUsage,
                extendedUsages,
                null);

            return new CertificateResult(certificate, subjectKeyPair);
        }
    }
}