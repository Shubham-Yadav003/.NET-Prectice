using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Validation.Models;

namespace Validation
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }

   
}
