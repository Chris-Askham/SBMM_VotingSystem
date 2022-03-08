namespace SBMMVotingSystem.Forms.SubForms
{
    partial class ucUsersManagementForm
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
            this.lstUserGrid = new System.Windows.Forms.ListView();
            this.ccolUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHasVoted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRefNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbtnShowDeactivatedUsers = new SBMMVotingSystem.CustomControls.ToggleButton();
            this.lblShowDeactivatedUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUserGrid
            // 
            this.lstUserGrid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstUserGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstUserGrid.CheckBoxes = true;
            this.lstUserGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ccolUserId,
            this.colUsername,
            this.colFirstName,
            this.colLastName,
            this.colAddress,
            this.colAge,
            this.colHasVoted,
            this.colRefNumber,
            this.colEnabled});
            this.lstUserGrid.GridLines = true;
            this.lstUserGrid.HideSelection = false;
            this.lstUserGrid.Location = new System.Drawing.Point(21, 60);
            this.lstUserGrid.Name = "lstUserGrid";
            this.lstUserGrid.Size = new System.Drawing.Size(937, 630);
            this.lstUserGrid.TabIndex = 21;
            this.lstUserGrid.UseCompatibleStateImageBehavior = false;
            this.lstUserGrid.View = System.Windows.Forms.View.Details;
            this.lstUserGrid.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstUserGrid_ItemCheck);
            // 
            // ccolUserId
            // 
            this.ccolUserId.Text = "User Id";
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 120;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First name";
            this.colFirstName.Width = 120;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last name";
            this.colLastName.Width = 120;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 240;
            // 
            // colAge
            // 
            this.colAge.DisplayIndex = 6;
            this.colAge.Text = "Age";
            this.colAge.Width = 42;
            // 
            // colHasVoted
            // 
            this.colHasVoted.DisplayIndex = 5;
            this.colHasVoted.Text = "Has voted?";
            this.colHasVoted.Width = 70;
            // 
            // colRefNumber
            // 
            this.colRefNumber.Text = "Ref Number";
            this.colRefNumber.Width = 90;
            // 
            // colEnabled
            // 
            this.colEnabled.Text = "Enabled";
            // 
            // tbtnShowDeactivatedUsers
            // 
            this.tbtnShowDeactivatedUsers.AutoSize = true;
            this.tbtnShowDeactivatedUsers.Location = new System.Drawing.Point(667, 23);
            this.tbtnShowDeactivatedUsers.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbtnShowDeactivatedUsers.Name = "tbtnShowDeactivatedUsers";
            this.tbtnShowDeactivatedUsers.OffBackColor = System.Drawing.Color.Gray;
            this.tbtnShowDeactivatedUsers.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtnShowDeactivatedUsers.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtnShowDeactivatedUsers.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtnShowDeactivatedUsers.Size = new System.Drawing.Size(45, 22);
            this.tbtnShowDeactivatedUsers.TabIndex = 23;
            this.tbtnShowDeactivatedUsers.UseVisualStyleBackColor = true;
            this.tbtnShowDeactivatedUsers.CheckedChanged += new System.EventHandler(this.tbtnShowDeactivatedUsers_CheckedChanged);
            // 
            // lblShowDeactivatedUsers
            // 
            this.lblShowDeactivatedUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowDeactivatedUsers.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDeactivatedUsers.Location = new System.Drawing.Point(718, 23);
            this.lblShowDeactivatedUsers.Name = "lblShowDeactivatedUsers";
            this.lblShowDeactivatedUsers.Size = new System.Drawing.Size(240, 34);
            this.lblShowDeactivatedUsers.TabIndex = 66;
            this.lblShowDeactivatedUsers.Text = "Show/Hide deactivated users";
            // 
            // ucUsersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblShowDeactivatedUsers);
            this.Controls.Add(this.tbtnShowDeactivatedUsers);
            this.Controls.Add(this.lstUserGrid);
            this.Name = "ucUsersManagementForm";
            this.Size = new System.Drawing.Size(984, 710);
            this.Load += new System.EventHandler(this.ucUsersManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstUserGrid;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colAge;
        private System.Windows.Forms.ColumnHeader colHasVoted;
        private System.Windows.Forms.ColumnHeader colRefNumber;
        private System.Windows.Forms.ColumnHeader ccolUserId;
        private CustomControls.ToggleButton tbtnShowDeactivatedUsers;
        private System.Windows.Forms.Label lblShowDeactivatedUsers;
        private System.Windows.Forms.ColumnHeader colEnabled;
    }
}
