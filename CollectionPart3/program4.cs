// using System;
// using System.Collections.Generic;

// public class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter strings separated by spaces: ");
//         string input = Console.ReadLine();

//         List<string> strings = new List<string>(input.Split(' '));
//         List<string> sortedStrings = SortStringsByLength(strings);

//         Console.WriteLine("Sorted strings:");
//         Console.WriteLine(string.Join(" ", sortedStrings));
//     }

//     private static List<string> SortStringsByLength(List<string> strings)
//     {
//         strings.Sort((a, b) => b.Length.CompareTo(a.Length));
//         return strings;
//     }
// }
