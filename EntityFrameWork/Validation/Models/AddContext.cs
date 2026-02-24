using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Validation.Models.Context
{
    public class AddContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Lenovo_Ideapad\\SQLEXPRESS;Initial Catalog=Validate;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

    }
}
