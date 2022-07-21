using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace webaddressbooktests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]

        public void TestMethod1()
        {
            string[] s = new string[] { "i" , "want", "to", "sleep" };

            foreach (string element in s)
            {
                Console.Out.Write(element + "\n");
            }

        }
    }
}

