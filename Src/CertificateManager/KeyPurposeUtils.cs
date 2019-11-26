using System;
using System.Linq;
using CertificateManager.Infrastructure;
using Org.BouncyCastle.Asn1.X509;

namespace CertificateManager
{
    public static class KeyPurposeUtils
    {
        public static KeyPurposeID[] All
        {
            get
            {
                return new[]
                {
                    KeyPurposeID.AnyExtendedKeyUsage,
                    KeyPurposeID.IdKPServerAuth,
                    KeyPurposeID.IdKPClientAuth,
                    KeyPurposeID.IdKPCodeSigning,
                    KeyPurposeID.IdKPEmailProtection,
                    KeyPurposeID.IdKPIpsecEndSystem,
                    KeyPurposeID.IdKPIpsecTunnel,
                    KeyPurposeID.IdKPIpsecUser,
                    KeyPurposeID.IdKPTimeStamping,
                    KeyPurposeID.IdKPOcspSigning,
                    KeyPurposeID.IdKPSmartCardLogon
                };
            }
        }

        public static bool HasKeyPurpose(this KeyPurposeID[] list, KeyPurposeID purpose)
        {
            return !list.IsNullOrEmpty() && list.Any(v => String.CompareOrdinal(v.Id, purpose.Id) == 0);
        }
    }
}