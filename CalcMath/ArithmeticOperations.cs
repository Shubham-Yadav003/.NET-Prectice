using System;

namespace CalcMath
{
    public class SalaryOpr
    {
        public static void Execute()
        {
            Console.WriteLine("--- Arithmetic Operations Program ---");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nAddition: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"Modulus: {num1} % {num2} = {num1 % num2}");
            Console.WriteLine();
        }
    }
}
