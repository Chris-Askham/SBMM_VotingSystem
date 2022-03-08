namespace SBMMVotingSystem.Forms.SubForms
{
    partial class ucUserLoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdminHeaderText = new System.Windows.Forms.Label();
            this.lblUserNotificationText = new System.Windows.Forms.Label();
            this.btnCancelLogin = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnLogin = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.txtPassword = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtUsername = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(330, 204);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 20);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(330, 274);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 20);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblAdminHeaderText
            // 
            this.lblAdminHeaderText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdminHeaderText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHeaderText.Location = new System.Drawing.Point(35, 61);
            this.lblAdminHeaderText.Name = "lblAdminHeaderText";
            this.lblAdminHeaderText.Size = new System.Drawing.Size(914, 37);
            this.lblAdminHeaderText.TabIndex = 18;
            this.lblAdminHeaderText.Text = "Please sign in";
            this.lblAdminHeaderText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserNotificationText
            // 
            this.lblUserNotificationText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserNotificationText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNotificationText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUserNotificationText.Location = new System.Drawing.Point(31, 344);
            this.lblUserNotificationText.Name = "lblUserNotificationText";
            this.lblUserNotificationText.Size = new System.Drawing.Size(918, 28);
            this.lblUserNotificationText.TabIndex = 19;
            this.lblUserNotificationText.Text = "*Not already a user? Click here to register.";
            this.lblUserNotificationText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserNotificationText.Click += new System.EventHandler(this.lblUserNotificationText_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancelLogin.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnCancelLogin.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnCancelLogin.BorderRadius = 10;
            this.btnCancelLogin.BorderSize = 2;
            this.btnCancelLogin.BTextColour = System.Drawing.Color.White;
            this.btnCancelLogin.FlatAppearance.BorderSize = 0;
            this.btnCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.ForeColor = System.Drawing.Color.White;
            this.btnCancelLogin.Location = new System.Drawing.Point(535, 424);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(144, 46);
            this.btnCancelLogin.TabIndex = 21;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.UseVisualStyleBackColor = false;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLogin.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnLogin.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 2;
            this.btnLogin.BTextColour = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(314, 424);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 46);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BorderColour = System.Drawing.Color.SlateBlue;
            this.txtPassword.BorderFocusColour = System.Drawing.Color.DarkSlateBlue;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.Location = new System.Drawing.Point(324, 300);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(342, 38);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BorderColour = System.Drawing.Color.SlateBlue;
            this.txtUsername.BorderFocusColour = System.Drawing.Color.DarkSlateBlue;
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsername.Location = new System.Drawing.Point(324, 230);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(342, 38);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // ucUserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnCancelLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUserNotificationText);
            this.Controls.Add(this.lblAdminHeaderText);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "ucUserLoginForm";
            this.Size = new System.Drawing.Size(984, 710);
            this.Load += new System.EventHandler(this.ucAdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedTextbox txtUsername;
        private CustomControls.RoundedTextbox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdminHeaderText;
        private System.Windows.Forms.Label lblUserNotificationText;
        private CustomControls.RoundedButton btnCancelLogin;
        private CustomControls.RoundedButton btnLogin;
    }
}
