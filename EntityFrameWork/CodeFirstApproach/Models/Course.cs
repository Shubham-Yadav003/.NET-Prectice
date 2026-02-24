using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApproach.Models
{
    internal class Course
    {
        public int CourseId { get; set; } = 0;
        public string CourseName { get; set; } = string.Empty;
        public int Duration { get; set; } = 0;
    }
}
