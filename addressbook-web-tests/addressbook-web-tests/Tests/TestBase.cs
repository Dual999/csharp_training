using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;


namespace webaddressbooktests
{
   public class TestBase 
    {
        protected ApplicationManager applicationManager;
        protected IWebDriver driver;
        protected string baseURL;

        [SetUp]

        public void SetupTest()
        {
            applicationManager = new ApplicationManager();
            
           
          }

        [TearDown]
        public void TeardownTest()
        {
            applicationManager.Stop();
        }
           
    }
}