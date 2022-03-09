using Dapper;
using SBMMVotingSystem.DAL;
using SBMMVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SBMMVotingSystem.Managers
{
    public class UserAuditManager
    {
        #region Internal enums
        internal enum UserAuditType
        {
            NewVote,
            AddVotingOption,
            DeleteVotingOption,
            UpdateVotingOption,
            AddVotingInstance,
            DeleteVotingInstance,
            UpdateVotingInstance,
            AddUser,
            UpdateUser,
        }
        #endregion

        #region Declerations
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }
        public ErrorManager _ThisErrorManager { get; set; }

        #endregion

        #region Constructor
        public UserAuditManager(ISQLAccessLayer thisDALManager)
        {
            _ThisSQLAccessLayer = thisDALManager;
            _ThisErrorManager = new ErrorManager(_ThisSQLAccessLayer);
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Log user audit message to the database
        /// </summary>
        /// <param name="auditToLog">Audit that needs logging to the db</param>
        internal void LogUserAudit(UserAuditDBModel auditToLog)
        {
            try
            {
                // Add the message to the database
                // -------------------------------
                string insertScript = "INSERT INTO [UserAuditLog] ([UserId], [LoggedDatetimeUTD], [Message], [VotingInstanceId], [AuditType]) " +
                                        "VALUES (@UserId, @LoggedDatetimeUTD, @Message, @VotingInstanceId, @AuditType)";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", auditToLog.UserId);
                parameters.Add("@LoggedDatetimeUTD", auditToLog.LoggedDatetimeUTC);
                parameters.Add("@Message", auditToLog.Message);
                parameters.Add("@VotingInstanceId", auditToLog.VotingInstanceId);
                parameters.Add("@AuditType", auditToLog.AuditType);

                // Execute the SQL query
                // ---------------------
                _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, insertScript, parameters);
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
        }

        /// <summary>
        /// Check the user audit logs to see if th euser has already
        /// voted for the specified election
        /// </summary>
        /// <returns>True if the user has already voted, else false</returns>
        internal bool HasUserAlreadyVoted(int userId, List<VotingInstanceViewModel> allElections)
        {
            bool userHasAlreadyVoted = true;

            try
            {
                string query = @"SELECT * FROM [UserAuditLog] WHERE [UserId] = @UserId AND [AuditType] = @AuditType";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", userId);
                parameters.Add("@AuditType", "NewVote");

                // Execute the SQL query
                // ---------------------
                List<UserAuditDBModel> loggedMessageList = _ThisSQLAccessLayer.GetUserAudits(null, query, parameters);

                if (loggedMessageList != null && loggedMessageList.Count > 0)
                {
                    foreach (VotingInstanceViewModel thisInstance in allElections)
                    {
                        // If the user has not voted in the election then set the flag to false
                        // --------------------------------------------------------------------
                        if (!loggedMessageList.Select(v => v.VotingInstanceId).Contains(thisInstance.VotingInstanceId))
                        {
                            userHasAlreadyVoted = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return userHasAlreadyVoted;
        }
        #endregion
    }
}
