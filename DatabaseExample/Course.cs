using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample
{
    public class Course
    {
        public Course()
        {
            Prerequisite = new List<string>();
        }

        public string Name  { get; set; }
        public string Semester { get; set; }
        public string Program { get; set; }
        public List<string> Prerequisite { get; set; }
    }
}