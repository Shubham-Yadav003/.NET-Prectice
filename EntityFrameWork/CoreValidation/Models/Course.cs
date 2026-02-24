using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreValidation.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]

        public string CourseName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
