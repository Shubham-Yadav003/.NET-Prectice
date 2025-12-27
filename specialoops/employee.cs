using System;

public class Employee
{
    protected int Eid, Eage;
    protected string Ename, Eaddress;
    protected float Salary;


    public virtual void GetEmployeeData()
    {
        Console.WriteLine("Enter Employee Details");
        Console.WriteLine("Enter E_Id:");
        Eid = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Ename:");
        Ename = Console.ReadLine();

        Console.WriteLine("Enter Eaddress:");
        Eaddress = Console.ReadLine();

        Console.WriteLine("Enter Eage:");
        Eage =  int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Salary:");
        Salary =  float.Parse(Console.ReadLine());
    }

    public virtual void DisplayEmployeeData()
{
    Console.WriteLine("Employee Details");

    Console.WriteLine("Manager E_Id: " + Eid);
    Console.WriteLine("Manager Ename: " + Ename);
    Console.WriteLine("Manager Eaddress: " + Eaddress);
    Console.WriteLine(" ManagerEage: " + Eage);
    Console.WriteLine("  ManagerSalary: " + Salary);
}

   public virtual void CalculateSalary()
    {
         Console.WriteLine("Manager Salary: " + Salary);
    }


}