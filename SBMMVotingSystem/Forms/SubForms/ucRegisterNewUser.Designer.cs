namespace SBMMVotingSystem.Forms.SubForms
{
    partial class ucRegisterNewUser
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
            this.lblVotingRef = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAddressHeader = new System.Windows.Forms.Label();
            this.lblUsernameHeader = new System.Windows.Forms.Label();
            this.lblPasswordHeader = new System.Windows.Forms.Label();
            this.lblConfirmPasswordHeader = new System.Windows.Forms.Label();
            this.lblIsUserVotingUserMessage = new System.Windows.Forms.Label();
            this.lblPasswordMsgDontMatch = new System.Windows.Forms.Label();
            this.lblPasswordMsgLength = new System.Windows.Forms.Label();
            this.lblErrorMessageText = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.numUserId = new System.Windows.Forms.NumericUpDown();
            this.pnlPasswordArea = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtPassword = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.numAddressId = new System.Windows.Forms.NumericUpDown();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine3 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblEnabled = new System.Windows.Forms.Label();
            this.tbtnEnabled = new SBMMVotingSystem.CustomControls.ToggleButton();
            this.btnUpdatePassword = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.cboUserTypeDDList = new SBMMVotingSystem.CustomControls.CustomComboBox();
            this.cboAgeDDList = new SBMMVotingSystem.CustomControls.CustomComboBox();
            this.txtUsername = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.btnCancelNewUser = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnSubmitNewUser = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.txtPostcode = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtCountry = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtAddress3 = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtAddress2 = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtAddress1 = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtVotingRefNumber = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtLastName = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            this.txtFirstName = new SBMMVotingSystem.CustomControls.RoundedTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.numUserId)).BeginInit();
            this.pnlPasswordArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddressId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVotingRef
            // 
            this.lblVotingRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVotingRef.AutoSize = true;
            this.lblVotingRef.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotingRef.Location = new System.Drawing.Point(533, 127);
            this.lblVotingRef.Name = "lblVotingRef";
            this.lblVotingRef.Size = new System.Drawing.Size(184, 20);
            this.lblVotingRef.TabIndex = 35;
            this.lblVotingRef.Text = "Voting reference number";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(117, 217);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 20);
            this.lblAge.TabIndex = 34;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(117, 150);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(81, 20);
            this.lblLastName.TabIndex = 33;
            this.lblLastName.Text = "Last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(117, 80);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First name";
            // 
            // lblAddressHeader
            // 
            this.lblAddressHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressHeader.AutoSize = true;
            this.lblAddressHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressHeader.Location = new System.Drawing.Point(113, 290);
            this.lblAddressHeader.Name = "lblAddressHeader";
            this.lblAddressHeader.Size = new System.Drawing.Size(66, 20);
            this.lblAddressHeader.TabIndex = 31;
            this.lblAddressHeader.Text = "Address";
            // 
            // lblUsernameHeader
            // 
            this.lblUsernameHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsernameHeader.AutoSize = true;
            this.lblUsernameHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameHeader.Location = new System.Drawing.Point(533, 290);
            this.lblUsernameHeader.Name = "lblUsernameHeader";
            this.lblUsernameHeader.Size = new System.Drawing.Size(80, 20);
            this.lblUsernameHeader.TabIndex = 37;
            this.lblUsernameHeader.Text = "Username";
            // 
            // lblPasswordHeader
            // 
            this.lblPasswordHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordHeader.AutoSize = true;
            this.lblPasswordHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordHeader.Location = new System.Drawing.Point(13, 4);
            this.lblPasswordHeader.Name = "lblPasswordHeader";
            this.lblPasswordHeader.Size = new System.Drawing.Size(76, 20);
            this.lblPasswordHeader.TabIndex = 39;
            this.lblPasswordHeader.Text = "Password";
            // 
            // lblConfirmPasswordHeader
            // 
            this.lblConfirmPasswordHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmPasswordHeader.AutoSize = true;
            this.lblConfirmPasswordHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordHeader.Location = new System.Drawing.Point(13, 73);
            this.lblConfirmPasswordHeader.Name = "lblConfirmPasswordHeader";
            this.lblConfirmPasswordHeader.Size = new System.Drawing.Size(137, 20);
            this.lblConfirmPasswordHeader.TabIndex = 41;
            this.lblConfirmPasswordHeader.Text = "Confirm Password";
            // 
            // lblIsUserVotingUserMessage
            // 
            this.lblIsUserVotingUserMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIsUserVotingUserMessage.AutoSize = true;
            this.lblIsUserVotingUserMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsUserVotingUserMessage.Location = new System.Drawing.Point(533, 94);
            this.lblIsUserVotingUserMessage.Name = "lblIsUserVotingUserMessage";
            this.lblIsUserVotingUserMessage.Size = new System.Drawing.Size(259, 20);
            this.lblIsUserVotingUserMessage.TabIndex = 42;
            this.lblIsUserVotingUserMessage.Text = "Will this login be used for voting too?";
            // 
            // lblPasswordMsgDontMatch
            // 
            this.lblPasswordMsgDontMatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordMsgDontMatch.AutoSize = true;
            this.lblPasswordMsgDontMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMsgDontMatch.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPasswordMsgDontMatch.Location = new System.Drawing.Point(13, 147);
            this.lblPasswordMsgDontMatch.Name = "lblPasswordMsgDontMatch";
            this.lblPasswordMsgDontMatch.Size = new System.Drawing.Size(195, 21);
            this.lblPasswordMsgDontMatch.TabIndex = 43;
            this.lblPasswordMsgDontMatch.Text = "- Passwords do not match";
            // 
            // lblPasswordMsgLength
            // 
            this.lblPasswordMsgLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordMsgLength.AutoSize = true;
            this.lblPasswordMsgLength.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMsgLength.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPasswordMsgLength.Location = new System.Drawing.Point(13, 168);
            this.lblPasswordMsgLength.Name = "lblPasswordMsgLength";
            this.lblPasswordMsgLength.Size = new System.Drawing.Size(346, 21);
            this.lblPasswordMsgLength.TabIndex = 44;
            this.lblPasswordMsgLength.Text = "- Password should be longer then 10 characters";
            // 
            // lblErrorMessageText
            // 
            this.lblErrorMessageText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorMessageText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessageText.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblErrorMessageText.Location = new System.Drawing.Point(23, 669);
            this.lblErrorMessageText.Name = "lblErrorMessageText";
            this.lblErrorMessageText.Size = new System.Drawing.Size(937, 21);
            this.lblErrorMessageText.TabIndex = 50;
            this.lblErrorMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(528, 217);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(76, 20);
            this.lblUserType.TabIndex = 54;
            this.lblUserType.Text = "User type";
            this.lblUserType.Visible = false;
            // 
            // numUserId
            // 
            this.numUserId.Location = new System.Drawing.Point(17, 668);
            this.numUserId.Name = "numUserId";
            this.numUserId.Size = new System.Drawing.Size(60, 20);
            this.numUserId.TabIndex = 56;
            this.numUserId.Visible = false;
            // 
            // pnlPasswordArea
            // 
            this.pnlPasswordArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPasswordArea.Controls.Add(this.lblPasswordMsgDontMatch);
            this.pnlPasswordArea.Controls.Add(this.lblConfirmPasswordHeader);
            this.pnlPasswordArea.Controls.Add(this.txtConfirmPassword);
            this.pnlPasswordArea.Controls.Add(this.lblPasswordHeader);
            this.pnlPasswordArea.Controls.Add(this.txtPassword);
            this.pnlPasswordArea.Controls.Add(this.lblPasswordMsgLength);
            this.pnlPasswordArea.Location = new System.Drawing.Point(519, 361);
            this.pnlPasswordArea.Name = "pnlPasswordArea";
            this.pnlPasswordArea.Size = new System.Drawing.Size(367, 200);
            this.pnlPasswordArea.TabIndex = 57;
            this.pnlPasswordArea.Visible = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtConfirmPassword.BorderRadius = 5;
            this.txtConfirmPassword.BorderSize = 2;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtConfirmPassword.Location = new System.Drawing.Point(8, 97);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtConfirmPassword.PasswordChar = true;
            this.txtConfirmPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.PlaceholderText = "Conrfirm password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(343, 38);
            this.txtConfirmPassword.TabIndex = 13;
            this.txtConfirmPassword.Texts = "";
            this.txtConfirmPassword.UnderlinedStyle = false;
            this.txtConfirmPassword._TextChanged += new System.EventHandler(this.PasswordChecker_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.Location = new System.Drawing.Point(8, 28);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(343, 38);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword._TextChanged += new System.EventHandler(this.PasswordChecker_TextChanged);
            // 
            // numAddressId
            // 
            this.numAddressId.Location = new System.Drawing.Point(83, 668);
            this.numAddressId.Name = "numAddressId";
            this.numAddressId.Size = new System.Drawing.Size(60, 20);
            this.numAddressId.TabIndex = 59;
            this.numAddressId.Visible = false;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(118, 321);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(40, 13);
            this.lblAddressLine1.TabIndex = 60;
            this.lblAddressLine1.Text = "Line 1:";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(118, 372);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(40, 13);
            this.lblAddressLine2.TabIndex = 61;
            this.lblAddressLine2.Text = "Line 2:";
            // 
            // lblAddressLine3
            // 
            this.lblAddressLine3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressLine3.AutoSize = true;
            this.lblAddressLine3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine3.Location = new System.Drawing.Point(118, 424);
            this.lblAddressLine3.Name = "lblAddressLine3";
            this.lblAddressLine3.Size = new System.Drawing.Size(40, 13);
            this.lblAddressLine3.TabIndex = 62;
            this.lblAddressLine3.Text = "Line 3:";
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(118, 475);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(62, 38);
            this.lblCountry.TabIndex = 63;
            this.lblCountry.Text = "Country:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPostcode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(118, 516);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(61, 37);
            this.lblPostcode.TabIndex = 64;
            this.lblPostcode.Text = "Postcode/State:";
            // 
            // lblEnabled
            // 
            this.lblEnabled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnabled.Location = new System.Drawing.Point(303, 218);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(87, 20);
            this.lblEnabled.TabIndex = 65;
            this.lblEnabled.Text = "Still in use?";
            // 
            // tbtnEnabled
            // 
            this.tbtnEnabled.AutoSize = true;
            this.tbtnEnabled.Location = new System.Drawing.Point(307, 241);
            this.tbtnEnabled.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbtnEnabled.Name = "tbtnEnabled";
            this.tbtnEnabled.OffBackColor = System.Drawing.Color.Gray;
            this.tbtnEnabled.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtnEnabled.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtnEnabled.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtnEnabled.Size = new System.Drawing.Size(45, 22);
            this.tbtnEnabled.TabIndex = 66;
            this.tbtnEnabled.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdatePassword.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUpdatePassword.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnUpdatePassword.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdatePassword.BorderRadius = 10;
            this.btnUpdatePassword.BorderSize = 2;
            this.btnUpdatePassword.BTextColour = System.Drawing.Color.White;
            this.btnUpdatePassword.FlatAppearance.BorderSize = 0;
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePassword.Location = new System.Drawing.Point(530, 398);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(343, 115);
            this.btnUpdatePassword.TabIndex = 58;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Visible = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // cboUserTypeDDList
            // 
            this.cboUserTypeDDList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboUserTypeDDList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboUserTypeDDList.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboUserTypeDDList.BorderSize = 1;
            this.cboUserTypeDDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboUserTypeDDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboUserTypeDDList.ForeColor = System.Drawing.Color.DimGray;
            this.cboUserTypeDDList.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboUserTypeDDList.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboUserTypeDDList.ListTextColor = System.Drawing.Color.DimGray;
            this.cboUserTypeDDList.Location = new System.Drawing.Point(528, 240);
            this.cboUserTypeDDList.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboUserTypeDDList.Name = "cboUserTypeDDList";
            this.cboUserTypeDDList.Padding = new System.Windows.Forms.Padding(1);
            this.cboUserTypeDDList.Size = new System.Drawing.Size(334, 30);
            this.cboUserTypeDDList.TabIndex = 10;
            this.cboUserTypeDDList.Texts = "";
            this.cboUserTypeDDList.Visible = false;
            // 
            // cboAgeDDList
            // 
            this.cboAgeDDList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAgeDDList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboAgeDDList.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboAgeDDList.BorderSize = 1;
            this.cboAgeDDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboAgeDDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboAgeDDList.ForeColor = System.Drawing.Color.DimGray;
            this.cboAgeDDList.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboAgeDDList.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboAgeDDList.ListTextColor = System.Drawing.Color.DimGray;
            this.cboAgeDDList.Location = new System.Drawing.Point(117, 240);
            this.cboAgeDDList.MinimumSize = new System.Drawing.Size(100, 30);
            this.cboAgeDDList.Name = "cboAgeDDList";
            this.cboAgeDDList.Padding = new System.Windows.Forms.Padding(1);
            this.cboAgeDDList.Size = new System.Drawing.Size(123, 30);
            this.cboAgeDDList.TabIndex = 3;
            this.cboAgeDDList.Texts = "";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsername.Location = new System.Drawing.Point(528, 314);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(343, 38);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // btnCancelNewUser
            // 
            this.btnCancelNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelNewUser.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancelNewUser.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnCancelNewUser.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnCancelNewUser.BorderRadius = 10;
            this.btnCancelNewUser.BorderSize = 2;
            this.btnCancelNewUser.BTextColour = System.Drawing.Color.White;
            this.btnCancelNewUser.FlatAppearance.BorderSize = 0;
            this.btnCancelNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNewUser.ForeColor = System.Drawing.Color.White;
            this.btnCancelNewUser.Location = new System.Drawing.Point(528, 602);
            this.btnCancelNewUser.Name = "btnCancelNewUser";
            this.btnCancelNewUser.Size = new System.Drawing.Size(144, 46);
            this.btnCancelNewUser.TabIndex = 30;
            this.btnCancelNewUser.Text = "Cancel";
            this.btnCancelNewUser.UseVisualStyleBackColor = false;
            this.btnCancelNewUser.Click += new System.EventHandler(this.btnCancelNewUser_Click);
            // 
            // btnSubmitNewUser
            // 
            this.btnSubmitNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitNewUser.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitNewUser.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnSubmitNewUser.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmitNewUser.BorderRadius = 10;
            this.btnSubmitNewUser.BorderSize = 2;
            this.btnSubmitNewUser.BTextColour = System.Drawing.Color.White;
            this.btnSubmitNewUser.Enabled = false;
            this.btnSubmitNewUser.FlatAppearance.BorderSize = 0;
            this.btnSubmitNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNewUser.ForeColor = System.Drawing.Color.White;
            this.btnSubmitNewUser.Location = new System.Drawing.Point(307, 602);
            this.btnSubmitNewUser.Name = "btnSubmitNewUser";
            this.btnSubmitNewUser.Size = new System.Drawing.Size(144, 46);
            this.btnSubmitNewUser.TabIndex = 14;
            this.btnSubmitNewUser.Text = "Submit";
            this.btnSubmitNewUser.UseVisualStyleBackColor = false;
            this.btnSubmitNewUser.Click += new System.EventHandler(this.btnSubmitNewUser_Click);
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
            this.txtPostcode.Location = new System.Drawing.Point(189, 511);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(6);
            this.txtPostcode.Multiline = false;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtPostcode.PasswordChar = false;
            this.txtPostcode.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPostcode.PlaceholderText = "";
            this.txtPostcode.Size = new System.Drawing.Size(266, 38);
            this.txtPostcode.TabIndex = 8;
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
            this.txtCountry.Location = new System.Drawing.Point(189, 461);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(6);
            this.txtCountry.Multiline = false;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtCountry.PasswordChar = false;
            this.txtCountry.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtCountry.PlaceholderText = "";
            this.txtCountry.Size = new System.Drawing.Size(266, 38);
            this.txtCountry.TabIndex = 7;
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
            this.txtAddress3.Location = new System.Drawing.Point(189, 411);
            this.txtAddress3.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress3.Multiline = false;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtAddress3.PasswordChar = false;
            this.txtAddress3.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtAddress3.PlaceholderText = "";
            this.txtAddress3.Size = new System.Drawing.Size(266, 38);
            this.txtAddress3.TabIndex = 6;
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
            this.txtAddress2.Location = new System.Drawing.Point(189, 361);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress2.Multiline = false;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtAddress2.PasswordChar = false;
            this.txtAddress2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtAddress2.PlaceholderText = "";
            this.txtAddress2.Size = new System.Drawing.Size(266, 38);
            this.txtAddress2.TabIndex = 5;
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
            this.txtAddress1.Location = new System.Drawing.Point(189, 311);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress1.Multiline = false;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtAddress1.PasswordChar = false;
            this.txtAddress1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtAddress1.PlaceholderText = "";
            this.txtAddress1.Size = new System.Drawing.Size(266, 38);
            this.txtAddress1.TabIndex = 4;
            this.txtAddress1.Texts = "";
            this.txtAddress1.UnderlinedStyle = false;
            // 
            // txtVotingRefNumber
            // 
            this.txtVotingRefNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVotingRefNumber.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtVotingRefNumber.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtVotingRefNumber.BorderRadius = 5;
            this.txtVotingRefNumber.BorderSize = 2;
            this.txtVotingRefNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVotingRefNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtVotingRefNumber.Location = new System.Drawing.Point(528, 150);
            this.txtVotingRefNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtVotingRefNumber.Multiline = false;
            this.txtVotingRefNumber.Name = "txtVotingRefNumber";
            this.txtVotingRefNumber.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtVotingRefNumber.PasswordChar = false;
            this.txtVotingRefNumber.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtVotingRefNumber.PlaceholderText = "";
            this.txtVotingRefNumber.Size = new System.Drawing.Size(343, 38);
            this.txtVotingRefNumber.TabIndex = 9;
            this.txtVotingRefNumber.Texts = "";
            this.txtVotingRefNumber.UnderlinedStyle = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtLastName.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtLastName.BorderRadius = 5;
            this.txtLastName.BorderSize = 2;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLastName.Location = new System.Drawing.Point(112, 174);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.Size = new System.Drawing.Size(343, 38);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtFirstName.BorderFocusColour = System.Drawing.Color.Blue;
            this.txtFirstName.BorderRadius = 5;
            this.txtFirstName.BorderSize = 2;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFirstName.Location = new System.Drawing.Point(112, 106);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.txtFirstName.PasswordChar = false;
            this.txtFirstName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.Size = new System.Drawing.Size(343, 38);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Texts = "";
            this.txtFirstName.UnderlinedStyle = false;
            // 
            // ucRegisterNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.tbtnEnabled);
            this.Controls.Add(this.lblEnabled);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblAddressLine3);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.numAddressId);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.pnlPasswordArea);
            this.Controls.Add(this.numUserId);
            this.Controls.Add(this.cboUserTypeDDList);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.cboAgeDDList);
            this.Controls.Add(this.lblErrorMessageText);
            this.Controls.Add(this.lblIsUserVotingUserMessage);
            this.Controls.Add(this.lblUsernameHeader);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblVotingRef);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAddressHeader);
            this.Controls.Add(this.btnCancelNewUser);
            this.Controls.Add(this.btnSubmitNewUser);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtVotingRefNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "ucRegisterNewUser";
            this.Size = new System.Drawing.Size(984, 710);
            this.Load += new System.EventHandler(this.ucAdminNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUserId)).EndInit();
            this.pnlPasswordArea.ResumeLayout(false);
            this.pnlPasswordArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddressId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVotingRef;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAddressHeader;
        private CustomControls.RoundedButton btnCancelNewUser;
        private CustomControls.RoundedButton btnSubmitNewUser;
        private CustomControls.RoundedTextbox txtPostcode;
        private CustomControls.RoundedTextbox txtCountry;
        private CustomControls.RoundedTextbox txtAddress3;
        private CustomControls.RoundedTextbox txtAddress2;
        private CustomControls.RoundedTextbox txtAddress1;
        private CustomControls.RoundedTextbox txtVotingRefNumber;
        private CustomControls.RoundedTextbox txtLastName;
        private CustomControls.RoundedTextbox txtFirstName;
        private System.Windows.Forms.Label lblUsernameHeader;
        private CustomControls.RoundedTextbox txtUsername;
        private System.Windows.Forms.Label lblPasswordHeader;
        private CustomControls.RoundedTextbox txtPassword;
        private System.Windows.Forms.Label lblConfirmPasswordHeader;
        private CustomControls.RoundedTextbox txtConfirmPassword;
        private System.Windows.Forms.Label lblIsUserVotingUserMessage;
        private System.Windows.Forms.Label lblPasswordMsgDontMatch;
        private System.Windows.Forms.Label lblPasswordMsgLength;
        private System.Windows.Forms.Label lblErrorMessageText;
        private CustomControls.CustomComboBox cboAgeDDList;
        private CustomControls.CustomComboBox cboUserTypeDDList;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.NumericUpDown numUserId;
        private System.Windows.Forms.Panel pnlPasswordArea;
        private CustomControls.RoundedButton btnUpdatePassword;
        private System.Windows.Forms.NumericUpDown numAddressId;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine3;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblEnabled;
        private CustomControls.ToggleButton tbtnEnabled;
    }
}
