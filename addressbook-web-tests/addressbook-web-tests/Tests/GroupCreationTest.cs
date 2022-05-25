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
    public class GroupCreationTests : TestBase
    {
         [Test]
        public void GroupCreationTest()
        {
            applicationManager.Navigator.OpenHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Navigator.Gotogroppage();
            applicationManager.Groups.Initgropscreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            applicationManager.Groups.Fillgropform(group);
            applicationManager.Groups.SubmitGropCreation();
            applicationManager.Groups.ReturnToGropsPage();
        }
                           
    }
}
