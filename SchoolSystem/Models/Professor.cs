using System;
using System.Collections.Generic;

namespace SchoolSystem.Models
{
    public partial class Professor
    {
        public int Id { get; set; }
        public string? ProfessorName { get; set; }
        public string? ProfessorLastN { get; set; }
        public string? ProfessorClass { get; set; }
        public int? ProfessorAge { get; set; }
        public string? ProfessorPhone { get; set; }
    }
}
