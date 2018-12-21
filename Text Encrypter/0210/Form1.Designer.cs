namespace LinMaggieTextEncrypter
{
    partial class FormTextEncrypter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextEncrypter));
            this.pnlNewPassword = new System.Windows.Forms.Panel();
            this.btnNewPasswordCancel = new System.Windows.Forms.Button();
            this.btnNewPasswordOK = new System.Windows.Forms.Button();
            this.txtNewPasswordConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemEncryption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEncryptionEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEncryptionDecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUserChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUserLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAboutAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAboutResetApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCurrentPassword = new System.Windows.Forms.Panel();
            this.btnCurrentPasswordCancel = new System.Windows.Forms.Button();
            this.btnCurrentPasswordOK = new System.Windows.Forms.Button();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.picLogoWelcome = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnWelcomeCreatePassword = new System.Windows.Forms.Button();
            this.btnWelcomeLogin = new System.Windows.Forms.Button();
            this.pnlEncrypt = new System.Windows.Forms.Panel();
            this.chkPrintChar = new System.Windows.Forms.CheckBox();
            this.btnEncryptAction = new System.Windows.Forms.Button();
            this.btnEncryptClearAll = new System.Windows.Forms.Button();
            this.btnEncryptCopyOutput = new System.Windows.Forms.Button();
            this.btnEncryptPaste = new System.Windows.Forms.Button();
            this.lblEncryptOutput = new System.Windows.Forms.Label();
            this.lblEncryptInput = new System.Windows.Forms.Label();
            this.txtEncryptOutput = new System.Windows.Forms.TextBox();
            this.txtEncryptInput = new System.Windows.Forms.TextBox();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.picLogoAbout = new System.Windows.Forms.PictureBox();
            this.btnAboutOK = new System.Windows.Forms.Button();
            this.pnlNewPassword.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pnlCurrentPassword.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoWelcome)).BeginInit();
            this.pnlEncrypt.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNewPassword
            // 
            this.pnlNewPassword.Controls.Add(this.btnNewPasswordCancel);
            this.pnlNewPassword.Controls.Add(this.btnNewPasswordOK);
            this.pnlNewPassword.Controls.Add(this.txtNewPasswordConfirmPassword);
            this.pnlNewPassword.Controls.Add(this.txtNewPasswordPassword);
            this.pnlNewPassword.Controls.Add(this.lblConfirmPassword);
            this.pnlNewPassword.Controls.Add(this.lblCreatePassword);
            this.pnlNewPassword.Location = new System.Drawing.Point(0, 24);
            this.pnlNewPassword.Name = "pnlNewPassword";
            this.pnlNewPassword.Size = new System.Drawing.Size(384, 337);
            this.pnlNewPassword.TabIndex = 0;
            // 
            // btnNewPasswordCancel
            // 
            this.btnNewPasswordCancel.Location = new System.Drawing.Point(281, 311);
            this.btnNewPasswordCancel.Name = "btnNewPasswordCancel";
            this.btnNewPasswordCancel.Size = new System.Drawing.Size(100, 23);
            this.btnNewPasswordCancel.TabIndex = 5;
            this.btnNewPasswordCancel.Text = "Cancel";
            this.btnNewPasswordCancel.UseVisualStyleBackColor = true;
            this.btnNewPasswordCancel.Click += new System.EventHandler(this.btnNewPasswordCancel_Click);
            // 
            // btnNewPasswordOK
            // 
            this.btnNewPasswordOK.Location = new System.Drawing.Point(175, 311);
            this.btnNewPasswordOK.Name = "btnNewPasswordOK";
            this.btnNewPasswordOK.Size = new System.Drawing.Size(100, 23);
            this.btnNewPasswordOK.TabIndex = 4;
            this.btnNewPasswordOK.Text = "OK";
            this.btnNewPasswordOK.UseVisualStyleBackColor = true;
            this.btnNewPasswordOK.Click += new System.EventHandler(this.btnNewPasswordOK_Click);
            // 
            // txtNewPasswordConfirmPassword
            // 
            this.txtNewPasswordConfirmPassword.Location = new System.Drawing.Point(101, 189);
            this.txtNewPasswordConfirmPassword.Name = "txtNewPasswordConfirmPassword";
            this.txtNewPasswordConfirmPassword.PasswordChar = '•';
            this.txtNewPasswordConfirmPassword.Size = new System.Drawing.Size(185, 20);
            this.txtNewPasswordConfirmPassword.TabIndex = 3;
            // 
            // txtNewPasswordPassword
            // 
            this.txtNewPasswordPassword.Location = new System.Drawing.Point(101, 144);
            this.txtNewPasswordPassword.Name = "txtNewPasswordPassword";
            this.txtNewPasswordPassword.PasswordChar = '•';
            this.txtNewPasswordPassword.Size = new System.Drawing.Size(185, 20);
            this.txtNewPasswordPassword.TabIndex = 2;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(98, 173);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 1;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(98, 128);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(81, 13);
            this.lblCreatePassword.TabIndex = 0;
            this.lblCreatePassword.Text = "New Password:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEncryption,
            this.menuItemUser,
            this.menuItemAbout,
            this.menuItemExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuItemEncryption
            // 
            this.menuItemEncryption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEncryptionEncrypt,
            this.menuItemEncryptionDecrypt});
            this.menuItemEncryption.Name = "menuItemEncryption";
            this.menuItemEncryption.Size = new System.Drawing.Size(76, 20);
            this.menuItemEncryption.Text = "Encryption";
            // 
            // menuItemEncryptionEncrypt
            // 
            this.menuItemEncryptionEncrypt.Name = "menuItemEncryptionEncrypt";
            this.menuItemEncryptionEncrypt.Size = new System.Drawing.Size(152, 22);
            this.menuItemEncryptionEncrypt.Text = "Encrypt Text";
            this.menuItemEncryptionEncrypt.Click += new System.EventHandler(this.menuItemEncryptionEncrypt_Click);
            // 
            // menuItemEncryptionDecrypt
            // 
            this.menuItemEncryptionDecrypt.Name = "menuItemEncryptionDecrypt";
            this.menuItemEncryptionDecrypt.Size = new System.Drawing.Size(152, 22);
            this.menuItemEncryptionDecrypt.Text = "Decrypt Text";
            this.menuItemEncryptionDecrypt.Click += new System.EventHandler(this.menuItemEncryptionDecrypt_Click);
            // 
            // menuItemUser
            // 
            this.menuItemUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUserChangePassword,
            this.menuItemUserLogout});
            this.menuItemUser.Name = "menuItemUser";
            this.menuItemUser.Size = new System.Drawing.Size(42, 20);
            this.menuItemUser.Text = "User";
            // 
            // menuItemUserChangePassword
            // 
            this.menuItemUserChangePassword.Name = "menuItemUserChangePassword";
            this.menuItemUserChangePassword.Size = new System.Drawing.Size(168, 22);
            this.menuItemUserChangePassword.Text = "Change Password";
            this.menuItemUserChangePassword.Click += new System.EventHandler(this.menuItemUserChangePassword_Click);
            // 
            // menuItemUserLogout
            // 
            this.menuItemUserLogout.Name = "menuItemUserLogout";
            this.menuItemUserLogout.Size = new System.Drawing.Size(168, 22);
            this.menuItemUserLogout.Text = "Logout";
            this.menuItemUserLogout.Click += new System.EventHandler(this.menuItemUserLogout_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAboutAbout,
            this.toolStripMenuItem1,
            this.menuItemAboutResetApplication});
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.menuItemAbout.Text = "About";
            // 
            // menuItemAboutAbout
            // 
            this.menuItemAboutAbout.Name = "menuItemAboutAbout";
            this.menuItemAboutAbout.Size = new System.Drawing.Size(185, 22);
            this.menuItemAboutAbout.Text = "About Text Encrypter";
            this.menuItemAboutAbout.Click += new System.EventHandler(this.menuItemAboutAbout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // menuItemAboutResetApplication
            // 
            this.menuItemAboutResetApplication.Name = "menuItemAboutResetApplication";
            this.menuItemAboutResetApplication.Size = new System.Drawing.Size(185, 22);
            this.menuItemAboutResetApplication.Text = "Reset Application";
            this.menuItemAboutResetApplication.Click += new System.EventHandler(this.menuItemAboutResetApplication_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(37, 20);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // pnlCurrentPassword
            // 
            this.pnlCurrentPassword.Controls.Add(this.btnCurrentPasswordCancel);
            this.pnlCurrentPassword.Controls.Add(this.btnCurrentPasswordOK);
            this.pnlCurrentPassword.Controls.Add(this.txtCurrentPassword);
            this.pnlCurrentPassword.Controls.Add(this.lblCurrentPassword);
            this.pnlCurrentPassword.Location = new System.Drawing.Point(0, 367);
            this.pnlCurrentPassword.Name = "pnlCurrentPassword";
            this.pnlCurrentPassword.Size = new System.Drawing.Size(384, 337);
            this.pnlCurrentPassword.TabIndex = 6;
            // 
            // btnCurrentPasswordCancel
            // 
            this.btnCurrentPasswordCancel.Location = new System.Drawing.Point(281, 311);
            this.btnCurrentPasswordCancel.Name = "btnCurrentPasswordCancel";
            this.btnCurrentPasswordCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCurrentPasswordCancel.TabIndex = 5;
            this.btnCurrentPasswordCancel.Text = "Cancel";
            this.btnCurrentPasswordCancel.UseVisualStyleBackColor = true;
            this.btnCurrentPasswordCancel.Click += new System.EventHandler(this.btnCurrentPasswordCancel_Click);
            // 
            // btnCurrentPasswordOK
            // 
            this.btnCurrentPasswordOK.Location = new System.Drawing.Point(175, 311);
            this.btnCurrentPasswordOK.Name = "btnCurrentPasswordOK";
            this.btnCurrentPasswordOK.Size = new System.Drawing.Size(100, 23);
            this.btnCurrentPasswordOK.TabIndex = 4;
            this.btnCurrentPasswordOK.Text = "OK";
            this.btnCurrentPasswordOK.UseVisualStyleBackColor = true;
            this.btnCurrentPasswordOK.Click += new System.EventHandler(this.btnCurrentPasswordOK_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(101, 166);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '•';
            this.txtCurrentPassword.Size = new System.Drawing.Size(185, 20);
            this.txtCurrentPassword.TabIndex = 2;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(98, 150);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(56, 13);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Password:";
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.picLogoWelcome);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Controls.Add(this.btnWelcomeCreatePassword);
            this.pnlWelcome.Controls.Add(this.btnWelcomeLogin);
            this.pnlWelcome.Location = new System.Drawing.Point(780, 24);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(384, 337);
            this.pnlWelcome.TabIndex = 7;
            this.pnlWelcome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWelcome_Paint);
            // 
            // picLogoWelcome
            // 
            this.picLogoWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogoWelcome.Image = ((System.Drawing.Image)(resources.GetObject("picLogoWelcome.Image")));
            this.picLogoWelcome.Location = new System.Drawing.Point(158, 116);
            this.picLogoWelcome.Name = "picLogoWelcome";
            this.picLogoWelcome.Size = new System.Drawing.Size(68, 50);
            this.picLogoWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoWelcome.TabIndex = 13;
            this.picLogoWelcome.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(94, 172);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(197, 31);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Text Encrypter";
            // 
            // btnWelcomeCreatePassword
            // 
            this.btnWelcomeCreatePassword.Location = new System.Drawing.Point(281, 311);
            this.btnWelcomeCreatePassword.Name = "btnWelcomeCreatePassword";
            this.btnWelcomeCreatePassword.Size = new System.Drawing.Size(100, 23);
            this.btnWelcomeCreatePassword.TabIndex = 5;
            this.btnWelcomeCreatePassword.Text = " Create Password";
            this.btnWelcomeCreatePassword.UseVisualStyleBackColor = true;
            this.btnWelcomeCreatePassword.Click += new System.EventHandler(this.btnWelcomeCreatePassword_Click);
            // 
            // btnWelcomeLogin
            // 
            this.btnWelcomeLogin.Location = new System.Drawing.Point(175, 311);
            this.btnWelcomeLogin.Name = "btnWelcomeLogin";
            this.btnWelcomeLogin.Size = new System.Drawing.Size(100, 23);
            this.btnWelcomeLogin.TabIndex = 4;
            this.btnWelcomeLogin.Text = "Login";
            this.btnWelcomeLogin.UseVisualStyleBackColor = true;
            this.btnWelcomeLogin.Click += new System.EventHandler(this.btnWelcomeLogin_Click);
            // 
            // pnlEncrypt
            // 
            this.pnlEncrypt.Controls.Add(this.chkPrintChar);
            this.pnlEncrypt.Controls.Add(this.btnEncryptAction);
            this.pnlEncrypt.Controls.Add(this.btnEncryptClearAll);
            this.pnlEncrypt.Controls.Add(this.btnEncryptCopyOutput);
            this.pnlEncrypt.Controls.Add(this.btnEncryptPaste);
            this.pnlEncrypt.Controls.Add(this.lblEncryptOutput);
            this.pnlEncrypt.Controls.Add(this.lblEncryptInput);
            this.pnlEncrypt.Controls.Add(this.txtEncryptOutput);
            this.pnlEncrypt.Controls.Add(this.txtEncryptInput);
            this.pnlEncrypt.Location = new System.Drawing.Point(390, 367);
            this.pnlEncrypt.Name = "pnlEncrypt";
            this.pnlEncrypt.Size = new System.Drawing.Size(384, 337);
            this.pnlEncrypt.TabIndex = 6;
            // 
            // chkPrintChar
            // 
            this.chkPrintChar.AutoSize = true;
            this.chkPrintChar.Location = new System.Drawing.Point(118, 291);
            this.chkPrintChar.Name = "chkPrintChar";
            this.chkPrintChar.Size = new System.Drawing.Size(151, 17);
            this.chkPrintChar.TabIndex = 8;
            this.chkPrintChar.Text = "Skip non-ASCII characters";
            this.chkPrintChar.UseVisualStyleBackColor = true;
            // 
            // btnEncryptAction
            // 
            this.btnEncryptAction.Location = new System.Drawing.Point(142, 144);
            this.btnEncryptAction.Name = "btnEncryptAction";
            this.btnEncryptAction.Size = new System.Drawing.Size(100, 23);
            this.btnEncryptAction.TabIndex = 7;
            this.btnEncryptAction.Text = "Encrypt";
            this.btnEncryptAction.UseVisualStyleBackColor = true;
            this.btnEncryptAction.Click += new System.EventHandler(this.btnEncryptAction_Click);
            // 
            // btnEncryptClearAll
            // 
            this.btnEncryptClearAll.Location = new System.Drawing.Point(12, 287);
            this.btnEncryptClearAll.Name = "btnEncryptClearAll";
            this.btnEncryptClearAll.Size = new System.Drawing.Size(100, 23);
            this.btnEncryptClearAll.TabIndex = 6;
            this.btnEncryptClearAll.Text = "Clear All";
            this.btnEncryptClearAll.UseVisualStyleBackColor = true;
            this.btnEncryptClearAll.Click += new System.EventHandler(this.btnEncryptClearAll_Click);
            // 
            // btnEncryptCopyOutput
            // 
            this.btnEncryptCopyOutput.Location = new System.Drawing.Point(272, 175);
            this.btnEncryptCopyOutput.Name = "btnEncryptCopyOutput";
            this.btnEncryptCopyOutput.Size = new System.Drawing.Size(100, 23);
            this.btnEncryptCopyOutput.TabIndex = 5;
            this.btnEncryptCopyOutput.Text = "Copy Output";
            this.btnEncryptCopyOutput.UseVisualStyleBackColor = true;
            this.btnEncryptCopyOutput.Click += new System.EventHandler(this.btnEncryptCopyOutput_Click);
            // 
            // btnEncryptPaste
            // 
            this.btnEncryptPaste.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEncryptPaste.Location = new System.Drawing.Point(272, 27);
            this.btnEncryptPaste.Name = "btnEncryptPaste";
            this.btnEncryptPaste.Size = new System.Drawing.Size(100, 23);
            this.btnEncryptPaste.TabIndex = 4;
            this.btnEncryptPaste.Text = "Paste";
            this.btnEncryptPaste.UseVisualStyleBackColor = true;
            this.btnEncryptPaste.Click += new System.EventHandler(this.btnEncryptPaste_Click);
            // 
            // lblEncryptOutput
            // 
            this.lblEncryptOutput.AutoSize = true;
            this.lblEncryptOutput.Location = new System.Drawing.Point(12, 185);
            this.lblEncryptOutput.Name = "lblEncryptOutput";
            this.lblEncryptOutput.Size = new System.Drawing.Size(39, 13);
            this.lblEncryptOutput.TabIndex = 3;
            this.lblEncryptOutput.Text = "Output";
            // 
            // lblEncryptInput
            // 
            this.lblEncryptInput.AutoSize = true;
            this.lblEncryptInput.Location = new System.Drawing.Point(12, 37);
            this.lblEncryptInput.Name = "lblEncryptInput";
            this.lblEncryptInput.Size = new System.Drawing.Size(31, 13);
            this.lblEncryptInput.TabIndex = 2;
            this.lblEncryptInput.Text = "Input";
            // 
            // txtEncryptOutput
            // 
            this.txtEncryptOutput.Location = new System.Drawing.Point(12, 201);
            this.txtEncryptOutput.Multiline = true;
            this.txtEncryptOutput.Name = "txtEncryptOutput";
            this.txtEncryptOutput.ReadOnly = true;
            this.txtEncryptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncryptOutput.Size = new System.Drawing.Size(360, 80);
            this.txtEncryptOutput.TabIndex = 1;
            // 
            // txtEncryptInput
            // 
            this.txtEncryptInput.Location = new System.Drawing.Point(12, 53);
            this.txtEncryptInput.Multiline = true;
            this.txtEncryptInput.Name = "txtEncryptInput";
            this.txtEncryptInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncryptInput.Size = new System.Drawing.Size(360, 80);
            this.txtEncryptInput.TabIndex = 0;
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.txtAbout);
            this.pnlAbout.Controls.Add(this.picLogoAbout);
            this.pnlAbout.Controls.Add(this.btnAboutOK);
            this.pnlAbout.Location = new System.Drawing.Point(390, 24);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(384, 337);
            this.pnlAbout.TabIndex = 9;
            // 
            // txtAbout
            // 
            this.txtAbout.BackColor = System.Drawing.SystemColors.Control;
            this.txtAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbout.Location = new System.Drawing.Point(63, 222);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(259, 74);
            this.txtAbout.TabIndex = 12;
            this.txtAbout.Text = "Text Encrypter encrypts and decrypts text.\r\n\r\nVersion whoknows\r\n© Software 2018 M" +
    "L Inc.\r\nAll Rights Reserved.";
            // 
            // picLogoAbout
            // 
            this.picLogoAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogoAbout.Image = ((System.Drawing.Image)(resources.GetObject("picLogoAbout.Image")));
            this.picLogoAbout.Location = new System.Drawing.Point(50, 36);
            this.picLogoAbout.Name = "picLogoAbout";
            this.picLogoAbout.Size = new System.Drawing.Size(285, 180);
            this.picLogoAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoAbout.TabIndex = 8;
            this.picLogoAbout.TabStop = false;
            // 
            // btnAboutOK
            // 
            this.btnAboutOK.Location = new System.Drawing.Point(281, 311);
            this.btnAboutOK.Name = "btnAboutOK";
            this.btnAboutOK.Size = new System.Drawing.Size(100, 23);
            this.btnAboutOK.TabIndex = 7;
            this.btnAboutOK.Text = "OK";
            this.btnAboutOK.UseVisualStyleBackColor = true;
            this.btnAboutOK.Click += new System.EventHandler(this.btnAboutOK_Click);
            // 
            // FormTextEncrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 710);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.pnlCurrentPassword);
            this.Controls.Add(this.pnlEncrypt);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlNewPassword);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTextEncrypter";
            this.Text = "Text Encrypter";
            this.pnlNewPassword.ResumeLayout(false);
            this.pnlNewPassword.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlCurrentPassword.ResumeLayout(false);
            this.pnlCurrentPassword.PerformLayout();
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoWelcome)).EndInit();
            this.pnlEncrypt.ResumeLayout(false);
            this.pnlEncrypt.PerformLayout();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewPassword;
        private System.Windows.Forms.Button btnNewPasswordOK;
        private System.Windows.Forms.TextBox txtNewPasswordConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPasswordPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.Button btnNewPasswordCancel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemEncryption;
        private System.Windows.Forms.ToolStripMenuItem menuItemEncryptionEncrypt;
        private System.Windows.Forms.ToolStripMenuItem menuItemEncryptionDecrypt;
        private System.Windows.Forms.ToolStripMenuItem menuItemUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemUserChangePassword;
        private System.Windows.Forms.ToolStripMenuItem menuItemUserLogout;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuItemAboutAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAboutResetApplication;
        private System.Windows.Forms.Panel pnlCurrentPassword;
        private System.Windows.Forms.Button btnCurrentPasswordCancel;
        private System.Windows.Forms.Button btnCurrentPasswordOK;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnWelcomeCreatePassword;
        private System.Windows.Forms.Button btnWelcomeLogin;
        private System.Windows.Forms.Panel pnlEncrypt;
        private System.Windows.Forms.Label lblEncryptOutput;
        private System.Windows.Forms.Label lblEncryptInput;
        private System.Windows.Forms.TextBox txtEncryptOutput;
        private System.Windows.Forms.TextBox txtEncryptInput;
        private System.Windows.Forms.Button btnEncryptPaste;
        private System.Windows.Forms.Button btnEncryptAction;
        private System.Windows.Forms.Button btnEncryptClearAll;
        private System.Windows.Forms.Button btnEncryptCopyOutput;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Button btnAboutOK;
        private System.Windows.Forms.PictureBox picLogoAbout;
        private System.Windows.Forms.TextBox txtAbout;
        private System.Windows.Forms.PictureBox picLogoWelcome;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.CheckBox chkPrintChar;
    }
}

