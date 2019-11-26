namespace CertificateManager.UserControls
{
    partial class KeyUsageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkbKeyCertSign = new System.Windows.Forms.CheckBox();
            this.chkbKeyAgreement = new System.Windows.Forms.CheckBox();
            this.chkbNonRepudiation = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkbDigitalSignature = new System.Windows.Forms.CheckBox();
            this.chkbKeyEncipherment = new System.Windows.Forms.CheckBox();
            this.chkbDataEncipherment = new System.Windows.Forms.CheckBox();
            this.chkbCrlSign = new System.Windows.Forms.CheckBox();
            this.chkbEncipherOnly = new System.Windows.Forms.CheckBox();
            this.chkbDecipherOnly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkbKeyCertSign
            // 
            this.chkbKeyCertSign.AutoSize = true;
            this.chkbKeyCertSign.Location = new System.Drawing.Point(3, 129);
            this.chkbKeyCertSign.Name = "chkbKeyCertSign";
            this.chkbKeyCertSign.Size = new System.Drawing.Size(125, 17);
            this.chkbKeyCertSign.TabIndex = 6;
            this.chkbKeyCertSign.Text = "Assinaturade chaves";
            this.chkbKeyCertSign.UseVisualStyleBackColor = true;
            // 
            // chkbKeyAgreement
            // 
            this.chkbKeyAgreement.AutoSize = true;
            this.chkbKeyAgreement.Location = new System.Drawing.Point(3, 107);
            this.chkbKeyAgreement.Name = "chkbKeyAgreement";
            this.chkbKeyAgreement.Size = new System.Drawing.Size(113, 17);
            this.chkbKeyAgreement.TabIndex = 5;
            this.chkbKeyAgreement.Text = "Acordo de chaves";
            this.chkbKeyAgreement.UseVisualStyleBackColor = true;
            // 
            // chkbNonRepudiation
            // 
            this.chkbNonRepudiation.AutoSize = true;
            this.chkbNonRepudiation.Location = new System.Drawing.Point(3, 41);
            this.chkbNonRepudiation.Name = "chkbNonRepudiation";
            this.chkbNonRepudiation.Size = new System.Drawing.Size(102, 17);
            this.chkbNonRepudiation.TabIndex = 2;
            this.chkbNonRepudiation.Text = "Não repudiação";
            this.chkbNonRepudiation.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Uso";
            // 
            // chkbDigitalSignature
            // 
            this.chkbDigitalSignature.AutoSize = true;
            this.chkbDigitalSignature.Location = new System.Drawing.Point(3, 19);
            this.chkbDigitalSignature.Name = "chkbDigitalSignature";
            this.chkbDigitalSignature.Size = new System.Drawing.Size(105, 17);
            this.chkbDigitalSignature.TabIndex = 1;
            this.chkbDigitalSignature.Text = "Assinatura digital";
            this.chkbDigitalSignature.UseVisualStyleBackColor = true;
            // 
            // chkbKeyEncipherment
            // 
            this.chkbKeyEncipherment.AutoSize = true;
            this.chkbKeyEncipherment.Location = new System.Drawing.Point(3, 63);
            this.chkbKeyEncipherment.Name = "chkbKeyEncipherment";
            this.chkbKeyEncipherment.Size = new System.Drawing.Size(130, 17);
            this.chkbKeyEncipherment.TabIndex = 3;
            this.chkbKeyEncipherment.Text = "Encritação de chaves";
            this.chkbKeyEncipherment.UseVisualStyleBackColor = true;
            // 
            // chkbDataEncipherment
            // 
            this.chkbDataEncipherment.AutoSize = true;
            this.chkbDataEncipherment.Location = new System.Drawing.Point(3, 85);
            this.chkbDataEncipherment.Name = "chkbDataEncipherment";
            this.chkbDataEncipherment.Size = new System.Drawing.Size(124, 17);
            this.chkbDataEncipherment.TabIndex = 4;
            this.chkbDataEncipherment.Text = "Encritação de dados";
            this.chkbDataEncipherment.UseVisualStyleBackColor = true;
            // 
            // chkbCrlSign
            // 
            this.chkbCrlSign.AutoSize = true;
            this.chkbCrlSign.Location = new System.Drawing.Point(3, 151);
            this.chkbCrlSign.Name = "chkbCrlSign";
            this.chkbCrlSign.Size = new System.Drawing.Size(116, 17);
            this.chkbCrlSign.TabIndex = 7;
            this.chkbCrlSign.Text = "Assinatura de listas";
            this.chkbCrlSign.UseVisualStyleBackColor = true;
            // 
            // chkbEncipherOnly
            // 
            this.chkbEncipherOnly.AutoSize = true;
            this.chkbEncipherOnly.Location = new System.Drawing.Point(3, 173);
            this.chkbEncipherOnly.Name = "chkbEncipherOnly";
            this.chkbEncipherOnly.Size = new System.Drawing.Size(121, 17);
            this.chkbEncipherOnly.TabIndex = 8;
            this.chkbEncipherOnly.Text = "Apenas encriptação";
            this.chkbEncipherOnly.UseVisualStyleBackColor = true;
            // 
            // chkbDecipherOnly
            // 
            this.chkbDecipherOnly.AutoSize = true;
            this.chkbDecipherOnly.Location = new System.Drawing.Point(3, 195);
            this.chkbDecipherOnly.Name = "chkbDecipherOnly";
            this.chkbDecipherOnly.Size = new System.Drawing.Size(132, 17);
            this.chkbDecipherOnly.TabIndex = 9;
            this.chkbDecipherOnly.Text = "Apenas desencritação";
            this.chkbDecipherOnly.UseVisualStyleBackColor = true;
            // 
            // KeyUsageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkbDecipherOnly);
            this.Controls.Add(this.chkbEncipherOnly);
            this.Controls.Add(this.chkbCrlSign);
            this.Controls.Add(this.chkbDataEncipherment);
            this.Controls.Add(this.chkbKeyEncipherment);
            this.Controls.Add(this.chkbKeyCertSign);
            this.Controls.Add(this.chkbKeyAgreement);
            this.Controls.Add(this.chkbNonRepudiation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkbDigitalSignature);
            this.Name = "KeyUsageControl";
            this.Size = new System.Drawing.Size(139, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbKeyCertSign;
        private System.Windows.Forms.CheckBox chkbKeyAgreement;
        private System.Windows.Forms.CheckBox chkbNonRepudiation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkbDigitalSignature;
        private System.Windows.Forms.CheckBox chkbKeyEncipherment;
        private System.Windows.Forms.CheckBox chkbDataEncipherment;
        private System.Windows.Forms.CheckBox chkbCrlSign;
        private System.Windows.Forms.CheckBox chkbEncipherOnly;
        private System.Windows.Forms.CheckBox chkbDecipherOnly;

    }
}
