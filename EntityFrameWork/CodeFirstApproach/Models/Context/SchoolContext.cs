using CodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.EntityFrameWork.Models

{
    internal class SchoolContext: DbContext
    {
        
        public DbSet<Student> ? Students { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Branch>? Branches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =Lenovo_Ideapad\SQLEXPRESS;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(

                new Student
                {
                    Id = 1,
                    Name = "Shubham",
                    Email = "shubham@gmail.com",
                    Phone = "9026262332",
                    BranchId = 1
                },

                new Student
                {
                    Id = 2,
                    Name = "Rahul",
                    Email = "rahul@gmail.com",
                    Phone = "9026262332",
                    BranchId = 2
                },

                new Student
                {
                    Id = 3,
                    Name = "Amit",
                    Email = "amit@gmail.com",
                    Phone = "9026262332",
                    BranchId = 1
                },

                new Student
                {
                    Id = 4,
                    Name = "Priya",
                    Email = "priya@gmail.com",
                    Phone = "9026262332",
                    BranchId = 3
                }

            );



            modelBuilder.Entity<Course>().HasData(

    new Course
    {
        CourseId = 1,
        CourseName = "Computer Science",
        Duration = 4
    },

    new Course
    {
        CourseId = 2,
        CourseName = "Mechanical Engineering",
        Duration = 4
    },

    new Course
    {
        CourseId = 3,
        CourseName = "MBA",
        Duration = 2
    }

);

            modelBuilder.Entity<Branch>().HasData(

    new Branch
    {
        Id = 1,
        Name = "CSE"
    },

    new Branch
    {
        Id = 2,
        Name = "Mechanical"
    },

    new Branch
    {
        Id = 3,
        Name = "Management"
    }

);

            modelBuilder.Entity<Address>().HasData(

    new Address
    {
        Id = 1,
        Studentid = 1,
        City = "Lucknow",
        State = "Uttar Pradesh",
        Country = "India",
        Pin = "226001"
    },

    new Address
    {
        Id = 2,
        Studentid = 2,
        City = "Delhi",
        State = "Delhi",
        Country = "India",
        Pin = "110001"
    }

);
        }

    }
}
