using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace CertificateManager.Services
{
    public static class CertificateUtils
    {
        public static string GetAuthorityKeyIdentifierFromCertificate(X509Certificate certificate)
        {
            Asn1OctetString authorityKeyIdentifierValue =
                certificate.GetExtensionValue(X509Extensions.AuthorityKeyIdentifier);
            if (authorityKeyIdentifierValue != null)
            {
                byte[] val = new AuthorityKeyIdentifierStructure(authorityKeyIdentifierValue).GetKeyIdentifier();
                if (val != null)
                {
                    return Hex.ToHexString(new BigInteger(val).ToByteArray());
                }
            }
            return null;
        }

        public static string GetSubjectKeyIdentifierFromCertificate(X509Certificate certificate)
        {
            Asn1OctetString sujectKeyIdentifierValue = certificate.GetExtensionValue(X509Extensions.SubjectKeyIdentifier);
            if (sujectKeyIdentifierValue != null)
            {
                var val = (Asn1OctetString) X509ExtensionUtilities.FromExtensionValue(sujectKeyIdentifierValue);
                if (val != null)
                {
                    return Hex.ToHexString(new BigInteger(val.GetOctets()).ToByteArray());
                }
            }
            return null;
        }

        public static string GetCrlNumber(X509Crl crl)
        {
            Asn1OctetString extVal = crl.GetExtensionValue(X509Extensions.CrlNumber);
            if (extVal == null)
            {
                return null;
            }

            BigInteger cn = DerInteger.GetInstance(
                X509ExtensionUtilities.FromExtensionValue(extVal)).PositiveValue;

            return cn.ToString();
        }

        public static TimeSpan CalculateUntilNextCrlRefreshInUtc(DateTime nowInUtc, TimeSpan nextScheduledRefresh)
        {
            // Necessitamos de converter o TimeSpan para "UTC"
            DateTime nextRefreshInUtc =
                new DateTime(
                    nowInUtc.Year,
                    nowInUtc.Month,
                    nowInUtc.Day,
                    nextScheduledRefresh.Hours,
                    nextScheduledRefresh.Minutes,
                    nextScheduledRefresh.Seconds).ToUniversalTime();

            var desiredUtcTime = new DateTime(
                nowInUtc.Year,
                nowInUtc.Month,
                nowInUtc.Day,
                nextRefreshInUtc.Hour,
                nextRefreshInUtc.Minute,
                nextRefreshInUtc.Second);

            TimeSpan result = nowInUtc >= nextRefreshInUtc
                ? (desiredUtcTime.AddDays(1) - nowInUtc)
                : desiredUtcTime - nowInUtc;

            return result;
        }

        public static DateTime CalculateNextCrlRefreshDate(DateTime nowInUtc, TimeSpan nextScheduledRefresh)
        {
            return nowInUtc.Add(CalculateUntilNextCrlRefreshInUtc(nowInUtc, nextScheduledRefresh));
        }

        public static AsymmetricKeyParameter PrivateKeyFrom(byte[] privateKeyContents)
        {
            return PrivateKeyFactory.CreateKey(privateKeyContents);
        }

        public static byte[] PrivateKeyAsByteArray(AsymmetricCipherKeyPair keyPair)
        {
            return PrivateKeyInfoFactory
                .CreatePrivateKeyInfo(keyPair.Private)
                .GetDerEncoded();
        }

        public static AsymmetricKeyParameter PublicKeyFrom(byte[] publicKeyContents)
        {
            return PublicKeyFactory.CreateKey(publicKeyContents);
        }

        public static byte[] PublicKeyAsByteArray(AsymmetricCipherKeyPair keyPair)
        {
            return SubjectPublicKeyInfoFactory
                .CreateSubjectPublicKeyInfo(keyPair.Public)
                .GetDerEncoded();
        }

        public static AsymmetricKeyParameter PublicKeyFromCertificate(X509Certificate certificate)
        {
            return certificate.GetPublicKey();
        }
    }
}