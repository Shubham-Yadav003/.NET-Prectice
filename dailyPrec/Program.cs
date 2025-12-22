

using System;
public class Program
{
    public static void Main()
    {

        // Factorial.Calculate();

        int number1 = 20;
        int number2 = 10;
        Calculator calc = new Calculator();
        int sum = calc.Add(number1,number2);
        Console.WriteLine($"sum: {sum}");
        int diff = calc.sub(number1,number2);
         Console.WriteLine($"sum: {diff}");
        int mul = calc.multiply(number1, number2);
         Console.WriteLine($"sum: {mul}");
        int divide = calc.Divide(number1, number2);
         Console.WriteLine($"sum: {divide}");
        // Console.WriteLine($"Before swapping: {number1},{number2}");
        // calc.swap(number1, number2);
        //  Console.WriteLine($"After swapping: {number1},{number2}");

        //  int val1= 60;
        //  int val2=70;
        // Console.WriteLine($"Before swapping: {val1},{val2}");
        // calc.swap1(ref val1, ref val2);
        // Console.WriteLine($"After swapping: {val1},{val2}");

        // Calculator obj2 = new Calculator();
        // int num1= 10;
        // int num2=20;
        // int result=0;
        // int n3=0;
        // int n4=0;
        // obj2.Addition(num1,num2,out result,out n3,out n4);
        // Console.WriteLine($"First number: {n3} + second number:{n4} + result is: {result}");

    }



}