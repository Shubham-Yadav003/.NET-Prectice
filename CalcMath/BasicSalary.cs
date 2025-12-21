// program to read eno,ename,basic salary and calculate  
//pf,hra,da,net salary and gross salary and print eno,ename,basic 
//salary,
//gross salary and net salary*/

// pf= 12% of basic salary.
// hra=20% of basic salary.
// da= 15% of basic salary.
// gross salary=pf+hra+da+basic salary;
// net salary=gross salary - pf;


using System;
// using System.Security.Cryptography.X509Certificates;
using CalcMath;

public class Salary
{
    public static void BasicSalary()
    {
        Console.Write("Enter your eno: ");
        int eno = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your ename: ");
        string ename = Console.ReadLine();
        Console.Write("Enter your basic salary: ");
        double basicSalary = Convert.ToDouble(Console.ReadLine());

        Salary salary = new Salary();
        salary.CalculateSalary(basicSalary);
        Console.WriteLine($"Employee Number: {eno}");
        Console.WriteLine($"Employee Name: {ename}");
        Console.WriteLine($"Basic Salary: {basicSalary}");
    }

      public void CalculateSalary(double basicSalary)
        {
            double pf = 0.12 * basicSalary;
            double hra = 0.20 * basicSalary;
        
            double da = 0.15 * basicSalary;
            double grossSalary = pf + hra + da + basicSalary;
            Console.WriteLine($"Gross Salary: {grossSalary}");
            double netSalary = grossSalary - pf;
            Console.WriteLine($"Net Salary: {netSalary}");
        }

            
        
        
    
}