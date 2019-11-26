using System;
using System.IO;
using System.Windows.Forms;
using CertificateManager.Infrastructure;
using CertificateManager.Services;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace CertificateManager.Views
{
    public interface IConvertPem2Pkcs12CertificateView : IView
    {
        string[] CasFiles { get; }
        string CertificateFile { get; }
        string CertificatePrivateKeyFile { get; }
        string Pkcs12Password { get; }
        string Pkcs12PasswordConfirmation { get; }
    }

    public class ConvertPem2Pkcs12CertificateFormPresenter : Presenter<IConvertPem2Pkcs12CertificateView>
    {
        public bool Convert()
        {
            string password = View.Pkcs12Password;
            string confirmPassword = View.Pkcs12PasswordConfirmation;

            if (String.CompareOrdinal(password, confirmPassword) != 0)
            {
                MessageBox.Show(@"A password e confirmação não coincidem", @"Passwords",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = @"Pfx files (*.pfx)|*.pfx|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string file = dlg.FileName;

                    var storeGenerator = new DefaultPkcs12StoreGenerator();

                    X509Certificate certificateFile = IOPEMUtils.LoadPemCertificate(View.CertificateFile);
                    AsymmetricCipherKeyPair certificatePriveKeyFile =
                        IOPEMUtils.LoadPemPrivateKey(View.CertificatePrivateKeyFile);

                    try
                    {
                        byte[] result = storeGenerator.Create(certificateFile, certificatePriveKeyFile, password,
                            View.CasFiles);

                        File.WriteAllBytes(file, result);

                        MessageBox.Show(String.Format("Lista gravada em '{0}'", file), @"Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        return true;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, @"Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }

                return false;
            }
        }
    }
}