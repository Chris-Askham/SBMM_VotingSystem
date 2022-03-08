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
    public partial class ucMainUserForm : UserControl
    {
        #region Constants
        private const string _c_LoggedInAsText = "Logged in as: ";
        #endregion

        private frmMainGui _ThisMainGui;

        #region Constructor
        public ucMainUserForm(frmMainGui mainForm)
        {
            _ThisMainGui = mainForm;

            InitializeComponent();
            lblWelcomeText.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void ucMainUserForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            ChangeLanguageForControls();
        }
        #endregion

        #region User event handlers        
        /// <summary>
        /// User has requested to login
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.UserLoginForm);
        }
        /// <summary>
        /// User has requested to register as a new user
        /// </summary>
        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.RegisterNewUser);
        }
        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            lblWelcomeText.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblWelcomeText");
            btnLogin.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnLogin");
            btnRegisterNewUser.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnRegisterNewUser");
        }
        #endregion
    }
}
