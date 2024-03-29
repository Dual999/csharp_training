﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace webaddressbooktests
{
    public class LoginHelper : HelperBase
    {


        public LoginHelper(ApplicationManager manager)

          : base(manager)
        {

        }

        public void Login(AccountData account)
        {
            if (IsLoggedIn()) 
            {

                if (IsLoggedIn(account)) 
                {
                    return;
                }

                Logout();
            }
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            //driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
            && GetLoggetName() == account.Username;

            
        }

        public string GetLoggetName()
        {
            string text = driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text;
            return text.Substring(1, text.Length - 2);
   
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {

                driver.FindElement(By.LinkText("Logout")).Click();
            }
        }
    }
}
