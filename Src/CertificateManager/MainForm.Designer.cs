namespace CertificateManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerateSelfSign = new System.Windows.Forms.Button();
            this.btnConvertFormat = new System.Windows.Forms.Button();
            this.btnGenerateSubCA = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerateRevocationList = new System.Windows.Forms.Button();
            this.btnGenerateEndUserCertificate = new System.Windows.Forms.Button();
            this.btnGenerateServerCertificate = new System.Windows.Forms.Button();
            this.btnGenerateCA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "Certificate-01.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(959, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(338, 17);
            this.toolStripStatusLabel1.Text = "(c) 2016 | António Salgado | antonio.costa.salgado@gmail.com";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CertificateManager.Properties.Resources.Agreement_01;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(764, 12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(182, 196);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar Lista Revogação";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerateSelfSign
            // 
            this.btnGenerateSelfSign.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateSelfSign.BackgroundImage = global::CertificateManager.Properties.Resources.Certificate_02;
            this.btnGenerateSelfSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateSelfSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSelfSign.Location = new System.Drawing.Point(200, 214);
            this.btnGenerateSelfSign.Name = "btnGenerateSelfSign";
            this.btnGenerateSelfSign.Padding = new System.Windows.Forms.Padding(5);
            this.btnGenerateSelfSign.Size = new System.Drawing.Size(182, 196);
            this.btnGenerateSelfSign.TabIndex = 7;
            this.btnGenerateSelfSign.Text = "Certificado Self Sign";
            this.btnGenerateSelfSign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateSelfSign.UseVisualStyleBackColor = true;
            this.btnGenerateSelfSign.Click += new System.EventHandler(this.btnGenerateSelfSign_Click);
            // 
            // btnConvertFormat
            // 
            this.btnConvertFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnConvertFormat.BackgroundImage = global::CertificateManager.Properties.Resources.Branch_Engineering;
            this.btnConvertFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConvertFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFormat.Location = new System.Drawing.Point(576, 214);
            this.btnConvertFormat.Name = "btnConvertFormat";
            this.btnConvertFormat.Padding = new System.Windows.Forms.Padding(5);
            this.btnConvertFormat.Size = new System.Drawing.Size(182, 196);
            this.btnConvertFormat.TabIndex = 9;
            this.btnConvertFormat.Text = "PEM -> Pkcs12 (pfx)";
            this.btnConvertFormat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertFormat.UseVisualStyleBackColor = true;
            this.btnConvertFormat.Click += new System.EventHandler(this.btnConvertFormat_Click);
            // 
            // btnGenerateSubCA
            // 
            this.btnGenerateSubCA.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateSubCA.BackgroundImage = global::CertificateManager.Properties.Resources.CACertificate;
            this.btnGenerateSubCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateSubCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSubCA.Location = new System.Drawing.Point(12, 214);
            this.btnGenerateSubCA.Name = "btnGenerateSubCA";
            this.btnGenerateSubCA.Padding = new System.Windows.Forms.Padding(5);
            this.btnGenerateSubCA.Size = new System.Drawing.Size(182, 196);
            this.btnGenerateSubCA.TabIndex = 6;
            this.btnGenerateSubCA.Text = "Gerar Sub CA";
            this.btnGenerateSubCA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateSubCA.UseVisualStyleBackColor = true;
            this.btnGenerateSubCA.Click += new System.EventHandler(this.btnGenerateSubCA_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(886, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5);
            this.btnExit.Size = new System.Drawing.Size(60, 56);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerateRevocationList
            // 
            this.btnGenerateRevocationList.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateRevocationList.BackgroundImage = global::CertificateManager.Properties.Resources.Agreement_02;
            this.btnGenerateRevocationList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateRevocationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRevocationList.Location = new System.Drawing.Point(576, 12);
            this.btnGenerateRevocationList.Name = "btnGenerateRevocationList";
            this.btnGenerateRevocationList.Padding = new System.Windows.Forms.Padding(5);
            this.btnGenerateRevocationList.Size = new System.Drawing.Size(182, 196);
            this.btnGenerateRevocationList.TabIndex = 4;
            this.btnGenerateRevocationList.Text = "Criar Lista de Revogação";
            this.btnGenerateRevocationList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateRevocationList.UseVisualStyleBackColor = true;
            this.btnGenerateRevocationList.Click += new System.EventHandler(this.btnGenerateRevocationList_Click);
            // 
            // btnGenerateEndUserCertificate
            // 
            this.btnGenerateEndUserCertificate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateEndUserCertificate.BackgroundImage = global::CertificateManager.Properties.Resources.ID_New;
            this.btnGenerateEndUserCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateEndUserCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateEndUserCertificate.Location = new System.Drawing.Point(388, 12);
            this.btnGenerateEndUserCertificate.Name = "btnGenerateEndUserCertificate";
            this.btnGenerateEndUserCertificate.Padding = new System.Windows.Forms.Padding(5);
            this.btnGenerateEndUserCertificate.Size = new System.Drawing.Size(182, 196);
            this.btnGenerateEndUserCertificate.TabIndex = 3;
            this.btnGenerateEndUserCertificate.Text = "Gerar Certificado End User";
            this.btnGenerateEndUserCertificate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateEndUserCertificate.UseVisualStyleBackColor = true;
            this.btnGenerateEndUserCertificate.Click += new System.EventHandler(this.btnGenerateEndUserCertificate_Click);
            // 
            // btnGenerateServerCertificate
            // 
            this.btnGenerateServerCertificate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateServerCertificate.BackgroundImage = global::CertificateManager.Properties.Resources.Server_Certificate;
            this.btnGenerateServerCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateServerCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateServerCertificate.Location = new System.Drawing.Point(200, 12);
            this.btnGenerateServerCertificate.Name = "btnGenerateServerCertificate";
            this.btnGenerateServerCertificate.Padding = new System.Windows.Forms.Padding(5);
            this.btnGenerateServerCertificate.Size = new System.Drawing.Size(182, 196);
            this.btnGenerateServerCertificate.TabIndex = 2;
            this.btnGenerateServerCertificate.Text = "Gerar Certificado Servidor";
            this.btnGenerateServerCertificate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateServerCertificate.UseVisualStyleBackColor = true;
            this.btnGenerateServerCertificate.Click += new System.EventHandler(this.btnGenerateServerCertificate_Click);
            // 
            // btnGenerateCA
            // 
            this.btnGenerateCA.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateCA.BackgroundImage = global::CertificateManager.Properties.Resources.CACertificate;
            this.btnGenerateCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCA.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateCA.Name = "btnGenerateCA";
            this.btnGenerateCA.Padding = new System.Windows.Forms.Padding(5);
            this.btnGenerateCA.Size = new System.Drawing.Size(182, 196);
            this.btnGenerateCA.TabIndex = 1;
            this.btnGenerateCA.Text = "Gerar CA";
            this.btnGenerateCA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateCA.UseVisualStyleBackColor = true;
            this.btnGenerateCA.Click += new System.EventHandler(this.btnGenerateCA_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::CertificateManager.Properties.Resources.Branch_Engineering;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(388, 214);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(182, 196);
            this.button2.TabIndex = 8;
            this.button2.Text = "PEM -> DER";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 439);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGenerateSelfSign);
            this.Controls.Add(this.btnConvertFormat);
            this.Controls.Add(this.btnGenerateSubCA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerateRevocationList);
            this.Controls.Add(this.btnGenerateEndUserCertificate);
            this.Controls.Add(this.btnGenerateServerCertificate);
            this.Controls.Add(this.btnGenerateCA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de certificados";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.Button btnGenerateServerCertificate;
        private System.Windows.Forms.Button btnGenerateEndUserCertificate;
        private System.Windows.Forms.Button btnGenerateRevocationList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerateCA;
        private System.Windows.Forms.Button btnGenerateSubCA;
        private System.Windows.Forms.Button btnConvertFormat;
        private System.Windows.Forms.Button btnGenerateSelfSign;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

