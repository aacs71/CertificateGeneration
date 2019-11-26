namespace CertificateManager.Views
{
    partial class CACreateForm
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
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.numKeyLength = new System.Windows.Forms.NumericUpDown();
			this.cbAlgoritms = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numDuration = new System.Windows.Forms.NumericUpDown();
			this.calFrom = new System.Windows.Forms.DateTimePicker();
			this.tbSubject = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnUrlGenerationHelp_2 = new System.Windows.Forms.Button();
			this.btnUrlGenerationHelp_1 = new System.Windows.Forms.Button();
			this.kpPurpose = new CertificateManager.UserControls.KeyPurposeControl();
			this.kuControl = new CertificateManager.UserControls.KeyUsageControl();
			this.txtUriOcsp = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCrlUri = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numKeyLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
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
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(445, 181);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados obrigatórios";
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
			this.label8.Location = new System.Drawing.Point(315, 84);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Comprimento da chave";
			// 
			// numKeyLength
			// 
			this.numKeyLength.Location = new System.Drawing.Point(318, 100);
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
			// cbAlgoritms
			// 
			this.cbAlgoritms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAlgoritms.FormattingEnabled = true;
			this.cbAlgoritms.Location = new System.Drawing.Point(10, 99);
			this.cbAlgoritms.Name = "cbAlgoritms";
			this.cbAlgoritms.Size = new System.Drawing.Size(200, 21);
			this.cbAlgoritms.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
			this.label4.Location = new System.Drawing.Point(10, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(400, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ex: apenas um nome ou um DN (ex: CN=AMinha CA,O=A minha companhia, C=PT)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(315, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Duração (dias)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Validade a partir de ";
			// 
			// numDuration
			// 
			this.numDuration.Location = new System.Drawing.Point(318, 149);
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
			// calFrom
			// 
			this.calFrom.CustomFormat = "dd-MM-yyyy";
			this.calFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.calFrom.Location = new System.Drawing.Point(10, 149);
			this.calFrom.Name = "calFrom";
			this.calFrom.Size = new System.Drawing.Size(204, 20);
			this.calFrom.TabIndex = 8;
			// 
			// tbSubject
			// 
			this.tbSubject.Location = new System.Drawing.Point(10, 33);
			this.tbSubject.Name = "tbSubject";
			this.tbSubject.Size = new System.Drawing.Size(421, 20);
			this.tbSubject.TabIndex = 1;
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
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(302, 581);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(383, 581);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnUrlGenerationHelp_2);
			this.groupBox2.Controls.Add(this.btnUrlGenerationHelp_1);
			this.groupBox2.Controls.Add(this.kpPurpose);
			this.groupBox2.Controls.Add(this.kuControl);
			this.groupBox2.Controls.Add(this.txtUriOcsp);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtCrlUri);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(13, 200);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(445, 375);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Opções";
			// 
			// btnUrlGenerationHelp_2
			// 
			this.btnUrlGenerationHelp_2.Location = new System.Drawing.Point(414, 81);
			this.btnUrlGenerationHelp_2.Name = "btnUrlGenerationHelp_2";
			this.btnUrlGenerationHelp_2.Size = new System.Drawing.Size(25, 20);
			this.btnUrlGenerationHelp_2.TabIndex = 7;
			this.btnUrlGenerationHelp_2.Text = "...";
			this.btnUrlGenerationHelp_2.UseVisualStyleBackColor = true;
			this.btnUrlGenerationHelp_2.Click += new System.EventHandler(this.btnUrlGenerationHelp_1_Click);
			// 
			// btnUrlGenerationHelp_1
			// 
			this.btnUrlGenerationHelp_1.Location = new System.Drawing.Point(414, 38);
			this.btnUrlGenerationHelp_1.Name = "btnUrlGenerationHelp_1";
			this.btnUrlGenerationHelp_1.Size = new System.Drawing.Size(25, 20);
			this.btnUrlGenerationHelp_1.TabIndex = 6;
			this.btnUrlGenerationHelp_1.Text = "...";
			this.btnUrlGenerationHelp_1.UseVisualStyleBackColor = true;
			this.btnUrlGenerationHelp_1.Click += new System.EventHandler(this.btnUrlGenerationHelp_1_Click);
			// 
			// kpPurpose
			// 
			this.kpPurpose.Location = new System.Drawing.Point(295, 107);
			this.kpPurpose.Name = "kpPurpose";
			this.kpPurpose.Size = new System.Drawing.Size(133, 260);
			this.kpPurpose.TabIndex = 5;
			// 
			// kuControl
			// 
			this.kuControl.Location = new System.Drawing.Point(9, 107);
			this.kuControl.Name = "kuControl";
			this.kuControl.Size = new System.Drawing.Size(139, 218);
			this.kuControl.TabIndex = 4;
			// 
			// txtUriOcsp
			// 
			this.txtUriOcsp.Location = new System.Drawing.Point(10, 81);
			this.txtUriOcsp.Name = "txtUriOcsp";
			this.txtUriOcsp.Size = new System.Drawing.Size(398, 20);
			this.txtUriOcsp.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Uri do local do OCSP";
			// 
			// txtCrlUri
			// 
			this.txtCrlUri.Location = new System.Drawing.Point(10, 38);
			this.txtCrlUri.Name = "txtCrlUri";
			this.txtCrlUri.Size = new System.Drawing.Size(398, 20);
			this.txtCrlUri.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(167, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Uri do local da lista de distribuição";
			// 
			// CACreateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(473, 611);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CACreateForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CA";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numKeyLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.DateTimePicker calFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUriOcsp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCrlUri;
        private System.Windows.Forms.Label label6;
        private UserControls.KeyUsageControl kuControl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numKeyLength;
        private System.Windows.Forms.ComboBox cbAlgoritms;
        private UserControls.KeyPurposeControl kpPurpose;
		private System.Windows.Forms.Button btnUrlGenerationHelp_2;
		private System.Windows.Forms.Button btnUrlGenerationHelp_1;
	}
}