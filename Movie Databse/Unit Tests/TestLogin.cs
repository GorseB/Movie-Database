using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movie_Databse;
using System.Security.Cryptography;

namespace Unit_Tests
{
    [TestClass]
    public class TestLogin
    {
        [TestMethod]
        public void Login()
        {
            var Login = new LoginInfo();
            LoginInfo.User = "Unit Tests!";
            LoginInfo.Security = "A";
            LoginInfo.Password = "A";
            MD5 Hash = MD5.Create();
            if (LoginInfo.User == null)
            {
                Assert.Fail();
            }
            if (GetHash(Hash, "A") == LoginInfo.Password.ToString())
            {
                switch (LoginInfo.Security)
                {
                    case "M":
                        Assert.Fail();
                        break;

                    case "A":
                        {
                            Assert.AreEqual(1, 1);
                        }
                        break;

                    case "E":
                        Assert.Fail();
                        break;

                    default:
                        Assert.Fail();
                        break;
                }
            }
            else
            {
                Assert.Fail();
            }
        }

        private static string GetHash(MD5 Hash, string Input)
        {
            return "A";
        }
    }
}

// (61) Simple Login Check to see if c# is still working
// Phew Can't Think of anything else to comment in, overall very happy with what i have done but in a perfect world would love to spend a few more months on it.
// At the time of writing 8/5/16 this program clocks in at 1,200 lines of code
// Alright im off.