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
    public class HelperBase
    {
        protected IWebDriver driver;
        protected ApplicationManager manager;
        
        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }

     
        public void Type(By localor, string text)
        {
            if (text != null)
            {
                driver.FindElement(localor).Clear();
                driver.FindElement(localor).SendKeys(text);
            }

        }
    }
}