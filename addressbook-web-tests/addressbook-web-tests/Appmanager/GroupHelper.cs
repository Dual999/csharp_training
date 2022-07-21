using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;


namespace webaddressbooktests
{
    public class GroupHelper : HelperBase
    {

             public GroupHelper(ApplicationManager manager)
            :base(manager)
        {
          
        }

        public GroupHelper Remove(int v)
        {
            manager.Navigator.Gotogroppage();
            SelectGroup(v);
            Deletegroup();
            ReturnToGropsPage();
            return this;
        }

        // для группы 
        public GroupHelper Fillgropform(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
  
            return this;
        }

        public List<GroupData> GetGroupList()
        {

            List<GroupData> groups = new List<GroupData>();
            manager.Navigator.Gotogroppage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
            foreach (IWebElement element in elements)
            {
                groups.Add(new GroupData(element.Text));
            }
            return groups;
        }

        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.Gotogroppage();
            Initgropscreation();
            Fillgropform(group);
            SubmitGropCreation();
            ReturnToGropsPage();
            return this;
        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator.Gotogroppage();
            SelectGroup(v);
            InitGroupModification();
            Fillgropform(newData);
            SubmitgroupModification();
            ReturnToGropsPage();
            return this;

        }

        private GroupHelper SubmitgroupModification()
        {

            driver.FindElement(By.Name("update")).Click();
            return this;

        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        // для группы 
        public GroupHelper SubmitGropCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;

        }
        // для группы 
        public GroupHelper ReturnToGropsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;

        }
        // для группы 
        public GroupHelper Initgropscreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;

        }
        // для удаления группы 
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//input[@name='selected[]'][" + (index+1) + "]")).Click();
            return this;

        }
        // для удаления группы 
        public GroupHelper Deletegroup()
        {
            driver.FindElement(By.Name("delete")).Click(); 
            return this;

        }

    }
}
