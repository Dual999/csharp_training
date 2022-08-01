using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
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


        public ContactHelper initContactDetails(int index)
        {
            driver.FindElements(By.Name("entry"))[index]
               .FindElements(By.TagName("td"))[6]
               .FindElement(By.TagName("a")).Click();
            return this;
        }


        internal ContactData GetContactInformationFormDetails(int index)
        {
            manager.Navigator.OpenHomePage();
            initContactDetails(0);
            // IList<IWebElement> data = driver.FindElements(By.TagName("content"))[index].FindElements(By.TagName("#text"));

            // бла бла бла
            //string lastname = driver.FindElement(By.Name("content")).GetAttribute("#text");
            //string firstname = data[2].Text;
            //string address = data[3].Text;
            //string allPhones = data[5].Text;

            IWebElement data = driver.FindElement(By.Id("content"));

            string text = data.Text;

            string[] datas = text.Split();

            string lastname = datas[1];
            string firstname = datas[0];
            string address = datas[7];
            string allPhones = datas[12] + "\r\n" + datas[15];

            return new ContactData(firstname, lastname)
            {
                Address = address,
                AllPhones = allPhones,
            };
        }

 
        internal ContactData GetContactInformationFromTable(int index)
        {
            manager.Navigator.OpenHomePage();
            IList<IWebElement> cells = driver.FindElements(By.Name("entry"))[index]
             .FindElements(By.TagName("td"));
            string lastname = cells[1].Text;
            string firstname = cells[2].Text;
            string address = cells[3].Text;
            string allPhones = cells[5].Text;

            return new ContactData(firstname, lastname)
            {
                Address = address,
                AllPhones = allPhones,
            };

        }

 

        internal ContactData GetContactInformationEditForm(int index)
        {
            manager.Navigator.OpenHomePage();
            InitContactModification(0);
            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string address = driver.FindElement(By.Name("address")).GetAttribute("value");

            string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");

            return new ContactData(firstName, lastName)
            {
                Address = address,
                HomePhone = homePhone,
                MobilePhone = mobilePhone,
                WorkPhone = workPhone
            };
        }

        public int GetNumberOfSearchResults()
        {
            manager.Navigator.OpenHomePage();
            string text =  driver.FindElement(By.TagName("label")).Text;
            Match m =  new Regex(@"\d+").Match(text);
           return Int32.Parse(m.Value);
        }
        public ContactHelper Remove(int v)
        {
            manager.Navigator.OpenHomePage();
            SelectContacts(v);
            Deletecontact();
            SubmitContactDelete();
            return this;
        }

        public ContactHelper SubmitContactDelete()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public int GetContactsCount()
        {
            return driver.FindElements(By.Name("selected[]")).Count;
        }

        private List<ContactData> contactCache = null;

        public List<ContactData> GetContactsList()
        {
           if (contactCache == null)
            {
                contactCache = new List<ContactData>();
                manager.Navigator.OpenHomePage();
                ICollection<IWebElement> elements = driver.FindElements(By.Name("entry"));
                foreach (IWebElement element in elements)
                {
                     var tds = element.FindElements(By.TagName("td"));
                    contactCache.Add(new ContactData(tds[2].Text, tds[1].Text)
                    {
                        id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }
                
            }

                return new List<ContactData>(contactCache);
        }

        public ContactHelper Deletecontact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper SelectContacts(int index)
        {
            driver.FindElement(By.XPath("//input[@name='selected[]'][" + (index + 1) + "]")).Click();
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
            InitContactModification(0);
            FillContactForm(newData);
            SubmitContactModification();
            ReturnToHomePage();
            return this;
        }
        public ContactHelper InitContactModification(int index)
        {
            //  driver.FindElement(By.CssSelector("img[alt=Edit]")).Click();
            driver.FindElements(By.Name("entry"))[index]
                .FindElements(By.TagName("td"))[7]
                .FindElement(By.TagName("a")).Click();
              return this;
        }
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            contactCache = null;
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
            Type(By.Name("firstname"), contact.Fname);
            Type(By.Name("lastname"), contact.Lname);
            Type(By.Name("nickname"), contact.Nick);
            Type(By.Name("company"), contact.Comp);
            Type(By.Name("home"), contact.HomePhone);
            Type(By.Name("work"), contact.WorkPhone);
            Type(By.Name("mobile"), contact.MobilePhone);
            return this;
        }

        // для контакта
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            contactCache = null;
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
