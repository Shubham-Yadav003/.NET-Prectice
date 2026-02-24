using CoreValidation.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreValidation.Models
{
    public class Student
    {
        public int StudentId {  get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Range(18,60)]
        public int Age {  get; set; }

        [FutureDateValidation]
        public DateTime Enrollment {  get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
