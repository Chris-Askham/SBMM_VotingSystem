using SBMMVotingSystem.DAL;
using SBMMVotingSystem.Forms.SubForms;
using SBMMVotingSystem.Managers;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static SBMMVotingSystem.Managers.UserManager;

namespace SBMMVotingSystem.Forms
{
    public partial class frmMainGui : Form
    {
        #region Public enums
        /// <summary>
        /// List of all the diffrent screen types
        /// </summary>
        public enum ScreenTypes
        {
            RegistrationForm,
            MainUserForm,
            UserLoginForm,
            UserNavForm,
            RegisterNewUser,
            UsersManagementForm,
            VotingSetupForm,
            VotingManagementForm,
            VotingForm,
            VotingSummary
        }
        #endregion

        #region Declerations

        #region Form declerations
        internal ucMainUserForm MainUserForm { get; set; }
        internal ucUserLoginForm UserLoginForm { get; set; }
        internal ucUserNavForm UserNavForm { get; set; }
        internal ucRegisterNewUser RegisterNewUser { get; set; }
        internal ucUsersManagementForm UsersManagementForm { get; set; }
        internal ucVotingSetupForm VotingSetupForm { get; set; }
        internal ucVotingManagementForm VotingManagementForm { get; set; }
        internal ucVotingForm VotingForm { get; set; }
        internal ucVotingSummary VotingSummary { get; set; }
        #endregion

        #region Manager declerations
        public UserManager _ThisUserManager { get; set; }
        public VotingManager _ThisVotingManager { get; set; }
        public ISQLAccessLayer _ThisSQLAccessLayer { get; set; }
        public UserAuditManager _ThisUserAuditManager { get; set; }
        #endregion

        /// <summary>
        /// Identifies which user control is currently being displayed
        /// </summary>
        private ScreenTypes currentScreenType { get; set; }

        #endregion

