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
    public class GroupHelper :HelperBase
    {

       public GroupHelper(IWebDriver driver) :base(driver)
        {
          
        }
        
        // для группы 
        public void Fillgropform(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }
        // для группы 
        public void SubmitGropCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
        // для группы 
        public void ReturnToGropsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        // для группы 
        public void Initgropscreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }
        // для удаления группы 
        public void SelectGruop(int index)
        {
            driver.FindElement(By.XPath("//input[@name='selected[]'][" + index + "]")).Click();
        }
        // для удаления группы 
        public void Deletegroup()
        {
            //driver.FindElement(By.Name("delete")).Click(); - альтернативный вариант (как в примере)
            driver.FindElement(By.XPath("//input[5]")).Click();
        }

    }
}
