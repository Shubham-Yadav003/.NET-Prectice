using CodeFirstApproach.Models;
using Microsoft.EntityFrameWork.Models;

namespace CodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
          using (var _context = new SchoolContext())
            {
                var std = new Student() { 
                    Id = 7,
                    Name = "Foo",
                  Email = "QWERT@gmail.com",
                    Phone = "9023232442"


                };

                _context.Students.Add(std);
                _context.SaveChanges();
                Console.WriteLine("Student added successfully");
            }

          // select by  id
          var context = new SchoolContext();
            var studentSameName = new Student() { 

            }
        }
    }
}
