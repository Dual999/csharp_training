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
    public class ContactHelper : HelperBase
    {
              public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
            
        }

        public ContactHelper Remove(int v)
        {
            SelectContacts(v);
            Deletecontact();
            SubmitContactDelete();
            return this;
        }

        private void SubmitContactDelete()
        {
            //Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            driver.SwitchTo().Alert().Accept();
        }

        private ContactHelper Deletecontact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper SelectContacts(int index)
        {
            driver.FindElement(By.XPath("//input[@name='selected[]'][" + index + "]")).Click();
            return this;
        }
        // для удаления 
        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper Modify(int v, ContactData newData)
        {
            InitContactModification();
            FillContactForm(newData);
            SubmitContactModification();
            ReturnToHomePage();
            return this;
        }
        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.CssSelector("img[alt=Edit]")).Click();

              return this;
        }
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();

            return this;
        }
        public ContactHelper Create(ContactData contact)
        {
            InitContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToHomePage();
            return this;
        }
        // для контакта
        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Name);
            Type(By.Name("lastname"), contact.Lname);
            Type(By.Name("nickname"), contact.Nick);
            Type(By.Name("company"), contact.Comp);
            Type(By.Name("home"), contact.Hom);
            Type(By.Name("work"), contact.Place);
             return this;
        }

        // для контакта
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }
        // для контакта
        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }
    }
}
