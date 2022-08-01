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
        public static IEnumerable<ContactData> RandomContactDataProvider()
        {

            List<ContactData> contancts = new List<ContactData>();
            for (int i = 0; i < 5; i++)

            {
                contancts.Add(new ContactData(GenerateRandomString(30))
                {
                    Fname = GenerateRandomString(100),
                    Lname = GenerateRandomString(100),
                    Address = GenerateRandomString(100),
                    HomePhone = GenerateRandomString(100),
                    MobilePhone = GenerateRandomString(100),
                    WorkPhone = GenerateRandomString(100)
                });
            }
            return contancts;
        }
        [Test, TestCaseSource("RandomContactDataProvider")]
        public void ContactCreationTest(ContactData contact)
        {
            //ContactData contact = new ContactData();
            //contact.Fname = "Alexandr";
            //contact.Lname = "Dubynin";
            //contact.Nick = "Aldu";
            //contact.Comp = "Ascon";
            //contact.HomePhone = "111111";
            //contact.MobilePhone = "222222";
            //contact.WorkPhone = "333333333";

            List<ContactData> oldContacts = app.Contacts.GetContactsList();


            app.Contacts.Create(contact);

            Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactsCount());

            List<ContactData> newcontact = app.Contacts.GetContactsList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            oldContacts.Sort();

            Assert.AreEqual(oldContacts, newcontact);
        }

        //[Test]
        //public void EmptyContactCreationTest()
        //{
        //    ContactData contact = new ContactData();
        //    contact.Fname = "";
        //    contact.Lname = "";
        //    contact.Nick = "";
        //    contact.Comp = "";
        //    contact.HomePhone = "";
        //    contact.Place = "";

        //    List<ContactData> oldContacts = app.Contacts.GetContactsList();

        //    app.Contacts.Create(contact);

        //    Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactsCount());

        //    List<ContactData> newcontact = app.Contacts.GetContactsList();
        //    oldContacts.Add(contact);
        //    oldContacts.Sort();
        //    oldContacts.Sort();
        //    Assert.AreEqual(oldContacts, newcontact);

        //}
    }
}