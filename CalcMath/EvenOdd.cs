using System;

namespace CalcMath
{
    public class EvenOdd
    {
        public static void Execute()
        {
           
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }
            // Console.WriteLine();
        }
    }
}
