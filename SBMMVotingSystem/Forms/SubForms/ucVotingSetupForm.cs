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
using static SBMMVotingSystem.Managers.VotingManager;
using static System.Windows.Forms.ListView;

namespace SBMMVotingSystem.Forms.SubForms
{
    public partial class ucVotingSetupForm : UserControl
    {
        #region Attributes
        internal frmMainGui _ThisMainGui { get; set; }
        #endregion

        #region Constructor
        public ucVotingSetupForm(frmMainGui thisMainGui)
        {
            _ThisMainGui = thisMainGui;
            InitializeComponent();
            ChangeLanguageForControls();
        }

        /// <summary>
        /// Setup some defaults when the form is loaded
        /// </summary>
        private void ucVotingSetupForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            SetupForNewVotingInstance();
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Clear all text boxes and list views ready for another voting instance
        /// </summary>
        internal void SetupForNewVotingInstance()
        {
            txtElectionName.Texts = String.Empty;
            txtDescription.Texts = String.Empty;
            txtAddress1.Texts = String.Empty;
            txtAddress2.Texts = String.Empty;
            txtAddress3.Texts = String.Empty;
            txtCountry.Texts = String.Empty;
            txtPostcode.Texts = String.Empty;
            txtOptionName.Texts = String.Empty;
            txtOptionDescription.Texts = String.Empty;
            lstVotingOptions.Items.Clear();
            numVotingInstanceId.Value = 0;
            tbtnEnabled.Checked = true;
            cboElectionTypeDDList.Items.Clear();

            foreach (VotingMode VIVotinMode in (VotingMode[])Enum.GetValues(typeof(VotingMode)))
            {
                cboElectionTypeDDList.Items.Add(VIVotinMode.ToString());
            }
        }

        /// <summary>
        /// Clear all text boxes and list views ready for another voting instance
        /// </summary>
        internal void SetupForUpdatingVotingInstance(VotingInstanceViewModel votingInstance)
        {
            txtElectionName.Texts = votingInstance.VIName;
            txtDescription.Texts = votingInstance.VIDescription;
            txtAddress1.Texts = votingInstance.Address.AddressLine1;
            txtAddress2.Texts = votingInstance.Address.AddressLine2;
            txtAddress3.Texts = votingInstance.Address.City;
            txtCountry.Texts = votingInstance.Address.Country;
            txtPostcode.Texts = votingInstance.Address.Postcode;
            txtOptionName.Texts = String.Empty;
            txtOptionDescription.Texts = String.Empty;
            numVotingInstanceId.Value = votingInstance.VotingInstanceId;
            lstVotingOptions.Items.Clear();
            tbtnEnabled.Checked = votingInstance.CurrentlyInUse == 1 ? true : false;

            foreach (VotingOptionDBModel thisOption in votingInstance.VotingOptions)
            {
                string[] votingoption = { thisOption.VOName, thisOption.VODescription };
                lstVotingOptions.Items.Add(new ListViewItem(votingoption));
            }

            cboElectionTypeDDList.Items.Clear();

            foreach (VotingMode VIVotinMode in (VotingMode[])Enum.GetValues(typeof(VotingMode)))
            {
                cboElectionTypeDDList.Items.Add(VIVotinMode.ToString());
            }            
            cboElectionTypeDDList.SelectedItem = votingInstance.VIVotingMode.ToString();

            if(votingInstance.CurrentlyInUse == 1) { btnEndElection.Enabled = true; }
            else { btnEndElection.Enabled = false; }   
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Shows a popup to make sure user wants to end the election
        /// </summary>
        private void btnEndElection_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(_ThisMainGui._ThisUserManager.GetLocalisedString("lblEndElectionMessage1") + "\n\r" + _ThisMainGui._ThisUserManager.GetLocalisedString("lblEndElectionMessage2"),
                                                        _ThisMainGui._ThisUserManager.GetLocalisedString("lblEndElectionTitle"),
                                                        MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // End the election 
                // ----------------
                _ThisMainGui._ThisVotingManager.EndVotingInstance(Convert.ToInt32(numVotingInstanceId.Value), _ThisMainGui._ThisUserManager.CurrentUsernameId);
                _ThisMainGui.SwitchScreenType(ScreenTypes.VotingManagementForm);
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing, return to setup screen
                // ----------------------------------
            }
        }

