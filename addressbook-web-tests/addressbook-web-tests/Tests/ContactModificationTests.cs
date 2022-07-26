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
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationtest()
        {
            ContactData newData = new ContactData();
            newData.Fname = "111";
            newData.Lname = "222";
            newData.Nick = null;
            newData.Comp = "444";
            newData.Hom = null;
            newData.Place = null;



            List<ContactData> oldContacts = app.Contacts.GetContactsList();

            ContactData oldData = oldContacts[0];
            app.Contacts.Modify(0, newData);

            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactsCount());

            List<ContactData> newcontact = app.Contacts.GetContactsList();
            oldContacts[0].Fname = newData.Fname;
            oldContacts[0].Lname = newData.Lname;
            oldContacts.Sort();
            oldContacts.Sort();
            Assert.AreEqual(oldContacts, newcontact);

            foreach (ContactData contact in newcontact)
            { 
            
                if (contact.id == oldData.id)
                    {
                    Assert.AreEqual(oldContacts, newcontact);

                }
            }
        }
    }
}
