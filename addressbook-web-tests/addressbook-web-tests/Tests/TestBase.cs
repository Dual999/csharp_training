using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace webaddressbooktests
{
    public class TestBase
    {

        protected ApplicationManager app;
        protected IWebDriver driver;
        protected string baseURL;

        [SetUp]
        public void SetupTest()
        {
           app = ApplicationManager.GetInstance();
            //app = TestSuiteFixture.app;
            //  app = new ApplicationManager();
            // app.Navigator.OpenHomePage();
            //app.Auth.Login(new AccountData("admin", "secret"));
        }

       // [TearDown]

        //public void Teardowntest()
        //{
        //    app.Stop();
        //}
    }
}