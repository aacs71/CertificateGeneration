using System;
using System.Windows.Forms;
using CertificateManager.Infrastructure;
using Org.BouncyCastle.Asn1.X509;

namespace CertificateManager.Views
{
    public partial class UpdateCrlForm : Form, IUpdateCrlView
    {
        private readonly UpdateCrlFormPresenter _presenter;

        public UpdateCrlForm()
        {
            InitializeComponent();
        }

        public UpdateCrlForm(UpdateCrlFormPresenter presenter)
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

        public string CrlListFile
        {
            get { return txtExistingRevocationList.Text.Trim(); }
        }

        public string[] CertificatesFilesToRevocate
        {
            get { return txtNewCertificates.Lines; }
        }

        public string CAFile
        {
            get { return txtCAFile.Text.Trim(); }
        }

        public string CAPrivateKeyFile
        {
            get { return txtCAPrivateKeyFile.Text.Trim(); }
        }

        public int Reason
        {
            get
            {
                // seca...
                if (rbReasonAACompromise.Checked)
                {
                    return CrlReason.AACompromise;
                }
                if (rbReasonPrivilegeWithdrawn.Checked)
                {
                    return CrlReason.PrivilegeWithdrawn;
                }
                if (rbReasonRemoveFromCrl.Checked)
                {
                    return CrlReason.RemoveFromCrl;
                }
                if (rbReasonCertificateHold.Checked)
                {
                    return CrlReason.CertificateHold;
                }
                if (rbReasonCessationOfOperation.Checked)
                {
                    return CrlReason.CessationOfOperation;
                }
                if (rbReasonSuperseded.Checked)
                {
                    return CrlReason.Superseded;
                }
                if (rbReasonAffiliationChanged.Checked)
                {
                    return CrlReason.AffiliationChanged;
                }
                if (rbReasonCACompromise.Checked)
                {
                    return CrlReason.CACompromise;
                }
                if (rbReasonKeyCompromise.Checked)
                {
                    return CrlReason.KeyCompromise;
                }

                return CrlReason.Unspecified;
            }
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

        private void btnChooseRevocationList_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = @"Crl files (*.crl)|*.crl|All files (*.*)|*.*";
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;
                dlg.CheckFileExists = true;
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtExistingRevocationList.Text = dlg.FileName;
                }
            }
        }

        private void btnChooseCerticates_Click(object sender, EventArgs e)
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
                    txtNewCertificates.Lines = dlg.FileNames;
                }
            }
        }
    }
}