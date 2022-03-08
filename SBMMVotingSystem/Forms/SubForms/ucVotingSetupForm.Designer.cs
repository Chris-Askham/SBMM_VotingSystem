namespace SBMMVotingSystem.Forms.SubForms
{
    partial class ucVotingSetupForm
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
            this.lblAddressHeader = new System.Windows.Forms.Label();
            this.lblDecription = new System.Windows.Forms.Label();
            this.lblElectionName = new System.Windows.Forms.Label();
            this.lstVotingOptions = new System.Windows.Forms.ListView();
            this.lblVotingOptionDescription = new System.Windows.Forms.Label();
            this.lblVotingOptionName = new System.Windows.Forms.Label();
            this.lblVotingOptions = new System.Windows.Forms.Label();
            this.btnClearOptions = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnRemoveSelected = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnAddOption = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.txtOptionDescription = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtOptionName = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.btnCancelSetup = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnSubmitVotingInstance = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.txtDescription = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtElectionName = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtPostcode = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtCountry = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtAddress3 = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtAddress2 = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtAddress1 = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAddressLine3 = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.numVotingInstanceId = new System.Windows.Forms.NumericUpDown();
            this.tbtnEnabled = new SBMMVotingSystem.CustomControls.ToggleButton();
            this.lblEnabled = new System.Windows.Forms.Label();
            this.btnEndElection = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.cboElectionTypeDDList = new SBMMVotingSystem.CustomControls.CustomComboBox();
            this.lblElectionType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVotingInstanceId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddressHeader
            // 
            this.lblAddressHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressHeader.AutoSize = true;
            this.lblAddressHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressHeader.Location = new System.Drawing.Point(111, 275);
            this.lblAddressHeader.Name = "lblAddressHeader";
            this.lblAddressHeader.Size = new System.Drawing.Size(66, 20);
            this.lblAddressHeader.TabIndex = 37;
            this.lblAddressHeader.Text = "Address";
            // 
            // lblDecription
            // 
            this.lblDecription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecription.Location = new System.Drawing.Point(115, 121);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(89, 20);
            this.lblDecription.TabIndex = 41;
            this.lblDecription.Text = "Description";
            // 
            // lblElectionName
            // 
            this.lblElectionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionName.AutoSize = true;
            this.lblElectionName.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionName.Location = new System.Drawing.Point(115, 51);
            this.lblElectionName.Name = "lblElectionName";
            this.lblElectionName.Size = new System.Drawing.Size(107, 20);
            this.lblElectionName.TabIndex = 40;
            this.lblElectionName.Text = "Election name";
            // 
            // lstVotingOptions
            // 
            this.lstVotingOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstVotingOptions.HideSelection = false;
            this.lstVotingOptions.Location = new System.Drawing.Point(530, 296);
            this.lstVotingOptions.Name = "lstVotingOptions";
            this.lstVotingOptions.Size = new System.Drawing.Size(343, 138);
            this.lstVotingOptions.TabIndex = 44;
            this.lstVotingOptions.UseCompatibleStateImageBehavior = false;
            this.lstVotingOptions.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstVotingOptions_ItemSelectionChanged);
            // 
            // lblVotingOptionDescription
            // 
            this.lblVotingOptionDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVotingOptionDescription.AutoSize = true;
            this.lblVotingOptionDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotingOptionDescription.Location = new System.Drawing.Point(535, 144);
            this.lblVotingOptionDescription.Name = "lblVotingOptionDescription";
            this.lblVotingOptionDescription.Size = new System.Drawing.Size(76, 17);
            this.lblVotingOptionDescription.TabIndex = 48;
            this.lblVotingOptionDescription.Text = "Description";
            // 
            // lblVotingOptionName
            // 
            this.lblVotingOptionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVotingOptionName.AutoSize = true;
            this.lblVotingOptionName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotingOptionName.Location = new System.Drawing.Point(535, 76);
            this.lblVotingOptionName.Name = "lblVotingOptionName";
            this.lblVotingOptionName.Size = new System.Drawing.Size(44, 17);
            this.lblVotingOptionName.TabIndex = 47;
            this.lblVotingOptionName.Text = "Name";
            // 
            // lblVotingOptions
            // 
            this.lblVotingOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVotingOptions.AutoSize = true;
            this.lblVotingOptions.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotingOptions.Location = new System.Drawing.Point(534, 51);
            this.lblVotingOptions.Name = "lblVotingOptions";
            this.lblVotingOptions.Size = new System.Drawing.Size(112, 20);
            this.lblVotingOptions.TabIndex = 49;
            this.lblVotingOptions.Text = "Voting options";
            // 
            // btnClearOptions
            // 
            this.btnClearOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearOptions.BackColor = System.Drawing.Color.SlateBlue;
            this.btnClearOptions.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnClearOptions.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnClearOptions.BorderRadius = 10;
            this.btnClearOptions.BorderSize = 2;
            this.btnClearOptions.BTextColour = System.Drawing.Color.White;
            this.btnClearOptions.FlatAppearance.BorderSize = 0;
            this.btnClearOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOptions.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnClearOptions.ForeColor = System.Drawing.Color.White;
            this.btnClearOptions.Location = new System.Drawing.Point(774, 249);
            this.btnClearOptions.Name = "btnClearOptions";
            this.btnClearOptions.Size = new System.Drawing.Size(99, 34);
            this.btnClearOptions.TabIndex = 53;
            this.btnClearOptions.Text = "Clear options";
            this.btnClearOptions.UseVisualStyleBackColor = false;
            this.btnClearOptions.Click += new System.EventHandler(this.btnClearOptions_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveSelected.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRemoveSelected.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnRemoveSelected.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnRemoveSelected.BorderRadius = 10;
            this.btnRemoveSelected.BorderSize = 2;
            this.btnRemoveSelected.BTextColour = System.Drawing.Color.White;
            this.btnRemoveSelected.Enabled = false;
            this.btnRemoveSelected.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location = new System.Drawing.Point(651, 249);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(97, 34);
            this.btnRemoveSelected.TabIndex = 52;
            this.btnRemoveSelected.Text = "Remove selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnAddOption
            // 
            this.btnAddOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOption.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddOption.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnAddOption.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnAddOption.BorderRadius = 10;
            this.btnAddOption.BorderSize = 2;
            this.btnAddOption.BTextColour = System.Drawing.Color.White;
            this.btnAddOption.FlatAppearance.BorderSize = 0;
            this.btnAddOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddOption.ForeColor = System.Drawing.Color.White;
            this.btnAddOption.Location = new System.Drawing.Point(530, 249);
            this.btnAddOption.Name = "btnAddOption";
            this.btnAddOption.Size = new System.Drawing.Size(96, 34);
            this.btnAddOption.TabIndex = 50;
            this.btnAddOption.Text = "Add  option";
            this.btnAddOption.UseVisualStyleBackColor = false;
            this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
            // 
            // txtOptionDescription
            // 
            this.txtOptionDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOptionDescription.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtOptionDescription.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtOptionDescription.BorderRadius = 5;
            this.txtOptionDescription.BorderSize = 2;
            this.txtOptionDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOptionDescription.Location = new System.Drawing.Point(530, 167);
            this.txtOptionDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtOptionDescription.Multiline = true;
            this.txtOptionDescription.Name = "txtOptionDescription";
            this.txtOptionDescription.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtOptionDescription.PasswordChar = false;
            this.txtOptionDescription.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtOptionDescription.PlaceholderText = "";
            this.txtOptionDescription.Size = new System.Drawing.Size(343, 80);
            this.txtOptionDescription.TabIndex = 9;
            this.txtOptionDescription.Texts = "";
            this.txtOptionDescription.UnderlinedStyle = false;
            // 
            // txtOptionName
            // 
            this.txtOptionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOptionName.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtOptionName.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtOptionName.BorderRadius = 5;
            this.txtOptionName.BorderSize = 2;
            this.txtOptionName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOptionName.Location = new System.Drawing.Point(530, 100);
            this.txtOptionName.Margin = new System.Windows.Forms.Padding(6);
            this.txtOptionName.Multiline = false;
            this.txtOptionName.Name = "txtOptionName";
            this.txtOptionName.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtOptionName.PasswordChar = false;
            this.txtOptionName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtOptionName.PlaceholderText = "";
            this.txtOptionName.Size = new System.Drawing.Size(343, 38);
            this.txtOptionName.TabIndex = 8;
            this.txtOptionName.Texts = "";
            this.txtOptionName.UnderlinedStyle = false;
            // 
            // btnCancelSetup
            // 
            this.btnCancelSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelSetup.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancelSetup.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnCancelSetup.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnCancelSetup.BorderRadius = 10;
            this.btnCancelSetup.BorderSize = 2;
            this.btnCancelSetup.BTextColour = System.Drawing.Color.White;
            this.btnCancelSetup.FlatAppearance.BorderSize = 0;
            this.btnCancelSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSetup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSetup.ForeColor = System.Drawing.Color.White;
            this.btnCancelSetup.Location = new System.Drawing.Point(530, 613);
            this.btnCancelSetup.Name = "btnCancelSetup";
            this.btnCancelSetup.Size = new System.Drawing.Size(144, 46);
            this.btnCancelSetup.TabIndex = 43;
            this.btnCancelSetup.Text = "Cancel";
            this.btnCancelSetup.UseVisualStyleBackColor = false;
            this.btnCancelSetup.Click += new System.EventHandler(this.btnCancelSetup_Click);
            // 
            // btnSubmitVotingInstance
            // 
            this.btnSubmitVotingInstance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitVotingInstance.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitVotingInstance.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnSubmitVotingInstance.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmitVotingInstance.BorderRadius = 10;
            this.btnSubmitVotingInstance.BorderSize = 2;
            this.btnSubmitVotingInstance.BTextColour = System.Drawing.Color.White;
            this.btnSubmitVotingInstance.FlatAppearance.BorderSize = 0;
            this.btnSubmitVotingInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitVotingInstance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitVotingInstance.ForeColor = System.Drawing.Color.White;
            this.btnSubmitVotingInstance.Location = new System.Drawing.Point(309, 613);
            this.btnSubmitVotingInstance.Name = "btnSubmitVotingInstance";
            this.btnSubmitVotingInstance.Size = new System.Drawing.Size(144, 46);
            this.btnSubmitVotingInstance.TabIndex = 10;
            this.btnSubmitVotingInstance.Text = "Submit";
            this.btnSubmitVotingInstance.UseVisualStyleBackColor = false;
            this.btnSubmitVotingInstance.Click += new System.EventHandler(this.btnSubmitVotingInstance_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtDescription.BorderRadius = 5;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.Location = new System.Drawing.Point(110, 147);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(343, 122);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // txtElectionName
            // 
            this.txtElectionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtElectionName.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtElectionName.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtElectionName.BorderRadius = 5;
            this.txtElectionName.BorderSize = 2;
            this.txtElectionName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectionName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtElectionName.Location = new System.Drawing.Point(110, 77);
            this.txtElectionName.Margin = new System.Windows.Forms.Padding(6);
            this.txtElectionName.Multiline = false;
            this.txtElectionName.Name = "txtElectionName";
            this.txtElectionName.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtElectionName.PasswordChar = false;
            this.txtElectionName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtElectionName.PlaceholderText = "";
            this.txtElectionName.Size = new System.Drawing.Size(343, 38);
            this.txtElectionName.TabIndex = 1;
            this.txtElectionName.Texts = "";
            this.txtElectionName.UnderlinedStyle = false;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPostcode.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPostcode.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtPostcode.BorderRadius = 5;
            this.txtPostcode.BorderSize = 2;
            this.txtPostcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPostcode.Location = new System.Drawing.Point(196, 496);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(6);
            this.txtPostcode.Multiline = false;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtPostcode.PasswordChar = false;
            this.txtPostcode.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPostcode.PlaceholderText = "";
            this.txtPostcode.Size = new System.Drawing.Size(257, 38);
            this.txtPostcode.TabIndex = 7;
            this.txtPostcode.Texts = "";
            this.txtPostcode.UnderlinedStyle = false;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCountry.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtCountry.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtCountry.BorderRadius = 5;
            this.txtCountry.BorderSize = 2;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCountry.Location = new System.Drawing.Point(196, 446);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(6);
            this.txtCountry.Multiline = false;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtCountry.PasswordChar = false;
            this.txtCountry.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtCountry.PlaceholderText = "";
            this.txtCountry.Size = new System.Drawing.Size(257, 38);
            this.txtCountry.TabIndex = 6;
            this.txtCountry.Texts = "";
            this.txtCountry.UnderlinedStyle = false;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress3.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAddress3.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtAddress3.BorderRadius = 5;
            this.txtAddress3.BorderSize = 2;
            this.txtAddress3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress3.Location = new System.Drawing.Point(196, 396);
            this.txtAddress3.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress3.Multiline = false;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtAddress3.PasswordChar = false;
            this.txtAddress3.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtAddress3.PlaceholderText = "";
            this.txtAddress3.Size = new System.Drawing.Size(257, 38);
            this.txtAddress3.TabIndex = 5;
            this.txtAddress3.Texts = "";
            this.txtAddress3.UnderlinedStyle = false;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress2.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAddress2.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtAddress2.BorderRadius = 5;
            this.txtAddress2.BorderSize = 2;
            this.txtAddress2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress2.Location = new System.Drawing.Point(196, 346);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress2.Multiline = false;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtAddress2.PasswordChar = false;
            this.txtAddress2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtAddress2.PlaceholderText = "";
            this.txtAddress2.Size = new System.Drawing.Size(257, 38);
            this.txtAddress2.TabIndex = 4;
            this.txtAddress2.Texts = "";
            this.txtAddress2.UnderlinedStyle = false;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress1.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAddress1.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtAddress1.BorderRadius = 5;
            this.txtAddress1.BorderSize = 2;
            this.txtAddress1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress1.Location = new System.Drawing.Point(196, 296);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress1.Multiline = false;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtAddress1.PasswordChar = false;
            this.txtAddress1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtAddress1.PlaceholderText = "";
            this.txtAddress1.Size = new System.Drawing.Size(257, 38);
            this.txtAddress1.TabIndex = 3;
            this.txtAddress1.Texts = "";
            this.txtAddress1.UnderlinedStyle = false;
            // 
            // lblPostcode
            // 
            this.lblPostcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPostcode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(116, 501);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(61, 37);
            this.lblPostcode.TabIndex = 69;
            this.lblPostcode.Text = "Postcode/State:";
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(116, 461);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(51, 13);
            this.lblCountry.TabIndex = 68;
            this.lblCountry.Text = "Country:";
            // 
            // lblAddressLine3
            // 
            this.lblAddressLine3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressLine3.AutoSize = true;
            this.lblAddressLine3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine3.Location = new System.Drawing.Point(116, 411);
            this.lblAddressLine3.Name = "lblAddressLine3";
            this.lblAddressLine3.Size = new System.Drawing.Size(40, 13);
            this.lblAddressLine3.TabIndex = 67;
            this.lblAddressLine3.Text = "Line 3:";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(116, 359);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(40, 13);
            this.lblAddressLine2.TabIndex = 66;
            this.lblAddressLine2.Text = "Line 2:";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(116, 308);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(40, 13);
            this.lblAddressLine1.TabIndex = 65;
            this.lblAddressLine1.Text = "Line 1:";
            // 
            // numVotingInstanceId
            // 
            this.numVotingInstanceId.Location = new System.Drawing.Point(16, 666);
            this.numVotingInstanceId.Name = "numVotingInstanceId";
            this.numVotingInstanceId.Size = new System.Drawing.Size(49, 20);
            this.numVotingInstanceId.TabIndex = 70;
            this.numVotingInstanceId.Visible = false;
            // 
            // tbtnEnabled
            // 
            this.tbtnEnabled.AutoSize = true;
            this.tbtnEnabled.Location = new System.Drawing.Point(408, 552);
            this.tbtnEnabled.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbtnEnabled.Name = "tbtnEnabled";
            this.tbtnEnabled.OffBackColor = System.Drawing.Color.Gray;
            this.tbtnEnabled.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtnEnabled.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtnEnabled.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtnEnabled.Size = new System.Drawing.Size(45, 22);
            this.tbtnEnabled.TabIndex = 72;
            this.tbtnEnabled.UseVisualStyleBackColor = true;
            // 
            // lblEnabled
            // 
            this.lblEnabled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnabled.Location = new System.Drawing.Point(117, 552);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(87, 20);
            this.lblEnabled.TabIndex = 71;
            this.lblEnabled.Text = "Still in use?";
            // 
            // btnEndElection
            // 
            this.btnEndElection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEndElection.BackColor = System.Drawing.Color.Red;
            this.btnEndElection.BackgroundColour = System.Drawing.Color.Red;
            this.btnEndElection.BorderColour = System.Drawing.Color.DarkRed;
            this.btnEndElection.BorderRadius = 10;
            this.btnEndElection.BorderSize = 2;
            this.btnEndElection.BTextColour = System.Drawing.Color.White;
            this.btnEndElection.Enabled = false;
            this.btnEndElection.FlatAppearance.BorderSize = 0;
            this.btnEndElection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndElection.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnEndElection.ForeColor = System.Drawing.Color.White;
            this.btnEndElection.Location = new System.Drawing.Point(776, 538);
            this.btnEndElection.Name = "btnEndElection";
            this.btnEndElection.Size = new System.Drawing.Size(97, 34);
            this.btnEndElection.TabIndex = 73;
            this.btnEndElection.Text = "End Election";
            this.btnEndElection.UseVisualStyleBackColor = false;
            this.btnEndElection.Click += new System.EventHandler(this.btnEndElection_Click);
            // 
            // cboElectionTypeDDList
            // 
            this.cboElectionTypeDDList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboElectionTypeDDList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboElectionTypeDDList.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboElectionTypeDDList.BorderSize = 1;
            this.cboElectionTypeDDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboElectionTypeDDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboElectionTypeDDList.ForeColor = System.Drawing.Color.DimGray;
            this.cboElectionTypeDDList.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboElectionTypeDDList.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboElectionTypeDDList.ListTextColor = System.Drawing.Color.DimGray;
            this.cboElectionTypeDDList.Location = new System.Drawing.Point(678, 452);
            this.cboElectionTypeDDList.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboElectionTypeDDList.Name = "cboElectionTypeDDList";
            this.cboElectionTypeDDList.Padding = new System.Windows.Forms.Padding(1);
            this.cboElectionTypeDDList.Size = new System.Drawing.Size(200, 30);
            this.cboElectionTypeDDList.TabIndex = 89;
            this.cboElectionTypeDDList.Texts = "";
            // 
            // lblElectionType
            // 
            this.lblElectionType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionType.AutoSize = true;
            this.lblElectionType.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionType.Location = new System.Drawing.Point(534, 461);
            this.lblElectionType.Name = "lblElectionType";
            this.lblElectionType.Size = new System.Drawing.Size(101, 20);
            this.lblElectionType.TabIndex = 91;
            this.lblElectionType.Text = "Election Type";
            // 
            // ucVotingSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblElectionType);
            this.Controls.Add(this.cboElectionTypeDDList);
            this.Controls.Add(this.btnEndElection);
            this.Controls.Add(this.tbtnEnabled);
            this.Controls.Add(this.lblEnabled);
            this.Controls.Add(this.numVotingInstanceId);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblAddressLine3);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.btnClearOptions);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnAddOption);
            this.Controls.Add(this.lblVotingOptions);
            this.Controls.Add(this.lblVotingOptionDescription);
            this.Controls.Add(this.lblVotingOptionName);
            this.Controls.Add(this.txtOptionDescription);
            this.Controls.Add(this.txtOptionName);
            this.Controls.Add(this.lstVotingOptions);
            this.Controls.Add(this.btnCancelSetup);
            this.Controls.Add(this.btnSubmitVotingInstance);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.lblElectionName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtElectionName);
            this.Controls.Add(this.lblAddressHeader);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Name = "ucVotingSetupForm";
            this.Size = new System.Drawing.Size(984, 710);
            this.Load += new System.EventHandler(this.ucVotingSetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVotingInstanceId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddressHeader;
        private CustomControls.RoundedTextbox txtPostcode;
        private CustomControls.RoundedTextbox txtCountry;
        private CustomControls.RoundedTextbox txtAddress3;
        private CustomControls.RoundedTextbox txtAddress2;
        private CustomControls.RoundedTextbox txtAddress1;
        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Label lblElectionName;
        private CustomControls.RoundedTextbox txtDescription;
        private CustomControls.RoundedTextbox txtElectionName;
        private CustomControls.RoundedButton btnCancelSetup;
        private CustomControls.RoundedButton btnSubmitVotingInstance;
        private System.Windows.Forms.ListView lstVotingOptions;
        private System.Windows.Forms.Label lblVotingOptionDescription;
        private System.Windows.Forms.Label lblVotingOptionName;
        private CustomControls.RoundedTextbox txtOptionDescription;
        private CustomControls.RoundedTextbox txtOptionName;
        private System.Windows.Forms.Label lblVotingOptions;
        private CustomControls.RoundedButton btnAddOption;
        private CustomControls.RoundedButton btnRemoveSelected;
        private CustomControls.RoundedButton btnClearOptions;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAddressLine3;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.NumericUpDown numVotingInstanceId;
        private CustomControls.ToggleButton tbtnEnabled;
        private System.Windows.Forms.Label lblEnabled;
        private CustomControls.RoundedButton btnEndElection;
        private CustomControls.CustomComboBox cboElectionTypeDDList;
        private System.Windows.Forms.Label lblElectionType;
    }
}
