﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace webaddressbooktests
{
    public class TestBase
    {

        protected ApplicationManager app;
        //protected IWebDriver driver;
        //protected string baseURL;

        [SetUp]
        public void SetupApplecationManager()
        {
            app = ApplicationManager.GetInstance();


        }
        public static  Random rnd = new Random();
        public static string GenerateRandomString(int max)
        {
            int l = Convert.ToInt32(rnd.NextDouble() * max);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < l; i++)
            {
                builder.Append(Convert.ToChar(32 + Convert.ToInt32(rnd.NextDouble() * 223 )));
            }

          return  builder.ToString();
        }

    }
}