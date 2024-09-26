using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [SetUpFixture]
    internal class OneTimeSetupTeardown
    {
        [OneTimeSetUp] 
        public void DBConnection() {
            TestContext.Progress.WriteLine("Connected");
        }

        [OneTimeTearDown]
        public void DBConnectionClose()
        {
            TestContext.Progress.WriteLine("Disconnected");
        }
    }
}
