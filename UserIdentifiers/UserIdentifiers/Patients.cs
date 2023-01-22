using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserIdentifiers
{
    internal class Patients
    {
        string Username { get; set; }

        int Identifier { get; set; }

        string Firstname { get; set; }

        string Lastname { get; set; }   


        public Patients(string uname, int identifier, string fname, string lname)
        {
            Username = uname;
            Identifier= identifier;
            Firstname= fname;
            Lastname= lname;
        }

        public override string ToString()
        {
            return Username+ Identifier+ Firstname+ Lastname;   
        }


    }
}
