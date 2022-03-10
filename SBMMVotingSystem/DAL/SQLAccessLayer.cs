using Dapper;
using SBMMVotingSystem.Managers;
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
using static SBMMVotingSystem.Managers.UserManager;

namespace SBMMVotingSystem.DAL
{
    public class SQLAccessLayer : ISQLAccessLayer
    {
        #region Constants
        private const string _ConnectionString = @"Data Source=.\DAL\SBMMVotingDatabase.db;Version=3;";
        #endregion

        #region Declerations
        private ErrorManager _ThisErrorManager { get; set; }
        #endregion

        #region Constructor
        public SQLAccessLayer()
        {
            _ThisErrorManager = new ErrorManager(this);
        }
        #endregion

        #region General methods
        /// <summary>
        /// Adds <T> to the database and returns the id
        /// </summary>
        /// <param name="sqlString">SQL String to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        public int ExecuteScalar_CreateT(string connectionString, string sqlString, DynamicParameters parameters)
        {
            int rtnInt = 0;
            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    var results = db.ExecuteScalar(sqlString, parameters);
                    rtnInt = Convert.ToInt32(results);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
            return rtnInt;
        }

        /// <summary>
        /// Method that will execute the command and return nothing 
        /// Can be used for Update and delete statements
        /// </summary>
        /// <param name="sqlString">SQL String to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        public void ExecuteSQL_ReturnNothing(string connectionString, string sqlString, DynamicParameters parameters)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    db.Execute(sqlString, parameters);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
        }
        #endregion

        #region Voting methods

        #region Voting instances
        /// <summary>
        /// Get a list of voting instances
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        public List<VotingInstanceViewModel> LoadVotingInstances(string connectionString, string sqlString, DynamicParameters parameters)
        {
            List<VotingInstanceViewModel> rtnList = new List<VotingInstanceViewModel>();
            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    var votingInstanceResult = db.Query<VotingInstanceViewModel>(sqlString, parameters);
                    rtnList = votingInstanceResult.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnList;
        }
        #endregion

        #region Voting options
        /// <summary>
        /// Get a list of voting instances
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        public List<VotingOptionDBModel> LoadVotingOptions(string connectionString, string sqlString, DynamicParameters parameters)
        {
            List<VotingOptionDBModel> rtnList = new List<VotingOptionDBModel>();
            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    var votingInstanceResult = db.Query<VotingOptionDBModel>(sqlString, parameters);
                    rtnList = votingInstanceResult.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnList;
        }
        #endregion

        #region Votes
        /// <summary>
        /// gets a count of votes
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        public List<VoteDBModel> LoadVotes(string connectionString, string sqlString, DynamicParameters parameters)
        {
            List<VoteDBModel> rtnVoteSummary = new List<VoteDBModel>();
            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    var voteResult = db.Query<VoteDBModel>(sqlString, parameters);
                    rtnVoteSummary = voteResult.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnVoteSummary;
        }

