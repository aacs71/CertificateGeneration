using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;

namespace CertificateManager.UserControls
{
    public partial class KeyUsageControl : UserControl
    {
        public KeyUsageControl()
        {
            InitializeComponent();
            InitControls();
        }

        public KeyUsage Usage
        {
            get
            {
                int mask = 0x00;

                mask |= chkbDigitalSignature.Checked ? KeyUsage.DigitalSignature : 0x00;
                mask |= chkbNonRepudiation.Checked ? KeyUsage.NonRepudiation : 0x00;
                mask |= chkbKeyEncipherment.Checked ? KeyUsage.KeyEncipherment : 0x00;
                mask |= chkbDataEncipherment.Checked ? KeyUsage.DataEncipherment : 0x00;
                mask |= chkbKeyAgreement.Checked ? KeyUsage.KeyAgreement : 0x00;
                mask |= chkbKeyCertSign.Checked ? KeyUsage.KeyCertSign : 0x00;
                mask |= chkbCrlSign.Checked ? KeyUsage.CrlSign : 0x00;
                mask |= chkbEncipherOnly.Checked ? KeyUsage.EncipherOnly : 0x00;
                mask |= chkbDecipherOnly.Checked ? KeyUsage.DecipherOnly : 0x00;

                return mask == 0x00 ? null : new KeyUsage(mask);
            }
        }

        private void InitControls()
        {
            chkbKeyCertSign.Enabled =
                chkbKeyAgreement.Enabled =
                    chkbNonRepudiation.Enabled =
                        chkbDigitalSignature.Enabled =
                            chkbKeyEncipherment.Enabled =
                                chkbDataEncipherment.Enabled =
                                    chkbCrlSign.Enabled =
                                        chkbEncipherOnly.Enabled =
                                            chkbDecipherOnly.Enabled = false;
        }

        public void EnableControls(int mask)
        {
            chkbDigitalSignature.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.DigitalSignature);
            chkbNonRepudiation.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.NonRepudiation);
            chkbKeyEncipherment.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.KeyEncipherment);
            chkbDataEncipherment.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.DataEncipherment);
            chkbKeyAgreement.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.KeyAgreement);
            chkbKeyCertSign.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.KeyCertSign);
            chkbCrlSign.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.CrlSign);
            chkbEncipherOnly.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.EncipherOnly);
            chkbDecipherOnly.Enabled = KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.DecipherOnly);
        }

        public void CheckControls(int mask)
        {
            chkbDigitalSignature.Checked = chkbDigitalSignature.Enabled &&
                                           KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.DigitalSignature);
            chkbNonRepudiation.Checked = chkbNonRepudiation.Enabled &&
                                         KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.NonRepudiation);
            chkbKeyEncipherment.Checked = chkbKeyEncipherment.Enabled &&
                                          KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.KeyEncipherment);
            chkbDataEncipherment.Checked = chkbDataEncipherment.Enabled &&
                                           KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.DataEncipherment);
            chkbKeyAgreement.Checked = chkbKeyAgreement.Enabled &&
                                       KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.KeyAgreement);
            chkbKeyCertSign.Checked = chkbKeyCertSign.Enabled &&
                                      KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.KeyCertSign);
            chkbCrlSign.Checked = chkbCrlSign.Enabled && KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.CrlSign);
            chkbEncipherOnly.Checked = chkbEncipherOnly.Enabled &&
                                       KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.EncipherOnly);
            chkbDecipherOnly.Checked = chkbDecipherOnly.Enabled &&
                                       KeyUsageUtils.HasKeyUsageMask(mask, KeyUsage.DecipherOnly);
        }
    }
}