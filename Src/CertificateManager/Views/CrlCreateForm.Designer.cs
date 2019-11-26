namespace CertificateManager.Views
{
    partial class CrlCreateForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtCAFile = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbAlgoritms = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.calFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseCAPrivateKeyFile
            // 
            this.btnChooseCAPrivateKeyFile.Location = new System.Drawing.Point(367, 206);
            this.btnChooseCAPrivateKeyFile.Name = "btnChooseCAPrivateKeyFile";
            this.btnChooseCAPrivateKeyFile.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCAPrivateKeyFile.TabIndex = 16;
            this.btnChooseCAPrivateKeyFile.Text = "...";
            this.btnChooseCAPrivateKeyFile.UseVisualStyleBackColor = true;
            this.btnChooseCAPrivateKeyFile.Click += new System.EventHandler(this.btnChooseCAPrivateKeyFile_Click);
            // 
            // txtCAPrivateKeyFile
            // 
            this.txtCAPrivateKeyFile.Location = new System.Drawing.Point(9, 206);
            this.txtCAPrivateKeyFile.Name = "txtCAPrivateKeyFile";
            this.txtCAPrivateKeyFile.ReadOnly = true;
            this.txtCAPrivateKeyFile.Size = new System.Drawing.Size(352, 20);
            this.txtCAPrivateKeyFile.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Localização da chave privada da CA";
            // 
            // btnChooseCAFile
            // 
            this.btnChooseCAFile.Location = new System.Drawing.Point(367, 163);
            this.btnChooseCAFile.Name = "btnChooseCAFile";
            this.btnChooseCAFile.Size = new System.Drawing.Size(29, 20);
            this.btnChooseCAFile.TabIndex = 13;
            this.btnChooseCAFile.Text = "...";
            this.btnChooseCAFile.UseVisualStyleBackColor = true;
            this.btnChooseCAFile.Click += new System.EventHandler(this.btnChooseCAFile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Localização da CA";
            // 
            // txtCAFile
            // 
            this.txtCAFile.Location = new System.Drawing.Point(9, 164);
            this.txtCAFile.Name = "txtCAFile";
            this.txtCAFile.ReadOnly = true;
            this.txtCAFile.Size = new System.Drawing.Size(352, 20);
            this.txtCAFile.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(342, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(261, 261);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
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
            this.cbAlgoritms.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Próxima actualizção (dias)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data actualização";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(9, 119);
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
            this.numDuration.TabIndex = 10;
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
            this.calFrom.TabIndex = 8;
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
            this.groupBox1.Controls.Add(this.cbAlgoritms);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numDuration);
            this.groupBox1.Controls.Add(this.calFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 243);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados obrigatórios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Algoritmo";
            // 
            // CrlCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(430, 290);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrlCreateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criação da lista de revogação";
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCAFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbAlgoritms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.DateTimePicker calFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
    }
}