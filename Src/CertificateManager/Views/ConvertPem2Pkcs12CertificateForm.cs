using System;
using System.Windows.Forms;
using CertificateManager.Infrastructure;

namespace CertificateManager.Views
{
    public partial class ConvertPem2Pkcs12Pem2Pkcs12CertificateForm : Form, IConvertPem2Pkcs12CertificateView
    {
        private readonly ConvertPem2Pkcs12CertificateFormPresenter _presenter;

        public ConvertPem2Pkcs12Pem2Pkcs12CertificateForm()
        {
            InitializeComponent();
        }

        public ConvertPem2Pkcs12Pem2Pkcs12CertificateForm(ConvertPem2Pkcs12CertificateFormPresenter presenter)
            : this()
        {
            _presenter = presenter;
            _presenter.View = this;
        }

        public IPresenter Presenter
        {
            get { return _presenter; }
        }

        public string[] CasFiles
        {
            get { return txtCAs.Lines; }
        }

        public string CertificateFile
        {
            get { return txtCertificateFile.Text.Trim(); }
        }

        public string CertificatePrivateKeyFile
        {
            get { return txtCertificatePrivateKeyFile.Text.Trim(); }
        }

        public string Pkcs12Password
        {
            get { return txtPassword.Text; }
        }

        public string Pkcs12PasswordConfirmation
        {
            get { return txtConfirmPassword.Text; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _presenter.OnViewReady();
        }

        private void btnChooseCertificateFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter =
                    @"X.509 Certificate files (*.cer;*.crt;*.cert;*.pem)|*.cer;*.crt;*.cert;*.pem|Pem files (*.pem)|*.pem|Crt files (*.crt)|*.crt|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;
                dlg.CheckFileExists = true;
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtCertificateFile.Text = dlg.FileName;
                }
            }
        }

        private void btnChooseCertificatePrivateKeyFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = @"PEM files (*.pem)|*.pem|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;
                dlg.CheckFileExists = true;
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtCertificatePrivateKeyFile.Text = dlg.FileName;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _presenter.Convert();
        }

        private void btnChooseCas_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter =
                    @"X.509 Certificate files (*.cer;*.crt;*.cert;*.pem)|*.cer;*.crt;*.cert;*.pem|Pem files (*.pem)|*.pem|Crt files (*.crt)|*.crt|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;
                dlg.CheckFileExists = true;
                dlg.Multiselect = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtCAs.Lines = dlg.FileNames;
                }
            }
        }
    }
}