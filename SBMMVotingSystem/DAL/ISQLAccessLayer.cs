using Dapper;
using SBMMVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SBMMVotingSystem.Managers.UserManager;

namespace SBMMVotingSystem.DAL
{
    public interface ISQLAccessLayer
    {
        #region General methods
        /// <summary>
        /// Adds <T> to the database and returns the id
        /// </summary>
        /// <param name="sqlString">SQL String to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        int ExecuteScalar_CreateT(string connectionString, string sqlString, DynamicParameters parameters);

        /// <summary>
        /// Method that will execute the command and return nothing 
        /// Can be used for Update and delete statements
        /// </summary>
        /// <param name="sqlString">SQL String to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        void ExecuteSQL_ReturnNothing(string connectionString, string sqlString, DynamicParameters parameters);
        #endregion

        #region Voting methods

        #region Voting instances
        /// <summary>
        /// Get a list of voting instances
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        List<VotingInstanceViewModel> LoadVotingInstances(string connectionString, string sqlString, DynamicParameters parameters);
        #endregion

        #region Voting options
        /// <summary>
        /// Get a list of voting instances
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        List<VotingOptionDBModel> LoadVotingOptions(string connectionString, string sqlString, DynamicParameters parameters);
        #endregion

        #region Votes
        /// <summary>
        /// gets a count of votes
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        List<VoteDBModel> LoadVotes(string connectionString, string sqlString, DynamicParameters parameters);
        #endregion

        #endregion

        #region Address methods
        /// <summary>
        /// Gets the address for a id
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        AddressDBModel LoadAddress(string connectionString, string sqlString, DynamicParameters parameters);
        #endregion

        #region User methods
        /// <summary>
        /// Gets a list of users
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        List<SuperUserViewModel> LoadUsers(string connectionString, string sqlString, DynamicParameters parameters);

        /// <summary>
        /// Gets a localised string for a given keyword
        /// </summary>
        /// <param name="connectionString">Testing or real database</param>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <param name="cultureCode">Currently selected culture</param>
        /// <returns></returns>
        String GetLocalisedString(string connectionString, string sqlString,DynamicParameters parameters, LanguageOptions cultureCode);
        #endregion

        #region User audit methods
        /// <summary>
        /// Gets a user audit 
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        UserAuditDBModel GetUserAudits(string connectionString, string sqlString, DynamicParameters parameters);
        #endregion
    }
}