        /// <summary>
        /// Get the winner for a suplementary election
        /// </summary>
        /// <param name="connectionString">Connection string to use, null if it's the real db</param>
        /// <param name="votingInstance">Election that we want to get the vote for </param>
        /// <returns></returns>
        public string GetSupplementaryWinner(string connectionString, VotingInstanceViewModel votingInstance)
        {
            string winnerName = string.Empty;

            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    string queryScript = "SELECT * FROM [Vote] WHERE [VotingInstanceId] = @VotingInstanceId";

                    var parameters = new DynamicParameters();
                    parameters.Add("@VotingInstanceId", votingInstance.VotingInstanceId);

                    List<VoteDBModel> results = LoadVotes(null, queryScript, parameters);

                    if(results.Count > 0)
                    {
                        var groupedResults = from p in results
                                             group p by p.VotedForOptionId into g
                                              select new { VotingOptionId = g.Key, Count = g.Where(c => c.Preference == 1).Count() };

                        string query = "SELECT * FROM [VotingOption] WHERE [VotingOptionId] = @VotingOptionId";
                        parameters = new DynamicParameters();
                        parameters.Add("@VotingOptionId", groupedResults.OrderByDescending(c => c.Count).FirstOrDefault().VotingOptionId);
                        VotingOptionDBModel result = LoadVotingOptions(null, query, parameters).FirstOrDefault();

                        winnerName = result.VOName;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return winnerName; 
        }

        /// <summary>
        /// Get the winner for a first past the post election
        /// </summary>
        /// <param name="connectionString">Connection string to use, null if it's the real db</param>
        /// <param name="votingInstance">Election that we want to get the vote for </param>
        /// <returns></returns>
        public string GetFirstPastPostWinner(string connectionString, VotingInstanceViewModel votingInstance)
        {
            string winnerName = string.Empty;

            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    string queryScript = "SELECT * FROM [Vote] WHERE [VotingInstanceId] = @VotingInstanceId";

                    var parameters = new DynamicParameters();
                    parameters.Add("@VotingInstanceId", votingInstance.VotingInstanceId);

                    List<VoteDBModel> results = LoadVotes(null, queryScript, parameters);

                    if (results.Count > 0)
                    {
                        var groupedResults = from p in results
                                             group p by p.VotedForOptionId into g
                                             select new { VotingOptionId = g.Key, Count = g.Count() };

                        string query = "SELECT * FROM [VotingOption] WHERE [VotingOptionId] = @VotingOptionId";
                        parameters = new DynamicParameters();
                        parameters.Add("@VotingOptionId", groupedResults.OrderByDescending(c => c.Count).FirstOrDefault().VotingOptionId);
                        VotingOptionDBModel result = LoadVotingOptions(null, query, parameters).FirstOrDefault();

                        winnerName = result.VOName;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return winnerName;
        }

        /// <summary>
        /// Get the winner for a Supplementary Vote election
        /// </summary>
        /// <param name="connectionString">Connection string to use, null if it's the real db</param>
        /// <param name="votingInstance">Election that we want to get the vote for </param>
        /// <returns></returns>
        public string GetSupplementaryVoteWinner(string connectionString, VotingInstanceViewModel votingInstance)
        {
            string winnerName = string.Empty;
            int winningOptionId = 0;

            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Get all the votes
                    // -----------------
                    string queryScript = "SELECT * FROM [Vote] WHERE [VotingInstanceId] = @VotingInstanceId";
                    var parameters = new DynamicParameters();
                    parameters.Add("@VotingInstanceId", votingInstance.VotingInstanceId);

                    List<VoteDBModel> results = LoadVotes(null, queryScript, parameters);

                    if (results.Count > 0)
                    {
                        // Group them by option id
                        // -----------------------
                        var optionGroup = from p in results
                                             group p by p.VotedForOptionId into g
                                             select new { VotingOptionId = g.Key, CountPref1 = g.Where(c => c.Preference == 1).Count(), CountPref2 = g.Where(c => c.Preference == 2).Count() };

                        optionGroup = optionGroup.OrderByDescending(list => list.CountPref1).Take(2);

                        var firstPlaceVotes = optionGroup.FirstOrDefault();
                        var secondPlaceVotes = optionGroup.LastOrDefault();

                        int percentage = (firstPlaceVotes.CountPref1 / 100) * results.Count;

                        // IF a candidate has over 50% of the votes
                        // ELSE Winner is between the top 2 candidate who has the most rank 1 + rank 2 votes
                        // ---------------------------------------------------------------------------------
                        if (percentage > 50)
                        {
                            winningOptionId = firstPlaceVotes.VotingOptionId;
                        }
                        else
                        {
                            int firstOptionCombined = firstPlaceVotes.CountPref1 + firstPlaceVotes.CountPref2;
                            int secondOptionCombined = secondPlaceVotes.CountPref1 + secondPlaceVotes.CountPref2;

                            if (firstOptionCombined >= secondOptionCombined)
                            {
                                winningOptionId = firstPlaceVotes.VotingOptionId;
                            }
                            else
                            {
                                winningOptionId = secondPlaceVotes.VotingOptionId;
                            }
                        }

                        // Once we have the winning option id, get the option name
                        // -------------------------------------------------------
                        string query = "SELECT * FROM [VotingOption] WHERE [VotingOptionId] = @VotingOptionId";
                        parameters = new DynamicParameters();
                        parameters.Add("@VotingOptionId", winningOptionId);
                        VotingOptionDBModel result = LoadVotingOptions(null, query, parameters).FirstOrDefault();

                        winnerName = result.VOName;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return winnerName;
        }
        #endregion

        #endregion

        #region Address methods
        /// <summary>
        /// Gets the address for a id
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        public AddressDBModel LoadAddress(string connectionString, string sqlString, DynamicParameters parameters)
        {
            AddressDBModel rtnAddress = new AddressDBModel();
            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    rtnAddress = db.QueryFirstOrDefault<AddressDBModel>(sqlString, parameters);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnAddress;
        }
        #endregion

        #region User methods
        /// <summary>
        /// Gets a list of users
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        public List<SuperUserViewModel> LoadUsers(string connectionString, string sqlString, DynamicParameters parameters)
        {
            List<SuperUserViewModel> rtnList = new List<SuperUserViewModel>();
            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    var votingInstanceResult = db.Query<SuperUserViewModel>(sqlString, parameters);
                    rtnList = votingInstanceResult.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnList;
        }

        /// <summary>
        /// Gets a localised string for a given keyword
        /// </summary>
        /// <param name="connectionString">Testing or real database</param>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        public String GetLocalisedString(string connectionString, string sqlString, DynamicParameters parameters, LanguageOptions cultureCode)
        {
            string rtnString = string.Empty;

            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    var languageResult = db.QueryFirstOrDefault(sqlString, parameters);

                    if (languageResult != null)
                    {
                        if (cultureCode == LanguageOptions.EN) { rtnString = languageResult.EN; }
                        else if (cultureCode == LanguageOptions.ES) { rtnString = languageResult.ES; }
                        else { rtnString = languageResult.FR; }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnString;
        }
        #endregion

        #region User audit methods
        /// <summary>
        /// Gets a user audit 
        /// </summary>
        /// <param name="sqlString">SQL string to execute</param>
        /// <param name="parameters">Parameter used in SQL string</param>
        /// <returns></returns>
        public List<UserAuditDBModel> GetUserAudits(string connectionString, string sqlString, DynamicParameters parameters)
        {
            List<UserAuditDBModel> rtnAudit = new List<UserAuditDBModel>();
            try
            {
                using (IDbConnection db = new SQLiteConnection(connectionString ?? _ConnectionString))
                {
                    // Execute the query
                    // -----------------
                    var tempList = db.Query<UserAuditDBModel>(sqlString, parameters);
                    rtnAudit = tempList.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = typeof(SQLAccessLayer).FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnAudit;
        }
        #endregion
    }
}
