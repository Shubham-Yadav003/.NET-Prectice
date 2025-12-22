using System;

public class Utility
{
    public string? name { get; set; }
    public int age { get; set; }
    public void Func(string name, int num2)
    {

        this.name = name;
        age = num2;
        Console.WriteLine($"name: {name} , age: {age}");


    }
}