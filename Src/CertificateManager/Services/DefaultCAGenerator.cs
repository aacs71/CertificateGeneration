using System;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace CertificateManager.Services
{
    public class DefaultCAGenerator : AbstractCACertificateGenerator
    {
        public DefaultCAGenerator(IUrlEvaluator urlEvaluator) : base(urlEvaluator)
        {
        }

        protected override void AddSubjectAlternativeNames(X509V3CertificateGenerator certificateGenerator,
            IEnumerable<string> subjectAlternativeNames)
        {
            // para uma CA , nada
        }

        public CertificateResult Create(
            string algorithm,
            int keyLength,
            string subjectName,
            DateTime notBefore,
            DateTime notAfter,
            KeyUsage keyUsage,
            KeyPurposeID[] extendedUsages,
            CertificateEndPoints certificateEndPoints
            )
        {
            SecureRandom random = GenerateSecureRandom();
            AsymmetricCipherKeyPair subjectKeyPair = GenerateKeyPair(random, keyLength);
            BigInteger serialNumber = GenerateSerialNumber(random);

            // É auto-assinado, então são iguais.
            // Uma CA é um Self-signed certificate com a 'BasicConstraint' CA=true
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
                certificateEndPoints);

            return new CertificateResult(certificate, subjectKeyPair);
        }
    }
}