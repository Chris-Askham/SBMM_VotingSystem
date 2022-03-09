using Dapper;
using SBMMVotingSystem.DAL;
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
using static SBMMVotingSystem.Managers.UserAuditManager;

namespace SBMMVotingSystem.Managers
{
    /// <summary>
    /// Collection of helper methods and attributes that will handle
    /// users wanting to vote and super users to setup voting instances
    /// </summary>
    public class VotingManager
    {
        #region Enumerations
        public enum VotingMode
        {
            FirstPassedThePost,
            SingleTransferableVote,
            SupplementaryVote
        }
        #endregion

        #region Declerations
        public AddressManager _ThisAddressManager { get; set; }
        public ErrorManager _ThisErrorManager { get; set; }
        public UserAuditManager _ThisUserAuditManager { get; set; }
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }

        /// <summary>
        /// Collection of all known voting instances
        /// </summary>
        internal List<VotingInstanceViewModel> _allVotingInstances { get; set; }

        /// <summary>
        /// App is registered for this voting instance
        /// </summary>
        internal int CurrentInstanceId { get; set; }
        #endregion

        #region Constructor
        public VotingManager(ISQLAccessLayer thisDALManager)
        {
            _ThisSQLAccessLayer = thisDALManager;
            _ThisAddressManager = new AddressManager(_ThisSQLAccessLayer);
            _ThisErrorManager = new ErrorManager(_ThisSQLAccessLayer);
            _ThisUserAuditManager = new UserAuditManager(_ThisSQLAccessLayer);

            // Get all the voting instances from the database
            // ----------------------------------------------
            _allVotingInstances = new List<VotingInstanceViewModel>();
            _allVotingInstances = GetAllVotingInstancesFromDb();
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Get a specific voting instance and its associated data, address and voting options
        /// </summary>
        /// <returns></returns>
        internal VotingInstanceViewModel GetVotingInstanceForId(int votingInstnaceId)
        {
            return _allVotingInstances.Where(vi => vi.VotingInstanceId == votingInstnaceId).FirstOrDefault();
        }

        /// <summary>
        /// Get a specific voting instance and its associated data, address and voting options
        /// </summary>
        /// <returns></returns>
        public VotingInstanceViewModel GetVotingInstanceForName(string votingInstnaceName)
        {
            return _allVotingInstances.Where(vi => vi.VIName == votingInstnaceName).FirstOrDefault();
        }


        /// <summary>
        /// Check which elections this user can vote on and return a list
        /// of voting instance view model
        /// </summary>
        public List<VotingInstanceViewModel> GetVotingInstancesForUser(int userId)
        {
            List<VotingInstanceViewModel> rtnList = new List<VotingInstanceViewModel>();

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
                    foreach (VotingInstanceViewModel thisInstance in _allVotingInstances)
                    {
                        // If the user has not voted in the election then set the flag to false
                        // --------------------------------------------------------------------
                        if (!loggedMessageList.Select(v => v.VotingInstanceId).Contains(thisInstance.VotingInstanceId))
                        {
                            rtnList.Add(thisInstance);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnList;
        }

        /// <summary>
        /// End the voting instance
        /// </summary>
        /// <param name="votingInstanceId">Election to end</param>
        /// <param name="username">User id for logging purposes</param>
        internal void EndVotingInstance(int votingInstanceId, int username)
        {
            try
            {
                // Get the voting instance details
                // -------------------------------
                string query = "UPDATE [VotingInstance] SET [CurrentlyInUse] = 0 WHERE [VotingInstanceId] = @VotingInstanceId";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@VotingInstanceId", votingInstanceId);

                _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, query, parameters);

                // Log audit to record a election has ended
                // ----------------------------------------
                UserAuditDBModel auditToAdd = new UserAuditDBModel()
                {
                    LoggedDatetimeUTC = DateTime.Now.ToString(),
                    Message = "User has ended an election",
                    UserId = username,
                    VotingInstanceId = votingInstanceId,
                    AuditType = UserAuditType.NewVote.ToString()
                };

                _ThisUserAuditManager.LogUserAudit(auditToAdd);
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
        }

        /// <summary>
        /// Removes the voting instance from the database
        /// </summary>
        /// <param name="votingInstanceId">Instance to remove</param>
        internal void DeleteVotingInstance(VotingInstanceViewModel votingInstance, int username)
        {
            try
            {
                string query;
                DynamicParameters parameters = new DynamicParameters();

                // Get the voting instance details
                // -------------------------------
                query = "SELECT * FROM [VotingInstance] WHERE [VotingInstanceId] = @VotingInstanceId";
                parameters = new DynamicParameters();
                parameters.Add("@VotingInstanceId", votingInstance.VotingInstanceId);

                VotingInstanceViewModel results = _ThisSQLAccessLayer.LoadVotingInstances(null, query, parameters).FirstOrDefault();

                if (results != null)
                {
                    // Remove the address for this instance
                    // ------------------------------------
                    _ThisAddressManager.DeleteThisAddress(results.AddressId);

                    // Remove the voting options from the database
                    // -------------------------------------------
                    DeleteVotingOptionForInstance(votingInstance.VotingInstanceId, username);

                    // Delete the voting instance
                    // --------------------------
                    query = "DELETE FROM [VotingInstance] WHERE [VotingInstanceId] = @VotingInstanceId";
                    parameters = new DynamicParameters();
                    parameters.Add("@VotingInstanceId", votingInstance.VotingInstanceId);

                    _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, query, parameters);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            // Update the internal list
            // ------------------------
            _allVotingInstances.Remove(votingInstance);
        }

        /// <summary>
        /// Add the voting instance to the databse
        /// </summary>
        /// <param name="instanceToAdd">Instance to add</param>
        /// <returns>Instance populated with the Id's from the database</returns>
        internal VotingInstanceViewModel SubmitNewVotingInstance(VotingInstanceViewModel instanceToAdd, int username)
        {
            try
            {
                // Add the voting instance address
                // -------------------------------
                instanceToAdd.AddressId = _ThisAddressManager.AddNewAddress(instanceToAdd.Address);

                // Add the voting instance
                // -----------------------
                instanceToAdd.VotingInstanceId = AddVotingInstance(instanceToAdd, username);

                // Add all voting intance options
                // ------------------------------
                foreach (VotingOptionDBModel thisOption in instanceToAdd.VotingOptions)
                {
                    thisOption.VotingInstanceId = instanceToAdd.VotingInstanceId;
                    thisOption.VotingOptionId = AddNewVotingOption(thisOption, username);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            // Update the internal list
            // ------------------------
            _allVotingInstances.Add(instanceToAdd);

            return instanceToAdd;
        }

        /// <summary>
        /// Updates a selected voting instance in the database 
        /// </summary>
        /// <param name="updatedVotingInstance">Updated details</param>
        internal void UpdateNewVotingInstance(VotingInstanceViewModel updatedVotingInstance, int username)
        {
            // Get the old model from the internal list
            // ----------------------------------------
            VotingInstanceViewModel oldInstance = _allVotingInstances.Where(vi => vi.VotingInstanceId == updatedVotingInstance.VotingInstanceId).FirstOrDefault();

            // Create a new object to store the updated details in
            // ---------------------------------------------------
            VotingInstanceViewModel newUpdatedInstance = new VotingInstanceViewModel();

            // Remove the old model from the internal list
            // -------------------------------------------
            _allVotingInstances.Remove(oldInstance);

            try
            {
                // Update the voting instance to get a new id
                // Model still contains the old instance Id until it is updated
                // ------------------------------------------------------------
                newUpdatedInstance = UpdateVotingInstance(updatedVotingInstance, username);

                // Add the voting instance address to the database
                // Model still contains the old instance Id until it is updated
                // ------------------------------------------------------------
                updatedVotingInstance.Address.AddressId = oldInstance.AddressId;
                newUpdatedInstance.Address = _ThisAddressManager.UpdateAddress(updatedVotingInstance.Address);
                if (newUpdatedInstance.Address != null)
                {
                    newUpdatedInstance.AddressId = newUpdatedInstance.Address.AddressId;
                }

                // Remove the voting options from the database
                // -------------------------------------------
                DeleteVotingOptionForInstance(oldInstance.VotingInstanceId, username);

                // Add the new voting options
                // --------------------------
                newUpdatedInstance.VotingOptions = new List<VotingOptionDBModel>();
                foreach (VotingOptionDBModel thisOption in updatedVotingInstance.VotingOptions)
                {
                    thisOption.VotingInstanceId = newUpdatedInstance.VotingInstanceId;
                    thisOption.VotingOptionId = AddNewVotingOption(thisOption, username);
                    newUpdatedInstance.VotingOptions.Add(thisOption);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            // Add the updated model back into the internal list
            // -------------------------------------------------
            _allVotingInstances.Add(updatedVotingInstance);
        }

        /// <summary>
        /// Submit a new vote from the user for the current voiting instance id
        /// </summary>
        /// <param name="submittedVote">Submitted vote information</param>
        /// <param name="userId">User id for user that has submitted the vote, for logging purposes</param>
        internal int SubmitNewVote(VoteDBModel submittedVote, int userId)
        {
            int rtnVoteId = 0;

            try
            {
                string insertScript = "INSERT INTO [Vote] ([VotingInstanceId], [VotedForOptionId], [VotedAtCity], [Preference]) " +
                                        "VALUES (@VotingInstanceId, @VotedForOptionId, @VotedAtCity, @Preference);  SELECT last_insert_rowid();";

                var parameters = new DynamicParameters();
                parameters.Add("@VotingInstanceId", submittedVote.VotingInstanceId);
                parameters.Add("@VotedForOptionId", submittedVote.VotedForOptionId);
                parameters.Add("@VotedAtCity", submittedVote.VotedAtCity);
                parameters.Add("@Preference", submittedVote.Preference);

                rtnVoteId = _ThisSQLAccessLayer.ExecuteScalar_CreateT(null, insertScript, parameters);

                // If the retnVoteId is not null then the vote has submitted successfully
                // Therefore log the submit to the User Audit table in the db
                //-----------------------------------------------------------------------
                if (rtnVoteId != 0)
                {
                    UserAuditDBModel auditToAdd = new UserAuditDBModel()
                    {
                        LoggedDatetimeUTC = DateTime.Now.ToString(),
                        Message = "User has submitted a vote",
                        UserId = userId,
                        VotingInstanceId = submittedVote.VotingInstanceId,
                        AuditType = UserAuditType.NewVote.ToString()
                    };

                    _ThisUserAuditManager.LogUserAudit(auditToAdd);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnVoteId;
        }

        /// <summary>
        /// Get a list of all the votes that have been submitted
        /// for the selected voting instance
        /// </summary>
        /// <param name="votingInstance">Selected voting instance</param>
        /// <returns>List of all the options and how many votes have been submitted for each</returns>
        internal SummaryExportModel GetSummaryData(string selectedinstance)
        {
            SummaryExportModel rtnmodel = new SummaryExportModel();
            rtnmodel.ResultsForOption = new List<SummaryChartViewModel>();
            rtnmodel.ResultsForArea = new List<SummaryForAreaViewModel>();

            try
            {
                rtnmodel.VotingInstance = GetVotingInstanceForName(selectedinstance);

                foreach (VotingOptionDBModel thisOption in rtnmodel.VotingInstance.VotingOptions)
                {
                    // Get a list of votes for the election and the specific option
                    // ------------------------------------------------------------
                    string queryScript = "SELECT * FROM [Vote] WHERE [VotingInstanceId] = @VotingInstanceId AND [VotedForOptionId] = @VotedForOptionId";

                    var parameters = new DynamicParameters();
                    parameters.Add("@VotingInstanceId", thisOption.VotingInstanceId);
                    parameters.Add("@VotedForOptionId", thisOption.VotingOptionId);

                    List<VoteDBModel> results = _ThisSQLAccessLayer.LoadVotes(null, queryScript, parameters);

                    // Get the data for the chart by option 
                    // ------------------------------------
                    SummaryChartViewModel modelToAddForOption = new SummaryChartViewModel()
                    {
                        NumberOfVotes = results.Count,
                        VotedForOptionId = thisOption.VotingOptionId,
                        VOName = thisOption.VOName
                    };
                    rtnmodel.ResultsForOption.Add(modelToAddForOption);

                    // Get the data for the grid by city
                    // ---------------------------------
                    var areaGroup = results.GroupBy(r => r.VotedAtCity).ToList();

                    foreach (var group in areaGroup)
                    {
                        SummaryForAreaViewModel modelToAddForArea = new SummaryForAreaViewModel()
                        {
                            City = group.Key,
                            NumberOfVotesPerCity = group.Count(),
                            VotedForOptionId = thisOption.VotingOptionId,
                            VOName = thisOption.VOName
                        };
                        rtnmodel.ResultsForArea.Add(modelToAddForArea);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnmodel;
        }

        /// <summary>
        /// Remove the selected name from the database
        /// </summary>
        /// <param name="optionName">Option to be deleted</param>
        internal void RemoveVotingOption(string optionName, int username)
        {
            try
            {
                string query = "SELECT * FROM [VotingOption] WHERE [VOName] = @VOName";
                var parameters = new DynamicParameters();
                parameters.Add("@VOName", optionName);
                VotingOptionDBModel optionResult = _ThisSQLAccessLayer.LoadVotingOptions(null, query, parameters).FirstOrDefault();

                if (optionResult != null)
                {
                    DeleteVotingOptionForInstance(optionResult.VotingOptionId, username);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Get the voting instance for a specific instance Id
        /// </summary>
        /// <param name="instanceId">Instance we ar elooking for</param>
        /// <returns>voting instance model populated with data from the database</returns>
        internal VotingInstanceViewModel GetVotingInstancesFromDb(int instanceId)
        {
            VotingInstanceViewModel rtnAddress = new VotingInstanceViewModel();
            try
            {
                string query = "SELECT * FROM [VotingInstance] WHERE [VotingInstanceId] = @VotingInstanceId";
                var parameters = new DynamicParameters();
                parameters.Add("@VotingInstanceId", instanceId);
                VotingInstanceViewModel results = _ThisSQLAccessLayer.LoadVotingInstances(null, query, parameters).FirstOrDefault();

                if (results != null)
                {
                    rtnAddress = new VotingInstanceViewModel()
                    {
                        AddressId = results.AddressId,
                        CurrentlyInUse = results.CurrentlyInUse,
                        VIDescription = results.VIDescription,
                        VIName = results.VIName,
                        VotingInstanceId = results.VotingInstanceId
                    };
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnAddress;
        }

        /// <summary>
        /// Get a list of all the voting instances and their connected data
        /// </summary>
        /// <returns>List of Voting instances models</returns>
        private List<VotingInstanceViewModel> GetAllVotingInstancesFromDb()
        {
            List<VotingInstanceViewModel> rtnList = new List<VotingInstanceViewModel>();

            try
            {
                // Get the data from the diffrent tables
                // -------------------------------------
                string query = "SELECT * FROM [VotingInstance] ";
                List<VotingInstanceViewModel> votingInstanceResult = _ThisSQLAccessLayer.LoadVotingInstances(null, query, new DynamicParameters());

                if (votingInstanceResult.ToList().Count > 0)
                {
                    foreach (VotingInstanceViewModel thisvotingInstance in votingInstanceResult)
                    {
                        // Setup the address details
                        // -------------------------
                        AddressDBModel thisAddress = _ThisAddressManager.GetAddress(thisvotingInstance.AddressId);

                        if (thisAddress != null)
                        {
                            thisvotingInstance.Address = new AddressDBModel()
                            {
                                AddressId = thisAddress.AddressId,
                                AddressLine1 = thisAddress.AddressLine1,
                                AddressLine2 = thisAddress.AddressLine2,
                                City = thisAddress.City,
                                Country = thisAddress.Country,
                                Postcode = thisAddress.Postcode,
                            };
                        }

                        // Setup the voting option details 
                        // -------------------------------
                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add("@VotingInstanceId", thisvotingInstance.VotingInstanceId);
                        query = "SELECT * FROM [VotingOption] WHERE [VotingInstanceId] = @VotingInstanceId";
                        List<VotingOptionDBModel> optionResult = _ThisSQLAccessLayer.LoadVotingOptions(null, query, parameters);

                        if (optionResult.Count > 0)
                        {
                            thisvotingInstance.VotingOptions = new List<VotingOptionDBModel>();
                            foreach (VotingOptionDBModel thisOption in optionResult.ToList())
                            {
                                thisvotingInstance.VotingOptions.Add(thisOption);
                            }
                        }
                    }
                    rtnList = votingInstanceResult.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnList;
        }

        /// <summary>
        /// Add a new voting instance and its associated data
        /// </summary>
        /// <param name="instanceToAdd">Instance to add</param>
        private int AddVotingInstance(VotingInstanceViewModel instanceToAdd, int username)
        {
            int rtnInstanceId = 0;

            try
            {
                string insertScript = "INSERT INTO [VotingInstance] ([VIName], [VIDescription], [AddressId], [CurrentlyInUse], [VIVotingMode]) " +
                                        "VALUES (@VIName, @ViDescription, @AddressId, @CurrentlyInUse, @VIVotingMode); SELECT last_insert_rowid();";

                var parameters = new DynamicParameters();
                parameters.Add("@VIName", instanceToAdd.VIName);
                parameters.Add("@VIDescription", instanceToAdd.VIDescription);
                parameters.Add("@AddressId", instanceToAdd.AddressId);
                parameters.Add("@CurrentlyInUse", instanceToAdd.CurrentlyInUse);
                parameters.Add("@VIVotingMode", instanceToAdd.VIVotingMode);

                rtnInstanceId = _ThisSQLAccessLayer.ExecuteScalar_CreateT(null, insertScript, parameters);

                if (rtnInstanceId != 0)
                {
                    UserAuditDBModel auditToAdd = new UserAuditDBModel()
                    {
                        LoggedDatetimeUTC = DateTime.Now.ToString(),
                        Message = $"User added voting instance {instanceToAdd.VotingInstanceId}",
                        UserId = username,
                        VotingInstanceId = rtnInstanceId,
                        AuditType = UserAuditType.AddVotingInstance.ToString()
                    };

                    _ThisUserAuditManager.LogUserAudit(auditToAdd);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnInstanceId;
        }

        /// <summary>
        /// Update the voting instance
        /// </summary>
        /// <param name="instanceToUpdate">Instance details</param>
        private VotingInstanceViewModel UpdateVotingInstance(VotingInstanceViewModel instanceToUpdate, int username)
        {
            VotingInstanceViewModel rtnModel = new VotingInstanceViewModel();

            try
            {
                var parameters = new DynamicParameters();

                // Update the instances record 
                // ---------------------------
                string updateScript = "UPDATE [VotingInstance] " +
                                        "SET [VIName] = @VIName, [VIDescription] = @VIDescription, [CurrentlyInUse] = @CurrentlyInUse, [VIVotingMode] = @VIVotingMode " +
                                        "WHERE [VotingInstanceId] = @VotingInstanceId;";
                parameters.Add("@VotingInstanceId", instanceToUpdate.VotingInstanceId);
                parameters.Add("@VIName", instanceToUpdate.VIName);
                parameters.Add("@VIDescription", instanceToUpdate.VIDescription);
                parameters.Add("@CurrentlyInUse", instanceToUpdate.CurrentlyInUse);
                parameters.Add("@VIVotingMode", instanceToUpdate.VIVotingMode);

                _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, updateScript, parameters);

                // Get the updated model from the database
                // ---------------------------------------
                rtnModel = GetVotingInstancesFromDb(instanceToUpdate.VotingInstanceId);

                if (rtnModel != null)
                {
                    UserAuditDBModel auditToAdd = new UserAuditDBModel()
                    {
                        LoggedDatetimeUTC = DateTime.Now.ToString(),
                        Message = $"User updated voting instance {instanceToUpdate.VotingInstanceId}",
                        UserId = username,
                        VotingInstanceId = rtnModel.VotingInstanceId,
                        AuditType = UserAuditType.UpdateVotingInstance.ToString()
                    };

                    _ThisUserAuditManager.LogUserAudit(auditToAdd);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
            return rtnModel;
        }

        /// <summary>
        /// Get the voting option for a specific option Id
        /// </summary>
        /// <param name="optionId">Option we are looking for</param>
        /// <returns>voting option model populated with data from the database</returns>
        internal VotingOptionDBModel GetVotingOptionFromDb(int optionId)
        {
            VotingOptionDBModel rtnModel = new VotingOptionDBModel();
            try
            {
                string query = "SELECT * FROM [VotingOption] WHERE [VotingOptionId] = @VotingOptionId";
                var parameters = new DynamicParameters();
                parameters.Add("@VotingOptionId", optionId);
                VotingOptionDBModel result = _ThisSQLAccessLayer.LoadVotingOptions(null, query, parameters).FirstOrDefault();

                if (result != null)
                {
                    rtnModel = new VotingOptionDBModel()
                    {
                        VODescription = result.VODescription,
                        VOName = result.VOName,
                        VotingOptionId = optionId,
                        VotingInstanceId = result.VotingInstanceId
                    };
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnModel;
        }

        /// <summary>
        /// Add a new voting option to the database
        /// </summary>
        /// <param name="optionToAdd">Option to add</param>
        private int AddNewVotingOption(VotingOptionDBModel optionToAdd, int username)
        {
            int rtnOptionId = 0;

            try
            {
                string insertScript = "INSERT INTO [VotingOption] ([VOName], [VODescription], [VotingInstanceId]) " +
                                            "VALUES (@VOName, @VODescription, @VotingInstanceId); SELECT last_insert_rowid();";

                var parameters = new DynamicParameters();
                parameters.Add("@VOName", optionToAdd.VOName);
                parameters.Add("@VODescription", optionToAdd.VODescription);
                parameters.Add("@VotingInstanceId", optionToAdd.VotingInstanceId);

                rtnOptionId = _ThisSQLAccessLayer.ExecuteScalar_CreateT(null, insertScript, parameters);

                if (rtnOptionId != 0)
                {
                    UserAuditDBModel auditToAdd = new UserAuditDBModel()
                    {
                        LoggedDatetimeUTC = DateTime.Now.ToString(),
                        Message = $"User added {optionToAdd.VOName} as a voting option",
                        UserId = username,
                        VotingInstanceId = optionToAdd.VotingInstanceId,
                        AuditType = UserAuditType.AddVotingOption.ToString()
                    };

                    _ThisUserAuditManager.LogUserAudit(auditToAdd);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnOptionId;
        }

        /// <summary>
        /// Removes all voting options for a given voting instance
        /// </summary>
        /// <param name="votingInstanceId">Voting instance id</param>
        private void DeleteVotingOptionForInstance(int votingInstanceId, int username)
        {
            try
            {
                string query = string.Empty;
                var parameters = new DynamicParameters();

                // Remove the voting options 
                // -------------------------
                query = "DELETE FROM [VotingOption] WHERE [VotingInstanceId] = @VotingInstanceId";
                parameters = new DynamicParameters();
                parameters.Add("@VotingInstanceId", votingInstanceId);
                _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, query, parameters);

                UserAuditDBModel auditToAdd = new UserAuditDBModel()
                {
                    LoggedDatetimeUTC = DateTime.Now.ToString(),
                    Message = $"User deleted voting options for votingInstanceId[{votingInstanceId}]",
                    UserId = username,
                    VotingInstanceId = votingInstanceId,
                    AuditType = UserAuditType.DeleteVotingOption.ToString()
                };

                _ThisUserAuditManager.LogUserAudit(auditToAdd);
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
        }
        #endregion
    }
}
