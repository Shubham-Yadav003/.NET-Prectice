using System;

namespace CalcMath
{
    public class Calculator
    {
        public static void Execute()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

             Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int greatest = num1;
            if(num2 > greatest && num2 > num3)
            {
                greatest = num3;
            }
            else if(num3 > greatest )
            {
                greatest = num3;
            }

            Console.WriteLine($"The greatest number among {num1}, {num2}, and {num3} is {greatest}");





            
        }
    }
}