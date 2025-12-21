using System;

namespace CalcMath
{
    public class ReadFloat
    {
        public static void Execute()
        {
          
            Console.Write("Enter a floating point number: ");
            double floatNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You entered: {floatNumber}");
            // Console.WriteLine();
        }
    }
}
