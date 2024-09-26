using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {
        [Test]
        public void login()
        {
            Console.WriteLine("Logging into application");

        }
        [Test]
        public void products()
        {
            Console.WriteLine("its product");

        }
        [Test]
        public void addtocart()
        {
            Console.WriteLine("product added to cart");
        }
    }
}
