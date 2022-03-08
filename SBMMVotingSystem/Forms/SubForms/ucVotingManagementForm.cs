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
    public partial class ucVotingManagementForm : UserControl
    {
        #region Attributes

        internal frmMainGui _ThisMainGui { get; set; }

        #endregion

        #region Constructor
        public ucVotingManagementForm(frmMainGui thisMainGui)
        {
            _ThisMainGui = thisMainGui;
            InitializeComponent();
        }

        /// <summary>
        /// Setup some defaults when the form is loaded
        /// </summary>
        private void ucVotingManagementForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            SetupVotingInstnaceLists();
            ChangeLanguageForControls();
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Setup some of the form controls
        /// </summary>
        internal void SetupVotingInstnaceLists()
        {
            // Get a list of all possible voting instances 
            // -------------------------------------------
            lstVotingInstances.Items.Clear();

            List<VotingInstanceViewModel> allElections = _ThisMainGui._ThisVotingManager._allVotingInstances;

            if (allElections.Count > 0)
            {
                if (!tbtnShowDeactivatedUsers.Checked) { allElections = allElections.Where(e => e.CurrentlyInUse == 1).ToList(); }

                foreach (VotingInstanceViewModel thisInstance in allElections)
                {
                    // Create the item object
                    // ----------------------
                    ListViewItem viItem = new ListViewItem(thisInstance.VIName);
                    viItem.SubItems.Add(thisInstance.VotingInstanceId.ToString());
                    if (tbtnShowDeactivatedUsers.Checked)
                    {
                        if (thisInstance.CurrentlyInUse == 1)
                        {
                            viItem.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            viItem.BackColor = Color.LightSalmon;
                        }
                    } 

                    // Populate the list box with the possible options
                    // -----------------------------------------------
                    lstVotingInstances.Items.Add(viItem);
                }
            }
            else
            {
                lstVotingInstances.Items.Add("No elections saved");
            }

            // Setup the buttons, text feilds, and drop-down lists
            // ---------------------------------------------------
            lblAddressText.Text = string.Empty;
            lblDescriptionText.Text = string.Empty; 
            lblElectionNameText.Text = string.Empty;
            lstPossibleVotingOptions.Items.Clear(); 
            btnUpdateInstance.Enabled = lstVotingInstances.SelectedItems.Count > 0;
            btnDeleteSelected.Enabled = lstVotingInstances.SelectedItems.Count > 0;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// User has requested to setup a new voting instance
        /// Show the Voting setup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.VotingSetupForm);
            _ThisMainGui.VotingSetupForm.SetupForNewVotingInstance();
        }

        /// <summary>
        /// User wants to delete a voting instance from the datbase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            ListViewItem itemToDelete = lstVotingInstances.SelectedItems.Cast<ListViewItem>().FirstOrDefault();

            if (itemToDelete != null)
            {
                // Get the voting instance and delete from the database
                // ----------------------------------------------------
                VotingInstanceViewModel instanceToDelete = _ThisMainGui._ThisVotingManager.GetVotingInstanceForName(itemToDelete.SubItems[0].Text);
                _ThisMainGui._ThisVotingManager.DeleteVotingInstance(instanceToDelete, _ThisMainGui._ThisUserManager.CurrentUsernameId);

                // Remove the item from the list view
                // ----------------------------------
                lstVotingInstances.Items.Remove(itemToDelete);
            }
        }

        /// <summary>
        /// When a voting instance is clicked populate the 
        /// details on the right hand side of the form
        /// </summary>
        private void lstVotingInstances_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem item = lstVotingInstances.FocusedItem;
            VotingInstanceViewModel chosenModel = _ThisMainGui._ThisVotingManager.GetVotingInstanceForId(Convert.ToInt32(item.SubItems[1].Text));

            if (chosenModel != null)
            {
                lblAddressText.Text = $"{chosenModel.Address.AddressLine1 ?? String.Empty} \n\r " +
                                        $"{chosenModel.Address.AddressLine2 ?? String.Empty} \n\r " +
                                        $"{chosenModel.Address.City ?? String.Empty} \n\r " +
                                        $"{chosenModel.Address.Country ?? String.Empty} \n\r " +
                                        $"{chosenModel.Address.Postcode ?? String.Empty}";
                lblDescriptionText.Text = chosenModel.VIDescription;
                lblElectionNameText.Text = chosenModel.VIName;

                lstPossibleVotingOptions.Clear();
                foreach (VotingOptionDBModel thisOption in chosenModel.VotingOptions)
                {
                    lstPossibleVotingOptions.Items.Add(thisOption.VOName);
                }
            }

            btnUpdateInstance.Enabled = true;
            btnDeleteSelected.Enabled = true;
        }

        /// <summary>
        /// User wants to update the selected voting instance from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateInstance_Click(object sender, EventArgs e)
        {
            ListViewItem item = lstVotingInstances.FocusedItem;

            VotingInstanceViewModel currentDetails = _ThisMainGui._ThisVotingManager.GetVotingInstanceForId(Convert.ToInt32(item.SubItems[1].Text));

            _ThisMainGui.SwitchScreenType(ScreenTypes.VotingSetupForm);
            _ThisMainGui.VotingSetupForm.SetupForUpdatingVotingInstance(currentDetails);
        }

        /// <summary>
        /// Refresh the grid to show all or part of the user list
        /// </summary>
        private void tbtnShowDeactivatedUsers_CheckedChanged(object sender, EventArgs e)
        {
            SetupVotingInstnaceLists();
        }
        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            lblPossibleElections.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblPossibleElections");
            lblElectionDetails.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblElectionDetails");
            lblElectionName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblElectionName");
            lblDescription.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblDescription");
            lblAddress.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddress");
            btnAddNew.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnAddNew");
            btnUpdateInstance.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnUpdateInstance");
            btnDeleteSelected.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnDeleteSelected");
        }
        #endregion
    }
}
