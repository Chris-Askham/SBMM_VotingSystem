using Microsoft.Office.Interop.Excel;
using SBMMVotingSystem.Managers;
using SBMMVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static SBMMVotingSystem.Forms.frmMainGui;

namespace SBMMVotingSystem.Forms.SubForms
{
    public partial class ucVotingSummary : UserControl
    {
        #region Declerations
        private frmMainGui _ThisMainGui;
        public ErrorManager _ThisErrorManager { get; set; }
        public UserAuditManager _ThisUserAuditManager { get; set; }
        #endregion

        #region Constructor
        public ucVotingSummary(frmMainGui mainForm)
        {
            InitializeComponent();
            _ThisMainGui = mainForm;
            _ThisErrorManager = new ErrorManager(_ThisMainGui._ThisSQLAccessLayer);
            _ThisUserAuditManager = new UserAuditManager(_ThisMainGui._ThisSQLAccessLayer);
            SetupVotingSummaryPage();
        }

        private void ucVotingSummary_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            ChangeLanguageForControls();
        }
        #endregion

        #region User event handlers        
        /// <summary>
        /// User has requested to go back to the nav form
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            _ThisMainGui.SwitchScreenType(ScreenTypes.UserNavForm);
        }

        /// <summary>
        /// User has selected a option so popuplate all the fields 
        /// </summary>
        private void cboVotingInstanceDDList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedinstance = (string)cboVotingInstanceDDList.SelectedItem;

            if (selectedinstance != "")
            {
                btnExportSummary.Visible = true;
             
                // Get the data
                // ------------
                SummaryExportModel results = _ThisMainGui._ThisVotingManager.GetSummaryData(selectedinstance);

                // Create the chart
                // ----------------
                CreateChart(results);

                // Create the grid - Setup the columns
                // -----------------------------------
                CreateResultsGrid(results);

                // Load the detail fields 
                // ----------------------
                SetVotingInstanceDetails(results);

                if (results.VotingInstance.CurrentlyInUse == 0)
                {
                    lblWinner.Visible = true;
                    lblWinner.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblWinner") + results.WinnerName;
                }
            }
        }

        /// <summary>
        /// Show the vote by option chart
        /// </summary>
        private void radVotesByOption_CheckedChanged(object sender, EventArgs e)
        {
            grdVotesByArea.Visible = false;
            chtVotingInstanceSummary.Visible = true;
        }

        /// <summary>
        /// Show the votes by area grid
        /// </summary>
        private void radVotesByArea_CheckedChanged(object sender, EventArgs e)
        {
            grdVotesByArea.Visible = true;
            chtVotingInstanceSummary.Visible = false;
        }
        #endregion

        #region internal methods
        /// <summary>
        /// Initialise the form
        /// </summary>
        internal void SetupVotingSummaryPage()
        {
            chtVotingInstanceSummary.Visible = false;
            grdVotesByArea.Visible = false;
            lblWinner.Visible = false;
            btnExportSummary.Visible = false;

            LoadVotingInstanceDDListData();
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Load the voting instance options into the drop down list
        /// </summary>
        private void LoadVotingInstanceDDListData()
        {
            cboVotingInstanceDDList.Items.Clear();
            cboVotingInstanceDDList.SelectedItem = 0;
            lblElectionNameText.Text = string.Empty;
            lblDescriptionText.Text = string.Empty;
            lblAddressText.Text = string.Empty;
            lblTotalnumberOfVotesText.Text = string.Empty;

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
                    cboVotingInstanceDDList.Items.Add(viItem.Text);
                }
            }

            cboVotingInstanceDDList.Enabled = _ThisMainGui._ThisVotingManager._allVotingInstances.Count > 0;
        }

        /// <summary>
        /// Create the chart and populate the data 
        /// </summary>
        /// <param name="results">Results for this election</param>
        private void CreateChart(SummaryExportModel results)
        {
            chtVotingInstanceSummary.Titles.Clear();
            chtVotingInstanceSummary.Titles.Add("Votes for " + results.VotingInstance.VIName);

            if (results != null)
            {
                int voteCount = 0;

                // Add series
                // ----------
                chtVotingInstanceSummary.Series.Clear();
                for (int i = 0; i < results.ResultsForOption.Count; i++)
                {
                    System.Windows.Forms.DataVisualization.Charting.Series series = chtVotingInstanceSummary.Series.Add(results.ResultsForOption[i].VOName);
                    series.Points.Add(results.ResultsForOption[i].NumberOfVotesPerOption);
                    voteCount += results.ResultsForOption[i].NumberOfVotesPerOption;
                }
                chtVotingInstanceSummary.Visible = true;
                lblTotalnumberOfVotesText.Text = voteCount.ToString();
            }
        }

        /// <summary>
        /// Create the grid and populate the data 
        /// </summary>
        /// <param name="results">Results for this election</param>
        private void CreateResultsGrid(SummaryExportModel results)
        {
            grdVotesByArea.Rows.Clear();

            grdVotesByArea.Columns[0].Name = _ThisMainGui._ThisUserManager.GetLocalisedString("colHeader_City");
            grdVotesByArea.Columns[1].Name = _ThisMainGui._ThisUserManager.GetLocalisedString("colHeader_VOName");
            grdVotesByArea.Columns[2].Name = _ThisMainGui._ThisUserManager.GetLocalisedString("colHeader_NumberOfVotes");

            // Add the data rows
            // -----------------
            foreach (SummaryForAreaViewModel thisOption in results.ResultsForArea)
            {
                string[] row = { thisOption.City, thisOption.VOName, thisOption.NumberOfVotesPerCity.ToString() };
                grdVotesByArea.Rows.Add(row);
            }
        }

        /// <summary>
        /// Populate the election details 
        /// </summary>
        /// <param name="results">Results for this election</param>
        private void SetVotingInstanceDetails(SummaryExportModel results)
        {
            cboVotingInstanceDDList.SelectedItem = results.VotingInstance.VotingInstanceId;
            lblElectionNameText.Text = results.VotingInstance.VIName;
            lblDescriptionText.Text = results.VotingInstance.VIDescription;
            lblAddressText.Text = $"{results.VotingInstance.Address.AddressLine1 ?? String.Empty} \n\r " +
                                        $"{results.VotingInstance.Address.AddressLine2 ?? String.Empty} \n\r " +
                                        $"{results.VotingInstance.Address.City ?? String.Empty} \n\r " +
                                        $"{results.VotingInstance.Address.Country ?? String.Empty} \n\r " +
                                        $"{results.VotingInstance.Address.Postcode ?? String.Empty}";
            chtVotingInstanceSummary.Visible = true;
            radVotesByOption.Checked = true;
        }
        #endregion

        #region Export summary methods
        /// <summary>
        /// User event handler. User wants to export the chosen election details to a Excel workbook
        /// </summary>
        private void btnExportSummary_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedinstance = (string)cboVotingInstanceDDList.SelectedItem;

                if (selectedinstance != "")
                {
                    // Load chart data
                    // ---------------
                    SummaryExportModel results = _ThisMainGui._ThisVotingManager.GetSummaryData(selectedinstance);

                    if (results != null)
                    {
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm", FileName = "Election Summary.xlsx", ValidateNames = true })
                        {
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                                Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                                Worksheet ws = (Worksheet)app.ActiveSheet;
                                app.Visible = false;

                                // Write the election details to the workbook
                                // ------------------------------------------
                                ws.Cells[2, 2] = "Election Summary";
                                ws.Cells[4, 2] = "Election Details";
                                ws.Cells[5, 2] = "Name";
                                ws.Cells[5, 3] = results.VotingInstance.VIName;
                                ws.Cells[6, 2] = "Description";
                                ws.Cells[6, 3] = results.VotingInstance.VIDescription;
                                ws.Cells[7, 2] = "Address:";
                                ws.Cells[7, 3] = $"{results.VotingInstance.Address.AddressLine1}," +
                                                    $"{results.VotingInstance.Address.AddressLine2}," +
                                                    $"{results.VotingInstance.Address.City}," +
                                                    $"{results.VotingInstance.Address.Country}," +
                                                    $"{results.VotingInstance.Address.Postcode},";
                                ws.Cells[8, 2] = "Currently in use?";
                                ws.Cells[8, 3] = results.VotingInstance.CurrentlyInUse == 1 ? "Yes" : "No";
                                if(results.VotingInstance.CurrentlyInUse == 0)
                                {
                                    ws.Cells[9, 2] = "Winning candidate";
                                    ws.Cells[9, 3] = results.WinnerName;
                                }
                                ws.Cells[11, 2] = "Total votes by chosen option";
                                ws.Cells[15, 2] = "Total votes by city";

                                // Write the results by voted option to the workbook
                                // -------------------------------------------------
                                int columnNumber = 2;
                                foreach (SummaryChartViewModel thisOption in results.ResultsForOption)
                                {
                                    ws.Cells[12, columnNumber] = thisOption.VOName;
                                    ws.Cells[13, columnNumber] = thisOption.NumberOfVotesPerOption;
                                    columnNumber++;
                                }

                                // Write the results by city to the workbook
                                // -----------------------------------------
                                columnNumber = 2;
                                foreach (SummaryForAreaViewModel thisOption in results.ResultsForArea)
                                {
                                    ws.Cells[16, columnNumber] = thisOption.City;
                                    ws.Cells[17, columnNumber] = thisOption.NumberOfVotesPerCity;
                                    ws.Cells[18, columnNumber] = thisOption.VOName;
                                    columnNumber++;
                                }

                                wb.SaveAs(saveFileDialog.FileName,
                                            XlFileFormat.xlWorkbookDefault,
                                            Type.Missing,
                                            Type.Missing,
                                            true,
                                            false,
                                            XlSaveAsAccessMode.xlNoChange,
                                            XlSaveConflictResolution.xlLocalSessionChanges,
                                            Type.Missing,
                                            Type.Missing);
                                app.Quit();
                                MessageBox.Show(this, "Data saved in Excel format at location " + saveFileDialog.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
        }
        #endregion

        #region Language methods
        /// <summary>
        /// Changes the language for this user control
        /// </summary>
        internal void ChangeLanguageForControls()
        {
            lblAddress.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblAddress");
            lblDescription.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblDescription");
            lblElectionDetails.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblElectionDetails");
            lblElectionName.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblElectionName");
            lblTotalnumberOfVotes.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblTotalnumberOfVotes");
            lblSummaryMessage.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("lblSummaryMessage");
            btnReturn.Text = _ThisMainGui._ThisUserManager.GetLocalisedString("btnReturn");
            grdVotesByArea.Columns[0].Name = _ThisMainGui._ThisUserManager.GetLocalisedString("colHeader_City");
            grdVotesByArea.Columns[1].Name = _ThisMainGui._ThisUserManager.GetLocalisedString("colHeader_VOName");
            grdVotesByArea.Columns[2].Name = _ThisMainGui._ThisUserManager.GetLocalisedString("colHeader_NumberOfVotes");
        }
        #endregion
    }
}
