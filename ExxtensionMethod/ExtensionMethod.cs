//using CalculatorLib;
using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowConsoleApp
{
    static class ExtensionMethod
    {
        public static int Multiply(this Calculator cal, int num1, int num2)
        {
            return num1 * num2;
        }
    }
}