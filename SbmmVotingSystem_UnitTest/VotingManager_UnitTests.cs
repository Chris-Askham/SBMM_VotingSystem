using Dapper;
using NUnit.Framework;
using SBMMVotingSystem.DAL;
using SBMMVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SbmmVotingSystem_UnitTest
{
    [TestFixture]
    public class VotingManager_UnitTests
    {
        #region Constructor
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }
        public VotingManager_UnitTests()
        {
            _ThisSQLAccessLayer = new SQLAccessLayer();
        }
        #endregion

        #region Test Database calls
        /// <summary>
        /// Test the database connection 
        /// Using the test database see if the SQLAccessLayer can get a list of users
        /// </summary>
        [Test]
        public void LoadVotingInstance_ValidateCall()
        {
            try
            {
                VotingInstanceViewModel instanceFromTestData = GetSampleUsers().FirstOrDefault();

                string query = "SELECT * FROM [VotingInstance] WHERE [VotingInstanceId] = @VotingInstanceId";
                var parameters = new DynamicParameters();
                parameters.Add("@VotingInstanceId", instanceFromTestData.VotingInstanceId);
                VotingInstanceViewModel results = _ThisSQLAccessLayer.LoadVotingInstances(Properties.Settings.Default.TestConnectionString, query, parameters).FirstOrDefault();

                Assert.IsTrue(results != null);
                Assert.IsTrue(results.VIName == "Test One Election");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed to run. ex[{ex.Message}] inner ex[{ex.InnerException}]");
            }
        }

        /// <summary>
        /// Test the database connection 
        /// Using the test database see if the SQLAccessLayer can get a list of users
        /// </summary>
        [Test]
        public void LoadAllVotingInstance_ValidateCall()
        {
            try
            {
                List<VotingInstanceViewModel> instancesFromTestData = GetSampleUsers();

                string query = "SELECT * FROM [VotingInstance] ";
                var parameters = new DynamicParameters();
                List<VotingInstanceViewModel> results = _ThisSQLAccessLayer.LoadVotingInstances(Properties.Settings.Default.TestConnectionString, query, parameters);

                Assert.IsTrue(results != null);
                Assert.IsTrue(results.FirstOrDefault().VIName == "Test One Election");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed to run. ex[{ex.Message}] inner ex[{ex.InnerException}]");
            }
        }

        /// <summary>
        /// Test add new address to database
        /// </summary>
        [Test]
        public void AddVotingInstance_ValidateCall()
        {
            try
            {
                VotingInstanceViewModel instanceToAdd = new VotingInstanceViewModel()
                {
                    AddressId = 1,
                    CurrentlyInUse = 0,
                    VIDescription = "Unit Test for adding and deleting  a voting instance",
                    VIName = "Unit Test Election"
                };

                string insertScript = "INSERT INTO [VotingInstance] ([VIName], [ViDescription], [AddressId], [CurrentlyInUse]) " +
                                        "VALUES (@VIName, @ViDescription, @AddressId, @CurrentlyInUse); SELECT last_insert_rowid();";

                var parameters = new DynamicParameters();
                parameters.Add("@VIName", instanceToAdd.VIName);
                parameters.Add("@ViDescription", instanceToAdd.VIDescription);
                parameters.Add("@AddressId", instanceToAdd.AddressId);
                parameters.Add("@CurrentlyInUse", instanceToAdd.CurrentlyInUse);

                int rtnInstanceId = _ThisSQLAccessLayer.ExecuteScalar_CreateT(Properties.Settings.Default.TestConnectionString, insertScript, parameters);

                Assert.IsTrue(rtnInstanceId != 0);

                if (rtnInstanceId != 0)
                {
                    // Delete the voting instance
                    // --------------------------
                    string query = "DELETE FROM [VotingInstance] WHERE [VotingInstanceId] = @VotingInstanceId";
                    parameters = new DynamicParameters();
                    parameters.Add("@VotingInstanceId", rtnInstanceId);

                    _ThisSQLAccessLayer.ExecuteSQL_ReturnNothing(Properties.Settings.Default.TestConnectionString, query, parameters);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed to run. ex[{ex.Message}] inner ex[{ex.InnerException}]");
            }

        }
        #endregion

        #region Private Data Methods
        /// <summary>
        /// Load a list of test users 
        /// These should match the records in the test database
        /// </summary>
        /// <returns>List test User data</returns>
        public List<VotingInstanceViewModel> GetSampleUsers()
        {
            List<VotingInstanceViewModel> rtnList = new List<VotingInstanceViewModel>()
            {
                new VotingInstanceViewModel()
                {
                        AddressId = 6,
                        CurrentlyInUse = 0,
                        VIDescription = "Test data for election one",
                        VIName = "Test One Election",
                        VotingInstanceId = 1
                },
                new VotingInstanceViewModel()
                {
                        AddressId = 7,
                        CurrentlyInUse = 0,
                        VIDescription = "Test data for a second election",
                        VIName = "Test Two Election",
                        VotingInstanceId = 2
                },
                new VotingInstanceViewModel()
                {
                        AddressId = 8,
                        CurrentlyInUse = 1,
                        VIDescription = "Test data for a Third election",
                        VIName = "Test Third Election",
                        VotingInstanceId = 3
                }
            };
            return rtnList;
        }

        #endregion
    }
}
