using System;
using System.Windows.Forms;
using CertificateManager.Infrastructure;

namespace CertificateManager.Views
{
    public partial class ConvertPem2DerCertificateForm : Form, IConvertPem2DerCertificateForm
    {
        private readonly ConvertPem2DerCertificateFormPresenter _presenter;

        public ConvertPem2DerCertificateForm()
        {
            InitializeComponent();
        }

        public ConvertPem2DerCertificateForm(ConvertPem2DerCertificateFormPresenter presenter)
            : this()
        {
            _presenter = presenter;
            _presenter.View = this;
        }

        public IPresenter Presenter
        {
            get { return _presenter; }
        }

        public string CertificateFile
        {
            get { return txtCertificateFile.Text.Trim(); }
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            _presenter.Convert();
        }
    }
}