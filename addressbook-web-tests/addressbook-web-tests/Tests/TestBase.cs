using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace webaddressbooktests
{
    public class TestBase
    {

        protected ApplicationManager app;
        //protected IWebDriver driver;
        //protected string baseURL;

        [SetUp]
        public void SetupApplecationManager()
        {
            app = ApplicationManager.GetInstance();


        }


    }
}