using System;
using System.Collections;

class Collections
{
    public void Func()
    {
        object o;
        int i = 10;
        o = i; // when converting value type to reference type {class type} the called unboxing


        int j = (int)o; // when converting referenece type to value type , called boxing

        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add(false);
        list.Add(56.6f);

        int k = (int)list[0];
        Console.WriteLine(k);

        // int v = list[1]; // ERROR: Cannot assign bool to int without casting
        bool v = (bool)list[1]; // CORRECT: Cast directly from list
        Console.WriteLine(v);
        // var x = 0;
        // x="Hello"; // ERROR: Cannot assign string to int variable
        var x = "Hello"; // CORRECT: Infer x as string type

        dynamic n = 10; // checked in run time

    }
}