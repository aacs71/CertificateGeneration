namespace CertificateManager.UserControls
{
    partial class KeyPurposeControl
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
            this.label8 = new System.Windows.Forms.Label();
            this.chkbIdKPOcspSigning = new System.Windows.Forms.CheckBox();
            this.chkbIdKPTimeStamping = new System.Windows.Forms.CheckBox();
            this.chkbIdKPIpsecUser = new System.Windows.Forms.CheckBox();
            this.chkbIdKPEmailProtection = new System.Windows.Forms.CheckBox();
            this.chkbIdKPCodeSigning = new System.Windows.Forms.CheckBox();
            this.chkbIdKPIpsecTunnel = new System.Windows.Forms.CheckBox();
            this.chkbIdKPIpsecEndSystem = new System.Windows.Forms.CheckBox();
            this.chkbIdKPClientAuth = new System.Windows.Forms.CheckBox();
            this.chkbIdKPServerAuth = new System.Windows.Forms.CheckBox();
            this.chkbIdKPSmartCardLogon = new System.Windows.Forms.CheckBox();
            this.chkbAnyExtendedKeyUsage = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Propósito";
            // 
            // chkbIdKPOcspSigning
            // 
            this.chkbIdKPOcspSigning.AutoSize = true;
            this.chkbIdKPOcspSigning.Location = new System.Drawing.Point(3, 195);
            this.chkbIdKPOcspSigning.Name = "chkbIdKPOcspSigning";
            this.chkbIdKPOcspSigning.Size = new System.Drawing.Size(107, 17);
            this.chkbIdKPOcspSigning.TabIndex = 9;
            this.chkbIdKPOcspSigning.Text = "Assinatura OCSP";
            this.chkbIdKPOcspSigning.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPTimeStamping
            // 
            this.chkbIdKPTimeStamping.AutoSize = true;
            this.chkbIdKPTimeStamping.Location = new System.Drawing.Point(3, 173);
            this.chkbIdKPTimeStamping.Name = "chkbIdKPTimeStamping";
            this.chkbIdKPTimeStamping.Size = new System.Drawing.Size(117, 17);
            this.chkbIdKPTimeStamping.TabIndex = 8;
            this.chkbIdKPTimeStamping.Text = "Marcação temporal";
            this.chkbIdKPTimeStamping.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPIpsecUser
            // 
            this.chkbIdKPIpsecUser.AutoSize = true;
            this.chkbIdKPIpsecUser.Location = new System.Drawing.Point(3, 151);
            this.chkbIdKPIpsecUser.Name = "chkbIdKPIpsecUser";
            this.chkbIdKPIpsecUser.Size = new System.Drawing.Size(97, 17);
            this.chkbIdKPIpsecUser.TabIndex = 7;
            this.chkbIdKPIpsecUser.Text = "IPSEC (cliente)";
            this.chkbIdKPIpsecUser.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPEmailProtection
            // 
            this.chkbIdKPEmailProtection.AutoSize = true;
            this.chkbIdKPEmailProtection.Location = new System.Drawing.Point(3, 85);
            this.chkbIdKPEmailProtection.Name = "chkbIdKPEmailProtection";
            this.chkbIdKPEmailProtection.Size = new System.Drawing.Size(117, 17);
            this.chkbIdKPEmailProtection.TabIndex = 4;
            this.chkbIdKPEmailProtection.Text = "Protecção de email";
            this.chkbIdKPEmailProtection.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPCodeSigning
            // 
            this.chkbIdKPCodeSigning.AutoSize = true;
            this.chkbIdKPCodeSigning.Location = new System.Drawing.Point(3, 63);
            this.chkbIdKPCodeSigning.Name = "chkbIdKPCodeSigning";
            this.chkbIdKPCodeSigning.Size = new System.Drawing.Size(125, 17);
            this.chkbIdKPCodeSigning.TabIndex = 3;
            this.chkbIdKPCodeSigning.Text = "Assinatura de código";
            this.chkbIdKPCodeSigning.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPIpsecTunnel
            // 
            this.chkbIdKPIpsecTunnel.AutoSize = true;
            this.chkbIdKPIpsecTunnel.Location = new System.Drawing.Point(3, 129);
            this.chkbIdKPIpsecTunnel.Name = "chkbIdKPIpsecTunnel";
            this.chkbIdKPIpsecTunnel.Size = new System.Drawing.Size(89, 17);
            this.chkbIdKPIpsecTunnel.TabIndex = 6;
            this.chkbIdKPIpsecTunnel.Text = "IPSEC (tunel)";
            this.chkbIdKPIpsecTunnel.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPIpsecEndSystem
            // 
            this.chkbIdKPIpsecEndSystem.AutoSize = true;
            this.chkbIdKPIpsecEndSystem.Location = new System.Drawing.Point(3, 107);
            this.chkbIdKPIpsecEndSystem.Name = "chkbIdKPIpsecEndSystem";
            this.chkbIdKPIpsecEndSystem.Size = new System.Drawing.Size(101, 17);
            this.chkbIdKPIpsecEndSystem.TabIndex = 5;
            this.chkbIdKPIpsecEndSystem.Text = "IPSEC (sistema)";
            this.chkbIdKPIpsecEndSystem.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPClientAuth
            // 
            this.chkbIdKPClientAuth.AutoSize = true;
            this.chkbIdKPClientAuth.Location = new System.Drawing.Point(3, 41);
            this.chkbIdKPClientAuth.Name = "chkbIdKPClientAuth";
            this.chkbIdKPClientAuth.Size = new System.Drawing.Size(123, 17);
            this.chkbIdKPClientAuth.TabIndex = 2;
            this.chkbIdKPClientAuth.Text = "Autenticação cliente";
            this.chkbIdKPClientAuth.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPServerAuth
            // 
            this.chkbIdKPServerAuth.AutoSize = true;
            this.chkbIdKPServerAuth.Location = new System.Drawing.Point(3, 19);
            this.chkbIdKPServerAuth.Name = "chkbIdKPServerAuth";
            this.chkbIdKPServerAuth.Size = new System.Drawing.Size(129, 17);
            this.chkbIdKPServerAuth.TabIndex = 1;
            this.chkbIdKPServerAuth.Text = "Autenticação servidor";
            this.chkbIdKPServerAuth.UseVisualStyleBackColor = true;
            // 
            // chkbIdKPSmartCardLogon
            // 
            this.chkbIdKPSmartCardLogon.AutoSize = true;
            this.chkbIdKPSmartCardLogon.Location = new System.Drawing.Point(3, 217);
            this.chkbIdKPSmartCardLogon.Name = "chkbIdKPSmartCardLogon";
            this.chkbIdKPSmartCardLogon.Size = new System.Drawing.Size(111, 17);
            this.chkbIdKPSmartCardLogon.TabIndex = 10;
            this.chkbIdKPSmartCardLogon.Text = "Logon Smart Card";
            this.chkbIdKPSmartCardLogon.UseVisualStyleBackColor = true;
            // 
            // chkbAnyExtendedKeyUsage
            // 
            this.chkbAnyExtendedKeyUsage.AutoSize = true;
            this.chkbAnyExtendedKeyUsage.Location = new System.Drawing.Point(3, 239);
            this.chkbAnyExtendedKeyUsage.Name = "chkbAnyExtendedKeyUsage";
            this.chkbAnyExtendedKeyUsage.Size = new System.Drawing.Size(89, 17);
            this.chkbAnyExtendedKeyUsage.TabIndex = 11;
            this.chkbAnyExtendedKeyUsage.Text = "Qualquer uso";
            this.chkbAnyExtendedKeyUsage.UseVisualStyleBackColor = true;
            // 
            // KeyPurposeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkbAnyExtendedKeyUsage);
            this.Controls.Add(this.chkbIdKPSmartCardLogon);
            this.Controls.Add(this.chkbIdKPOcspSigning);
            this.Controls.Add(this.chkbIdKPTimeStamping);
            this.Controls.Add(this.chkbIdKPIpsecUser);
            this.Controls.Add(this.chkbIdKPEmailProtection);
            this.Controls.Add(this.chkbIdKPCodeSigning);
            this.Controls.Add(this.chkbIdKPIpsecTunnel);
            this.Controls.Add(this.chkbIdKPIpsecEndSystem);
            this.Controls.Add(this.chkbIdKPClientAuth);
            this.Controls.Add(this.chkbIdKPServerAuth);
            this.Controls.Add(this.label8);
            this.Name = "KeyPurposeControl";
            this.Size = new System.Drawing.Size(133, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkbIdKPOcspSigning;
        private System.Windows.Forms.CheckBox chkbIdKPTimeStamping;
        private System.Windows.Forms.CheckBox chkbIdKPIpsecUser;
        private System.Windows.Forms.CheckBox chkbIdKPEmailProtection;
        private System.Windows.Forms.CheckBox chkbIdKPCodeSigning;
        private System.Windows.Forms.CheckBox chkbIdKPIpsecTunnel;
        private System.Windows.Forms.CheckBox chkbIdKPIpsecEndSystem;
        private System.Windows.Forms.CheckBox chkbIdKPClientAuth;
        private System.Windows.Forms.CheckBox chkbIdKPServerAuth;
        private System.Windows.Forms.CheckBox chkbIdKPSmartCardLogon;
        private System.Windows.Forms.CheckBox chkbAnyExtendedKeyUsage;
    }
}
