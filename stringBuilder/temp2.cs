using System;
class Animal
{
    public void Speak()
    {
        Console.WriteLine($"Hello i do speak");
    }
}

class Dog : Animal
{
    public void Speak()
    {
         Console.WriteLine($"Hello i do not speak");
    }
}
class Program { 
public static void Main()
{
    Dog obj = new Dog();
    obj.Speak();
    Animal obj2 = new Animal();
    obj2.Speak();
}
}