using Dapper;
using SBMMVotingSystem.DAL;
using SBMMVotingSystem.Forms;
using SBMMVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMMVotingSystem.Managers
{
    /// <summary>
    /// Collection of Helper methods and atributes that handle
    /// the application error messages
    /// </summary>
    public class ErrorManager
    {
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }

        #region Constructor
        public ErrorManager(ISQLAccessLayer thisDALManager)
        {
            _ThisSQLAccessLayer = thisDALManager;
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Log message to error log table
        /// </summary>
        /// <param name="errorToLog">Error that needs logging to the db</param>
        internal void LogErrorMessage(ErrorLogDBModel errorToLog)
        {
            try
            {
                // Add the message to the database
                // -------------------------------
                string insertScript = "INSERT INTO [ErrorLog] ([ClassName], [MethodName], [LoggedDatetimeUTC], [Exception]) " +
                                        "VALUES (@ClassName, @MethodName, @LoggedDatetimeUTC, @Exception)";

                var parameters = new DynamicParameters();
                parameters.Add("@ClassName", errorToLog.ClassName);
                parameters.Add("@MethodName", errorToLog.MethodName);
                parameters.Add("@LoggedDatetimeUTC", errorToLog.LoggedDatetimeUTC);
                parameters.Add("@Exception", errorToLog.Exception);

                _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, insertScript, parameters);
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                ShowErrorMessage(error);
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        /// In the event the error log fails show message to user
        /// </summary>
        /// <param name="error"></param>
        private void ShowErrorMessage(ErrorLogDBModel error)
        {
            string text = $"A error occurred  at {error.LoggedDatetimeUTC}. It originated from {error.ClassName}.{error.MethodName} \n\r ex: {error.Exception}";
            string caption = "Error!";

            MessageBox.Show(text, caption);
        }
        #endregion
    }
}
