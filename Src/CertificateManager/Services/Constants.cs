using Org.BouncyCastle.Asn1.X509;

namespace CertificateManager.Services
{
    public class Constants
    {
        // Comprimento da chave. Nesta data considerada o minimo aceitável
        public const int DEFAULT_KEY_LENGTH = 2048;

        // Algoritmo para assinatura. 'SHA-256' considerado forte.
        public const string DEFAULT_SIGNATURE_ALGORITHM = "SHA256WITHRSA";

        // Próximo update
        public const int DEFAULT_CRL_NEXT_UPDATE_DAYS = 1;

        #region CA

        // *******======== CA 
        // KEY USAGES
        public const int DefaulCAKeyUsageMask = KeyUsage.DigitalSignature |
                                                KeyUsage.NonRepudiation |
                                                KeyUsage.KeyCertSign |
                                                KeyUsage.CrlSign;

        // purposes
        public static readonly KeyPurposeID[] DefaultCAExtendUsages =
        {
            KeyPurposeID.IdKPServerAuth,
            KeyPurposeID.IdKPClientAuth,
            KeyPurposeID.IdKPSmartCardLogon,
            KeyPurposeID.IdKPTimeStamping
        };

        // *******======== FIM CA 

        #endregion

        #region Self Signed

        // *******======== SELF SIGNED 
        // quase como uma CA, excepto assinaturas de certificados o CRL's
        public const int DefaultSelfSignedKeyMask = KeyUsage.DigitalSignature |
                                                    KeyUsage.NonRepudiation |
                                                    KeyUsage.KeyEncipherment |
                                                    KeyUsage.DataEncipherment;

        public static readonly KeyPurposeID[] DefaultSelfSignedExtendUsages =
        {
            KeyPurposeID.IdKPServerAuth,
            KeyPurposeID.IdKPClientAuth,
            KeyPurposeID.IdKPEmailProtection,
            KeyPurposeID.IdKPSmartCardLogon,
            KeyPurposeID.IdKPTimeStamping
        };

        // *******======== FIM SELF SIGNED 

        #endregion

        #region Server Certificates

        // ******* SERVER Certificates
        public const int DefaultServerKeyUsage = KeyUsage.DigitalSignature | KeyUsage.KeyEncipherment;

        public static readonly KeyPurposeID[] DefaultServerExtendUsages =
        {
            KeyPurposeID.IdKPServerAuth,
            KeyPurposeID.IdKPTimeStamping
        };

        #endregion

        #region Client Certificate

        // ******* SERVER Certificates
        public const int DefaultClientKeyUsage = KeyUsage.DigitalSignature | KeyUsage.KeyEncipherment;

        public static readonly KeyPurposeID[] DefaultClientExtendUsages =
        {
            KeyPurposeID.IdKPClientAuth,
            KeyPurposeID.IdKPSmartCardLogon,
            KeyPurposeID.IdKPTimeStamping
        };

        #endregion
    }
}