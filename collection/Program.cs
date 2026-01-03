using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        // Hashtable hash = new Hashtable();
        // hash.Add(200,"Abc");
        // hash.Add(300,"Def");
        // hash.Add(400,"Ghi");
        // hash.Add(500,"Jkl");
        // SortedList list = new SortedList();
        // list.Add(200,"Abc");
        // list.Add(300,"Def");
        // list.Add(400,"Ghi");
        // list.Add(500,"Jkl");


        // ICollection key = hash.Keys;
        // Console.WriteLine("Unsorted keys are;");
        // foreach(var i in key)
        // {
        //    Console.WriteLine(i);  
        // }


        // ICollection key2 = list.Keys;
        // Console.WriteLine("Sorted keys are;");
        // foreach(var i in key2)
        // {
        //    Console.WriteLine(i);  
        // }

        // ICollection value = hash.Values;
        // Console.WriteLine("All values are:");
        // foreach(var val in key)
        // {
        //    Console.WriteLine(hash[val]);  
        // }

        //  Console.WriteLine("Corresponding key and value pair:");

        // foreach(var k in key)
        // {
        //     Console.WriteLine($"Key is {k} and value is {hash[k]}");
        // }

        // //   Console.WriteLine("Searching key and value pair:");
        // //   int input = int.Parse(Console.ReadLine());
        // // if (hash.ContainsKey(input))
        // // {
        // //     Console.WriteLine($"Found key:{input} with value: {hash[input]}✅");
        // // }
        // // else
        // // {
        // //     Console.WriteLine("Not Found");
        // // }




        //  Console.WriteLine("Corresponding list values");
        //  ICollection val2 = list.Values;
        //  foreach(var vall in val2)
        // {
        //    Console.WriteLine(vall);  
        // }

        // Console.WriteLine("Corresponding list values using keys");
        // foreach(var value2 in key2)
        // {
        //    Console.WriteLine(hash[value2]);  
        // }

        // Console.WriteLine("Finding key index 200");
        // Console.WriteLine($"index of 200 is: {list.IndexOfKey(200)}");

        // int cnt = list.Count;
        // Console.WriteLine($"Count is: {cnt}");

        // Stack stack = new Stack();
        // stack.Push('A');
        // stack.Push('B');
        // stack.Push('C');
        // stack.Push('D');

        // Console.WriteLine($"Stack element is:");
        // foreach(var item in stack)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine($"Top elem is: {stack.Peek()}");
        //  Console.WriteLine($"Pop top elem: {stack.Pop()}");

        //  Console.WriteLine($"Enter element to search:");
        //  char ch= Convert.ToChar(Console.ReadLine());
        // if (stack.Contains(ch))
        // {
        //     Console.WriteLine($"element {ch} is found✅");
        // }
        // else
        // {
        //     Console.WriteLine($"Element not found");
        // }


        // Queue queue = new Queue();
        // queue.Enqueue('A');
        // queue.Enqueue('B');
        // queue.Enqueue('C');
        // queue.Enqueue('D');
        // queue.Dequeue();

        // foreach(var q in queue)
        // {
        //     Console.WriteLine($"elemnts are: {q}");
        // }



        // Collections obj = new Collections();
        //   obj.Func();


        // AddGeneric<int> addInt = new AddGeneric<int>(10, 10);
        // int sum = addInt.AddAllType(30, 20);
        // Console.WriteLine($"sum is: {sum}");

        // AddGeneric<string> addString = new AddGeneric<string>("hello", "world");
        // Console.WriteLine($"String is: {addString.AddAllType("Babu", "Rao")}");


        // AddGeneric<float> addFloat = new AddGeneric<float>(65.2f, 34.3f);
        // Console.WriteLine($"Float is: {addFloat.AddAllType(65.2f, 34.3f)}");


        // List<string> emp = new List<string>();
        // emp.Add("Rajesh");

        // foreach (var v in emp)
        // {
        //     Console.WriteLine($"value: {v}");
        // }

        // Employee emp1 = new Employee()
        // {
        //     Id = 20,
        //     Name = "Shubham"
        // };
        // Employee emp2 = new Employee()
        // {
        //     Id = 20,
        //     Name = "Shubham Babu"
        // };

        // List<Employee> list2 = new List<Employee>();
        // list2.Add(emp1);
        // list2.Add(emp2);

        // foreach (Employee e in list2)
        // {
        //     Console.WriteLine(e);
        // }


        // Dictionary<int, string> dict = new Dictionary<int, string>();
        // dict.Add(10, "shubham");
        // dict.Add(20, "Yadav");

        // foreach (KeyValuePair<int, string> key in dict)
        // {
        //     Console.WriteLine($" key is: {key.Key} value is: {key.Value}");

        // }

        // SortedList<string, string> pair = new SortedList<string, string>();
        // pair.Add("100", "rajesh");
        // pair.Add("200", "pajesh");
        // pair.Add("300", "kajesh");
        // Console.WriteLine($"Sorted list:");
        // foreach (KeyValuePair<string, string> key in pair)
        // {
        //     Console.WriteLine($"Key is {key.Key}, value is: {key.Value}");
        // }
        // *****************************************//
        // Stack<char> st = new Stack<char>();
        // st.Push('A');
        // st.Push('B');
        // st.Push('C');
        // st.Push('D');
        // foreach (var item in st)
        // {
        //     Console.WriteLine(item);
        // }
        // st.Pop();
        // Console.WriteLine("After removing");
        // foreach (var item in st)
        // {
        //     Console.WriteLine(item);
        // }

        // ***********************************//
        // Queue q = new Queue();
        // q.Enqueue(10);
        // q.Enqueue(20);
        // q.Enqueue(30);
        // Console.WriteLine("Queue Elements:");
        // foreach (var item in q)
        // {
        //     Console.WriteLine(item);
        // }


      // **********************************************************//
      MyCollection obj = new MyCollection();
      foreach(int i in obj){
        Console.WriteLine(i);
      }

       










    }
}