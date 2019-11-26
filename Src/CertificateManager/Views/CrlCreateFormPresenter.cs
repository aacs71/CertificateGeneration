using System;
using System.Windows.Forms;
using CertificateManager.Services;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace CertificateManager.Views
{
    public class CrlCreateFormPresenter : CrlCreateCrlPresenter<ICrlCreateView>
    {
        public bool Generate()
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = @"Crl files (*.crl)|*.crl|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string file = dlg.FileName;

                    var listGenerator = new DefaultCertificateRevocationListGenerator();

                    DateTime beginDate = View.From;
                    DateTime nextUpdateDate = beginDate.AddDays(View.NextUpdate);

                    X509Certificate caFile = IOPEMUtils.LoadPemCertificate(View.CAFile);
                    AsymmetricCipherKeyPair caPriveKeyFile = IOPEMUtils.LoadPemPrivateKey(View.CAPrivateKeyFile);

                    X509Crl result = listGenerator.Create(
                        View.Algoritm,
                        caFile,
                        caPriveKeyFile,
                        beginDate,
                        nextUpdateDate
                        );

                    IOPEMUtils.SavePemCrl(result, file);

                    MessageBox.Show(String.Format("Lista gravada em '{0}'", file), @"Informação",
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