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


        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}