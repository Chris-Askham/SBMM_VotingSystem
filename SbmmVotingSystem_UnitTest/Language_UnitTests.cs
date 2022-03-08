using NUnit.Framework;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMMVotingSystem.DAL;
using SBMMVotingSystem.Managers;

namespace SbmmVotingSystem_UnitTest
{
    [TestFixture]
    public class Language_UnitTests
    {
        #region Constructor
        private ISQLAccessLayer _ThisSQLAccessLayer { get; set; }
        public Language_UnitTests()
        {
            _ThisSQLAccessLayer = new SQLAccessLayer();
        }
        #endregion

        /// <summary>
        /// Test the database connection 
        /// Using the test database see if the SQLAccessLayer can get a specific  language translation
        /// </summary>
        [Test]
        public void GetLanguageForId_ValidateCall()
        {
            try
            {
                int langaugeId = 14;

                string testQuery = "SELECT * FROM [Language] WHERE [Id] = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("@Id", langaugeId);

                string translatedLanguageFromDb = _ThisSQLAccessLayer.GetLocalisedString(Properties.Settings.Default.TestConnectionString,
                                                  testQuery,
                                                  parameters,
                                                  UserManager.LanguageOptions.FR);

                Assert.NotNull(translatedLanguageFromDb);
                Assert.IsTrue(translatedLanguageFromDb != "");
                Assert.IsTrue(translatedLanguageFromDb == "- Le mot de passe doit être plus long que 10 caractères");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed to run. ex[{ex.Message}] inner ex[{ex.InnerException}]");
            }
        }


        /// <summary>
        /// Testing getting a translation based on a keyword
        /// Using the test database see if the SQLAccessLayer can get a specific language translation
        /// </summary>
        [Test]
        public void GetTranslatedLanguageString_ValidateCall()
        {
            try
            {
                string translatedText = "Mot de passe";

                string testQuery = "SELECT * FROM [Language] WHERE [KeyWord] = @KeyWord";
                var parameters = new DynamicParameters();
                parameters.Add("@KeyWord", "lblPasswordHeader");

                string translatedLanguageFromDb = _ThisSQLAccessLayer.GetLocalisedString(Properties.Settings.Default.TestConnectionString,
                                                                               testQuery,
                                                                               parameters,
                                                                               UserManager.LanguageOptions.FR);

                Assert.NotNull(translatedLanguageFromDb);
                Assert.IsTrue(translatedLanguageFromDb != "");
                Assert.AreEqual(translatedLanguageFromDb, translatedText);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed to run. ex[{ex.Message}] inner ex[{ex.InnerException}]");
            }
        }

        /// <summary>
        /// Testing exception handling 
        /// Using the test database see if the SQLAccessLayer can get a specific language translation
        /// </summary>
        [Test]
        public void GetTranslatedLanguageString_Exception()
        {
            try
            {
                string translatedText = "Confirmez le mot de passe";

                string testQuery = "SELECT * FROM [Language] WHERE [KeyWord] = @KeyWord";
                var parameters = new DynamicParameters();
                parameters.Add("@KeyWord", "lblPasswordHeader");

                string translatedLanguageFromDb = _ThisSQLAccessLayer.GetLocalisedString(Properties.Settings.Default.TestConnectionString,
                                                                               testQuery,
                                                                               parameters,
                                                                               UserManager.LanguageOptions.FR);

                Assert.NotNull(translatedLanguageFromDb);
                Assert.AreNotEqual(translatedLanguageFromDb, translatedText);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed to run. ex[{ex.Message}] inner ex[{ex.InnerException}]");
            }

        }
    }
}
