namespace SBMMVotingSystem.Forms
{
    partial class frmMainGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGui));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnHome = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.lblHeaderLabel = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnESFlag = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnFRFlag = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnENFlag = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnMinimise = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnMaximise = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnCloseGUI = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlTitleBar.Controls.Add(this.btnESFlag);
            this.pnlTitleBar.Controls.Add(this.btnFRFlag);
            this.pnlTitleBar.Controls.Add(this.btnENFlag);
            this.pnlTitleBar.Controls.Add(this.btnHome);
            this.pnlTitleBar.Controls.Add(this.lblLoggedInAs);
            this.pnlTitleBar.Controls.Add(this.btnMinimise);
            this.pnlTitleBar.Controls.Add(this.btnMaximise);
            this.pnlTitleBar.Controls.Add(this.btnCloseGUI);
            this.pnlTitleBar.Controls.Add(this.lblHeaderLabel);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(984, 79);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnHome.BackgroundColour = System.Drawing.Color.DarkSlateBlue;
            this.btnHome.BorderColour = System.Drawing.Color.GhostWhite;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 2;
            this.btnHome.BTextColour = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(884, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(96, 33);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInAs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoggedInAs.Location = new System.Drawing.Point(15, 49);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(114, 21);
            this.lblLoggedInAs.TabIndex = 24;
            this.lblLoggedInAs.Text = "Logged in as: ";
            this.lblLoggedInAs.Visible = false;
            this.lblLoggedInAs.Click += new System.EventHandler(this.lblLoggedInAs_Click);
            // 
            // lblHeaderLabel
            // 
            this.lblHeaderLabel.AutoSize = true;
            this.lblHeaderLabel.Font = new System.Drawing.Font("Segoe UI Historic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeaderLabel.Location = new System.Drawing.Point(12, 6);
            this.lblHeaderLabel.Name = "lblHeaderLabel";
            this.lblHeaderLabel.Size = new System.Drawing.Size(182, 37);
            this.lblHeaderLabel.TabIndex = 0;
            this.lblHeaderLabel.Text = "DASHBOARD";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Azure;
            this.pnlBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 79);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(984, 682);
            this.pnlBody.TabIndex = 2;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "11";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "22";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "4";
            // 
            // btnESFlag
            // 
            this.btnESFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnESFlag.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnESFlag.BackgroundColour = System.Drawing.Color.DarkSlateBlue;
            this.btnESFlag.BackgroundImage = global::SBMMVotingSystem.Properties.Resources.es_flag_out;
            this.btnESFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnESFlag.BorderColour = System.Drawing.Color.GhostWhite;
            this.btnESFlag.BorderRadius = 10;
            this.btnESFlag.BorderSize = 2;
            this.btnESFlag.BTextColour = System.Drawing.Color.White;
            this.btnESFlag.FlatAppearance.BorderSize = 0;
            this.btnESFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESFlag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnESFlag.ForeColor = System.Drawing.Color.White;
            this.btnESFlag.Location = new System.Drawing.Point(636, 12);
            this.btnESFlag.Name = "btnESFlag";
            this.btnESFlag.Size = new System.Drawing.Size(66, 48);
            this.btnESFlag.TabIndex = 28;
            this.btnESFlag.UseVisualStyleBackColor = false;
            this.btnESFlag.Click += new System.EventHandler(this.btnESFlag_Click);
            this.btnESFlag.MouseEnter += new System.EventHandler(this.btnESFlag_MouseEnter);
            this.btnESFlag.MouseLeave += new System.EventHandler(this.btnESFlag_MouseLeave);
            // 
            // btnFRFlag
            // 
            this.btnFRFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFRFlag.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFRFlag.BackgroundColour = System.Drawing.Color.DarkSlateBlue;
            this.btnFRFlag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFRFlag.BackgroundImage")));
            this.btnFRFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFRFlag.BorderColour = System.Drawing.Color.GhostWhite;
            this.btnFRFlag.BorderRadius = 10;
            this.btnFRFlag.BorderSize = 2;
            this.btnFRFlag.BTextColour = System.Drawing.Color.White;
            this.btnFRFlag.FlatAppearance.BorderSize = 0;
            this.btnFRFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFRFlag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFRFlag.ForeColor = System.Drawing.Color.White;
            this.btnFRFlag.Location = new System.Drawing.Point(780, 12);
            this.btnFRFlag.Name = "btnFRFlag";
            this.btnFRFlag.Size = new System.Drawing.Size(66, 48);
            this.btnFRFlag.TabIndex = 27;
            this.btnFRFlag.UseVisualStyleBackColor = false;
            this.btnFRFlag.Click += new System.EventHandler(this.btnFRFlag_Click);
            this.btnFRFlag.MouseEnter += new System.EventHandler(this.btnFRFlag_MouseEnter);
            this.btnFRFlag.MouseLeave += new System.EventHandler(this.btnFRFlag_MouseLeave);
            // 
            // btnENFlag
            // 
            this.btnENFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnENFlag.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnENFlag.BackgroundColour = System.Drawing.Color.DarkSlateBlue;
            this.btnENFlag.BackgroundImage = global::SBMMVotingSystem.Properties.Resources.en_flag_out;
            this.btnENFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnENFlag.BorderColour = System.Drawing.Color.GhostWhite;
            this.btnENFlag.BorderRadius = 10;
            this.btnENFlag.BorderSize = 2;
            this.btnENFlag.BTextColour = System.Drawing.Color.White;
            this.btnENFlag.FlatAppearance.BorderSize = 0;
            this.btnENFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnENFlag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnENFlag.ForeColor = System.Drawing.Color.White;
            this.btnENFlag.Location = new System.Drawing.Point(708, 12);
            this.btnENFlag.Name = "btnENFlag";
            this.btnENFlag.Size = new System.Drawing.Size(66, 48);
            this.btnENFlag.TabIndex = 26;
            this.btnENFlag.UseVisualStyleBackColor = false;
            this.btnENFlag.Click += new System.EventHandler(this.btnENFlag_Click);
            this.btnENFlag.MouseEnter += new System.EventHandler(this.btnENFlag_MouseEnter);
            this.btnENFlag.MouseLeave += new System.EventHandler(this.btnENFlag_MouseLeave);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimise.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimise.BackgroundColour = System.Drawing.Color.CornflowerBlue;
            this.btnMinimise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimise.BackgroundImage")));
            this.btnMinimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimise.BorderColour = System.Drawing.Color.RoyalBlue;
            this.btnMinimise.BorderRadius = 5;
            this.btnMinimise.BorderSize = 0;
            this.btnMinimise.BTextColour = System.Drawing.Color.White;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.ForeColor = System.Drawing.Color.White;
            this.btnMinimise.Location = new System.Drawing.Point(884, 9);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(28, 31);
            this.btnMinimise.TabIndex = 3;
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btnMaximise
            // 
            this.btnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximise.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximise.BackgroundColour = System.Drawing.Color.CornflowerBlue;
            this.btnMaximise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximise.BackgroundImage")));
            this.btnMaximise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximise.BorderColour = System.Drawing.Color.RoyalBlue;
            this.btnMaximise.BorderRadius = 5;
            this.btnMaximise.BorderSize = 0;
            this.btnMaximise.BTextColour = System.Drawing.Color.White;
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.ForeColor = System.Drawing.Color.White;
            this.btnMaximise.Location = new System.Drawing.Point(918, 9);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Size = new System.Drawing.Size(28, 31);
            this.btnMaximise.TabIndex = 2;
            this.btnMaximise.UseVisualStyleBackColor = false;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnCloseGUI
            // 
            this.btnCloseGUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseGUI.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCloseGUI.BackgroundColour = System.Drawing.Color.OrangeRed;
            this.btnCloseGUI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseGUI.BackgroundImage")));
            this.btnCloseGUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseGUI.BorderColour = System.Drawing.Color.DarkRed;
            this.btnCloseGUI.BorderRadius = 5;
            this.btnCloseGUI.BorderSize = 0;
            this.btnCloseGUI.BTextColour = System.Drawing.Color.White;
            this.btnCloseGUI.FlatAppearance.BorderSize = 0;
            this.btnCloseGUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseGUI.ForeColor = System.Drawing.Color.White;
            this.btnCloseGUI.Location = new System.Drawing.Point(952, 9);
            this.btnCloseGUI.Name = "btnCloseGUI";
            this.btnCloseGUI.Size = new System.Drawing.Size(28, 31);
            this.btnCloseGUI.TabIndex = 1;
            this.btnCloseGUI.UseVisualStyleBackColor = false;
            this.btnCloseGUI.Click += new System.EventHandler(this.btnCloseGUI_Click);
            // 
            // frmMainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitleBar);
            this.Name = "frmMainGui";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.frmMainGui_Resize);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlBody;
        private CustomControls.RoundedButton btnMinimise;
        private CustomControls.RoundedButton btnMaximise;
        private CustomControls.RoundedButton btnCloseGUI;
        private System.Windows.Forms.Label lblHeaderLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private CustomControls.RoundedButton btnHome;
        private System.Windows.Forms.Label lblLoggedInAs;
        private CustomControls.RoundedButton btnFRFlag;
        private CustomControls.RoundedButton btnENFlag;
        private CustomControls.RoundedButton btnESFlag;
    }
}

