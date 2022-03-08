using SBMMVotingSystem.CustomControls;
using SBMMVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SBMMVotingSystem.Forms.frmMainGui;

namespace SBMMVotingSystem.Forms.SubForms
{
    public partial class ucVotingForm : UserControl
    {
        #region Attributes
        private frmMainGui _ThisMainGui { get; set; }
        private VotingInstanceViewModel SelectedVotingInstance { get; set; }

        /// <summary>
        /// A collection of all the voting options and their related control
        /// used for submitting a new vote and various checks
        /// Key: Control Name, VoteSelectionViewModel: Voting Option Id and Prefrence value
        /// </summary>
        private Dictionary<String, VoteSelectionViewModel> VoteResults { get; set; } 

        #endregion

        #region Constructor
        public ucVotingForm(frmMainGui mainGui)
        {
            InitializeComponent();
            _ThisMainGui = mainGui;
        }

        private void ucVotingForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetupVotingForm();
            ChangeLanguageForControls();
        }
        #endregion

        #region Internal methods
        internal void SetupVotingForm()
        {
            cboElectionTypeDDList.Items.Clear();
            lblErrorMessageText.Visible = false;
            pnlVotingOptions.Controls.Clear();

            VoteResults = new Dictionary<string, VoteSelectionViewModel>();
            lblAddressText.Text = String.Empty;
            lblDescriptionText.Text = String.Empty;
            lblElectionNameText.Text = String.Empty;

            btnSubmitVote.Enabled = false;

            if (_ThisMainGui._ThisVotingManager._allVotingInstances.Count > 0)
            {
                foreach (VotingInstanceViewModel thisInstance in _ThisMainGui._ThisVotingManager._allVotingInstances)
                {
                    // Create the item object
                    // ----------------------
                    ListViewItem viItem = new ListViewItem(thisInstance.VIName);
                    viItem.SubItems.Add(thisInstance.VotingInstanceId.ToString());

                    // Populate the drop down list with the same options
                    // -------------------------------------------------
                    cboElectionTypeDDList.Items.Add(viItem.Text);
                }
            }
        }
        #endregion

        #region User event handler
        /// <summary>
        /// User event handler for a user selecting a election to vote on
        /// </summary>
        private void cboElectionTypeDDList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedinstance = (string)cboElectionTypeDDList.SelectedItem;

            // Get the voting instance
            // -----------------------
            SelectedVotingInstance = _ThisMainGui._ThisVotingManager.GetVotingInstanceForName(selectedinstance);

            if (SelectedVotingInstance != null)
            {
                // Populate the election details
                // -----------------------------
                lblErrorMessageText.Visible = false;
                numVotingInstanceId.Value = SelectedVotingInstance.VotingInstanceId;
                VoteResults = new Dictionary<string, VoteSelectionViewModel>();

                lblAddressText.Text = $"{SelectedVotingInstance.Address.AddressLine1 ?? String.Empty}\n\r" +
                                        $"{SelectedVotingInstance.Address.AddressLine2 ?? String.Empty}\n\r" +
                                        $"{SelectedVotingInstance.Address.City ?? String.Empty}\n\r" +
                                        $"{SelectedVotingInstance.Address.Country ?? String.Empty}\n\r" +
                                        $"{SelectedVotingInstance.Address.Postcode ?? String.Empty}";
                lblDescriptionText.Text = SelectedVotingInstance.VIDescription ?? String.Empty;
                lblElectionNameText.Text = SelectedVotingInstance.VIName;

                // Populate the voting option
                // --------------------------
                switch (SelectedVotingInstance.VIVotingMode)
                {
                    case Managers.VotingManager.VotingMode.FirstPassedThePost:
                        CreateRadioButton(SelectedVotingInstance.VotingOptions);
                        break;
                    case Managers.VotingManager.VotingMode.SingleTransferableVote:
                        CreateDropDownOptionSelector(SelectedVotingInstance.VotingOptions);
                        break;
                    case Managers.VotingManager.VotingMode.SupplementaryVote:
                        CreateDropDownOptionSelector(SelectedVotingInstance.VotingOptions);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// User wants to cancel their vote
        /// </summary>
        private void btnCancelVote_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.UserNavForm);
        }

