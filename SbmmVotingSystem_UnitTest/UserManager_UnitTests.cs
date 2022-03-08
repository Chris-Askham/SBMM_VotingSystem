using Autofac.Extras.Moq;
using Dapper;
using NUnit.Framework;
using SBMMVotingSystem.DAL;
using SBMMVotingSystem.Managers;
using SBMMVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SbmmVotingSystem_UnitTest
{
    [TestFixture]
    public class UserManager_UnitTests
    {
        #region Constructor
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }
        public UserManager_UnitTests()
        {
            _ThisSQLAccessLayer = new SQLAccessLayer();
        }
        #endregion

        #region Test Password Methods
        /// <summary>
        /// Test password validation
        /// Test validation by validating the passwrod for test user one
        /// Password provided is correct so expected outcome is true
        /// </summary>
        [Test]
        public void InvokeVerifyPassword_PasswordValid_ReturnTrue()
        {
            try
            {
                UserManager _thisUserManager = new UserManager(_ThisSQLAccessLayer);

                // Arrange
                // -------
                string password = "passwordtestone";
                string passwordHash = "f4qJU4vJDF/pcoypq3OLbyMjfNLVYMw6meWNGpO+f5f8IRjz";

                // Act
                // ---
                bool result = _thisUserManager.InvokeVerifyPassword(password, passwordHash);

                // Assert
                // ------
                Assert.IsTrue(result);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed to run. ex[{ex.Message}] inner ex[{ex.InnerException}]");
            }
        }

        /// <summary>
        /// Test password validation
        /// Test validation by validating the passwrod for test user one
        /// Password provided is wrong so expected outcome is false
        /// </summary>
        [Test]
        public void InvokeVerifyPassword_PasswordInValid_ReturnFalse()
        {
            try
            {
                UserManager _thisUserManager = new UserManager(_ThisSQLAccessLayer);
                string password = "passwordtesttwo";
                string passwordHash = "f4qJU4vJDF/pcoypq3OLbyMjfNLVYMw6meWNGpO+f5f8IRjz";

                bool result = _thisUserManager.InvokeVerifyPassword(password, passwordHash);

                Assert.IsFalse(result);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed to run. ex[{ex.Message}] inner ex[{ex.InnerException}]");
            }
        }
        #endregion

        #region Test Database calls
        /// <summary>
        /// Test the database connection 
        /// Using the test database see if the SQLAccessLayer can get a list of users
        /// </summary>
        [Test]
        public void LoadUsers_ValidateCall()
        {
            try
            {
                List<SuperUserViewModel> usersFromTestData = GetSampleUsers();
                string testQuery = "SELECT * FROM User ";

                List<SuperUserViewModel> usersFromDb = _ThisSQLAccessLayer.LoadUsers(Properties.Settings.Default.TestConnectionString, testQuery, new DynamicParameters()).ToList();

                Assert.IsTrue(usersFromDb != null);
                Assert.AreEqual(usersFromTestData.Count, usersFromDb.Count);
                Assert.IsTrue(usersFromDb.FirstOrDefault(u => u.FirstName == "admin").LastName == "admin");
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
        public List<SuperUserViewModel> GetSampleUsers()
        {
            List<SuperUserViewModel> rtnList = new List<SuperUserViewModel>()
            {
                new SuperUserViewModel()
                {
                     FirstName = "admin",
                      LastName = "admin",
                       AddressId = 1,
                        Age = 33,
                         RefNumber = "000"
                },
                new SuperUserViewModel()
                {
                     FirstName = "Test One",
                      LastName = "User",
                       AddressId = 3,
                        Age = 25,
                         RefNumber = "Test123"
                },
                new SuperUserViewModel()
                {
                     FirstName = "Test Two",
                      LastName = "User",
                       AddressId = 4,
                        Age = 30,
                         RefNumber = "Test456"
                },
                new SuperUserViewModel()
                {
                     FirstName = "Test Three",
                      LastName = "User",
                       AddressId = 5,
                        Age = 35,
                         RefNumber = "Test789"
                }
            };
            return rtnList;
        }

        #endregion
    }
}
