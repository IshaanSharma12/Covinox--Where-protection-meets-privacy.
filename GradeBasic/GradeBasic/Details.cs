using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBasic
{
    internal class Details
    {
        public string PassengerName { get; set; }
        public string PassengerId { get; set; }
        public string PassengerStatus { get; set; }

        // Creating the Constructor 

        public Details( string pname, string pid, string ps)
        {
            PassengerName= pname;
            PassengerId= pid;
            PassengerStatus= ps;

        }
        // Creating the Overriden To string Method

        public override string ToString()
        {
           return PassengerName+ "\t" + PassengerId + "\t" + PassengerStatus;
        }
    }
}
