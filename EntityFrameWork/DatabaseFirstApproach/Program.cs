using DatabaseFirstApproach.Models;
//using System.Collections;
namespace DatabaseFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdventureWorksContext _context = new AdventureWorksContext();
            var query = _context.Employees.ToList();

            // execute
            foreach(Employee e in query)
            {
                Console.WriteLine(e.EmployeeId + " " + e.LoginId);
            }
        }
    }
}
