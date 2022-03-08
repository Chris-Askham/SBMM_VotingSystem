using SBMMVotingSystem.Managers;
using SBMMVotingSystem.Models;
using Autofac.Extras.Moq;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Moq;
using NUnit.Framework;
using SBMMVotingSystem.DAL;

namespace SbmmVotingSystem_UnitTest
{
    [TestFixture]
    public class AddressManager_UnitTests
    {
        #region Constructor
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }
        public AddressManager_UnitTests()
        {
            _ThisSQLAccessLayer = new SQLAccessLayer();
        }
        #endregion

        #region Test Database calls
        /// <summary>
        /// Test the database connection 
        /// Using the test database see if the SQLAccessLayer can get a specific address
        /// </summary>
        [Test]
        public void LoadAddressForId_ValidateCall()
        {
            try
            {
                AddressDBModel addressFromTestData = GetSampleAddress()[2];

                string testQuery = "SELECT * FROM [Address] WHERE [AddressId] = @AddressId";
                var parameters = new DynamicParameters();
                parameters.Add("@AddressId", addressFromTestData.AddressId);

                AddressDBModel addressFromDb = _ThisSQLAccessLayer.LoadAddress(Properties.Settings.Default.TestConnectionString, testQuery, parameters);

                Assert.IsTrue(addressFromDb != null);
                Assert.IsTrue(addressFromDb.AddressLine1 == addressFromTestData.AddressLine1);
                Assert.IsFalse(addressFromDb.Postcode == null);
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
        public void AddAddress_ValidateCall()
        {
            try
            {
                AddressDBModel addressToAdd = new AddressDBModel()
                {
                    AddressLine1 = "999 Test Avenue",
                    AddressLine2 = "Test AD2",
                    City = "Test AD3",
                    Country = "Test UK",
                    Postcode = "AddedByVSTest",
                };

                string insertScript = @"INSERT INTO [Address] ([AddressLine1], [AddressLine2], [City], [Country], [Postcode]) " +
                                        "VALUES (@AddressLine1, @AddressLine2, @City, @Country, @PostCode); SELECT last_insert_rowid();";

                var parameters = new DynamicParameters();
                parameters.Add("@AddressLine1", addressToAdd.AddressLine1);
                parameters.Add("@AddressLine2", addressToAdd.AddressLine2);
                parameters.Add("@City", addressToAdd.City);
                parameters.Add("@Country", addressToAdd.Country);
                parameters.Add("@Postcode", addressToAdd.Postcode);

                int rtnAddressId = _ThisSQLAccessLayer.ExecuteScalar_CreateT(Properties.Settings.Default.TestConnectionString, insertScript, parameters);

                Assert.IsTrue(rtnAddressId != 0);

                if (rtnAddressId != 0)
                {
                    // Delete the address
                    // ------------------
                    string query = "DELETE FROM [Address] WHERE [AddressId] = @AddressId";

                    parameters = new DynamicParameters();
                    parameters.Add("@AddressId", rtnAddressId);
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
        /// Load a list of test addresses 
        /// These should match the records in the test database
        /// </summary>
        /// <returns>List test User data</returns>
        private List<AddressDBModel> GetSampleAddress()
        {
            List<AddressDBModel> rtnList = new List<AddressDBModel>()
            {
                new AddressDBModel()
                {
                    AddressId = 1,
                     AddressLine1 = "123 Test Street",
                      AddressLine2 = "Test",
                       City = "Testing",
                        Country = "UK",
                      Postcode = "Tester",
                },
                new AddressDBModel()
                {
                    AddressId = 2,
                     AddressLine1 = "123 Test Road",
                       AddressLine2 = "Test1 AD2",
                       City = "Test1 AD3",
                        Country = "Test1 UK",
                      Postcode = "PC1 Test1",
                },
                new AddressDBModel()
                {
                    AddressId = 3,
                     AddressLine1 = "456 Test Avenue",
                      AddressLine2 = "Test2 AD2",
                       City = "Test2 AD3",
                        Country = "Test2 UK",
                      Postcode = "PC1 Test2",
                },
                new AddressDBModel()
                {
                    AddressId = 4,
                     AddressLine1 = "789 Test Avenue",
                      AddressLine2 = "Test3 AD2",
                       City = "Test3 AD3",
                        Country = "Test3 UK",
                      Postcode = "PC1 Test3",
                },
                new AddressDBModel()
                {
                    AddressId = 5,
                     AddressLine1 = "951 Test One Road",
                      AddressLine2 = "AD2 Test E One",
                       City = "AD3 Test E One",
                        Country = "UK Test E One",
                      Postcode = "PC Test E One ",
                },
                new AddressDBModel()
                {
                    AddressId = 6,
                     AddressLine1 = "753 Test Two Street",
                       AddressLine2 = "AD2 Test Two",
                       City = "AD3 Test Two",
                        Country = "Uk Test Two",
                      Postcode = "PC Test Two",
                },
                new AddressDBModel()
                {
                    AddressId = 7,
                     AddressLine1 = "467 Test Three Avenue",
                      AddressLine2 = "AD2 Test Three",
                       City = "AD3 Test Three",
                        Country = "UK Test Three",
                      Postcode = "PC1 Test Three",
                },
            };
            return rtnList;
        }
        #endregion
    }
}
