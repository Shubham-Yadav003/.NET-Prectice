using System;

namespace CalcMath
{
    public class GreatestOfTwo
    {
        public static void Execute()
        {
           
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }
            Console.WriteLine();
        }
    }
}
