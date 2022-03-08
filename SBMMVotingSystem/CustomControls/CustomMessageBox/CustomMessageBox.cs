using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMMVotingSystem.CustomControls.CustomMessageBox
{
    public partial class CustomMessageBox : Form
    {
        #region Attributes
        private Color primaryColor = Color.SlateBlue;
        private int borderSize = 2;

        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;
                this.panelTitleBar.BackColor = PrimaryColor;
            }
        }
        #endregion

        #region Constructor
        public CustomMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.primaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
        }
        public CustomMessageBox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.primaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
        }
        public CustomMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.primaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);
        }
        public CustomMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.primaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);
            SetIcon(icon);
        }
        public CustomMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.primaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }
        #endregion

        #region Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Set border size 
            this.lblMessage.MaximumSize = new Size(550, 0);
            this.btnTopRightClose.DialogResult = DialogResult.Cancel;
            this.roundedButton1.DialogResult = DialogResult.OK;
            this.roundedButton1.Visible = false;
            this.roundedButton2.Visible = false;
            this.roundedButton3.Visible = false;
        }
        private void SetFormSize()
        {
            int width = this.lblMessage.Width + this.pictureBoxIcon.Width + this.panelBody.Padding.Left;
            int height = this.panelTitleBar.Height + this.lblMessage.Height + this.panelButtons.Height + this.panelBody.Padding.Top;
            this.Size = new Size(width, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.panelButtons.Width - roundedButton1.Width) / 2;
            int yCenter = (this.panelButtons.Height - roundedButton1.Height) / 2;
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    roundedButton1.Visible = true;
                    roundedButton1.Location = new Point(xCenter, yCenter);
                    roundedButton1.Text = "Okay";
                    roundedButton1.DialogResult = DialogResult.OK;//SetDialogResult
                                                                  //Set DefaultButton
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    roundedButton1.Visible = true;
                    roundedButton1.Location = new Point(xCenter - (roundedButton1.Width / 2) - 5, yCenter);
                    roundedButton1.Text = "Okay";
                    roundedButton1.DialogResult = DialogResult.OK;//SetDialogResult
                                                                  //CancelButton
                    roundedButton2.Visible = true;
                    roundedButton2.Location = new Point(xCenter + (roundedButton2.Width / 2) + 5, yCenter);
                    roundedButton2.Text = "Cancel";
                    roundedButton2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    roundedButton2.BackColor = Color.DimGray;
                    //Set DefaultButton
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be roundedButton3 
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    roundedButton1.Visible = true;
                    roundedButton1.Location = new Point(xCenter - (roundedButton1.Width / 2) - 5, yCenter);
                    roundedButton1.Text = "Retry";
                    roundedButton1.DialogResult = DialogResult.Retry;//Set DialogResult
                                                                     //CancelButton
                    roundedButton2.Visible = true;
                    roundedButton2.Location = new Point(xCenter + (roundedButton2.Width / 2) + 5, yCenter);
                    roundedButton2.Text = "Cancel";
                    roundedButton2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    roundedButton2.BackColor = Color.DimGray;
                    //Set DefaultButton
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be roundedButton3 
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNo:
                    //YesButton
                    roundedButton1.Visible = true;
                    roundedButton1.Location = new Point(xCenter - (roundedButton1.Width / 2) - 5, yCenter);
                    roundedButton1.Text = "Yes";
                    roundedButton1.DialogResult = DialogResult.Yes;//Set DialogResult
                                                                   //No Button
                    roundedButton2.Visible = true;
                    roundedButton2.Location = new Point(xCenter + (roundedButton2.Width / 2) + 5, yCenter);
                    roundedButton2.Text = "No";
                    roundedButton2.DialogResult = DialogResult.No;//SetDialogResult
                    roundedButton2.BackColor = Color.IndianRed;
                    //Set DefaultButton
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be roundedButton3 
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //YesButton
                    roundedButton1.Visible = true;
                    roundedButton1.Location = new Point(xCenter - roundedButton1.Width - 5, yCenter);
                    roundedButton1.Text = "Yes";
                    roundedButton1.DialogResult = DialogResult.Yes;//Set DialogResult
                                                                   //No Button
                    roundedButton2.Visible = true;
                    roundedButton2.Location = new Point(xCenter, yCenter);
                    roundedButton2.Text = "No";
                    roundedButton2.DialogResult = DialogResult.No;//SetDialogResult
                    roundedButton2.BackColor = Color.IndianRed;
                    //CancelButton
                    roundedButton3.Visible = true;
                    roundedButton3.Location = new Point(xCenter + roundedButton2.Width + 5, yCenter);
                    roundedButton3.Text = "Cancel";
                    roundedButton3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    roundedButton3.BackColor = Color.DimGray;
                    //Set DefaultButton
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    roundedButton1.Visible = true;
                    roundedButton1.Location = new Point(xCenter - roundedButton1.Width - 5, yCenter);
                    roundedButton1.Text = "Abort";
                    roundedButton1.DialogResult = DialogResult.Abort;//Set DialogResult
                    roundedButton1.BackColor = Color.Goldenrod;
                    //Retry Button
                    roundedButton2.Visible = true;
                    roundedButton2.Location = new Point(xCenter, yCenter);
                    roundedButton2.Text = "Retry";
                    roundedButton2.DialogResult = DialogResult.Retry;//Set DialogResult                    
                                                                     //Ignore Button
                    roundedButton3.Visible = true;
                    roundedButton3.Location = new Point(xCenter + roundedButton2.Width + 5, yCenter);
                    roundedButton3.Text = "Ignore";
                    roundedButton3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    roundedButton3.BackColor = Color.IndianRed;
                    //Set DefaultButton
                    SetDefaultButton(defaultButton);
                    break;
            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    roundedButton1.Select();
                    roundedButton1.ForeColor = Color.White;
                    roundedButton1.Font = new Font(roundedButton1.Font, FontStyle.Regular);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    roundedButton2.Select();
                    roundedButton2.ForeColor = Color.White;
                    roundedButton2.Font = new Font(roundedButton2.Font, FontStyle.Regular);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    roundedButton3.Select();
                    roundedButton3.ForeColor = Color.White;
                    roundedButton3.Font = new Font(roundedButton3.Font, FontStyle.Regular);
                    break;
            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.error;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    this.btnTopRightClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pictureBoxIcon.Image = Properties.Resources.information;
                    PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.pictureBoxIcon.Image = Properties.Resources.question;
                    PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.pictureBoxIcon.Image = Properties.Resources.exclamation;
                    PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
                case MessageBoxIcon.None: //None
                    this.pictureBoxIcon.Image = Properties.Resources.chat;
                    PrimaryColor = Color.DodgerBlue;
                    break;
            }
        }
        #endregion

        #region Events
        private void btnTopRightClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
