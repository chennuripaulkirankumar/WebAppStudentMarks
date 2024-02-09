using System;
using System.Collections.Generic;

namespace WebAppStudentMarks.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }
        public int? Marks { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
