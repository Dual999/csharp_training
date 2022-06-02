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
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData();
            contact.Name = "Alexandr";
            contact.Lname = "Dubynin";
            contact.Nick = "Aldu";
            contact.Comp = "Ascon";
            contact.Hom = "18";
            contact.Place = "Dolina";

            app.Contacts.Create(contact);
 
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData();
            contact.Name = "";
            contact.Lname = "";
            contact.Nick = "";
            contact.Comp = "";
            contact.Hom = "";
            contact.Place = "";

            app.Contacts.Create(contact);

        }
    }
}