using System;
using System.Collections.Generic;

namespace SchoolSystem.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public string? StudentLastN { get; set; }
        public int? StudentAge { get; set; }
        public string? StudentParent { get; set; }
        public string? StudentPhoneParent { get; set; }
        public string? StudentEmail { get; set; }
    }
}
