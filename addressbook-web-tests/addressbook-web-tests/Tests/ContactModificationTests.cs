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
    class ContactModificationTests :TestBase
    {
        [Test]
        public void ContactModificationtest()
        {
            ContactData newData = new ContactData();
            newData.Name = "111";
            newData.Lname = "222";
            newData.Nick = null;
            newData.Comp = "444";
            newData.Hom = null;
            newData.Place = null;

            app.Contacts.Modify(1, newData);

        }
    }
}
