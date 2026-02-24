using Validation.Models.Context; // Ensure this using directive is present and correct
namespace Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using var context = new AddContext(); // class name

            context.Database.EnsureCreated();
            var student = new Student
            {
                Name = "Shubham",
                Email = "shubham@gmail.com"
            };

            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine("Chnages saved successfully");
        }
    }
}
