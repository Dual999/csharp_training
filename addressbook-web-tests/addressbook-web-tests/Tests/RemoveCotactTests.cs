using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;


namespace webaddressbooktests.Tests
{

    [TestFixture]

    public class RemoveContactTests : TestBase
    {

        [Test]
        public void ContactRemoveTest()
        {
            app.Contacts.Remove(1);

        }


    }
}
