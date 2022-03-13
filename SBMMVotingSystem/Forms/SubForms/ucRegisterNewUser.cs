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
using static SBMMVotingSystem.Managers.UserManager;

namespace SBMMVotingSystem.Forms.SubForms
{
    public partial class ucRegisterNewUser : UserControl
    {
        #region Constants
        private const string _c_PasswordsDontMatch = "- Passwords do not match";
        private const string _c_PasswordsMatch = "- Passwords match";
        private const string _c_PasswordsLenghtNeedsIncreasing = "- Password should be longer then 10 characters";
        private const string _c_PasswordsLengthNeedsDecreasing = "- Password is greater than 10 characters";


        private readonly Color _c_PasswordMsgDontMatch = Color.OrangeRed;
        private readonly Color _c_PasswordGood = Color.Green;
        #endregion

        #region Attributes
        internal frmMainGui _ThisMainGui { get; set; }
        #endregion

        #region Constructor
        public ucRegisterNewUser(frmMainGui mainGui)
        {
            InitializeComponent();

            _ThisMainGui = mainGui;

            SetupFormForNewUser();
        }

        /// <summary>
        /// On inital load setup some default properties
        /// </summary>
        private void ucAdminNewUser_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            ChangeLanguageForControls();
        }
        #endregion

        #region User events
        /// <summary>
        /// User has requested to save the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitNewUser_Click(object sender, EventArgs e)
        {
            bool userAdded;

            SuperUserViewModel userToSave = new SuperUserViewModel()
            {
                UserId = (int)numUserId.Value,
                Username = txtUsername.Texts,
                Password = txtPassword.Texts,
                UserType = (UserType)cboUserTypeDDList.SelectedItem,
                FirstName = txtFirstName.Texts,
                LastName = txtLastName.Texts,
                Age = int.Parse(cboAgeDDList.SelectedItem.ToString()),
                RefNumber = txtVotingRefNumber.Texts,
                Enabled = tbtnEnabled.Checked ? 1 : 0,
            };

            AddressDBModel addressToSave = new AddressDBModel()
            {
                AddressId = (int)numAddressId.Value,
                AddressLine1 = txtAddress1.Texts,
                AddressLine2 = txtAddress2.Texts,
                City = txtAddress3.Texts,
                Country = txtCountry.Texts,
                Postcode = txtPostcode.Texts,
            };

            // Save the new/existing user
            // --------------------------
            if (userToSave.UserId != 0)
            {
                userAdded = _ThisMainGui._ThisUserManager.SaveUpdatesToUser(userToSave, addressToSave);
            }
            else
            {
                userAdded = _ThisMainGui._ThisUserManager.SaveThisNewUser(userToSave, addressToSave);
                if (userAdded) { _ThisMainGui.PopulateLoginName(userToSave.Username); }
            }

            // Switch the displays
            // -------------------
            if (userAdded)
            {
                if (userToSave.UserId != 0)
                {
                    _ThisMainGui.SwitchScreenType(frmMainGui.ScreenTypes.UsersManagementForm);
                }
                else
                {
                    _ThisMainGui.SwitchScreenType(frmMainGui.ScreenTypes.UserNavForm);
                    _ThisMainGui.UserNavForm.SetupNavForm();
                }
            }
            else
            {
                lblErrorMessageText.Text = "Something went wrong please try again. If the problem persists please email support at support@unknown.com.";
            }
        }

        /// <summary>
        /// User has clicked the cancel button
        /// Return them to the admin nav page
        /// </summary>
        private void btnCancelNewUser_Click(object sender, EventArgs e)
        {
            if (_ThisMainGui._ThisUserManager.IsLoggedIn())
            {
                _ThisMainGui.SwitchScreenType(frmMainGui.ScreenTypes.UserNavForm);
            }
            else
            {
                _ThisMainGui.SwitchScreenType(frmMainGui.ScreenTypes.MainUserForm);
            }
        }

        /// <summary>
        /// Checks the password to make sure they are the same and
        /// that they are above a certain lenght
        /// </summary>
        private void PasswordChecker_TextChanged(object sender, EventArgs e)
        {
            PasswordChecker();
        }

        /// <summary>
        /// User has requested to update a users password
        /// Show and hide the relevant panels
        /// </summary>
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            // Show and hide the relevant fields
            // ---------------------------------
            btnUpdatePassword.Visible = false;
            pnlPasswordArea.Visible = true;

            // Clear the password fields
            // -------------------------
            txtPassword.Texts = String.Empty;
            txtConfirmPassword.Texts = String.Empty;
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Clear any data that is still inside the controls
        /// </summary>
        internal void SetupFormForNewUser()
        {
            // Set areas and user messages
            // ---------------------------
            lblPasswordMsgDontMatch.Text = _c_PasswordsDontMatch;
            lblPasswordMsgLength.Text = _c_PasswordsLenghtNeedsIncreasing;
            lblPasswordMsgDontMatch.ForeColor = _c_PasswordMsgDontMatch;
            lblPasswordMsgLength.ForeColor = _c_PasswordMsgDontMatch;
            pnlPasswordArea.Visible = true;
            tbtnEnabled.Checked = true;
            tbtnEnabled.Visible = false;
            lblEnabled.Visible = false;

            // Clear all text fields
            // ---------------------
            txtAddress1.Texts = String.Empty;
            txtAddress2.Texts = String.Empty;
            txtAddress3.Texts = String.Empty;
            txtConfirmPassword.Texts = String.Empty;
            txtCountry.Texts = String.Empty;
            txtFirstName.Texts = String.Empty;
            txtLastName.Texts = String.Empty;
            txtPassword.Texts = String.Empty;
            txtPostcode.Texts = String.Empty;
            txtUsername.Texts = String.Empty;
            txtVotingRefNumber.Texts = String.Empty;
            numAddressId.Value = 0;
            numUserId.Value = 0;

            // Set the drop down lists
            // -----------------------
            cboUserTypeDDList.Visible = false;
            cboUserTypeDDList.Items.Clear();
            foreach (UserType userType in (UserType[])Enum.GetValues(typeof(UserType)))
            {
                cboUserTypeDDList.Items.Add(userType);
            }
            cboUserTypeDDList.SelectedItem = UserType.Voter;

            cboAgeDDList.Items.Clear();
            for (int i = 18; i < 101; i++)
            {
                cboAgeDDList.Items.Add(i);
            }
            cboAgeDDList.SelectedItem = null;
        }

