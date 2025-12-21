// program to read student num,name,mark of six subject and 
//calculate total and average and print result and division

using System;
namespace CalcMath
{
    public class ReadData
    {
        public static void Execute()
        {
            Console.Write("Enter Student Number: ");
            int studentNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            int[] marks = new int[6];
            int total = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter mark for subject {i +1}");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total += marks[i];
        }

        double average = total /6.0;
        if(average >= 60)
            {
                Console.WriteLine($"First Division");
            }
        else if(average >= 50 && average < 60)
            {
                Console.WriteLine($"Second Division");
            }
            else
            {
                Console.WriteLine($"Fail");
            }
        
    }
}

}