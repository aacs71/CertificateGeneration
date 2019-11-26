using System;
using System.Windows.Forms;
using CertificateManager.Services;

namespace CertificateManager.Views
{
    public interface ISelfSignedCreateFormView : ICertificateCreateView
    {
    }

    public class SelfSignedCreateFormPresenter : CertificateCreatePresenter<ISelfSignedCreateFormView>
    {
        public override void OnViewReady()
        {
            base.OnViewReady();

            View.AvailableKeyUsage = KeyUsageUtils.All;
            View.DefaultKeyUsage = Constants.DefaultSelfSignedKeyMask;
            View.AvailablePurpose = KeyPurposeUtils.All;
            View.DefaultPurpose = Constants.DefaultSelfSignedExtendUsages;
        }

        public bool Generate()
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter =
                    @"X.509 Certificate files (*.cer;*.crt;*.cert;*.pem)|*.cer;*.crt;*.cert;*.pem|Pem files (*.pem)|*.pem|Crt files (*.crt)|*.crt|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var certificateGenerator = new DefaultSelfSignedCertificateGenerator();

                    DateTime beginDate = View.From;
                    DateTime endDate = beginDate.AddDays(View.Duration);
                    CertificateResult result = certificateGenerator.Create(
                        View.Algoritm,
                        View.KeyLength,
                        View.Subject,
                        beginDate,
                        endDate,
                        View.KeyUsage,
                        View.Purpose
                        );

                    ResultFileNames files = IOPEMUtils.SaveCertificateAndPrivateKey(result.Certificate, result.KeyPair,
                        dlg.FileName);

                    MessageBox.Show(
                        String.Format("Foram gravados os ficheiros:\nCertificado como '{0}'\nChave privada como '{1}'",
                            files.Certificate,
                            files.PrivateKey), @"Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                    return true;
                }
            }

            return false;
        }
    }
}