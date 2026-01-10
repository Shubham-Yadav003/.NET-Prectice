// using System ;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             Console.Write("Enter The First Array's input values : ") ;
//             string[] input1 = Console.ReadLine().Split(" ") ;
//             Console.Write("Enter The Second Array's input values : ") ;
//             string[] input2 = Console.ReadLine().Split(" ") ;

//             if (input1.Length != input2.Length)
//             {
//                 throw new Exception($"Error: Arrays must have the same length for addition.") ;
//             }

//             int[] inputArray1 = new int[input1.Length] ;
//             int[] inputArray2 = new int[input2.Length] ;

//             for (int i=0 ; i<input1.Length ; i++)
//             {
//                 int value = Convert.ToInt32(input1[i]) ;
//                 inputArray1[i] = value ;
//             }
//             for (int i=0 ; i<input2.Length ; i++)
//             {
//                 int value = Convert.ToInt32(input2[i]) ;
//                 inputArray2[i] = value ;
//             }

//             int[] sumArray = new int[input1.Length] ;
//             for (int i=0 ; i<input1.Length ; i++)
//             {
//                 sumArray[i] = inputArray1[i] + inputArray2[i] ;
//             }

//             Console.Write("Enter The index to Access from sumArray : ") ;
//             int index = Convert.ToInt32(Console.ReadLine()) ;
//             Console.WriteLine() ;

//             int result = sumArray[index] ;
//             Console.WriteLine($"Element at index {index} in the sum array: {result}") ;
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine($"Error: Invalid input format. Please enter integers only.") ;
//             Console.WriteLine($"Exception Message: Input string was not in a correct format.") ;
//         }
//         catch (IndexOutOfRangeException ex)
//         {
//             Console.WriteLine($"Error: Index out of range for the sum array.") ;
//             Console.WriteLine($"Exception Message: Index was outside the bounds of the array.") ;
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error : {ex.Message}") ;
//         }
//     }
// }