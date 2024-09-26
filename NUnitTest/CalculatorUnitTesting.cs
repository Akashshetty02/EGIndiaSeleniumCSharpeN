using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    internal class CalculatorUnitTesting
    {
        Calculator Calculator = new Calculator();
        [Test]
        public void AddTest()
        {
            int result = Calculator.Add(2, 3);
            int result1= Calculator.Add(3, 4);

            Assert.AreEqual(5, result);
            Assert.AreEqual(7, result1);


        }
    }
}
