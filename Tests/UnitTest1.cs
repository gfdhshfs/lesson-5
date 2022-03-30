using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Library.LoginServise;
using Library;

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
