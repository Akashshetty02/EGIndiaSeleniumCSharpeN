﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    internal class Calculator
    {
        //Addition
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        //substraction
        public int Substract(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public int Multiply(int a, int b)
        {
            int c = a * b;
            return c;
        }
        public int Division(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
}
