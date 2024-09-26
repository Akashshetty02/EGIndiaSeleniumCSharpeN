using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.DataDrivenTesting
{
    internal class TestPartUsingTestcase
    {
        [TestCase("abc.com", "ghhjj")]
        [TestCase("ghh.com", "fghhj")]
        [TestCase("mkk.com", "ddffg")]
        public void LoginTest(string username, string password)
        {
            Thread.Sleep(2000)
            Console.WriteLine(username + ":" + password);
        }
    }
}