        /// <summary>
        /// User wants to submit their vote
        /// </summary>
        private void btnSubmitVote_Click(object sender, EventArgs e)
        {
            bool voteSubitted = false;

            if (SelectedVotingInstance != null)
            {
                SuperUserViewModel thisUser = _ThisMainGui._ThisUserManager.GetUserDetails(_ThisMainGui._ThisUserManager.CurrentUsernameId);

                // This mode only has to submit one vote
                // -------------------------------------
                if (SelectedVotingInstance.VIVotingMode == Managers.VotingManager.VotingMode.FirstPassedThePost)
                {
                    // Get the data
                    // ------------
                    int optionId = VoteResults.FirstOrDefault(r => r.Value.PreferenceValue == 1).Value.VotingOptionId;

                    VoteDBModel voteDBModel = new VoteDBModel()
                    {
                        City = thisUser.Address.City,
                        VotedForOptionId = optionId,
                        VotingInstanceId = SelectedVotingInstance.VotingInstanceId,
                        Preference = 1
                    };

                    // Send to manager to add to the database
                    // --------------------------------------
                    voteSubitted = _ThisMainGui._ThisVotingManager.SubmitNewVote(voteDBModel, thisUser.UserId) != 0;
                }
                // This voting mode has to submit multiple votes
                // ---------------------------------------------
                else
                {
                    foreach (var item in VoteResults)
                    {
                        if (item.Value.PreferenceValue != 0)
                        {
                            VoteDBModel voteDBModel = new VoteDBModel()
                            {
                                City = thisUser.Address.City,
                                VotedForOptionId = item.Value.VotingOptionId,
                                VotingInstanceId = SelectedVotingInstance.VotingInstanceId,
                                Preference = item.Value.PreferenceValue
                            };

                            // Send to manager to add to the database
                            // --------------------------------------
                            voteSubitted = _ThisMainGui._ThisVotingManager.SubmitNewVote(voteDBModel, thisUser.UserId) != 0;
                        }
                    }
                }

                // Switch the screen back to the nav form
                // --------------------------------------
                if (voteSubitted) { _ThisMainGui.SwitchScreenType(ScreenTypes.UserNavForm); }
                else { lblErrorMessageText.Visible = true; lblErrorMessageText.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorMessageText"); ; }
            }
        }

        /// <summary>
        /// User has selected a diffrent voting option
        /// Update the private string 
        /// </summary>
        private void votingOption_CheckedChanged(object sender, EventArgs e)
        {
            var radBtn = (CustomRadioButton)sender;
            foreach (var item in VoteResults.Keys)
            {
                if(item == radBtn.Text) { VoteResults[radBtn.Name].PreferenceValue = 1; }
                else { VoteResults[radBtn.Name].PreferenceValue = 0; }
            }
        }

        /// <summary>
        /// Check to make sure the user has added correct prefrences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Preference_OnKeyPress(object sender, EventArgs e)
        {
            RoundedTextbox textBox = sender as RoundedTextbox;
            int enteredNumber = 0;

            if (textBox.Texts.Length > 0)
            {
                // IF the entered char is a number 
                // ELSE char is not a number
                // -------------------------------
                if (int.TryParse(textBox.Texts, out enteredNumber))
                {
                    // IF the voting mode is set to Single Transferable Vote 
                    // ELSE if the voting mode is set to Sumplementary Vote
                    // -----------------------------------------------------
                    if(SelectedVotingInstance.VIVotingMode == Managers.VotingManager.VotingMode.SingleTransferableVote)
                    {
                        // IF the number entered is between 1 and the max number of voting options
                        // ELSE entered number is out of bounds
                        // -----------------------------------------------------------------------
                        if (enteredNumber <= SelectedVotingInstance.VotingOptions.Count && enteredNumber > 0)
                        {
                            // IF the number entered is already in the saved collection
                            // ELSE Number is invalid
                            // --------------------------------------------------------
                            if (!VoteResults.Values.Select(v => v.PreferenceValue).Contains(enteredNumber))
                            {
                                VoteResults[textBox.Name].PreferenceValue = enteredNumber;
                                btnSubmitVote.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show(_ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupMessage_NumberAlreadySelected"), _ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupHeader"));
                                textBox.Texts = String.Empty;
                                textBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show(_ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupMessage_NumberOutOfBounds"), _ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupHeader"));
                            textBox.Texts = String.Empty;
                            textBox.Focus();
                        }
                    }
                    else if(SelectedVotingInstance.VIVotingMode == Managers.VotingManager.VotingMode.SupplementaryVote)
                    {
                        // IF the number entered is either 1 or 2
                        // ELSE entered number is out of bounds
                        // --------------------------------------
                        if (enteredNumber == 1 || enteredNumber == 2)
                        {
                            // IF the number entered is already in the saved collection
                            // ELSE Number is invalid
                            // --------------------------------------------------------
                            if (!VoteResults.Values.Select(v => v.PreferenceValue).Contains(enteredNumber))
                            {
                                VoteResults[textBox.Name].PreferenceValue = enteredNumber;
                                btnSubmitVote.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show(_ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupMessage_NumberAlreadySelected") + VoteResults.Keys.Count, _ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupHeader"));
                                textBox.Texts = String.Empty;
                                textBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show(_ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupMessage_NumberOutOfBounds"), _ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupHeader"));
                            textBox.Texts = String.Empty;
                            textBox.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(_ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupMessage_NotANumber"), _ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorPopupHeader"));
                    textBox.Texts = String.Empty;
                    textBox.Focus();
                }
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Create a radio button for each of the voting options 
        /// and place them on the form
        /// </summary>
        /// <param name="optionsList">List of voting options</param>
        private void CreateRadioButton(List<VotingOptionDBModel> optionsList)
        {
            Point btnLocation = new Point(15, 17);
            int incrementBy = 60;

            pnlVotingOptions.Controls.Clear();

            foreach (VotingOptionDBModel thisOption in optionsList)
            {
                CustomRadioButton radioButton = new CustomRadioButton();

                radioButton.Location = btnLocation;
                radioButton.ButtonSize = 40F;
                radioButton.CheckedSize = 35F;
                radioButton.Text = thisOption.VOName;
                radioButton.CheckedColor = Color.MediumSlateBlue;
                radioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                radioButton.Name = "btn" + thisOption.VOName;
                radioButton.UnCheckedColor = Color.Gray;
                radioButton.CheckedChanged += new EventHandler(this.votingOption_CheckedChanged);
                radioButton.Size = new Size(180, 55);
                radioButton.Checked = false;

                btnLocation = new Point(btnLocation.X, btnLocation.Y + incrementBy);
                pnlVotingOptions.Controls.Add(radioButton);

                VoteResults.Add(radioButton.Name, new VoteSelectionViewModel() { VotingOptionId = thisOption.VotingOptionId, PreferenceValue = 0 });
            }
        }

        /// <summary>
        /// Create a dropdown that has a list of voting options
        /// </summary>
        /// <param name="optionsList">List of voting options</param>
        private void CreateDropDownOptionSelector(List<VotingOptionDBModel> optionsList)
        {
            Point lblLocation = new Point(121, 84);
            Point textBoxLocation = new Point(48, 71);
            int incrementBy = 60;

            pnlVotingOptions.Controls.Clear();

            // Create info label
            // -----------------
            Label labelInfo = new Label();
            labelInfo.Anchor = AnchorStyles.None;
            labelInfo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            labelInfo.Location = new Point(13, 8);
            labelInfo.Name = "lblInfoMessage";
            labelInfo.Size = new Size(347, 60);
            labelInfo.TabIndex = 89;
            labelInfo.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblInfoMessage");
            labelInfo.AutoSize = false;

            pnlVotingOptions.Controls.Add(labelInfo);

            foreach (VotingOptionDBModel thisOption in optionsList)
            {
                // Create option label
                // -------------------
                Label label = new Label();
                label.Anchor = AnchorStyles.None;
                label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                label.Location = lblLocation;
                label.Name = "lbl" + thisOption.VOName;
                label.Padding = new Padding(1);
                label.TabIndex = 79;
                label.Text = thisOption.VOName;
                label.TextAlign = ContentAlignment.MiddleRight;
                label.AutoSize = true;

                // Create text fields
                // ------------------
                RoundedTextbox textBox = new RoundedTextbox();

                textBox.BorderColour = Color.SlateBlue;
                textBox.Anchor = AnchorStyles.None;
                textBox.BorderFocusColour = Color.DarkSlateBlue;
                textBox.BorderRadius = 10;
                textBox.BorderSize = 2;
                textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                textBox.ForeColor = SystemColors.ControlDarkDark;
                textBox.Location = textBoxLocation;
                textBox.Margin = new Padding(6);
                textBox.Multiline = false;
                textBox.Name = "txt" + thisOption.VOName;
                textBox.Padding = new Padding(5, 5, 5, 5);
                textBox.PasswordChar = false;
                textBox.PlaceholderColor = Color.DimGray;
                textBox.PlaceholderText = "";
                textBox.Size = new Size(38, 53);
                textBox.TabIndex = 89;
                textBox.UnderlinedStyle = false;
                textBox.Leave += new EventHandler(this.Preference_OnKeyPress);

                VoteResults.Add(textBox.Name, new VoteSelectionViewModel() { VotingOptionId = thisOption.VotingOptionId, PreferenceValue = 0 });

                // Increment the label and text fields for next option
                // ---------------------------------------------------
                lblLocation = new Point(lblLocation.X, lblLocation.Y + incrementBy);
                textBoxLocation = new Point(textBoxLocation.X, textBoxLocation.Y + incrementBy);

                // Add option to panel
                // -------------------
                pnlVotingOptions.Controls.Add(label);
                pnlVotingOptions.Controls.Add(textBox);
            }
        }

        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            lblElectionDetails.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblElectionDetails");
            lblElectionName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblElectionName");
            lblDescription.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblDescription");
            lblErrorMessageText.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblErrorMessageText");
            lblAddress.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddress");
            btnSubmitVote.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnSubmitVote");
            btnCancelVote.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnCancelVote");

            // Get the voting instance
            // -----------------------
            if (SelectedVotingInstance != null)
            {
                switch (SelectedVotingInstance.VIVotingMode)
                {
                    case Managers.VotingManager.VotingMode.FirstPassedThePost:
                        CreateRadioButton(SelectedVotingInstance.VotingOptions);
                        break;
                    case Managers.VotingManager.VotingMode.SingleTransferableVote:
                        CreateDropDownOptionSelector(SelectedVotingInstance.VotingOptions);
                        break;
                    case Managers.VotingManager.VotingMode.SupplementaryVote:
                        CreateDropDownOptionSelector(SelectedVotingInstance.VotingOptions);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
