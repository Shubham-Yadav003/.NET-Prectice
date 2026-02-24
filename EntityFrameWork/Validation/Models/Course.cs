using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Validation.Models
{
    public class Course
    {
        [Key]
        public int CourseId {  get; set; }
        [Required]
        public string Title { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