        /// <summary>
        /// Setup the form for a existing user
        /// </summary>
        /// <param name="thisUser"></param>
        internal void SetupFormForUpdateUser(SuperUserViewModel thisUser)
        {
            // Populate all teh text fields
            // ----------------------------
            txtAddress1.Texts = thisUser.Address.AddressLine1;
            txtAddress2.Texts = thisUser.Address.AddressLine2;
            txtAddress3.Texts = thisUser.Address.City;
            txtCountry.Texts = thisUser.Address.Country;
            txtFirstName.Texts = thisUser.FirstName;
            txtLastName.Texts = thisUser.LastName;
            txtPostcode.Texts = thisUser.Address.Postcode;
            txtUsername.Texts = thisUser.Username;
            txtVotingRefNumber.Texts = thisUser.RefNumber;
            numUserId.Value = thisUser.UserId;
            numAddressId.Value = thisUser.AddressId;
            txtPassword.Texts = String.Empty;
            txtConfirmPassword.Texts = String.Empty;
            tbtnEnabled.Checked = thisUser.Enabled == 1 ? true : false;
            tbtnEnabled.Visible = true;
            lblEnabled.Visible = true;

            // Hide the password area
            // ----------------------
            pnlPasswordArea.Visible = false;
            btnUpdatePassword.Visible = true;

            // Update the drop down lists
            // --------------------------
            cboUserTypeDDList.Visible = true;
            lblUserType.Visible = true;
            cboUserTypeDDList.Items.Clear();
            foreach (UserType userType in (UserType[])Enum.GetValues(typeof(UserType)))
            {
                cboUserTypeDDList.Items.Add(userType);
            }
            cboUserTypeDDList.SelectedItem = thisUser.UserType;

            cboAgeDDList.Items.Clear();
            for (int i = 18; i < 101; i++)
            {
                cboAgeDDList.Items.Add(i);
            }
            cboAgeDDList.SelectedItem = thisUser.Age;

            btnSubmitNewUser.Enabled = true;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Check to make sure the users passwords match
        /// </summary>
        private void PasswordChecker()
        {
            bool firstTestState = false;

            if ((txtPassword.Texts.Length < 10 && txtConfirmPassword.Texts.Length < 10))
            {
                // Password lenght not ok
                // ----------------------
                lblPasswordMsgLength.Text = _c_PasswordsLenghtNeedsIncreasing;
                lblPasswordMsgLength.ForeColor = _c_PasswordMsgDontMatch;
                btnSubmitNewUser.Enabled = false;
            }
            else
            {
                // Password length is ok
                // ---------------------
                firstTestState = true;
                lblPasswordMsgLength.Text = _c_PasswordsLengthNeedsDecreasing;
                lblPasswordMsgLength.ForeColor = _c_PasswordGood;
                btnSubmitNewUser.Enabled = false;
            }

            if (txtPassword.Texts != txtConfirmPassword.Texts || txtPassword.Texts.Length == 0)
            {
                // Passwords dont match
                // --------------------
                lblPasswordMsgDontMatch.Text = _c_PasswordsDontMatch;
                lblPasswordMsgDontMatch.ForeColor = _c_PasswordMsgDontMatch;
                btnSubmitNewUser.Enabled = false;
            }
            else
            {
                // Passwords Match
                // ---------------
                lblPasswordMsgDontMatch.Text = _c_PasswordsMatch;
                lblPasswordMsgDontMatch.ForeColor = _c_PasswordGood;

                if (firstTestState) { btnSubmitNewUser.Enabled = true; }
            }
        }
        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            lblFirstName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblFirstName");
            lblLastName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblLastName");
            lblAge.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAge");
            lblAddressHeader.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddressHeader");
            lblAddressLine1.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddressLine1");
            lblAddressLine2.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddressLine2");
            lblAddressLine3.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddressLine3");
            lblConfirmPasswordHeader.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblConfirmPasswordHeader");
            lblCountry.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblCountry");
            lblIsUserVotingUserMessage.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblIsUserVotingUserMessage");
            lblPasswordHeader.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblPasswordHeader");
            lblPasswordMsgDontMatch.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblPasswordMsgDontMatch");
            lblPasswordMsgLength.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblPasswordMsgLength");
            lblPostcode.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblPostcode");
            lblUsernameHeader.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblUsernameHeader");
            lblUserType.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblUserType");
            lblVotingRef.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblVotingRef");
            btnUpdatePassword.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnUpdatePassword");
            btnCancelNewUser.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnCancelNewUser");
            btnSubmitNewUser.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnSubmitNewUser");
            lblEnabled.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblEnabled");
        }
        #endregion
    }
}
