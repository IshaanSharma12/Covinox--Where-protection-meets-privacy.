using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familydetails
{
    internal class Details
    {   
        public string ChildName { get; set; }
        public int Age { get; set; }
       
        public Details(string cname,int age)
        {
            ChildName = cname; 
            Age = age;
        }

        public override string ToString()
        {
            return ChildName + Age;
        }
    }
}
