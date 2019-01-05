using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiOauthDemo.Controllers;

namespace WebApiOauthDemo.Tests
{
    [TestClass]
    public class TestHomeController
    {
        HomeController home = new HomeController();
    
        [TestMethod]
        public void TestAdd()
        {
            int x = 5;
            int y = 2;

            Assert.AreEqual(7, home.Add(x, y));
            Assert.AreNotEqual(6, home.Add(x, y));
        }

        [TestMethod]
        public void TestAddFail()
        {
            int x = 5;
            int y = 2;

            Assert.AreEqual(6, home.Add(x, y));
        }
    }
}
