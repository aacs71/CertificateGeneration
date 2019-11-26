namespace CertificateManager.Views
{
    partial class EndUserCertificateCreateForm
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
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.numKeyLength = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numDuration = new System.Windows.Forms.NumericUpDown();
			this.tbSubject = new System.Windows.Forms.TextBox();
			this.kuControl = new CertificateManager.UserControls.KeyUsageControl();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.txtAlternateNames = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.kpPurpose = new CertificateManager.UserControls.KeyPurposeControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtCaUri = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUriOcsp = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCrlUri = new System.Windows.Forms.TextBox();
			this.calFrom = new System.Windows.Forms.DateTimePicker();
			this.txtCAFile = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnChooseCAPrivateKeyFile = new System.Windows.Forms.Button();
			this.txtCAPrivateKeyFile = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnChooseCAFile = new System.Windows.Forms.Button();
			this.cbAlgoritms = new System.Windows.Forms.ComboBox();
			this.btnUrlGenerationHelp_1 = new System.Windows.Forms.Button();
			this.btnUrlGenerationHelp_2 = new System.Windows.Forms.Button();
			this.btnUrlGenerationHelp_3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numKeyLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 84);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Algoritmo";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(280, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Comprimento da chave";
			// 
			// numKeyLength
			// 
			this.numKeyLength.Location = new System.Drawing.Point(283, 99);
			this.numKeyLength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numKeyLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numKeyLength.Name = "numKeyLength";
			this.numKeyLength.Size = new System.Drawing.Size(113, 20);
			this.numKeyLength.TabIndex = 6;
			this.numKeyLength.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
			this.label4.Location = new System.Drawing.Point(10, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(419, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ex: um nome ou um DN (ex: CN=email@companhia.com,O=A minha companhia, C=PT)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(679, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Duração (dias)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(405, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Validade a partir de ";
			// 
			// numDuration
			// 
			this.numDuration.Location = new System.Drawing.Point(682, 100);
			this.numDuration.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numDuration.Name = "numDuration";
			this.numDuration.Size = new System.Drawing.Size(113, 20);
			this.numDuration.TabIndex = 10;
			this.numDuration.Value = new decimal(new int[] {
            365,
            0,
            0,
            0});
			// 
			// tbSubject
			// 
			this.tbSubject.Location = new System.Drawing.Point(10, 33);
			this.tbSubject.Name = "tbSubject";
			this.tbSubject.Size = new System.Drawing.Size(785, 20);
			this.tbSubject.TabIndex = 1;
			// 
			// kuControl
			// 
			this.kuControl.Location = new System.Drawing.Point(451, 16);
			this.kuControl.Name = "kuControl";
			this.kuControl.Size = new System.Drawing.Size(139, 218);
			this.kuControl.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(167, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Uri do local da lista de distribuição";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(744, 486);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(663, 486);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
			this.label13.Location = new System.Drawing.Point(10, 117);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(303, 13);
			this.label13.TabIndex = 2;
			this.label13.Text = "Ex: email1@gmail.com, email2@hotmail.com, etc (um por linha)";
			// 
			// txtAlternateNames
			// 
			this.txtAlternateNames.Location = new System.Drawing.Point(13, 32);
			this.txtAlternateNames.Multiline = true;
			this.txtAlternateNames.Name = "txtAlternateNames";
			this.txtAlternateNames.Size = new System.Drawing.Size(418, 82);
			this.txtAlternateNames.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(10, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Nomes alterativos";
			// 
			// kpPurpose
			// 
			this.kpPurpose.Location = new System.Drawing.Point(662, 16);
			this.kpPurpose.Name = "kpPurpose";
			this.kpPurpose.Size = new System.Drawing.Size(133, 260);
			this.kpPurpose.TabIndex = 10;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnUrlGenerationHelp_3);
			this.groupBox2.Controls.Add(this.btnUrlGenerationHelp_2);
			this.groupBox2.Controls.Add(this.btnUrlGenerationHelp_1);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtAlternateNames);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.txtCaUri);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.kpPurpose);
			this.groupBox2.Controls.Add(this.kuControl);
			this.groupBox2.Controls.Add(this.txtUriOcsp);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtCrlUri);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(12, 199);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(807, 281);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Opções";
			// 
			// txtCaUri
			// 
			this.txtCaUri.Location = new System.Drawing.Point(13, 161);
			this.txtCaUri.Name = "txtCaUri";
			this.txtCaUri.Size = new System.Drawing.Size(387, 20);
			this.txtCaUri.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Uri do local da distribuição da CA";
			// 
			// txtUriOcsp
			// 
			this.txtUriOcsp.Location = new System.Drawing.Point(13, 245);
			this.txtUriOcsp.Name = "txtUriOcsp";
			this.txtUriOcsp.Size = new System.Drawing.Size(387, 20);
			this.txtUriOcsp.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Uri do local do OCSP";
			// 
			// txtCrlUri
			// 
			this.txtCrlUri.Location = new System.Drawing.Point(13, 202);
			this.txtCrlUri.Name = "txtCrlUri";
			this.txtCrlUri.Size = new System.Drawing.Size(387, 20);
			this.txtCrlUri.TabIndex = 6;
			// 
			// calFrom
			// 
			this.calFrom.CustomFormat = "dd-MM-yyyy";
			this.calFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.calFrom.Location = new System.Drawing.Point(408, 100);
			this.calFrom.Name = "calFrom";
			this.calFrom.Size = new System.Drawing.Size(204, 20);
			this.calFrom.TabIndex = 8;
			// 
			// txtCAFile
			// 
			this.txtCAFile.Location = new System.Drawing.Point(9, 146);
			this.txtCAFile.Name = "txtCAFile";
			this.txtCAFile.ReadOnly = true;
			this.txtCAFile.Size = new System.Drawing.Size(352, 20);
			this.txtCAFile.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sujeito";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 129);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 13);
			this.label10.TabIndex = 11;
			this.label10.Text = "Localização da CA";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnChooseCAPrivateKeyFile);
			this.groupBox1.Controls.Add(this.txtCAPrivateKeyFile);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.btnChooseCAFile);
			this.groupBox1.Controls.Add(this.txtCAFile);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.numKeyLength);
			this.groupBox1.Controls.Add(this.cbAlgoritms);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.numDuration);
			this.groupBox1.Controls.Add(this.calFrom);
			this.groupBox1.Controls.Add(this.tbSubject);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(807, 181);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados obrigatórios";
			// 
			// btnChooseCAPrivateKeyFile
			// 
			this.btnChooseCAPrivateKeyFile.Location = new System.Drawing.Point(766, 145);
			this.btnChooseCAPrivateKeyFile.Name = "btnChooseCAPrivateKeyFile";
			this.btnChooseCAPrivateKeyFile.Size = new System.Drawing.Size(29, 20);
			this.btnChooseCAPrivateKeyFile.TabIndex = 16;
			this.btnChooseCAPrivateKeyFile.Text = "...";
			this.btnChooseCAPrivateKeyFile.UseVisualStyleBackColor = true;
			this.btnChooseCAPrivateKeyFile.Click += new System.EventHandler(this.btnChooseCAPrivateKeyFile_Click);
			// 
			// txtCAPrivateKeyFile
			// 
			this.txtCAPrivateKeyFile.Location = new System.Drawing.Point(408, 145);
			this.txtCAPrivateKeyFile.Name = "txtCAPrivateKeyFile";
			this.txtCAPrivateKeyFile.ReadOnly = true;
			this.txtCAPrivateKeyFile.Size = new System.Drawing.Size(352, 20);
			this.txtCAPrivateKeyFile.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(405, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(182, 13);
			this.label11.TabIndex = 14;
			this.label11.Text = "Localização da chave privada da CA";
			// 
			// btnChooseCAFile
			// 
			this.btnChooseCAFile.Location = new System.Drawing.Point(367, 145);
			this.btnChooseCAFile.Name = "btnChooseCAFile";
			this.btnChooseCAFile.Size = new System.Drawing.Size(29, 20);
			this.btnChooseCAFile.TabIndex = 13;
			this.btnChooseCAFile.Text = "...";
			this.btnChooseCAFile.UseVisualStyleBackColor = true;
			this.btnChooseCAFile.Click += new System.EventHandler(this.btnChooseCAFile_Click);
			// 
			// cbAlgoritms
			// 
			this.cbAlgoritms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAlgoritms.FormattingEnabled = true;
			this.cbAlgoritms.Location = new System.Drawing.Point(10, 99);
			this.cbAlgoritms.Name = "cbAlgoritms";
			this.cbAlgoritms.Size = new System.Drawing.Size(200, 21);
			this.cbAlgoritms.TabIndex = 4;
			// 
			// btnUrlGenerationHelp_1
			// 
			this.btnUrlGenerationHelp_1.Location = new System.Drawing.Point(406, 161);
			this.btnUrlGenerationHelp_1.Name = "btnUrlGenerationHelp_1";
			this.btnUrlGenerationHelp_1.Size = new System.Drawing.Size(25, 20);
			this.btnUrlGenerationHelp_1.TabIndex = 11;
			this.btnUrlGenerationHelp_1.Text = "...";
			this.btnUrlGenerationHelp_1.UseVisualStyleBackColor = true;
			this.btnUrlGenerationHelp_1.Click += new System.EventHandler(this.btnUrlGenerationHelp_1_Click);
			// 
			// btnUrlGenerationHelp_2
			// 
			this.btnUrlGenerationHelp_2.Location = new System.Drawing.Point(406, 202);
			this.btnUrlGenerationHelp_2.Name = "btnUrlGenerationHelp_2";
			this.btnUrlGenerationHelp_2.Size = new System.Drawing.Size(25, 20);
			this.btnUrlGenerationHelp_2.TabIndex = 12;
			this.btnUrlGenerationHelp_2.Text = "...";
			this.btnUrlGenerationHelp_2.UseVisualStyleBackColor = true;
			this.btnUrlGenerationHelp_2.Click += new System.EventHandler(this.btnUrlGenerationHelp_1_Click);
			// 
			// btnUrlGenerationHelp_3
			// 
			this.btnUrlGenerationHelp_3.Location = new System.Drawing.Point(406, 245);
			this.btnUrlGenerationHelp_3.Name = "btnUrlGenerationHelp_3";
			this.btnUrlGenerationHelp_3.Size = new System.Drawing.Size(25, 20);
			this.btnUrlGenerationHelp_3.TabIndex = 13;
			this.btnUrlGenerationHelp_3.Text = "...";
			this.btnUrlGenerationHelp_3.UseVisualStyleBackColor = true;
			this.btnUrlGenerationHelp_3.Click += new System.EventHandler(this.btnUrlGenerationHelp_1_Click);
			// 
			// EndUserCertificateCreateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 517);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EndUserCertificateCreateForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Geração certificado end user";
			((System.ComponentModel.ISupportInitialize)(this.numKeyLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numKeyLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.TextBox tbSubject;
        private UserControls.KeyUsageControl kuControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAlternateNames;
        private System.Windows.Forms.Label label12;
        private UserControls.KeyPurposeControl kpPurpose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCaUri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUriOcsp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCrlUri;
        private System.Windows.Forms.DateTimePicker calFrom;
        private System.Windows.Forms.TextBox txtCAFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseCAPrivateKeyFile;
        private System.Windows.Forms.TextBox txtCAPrivateKeyFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChooseCAFile;
        private System.Windows.Forms.ComboBox cbAlgoritms;
		private System.Windows.Forms.Button btnUrlGenerationHelp_3;
		private System.Windows.Forms.Button btnUrlGenerationHelp_2;
		private System.Windows.Forms.Button btnUrlGenerationHelp_1;
	}
}