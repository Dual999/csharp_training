﻿using System;
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
       : base(manager)
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

        private List<GroupData> groupCache = null;

        //public List<GroupData> GetGroupList()
        //{
        //    if (groupCache == null)
        //    {
        //        groupCache = new List<GroupData>();
        //        manager.Navigator.Gotogroppage();
        //        ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
        //        foreach (IWebElement element in elements)
        //        {
        //            groupCache.Add(new GroupData(element.Text) { id = element.FindElement(By.TagName("input")).GetAttribute("value")
        //            });
        //        }
        //    }

        //    return new List<GroupData>(groupCache);
        //}

        // сплит
        public List<GroupData> GetGroupList()
        {
            if (groupCache == null)
            {
                groupCache = new List<GroupData>();
                manager.Navigator.Gotogroppage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebElement element in elements)
                {
                    groupCache.Add(new GroupData(null)
                    {
                        id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }
                string allGroupNames = driver.FindElement(By.CssSelector("div#content form")).Text;
        string[] parts = allGroupNames.Split('\n');
        int shift = groupCache.Count - parts.Length;
        for (int i = 0; i<groupCache.Count; i++)
            {
            if (i<shift)
            {
                groupCache[i].Name = "";
             }
    else
            {

         groupCache[i].Name = parts[i - shift].Trim();
                }
            
            }
            }

            return new List<GroupData>(groupCache);
        }
        public int GetGroupCount()
        {
          return driver.FindElements(By.CssSelector("span.group")).Count;
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
            groupCache = null;
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
            groupCache = null;
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
            groupCache = null;
            return this;

        }

    }
}
