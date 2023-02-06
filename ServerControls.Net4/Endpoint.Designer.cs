
namespace Opc.Ua.Server.Controls
{
    partial class Endpoint
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
            this.groupBoxSecuritySignAndEncrypt = new System.Windows.Forms.GroupBox();
            this.checkBoxAes128Sha256RsaPssSae = new System.Windows.Forms.CheckBox();
            this.checkBoxAes128Sha256RsaOaepSae = new System.Windows.Forms.CheckBox();
            this.checkBoxBasic256SHA256Sae = new System.Windows.Forms.CheckBox();
            this.checkBoxBasic256Sae = new System.Windows.Forms.CheckBox();
            this.checkBoxBasic128RSA15Sae = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxSecurityPoliciesSign = new System.Windows.Forms.GroupBox();
            this.checkBoxAes128Sha256RsaPssSign = new System.Windows.Forms.CheckBox();
            this.checkBoxAes128Sha256RsaOaepSign = new System.Windows.Forms.CheckBox();
            this.checkBoxBasic256SHA256Sign = new System.Windows.Forms.CheckBox();
            this.checkBoxBasic256Sign = new System.Windows.Forms.CheckBox();
            this.checkBoxBasic128RSA15Sign = new System.Windows.Forms.CheckBox();
            this.uaTcpAddressLabel = new System.Windows.Forms.Label();
            this.uaTcpAddressValue = new System.Windows.Forms.TextBox();
            this.securityTcpModeLabel = new System.Windows.Forms.Label();
            this.checkBoxNoneTcp = new System.Windows.Forms.CheckBox();
            this.checkBoxSignTcp = new System.Windows.Forms.CheckBox();
            this.checkBoxSignEncryptTcp = new System.Windows.Forms.CheckBox();
            this.uaHttpsAddressLabel = new System.Windows.Forms.Label();
            this.uaHttpsAddressValue = new System.Windows.Forms.TextBox();
            this.checkBoxSignHttps = new System.Windows.Forms.CheckBox();
            this.applySettingsButton = new System.Windows.Forms.Button();
            this.securityHttpsModeLabel = new System.Windows.Forms.Label();
            this.groupBoxSecuritySignAndEncrypt.SuspendLayout();
            this.groupBoxSecurityPoliciesSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSecuritySignAndEncrypt
            // 
            this.groupBoxSecuritySignAndEncrypt.Controls.Add(this.checkBoxAes128Sha256RsaPssSae);
            this.groupBoxSecuritySignAndEncrypt.Controls.Add(this.checkBoxAes128Sha256RsaOaepSae);
            this.groupBoxSecuritySignAndEncrypt.Controls.Add(this.checkBoxBasic256SHA256Sae);
            this.groupBoxSecuritySignAndEncrypt.Controls.Add(this.checkBoxBasic256Sae);
            this.groupBoxSecuritySignAndEncrypt.Controls.Add(this.checkBoxBasic128RSA15Sae);
            this.groupBoxSecuritySignAndEncrypt.Location = new System.Drawing.Point(688, 206);
            this.groupBoxSecuritySignAndEncrypt.Name = "groupBoxSecuritySignAndEncrypt";
            this.groupBoxSecuritySignAndEncrypt.Size = new System.Drawing.Size(234, 248);
            this.groupBoxSecuritySignAndEncrypt.TabIndex = 0;
            this.groupBoxSecuritySignAndEncrypt.TabStop = false;
            this.groupBoxSecuritySignAndEncrypt.Text = "Security Policies";
            // 
            // checkBoxAes128Sha256RsaPssSae
            // 
            this.checkBoxAes128Sha256RsaPssSae.AutoSize = true;
            this.checkBoxAes128Sha256RsaPssSae.Location = new System.Drawing.Point(24, 144);
            this.checkBoxAes128Sha256RsaPssSae.Name = "checkBoxAes128Sha256RsaPssSae";
            this.checkBoxAes128Sha256RsaPssSae.Size = new System.Drawing.Size(175, 21);
            this.checkBoxAes128Sha256RsaPssSae.TabIndex = 1;
            this.checkBoxAes128Sha256RsaPssSae.Text = "Aes128Sha256RsaPss";
            this.checkBoxAes128Sha256RsaPssSae.UseVisualStyleBackColor = true;
            // 
            // checkBoxAes128Sha256RsaOaepSae
            // 
            this.checkBoxAes128Sha256RsaOaepSae.AutoSize = true;
            this.checkBoxAes128Sha256RsaOaepSae.Location = new System.Drawing.Point(24, 117);
            this.checkBoxAes128Sha256RsaOaepSae.Name = "checkBoxAes128Sha256RsaOaepSae";
            this.checkBoxAes128Sha256RsaOaepSae.Size = new System.Drawing.Size(187, 21);
            this.checkBoxAes128Sha256RsaOaepSae.TabIndex = 2;
            this.checkBoxAes128Sha256RsaOaepSae.Text = "Aes128Sha256RsaOaep";
            this.checkBoxAes128Sha256RsaOaepSae.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasic256SHA256Sae
            // 
            this.checkBoxBasic256SHA256Sae.AutoSize = true;
            this.checkBoxBasic256SHA256Sae.Location = new System.Drawing.Point(24, 90);
            this.checkBoxBasic256SHA256Sae.Name = "checkBoxBasic256SHA256Sae";
            this.checkBoxBasic256SHA256Sae.Size = new System.Drawing.Size(140, 21);
            this.checkBoxBasic256SHA256Sae.TabIndex = 3;
            this.checkBoxBasic256SHA256Sae.Text = "Basic256SHA256";
            this.checkBoxBasic256SHA256Sae.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasic256Sae
            // 
            this.checkBoxBasic256Sae.AutoSize = true;
            this.checkBoxBasic256Sae.Location = new System.Drawing.Point(24, 63);
            this.checkBoxBasic256Sae.Name = "checkBoxBasic256Sae";
            this.checkBoxBasic256Sae.Size = new System.Drawing.Size(88, 21);
            this.checkBoxBasic256Sae.TabIndex = 4;
            this.checkBoxBasic256Sae.Text = "Basic256";
            this.checkBoxBasic256Sae.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasic128RSA15Sae
            // 
            this.checkBoxBasic128RSA15Sae.AutoSize = true;
            this.checkBoxBasic128RSA15Sae.Location = new System.Drawing.Point(24, 36);
            this.checkBoxBasic128RSA15Sae.Name = "checkBoxBasic128RSA15Sae";
            this.checkBoxBasic128RSA15Sae.Size = new System.Drawing.Size(132, 21);
            this.checkBoxBasic128RSA15Sae.TabIndex = 5;
            this.checkBoxBasic128RSA15Sae.Text = "Basic128RSA15";
            this.checkBoxBasic128RSA15Sae.UseVisualStyleBackColor = true;
            // 
            // groupBoxSecurityPoliciesSign
            // 
            this.groupBoxSecurityPoliciesSign.Controls.Add(this.checkBoxAes128Sha256RsaPssSign);
            this.groupBoxSecurityPoliciesSign.Controls.Add(this.checkBoxAes128Sha256RsaOaepSign);
            this.groupBoxSecurityPoliciesSign.Controls.Add(this.checkBoxBasic256SHA256Sign);
            this.groupBoxSecurityPoliciesSign.Controls.Add(this.checkBoxBasic256Sign);
            this.groupBoxSecurityPoliciesSign.Controls.Add(this.checkBoxBasic128RSA15Sign);
            this.groupBoxSecurityPoliciesSign.Location = new System.Drawing.Point(388, 208);
            this.groupBoxSecurityPoliciesSign.Name = "groupBoxSecurityPoliciesSign";
            this.groupBoxSecurityPoliciesSign.Size = new System.Drawing.Size(221, 246);
            this.groupBoxSecurityPoliciesSign.TabIndex = 1;
            this.groupBoxSecurityPoliciesSign.TabStop = false;
            this.groupBoxSecurityPoliciesSign.Text = "Security Policies";
            // 
            // checkBoxAes128Sha256RsaPssSign
            // 
            this.checkBoxAes128Sha256RsaPssSign.AutoSize = true;
            this.checkBoxAes128Sha256RsaPssSign.Location = new System.Drawing.Point(17, 142);
            this.checkBoxAes128Sha256RsaPssSign.Name = "checkBoxAes128Sha256RsaPssSign";
            this.checkBoxAes128Sha256RsaPssSign.Size = new System.Drawing.Size(175, 21);
            this.checkBoxAes128Sha256RsaPssSign.TabIndex = 0;
            this.checkBoxAes128Sha256RsaPssSign.Text = "Aes128Sha256RsaPss";
            this.checkBoxAes128Sha256RsaPssSign.UseVisualStyleBackColor = true;
            // 
            // checkBoxAes128Sha256RsaOaepSign
            // 
            this.checkBoxAes128Sha256RsaOaepSign.AutoSize = true;
            this.checkBoxAes128Sha256RsaOaepSign.Location = new System.Drawing.Point(17, 115);
            this.checkBoxAes128Sha256RsaOaepSign.Name = "checkBoxAes128Sha256RsaOaepSign";
            this.checkBoxAes128Sha256RsaOaepSign.Size = new System.Drawing.Size(187, 21);
            this.checkBoxAes128Sha256RsaOaepSign.TabIndex = 0;
            this.checkBoxAes128Sha256RsaOaepSign.Text = "Aes128Sha256RsaOaep";
            this.checkBoxAes128Sha256RsaOaepSign.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasic256SHA256Sign
            // 
            this.checkBoxBasic256SHA256Sign.AutoSize = true;
            this.checkBoxBasic256SHA256Sign.Location = new System.Drawing.Point(17, 88);
            this.checkBoxBasic256SHA256Sign.Name = "checkBoxBasic256SHA256Sign";
            this.checkBoxBasic256SHA256Sign.Size = new System.Drawing.Size(140, 21);
            this.checkBoxBasic256SHA256Sign.TabIndex = 0;
            this.checkBoxBasic256SHA256Sign.Text = "Basic256SHA256";
            this.checkBoxBasic256SHA256Sign.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasic256Sign
            // 
            this.checkBoxBasic256Sign.AutoSize = true;
            this.checkBoxBasic256Sign.Location = new System.Drawing.Point(17, 61);
            this.checkBoxBasic256Sign.Name = "checkBoxBasic256Sign";
            this.checkBoxBasic256Sign.Size = new System.Drawing.Size(88, 21);
            this.checkBoxBasic256Sign.TabIndex = 0;
            this.checkBoxBasic256Sign.Text = "Basic256";
            this.checkBoxBasic256Sign.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasic128RSA15Sign
            // 
            this.checkBoxBasic128RSA15Sign.AutoSize = true;
            this.checkBoxBasic128RSA15Sign.Location = new System.Drawing.Point(17, 34);
            this.checkBoxBasic128RSA15Sign.Name = "checkBoxBasic128RSA15Sign";
            this.checkBoxBasic128RSA15Sign.Size = new System.Drawing.Size(132, 21);
            this.checkBoxBasic128RSA15Sign.TabIndex = 0;
            this.checkBoxBasic128RSA15Sign.Text = "Basic128RSA15";
            this.checkBoxBasic128RSA15Sign.UseVisualStyleBackColor = true;
            this.checkBoxBasic128RSA15Sign.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // uaTcpAddressLabel
            // 
            this.uaTcpAddressLabel.AutoSize = true;
            this.uaTcpAddressLabel.Location = new System.Drawing.Point(58, 43);
            this.uaTcpAddressLabel.Name = "uaTcpAddressLabel";
            this.uaTcpAddressLabel.Size = new System.Drawing.Size(132, 17);
            this.uaTcpAddressLabel.TabIndex = 2;
            this.uaTcpAddressLabel.Text = "UA TCP ADDRESS:";
            // 
            // uaTcpAddressValue
            // 
            this.uaTcpAddressValue.Location = new System.Drawing.Point(252, 26);
            this.uaTcpAddressValue.Multiline = true;
            this.uaTcpAddressValue.Name = "uaTcpAddressValue";
            this.uaTcpAddressValue.Size = new System.Drawing.Size(267, 34);
            this.uaTcpAddressValue.TabIndex = 3;
            // 
            // securityTcpModeLabel
            // 
            this.securityTcpModeLabel.AutoSize = true;
            this.securityTcpModeLabel.Location = new System.Drawing.Point(58, 109);
            this.securityTcpModeLabel.Name = "securityTcpModeLabel";
            this.securityTcpModeLabel.Size = new System.Drawing.Size(98, 17);
            this.securityTcpModeLabel.TabIndex = 2;
            this.securityTcpModeLabel.Text = "Security Mode";
            // 
            // checkBoxNoneTcp
            // 
            this.checkBoxNoneTcp.AutoSize = true;
            this.checkBoxNoneTcp.Location = new System.Drawing.Point(189, 108);
            this.checkBoxNoneTcp.Name = "checkBoxNoneTcp";
            this.checkBoxNoneTcp.Size = new System.Drawing.Size(64, 21);
            this.checkBoxNoneTcp.TabIndex = 4;
            this.checkBoxNoneTcp.Text = "None";
            this.checkBoxNoneTcp.UseVisualStyleBackColor = true;
            // 
            // checkBoxSignTcp
            // 
            this.checkBoxSignTcp.AutoSize = true;
            this.checkBoxSignTcp.Location = new System.Drawing.Point(447, 105);
            this.checkBoxSignTcp.Name = "checkBoxSignTcp";
            this.checkBoxSignTcp.Size = new System.Drawing.Size(58, 21);
            this.checkBoxSignTcp.TabIndex = 4;
            this.checkBoxSignTcp.Text = "Sign";
            this.checkBoxSignTcp.UseVisualStyleBackColor = true;
            this.checkBoxSignTcp.CheckedChanged += new System.EventHandler(this.checkBoxSignTcp_CheckedChanged);
            // 
            // checkBoxSignEncryptTcp
            // 
            this.checkBoxSignEncryptTcp.AutoSize = true;
            this.checkBoxSignEncryptTcp.Location = new System.Drawing.Point(712, 109);
            this.checkBoxSignEncryptTcp.Name = "checkBoxSignEncryptTcp";
            this.checkBoxSignEncryptTcp.Size = new System.Drawing.Size(137, 21);
            this.checkBoxSignEncryptTcp.TabIndex = 4;
            this.checkBoxSignEncryptTcp.Text = "Sign and encrypt";
            this.checkBoxSignEncryptTcp.UseVisualStyleBackColor = true;
            this.checkBoxSignEncryptTcp.CheckedChanged += new System.EventHandler(this.checkBoxSignEncryptTcp_CheckedChanged);
            // 
            // uaHttpsAddressLabel
            // 
            this.uaHttpsAddressLabel.AutoSize = true;
            this.uaHttpsAddressLabel.Location = new System.Drawing.Point(80, 483);
            this.uaHttpsAddressLabel.Name = "uaHttpsAddressLabel";
            this.uaHttpsAddressLabel.Size = new System.Drawing.Size(141, 17);
            this.uaHttpsAddressLabel.TabIndex = 2;
            this.uaHttpsAddressLabel.Text = "UA HTTPS ADRESS:";
            // 
            // uaHttpsAddressValue
            // 
            this.uaHttpsAddressValue.Location = new System.Drawing.Point(252, 460);
            this.uaHttpsAddressValue.Multiline = true;
            this.uaHttpsAddressValue.Name = "uaHttpsAddressValue";
            this.uaHttpsAddressValue.Size = new System.Drawing.Size(267, 42);
            this.uaHttpsAddressValue.TabIndex = 3;
            // 
            // checkBoxSignHttps
            // 
            this.checkBoxSignHttps.AutoSize = true;
            this.checkBoxSignHttps.Location = new System.Drawing.Point(252, 550);
            this.checkBoxSignHttps.Name = "checkBoxSignHttps";
            this.checkBoxSignHttps.Size = new System.Drawing.Size(58, 21);
            this.checkBoxSignHttps.TabIndex = 7;
            this.checkBoxSignHttps.Text = "Sign";
            this.checkBoxSignHttps.UseVisualStyleBackColor = true;
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Location = new System.Drawing.Point(742, 524);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(157, 42);
            this.applySettingsButton.TabIndex = 8;
            this.applySettingsButton.Text = "APPLY SETTINGS";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            this.applySettingsButton.Click += new System.EventHandler(this.applySettingsButton_Click);
            // 
            // securityHttpsModeLabel
            // 
            this.securityHttpsModeLabel.AutoSize = true;
            this.securityHttpsModeLabel.Location = new System.Drawing.Point(58, 550);
            this.securityHttpsModeLabel.Name = "securityHttpsModeLabel";
            this.securityHttpsModeLabel.Size = new System.Drawing.Size(98, 17);
            this.securityHttpsModeLabel.TabIndex = 2;
            this.securityHttpsModeLabel.Text = "Security Mode";
            // 
            // Endpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.applySettingsButton);
            this.Controls.Add(this.checkBoxSignHttps);
            this.Controls.Add(this.checkBoxSignEncryptTcp);
            this.Controls.Add(this.checkBoxSignTcp);
            this.Controls.Add(this.checkBoxNoneTcp);
            this.Controls.Add(this.uaHttpsAddressValue);
            this.Controls.Add(this.uaTcpAddressValue);
            this.Controls.Add(this.securityHttpsModeLabel);
            this.Controls.Add(this.securityTcpModeLabel);
            this.Controls.Add(this.uaHttpsAddressLabel);
            this.Controls.Add(this.uaTcpAddressLabel);
            this.Controls.Add(this.groupBoxSecurityPoliciesSign);
            this.Controls.Add(this.groupBoxSecuritySignAndEncrypt);
            this.Name = "Endpoint";
            this.Size = new System.Drawing.Size(974, 598);
            this.groupBoxSecuritySignAndEncrypt.ResumeLayout(false);
            this.groupBoxSecuritySignAndEncrypt.PerformLayout();
            this.groupBoxSecurityPoliciesSign.ResumeLayout(false);
            this.groupBoxSecurityPoliciesSign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSecuritySignAndEncrypt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxSecurityPoliciesSign;
        private System.Windows.Forms.CheckBox checkBoxAes128Sha256RsaPssSign;
        private System.Windows.Forms.CheckBox checkBoxAes128Sha256RsaOaepSign;
        private System.Windows.Forms.CheckBox checkBoxBasic256SHA256Sign;
        private System.Windows.Forms.CheckBox checkBoxBasic256Sign;
        private System.Windows.Forms.CheckBox checkBoxBasic128RSA15Sign;
        private System.Windows.Forms.CheckBox checkBoxAes128Sha256RsaPssSae;
        private System.Windows.Forms.CheckBox checkBoxAes128Sha256RsaOaepSae;
        private System.Windows.Forms.CheckBox checkBoxBasic256SHA256Sae;
        private System.Windows.Forms.CheckBox checkBoxBasic256Sae;
        private System.Windows.Forms.CheckBox checkBoxBasic128RSA15Sae;
        private System.Windows.Forms.Label uaTcpAddressLabel;
        private System.Windows.Forms.TextBox uaTcpAddressValue;
        private System.Windows.Forms.Label securityTcpModeLabel;
        private System.Windows.Forms.CheckBox checkBoxNoneTcp;
        private System.Windows.Forms.CheckBox checkBoxSignTcp;
        private System.Windows.Forms.CheckBox checkBoxSignEncryptTcp;
        private System.Windows.Forms.Label uaHttpsAddressLabel;
        private System.Windows.Forms.TextBox uaHttpsAddressValue;
        private System.Windows.Forms.CheckBox checkBoxSignHttps;
        private System.Windows.Forms.Button applySettingsButton;
        private System.Windows.Forms.Label securityHttpsModeLabel;
    }
}
