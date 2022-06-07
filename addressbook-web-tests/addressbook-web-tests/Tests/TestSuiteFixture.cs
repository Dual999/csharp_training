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
        

        [SetUp]
        public void InitApplicationManager()
        {
            // app = new ApplicationManager();
            ApplicationManager app = ApplicationManager.GetInstance();
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void StopApplicationManager()
        {
            ApplicationManager.GetInstance().Stop();  
            //app.Stop();
         }
}     
}
