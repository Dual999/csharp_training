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
            applicationManager.Navigator.OpenHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Contacts.InitContactCreation();
            ContactData contact = new ContactData();
            contact.Name = "Alexandr";
            contact.Lname = "Dubynin";
            contact.Nick = "Aldu";
            contact.Comp = "Ascon";
            contact.Hom = "18";
            contact.Place = "Dolina";
            applicationManager.Contacts.FillContactForm(contact);
            applicationManager.Contacts.SubmitContactCreation();
            applicationManager.Contacts.RetutToHomePage();
        }
    }
}