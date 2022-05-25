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
    [TestFixture]
    public class RemoeveGroupTests : TestBase
    {
         [Test]
        public void GroupremoveTest()
        {
            applicationManager.Navigator.OpenHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Navigator.Gotogroppage();
            applicationManager.Groups.SelectGruop(1);
            applicationManager.Groups.Deletegroup();
            applicationManager.Groups.ReturnToGropsPage();
        }
               

        }
}
