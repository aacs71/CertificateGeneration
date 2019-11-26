using System;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace CertificateManager.Services
{
    public class DefaultSubCAGenerator : AbstractCACertificateGenerator
    {
        public DefaultSubCAGenerator(IUrlEvaluator urlEvaluator) : base(urlEvaluator)
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
            X509Certificate caCertificate,
            AsymmetricCipherKeyPair caKeyPair,
            CertificateEndPoints certificateEndPoints
            )
        {
            SecureRandom random = GenerateSecureRandom();
            AsymmetricCipherKeyPair subjectKeyPair = GenerateKeyPair(random, keyLength);
            BigInteger serialNumber = GenerateSerialNumber(random);
            string caName = caCertificate.SubjectDN.ToString();

            X509Certificate certificate = GenerateCertificate(
                random,
                algorithm,
                subjectName,
                subjectKeyPair,
                serialNumber,
                null,
                notBefore,
                notAfter,
                caName,
                caKeyPair,
                keyUsage,
                extendedUsages,
                certificateEndPoints);

            return new CertificateResult(certificate, subjectKeyPair);
        }

        protected override void Setup(X509V3CertificateGenerator generator, CertificateEndPoints certificateEndPoints)
        {
            AddCertificateAuthorityBasicConstraints(generator);
            if (certificateEndPoints != null)
            {
                AddCrlDistributionPoint(generator, certificateEndPoints.CrlDistributionEndPoint);
                AddAuthorityDistributionEndPoint(generator, certificateEndPoints.CaDistributionEndPoint,
                    certificateEndPoints.OcspEndPoint);
            }
        }
    }
}