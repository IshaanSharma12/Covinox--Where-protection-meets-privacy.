using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Forms
{
    internal class ChildDetails
    {
        public string Childname { get; set; }

        public string Childcity { get; set; }

        public ChildDetails( string cname, string ccity)
        {
            Childname = cname;
            Childcity = ccity;
        }

        public override string ToString()
        {
            return Childname + Childcity;

        }
    }
}
