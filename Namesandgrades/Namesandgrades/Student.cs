using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namesandgrades
{
    internal class Student
    {
        public string Name { get; set; }

        public string Grades { get; set; }

        public Student(string name, string grades)
        {
            Name = Name;

            Grades = grades;
        }

        public override string ToString()
        {

            return Name + Grades;
        }

    }
}