        #region Constructor
        public frmMainGui()
        {
            InitializeComponent();

            _ThisSQLAccessLayer = new SQLAccessLayer();
            _ThisUserManager = new UserManager(_ThisSQLAccessLayer);
            _ThisVotingManager = new VotingManager(_ThisSQLAccessLayer);
            _ThisUserAuditManager = new UserAuditManager(_ThisSQLAccessLayer);

            MainUserForm = new ucMainUserForm(this);
            UserLoginForm = new ucUserLoginForm(this);
            UserNavForm = new ucUserNavForm(this);
            RegisterNewUser = new ucRegisterNewUser(this);
            UsersManagementForm = new ucUsersManagementForm(this);
            VotingSetupForm = new ucVotingSetupForm(this);
            VotingManagementForm = new ucVotingManagementForm(this);
            VotingForm = new ucVotingForm(this);
            VotingSummary = new ucVotingSummary(this);

            PopulateLoginName(null);
            ResizeContenxtSection(MainUserForm);
            SwitchScreenType(ScreenTypes.MainUserForm);
            ChangeCurrentCulture();
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Public methods to switch the form content
        /// </summary>
        /// <param name="newScreen">Screen to display</param>
        internal void SwitchScreenType(ScreenTypes newScreen)
        {
            // Remove all forms
            // ----------------
            if (MainUserForm != null) { pnlBody.Controls.Remove(MainUserForm); }
            if (UserLoginForm != null) { pnlBody.Controls.Remove(UserLoginForm); }
            if (UserNavForm != null) { pnlBody.Controls.Remove(UserNavForm); }
            if (RegisterNewUser != null) { pnlBody.Controls.Remove(RegisterNewUser); }
            if (UsersManagementForm != null) { pnlBody.Controls.Remove(UsersManagementForm); }
            if (VotingSetupForm != null) { pnlBody.Controls.Remove(VotingSetupForm); }
            if (VotingManagementForm != null) { pnlBody.Controls.Remove(VotingManagementForm); }
            if (VotingForm != null) { pnlBody.Controls.Remove(VotingForm); }
            if (VotingSummary != null) { pnlBody.Controls.Remove(VotingSummary); }

            // Add the new form to the screen
            // ------------------------------
            switch (newScreen)
            {
                case ScreenTypes.MainUserForm:
                    this.pnlBody.Controls.Add(MainUserForm);
                    currentScreenType = ScreenTypes.MainUserForm;
                    break;
                case ScreenTypes.UserLoginForm:
                    this.pnlBody.Controls.Add(UserLoginForm);
                    UserLoginForm.ClearControls();
                    currentScreenType = ScreenTypes.UserLoginForm;
                    break;
                case ScreenTypes.UserNavForm:
                    this.pnlBody.Controls.Add(UserNavForm);
                    UserNavForm.SetupNavForm();
                    currentScreenType = ScreenTypes.UserNavForm;
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_Dashboard");
                    break;
                case ScreenTypes.RegisterNewUser:
                    this.pnlBody.Controls.Add(RegisterNewUser);
                    currentScreenType = ScreenTypes.RegisterNewUser;
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_NewUser");
                    break;
                case ScreenTypes.UsersManagementForm:
                    this.pnlBody.Controls.Add(UsersManagementForm);
                    UsersManagementForm.SetupNavForm();
                    currentScreenType = ScreenTypes.UsersManagementForm;
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_UserManagement");
                    break;
                case ScreenTypes.VotingSetupForm:
                    this.pnlBody.Controls.Add(VotingSetupForm);
                    currentScreenType = ScreenTypes.VotingSetupForm;
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_NewElections");
                    break;
                case ScreenTypes.VotingManagementForm:
                    this.pnlBody.Controls.Add(VotingManagementForm);
                    VotingManagementForm.SetupVotingInstnaceLists();
                    currentScreenType = ScreenTypes.VotingManagementForm;
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_VotingManagement");
                    break;
                case ScreenTypes.VotingForm:
                    this.pnlBody.Controls.Add(VotingForm);
                    VotingForm.SetupVotingForm();
                    currentScreenType = ScreenTypes.VotingForm;
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_Elections");
                    break;
                case ScreenTypes.VotingSummary:
                    this.pnlBody.Controls.Add(VotingSummary);
                    VotingSummary.SetupVotingSummaryPage();
                    currentScreenType = ScreenTypes.VotingSummary;
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_Summary");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// When the user has been authenticated populate the logged in text
        /// </summary>
        /// <param name="username"></param>
        internal void PopulateLoginName(string username)
        {
            if (username != null)
            {
                lblLoggedInAs.Visible = true;
                lblLoggedInAs.Text = _ThisUserManager.GetLocalisedString("lblLoggedInAs") + username;
                btnHome.Visible = true;
            }
            else
            {
                lblLoggedInAs.Visible = false;
                btnHome.Visible = false;
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Resizes the user control based on the size of the panel
        /// </summary>
        /// <param name="contextType">The current user control being displayed</param>
        private void ResizeContenxtSection(UserControl contextType)
        {
            // Realign the content window
            // --------------------------
            if (this.WindowState == FormWindowState.Maximized)
            {
                contextType.Location = new Point(
                        pnlBody.Width / 2 - contextType.Size.Width / 2,
                        pnlBody.Height / 2 - contextType.Size.Height / 2);
            }
            else
            {
                contextType.Location = new Point(0, 0);
            }

            // Change the size of the context window
            // -------------------------------------    
            contextType.Anchor = AnchorStyles.None;
            contextType.Width = pnlBody.Width;
            contextType.Height = pnlBody.Height;
        }

        /// <summary>
        /// User wants to return to the main navigation form
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (_ThisUserManager.IsLoggedIn()) { SwitchScreenType(ScreenTypes.UserNavForm); }
            else { SwitchScreenType(ScreenTypes.UserLoginForm); }
        }

        /// <summary>
        /// User requested to go log out of the system
        /// Return the user to the admin login screen
        /// </summary>
        private void lblLoggedInAs_Click(object sender, EventArgs e)
        {
            SwitchScreenType(ScreenTypes.UserLoginForm);
            _ThisUserManager.Logout();

            PopulateLoginName(null);
        }

        /// <summary>
        /// Simulates a hover affect for this button
        /// </summary>
        private void btnENFlag_MouseEnter(object sender, EventArgs e)
        {
            btnENFlag.BackgroundImage = Properties.Resources.en_flag_down;
        }
        private void btnENFlag_MouseLeave(object sender, EventArgs e)
        {
            btnENFlag.BackgroundImage = Properties.Resources.en_flag_out;
        }

        /// <summary>
        /// Simulates a hover affect for this button
        /// </summary>
        private void btnFRFlag_MouseEnter(object sender, EventArgs e)
        {
            btnFRFlag.BackgroundImage = Properties.Resources.fr_flag_down;
        }
        private void btnFRFlag_MouseLeave(object sender, EventArgs e)
        {
            btnFRFlag.BackgroundImage = Properties.Resources.fr_flag_out;
        }

        /// <summary>
        /// Simulates a hover affect for this button
        /// </summary>
        private void btnESFlag_MouseEnter(object sender, EventArgs e)
        {
            btnESFlag.BackgroundImage = Properties.Resources.es_flag_down;
        }
        private void btnESFlag_MouseLeave(object sender, EventArgs e)
        {
            btnESFlag.BackgroundImage = Properties.Resources.es_flag_out;
        }

        /// <summary>
        /// Change language to English (EN)
        /// </summary>
        private void btnENFlag_Click(object sender, EventArgs e)
        {
            _ThisUserManager.CurrentCultureCode = LanguageOptions.EN;
            ChangeCurrentCulture();
        }

        /// <summary>
        /// Change language to French (FR)
        /// </summary>
        private void btnFRFlag_Click(object sender, EventArgs e)
        {
            _ThisUserManager.CurrentCultureCode = LanguageOptions.FR;
            ChangeCurrentCulture();
        }

        /// <summary>
        /// Change language to Spanish (ES)
        /// </summary>
        private void btnESFlag_Click(object sender, EventArgs e)
        {
            _ThisUserManager.CurrentCultureCode = LanguageOptions.ES;
            ChangeCurrentCulture();
        }

        private void ChangeCurrentCulture()
        {
            // Change language for main form 
            // -----------------------------
            lblLoggedInAs.Text = _ThisUserManager.GetLocalisedString("lblLoggedInAs") + _ThisUserManager.CurrentUsername;
            btnHome.Text = _ThisUserManager.GetLocalisedString("btnHome");

            // Identify current user control and change lauguage for that
            // ----------------------------------------------------------
            switch (currentScreenType)
            {
                case ScreenTypes.MainUserForm:
                    MainUserForm.ChangeLanguageForControls();
                    lblHeaderLabel.Text = String.Empty;
                    break;
                case ScreenTypes.UserLoginForm:
                    UserLoginForm.ChangeLanguageForControls();
                    lblHeaderLabel.Text = String.Empty;
                    break;
                case ScreenTypes.UserNavForm:
                    UserNavForm.ChangeLanguageForControls();
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_Dashboard");
                    break;
                case ScreenTypes.RegisterNewUser:
                    RegisterNewUser.ChangeLanguageForControls();
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_NewUser");
                    break;
                case ScreenTypes.UsersManagementForm:
                    UsersManagementForm.ChangeLanguageForControls();
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_UserManagement");
                    break;
                case ScreenTypes.VotingSetupForm:
                    VotingSetupForm.ChangeLanguageForControls();
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_NewElections");
                    break;
                case ScreenTypes.VotingManagementForm:
                    VotingManagementForm.ChangeLanguageForControls();
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_VotingManagement");
                    break;
                case ScreenTypes.VotingForm:
                    VotingForm.ChangeLanguageForControls();
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_Elections");
                    break;
                case ScreenTypes.VotingSummary:
                    VotingSummary.ChangeLanguageForControls();
                    lblHeaderLabel.Text = _ThisUserManager.GetLocalisedString("HeaderLabel_Summary");
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Window Setup Attributes and methods

        #region Attributes
        private int borderSize = 2;
        private Size formSize;
        private Color borderColour = Color.SlateBlue;

        private int defaultFormHeight = 600;
        private int defaultFormWidth = 850;
        #endregion

        #region Events

        #region Drag and Drop
        /// <summary>
        /// External methods
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        /// <summary>
        /// User event, user mouse up over the header bar
        /// </summary>
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Windows toolbar buttons
        /// <summary>
        /// User event, user wants to close the application
        /// </summary>
        private void btnCloseGUI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// User event, user wants to maximise the application 
        /// </summary>
        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) { this.WindowState = FormWindowState.Normal; }
            else { this.WindowState = FormWindowState.Maximized; }
        }

        /// <summary>
        /// User event, user wants to Minimize the application 
        /// </summary>
        private void btnMinimise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) { this.WindowState = FormWindowState.Normal; }
            else { this.WindowState = FormWindowState.Minimized; }
        }
        #endregion

        #region Form resise
        /// <summary>
        /// Windows method for form resizing
        /// </summary>
        private void frmMainGui_Resize(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    if (Padding.Top != borderSize) { Padding = new Padding(borderSize); }
                    break;
                case FormWindowState.Minimized:
                    break;
                case FormWindowState.Maximized:
                    Padding = new Padding(0, 8, 8, 0);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Windows method for form resizing and snapping to a location
        /// Code was generated based on https://rjcodeadvance.com/final-modern-ui-aero-snap-window-resizing-sliding-menu-c-winforms/
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                {
                    if (formSize == new Size(0, 0))
                    {
                        formSize = new Size(defaultFormWidth, defaultFormHeight);
                    }
                    this.Size = formSize;
                }
            }
            base.WndProc(ref m);
        }


        #endregion

        #endregion

        #endregion
    }
}
