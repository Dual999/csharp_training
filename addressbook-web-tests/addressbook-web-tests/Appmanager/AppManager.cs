using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        private static ApplicationManager instance;

        private ApplicationManager()
        {
            driver = new ChromeDriver();
            baseURL = ("http://10.63.5.184/addressbook");
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);

        }

        public static ApplicationManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ApplicationManager();
            }
            return instance;

        
        }
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
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