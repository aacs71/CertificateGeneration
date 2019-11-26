namespace CertificateManager.Views
{
    partial class ConvertPem2Pkcs12Pem2Pkcs12CertificateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseCertificatePrivateKeyFile = new System.Windows.Forms.Button();
            this.txtCertificatePrivateKeyFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChooseCertificateFile = new System.Windows.Forms.Button();
            this.txtCertificateFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCAs = new System.Windows.Forms.TextBox();
            this.btnChooseCas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChooseCas);
            this.groupBox1.Controls.Add(this.txtCAs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChooseCertificatePrivateKeyFile);
            this.groupBox1.Controls.Add(this.txtCertificatePrivateKeyFile);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnChooseCertificateFile);
            this.groupBox1.Controls.Add(this.txtCertificateFile);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados obrigatórios";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(6, 296);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(352, 20);
            this.txtConfirmPassword.TabIndex = 12;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Confirmação da Password Pkcs12";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(352, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password Pkcs12";
            // 
            // btnChooseCertificatePrivateKeyFile
            // 
            this.btnChooseCertificatePrivateKeyFile.Location = new System.Drawing.Point(367, 78);
            this.btnChooseCertificatePrivateKeyFile.Name = "btnChooseCertificatePrivateKeyFile";
            this.btnChooseCertificatePrivateKeyFile.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCertificatePrivateKeyFile.TabIndex = 5;
            this.btnChooseCertificatePrivateKeyFile.Text = "...";
            this.btnChooseCertificatePrivateKeyFile.UseVisualStyleBackColor = true;
            this.btnChooseCertificatePrivateKeyFile.Click += new System.EventHandler(this.btnChooseCertificatePrivateKeyFile_Click);
            // 
            // txtCertificatePrivateKeyFile
            // 
            this.txtCertificatePrivateKeyFile.Location = new System.Drawing.Point(9, 78);
            this.txtCertificatePrivateKeyFile.Name = "txtCertificatePrivateKeyFile";
            this.txtCertificatePrivateKeyFile.ReadOnly = true;
            this.txtCertificatePrivateKeyFile.Size = new System.Drawing.Size(352, 20);
            this.txtCertificatePrivateKeyFile.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Localização da chave privada do certificado";
            // 
            // btnChooseCertificateFile
            // 
            this.btnChooseCertificateFile.Location = new System.Drawing.Point(367, 35);
            this.btnChooseCertificateFile.Name = "btnChooseCertificateFile";
            this.btnChooseCertificateFile.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCertificateFile.TabIndex = 2;
            this.btnChooseCertificateFile.Text = "...";
            this.btnChooseCertificateFile.UseVisualStyleBackColor = true;
            this.btnChooseCertificateFile.Click += new System.EventHandler(this.btnChooseCertificateFile_Click);
            // 
            // txtCertificateFile
            // 
            this.txtCertificateFile.Location = new System.Drawing.Point(9, 36);
            this.txtCertificateFile.Name = "txtCertificateFile";
            this.txtCertificateFile.ReadOnly = true;
            this.txtCertificateFile.Size = new System.Drawing.Size(352, 20);
            this.txtCertificateFile.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Localização do certificado";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(342, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(261, 350);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de CA\'s a incluir (opcional)";
            // 
            // txtCAs
            // 
            this.txtCAs.Location = new System.Drawing.Point(6, 120);
            this.txtCAs.Multiline = true;
            this.txtCAs.Name = "txtCAs";
            this.txtCAs.PasswordChar = '*';
            this.txtCAs.Size = new System.Drawing.Size(352, 101);
            this.txtCAs.TabIndex = 7;
            this.txtCAs.UseSystemPasswordChar = true;
            // 
            // btnChooseCas
            // 
            this.btnChooseCas.Location = new System.Drawing.Point(367, 201);
            this.btnChooseCas.Name = "btnChooseCas";
            this.btnChooseCas.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCas.TabIndex = 8;
            this.btnChooseCas.Text = "...";
            this.btnChooseCas.UseVisualStyleBackColor = true;
            this.btnChooseCas.Click += new System.EventHandler(this.btnChooseCas_Click);
            // 
            // ConvertPem2Pkcs12Pem2Pkcs12CertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(433, 379);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertPem2Pkcs12Pem2Pkcs12CertificateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter PEM para Pkcs12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseCertificatePrivateKeyFile;
        private System.Windows.Forms.TextBox txtCertificatePrivateKeyFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChooseCertificateFile;
        private System.Windows.Forms.TextBox txtCertificateFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnChooseCas;
        private System.Windows.Forms.TextBox txtCAs;
        private System.Windows.Forms.Label label3;
    }
}