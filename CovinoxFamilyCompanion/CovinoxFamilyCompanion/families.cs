using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CovinoxFamilyCompanion
{
    internal class families
    {
       public string Names { get; set; }

       public string Dose { get; set; }

        public int Age { get; set; }

        public int Month { get; set; }

        public int MonthLeft 
        {get

            { return 12 - Month; }
                
                
        }


        public families(string names, string dose, int age, int month)
        {
            Names = names;
            Dose= dose;
            Age = age;
            Month = month;
            

        }

        public override string ToString()
        {
            return (Names.PadRight(17) + "\t" + Dose.PadRight(17) + "\t" + Age + "\t" + Month.ToString() + "\t" + MonthLeft.ToString()); ;

            
        }




    }
}
