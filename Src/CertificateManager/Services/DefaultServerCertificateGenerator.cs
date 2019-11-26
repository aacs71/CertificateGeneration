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
    public class DefaultServerCertificateGenerator : AbstractNonCACertificateGenerator
    {
        public DefaultServerCertificateGenerator(IUrlEvaluator urlEvaluator) : base(urlEvaluator)
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
            string algorith,
            int keyLength,
            string subjectName,
            string[] subjectAlternativeNames,
            DateTime notBefore,
            DateTime notAfter,
            KeyUsage keyUsage,
            KeyPurposeID[] extendedUsages,
            X509Certificate issuerCertificate,
            AsymmetricCipherKeyPair issuerKeyPair,
            CertificateEndPoints certificateEndPoints
            )
        {
            SecureRandom random = GenerateSecureRandom();
            AsymmetricCipherKeyPair subjectKeyPair = GenerateKeyPair(random, keyLength);
            BigInteger serialNumber = GenerateSerialNumber(random);
            string issuerName = issuerCertificate.SubjectDN.ToString();

            X509Certificate certificate = GenerateCertificate(
                random,
                algorith,
                subjectName,
                subjectKeyPair,
                serialNumber,
                subjectAlternativeNames,
                notBefore,
                notAfter,
                issuerName,
                issuerKeyPair,
                keyUsage,
                extendedUsages,
                certificateEndPoints);

            return new CertificateResult(certificate, subjectKeyPair);
        }
    }
}