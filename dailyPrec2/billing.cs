using System;

public class Billing
{
    public int Val1 { get; set; }
    public int Val2 { get; set; }
    public Billing() // default 
    {
        Val1 = 10;
        Val2= 10;
        Console.WriteLine($"Val1: {Val1}, Val2:{Val2}");
    }

    public Billing(int Val1, int Val2)
    {
        this.Val1 = Val1;
        this.Val2 = Val2;
        Console.WriteLine($"Val1: {Val1}, Val2:{Val2}");
    }
}