using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CertificateManager.Infrastructure;
using CertificateManager.Services;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace CertificateManager.Views
{
    public interface IUpdateCrlView : ICrlCreateView
    {
        int Reason { get; }
        string CrlListFile { get; }
        string[] CertificatesFilesToRevocate { get; }
    }

    public class UpdateCrlFormPresenter : CrlCreateCrlPresenter<IUpdateCrlView>
    {
        public bool Generate()
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = @"X.509 Crl files (*.crl)|*.crl|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string file = dlg.FileName;

                    var listGenerator = new DefaultCertificateRevocationListGenerator();

                    DateTime beginDate = View.From;
                    DateTime nextUpdateDate = beginDate.AddDays(View.NextUpdate);

                    X509Crl crlFile = IOPEMUtils.LoadPemCrl(View.CrlListFile);
                    X509Certificate caFile = IOPEMUtils.LoadPemCertificate(View.CAFile);
                    AsymmetricCipherKeyPair caPriveKeyFile = IOPEMUtils.LoadPemPrivateKey(View.CAPrivateKeyFile);

                    string[] certificatesFiles = View.CertificatesFilesToRevocate;
                    List<X509Certificate> certificatesToRevocate = null;
                    if (!certificatesFiles.IsStringListNullOrEmpty())
                    {
                        certificatesToRevocate = certificatesFiles.Select(IOPEMUtils.LoadPemCertificate).ToList();
                    }

                    X509Crl result = listGenerator.Update(
                        View.Algoritm,
                        crlFile,
                        certificatesToRevocate.IsNullOrEmpty() ? null : certificatesToRevocate.ToArray(),
                        caFile,
                        caPriveKeyFile,
                        beginDate,
                        nextUpdateDate,
                        View.Reason
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