using System;

namespace CalcMath
{
    public class AreaOfCircle
    {
        public static void Execute()
        {
           
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            
            Console.WriteLine($"Area of Circle with radius{radius}: {area:F2}");
           
        }
    }
}
