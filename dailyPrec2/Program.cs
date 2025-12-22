using System;

public class Program
{
    public static void Main()
    {
        //  Billing obj1 = new Billing();
        //  Billing obj2= new Billing(20,20);

        // int val1 = 20;
        // int val2 = 30;
        // Swap obj = new Swap();
        // obj.Swapping(val1,val2);
        //  Console.WriteLine($"Original values after this operation: {val1} , {val2}");


        // Reference obj2 = new Reference();
        // int val1 = 90;
        // int val2=100;
        // Console.WriteLine($"Original values before  operation: val1:{val1} , val2:{val2}");
        // obj2.swap1(ref val1, ref val2);
        //  Console.WriteLine($"Original values after this operation: val1:{val1} , val2:{val2}");


        // Marks obj3 = new Marks();
        // int sub1 = 60;
        // int sub2 = 62;
        // int result = 0;
        // int carry1=0;
        // int carry2=0;
        // obj3.Addition(sub1,sub2,out result, out  carry1, out carry2);
        // Console.WriteLine($"sub1: {carry1} , sub2:{carry2} , result: {result}");



        // Utility obj4 = new Utility();
        // string name = "Shubham";
        // int age = 22;

        // obj4.Func(name,age);

        
        
        Unique obj5 = new Unique();
        int result = 0; int prev1 = 0; int prev2 = 0;

        obj5.Finder(5, 5, out result, out prev1, out prev2);
        Console.WriteLine($"Value post calculation: {result}, initial_value1:{prev1}, senond_value: {prev2}");
    }
}
