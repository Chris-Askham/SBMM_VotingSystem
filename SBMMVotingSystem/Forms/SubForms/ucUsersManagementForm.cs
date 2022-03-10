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
    public partial class ucUsersManagementForm : UserControl
    {
        #region Constructor        
        private frmMainGui _ThisMainGui;
        public ucUsersManagementForm(frmMainGui mainForm)
        {
            _ThisMainGui = mainForm;
            InitializeComponent();
        }

        private void ucUsersManagementForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetupNavForm();
            ChangeLanguageForControls();
        }
        #endregion

        #region User event methods
        /// <summary>
        /// User has selected a user 
        /// Display the regestraion form for user to update
        /// the selected user
        /// </summary>
        private void lstUserGrid_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ListViewItem item = lstUserGrid.FocusedItem;
            int userId = Convert.ToInt32(item.Text);

            SuperUserViewModel thisUser = _ThisMainGui._ThisUserManager.GetUserDetails(userId);

            _ThisMainGui.RegisterNewUser.SetupFormForUpdateUser(thisUser);
            _ThisMainGui.SwitchScreenType(ScreenTypes.RegisterNewUser);
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Setup the form for the current user
        /// </summary>
        internal void SetupNavForm()
        {
            lstUserGrid.Items.Clear();

            // Get the users data from the datbase
            // -----------------------------------
            List<SuperUserViewModel> usersList = _ThisMainGui._ThisUserManager.GetUserList(tbtnShowDeactivatedUsers.Checked);

            for (int i = 0; i < usersList.Count; i++)
            {
                // Create the list view model
                // --------------------------
                ListViewItem usersListViewItem = new ListViewItem(usersList[i].UserId.ToString());
                usersListViewItem.SubItems.Add(usersList[i].Username);
                usersListViewItem.SubItems.Add(usersList[i].FirstName);
                usersListViewItem.SubItems.Add(usersList[i].LastName);
                usersListViewItem.SubItems.Add(
                    usersList[i].Address.AddressLine1 + ", " +
                    usersList[i].Address.AddressLine2 + ", " +
                    usersList[i].Address.City + ", " +
                    usersList[i].Address.Country + ", " +
                    usersList[i].Address.Postcode);
                usersListViewItem.SubItems.Add(usersList[i].Age.ToString());
                usersListViewItem.SubItems.Add(usersList[i].RefNumber);
                usersListViewItem.SubItems.Add(usersList[i].Enabled == 1 ? "Yes" : "No");

                if (tbtnShowDeactivatedUsers.Checked)
                {
                    if (usersList[i].Enabled == 1)
                    {
                        usersListViewItem.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        usersListViewItem.BackColor = Color.LightSalmon;
                    }
                }

                // Add the model to the list view control
                // --------------------------------------
                lstUserGrid.Items.Add(usersListViewItem);
            }
        }

        /// <summary>
        /// Refresh the grid to show all or part of the user list
        /// </summary>
        private void tbtnShowDeactivatedUsers_CheckedChanged(object sender, EventArgs e)
        {
            SetupNavForm();
        }
        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            ccolUserId.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("ccolUserId");
            colAddress.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("colAddress");
            colAge.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("colAge");
            colFirstName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("colFirstName");
            colHasVoted.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("colHasVoted");
            colLastName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("colLastName");
            colRefNumber.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("colRefNumber");
            colUsername.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("colUsername");
            lblShowDeactivatedUsers.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblShowDeactivatedUsers");
            colEnabled.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("colEnabled");
        }

        #endregion
    }
}
