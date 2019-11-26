using System;
using System.Windows.Forms;
using CertificateManager.Infrastructure;

namespace CertificateManager
{
    public partial class MainForm : Form, IMainViewForm
    {
        private readonly MainFormPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(MainFormPresenter presenter) : this()
        {
            _presenter = presenter;
            _presenter.View = this;
        }

        public IPresenter Presenter
        {
            get { return _presenter; }
        }

        private void btnGenerateCA_Click(object sender, EventArgs e)
        {
            _presenter.GenerateCA();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerateSelfSign_Click(object sender, EventArgs e)
        {
            _presenter.GenerateSelfSigned();
        }

        private void btnGenerateSubCA_Click(object sender, EventArgs e)
        {
            _presenter.GenerateSubCA();
        }

        private void btnGenerateServerCertificate_Click(object sender, EventArgs e)
        {
            _presenter.GenerateServerCertificate();
        }

        private void btnGenerateEndUserCertificate_Click(object sender, EventArgs e)
        {
            _presenter.GenerateEndUserCertificate();
        }

        private void btnGenerateRevocationList_Click(object sender, EventArgs e)
        {
            _presenter.CreateCrlList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presenter.UpdateCrlList();
        }

        private void btnConvertFormat_Click(object sender, EventArgs e)
        {
            _presenter.ConvertPemCertificateToPkcs12();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presenter.ConvertPemCertificateToDer();
        }
    }
}