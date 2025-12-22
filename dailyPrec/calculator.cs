using System;

class Calculator
{
    // public int num1;
    public int Num1 { get; set; }
    public int Num2 { get; set; }

    public int Result { get; set; }

    public Calculator() // default constructor 
    {
        Num1 = 0;
        Num2 = 0;
        Result = 0;
    }

    public Calculator(int Num1, int Num2) // parameterized 
    {
        this.Num1 = Num1;
        this.Num2 = Num2;
    }
    // return -> true , para->true
    // return ->true, para->false
    //vise versa
    //vise vera
    public int Add(int number1, int number2)
    {
        Num1 = number1;
        Num2 = number2;

        return Result = number1 + number2;
    }

    public int Sub()
    {
        Num1 = 30;
        Num2 = 20;

        return Result = Num1 - Num2;
    }

    public void Multiply(int number1, int number2)
    {
        Num1 = number1;
        Num2 = number2;
        Result = number1 * number2;
        Console.WriteLine($"Multiplication: {Result}");
    }

    public void Divide()
    {
        Result = Num1 / Num2;
        Console.WriteLine($"Division: {Result}");
    }

    // Inparameter/ pass by value
    public void swap(int num1, int num2)
    {
        int n1 = num1;
        int n2 = num2;
        int temp = 0;
        //   Console.WriteLine($"Before swapping: {n1} , {n2}");
        temp = n1;
        n1 = n2;
        n2 = temp;
        // Console.WriteLine($"After swapping: {n1} , {n2}");

    }

    // inout parameter
    public void swap1(ref int num1, ref int num2)
    {

        int temp = 0;
        //   Console.WriteLine($"Before swapping: {n1} , {n2}");
        temp = num1;
        num1 = num2;
        num2 = temp;
        // Console.WriteLine($"After swapping: {n1} , {n2}");

    }

    public void Addition(int n1, int n2, out int result, out int n3, out int n4)
    {
        n3 = n1;
        n4 = n2;
        result = n1 + n2;

    }

}