        /// <summary>
        /// Submit the new voting instance to the database
        /// </summary>
        private void btnSubmitVotingInstance_Click(object sender, EventArgs e)
        {
            // Build up the view model for instance, address and voting options
            // ----------------------------------------------------------------
            VotingInstanceViewModel viewModel = new VotingInstanceViewModel()
            {
                VotingInstanceId = Convert.ToInt32(numVotingInstanceId.Value),
                VIName = txtElectionName.Texts,
                VIDescription = txtDescription.Texts,
                Address = new AddressDBModel()
                {
                    AddressLine1 = txtAddress1.Texts,
                    AddressLine2 = txtAddress2.Texts,
                    City = txtAddress3.Texts,
                    Country = txtCountry.Texts,
                    Postcode = txtPostcode.Texts,
                },
                CurrentlyInUse = tbtnEnabled.Checked == true ? 1 : 0,
                VotingOptions = new List<VotingOptionDBModel>(),
                VIVotingMode = (VotingMode)Enum.Parse(typeof(VotingMode), cboElectionTypeDDList.SelectedItem.ToString(), true),
            };

            foreach (ListViewItem thisOption in lstVotingOptions.Items)
            {
                viewModel.VotingOptions.Add(new VotingOptionDBModel() { VOName = thisOption.SubItems[0].Text, VODescription = thisOption.SubItems[1].Text });
            }

            // Pass to the managers, to insert into the database
            // -------------------------------------------------
            if (viewModel.VotingInstanceId != 0)
            {
                _ThisMainGui._ThisVotingManager.UpdateNewVotingInstance(viewModel, _ThisMainGui._ThisUserManager.CurrentUsernameId);
            }
            else
            {
                _ThisMainGui._ThisVotingManager.SubmitNewVotingInstance(viewModel, _ThisMainGui._ThisUserManager.CurrentUsernameId);
            }

            _ThisMainGui.SwitchScreenType(ScreenTypes.VotingManagementForm);
        }

        /// <summary>
        /// User wants to add some voting options to this voting instance 
        /// </summary>
        private void btnAddOption_Click(object sender, EventArgs e)
        {
            if (txtOptionName.Texts.Length > 0)
            {
                string[] votingoption = { txtOptionName.Texts, txtOptionDescription.Texts };
                lstVotingOptions.Items.Add(new ListViewItem(votingoption));

                if (lstVotingOptions.Items.Count == 0) { btnClearOptions.Enabled = true; }

                if(lstVotingOptions.Items.Count == 6) 
                {
                    btnAddOption.Enabled = false; 
                    MessageBox.Show(_ThisMainGui._ThisUserManager.GetLocalisedString("lblInfoMessage_MaxOptionsAdded"), _ThisMainGui._ThisUserManager.GetLocalisedString("lblInfoMessage_InformationHeader")); 
                }
            }
        }

        /// <summary>
        /// User wants to remove a voting option from the list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            ListViewItem itemToRemove = lstVotingOptions.SelectedItems[0];

            // Remove the item from the list view control
            // ------------------------------------------
            lstVotingOptions.SelectedItems[0].Remove();

            // if there is no options to display disable the remove and clear buttons
            // ----------------------------------------------------------------------
            if (lstVotingOptions.Items.Count == 0) { btnRemoveSelected.Enabled = false; btnClearOptions.Enabled = false; }
        }

        /// <summary>
        /// User wants to go back to the Voting instance form
        /// </summary>
        private void btnCancelSetup_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.VotingManagementForm);
        }

        /// <summary>
        /// User has requested that all voting options be cleared
        /// </summary>
        private void btnClearOptions_Click(object sender, EventArgs e)
        {
            lstVotingOptions.Items.Clear();
        }

        /// <summary>
        /// User has selected a voting option. Enable the remove option button
        /// </summary>
        private void lstVotingOptions_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnRemoveSelected.Enabled = true;
        }
        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            lblElectionName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblElectionName");
            lblDecription.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblDecription");
            lblAddressHeader.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddressHeader");
            lblAddressLine1.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddressLine1");
            lblAddressLine2.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddressLine2");
            lblAddressLine3.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddressLine3");
            lblCountry.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblCountry");
            lblPostcode.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblPostcode");
            lblVotingOptions.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblVotingOptions");
            lblVotingOptionName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblVotingOptionName");
            lblVotingOptionDescription.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblVotingOptionDescription");
            btnAddOption.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnAddOption");
            btnRemoveSelected.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnRemoveSelected");
            btnClearOptions.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnClearOptions");
            btnSubmitVotingInstance.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnSubmitVotingInstance");
            btnCancelSetup.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnCancelSetup");
            lblEnabled.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblEnabled");
            btnEndElection.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnEndElection");
            lblElectionType.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblElectionType");
        }
        #endregion
    }
}
