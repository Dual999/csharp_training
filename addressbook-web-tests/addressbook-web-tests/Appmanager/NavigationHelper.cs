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
    public class NavigationHelper : HelperBase

    {
         private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) :base(manager)
        {
         this.baseURL = baseURL;
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("http://10.63.5.184/addressbook");
        }

        public void Gotogroppage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}

           
    

