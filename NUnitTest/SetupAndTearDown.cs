﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    internal class SetupAndTearDown
    {
        [SetUp]
        public void Setup() {
            Console.WriteLine("Launching chrome browser");

        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing chrome browser");
        }

        [Test, Order(1)]
        public void Login()
        {
            Console.WriteLine("Login successful");

        }
        [Test, Order(2)]
        public void Logout()
        {
            Console.WriteLine("Logout successful");

        }
        [Test, Order(3)]
        public void products()
        {
            Console.WriteLine("Products");

        }
        [Test, Order(4)]
        public void AddCart()
        {
            Console.WriteLine("Products");

        }
    }
}
