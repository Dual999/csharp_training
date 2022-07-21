using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace webaddressbooktests.Tests
{
    [TestFixture]
    public class RemoeveGroupTests : AuthTestBase
    {
         [Test]
        public void GroupremoveTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(0);

            List<GroupData> NewGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, NewGroups);
                        
        }
               

        }
}
