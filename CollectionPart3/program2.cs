// using System;
// using System.Collections.Generic;

// class Program
// {
//     public static HashSet<string> strings = new HashSet<string>();

//     public static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("\nChoose an operation:");
//             Console.WriteLine("1: Create (Add a new string)");
//             Console.WriteLine("2: Read (Display all strings)");
//             Console.WriteLine("3: Update (Update an existing string)");
//             Console.WriteLine("4: Delete (Remove a string)");
//             Console.WriteLine("5: Exit");
//             Console.Write("Enter your choice: ");

//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     Create();
//                     break;
//                 case "2":
//                     Read();
//                     break;
//                 case "3":
//                     Update();
//                     break;
//                 case "4":
//                     Delete();
//                     break;
//                 case "5":
//                     return;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }
//         }
//     }

//     public static void Create()
//     {
//         Console.Write("Enter a string to add: ");
//         string input = Console.ReadLine();

//         if (strings.Add(input))
//         {
//             Console.WriteLine($"'{input}' has been added.");
//         }
//         else
//         {
//             Console.WriteLine($"'{input}' already exists in the set.");
//         }
//     }

//     public static void Read()
//     {
//         if (strings.Count == 0)
//         {
//             Console.WriteLine("The set is empty.");
//             return;
//         }

//         Console.WriteLine("Current items in the set:");
//         foreach (string str in strings)
//         {
//             Console.WriteLine(str);
//         }
//     }

//     public static void Update()
//     {
//         Console.Write("Enter the string to update: ");
//         string oldString = Console.ReadLine();

//         if (!strings.Contains(oldString))
//         {
//             Console.WriteLine($"'{oldString}' does not exist in the set.");
//             return;
//         }

//         Console.Write("Enter the new string: ");
//         string newString = Console.ReadLine();

//         if (strings.Contains(newString))
//         {
//             Console.WriteLine($"Update failed. '{newString}' already exists in the set.");
//             return;
//         }

//         strings.Remove(oldString);
//         strings.Add(newString);
//         Console.WriteLine($"'{oldString}' has been updated to '{newString}'.");
//     }

//     public static void Delete()
//     {
//         Console.Write("Enter the string to delete: ");
//         string input = Console.ReadLine();

//         if (strings.Remove(input))
//         {
//             Console.WriteLine($"'{input}' has been removed.");
//         }
//         else
//         {
//             Console.WriteLine($"'{input}' does not exist in the set.");
//         }
//     }
// }
