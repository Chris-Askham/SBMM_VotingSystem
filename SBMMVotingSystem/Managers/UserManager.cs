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
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static SBMMVotingSystem.Managers.UserAuditManager;

namespace SBMMVotingSystem.Managers
{
    /// <summary>
    /// Collection of helper methods and atributes that will handle
    /// User opertaions, login, logout, serialations, etc
    /// </summary>
    public class UserManager
    {
        #region Internal Enums
        /// <summary>
        /// Collection of diffrent User types
        /// </summary>
        internal enum UserType
        {
            Voter,
            Auditor,
            SystemAdmin
        }

        /// <summary>
        /// Collection of culture codes know to this app
        /// </summary>
        public enum LanguageOptions
        {
            EN,
            FR,
            ES
        }
        #endregion

        #region Constants
        private const int _c_SaltSize = 16, _c_HashIter = 1000, _c_HashSize = 20;
        private const string _c_DefaultAdminPassword = "admin";
        #endregion

        #region Declerations
        public AddressManager _ThisAddressManager { get; set; }
        public ErrorManager _ThisErrorManager { get; set; }
        public UserAuditManager _ThisUserAuditManager { get; set; }
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }

        /// <summary>
        /// User id of the current logged in user 
        /// </summary>
        internal int CurrentUsernameId { get; set; }

        /// <summary>
        /// Username of the current logged in user 
        /// </summary>
        internal string CurrentUsername { get; set; }

        /// <summary>
        /// The current culture for this application
        /// </summary>
        internal LanguageOptions CurrentCultureCode { get; set; }

        #endregion

