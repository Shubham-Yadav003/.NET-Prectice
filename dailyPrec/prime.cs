using System;
namespace oops;

public class PrimeVal
{
    public static void Find()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        PrimeVal obj = new PrimeVal();
        obj.helper(num); // print if prime
    }

    void helper(int num)
    {
        if(num == 1)
        {
            
         Console.WriteLine("Prime number");

        }
        for(int i=2;i*i <=num; i++)
        {
            if(num % i == 0)
            {
                Console.WriteLine("Non-Prime number");
            }
        }
         Console.WriteLine("Prime number");

    }

    


}