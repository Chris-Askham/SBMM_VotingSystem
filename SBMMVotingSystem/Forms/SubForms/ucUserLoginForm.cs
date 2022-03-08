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
    public partial class ucUserLoginForm : UserControl
    {
        #region Private constants
        private const string _c_LoginErrorMsg = "Login failed please try again";
        private const string _c_RegistrationMsg = "*Not already a user? Please speak to your system admin team.";


        private readonly Color _c_ErrorMsg = Color.DarkRed;
        private readonly Color _c_InfoMsg = Color.SlateBlue;
        #endregion

        #region Constructor
        private frmMainGui _ThisMainGui;
        public ucUserLoginForm(frmMainGui mainForm)
        {
            _ThisMainGui = mainForm;

            InitializeComponent();
        }

        /// <summary>
        /// On form loading set a few default properties
        /// </summary>
        private void ucAdminLogin_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            ClearControls();
            ChangeLanguageForControls();
        }

        #endregion

        #region Internal Methods
        internal void ClearControls()
        {
            // Setup user message
            // ------------------
            lblUserNotificationText.Text = _c_RegistrationMsg;
            lblUserNotificationText.ForeColor = _c_InfoMsg;

            // clear login details
            // -------------------
            txtPassword.Texts = String.Empty;
            txtUsername.Texts = String.Empty;
        }
        #endregion

        #region User Event Handlers
        /// <summary>
        /// User requested to login as a super user
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_ThisMainGui._ThisUserManager.ValidateThisLoginRequest(txtUsername.Texts, txtPassword.Texts))
            {
                // User logged in, show admin nav screen
                // -------------------------------------
                _ThisMainGui.SwitchScreenType(ScreenTypes.UserNavForm);
                _ThisMainGui.PopulateLoginName(txtUsername.Texts);
            }
            else
            {
                // Show login error msg
                // --------------------
                lblUserNotificationText.Text = _c_LoginErrorMsg;
                lblUserNotificationText.ForeColor = _c_ErrorMsg;
            }
        }

        /// <summary>
        /// User requested to go cancel the login process
        /// Return the user to the main screen
        /// </summary>
        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.MainUserForm);
        }

        /// <summary>
        /// Event to capture user pressing enter key
        /// </summary>
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) { btnLogin_Click(sender, e); }
        }

        /// <summary>
        /// Event to capture user pressing enter key
        /// </summary>
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) { btnLogin_Click(sender, e); }
        }

        /// <summary>
        /// User is not a registered voter so send them to the registration form
        /// </summary>
        private void lblUserNotificationText_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.RegistrationForm);
        }
        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            lblAdminHeaderText.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAdminHeaderText");
            lblUsername.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblUsername");
            lblPassword.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblPassword");
            lblUserNotificationText.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblUserNotificationText");
            btnLogin.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnLogin");
            btnCancelLogin.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnCancelLogin");
        }
        #endregion

    }
}
