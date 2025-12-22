using System;

public class Swap
{
     public void Swapping(int num1, int num2)
    {
        int n1 = num1;
        int n2 = num2;
        int temp = 0;
        Console.WriteLine($"Before swapping: {n1} , {n2}");
        temp = n1;
        n1 = n2;
        n2 = temp;
        Console.WriteLine($"After swapping: {n1} , {n2}");

    }

}