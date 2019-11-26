using Org.BouncyCastle.X509;

namespace CertificateManager
{
    public class KeyUsageUtils
    {
        public static int All
        {
            get
            {
                return X509KeyUsage.DigitalSignature
                       | X509KeyUsage.NonRepudiation
                       | X509KeyUsage.KeyEncipherment
                       | X509KeyUsage.DataEncipherment
                       | X509KeyUsage.KeyAgreement
                       | X509KeyUsage.KeyCertSign
                       | X509KeyUsage.CrlSign
                       | X509KeyUsage.EncipherOnly
                       | X509KeyUsage.DecipherOnly;
            }
        }

        public static bool HasKeyUsageMask(int value, int mask)
        {
            return (value & mask) == mask;
        }
    }
}