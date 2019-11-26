using System;
using System.Windows.Forms;
using CertificateManager.Infrastructure;

namespace CertificateManager.Views
{
    public partial class CrlCreateForm : Form, ICrlCreateView
    {
        private readonly CrlCreateFormPresenter _presenter;

        public CrlCreateForm()
        {
            InitializeComponent();
        }

        public CrlCreateForm(CrlCreateFormPresenter presenter)
            : this()
        {
            _presenter = presenter;
            _presenter.View = this;
        }

        public IPresenter Presenter
        {
            get { return _presenter; }
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

        public DateTime From
        {
            set { calFrom.Value = value; }
            get { return calFrom.Value; }
        }

        public int DefaultNextUpdate
        {
            set { numDuration.Value = value; }
        }

        public int NextUpdate
        {
            get { return (int) numDuration.Value; }
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
    }
}