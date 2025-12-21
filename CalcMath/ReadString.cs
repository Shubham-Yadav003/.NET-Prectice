using System;

namespace CalcMath
{
    public class ReadString
    {
        public static void Execute()
        {
            
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine($"You entered: {inputString}");
            // Console.WriteLine();
        }
    }
}