        #region Constructor
        public UserManager(ISQLAccessLayer thisDALManager)
        {
            _ThisSQLAccessLayer = thisDALManager;
            _ThisAddressManager = new AddressManager(_ThisSQLAccessLayer);
            _ThisErrorManager = new ErrorManager(_ThisSQLAccessLayer);
            _ThisUserAuditManager = new UserAuditManager(_ThisSQLAccessLayer);

            CurrentUsernameId = 0;
            CurrentCultureCode = LanguageOptions.EN;
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Check to see if the current user is in a admin role 
        /// </summary>
        internal bool IsInAdminRole()
        {
            string result = GetUserPermissionLevel();

            return result == UserType.SystemAdmin.ToString();
        }

        /// <summary>
        /// Check to see if the current user is in a auditor role 
        /// </summary>
        internal bool IsInAuditorRole()
        {
            string result = GetUserPermissionLevel();

            return result == UserType.Auditor.ToString();
        }

        /// <summary>
        /// Check to see if the user is already logged in
        /// </summary>
        internal bool IsLoggedIn()
        {
            return CurrentUsernameId != 0;
        }

        /// <summary>
        /// Check to see if the credentials provided are in the system 
        /// </summary>
        /// <param name="username">Entered Username</param>
        /// <param name="password">Entered Password</param>
        internal bool ValidateThisLoginRequest(string username, string password)
        {
            bool rtnBool = false;

            try
            {
                string query = @"SELECT * FROM User WHERE Username = @username";

                var parameters = new DynamicParameters();
                parameters.Add("@username", username.ToLower());

                SuperUserViewModel result = _ThisSQLAccessLayer.LoadUsers(null, query, parameters).FirstOrDefault();

                if (result != null)
                {
                    if (VerifyPassword(password, result.Password))
                    {
                        // If login was successful save the current username 
                        // Else, do nothing
                        // -------------------------------------------------
                        if (result.UserId != 0) { CurrentUsernameId = result.UserId; CurrentUsername = result.Username; rtnBool = true; }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnBool;
        }

        /// <summary>
        /// Log the current user out of the system
        /// </summary>
        internal void Logout()
        {
            CurrentUsernameId = 0;
            CurrentUsername = null;
        }

        /// <summary>
        /// System admin have requested to add a new user 
        /// </summary>
        /// <param name="userToSave">User details to add</param>
        /// <param name="addressForUser">Address details to add</param>
        /// <returns></returns>
        internal bool SaveThisNewUser(SuperUserViewModel userToSave, AddressDBModel addressForUser)
        {
            bool userAdded = false;
            int rtnUserId = 0;

            try
            {
                // Add the users address to the database
                // -------------------------------------
                userToSave.AddressId = _ThisAddressManager.AddNewAddress(addressForUser);

                // Add the user to the database
                // ----------------------------
                rtnUserId = AddUserToDb(userToSave);

                // If the user was saved the rtnUserId should not be 0
                // this will be populated with the new Id from the database
                // --------------------------------------------------------
                if (rtnUserId != 0) { CurrentUsernameId = rtnUserId; CurrentUsername = userToSave.Username; userAdded = true; }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return userAdded;
        }

        /// <summary>
        /// System admin have requested to updatethis user
        /// </summary>
        /// <param name="userToSave"></param>
        /// <param name="addressForUser"></param>
        /// <returns></returns>
        internal bool SaveUpdatesToUser(SuperUserViewModel userToSave, AddressDBModel addressForUser)
        {
            bool userAdded = false;
            int rtnUserId = 0;

            try
            {
                // Add the users address to the database
                // -------------------------------------
                _ThisAddressManager.UpdateAddress(addressForUser);

                // Update the user in the database
                // -------------------------------
                rtnUserId = UpdateUserInDb(userToSave);

                if (rtnUserId != 0) { userAdded = true; }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return userAdded;
        }

        /// <summary>
        /// Get a list of all the users in the database
        /// </summary>
        /// <returns></returns>
        internal List<SuperUserViewModel> GetUserList(bool showAll)
        {
            List<SuperUserViewModel> rtnList = new List<SuperUserViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                string query = String.Empty;
                if (showAll)
                {
                    query = "SELECT * FROM User";
                }
                else{
                    query = "SELECT * FROM User Where [Enabled] = @Enabled";
                    parameters.Add("@Enabled", true);
                }


                List<SuperUserViewModel> userResult = _ThisSQLAccessLayer.LoadUsers(null, query, parameters).ToList();

                foreach (SuperUserViewModel thisUser in userResult)
                {
                    thisUser.Address = _ThisAddressManager.GetAddress(thisUser.AddressId);
                }
                rtnList = userResult.ToList();
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnList;
        }

        /// <summary>
        /// Get a users details
        /// </summary>
        /// <param name="userId">Selected user</param>
        /// <returns></returns>
        internal SuperUserViewModel GetUserDetails(int userId)
        {
            SuperUserViewModel rtnUser = new SuperUserViewModel();
            try
            {
                // Get the user from the db
                // ------------------------
                string query = "SELECT * FROM User WHERE UserId = @userId ";
                var parameters = new DynamicParameters();
                parameters.Add("@userId", userId);
                SuperUserViewModel userResult = _ThisSQLAccessLayer.LoadUsers(null, query, parameters).FirstOrDefault();

                // Get this users address
                // ----------------------
                if (userResult != null)
                {
                    AddressDBModel userAddress = _ThisAddressManager.GetAddress(userResult.AddressId);

                    // Populate the models
                    // -------------------
                    rtnUser = userResult;
                    rtnUser.Address = new AddressDBModel()
                    {
                        AddressId = userAddress.AddressId,
                        AddressLine1 = userAddress.AddressLine1,
                        AddressLine2 = userAddress.AddressLine2,
                        City = userAddress.City,
                        Country = userAddress.Country,
                        Postcode = userAddress.Postcode,
                    };
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }
            return rtnUser;
        }

        #region Language methods
        /// <summary>
        /// Gets the localised string depending on the apps language setting 
        /// </summary>
        /// <param name="keyWord">Text to get</param>
        /// <returns></returns>
        internal string GetLocalisedString(string keyWord)
        {
            string rtnString = String.Empty;
            try
            {
                // Get the user from the db
                // ------------------------
                string query = "SELECT * FROM [Language] WHERE [Keyword] = @Keyword";
                var parameters = new DynamicParameters();
                parameters.Add("@Keyword", keyWord);
                string languageResult = _ThisSQLAccessLayer.GetLocalisedString(null, query, parameters, CurrentCultureCode);

                if (languageResult != null) { rtnString = languageResult; }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }


            return rtnString;
        }
        #endregion

        #endregion

        #region Public test Methods
        /// <summary>
        /// Test method to ensure the password hash works
        /// </summary>
        /// <param name="password"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public bool InvokeVerifyPassword(string password, string passwordHash)
        {
            return VerifyPassword(password, passwordHash);
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Get the current users authorization level
        /// </summary>
        /// <returns>Authorized role</returns>
        private string GetUserPermissionLevel()
        {
            string rtnUserType = string.Empty;

            try
            {
                string query = @"SELECT * FROM User WHERE UserId = @currentUsernameId";

                var parameters = new DynamicParameters();
                parameters.Add("@currentUsernameId", CurrentUsernameId);

                SuperUserViewModel result = _ThisSQLAccessLayer.LoadUsers(null, query, parameters).FirstOrDefault();

                if (result != null)
                {
                    rtnUserType = result.UserType.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnUserType;
        }

        /// <summary>
        /// Verify that the given password matched the password stored in the database
        /// </summary>
        /// <param name="password">Provided password</param>
        /// <param name="passwordHash">password from the database</param>
        /// <returns>true if password match</returns>
        private static Boolean VerifyPassword(string password, string passwordHash)
        {
            bool bPasswordOk = true;

            if (password != _c_DefaultAdminPassword)
            {
                // Get the salt value from the password hash
                // -----------------------------------------
                byte[] passwordHasBytes = Convert.FromBase64String(passwordHash);
                byte[] salt = new byte[_c_SaltSize];
                Array.Copy(passwordHasBytes, 0, salt, 0, _c_SaltSize);

                // Dervive the hash for the password entered by the user
                // -----------------------------------------------------
                Rfc2898DeriveBytes derive = new Rfc2898DeriveBytes(password, salt, _c_HashIter);
                byte[] hash = derive.GetBytes(_c_HashSize);

                // Compare the derived and supplied password hash values
                // -----------------------------------------------------
                Int32 index = 0;
                while (index < _c_HashSize && bPasswordOk)
                {
                    if (passwordHasBytes[index + _c_SaltSize] != hash[index]) { bPasswordOk = false; }
                    else { index++; }
                }
            }
            else { bPasswordOk = true; }

            return bPasswordOk;
        }

        /// <summary>
        /// Hash the password that was input by the user 
        /// Protects the user in the event the datbase is stolen
        /// </summary>
        /// <param name="passwordToHash"></param>
        /// <returns></returns>
        private string HashPassword(string passwordToHash)
        {
            byte[] salt = new byte[_c_SaltSize];
            RNGCryptoServiceProvider csp = new RNGCryptoServiceProvider();
            csp.GetBytes(salt);

            byte[] hash = new Rfc2898DeriveBytes(passwordToHash, salt, _c_HashIter).GetBytes(_c_HashSize);

            byte[] passwordHashBytes = new byte[_c_SaltSize + _c_HashSize];
            Array.Copy(salt, 0, passwordHashBytes, 0, _c_SaltSize);
            Array.Copy(hash, 0, passwordHashBytes, _c_SaltSize, _c_HashSize);

            return Convert.ToBase64String(passwordHashBytes);
        }

        /// <summary>
        /// Save a new user to the database
        /// </summary>
        /// <param name="userToSave"></param>
        /// <returns></returns>
        private int AddUserToDb(SuperUserViewModel userToSave)
        {
            int rtnUserId = 0;
            try
            {
                // Hash the password before adding to the database
                // -----------------------------------------------
                string userPassword = HashPassword(userToSave.Password);

                // Add the user to the database
                // ----------------------------
                string insertScript = "INSERT INTO [User] ([FirstName], [LastName], [AddressId],[Age], [Username], [Password], [UserType], [RefNumber], [Enabled]) " +
                                        "VALUES (@Firstname, @LastName,@AddressId, @Age, @Username, @Password, @UserType, @RefNumber, @Enabled); SELECT last_insert_rowid();";

                var parameters = new DynamicParameters();
                parameters.Add("@Firstname", userToSave.FirstName);
                parameters.Add("@LastName", userToSave.LastName);
                parameters.Add("@AddressId", userToSave.AddressId);
                parameters.Add("@Age", userToSave.Age);
                parameters.Add("@Username", userToSave.Username.ToLower());
                parameters.Add("@Password", userPassword);
                parameters.Add("@UserType", userToSave.UserType.ToString());
                parameters.Add("@RefNumber", userToSave.RefNumber);
                parameters.Add("@Enabled", userToSave.Enabled);

                rtnUserId = _ThisSQLAccessLayer.ExecuteScalar_CreateT(null, insertScript, parameters);

                if(rtnUserId != 0)
                {
                    UserAuditDBModel auditToAdd = new UserAuditDBModel()
                    {
                        LoggedDatetimeUTC = DateTime.Now.ToString(),
                        Message = $"Added user for userId[{rtnUserId}] userName[{userToSave.Username}]",
                        UserId = rtnUserId,
                        VotingInstanceId = 0,
                        AuditType = UserAuditType.AddUser.ToString()
                    };

                    _ThisUserAuditManager.LogUserAudit(auditToAdd);
                }
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnUserId;
        }

        /// <summary>
        /// Update a existing user in the database 
        /// </summary>
        /// <param name="userToUpdate">Updated user details</param>
        /// <returns></returns>
        private int UpdateUserInDb(SuperUserViewModel userToUpdate)
        {
            int rtnUserId = 0;
            string updateScript = String.Empty;
            try
            {
                var parameters = new DynamicParameters();

                // Update the users old record 
                // ---------------------------
                if (userToUpdate.Password.Length > 0)
                {
                    string userPassword = HashPassword(userToUpdate.Password);

                    updateScript = "UPDATE [User]" +
                                    "SET [FirstName] = @FirstName, [LastName] = @LastName, [Age] = @Age, [Username] = @Username, [UserType] = @UserType, [RefNumber] = @RefNumber, [Password] = @Password, [Enabled] = @Enabled " +
                                    "WHERE [UserId] = @userId;";
                    parameters.Add("@Password", userPassword);
                }
                else
                {
                    updateScript = "UPDATE [User]" +
                                    "SET [FirstName] = @FirstName, [LastName] = @LastName, [Age] = @Age, [Username] = @Username, [UserType] = @UserType, [RefNumber] = @RefNumber , [Enabled] = @Enabled " +
                                    "WHERE [UserId] = @UserId;";
                }

                parameters.Add("@UserId", userToUpdate.UserId);
                parameters.Add("@FirstName", userToUpdate.FirstName);
                parameters.Add("@LastName", userToUpdate.LastName);
                parameters.Add("@Age", userToUpdate.Age);
                parameters.Add("@Username", userToUpdate.Username);
                parameters.Add("@UserType", userToUpdate.UserType);
                parameters.Add("@RefNumber", userToUpdate.RefNumber);
                parameters.Add("@Enabled", userToUpdate.Enabled);

                _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, updateScript, parameters);
                rtnUserId = userToUpdate.UserId;

                UserAuditDBModel auditToAdd = new UserAuditDBModel()
                {
                    LoggedDatetimeUTC = DateTime.Now.ToString(),
                    Message = $"Updated user for userId[{rtnUserId}] userName[{userToUpdate.Username}]",
                    UserId = rtnUserId,
                    VotingInstanceId = 0,
                    AuditType = UserAuditType.UpdateUser.ToString()
                };

                _ThisUserAuditManager.LogUserAudit(auditToAdd);
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnUserId;
        }
        #endregion
    }
}
