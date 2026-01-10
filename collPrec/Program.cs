using System;
using System.Collections;

public class Program
{
    // private static string name = "";
    // private static ArrayList list = new ArrayList();

    private static ArrayList list2 = new ArrayList();
    private static int num;


    private static void Addition()
    {     if(int.TryParse(Console.ReadLine(), out num))// out is reference
        {
            list2.Add(num);
            Console.WriteLine("Number added successfully");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }


    private static void Removed()
    {
        if (int.TryParse(Console.ReadLine(), out num))
        {
            if (list2.Contains(num))
            {
                list2.Remove(num);
                Console.WriteLine($"{num} is removed");
            }
            else
            {
                Console.WriteLine($"{num} is not found in the ArrayList");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    private static void Printed()
    {
        Console.WriteLine($"Numbers Are:");
        for (int i = 0; i < list2.Count; i++)
        {
            Console.WriteLine(list2[i]);
        }
    }

    // private static void Helper()
    // {
    //     while (name != "stop")
    //     {
    //         name = Console.ReadLine();
    //         if(name == "stop") break;

    //         if (!list.Contains(name.ToLower()))
    //         {
    //             list.Add(name.ToLower());
    //             Console.WriteLine("New Name Added");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Dublicate name");
    //         }
    //     }

    //     Console.WriteLine("Unique names:");
    //     for (int i = 0; i < list.Count; i++)
    //     {
    //         Console.WriteLine(list[i]);
    //     }
    // }

    private static void Main()
    {
        // Helper();
        Addition();
        Addition();
        Addition();
        Removed();
        Printed();

    }
}