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
    public partial class ucUserNavForm : UserControl
    {
        #region Constructor
        private frmMainGui _ThisMainGui;
        public ucUserNavForm(frmMainGui mainForm)
        {
            _ThisMainGui = mainForm;

            InitializeComponent();
        }

        private void ucAdminNavPage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetupNavForm();
            ChangeLanguageForControls();
        }
        #endregion

        #region User Event methods
        /// <summary>
        /// User requested to setup a new user on the system
        /// Send user to Admin new user screen
        /// </summary>
        private void btnUsers_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.UsersManagementForm);
        }

        /// <summary>
        /// User has requested to begin a new Vote
        /// </summary>
        private void btnNewVote_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.VotingForm);
        }

        /// <summary>
        /// User wants to view any voting instances
        /// </summary>
        private void btnVotingInstances_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.VotingManagementForm);
        }

        /// <summary>
        /// User wants to view data for a specific voting instance
        /// </summary>
        private void btnGetVotes_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.VotingSummary);
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Setup the form for the current user
        /// </summary>
        internal void SetupNavForm()
        {
            // If the current user is in a Administrator role then hide 
            // the user and voting instance buttons
            // --------------------------------------------------------
            if (_ThisMainGui._ThisUserManager.IsInAdminRole())
            {
                btnUsers.Visible = true;
                btnVotingInstances.Visible = true;
                btnGetVotes.Visible = false;
            }
            else if (_ThisMainGui._ThisUserManager.IsInAuditorRole())
            {
                btnUsers.Visible = false;
                btnVotingInstances.Visible = false;
                btnGetVotes.Visible = true;
            }
            else
            {
                btnUsers.Visible = false;
                btnVotingInstances.Visible = false;
                btnGetVotes.Visible = false;
            }

            bool userHasVotedOnAll = _ThisMainGui._ThisUserAuditManager.HasUserAlreadyVoted(_ThisMainGui._ThisUserManager.CurrentUsernameId,
                                                                                            _ThisMainGui._ThisVotingManager._allVotingInstances);

            // IF the election has not been set for this app disable the voting button
            // ELSE IF the user has voted on all elections then disable the button
            // ELSE enable the button
            // -----------------------------------------------------------------------
            if (_ThisMainGui._ThisVotingManager._allVotingInstances.Where(e => e.CurrentlyInUse == 1).Count() == 0) { btnNewVote.Enabled = false; }
            else if (userHasVotedOnAll) { btnNewVote.Enabled = false; }
            else { btnNewVote.Enabled = true; }

        }
        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            btnGetVotes.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnGetVotes");
            btnNewVote.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnNewVote");
            btnUsers.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnUsers");
            btnVotingInstances.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnVotingInstances");
        }
        #endregion
    }
}
