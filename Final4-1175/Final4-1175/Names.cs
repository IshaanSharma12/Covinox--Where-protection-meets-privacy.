using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final4_1175
{
    internal class Names
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }    

        public Names(string fname, string lname)
        {
            Firstname= fname;
            Lastname= lname;

        }

        public override string ToString()
        {
            return Firstname.PadRight(17)+"\t"+ Lastname;
        }

    }
}
