using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace webaddressbooktests.Tests
{
    [TestFixture]
    public class RemoeveGroupTests : TestBase
    {
         [Test]
        public void GroupremoveTest()
        {
            app.Groups.Remove(1);
            
        }
               

        }
}
