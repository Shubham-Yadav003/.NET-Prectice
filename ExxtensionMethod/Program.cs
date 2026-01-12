using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace ExxtensionMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(20, 20);
            int diff = calculator.Subtract(1, 2);
            int pro = calculator.Multiply(2, 2);
            int div = calculator.Divide(2, 1);
            Console.WriteLine($"{ sum} , ${ diff} , ${ pro} , ${ div}" );
        }

    }
}
