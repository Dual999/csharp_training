using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;


namespace webaddressbooktests.Tests
{

    [TestFixture]

    public class RemoveContactTests : AuthTestBase
    {

        [Test]
        public void ContactRemoveTest()
        {

            List<ContactData> oldContacts = app.Contacts.GetContactsList();

            app.Contacts.Remove(0);

            List<ContactData> NewContact = app.Contacts.GetContactsList();

            oldContacts.RemoveAt(0);
            Assert.AreEqual(oldContacts, NewContact);
        }


    }
}
