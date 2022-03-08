namespace SBMMVotingSystem.Forms.SubForms
{
    partial class ucVotingForm
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
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.lblElectionNameText = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblElectionName = new System.Windows.Forms.Label();
            this.lblElectionDetails = new System.Windows.Forms.Label();
            this.pnlElectionDetails = new System.Windows.Forms.Panel();
            this.numVotingInstanceId = new System.Windows.Forms.NumericUpDown();
            this.pnlVotingOptions = new System.Windows.Forms.Panel();
            this.lblErrorMessageText = new System.Windows.Forms.Label();
            this.pnlDetailsBorder = new System.Windows.Forms.Panel();
            this.pnlOptionsBorder = new System.Windows.Forms.Panel();
            this.lblElectionList = new System.Windows.Forms.Label();
            this.cboElectionTypeDDList = new SBMMVotingSystem.CustomControls.CustomComboBox();
            this.btnCancelVote = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnSubmitVote = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.pnlElectionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVotingInstanceId)).BeginInit();
            this.pnlDetailsBorder.SuspendLayout();
            this.pnlOptionsBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddressText
            // 
            this.lblAddressText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressText.Location = new System.Drawing.Point(14, 224);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(19, 21);
            this.lblAddressText.TabIndex = 77;
            this.lblAddressText.Text = "...";
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescriptionText.AutoSize = true;
            this.lblDescriptionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionText.Location = new System.Drawing.Point(14, 132);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(19, 21);
            this.lblDescriptionText.TabIndex = 76;
            this.lblDescriptionText.Text = "...";
            // 
            // lblElectionNameText
            // 
            this.lblElectionNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionNameText.AutoSize = true;
            this.lblElectionNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionNameText.Location = new System.Drawing.Point(14, 63);
            this.lblElectionNameText.Name = "lblElectionNameText";
            this.lblElectionNameText.Size = new System.Drawing.Size(19, 21);
            this.lblElectionNameText.TabIndex = 75;
            this.lblElectionNameText.Text = "...";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(14, 203);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 21);
            this.lblAddress.TabIndex = 74;
            this.lblAddress.Text = "Address: ";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(14, 102);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 21);
            this.lblDescription.TabIndex = 73;
            this.lblDescription.Text = "Description: ";
            // 
            // lblElectionName
            // 
            this.lblElectionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionName.AutoSize = true;
            this.lblElectionName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionName.Location = new System.Drawing.Point(14, 39);
            this.lblElectionName.Name = "lblElectionName";
            this.lblElectionName.Size = new System.Drawing.Size(61, 21);
            this.lblElectionName.TabIndex = 72;
            this.lblElectionName.Text = "Name: ";
            // 
            // lblElectionDetails
            // 
            this.lblElectionDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionDetails.AutoSize = true;
            this.lblElectionDetails.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionDetails.Location = new System.Drawing.Point(13, 2);
            this.lblElectionDetails.Name = "lblElectionDetails";
            this.lblElectionDetails.Size = new System.Drawing.Size(146, 25);
            this.lblElectionDetails.TabIndex = 71;
            this.lblElectionDetails.Text = "Election Details";
            // 
            // pnlElectionDetails
            // 
            this.pnlElectionDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlElectionDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlElectionDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlElectionDetails.Controls.Add(this.numVotingInstanceId);
            this.pnlElectionDetails.Controls.Add(this.lblAddressText);
            this.pnlElectionDetails.Controls.Add(this.lblDescriptionText);
            this.pnlElectionDetails.Controls.Add(this.lblElectionNameText);
            this.pnlElectionDetails.Controls.Add(this.lblAddress);
            this.pnlElectionDetails.Controls.Add(this.lblDescription);
            this.pnlElectionDetails.Controls.Add(this.lblElectionName);
            this.pnlElectionDetails.Controls.Add(this.lblElectionDetails);
            this.pnlElectionDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlElectionDetails.Name = "pnlElectionDetails";
            this.pnlElectionDetails.Size = new System.Drawing.Size(377, 444);
            this.pnlElectionDetails.TabIndex = 82;
            // 
            // numVotingInstanceId
            // 
            this.numVotingInstanceId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numVotingInstanceId.Location = new System.Drawing.Point(4, 415);
            this.numVotingInstanceId.Name = "numVotingInstanceId";
            this.numVotingInstanceId.Size = new System.Drawing.Size(120, 20);
            this.numVotingInstanceId.TabIndex = 78;
            this.numVotingInstanceId.Visible = false;
            // 
            // pnlVotingOptions
            // 
            this.pnlVotingOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlVotingOptions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlVotingOptions.Location = new System.Drawing.Point(13, 12);
            this.pnlVotingOptions.Name = "pnlVotingOptions";
            this.pnlVotingOptions.Size = new System.Drawing.Size(373, 444);
            this.pnlVotingOptions.TabIndex = 83;
            // 
            // lblErrorMessageText
            // 
            this.lblErrorMessageText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorMessageText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessageText.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblErrorMessageText.Location = new System.Drawing.Point(25, 671);
            this.lblErrorMessageText.Name = "lblErrorMessageText";
            this.lblErrorMessageText.Size = new System.Drawing.Size(937, 21);
            this.lblErrorMessageText.TabIndex = 84;
            this.lblErrorMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDetailsBorder
            // 
            this.pnlDetailsBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDetailsBorder.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlDetailsBorder.Controls.Add(this.pnlElectionDetails);
            this.pnlDetailsBorder.Location = new System.Drawing.Point(57, 88);
            this.pnlDetailsBorder.Name = "pnlDetailsBorder";
            this.pnlDetailsBorder.Size = new System.Drawing.Size(399, 468);
            this.pnlDetailsBorder.TabIndex = 85;
            // 
            // pnlOptionsBorder
            // 
            this.pnlOptionsBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOptionsBorder.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlOptionsBorder.Controls.Add(this.pnlVotingOptions);
            this.pnlOptionsBorder.Location = new System.Drawing.Point(523, 88);
            this.pnlOptionsBorder.Name = "pnlOptionsBorder";
            this.pnlOptionsBorder.Size = new System.Drawing.Size(399, 468);
            this.pnlOptionsBorder.TabIndex = 86;
            // 
            // lblElectionList
            // 
            this.lblElectionList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblElectionList.AutoSize = true;
            this.lblElectionList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionList.Location = new System.Drawing.Point(59, 43);
            this.lblElectionList.Name = "lblElectionList";
            this.lblElectionList.Size = new System.Drawing.Size(181, 20);
            this.lblElectionList.TabIndex = 88;
            this.lblElectionList.Text = "Please select an election: ";
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
            this.cboElectionTypeDDList.Location = new System.Drawing.Point(262, 39);
            this.cboElectionTypeDDList.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboElectionTypeDDList.Name = "cboElectionTypeDDList";
            this.cboElectionTypeDDList.Padding = new System.Windows.Forms.Padding(1);
            this.cboElectionTypeDDList.Size = new System.Drawing.Size(334, 30);
            this.cboElectionTypeDDList.TabIndex = 87;
            this.cboElectionTypeDDList.Texts = "";
            this.cboElectionTypeDDList.OnSelectedIndexChanged += new System.EventHandler(this.cboElectionTypeDDList_OnSelectedIndexChanged);
            // 
            // btnCancelVote
            // 
            this.btnCancelVote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelVote.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancelVote.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnCancelVote.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnCancelVote.BorderRadius = 10;
            this.btnCancelVote.BorderSize = 2;
            this.btnCancelVote.BTextColour = System.Drawing.Color.White;
            this.btnCancelVote.FlatAppearance.BorderSize = 0;
            this.btnCancelVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelVote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelVote.ForeColor = System.Drawing.Color.White;
            this.btnCancelVote.Location = new System.Drawing.Point(523, 604);
            this.btnCancelVote.Name = "btnCancelVote";
            this.btnCancelVote.Size = new System.Drawing.Size(144, 46);
            this.btnCancelVote.TabIndex = 15;
            this.btnCancelVote.Text = "Cancel";
            this.btnCancelVote.UseVisualStyleBackColor = false;
            this.btnCancelVote.Click += new System.EventHandler(this.btnCancelVote_Click);
            // 
            // btnSubmitVote
            // 
            this.btnSubmitVote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitVote.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitVote.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnSubmitVote.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmitVote.BorderRadius = 10;
            this.btnSubmitVote.BorderSize = 2;
            this.btnSubmitVote.BTextColour = System.Drawing.Color.White;
            this.btnSubmitVote.FlatAppearance.BorderSize = 0;
            this.btnSubmitVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitVote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitVote.ForeColor = System.Drawing.Color.White;
            this.btnSubmitVote.Location = new System.Drawing.Point(302, 604);
            this.btnSubmitVote.Name = "btnSubmitVote";
            this.btnSubmitVote.Size = new System.Drawing.Size(144, 46);
            this.btnSubmitVote.TabIndex = 14;
            this.btnSubmitVote.Text = "Submit";
            this.btnSubmitVote.UseVisualStyleBackColor = false;
            this.btnSubmitVote.Click += new System.EventHandler(this.btnSubmitVote_Click);
            // 
            // ucVotingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblElectionList);
            this.Controls.Add(this.cboElectionTypeDDList);
            this.Controls.Add(this.pnlOptionsBorder);
            this.Controls.Add(this.pnlDetailsBorder);
            this.Controls.Add(this.lblErrorMessageText);
            this.Controls.Add(this.btnCancelVote);
            this.Controls.Add(this.btnSubmitVote);
            this.Name = "ucVotingForm";
            this.Size = new System.Drawing.Size(984, 710);
            this.Load += new System.EventHandler(this.ucVotingForm_Load);
            this.pnlElectionDetails.ResumeLayout(false);
            this.pnlElectionDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVotingInstanceId)).EndInit();
            this.pnlDetailsBorder.ResumeLayout(false);
            this.pnlOptionsBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedButton btnCancelVote;
        private CustomControls.RoundedButton btnSubmitVote;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblDescriptionText;
        private System.Windows.Forms.Label lblElectionNameText;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblElectionName;
        private System.Windows.Forms.Label lblElectionDetails;
        private System.Windows.Forms.Panel pnlElectionDetails;
        private System.Windows.Forms.Panel pnlVotingOptions;
        private System.Windows.Forms.NumericUpDown numVotingInstanceId;
        private System.Windows.Forms.Label lblErrorMessageText;
        private System.Windows.Forms.Panel pnlDetailsBorder;
        private System.Windows.Forms.Panel pnlOptionsBorder;
        private System.Windows.Forms.Label lblElectionList;
        private CustomControls.CustomComboBox cboElectionTypeDDList;
    }
}
