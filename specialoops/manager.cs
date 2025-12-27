using System;

class Manager : Employee
{
    double Bonus, CA;

    public override void GetEmployeeData()
    {
        Console.WriteLine("Enter Employee Details");
        Console.WriteLine("Enter E_Id:");
        Eid = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Ename:");
        Ename = Console.ReadLine();

        Console.WriteLine("Enter Bonus:");
        Bonus = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter CA:");
        CA = double.Parse(Console.ReadLine());


    }

    public override void DisplayEmployeeData()
    {
        Console.WriteLine("Employee Details");

        Console.WriteLine("E_Id: " + Eid);
        Console.WriteLine("Ename: " + Ename);
        Console.WriteLine("Bonus: " + Bonus);
        Console.WriteLine("CA: " + CA);

    }

    public override void CalculateSalary()
    {
        Console.WriteLine("Salary: " + Salary);
    }

}