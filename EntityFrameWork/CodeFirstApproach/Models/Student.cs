using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApproach.Models
{
    internal class Student
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int BranchId { get; set; } = 0;
        // propertu add
        public string Phone { get; set; } = string.Empty;


    }
}
