namespace SBMMVotingSystem.Forms.SubForms
{
    partial class ucVotingManagementForm
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
            this.lblElectionDetails = new System.Windows.Forms.Label();
            this.lstVotingInstances = new System.Windows.Forms.ListView();
            this.lstPossibleVotingOptions = new System.Windows.Forms.ListView();
            this.lblPossibleElections = new System.Windows.Forms.Label();
            this.lblElectionName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.lblElectionNameText = new System.Windows.Forms.Label();
            this.btnUpdateInstance = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnDeleteSelected = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnAddNew = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.lblShowDeactivatedElections = new System.Windows.Forms.Label();
            this.tbtnShowDeactivatedUsers = new SBMMVotingSystem.CustomControls.ToggleButton();
            this.SuspendLayout();
            // 
            // lblElectionDetails
            // 
            this.lblElectionDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionDetails.AutoSize = true;
            this.lblElectionDetails.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblElectionDetails.Location = new System.Drawing.Point(548, 123);
            this.lblElectionDetails.Name = "lblElectionDetails";
            this.lblElectionDetails.Size = new System.Drawing.Size(143, 25);
            this.lblElectionDetails.TabIndex = 56;
            this.lblElectionDetails.Text = "Election Details";
            // 
            // lstVotingInstances
            // 
            this.lstVotingInstances.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstVotingInstances.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstVotingInstances.HideSelection = false;
            this.lstVotingInstances.Location = new System.Drawing.Point(83, 146);
            this.lstVotingInstances.Name = "lstVotingInstances";
            this.lstVotingInstances.Size = new System.Drawing.Size(403, 464);
            this.lstVotingInstances.TabIndex = 58;
            this.lstVotingInstances.UseCompatibleStateImageBehavior = false;
            this.lstVotingInstances.View = System.Windows.Forms.View.Tile;
            this.lstVotingInstances.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstVotingInstances_ItemSelectionChanged);
            // 
            // lstPossibleVotingOptions
            // 
            this.lstPossibleVotingOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstPossibleVotingOptions.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstPossibleVotingOptions.Enabled = false;
            this.lstPossibleVotingOptions.HideSelection = false;
            this.lstPossibleVotingOptions.Location = new System.Drawing.Point(548, 336);
            this.lstPossibleVotingOptions.Name = "lstPossibleVotingOptions";
            this.lstPossibleVotingOptions.Size = new System.Drawing.Size(334, 274);
            this.lstPossibleVotingOptions.TabIndex = 59;
            this.lstPossibleVotingOptions.UseCompatibleStateImageBehavior = false;
            // 
            // lblPossibleElections
            // 
            this.lblPossibleElections.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPossibleElections.AutoSize = true;
            this.lblPossibleElections.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblPossibleElections.Location = new System.Drawing.Point(88, 65);
            this.lblPossibleElections.Name = "lblPossibleElections";
            this.lblPossibleElections.Size = new System.Drawing.Size(161, 25);
            this.lblPossibleElections.TabIndex = 60;
            this.lblPossibleElections.Text = "Possible elections";
            // 
            // lblElectionName
            // 
            this.lblElectionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionName.AutoSize = true;
            this.lblElectionName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionName.Location = new System.Drawing.Point(587, 155);
            this.lblElectionName.Name = "lblElectionName";
            this.lblElectionName.Size = new System.Drawing.Size(51, 17);
            this.lblElectionName.TabIndex = 63;
            this.lblElectionName.Text = "Name: ";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(492, 186);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 29);
            this.lblDescription.TabIndex = 64;
            this.lblDescription.Text = "Description: ";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(574, 230);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 66;
            this.lblAddress.Text = "Address: ";
            // 
            // lblAddressText
            // 
            this.lblAddressText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressText.Location = new System.Drawing.Point(644, 230);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(18, 20);
            this.lblAddressText.TabIndex = 69;
            this.lblAddressText.Text = "...";
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescriptionText.AutoSize = true;
            this.lblDescriptionText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionText.Location = new System.Drawing.Point(644, 186);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(18, 20);
            this.lblDescriptionText.TabIndex = 68;
            this.lblDescriptionText.Text = "...";
            // 
            // lblElectionNameText
            // 
            this.lblElectionNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionNameText.AutoSize = true;
            this.lblElectionNameText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionNameText.Location = new System.Drawing.Point(644, 155);
            this.lblElectionNameText.Name = "lblElectionNameText";
            this.lblElectionNameText.Size = new System.Drawing.Size(18, 20);
            this.lblElectionNameText.TabIndex = 67;
            this.lblElectionNameText.Text = "...";
            // 
            // btnUpdateInstance
            // 
            this.btnUpdateInstance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateInstance.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUpdateInstance.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnUpdateInstance.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdateInstance.BorderRadius = 10;
            this.btnUpdateInstance.BorderSize = 2;
            this.btnUpdateInstance.BTextColour = System.Drawing.Color.White;
            this.btnUpdateInstance.Enabled = false;
            this.btnUpdateInstance.FlatAppearance.BorderSize = 0;
            this.btnUpdateInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInstance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInstance.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInstance.Location = new System.Drawing.Point(227, 93);
            this.btnUpdateInstance.Name = "btnUpdateInstance";
            this.btnUpdateInstance.Size = new System.Drawing.Size(116, 47);
            this.btnUpdateInstance.TabIndex = 70;
            this.btnUpdateInstance.Text = "Update selected";
            this.btnUpdateInstance.UseVisualStyleBackColor = false;
            this.btnUpdateInstance.Click += new System.EventHandler(this.btnUpdateInstance_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteSelected.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDeleteSelected.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnDeleteSelected.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteSelected.BorderRadius = 10;
            this.btnDeleteSelected.BorderSize = 2;
            this.btnDeleteSelected.BTextColour = System.Drawing.Color.White;
            this.btnDeleteSelected.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelected.Location = new System.Drawing.Point(370, 93);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(116, 47);
            this.btnDeleteSelected.TabIndex = 62;
            this.btnDeleteSelected.Text = "Delete selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNew.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddNew.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnAddNew.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnAddNew.BorderRadius = 10;
            this.btnAddNew.BorderSize = 2;
            this.btnAddNew.BTextColour = System.Drawing.Color.White;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(83, 93);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(116, 47);
            this.btnAddNew.TabIndex = 61;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblShowDeactivatedElections
            // 
            this.lblShowDeactivatedElections.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowDeactivatedElections.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDeactivatedElections.Location = new System.Drawing.Point(134, 613);
            this.lblShowDeactivatedElections.Name = "lblShowDeactivatedElections";
            this.lblShowDeactivatedElections.Size = new System.Drawing.Size(240, 34);
            this.lblShowDeactivatedElections.TabIndex = 72;
            this.lblShowDeactivatedElections.Text = "Show/Hide deactivated elections";
            // 
            // tbtnShowDeactivatedUsers
            // 
            this.tbtnShowDeactivatedUsers.AutoSize = true;
            this.tbtnShowDeactivatedUsers.Location = new System.Drawing.Point(83, 613);
            this.tbtnShowDeactivatedUsers.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbtnShowDeactivatedUsers.Name = "tbtnShowDeactivatedUsers";
            this.tbtnShowDeactivatedUsers.OffBackColor = System.Drawing.Color.Gray;
            this.tbtnShowDeactivatedUsers.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtnShowDeactivatedUsers.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtnShowDeactivatedUsers.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtnShowDeactivatedUsers.Size = new System.Drawing.Size(45, 22);
            this.tbtnShowDeactivatedUsers.TabIndex = 71;
            this.tbtnShowDeactivatedUsers.UseVisualStyleBackColor = true;
            this.tbtnShowDeactivatedUsers.CheckedChanged += new System.EventHandler(this.tbtnShowDeactivatedUsers_CheckedChanged);
            // 
            // ucVotingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblShowDeactivatedElections);
            this.Controls.Add(this.tbtnShowDeactivatedUsers);
            this.Controls.Add(this.btnUpdateInstance);
            this.Controls.Add(this.lblAddressText);
            this.Controls.Add(this.lblDescriptionText);
            this.Controls.Add(this.lblElectionNameText);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblElectionName);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblPossibleElections);
            this.Controls.Add(this.lstPossibleVotingOptions);
            this.Controls.Add(this.lstVotingInstances);
            this.Controls.Add(this.lblElectionDetails);
            this.Name = "ucVotingManagementForm";
            this.Size = new System.Drawing.Size(984, 710);
            this.Load += new System.EventHandler(this.ucVotingManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblElectionDetails;
        private System.Windows.Forms.ListView lstVotingInstances;
        private System.Windows.Forms.ListView lstPossibleVotingOptions;
        private System.Windows.Forms.Label lblPossibleElections;
        private CustomControls.RoundedButton btnAddNew;
        private CustomControls.RoundedButton btnDeleteSelected;
        private System.Windows.Forms.Label lblElectionName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblDescriptionText;
        private System.Windows.Forms.Label lblElectionNameText;
        private CustomControls.RoundedButton btnUpdateInstance;
        private System.Windows.Forms.Label lblShowDeactivatedElections;
        private CustomControls.ToggleButton tbtnShowDeactivatedUsers;
    }
}
