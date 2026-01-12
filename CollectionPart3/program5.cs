using System;

class Program5
{
   public static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        string[] arr = input.Split(" ");
        List<int> list = new List<int>();
        foreach(var val in arr)
        {
            int value;
            if(int.TryParse(val, out  value))
            {
                int square = value * value;
              list.Add(square);
              
            }
            else
            {
                Console.WriteLine("Invalid , not a number");
                return;
            }

        }
        list.Sort();
        list.Reverse();

        foreach(var num in list)
        {
            Console.Write(num + " ");
        }
    }



}