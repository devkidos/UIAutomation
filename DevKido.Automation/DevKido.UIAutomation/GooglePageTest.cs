using System;
using System.Threading;
using DevKido.Automation.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DevKido.UIAutomation
{
    [TestClass]
    public class GooglePageTest
    {
        [TestMethod]
        public void CheckGooglePage()
        {
            var returnValue = GooglePage.CheckGooglePage();
            var expectedValue = "Gmail";
            Assert.AreEqual(expectedValue, returnValue);
        } 
    }
}
