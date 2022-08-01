using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using System.Linq;

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
            Task.Delay(5000).Wait();
            Assert.AreEqual(oldContacts.Count - 1, app.Contacts.GetContactsCount());

            List<ContactData> NewContact = app.Contacts.GetContactsList();

            ContactData oldtData = oldContacts[0];
            
             oldContacts.RemoveAt(0);

            Assert.AreEqual(oldContacts, NewContact);

            foreach (ContactData contact in NewContact)
            {

                Assert.AreNotEqual(contact.id, oldtData.id);

            }


        }


    }
}
