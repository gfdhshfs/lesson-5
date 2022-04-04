using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestLoginMethod()
        {
            var login = "admin";
            var password = "admin";

            var LoginStatus = LoginServise.Login(login, password);
        }
    }
}
