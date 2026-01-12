// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter integers separated by spaces: ");
//         string input = Console.ReadLine();

//         List<int> numbers = ParseIntegers(input);
//         List<int> oddNumbers = GetOddNumbers(numbers);

//         if (oddNumbers.Count == 0)
//         {
//             Console.WriteLine("No odd numbers found.");
//         }
//         else
//         {
//             Console.WriteLine("Sorted odd numbers:");
//             Console.WriteLine(string.Join(" ", oddNumbers));
//         }
//     }

//     private static List<int> ParseIntegers(string input)
//     {
//         List<int> numbers = new List<int>();
//         string[] tokens = input.Split(' ');

//         foreach (string token in tokens)
//         {
//             if (int.TryParse(token, out int number))
//             {
//                 numbers.Add(number);
//             }
//         }

//         return numbers;
//     }

//     private static List<int> GetOddNumbers(List<int> numbers)
//     {
//         List<int> oddNumbers = new List<int>();

//         foreach (int num in numbers)
//         {
//             if (num % 2 != 0)
//             {
//                 oddNumbers.Add(num);
//             }
//         }

//         oddNumbers.Sort();
//         return oddNumbers;
//     }
// }
