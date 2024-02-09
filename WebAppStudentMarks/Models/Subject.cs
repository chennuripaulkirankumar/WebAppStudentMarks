using System;
using System.Collections.Generic;

namespace WebAppStudentMarks.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Students = new HashSet<Student>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = null!;
        public int? ClassId { get; set; }
        public int? Marks { get; set; }

        public virtual Class? Class { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
