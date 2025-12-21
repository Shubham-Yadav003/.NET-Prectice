using System;

namespace CalcMath
{
    public class ReadNumber
    {
        public static void Execute()
        {
         
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {number}");
            // Console.WriteLine();
        }
    }
}
