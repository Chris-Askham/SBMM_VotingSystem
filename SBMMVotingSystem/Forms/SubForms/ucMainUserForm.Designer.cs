namespace SBMMVotingSystem.Forms.SubForms
{
    partial class ucMainUserForm
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
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.btnLogin = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnRegisterNewUser = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.Location = new System.Drawing.Point(385, 112);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(237, 65);
            this.lblWelcomeText.TabIndex = 2;
            this.lblWelcomeText.Text = "Welcome";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLogin.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnLogin.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 2;
            this.btnLogin.BTextColour = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(517, 260);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(219, 210);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegisterNewUser
            // 
            this.btnRegisterNewUser.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRegisterNewUser.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnRegisterNewUser.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnRegisterNewUser.BorderRadius = 10;
            this.btnRegisterNewUser.BorderSize = 2;
            this.btnRegisterNewUser.BTextColour = System.Drawing.Color.White;
            this.btnRegisterNewUser.FlatAppearance.BorderSize = 0;
            this.btnRegisterNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNewUser.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterNewUser.ForeColor = System.Drawing.Color.White;
            this.btnRegisterNewUser.Location = new System.Drawing.Point(258, 259);
            this.btnRegisterNewUser.Name = "btnRegisterNewUser";
            this.btnRegisterNewUser.Size = new System.Drawing.Size(220, 211);
            this.btnRegisterNewUser.TabIndex = 3;
            this.btnRegisterNewUser.Text = "Register";
            this.btnRegisterNewUser.UseVisualStyleBackColor = false;
            this.btnRegisterNewUser.Click += new System.EventHandler(this.btnRegisterNewUser_Click);
            // 
            // ucMainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegisterNewUser);
            this.Controls.Add(this.lblWelcomeText);
            this.Name = "ucMainUserForm";
            this.Size = new System.Drawing.Size(984, 710);
            this.Load += new System.EventHandler(this.ucMainUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeText;
        private CustomControls.RoundedButton btnRegisterNewUser;
        private CustomControls.RoundedButton btnLogin;
    }
}
