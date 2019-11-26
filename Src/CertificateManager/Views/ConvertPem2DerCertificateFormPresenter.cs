using System;
using System.Windows.Forms;
using CertificateManager.Infrastructure;
using CertificateManager.Services;
using Org.BouncyCastle.X509;

namespace CertificateManager.Views
{
    public interface IConvertPem2DerCertificateForm : IView
    {
        string CertificateFile { get; }
    }

    public class ConvertPem2DerCertificateFormPresenter : Presenter<IConvertPem2DerCertificateForm>
    {
        public bool Convert()
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = @"Der files (*.der)|*.der|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string file = dlg.FileName;

                    X509Certificate certificate = IOPEMUtils.LoadPemCertificate(View.CertificateFile);

                    IODERUtils.SaveEncodedCertificate(certificate, file);

                    MessageBox.Show(String.Format("Ficheiro gravado em '{0}'", file), @"Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                    return true;
                }

                return false;
            }
        }
    }
}