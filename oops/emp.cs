using System;
namespace oops;

// namespace oops
// {
    public class Emp
    {
       private int empId = 0;
        private  string name  = string.Empty;
        private string dept = string.Empty;
        protected float salary  = 0.0f;
        private bool status = true;

        public int EmpId
    {
        get
        {
            return empId;
        }
        set
        {
            empId = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }



        public void AcceptDetails()
        {
            Console.WriteLine("Enter Employee Details:");
            Console.Write("Employee ID: ");
            empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Department: ");
            dept = Console.ReadLine();
            Console.Write("Salary: ");
            salary = Convert.ToSingle(Console.ReadLine());
            Console.Write("Status (true for active, false for inactive): ");
            status = Convert.ToBoolean(Console.ReadLine()); 
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Employee ID: {empId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Department: {dept}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Status: {(status ? "Active" : "Inactive")}");
        }
    }
// }