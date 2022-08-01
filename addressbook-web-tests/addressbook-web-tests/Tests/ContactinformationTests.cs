using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace webaddressbooktests.Tests
{

    [TestFixture]
    class ContactinformationTests: AuthTestBase
    {

        [Test]

        public void TestContactInformation()
        {

            ContactData fromTable = app.Contacts.GetContactInformationFromTable(0);
            ContactData fromForm = app.Contacts.GetContactInformationEditForm(0);


            //verification


            Assert.AreEqual(fromTable, fromForm);
            Assert.AreEqual(fromTable.Address, fromForm.Address);
            Assert.AreEqual(fromTable.AllPhones, fromForm.AllPhones);
        }


        [Test]


        public void TestContactInformationDetails()
        {
            ContactData fromForm = app.Contacts.GetContactInformationEditForm(0);
            ContactData fromDetails = app.Contacts.GetContactInformationFormDetails(0);

            //verification

            Assert.AreEqual(fromForm, fromDetails );
            Assert.AreEqual(fromDetails.Address, fromForm.Address);
            Assert.AreEqual(fromDetails.AllPhones, fromForm.AllPhones);

        }

    }
}
