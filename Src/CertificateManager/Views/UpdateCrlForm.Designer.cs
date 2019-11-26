namespace CertificateManager.Views
{
    partial class UpdateCrlForm
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
            this.btnChooseCAPrivateKeyFile = new System.Windows.Forms.Button();
            this.txtCAPrivateKeyFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChooseCAFile = new System.Windows.Forms.Button();
            this.txtCAFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbAlgoritms = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.calFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChooseRevocationList = new System.Windows.Forms.Button();
            this.txtExistingRevocationList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseCerticates = new System.Windows.Forms.Button();
            this.txtNewCertificates = new System.Windows.Forms.TextBox();
            this.rbReasonUnspecified = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbReasonKeyCompromise = new System.Windows.Forms.RadioButton();
            this.rbReasonCACompromise = new System.Windows.Forms.RadioButton();
            this.rbReasonAffiliationChanged = new System.Windows.Forms.RadioButton();
            this.rbReasonSuperseded = new System.Windows.Forms.RadioButton();
            this.rbReasonCessationOfOperation = new System.Windows.Forms.RadioButton();
            this.rbReasonCertificateHold = new System.Windows.Forms.RadioButton();
            this.rbReasonRemoveFromCrl = new System.Windows.Forms.RadioButton();
            this.rbReasonPrivilegeWithdrawn = new System.Windows.Forms.RadioButton();
            this.rbReasonAACompromise = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseCAPrivateKeyFile
            // 
            this.btnChooseCAPrivateKeyFile.Location = new System.Drawing.Point(367, 326);
            this.btnChooseCAPrivateKeyFile.Name = "btnChooseCAPrivateKeyFile";
            this.btnChooseCAPrivateKeyFile.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCAPrivateKeyFile.TabIndex = 17;
            this.btnChooseCAPrivateKeyFile.Text = "...";
            this.btnChooseCAPrivateKeyFile.UseVisualStyleBackColor = true;
            this.btnChooseCAPrivateKeyFile.Click += new System.EventHandler(this.btnChooseCAPrivateKeyFile_Click);
            // 
            // txtCAPrivateKeyFile
            // 
            this.txtCAPrivateKeyFile.Location = new System.Drawing.Point(9, 326);
            this.txtCAPrivateKeyFile.Name = "txtCAPrivateKeyFile";
            this.txtCAPrivateKeyFile.ReadOnly = true;
            this.txtCAPrivateKeyFile.Size = new System.Drawing.Size(352, 20);
            this.txtCAPrivateKeyFile.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Localização da chave privada da CA";
            // 
            // btnChooseCAFile
            // 
            this.btnChooseCAFile.Location = new System.Drawing.Point(367, 283);
            this.btnChooseCAFile.Name = "btnChooseCAFile";
            this.btnChooseCAFile.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCAFile.TabIndex = 14;
            this.btnChooseCAFile.Text = "...";
            this.btnChooseCAFile.UseVisualStyleBackColor = true;
            this.btnChooseCAFile.Click += new System.EventHandler(this.btnChooseCAFile_Click);
            // 
            // txtCAFile
            // 
            this.txtCAFile.Location = new System.Drawing.Point(9, 284);
            this.txtCAFile.Name = "txtCAFile";
            this.txtCAFile.ReadOnly = true;
            this.txtCAFile.Size = new System.Drawing.Size(352, 20);
            this.txtCAFile.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Localização da CA";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(342, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(261, 507);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbAlgoritms
            // 
            this.cbAlgoritms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgoritms.FormattingEnabled = true;
            this.cbAlgoritms.Location = new System.Drawing.Point(9, 31);
            this.cbAlgoritms.Name = "cbAlgoritms";
            this.cbAlgoritms.Size = new System.Drawing.Size(352, 21);
            this.cbAlgoritms.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Próxima actualizção (dias)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data actualização";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(235, 77);
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
            this.numDuration.Size = new System.Drawing.Size(126, 20);
            this.numDuration.TabIndex = 5;
            this.numDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calFrom
            // 
            this.calFrom.CustomFormat = "dd-MM-yyyy";
            this.calFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calFrom.Location = new System.Drawing.Point(9, 77);
            this.calFrom.Name = "calFrom";
            this.calFrom.Size = new System.Drawing.Size(158, 20);
            this.calFrom.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbReasonAACompromise);
            this.groupBox1.Controls.Add(this.rbReasonPrivilegeWithdrawn);
            this.groupBox1.Controls.Add(this.rbReasonRemoveFromCrl);
            this.groupBox1.Controls.Add(this.rbReasonCertificateHold);
            this.groupBox1.Controls.Add(this.rbReasonCessationOfOperation);
            this.groupBox1.Controls.Add(this.rbReasonSuperseded);
            this.groupBox1.Controls.Add(this.rbReasonAffiliationChanged);
            this.groupBox1.Controls.Add(this.rbReasonCACompromise);
            this.groupBox1.Controls.Add(this.rbReasonKeyCompromise);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbReasonUnspecified);
            this.groupBox1.Controls.Add(this.btnChooseCerticates);
            this.groupBox1.Controls.Add(this.txtNewCertificates);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnChooseRevocationList);
            this.groupBox1.Controls.Add(this.txtExistingRevocationList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChooseCAPrivateKeyFile);
            this.groupBox1.Controls.Add(this.txtCAPrivateKeyFile);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnChooseCAFile);
            this.groupBox1.Controls.Add(this.txtCAFile);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbAlgoritms);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numDuration);
            this.groupBox1.Controls.Add(this.calFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados obrigatórios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Algoritmo";
            // 
            // btnChooseRevocationList
            // 
            this.btnChooseRevocationList.Location = new System.Drawing.Point(367, 119);
            this.btnChooseRevocationList.Name = "btnChooseRevocationList";
            this.btnChooseRevocationList.Size = new System.Drawing.Size(29, 20);
            this.btnChooseRevocationList.TabIndex = 8;
            this.btnChooseRevocationList.Text = "...";
            this.btnChooseRevocationList.UseVisualStyleBackColor = true;
            this.btnChooseRevocationList.Click += new System.EventHandler(this.btnChooseRevocationList_Click);
            // 
            // txtExistingRevocationList
            // 
            this.txtExistingRevocationList.Location = new System.Drawing.Point(9, 120);
            this.txtExistingRevocationList.Name = "txtExistingRevocationList";
            this.txtExistingRevocationList.ReadOnly = true;
            this.txtExistingRevocationList.Size = new System.Drawing.Size(352, 20);
            this.txtExistingRevocationList.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de revogação a actualizar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Certificados a revogar (opcional)";
            // 
            // btnChooseCerticates
            // 
            this.btnChooseCerticates.Location = new System.Drawing.Point(367, 244);
            this.btnChooseCerticates.Name = "btnChooseCerticates";
            this.btnChooseCerticates.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCerticates.TabIndex = 11;
            this.btnChooseCerticates.Text = "...";
            this.btnChooseCerticates.UseVisualStyleBackColor = true;
            this.btnChooseCerticates.Click += new System.EventHandler(this.btnChooseCerticates_Click);
            // 
            // txtNewCertificates
            // 
            this.txtNewCertificates.Location = new System.Drawing.Point(9, 159);
            this.txtNewCertificates.Multiline = true;
            this.txtNewCertificates.Name = "txtNewCertificates";
            this.txtNewCertificates.ReadOnly = true;
            this.txtNewCertificates.Size = new System.Drawing.Size(352, 105);
            this.txtNewCertificates.TabIndex = 10;
            // 
            // rbReasonUnspecified
            // 
            this.rbReasonUnspecified.AutoSize = true;
            this.rbReasonUnspecified.Location = new System.Drawing.Point(9, 370);
            this.rbReasonUnspecified.Name = "rbReasonUnspecified";
            this.rbReasonUnspecified.Size = new System.Drawing.Size(108, 17);
            this.rbReasonUnspecified.TabIndex = 19;
            this.rbReasonUnspecified.Tag = "0";
            this.rbReasonUnspecified.Text = "Não especificada";
            this.rbReasonUnspecified.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Razão";
            // 
            // rbReasonKeyCompromise
            // 
            this.rbReasonKeyCompromise.AutoSize = true;
            this.rbReasonKeyCompromise.Location = new System.Drawing.Point(237, 370);
            this.rbReasonKeyCompromise.Name = "rbReasonKeyCompromise";
            this.rbReasonKeyCompromise.Size = new System.Drawing.Size(125, 17);
            this.rbReasonKeyCompromise.TabIndex = 20;
            this.rbReasonKeyCompromise.Tag = "1";
            this.rbReasonKeyCompromise.Text = "Chave comprometida";
            this.rbReasonKeyCompromise.UseVisualStyleBackColor = true;
            // 
            // rbReasonCACompromise
            // 
            this.rbReasonCACompromise.AutoSize = true;
            this.rbReasonCACompromise.Location = new System.Drawing.Point(9, 393);
            this.rbReasonCACompromise.Name = "rbReasonCACompromise";
            this.rbReasonCACompromise.Size = new System.Drawing.Size(108, 17);
            this.rbReasonCACompromise.TabIndex = 21;
            this.rbReasonCACompromise.Tag = "2";
            this.rbReasonCACompromise.Text = "CA comprometida";
            this.rbReasonCACompromise.UseVisualStyleBackColor = true;
            // 
            // rbReasonAffiliationChanged
            // 
            this.rbReasonAffiliationChanged.AutoSize = true;
            this.rbReasonAffiliationChanged.Location = new System.Drawing.Point(237, 393);
            this.rbReasonAffiliationChanged.Name = "rbReasonAffiliationChanged";
            this.rbReasonAffiliationChanged.Size = new System.Drawing.Size(102, 17);
            this.rbReasonAffiliationChanged.TabIndex = 22;
            this.rbReasonAffiliationChanged.Tag = "3";
            this.rbReasonAffiliationChanged.Text = "Filiação alterada";
            this.rbReasonAffiliationChanged.UseVisualStyleBackColor = true;
            // 
            // rbReasonSuperseded
            // 
            this.rbReasonSuperseded.AutoSize = true;
            this.rbReasonSuperseded.Checked = true;
            this.rbReasonSuperseded.Location = new System.Drawing.Point(9, 416);
            this.rbReasonSuperseded.Name = "rbReasonSuperseded";
            this.rbReasonSuperseded.Size = new System.Drawing.Size(77, 17);
            this.rbReasonSuperseded.TabIndex = 23;
            this.rbReasonSuperseded.TabStop = true;
            this.rbReasonSuperseded.Tag = "4";
            this.rbReasonSuperseded.Text = "Substituida";
            this.rbReasonSuperseded.UseVisualStyleBackColor = true;
            // 
            // rbReasonCessationOfOperation
            // 
            this.rbReasonCessationOfOperation.AutoSize = true;
            this.rbReasonCessationOfOperation.Location = new System.Drawing.Point(237, 416);
            this.rbReasonCessationOfOperation.Name = "rbReasonCessationOfOperation";
            this.rbReasonCessationOfOperation.Size = new System.Drawing.Size(135, 17);
            this.rbReasonCessationOfOperation.TabIndex = 24;
            this.rbReasonCessationOfOperation.Tag = "5";
            this.rbReasonCessationOfOperation.Text = "Cessação de operação";
            this.rbReasonCessationOfOperation.UseVisualStyleBackColor = true;
            // 
            // rbReasonCertificateHold
            // 
            this.rbReasonCertificateHold.AutoSize = true;
            this.rbReasonCertificateHold.Location = new System.Drawing.Point(9, 439);
            this.rbReasonCertificateHold.Name = "rbReasonCertificateHold";
            this.rbReasonCertificateHold.Size = new System.Drawing.Size(124, 17);
            this.rbReasonCertificateHold.TabIndex = 25;
            this.rbReasonCertificateHold.Tag = "6";
            this.rbReasonCertificateHold.Text = "Retenção certificado";
            this.rbReasonCertificateHold.UseVisualStyleBackColor = true;
            // 
            // rbReasonRemoveFromCrl
            // 
            this.rbReasonRemoveFromCrl.AutoSize = true;
            this.rbReasonRemoveFromCrl.Location = new System.Drawing.Point(237, 439);
            this.rbReasonRemoveFromCrl.Name = "rbReasonRemoveFromCrl";
            this.rbReasonRemoveFromCrl.Size = new System.Drawing.Size(159, 17);
            this.rbReasonRemoveFromCrl.TabIndex = 26;
            this.rbReasonRemoveFromCrl.Tag = "8";
            this.rbReasonRemoveFromCrl.Text = "Remoção certificado da lista";
            this.rbReasonRemoveFromCrl.UseVisualStyleBackColor = true;
            // 
            // rbReasonPrivilegeWithdrawn
            // 
            this.rbReasonPrivilegeWithdrawn.AutoSize = true;
            this.rbReasonPrivilegeWithdrawn.Location = new System.Drawing.Point(9, 462);
            this.rbReasonPrivilegeWithdrawn.Name = "rbReasonPrivilegeWithdrawn";
            this.rbReasonPrivilegeWithdrawn.Size = new System.Drawing.Size(127, 17);
            this.rbReasonPrivilegeWithdrawn.TabIndex = 27;
            this.rbReasonPrivilegeWithdrawn.Tag = "9";
            this.rbReasonPrivilegeWithdrawn.Text = "Previégios revogados";
            this.rbReasonPrivilegeWithdrawn.UseVisualStyleBackColor = true;
            // 
            // rbReasonAACompromise
            // 
            this.rbReasonAACompromise.AutoSize = true;
            this.rbReasonAACompromise.Location = new System.Drawing.Point(237, 462);
            this.rbReasonAACompromise.Name = "rbReasonAACompromise";
            this.rbReasonAACompromise.Size = new System.Drawing.Size(108, 17);
            this.rbReasonAACompromise.TabIndex = 28;
            this.rbReasonAACompromise.Tag = "10";
            this.rbReasonAACompromise.Text = "AA comprometida";
            this.rbReasonAACompromise.UseVisualStyleBackColor = true;
            // 
            // UpdateCrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(429, 537);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCrlForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualização da lista de revogação";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseCAPrivateKeyFile;
        private System.Windows.Forms.TextBox txtCAPrivateKeyFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChooseCAFile;
        private System.Windows.Forms.TextBox txtCAFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbAlgoritms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.DateTimePicker calFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseCerticates;
        private System.Windows.Forms.TextBox txtNewCertificates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChooseRevocationList;
        private System.Windows.Forms.TextBox txtExistingRevocationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbReasonAACompromise;
        private System.Windows.Forms.RadioButton rbReasonPrivilegeWithdrawn;
        private System.Windows.Forms.RadioButton rbReasonRemoveFromCrl;
        private System.Windows.Forms.RadioButton rbReasonCertificateHold;
        private System.Windows.Forms.RadioButton rbReasonCessationOfOperation;
        private System.Windows.Forms.RadioButton rbReasonSuperseded;
        private System.Windows.Forms.RadioButton rbReasonAffiliationChanged;
        private System.Windows.Forms.RadioButton rbReasonCACompromise;
        private System.Windows.Forms.RadioButton rbReasonKeyCompromise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbReasonUnspecified;
    }
}