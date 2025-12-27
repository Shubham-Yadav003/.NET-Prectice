using System;

namespace PartialDemo

{
    public partial class PartialDemo()
    {
        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name is: {_firstName} + {_lastName}");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details");

            Console.WriteLine("FirstName: " + _firstName);
            Console.WriteLine("LastName: " + _lastName);
            Console.WriteLine("Gender: " + _gender);
            Console.WriteLine("Salary: " + _salary);

        }

        public partial void PartialMethod()
        {
            Console.WriteLine($"Partial Method invoked");
        }
    }
}