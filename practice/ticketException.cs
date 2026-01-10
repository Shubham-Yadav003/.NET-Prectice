

// using System ;

// class Program
// {
//     public static void Main (string[] args)
//     {
//         try
//         {
//             Console.Write("Enter The Number of Tickets : ") ;
//             int ticketNumber = Convert.ToInt32(Console.ReadLine()) ;
//             if (ticketNumber <= 0)
//             {
//                 throw new ArgumentException("Error : Number of Tickets must be Greater than Zero (0) ... !!") ;
//             }
//             Console.WriteLine() ;

//             Console.Write("Enter The Price per Ticket : ") ;
//             double ticketPrice = Convert.ToDouble(Console.ReadLine()) ;
//             if (ticketPrice <= 0)
//             {
//                 throw new ArgumentException("Error : Price per Tickets must be Greater than Zero (0) ... !!") ;
//             }
//             Console.WriteLine() ;

//             double totalCost = ticketNumber * ticketPrice ;
//             Console.WriteLine($"The Total Cost of The Tickets will be : {totalCost:F2}") ;
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine(ex.Message) ;
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine("Error : Please Enter a Valid Number ... !! " + ex.Message) ;
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error : " + ex.Message) ;
//         }
//     }
// }