using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class Description
    {
        [Test]
        [Description("Testcase verifies the login functionality with valid credentials")]
        public void testcase()
        {
            Console.WriteLine("Desc");
        }
    }

}
