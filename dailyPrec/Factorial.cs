using System;
namespace oops;

public class Factorial
{
     public static void Calculate()
    {

        while (true)
        {
            Console.WriteLine("Enter a number");
            string? input = Console.ReadLine();

            if (input == null)
                continue;
            if (input == "q")
            {
                Console.WriteLine("Quitting");
                break;
            }
            

            long num = Convert.ToInt64(input);
            if (num < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.\n");
                continue;
            }
            Console.WriteLine($"{Helper(num)}");

        }


    }
    public static long Helper(long num)
    {
        if (num <= 1) return 1;

        return num * Helper(num - 1);
    }
}