using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{

    [Allure.NUnit.AllureNUnit]
    internal class Assertion
    {
        [Test]
        public void Test()
        {
            string actual = "google";
            string expected = "yahoo";
           /* if (actual == expected)
            {
                Console.WriteLine("The result is matching");

            }
            else
            {
                Console.WriteLine("The result are not matching");
            }*/
           Assert.AreEqual(expected,actual);
            

            Assert.That(actual,Is.EqualTo(expected).IgnoreCase);

            
        }
    }
}