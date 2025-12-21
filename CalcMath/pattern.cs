using System;
using CalcMath;
public class Pattern
{
    // static int n = 5;
    public static void ShowPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int k = i; k < n; k++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" ");
                Console.Write(j);
            }
            Console.WriteLine();

        }
    }
}