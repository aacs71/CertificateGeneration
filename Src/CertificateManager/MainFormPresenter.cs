using CertificateManager.Infrastructure;
using CertificateManager.Views;

namespace CertificateManager
{
    public interface IMainViewForm : IView
    {
    }

    public class MainFormPresenter : Presenter<IMainViewForm>
    {
        public void GenerateCA()
        {
            using (var dlg = new CACreateForm(new CACreateFormPresenter()))
            {
                dlg.ShowDialog();
            }
        }

        public void GenerateSelfSigned()
        {
            using (var dlg = new SelfSignedCreateForm(new SelfSignedCreateFormPresenter()))
            {
                dlg.ShowDialog();
            }
        }

        public void GenerateSubCA()
        {
            using (var dlg = new SubCACreateForm(new SubCACreateFormPresenter()))
            {
                dlg.ShowDialog();
            }
        }

        public void GenerateServerCertificate()
        {
            using (var dlg = new ServerCertificateCreateForm(new ServerCertificateCreateFormPresenter()))
            {
                dlg.ShowDialog();
            }
        }

        public void GenerateEndUserCertificate()
        {
            using (var dlg = new EndUserCertificateCreateForm(new EndUserCertificateCreateFormPresenter()))
            {
                dlg.ShowDialog();
            }
        }

        public void CreateCrlList()
        {
            using (var dlg = new CrlCreateForm(new CrlCreateFormPresenter()))
            {
                dlg.ShowDialog();
            }
        }

        public void UpdateCrlList()
        {
            using (var dlg = new UpdateCrlForm(new UpdateCrlFormPresenter()))
            {
                dlg.ShowDialog();
            }
        }

        public void ConvertPemCertificateToPkcs12()
        {
            using (
                var dlg = new ConvertPem2Pkcs12Pem2Pkcs12CertificateForm(new ConvertPem2Pkcs12CertificateFormPresenter())
                )
            {
                dlg.ShowDialog();
            }
        }

        public void ConvertPemCertificateToDer()
        {
            using (var dlg = new ConvertPem2DerCertificateForm(new ConvertPem2DerCertificateFormPresenter()))
            {
                dlg.ShowDialog();
            }
        }
    }
}