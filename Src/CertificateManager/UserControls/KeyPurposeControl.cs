using System.Collections.Generic;
using System.Windows.Forms;
using CertificateManager.Infrastructure;
using Org.BouncyCastle.Asn1.X509;

namespace CertificateManager.UserControls
{
    public partial class KeyPurposeControl : UserControl
    {
        public KeyPurposeControl()
        {
            InitializeComponent();
            InitControls();
        }

        public KeyPurposeID[] Purposes
        {
            get
            {
                var list = new List<KeyPurposeID>();

                if (chkbIdKPOcspSigning.Checked)
                {
                    list.Add(KeyPurposeID.IdKPOcspSigning);
                }
                if (chkbIdKPTimeStamping.Checked)
                {
                    list.Add(KeyPurposeID.IdKPTimeStamping);
                }
                if (chkbIdKPIpsecUser.Checked)
                {
                    list.Add(KeyPurposeID.IdKPIpsecUser);
                }
                if (chkbIdKPEmailProtection.Checked)
                {
                    list.Add(KeyPurposeID.IdKPEmailProtection);
                }
                if (chkbIdKPCodeSigning.Checked)
                {
                    list.Add(KeyPurposeID.IdKPCodeSigning);
                }
                if (chkbIdKPIpsecTunnel.Checked)
                {
                    list.Add(KeyPurposeID.IdKPIpsecTunnel);
                }
                if (chkbIdKPIpsecEndSystem.Checked)
                {
                    list.Add(KeyPurposeID.IdKPIpsecEndSystem);
                }
                if (chkbIdKPClientAuth.Checked)
                {
                    list.Add(KeyPurposeID.IdKPClientAuth);
                }
                if (chkbIdKPServerAuth.Checked)
                {
                    list.Add(KeyPurposeID.IdKPServerAuth);
                }
                if (chkbIdKPSmartCardLogon.Checked)
                {
                    list.Add(KeyPurposeID.IdKPSmartCardLogon);
                }
                if (chkbAnyExtendedKeyUsage.Checked)
                {
                    list.Add(KeyPurposeID.AnyExtendedKeyUsage);
                }

                return list.IsNullOrEmpty() ? null : list.ToArray();
            }
        }

        private void InitControls()
        {
            chkbIdKPOcspSigning.Enabled =
                chkbIdKPTimeStamping.Enabled =
                    chkbIdKPIpsecUser.Enabled =
                        chkbIdKPEmailProtection.Enabled =
                            chkbIdKPCodeSigning.Enabled =
                                chkbIdKPIpsecTunnel.Enabled =
                                    chkbIdKPIpsecEndSystem.Enabled =
                                        chkbIdKPClientAuth.Enabled =
                                            chkbIdKPServerAuth.Enabled =
                                                chkbIdKPSmartCardLogon.Enabled =
                                                    chkbAnyExtendedKeyUsage.Enabled = false;
        }


        public void EnableControls(KeyPurposeID[] purposes)
        {
            chkbIdKPOcspSigning.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPOcspSigning);
            chkbIdKPTimeStamping.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPTimeStamping);
            chkbIdKPIpsecUser.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPIpsecUser);
            chkbIdKPEmailProtection.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPEmailProtection);
            chkbIdKPCodeSigning.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPCodeSigning);
            chkbIdKPIpsecTunnel.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPIpsecTunnel);
            chkbIdKPIpsecEndSystem.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPIpsecEndSystem);
            chkbIdKPClientAuth.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPClientAuth);
            chkbIdKPServerAuth.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPServerAuth);
            chkbIdKPSmartCardLogon.Enabled = purposes.HasKeyPurpose(KeyPurposeID.IdKPSmartCardLogon);
            chkbAnyExtendedKeyUsage.Enabled = purposes.HasKeyPurpose(KeyPurposeID.AnyExtendedKeyUsage);
        }

        public void CheckControls(KeyPurposeID[] purposes)
        {
            chkbIdKPOcspSigning.Checked = chkbIdKPOcspSigning.Enabled &&
                                          purposes.HasKeyPurpose(KeyPurposeID.IdKPOcspSigning);
            chkbIdKPTimeStamping.Checked = chkbIdKPTimeStamping.Enabled &&
                                           purposes.HasKeyPurpose(KeyPurposeID.IdKPTimeStamping);
            chkbIdKPIpsecUser.Checked = chkbIdKPIpsecUser.Enabled && purposes.HasKeyPurpose(KeyPurposeID.IdKPIpsecUser);
            chkbIdKPEmailProtection.Checked = chkbIdKPEmailProtection.Enabled &&
                                              purposes.HasKeyPurpose(KeyPurposeID.IdKPEmailProtection);
            chkbIdKPCodeSigning.Checked = chkbIdKPCodeSigning.Enabled &&
                                          purposes.HasKeyPurpose(KeyPurposeID.IdKPCodeSigning);
            chkbIdKPIpsecTunnel.Checked = chkbIdKPIpsecTunnel.Enabled &&
                                          purposes.HasKeyPurpose(KeyPurposeID.IdKPIpsecTunnel);
            chkbIdKPIpsecEndSystem.Checked = chkbIdKPIpsecEndSystem.Enabled &&
                                             purposes.HasKeyPurpose(KeyPurposeID.IdKPIpsecEndSystem);
            chkbIdKPClientAuth.Checked = chkbIdKPClientAuth.Enabled &&
                                         purposes.HasKeyPurpose(KeyPurposeID.IdKPClientAuth);
            chkbIdKPServerAuth.Checked = chkbIdKPServerAuth.Enabled &&
                                         purposes.HasKeyPurpose(KeyPurposeID.IdKPServerAuth);
            chkbIdKPSmartCardLogon.Checked = chkbIdKPSmartCardLogon.Enabled &&
                                             purposes.HasKeyPurpose(KeyPurposeID.IdKPSmartCardLogon);
            chkbAnyExtendedKeyUsage.Checked = chkbAnyExtendedKeyUsage.Enabled &&
                                              purposes.HasKeyPurpose(KeyPurposeID.AnyExtendedKeyUsage);
        }
    }
}