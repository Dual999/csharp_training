using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace webaddressbooktests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        public static ApplicationManager app;

        [SetUp]
        public void InitApplicationManager()
        {
           ApplicationManager app = ApplicationManager.Getinstance();
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

    }
}
