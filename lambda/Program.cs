using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    delegate bool IsTeenAger(Student stud);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
                {
                    Id= 101,
                    Name = "Rjaesh",
                    Age = 25
            };
            IsTeenAger isTeenAger = delegate (Student s)
            {
                return s.Age > 12 && s.Age < 20;
            };

            // lambda expresion
            IsTeenAger isTeenAger1 = (s) => { return s.Age > 12 && s.Age < 20; };
            IsTeenAger isTeenAger2 = s=> s.Age > 12 && s.Age < 20;

            Console.WriteLine(isTeenAger1(student));

            Calculator calc = new Calculator();
            calc.Add(10, 20);
            int result = calc.Add(10, 20);
            Console.WriteLine(result);
        }
    }
}
