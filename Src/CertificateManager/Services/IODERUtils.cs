using System.IO;
using Org.BouncyCastle.X509;

namespace CertificateManager.Services
{
    public static class IODERUtils
    {
        public static byte[] EncodedCertificate(X509Certificate certificate)
        {
            return certificate.GetEncoded();
        }

        public static void SaveEncodedCertificate(X509Certificate certificate, string file)
        {
            File.WriteAllBytes(file, EncodedCertificate(certificate));
        }

        public static X509Certificate ReadDerCertificateFrom(byte[] certificateContents)
        {
            return new X509CertificateParser().ReadCertificate(certificateContents);
        }

        public static X509Certificate ReadDerCertificateFrom(string certificateFile)
        {
            return ReadDerCertificateFrom(File.ReadAllBytes(certificateFile));
        }

        public static byte[] EncodedCrl(X509Crl crl)
        {
            return crl.GetEncoded();
        }

        public static X509Crl ReadCrlFrom(byte[] crlContents)
        {
            return new X509CrlParser().ReadCrl(crlContents);
        }

        public static X509Crl ReadCrlFrom(string crlFile)
        {
            return ReadCrlFrom(File.ReadAllBytes(crlFile));
        }
    }
}