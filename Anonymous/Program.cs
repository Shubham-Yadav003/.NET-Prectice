using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    public delegate void Print(int val, string str);
    public delegate void Print1(int val);
    internal class Program
    {
        public static void PrintHelperMethod(Print1 printDel, int val)
        {
            val += 10;
            printDel(val);

        }
        static void Main(string[] args)
        {

            PrintHelperMethod(delegate (int val)
            {
                Console.WriteLine($"Anonymous method:", val);
            }, 100);


            Print print = delegate (int val, string str)
            {
                Console.WriteLine($"hello world {val} {str}");
            };
            print(100, "Welcome");

            var ManagerInfo = new
            {
                id = 1001,
                Name = "Rajesh Patel"
            };

            Console.WriteLine($"Manager: {ManagerInfo.id}");
            Console.WriteLine($"Name: {ManagerInfo.Name}");



        }


        //public static void MyMethod(dynamic dy)
        //{
        //    Console.WriteLine(dy);
        //}
    }
    
}
