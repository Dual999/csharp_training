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
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData();
            contact.Fname = "Alexandr";
            contact.Lname = "Dubynin";
            contact.Nick = "Aldu";
            contact.Comp = "Ascon";
            contact.Hom = "18";
            contact.Place = "Dolina";

            List<ContactData> oldContacts = app.Contacts.GetContactsList();


            app.Contacts.Create(contact);

            List<ContactData> NewContact = app.Contacts.GetContactsList();
            Assert.AreEqual(oldContacts.Count + 1, NewContact.Count);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData();
            contact.Fname = "";
            contact.Lname = "";
            contact.Nick = "";
            contact.Comp = "";
            contact.Hom = "";
            contact.Place = "";

            List<ContactData> oldContacts = app.Contacts.GetContactsList();

            app.Contacts.Create(contact);


            List<ContactData> NewContact = app.Contacts.GetContactsList();
            Assert.AreEqual(oldContacts.Count + 1, NewContact.Count);

        }
    }
}