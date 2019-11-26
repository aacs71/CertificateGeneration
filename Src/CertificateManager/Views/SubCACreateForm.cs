using System;
using System.Windows.Forms;
using CertificateManager.Infrastructure;
using Org.BouncyCastle.Asn1.X509;

namespace CertificateManager.Views
{
    public partial class SubCACreateForm : Form, ISubCACreateFormView
    {
        private readonly SubCACreateFormPresenter _presenter;

        public SubCACreateForm()
        {
            InitializeComponent();
        }

        public SubCACreateForm(SubCACreateFormPresenter presenter)
            : this()
        {
            _presenter = presenter;
            _presenter.View = this;
        }

        public IPresenter Presenter
        {
            get { return _presenter; }
        }

        public int AvailableKeyUsage
        {
            set { kuControl.EnableControls(value); }
        }

        public int DefaultKeyUsage
        {
            set { kuControl.CheckControls(value); }
        }

        public KeyUsage KeyUsage
        {
            get { return kuControl.Usage; }
        }

        public KeyPurposeID[] AvailablePurpose
        {
            set { kpPurpose.EnableControls(value); }
        }

        public KeyPurposeID[] DefaultPurpose
        {
            set { kpPurpose.CheckControls(value); }
        }

        public KeyPurposeID[] Purpose
        {
            get { return kpPurpose.Purposes; }
        }

        public string[] Algoritms
        {
            set
            {
                cbAlgoritms.BeginUpdate();
                cbAlgoritms.Items.Clear();
                cbAlgoritms.Items.AddRange(value);
                cbAlgoritms.EndUpdate();
            }
        }

        public string DefaultAlgoritm
        {
            set { cbAlgoritms.SelectedItem = cbAlgoritms.Items[cbAlgoritms.Items.IndexOf(value)]; }
        }

        public string Algoritm
        {
            get { return cbAlgoritms.SelectedItem as string; }
        }

        public int DefaultKeyLength
        {
            set { numKeyLength.Value = value; }
        }

        public int KeyLength
        {
            get { return (int) numKeyLength.Value; }
        }

        public string Subject
        {
            get { return tbSubject.Text.Trim(); }
        }

        public DateTime From
        {
            set { calFrom.Value = value; }
            get { return calFrom.Value; }
        }

        public int Duration
        {
            get { return (int) numDuration.Value; }
        }

        public string CaUri
        {
            get { return txtCaUri.Text.Trim(); }
        }

        public string CrlUri
        {
            get { return txtCrlUri.Text.Trim(); }
        }

        public string OcspUri
        {
            get { return txtUriOcsp.Text.Trim(); }
        }

        public string CAFile
        {
            get { return txtCAFile.Text.Trim(); }
        }

        public string CAPrivateKeyFile
        {
            get { return txtCAPrivateKeyFile.Text.Trim(); }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _presenter.OnViewReady();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_presenter.Generate())
            {
                Close();
            }
        }

        private void btnChooseCAFile_Click(object sender, EventArgs e)
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
                    txtCAFile.Text = dlg.FileName;
                }
            }
        }

        private void btnChooseCAPrivateKeyFile_Click(object sender, EventArgs e)
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
                    txtCAPrivateKeyFile.Text = dlg.FileName;
                }
            }
        }

		private void btnUrlGenerationHelp_1_Click(object sender, EventArgs e)
		{
			var dlg = new UriGenerationHelpWindow();
			dlg.ShowDialog();
		}
	}
}