using Dapper;
using SBMMVotingSystem.DAL;
using SBMMVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SBMMVotingSystem.Managers
{
    /// <summary>
    /// Collection of helper methods that will enable the user to get 
    /// information and submit inforamtion to the database
    /// </summary>
    public class AddressManager
    {
        #region Attributes
        public ErrorManager _ThisErrorManager { get; set; }
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }

        #endregion

        #region Constructor
        public AddressManager(ISQLAccessLayer thisDALManager)
        {
            _ThisSQLAccessLayer = thisDALManager;
            _ThisErrorManager = new ErrorManager(_ThisSQLAccessLayer);
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Update a new users address details 
        /// </summary>
        /// <param name="addressToAdd">Address details for new user</param>
        /// <returns>Address from database</returns>
        internal AddressDBModel UpdateAddress(AddressDBModel addressToAdd)
        {
            AddressDBModel rtnAddress = new AddressDBModel();
            try
            {
                var parameters = new DynamicParameters();

                string insertScript = "UPDATE [Address] " +
                                        "SET [AddressLine1] = @AddressLine1, [AddressLine2] = @AddressLine2, [City] = @City, [Country] = @Country, [Postcode] = @Postcode " +
                                        "WHERE [AddressId] = @AddressId; ";
                parameters.Add("@AddressId", addressToAdd.AddressId);
                parameters.Add("@AddressLine1", addressToAdd.AddressLine1);
                parameters.Add("@AddressLine2", addressToAdd.AddressLine2);
                parameters.Add("@City", addressToAdd.City);
                parameters.Add("@Country", addressToAdd.Country);
                parameters.Add("@Postcode", addressToAdd.Postcode);

                _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, insertScript, parameters);

                // Get the updated address to return to the caller
                // -----------------------------------------------
                rtnAddress = GetAddress(addressToAdd.AddressId);
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnAddress;
        }

        /// <summary>
        /// Save a new users address details 
        /// </summary>
        /// <param name="addressToAdd">Address details for new user</param>
        /// <returns>Address id from database</returns>
        internal int AddNewAddress(AddressDBModel addressToAdd)
        {
            int rtnAddressId = 0;
            try
            {
                string insertScript = @"INSERT INTO [Address] ([AddressLine1], [AddressLine2], [City], [Country], [Postcode])" +
                                        "VALUES (@AddressLine1, @AddressLine2, @City, @Country, @PostCode); SELECT last_insert_rowid();";

                var parameters = new DynamicParameters();
                parameters.Add("@AddressLine1", addressToAdd.AddressLine1);
                parameters.Add("@AddressLine2", addressToAdd.AddressLine2);
                parameters.Add("@City", addressToAdd.City);
                parameters.Add("@Country", addressToAdd.Country);
                parameters.Add("@Postcode", addressToAdd.Postcode);

                rtnAddressId = _ThisSQLAccessLayer.ExecuteScalar_CreateT(null, insertScript, parameters);
            }
            catch (Exception ex)
            {
                ErrorLogDBModel error = new ErrorLogDBModel() { ClassName = GetType().FullName, MethodName = MethodBase.GetCurrentMethod().Name, LoggedDatetimeUTC = DateTime.Now.ToString(), Exception = ex.Message };
                _ThisErrorManager.LogErrorMessage(error);
            }

            return rtnAddressId;
        }

        /// <summary>
        /// Get the Address for a specific address Id
        /// </summary>
        /// <param name="addressId">Address we are looking for </param>
        /// <returns>Address model populated with data from the database</returns>
        public AddressDBModel GetAddress(int addressId)
        {
            AddressDBModel rtnAddress = new AddressDBModel();
            try
            {
                string query = "SELECT * FROM [Address] WHERE [AddressId] = @AddressId";
                var parameters = new DynamicParameters();
                parameters.Add("@AddressId", addressId);
                AddressDBModel addressResult = _ThisSQLAccessLayer.LoadAddress(null, query, parameters);

                if (addressResult != null)
                {
                    rtnAddress = new AddressDBModel()
                    {
                        AddressId = addressResult.AddressId,
                        AddressLine1 = addressResult.AddressLine1,
                        AddressLine2 = addressResult.AddressLine2,
                        City = addressResult.City,
                        Country = addressResult.Country,
                        Postcode = addressResult.Postcode,
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
        /// Remove the address
        /// </summary>
        /// <param name="addressId">Instance that is to be removed</param>
        internal void DeleteThisAddress(int addressId)
        {
            try
            {
                // Remove the address for this instance
                // ------------------------------------
                string query = "DELETE FROM [Address] WHERE [AddressId] = @AddressId";

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AddressId", addressId);
                _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(null, query, parameters);
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
