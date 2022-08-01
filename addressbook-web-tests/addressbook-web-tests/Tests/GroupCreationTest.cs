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
    public class GroupCreationTests : AuthTestBase
    {
        public static IEnumerable<GroupData> RandomGroupDataProvider() 
        {

        List<GroupData> groups = new List<GroupData>();
            for (int i = 0; i < 5; i++) 
            
            {
            groups.Add(new GroupData(GenerateRandomString(30)) {
                    Header = GenerateRandomString(100),
                    Footer = GenerateRandomString(100)
            });
            }
            return groups;
        }



        [Test, TestCaseSource("RandomGroupDataProvider")]
        public void GroupCreationTest(GroupData group)
        {
            //GrouptData group = new groupData("aaaaa");
            //group.Header = "fffffff";
            //group.Footer = "zzzzzz";
 
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);
            Assert.AreEqual(oldGroups.Count + 1, app.Groups.GetGroupCount());

          List<GroupData> newGroups = app.Groups.GetGroupList();
          oldGroups.Add(group);
          oldGroups.Sort();
          newGroups.Sort();
          Assert.AreEqual(oldGroups, newGroups);
        }

    
        
    }
}
