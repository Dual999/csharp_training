using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;


namespace webaddressbooktests
{
    public class ApplicationManager
    {

        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;


        public ApplicationManager() 
        {
            driver = new EdgeDriver();
            baseURL = ("http://10.63.5.184/addressbook");
            loginHelper = new LoginHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);

        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get 
            { return loginHelper; }
        }
        public NavigationHelper Navigator
        {
            get
            { return navigationHelper; }
        }
        public GroupHelper Groups
        {
            get
            { return groupHelper; }
        }
        public ContactHelper Contacts
        {
            get
            { return contactHelper; }
        }
    }
}
