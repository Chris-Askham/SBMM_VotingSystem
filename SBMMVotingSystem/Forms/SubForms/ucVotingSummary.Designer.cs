using System.Drawing;

namespace SBMMVotingSystem.Forms.SubForms
{
    partial class ucVotingSummary
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSummaryMessage = new System.Windows.Forms.Label();
            this.pnlElectionDetails = new System.Windows.Forms.Panel();
            this.lblTotalnumberOfVotesText = new System.Windows.Forms.Label();
            this.lblTotalnumberOfVotes = new System.Windows.Forms.Label();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.lblElectionNameText = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblElectionName = new System.Windows.Forms.Label();
            this.lblElectionDetails = new System.Windows.Forms.Label();
            this.chtVotingInstanceSummary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radVotesByOption = new SBMMVotingSystem.CustomControls.CustomRadioButton();
            this.radVotesByArea = new SBMMVotingSystem.CustomControls.CustomRadioButton();
            this.btnExportSummary = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.btnReturn = new SBMMVotingSystem.CustomControls.RoundedButton();
            this.cboVotingInstanceDDList = new SBMMVotingSystem.CustomControls.CustomComboBox();
            this.grdVotesByArea = new System.Windows.Forms.DataGridView();
            this.colHeader_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeader_VOName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeader_NumberOfVotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlElectionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVotingInstanceSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVotesByArea)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSummaryMessage
            // 
            this.lblSummaryMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSummaryMessage.AutoSize = true;
            this.lblSummaryMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryMessage.Location = new System.Drawing.Point(66, 50);
            this.lblSummaryMessage.Name = "lblSummaryMessage";
            this.lblSummaryMessage.Size = new System.Drawing.Size(248, 20);
            this.lblSummaryMessage.TabIndex = 57;
            this.lblSummaryMessage.Text = "Which summary do you ant to view?";
            // 
            // pnlElectionDetails
            // 
            this.pnlElectionDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlElectionDetails.Controls.Add(this.lblTotalnumberOfVotesText);
            this.pnlElectionDetails.Controls.Add(this.lblTotalnumberOfVotes);
            this.pnlElectionDetails.Controls.Add(this.lblAddressText);
            this.pnlElectionDetails.Controls.Add(this.lblDescriptionText);
            this.pnlElectionDetails.Controls.Add(this.lblElectionNameText);
            this.pnlElectionDetails.Controls.Add(this.lblAddress);
            this.pnlElectionDetails.Controls.Add(this.lblDescription);
            this.pnlElectionDetails.Controls.Add(this.lblElectionName);
            this.pnlElectionDetails.Controls.Add(this.lblElectionDetails);
            this.pnlElectionDetails.Location = new System.Drawing.Point(49, 118);
            this.pnlElectionDetails.Name = "pnlElectionDetails";
            this.pnlElectionDetails.Size = new System.Drawing.Size(377, 392);
            this.pnlElectionDetails.TabIndex = 83;
            // 
            // lblTotalnumberOfVotesText
            // 
            this.lblTotalnumberOfVotesText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalnumberOfVotesText.AutoSize = true;
            this.lblTotalnumberOfVotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalnumberOfVotesText.Location = new System.Drawing.Point(15, 346);
            this.lblTotalnumberOfVotesText.Name = "lblTotalnumberOfVotesText";
            this.lblTotalnumberOfVotesText.Size = new System.Drawing.Size(19, 21);
            this.lblTotalnumberOfVotesText.TabIndex = 79;
            this.lblTotalnumberOfVotesText.Text = "...";
            // 
            // lblTotalnumberOfVotes
            // 
            this.lblTotalnumberOfVotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalnumberOfVotes.AutoSize = true;
            this.lblTotalnumberOfVotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalnumberOfVotes.Location = new System.Drawing.Point(15, 325);
            this.lblTotalnumberOfVotes.Name = "lblTotalnumberOfVotes";
            this.lblTotalnumberOfVotes.Size = new System.Drawing.Size(174, 21);
            this.lblTotalnumberOfVotes.TabIndex = 78;
            this.lblTotalnumberOfVotes.Text = "Total number of votes:";
            // 
            // lblAddressText
            // 
            this.lblAddressText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressText.Location = new System.Drawing.Point(15, 209);
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
            this.lblDescriptionText.Location = new System.Drawing.Point(15, 126);
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
            this.lblElectionNameText.Location = new System.Drawing.Point(15, 74);
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
            this.lblAddress.Location = new System.Drawing.Point(15, 188);
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
            this.lblDescription.Location = new System.Drawing.Point(15, 105);
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
            this.lblElectionName.Location = new System.Drawing.Point(15, 50);
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
            this.lblElectionDetails.Location = new System.Drawing.Point(14, 13);
            this.lblElectionDetails.Name = "lblElectionDetails";
            this.lblElectionDetails.Size = new System.Drawing.Size(71, 25);
            this.lblElectionDetails.TabIndex = 71;
            this.lblElectionDetails.Text = "Details";
            // 
            // chtVotingInstanceSummary
            // 
            this.chtVotingInstanceSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chtVotingInstanceSummary.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtVotingInstanceSummary.Legends.Add(legend2);
            this.chtVotingInstanceSummary.Location = new System.Drawing.Point(454, 86);
            this.chtVotingInstanceSummary.Name = "chtVotingInstanceSummary";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtVotingInstanceSummary.Series.Add(series2);
            this.chtVotingInstanceSummary.Size = new System.Drawing.Size(479, 417);
            this.chtVotingInstanceSummary.TabIndex = 84;
            this.chtVotingInstanceSummary.Text = "chart1";
            this.chtVotingInstanceSummary.Visible = false;
            // 
            // radVotesByOption
            // 
            this.radVotesByOption.AutoSize = true;
            this.radVotesByOption.ButtonSize = 18F;
            this.radVotesByOption.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.radVotesByOption.CheckedSize = 12F;
            this.radVotesByOption.Location = new System.Drawing.Point(516, 526);
            this.radVotesByOption.MinimumSize = new System.Drawing.Size(0, 21);
            this.radVotesByOption.Name = "radVotesByOption";
            this.radVotesByOption.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radVotesByOption.Size = new System.Drawing.Size(108, 21);
            this.radVotesByOption.TabIndex = 88;
            this.radVotesByOption.TabStop = true;
            this.radVotesByOption.Text = "Votes by option";
            this.radVotesByOption.UnCheckedColor = System.Drawing.Color.Gray;
            this.radVotesByOption.UseVisualStyleBackColor = true;
            this.radVotesByOption.CheckedChanged += new System.EventHandler(this.radVotesByOption_CheckedChanged);
            // 
            // radVotesByArea
            // 
            this.radVotesByArea.AutoSize = true;
            this.radVotesByArea.ButtonSize = 18F;
            this.radVotesByArea.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.radVotesByArea.CheckedSize = 12F;
            this.radVotesByArea.Location = new System.Drawing.Point(749, 526);
            this.radVotesByArea.MinimumSize = new System.Drawing.Size(0, 21);
            this.radVotesByArea.Name = "radVotesByArea";
            this.radVotesByArea.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radVotesByArea.Size = new System.Drawing.Size(95, 21);
            this.radVotesByArea.TabIndex = 87;
            this.radVotesByArea.TabStop = true;
            this.radVotesByArea.Text = "Votes by city";
            this.radVotesByArea.UnCheckedColor = System.Drawing.Color.Gray;
            this.radVotesByArea.UseVisualStyleBackColor = true;
            this.radVotesByArea.CheckedChanged += new System.EventHandler(this.radVotesByArea_CheckedChanged);
            // 
            // btnExportSummary
            // 
            this.btnExportSummary.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportSummary.BackColor = System.Drawing.Color.SlateBlue;
            this.btnExportSummary.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnExportSummary.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnExportSummary.BorderRadius = 10;
            this.btnExportSummary.BorderSize = 2;
            this.btnExportSummary.BTextColour = System.Drawing.Color.White;
            this.btnExportSummary.FlatAppearance.BorderSize = 0;
            this.btnExportSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportSummary.ForeColor = System.Drawing.Color.White;
            this.btnExportSummary.Location = new System.Drawing.Point(68, 516);
            this.btnExportSummary.Name = "btnExportSummary";
            this.btnExportSummary.Size = new System.Drawing.Size(145, 31);
            this.btnExportSummary.TabIndex = 86;
            this.btnExportSummary.Text = "Export";
            this.btnExportSummary.UseVisualStyleBackColor = false;
            this.btnExportSummary.Click += new System.EventHandler(this.btnExportSummary_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReturn.BackColor = System.Drawing.Color.SlateBlue;
            this.btnReturn.BackgroundColour = System.Drawing.Color.SlateBlue;
            this.btnReturn.BorderColour = System.Drawing.Color.DarkSlateBlue;
            this.btnReturn.BorderRadius = 10;
            this.btnReturn.BorderSize = 2;
            this.btnReturn.BTextColour = System.Drawing.Color.White;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(397, 618);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(189, 46);
            this.btnReturn.TabIndex = 85;
            this.btnReturn.Text = "Return to Navigation";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboVotingInstanceDDList
            // 
            this.cboVotingInstanceDDList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboVotingInstanceDDList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboVotingInstanceDDList.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboVotingInstanceDDList.BorderSize = 1;
            this.cboVotingInstanceDDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboVotingInstanceDDList.Enabled = false;
            this.cboVotingInstanceDDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboVotingInstanceDDList.ForeColor = System.Drawing.Color.DimGray;
            this.cboVotingInstanceDDList.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboVotingInstanceDDList.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboVotingInstanceDDList.ListTextColor = System.Drawing.Color.DimGray;
            this.cboVotingInstanceDDList.Location = new System.Drawing.Point(68, 73);
            this.cboVotingInstanceDDList.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboVotingInstanceDDList.Name = "cboVotingInstanceDDList";
            this.cboVotingInstanceDDList.Padding = new System.Windows.Forms.Padding(1);
            this.cboVotingInstanceDDList.Size = new System.Drawing.Size(334, 30);
            this.cboVotingInstanceDDList.TabIndex = 55;
            this.cboVotingInstanceDDList.Texts = "";
            this.cboVotingInstanceDDList.OnSelectedIndexChanged += new System.EventHandler(this.cboVotingInstanceDDList_OnSelectedIndexChanged);
            // 
            // grdVotesByArea
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVotesByArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdVotesByArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVotesByArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeader_City,
            this.colHeader_VOName,
            this.colHeader_NumberOfVotes});
            this.grdVotesByArea.Location = new System.Drawing.Point(454, 86);
            this.grdVotesByArea.Name = "grdVotesByArea";
            this.grdVotesByArea.Size = new System.Drawing.Size(479, 417);
            this.grdVotesByArea.TabIndex = 90;
            // 
            // colHeader_City
            // 
            this.colHeader_City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHeader_City.HeaderText = "City";
            this.colHeader_City.Name = "colHeader_City";
            this.colHeader_City.Width = 170;
            // 
            // colHeader_VOName
            // 
            this.colHeader_VOName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHeader_VOName.HeaderText = "Voting Option";
            this.colHeader_VOName.Name = "colHeader_VOName";
            this.colHeader_VOName.Width = 170;
            // 
            // colHeader_NumberOfVotes
            // 
            this.colHeader_NumberOfVotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHeader_NumberOfVotes.HeaderText = "Total Votes";
            this.colHeader_NumberOfVotes.Name = "colHeader_NumberOfVotes";
            this.colHeader_NumberOfVotes.Width = 89;
            // 
            // ucVotingSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.grdVotesByArea);
            this.Controls.Add(this.radVotesByOption);
            this.Controls.Add(this.radVotesByArea);
            this.Controls.Add(this.btnExportSummary);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.chtVotingInstanceSummary);
            this.Controls.Add(this.pnlElectionDetails);
            this.Controls.Add(this.cboVotingInstanceDDList);
            this.Controls.Add(this.lblSummaryMessage);
            this.Name = "ucVotingSummary";
            this.Size = new System.Drawing.Size(984, 710);
            this.Load += new System.EventHandler(this.ucVotingSummary_Load);
            this.pnlElectionDetails.ResumeLayout(false);
            this.pnlElectionDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVotingInstanceSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVotesByArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomComboBox cboVotingInstanceDDList;
        private System.Windows.Forms.Label lblSummaryMessage;
        private System.Windows.Forms.Panel pnlElectionDetails;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblDescriptionText;
        private System.Windows.Forms.Label lblElectionNameText;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblElectionName;
        private System.Windows.Forms.Label lblElectionDetails;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVotingInstanceSummary;
        private CustomControls.RoundedButton btnReturn;
        private System.Windows.Forms.Label lblTotalnumberOfVotesText;
        private System.Windows.Forms.Label lblTotalnumberOfVotes;
        private CustomControls.RoundedButton btnExportSummary;
        private CustomControls.CustomRadioButton radVotesByArea;
        private CustomControls.CustomRadioButton radVotesByOption;
        private System.Windows.Forms.DataGridView grdVotesByArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader_VOName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader_NumberOfVotes;
    }
}
