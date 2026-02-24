using CoreValidation.Models;
using CoreValidation.Models.Context;
using System.ComponentModel.DataAnnotations;

namespace CoreValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();
            context.Database.EnsureCreated();
            var course = new Course
            {
                CourseName = "FullStack .net"
            };

            context.Courses.Add(course);
            context.SaveChanges();
            var student = new Student
            {
                Name = "Kundan Kumar",
                Email = "Kundan@gmail.com",
                Age = 100,
                Enrollment = DateTime.Now.AddDays(5),
                CourseId = course.CourseId
            };

            ValidateAndSave(context, student);

        }

        static void ValidateAndSave(AppDbContext context , Student student)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(student);

            bool isValid = Validator.TryValidateObject(
                student,
                validationContext,
                validationResults,
                true
                );

            if (!isValid)
            {
                Console.WriteLine("Validation Errors");
                foreach (var error in validationResults)
                {
                    Console.WriteLine($"- {error.ErrorMessage}");
                }
                return;
            }
            try
            {
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student Saved sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database Error: ");
                Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
