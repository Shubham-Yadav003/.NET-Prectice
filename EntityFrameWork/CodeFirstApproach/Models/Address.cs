using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApproach.Models
{
    internal class Address
    {
        public int Id { get; set; } = 0;
        public int Studentid { get; set; } = 0;
        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public string Pin { get; set; } = string.Empty;
    }
}
