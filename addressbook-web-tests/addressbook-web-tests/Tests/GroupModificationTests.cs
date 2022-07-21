using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace webaddressbooktests.Tests
{

    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
    public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = "vvv";
            newData.Footer = "bbb";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Modify(1, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
