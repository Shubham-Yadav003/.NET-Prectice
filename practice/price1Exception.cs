// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// using System ;

// class Program
// {
//     public static void Main (string[] args)
//     {
//         try
//         {
//             Console.Write("Enter The Price of the Item : ") ;
//             double price = Convert.ToDouble(Console.ReadLine()) ;
//             if (price <= 0)
//             {
//                 throw new InvalidPriceException() ;
//             }
//             Console.WriteLine() ;

//             Console.Write("Enter The Quantity of the Item : ") ;
//             int quantity = Convert.ToInt32(Console.ReadLine()) ;
//             if (quantity <= 0)
//             {
//                 throw new InvalidQuantityException() ;
//             }
//             Console.WriteLine() ;

//             double totalCost = price * quantity ;
//             Console.WriteLine($"Total Cost is : {totalCost:F2}") ;
//         }
//         catch (InvalidPriceException ex)
//         {
//             Console.WriteLine(ex.Message) ;
//         }
//         catch (InvalidQuantityException ex)
//         {
//             Console.WriteLine(ex.Message) ;
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine("Error : Please Enter a Valid Number " + ex.Message) ;
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error : " + ex.Message) ;
//         }
//     }
// }