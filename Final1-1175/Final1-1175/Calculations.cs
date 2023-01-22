using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1_1175
{
    internal class Calculations
    {
        public int Elements { get; set; }




        public Calculations(int elements)
        {
            Elements = elements;
            
        }

        public override string ToString()
        {
            return Elements.ToString();

        }



    }
}
