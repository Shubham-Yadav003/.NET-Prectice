using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
namespace SerializationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            string fileName = "D:\\Data:\\employee.json";
            string json = JsonSerializer.Serialize(emp, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(fileName, json);
            Console.WriteLine("JSON file created successfully");


        }
    }
}
