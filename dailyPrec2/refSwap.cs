using System;

public class Reference
{
    public void swap1(ref int num1, ref int num2)
    {

        int temp = 0;
        //   Console.WriteLine($"Before swapping: {n1} , {n2}");
        temp = num1;
        num1 = num2;
        num2 = temp;
        // Console.WriteLine($"After swapping: {n1} , {n2}");

    }
}