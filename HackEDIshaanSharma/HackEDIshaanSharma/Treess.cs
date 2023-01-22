using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackEDIshaanSharma
{
    internal class Treess
    {
        public int Index
        {
            get; set;
        }

        public double Girth
        {
            get; set;
        }

        public int Height
        {
            get; set;
        }

        public double Volume
        {
            get; set;
        }

        public double Width
        {
            get
            {
                return Girth / 2;
            }
        }

        public Treess(int index, double girth, int height, double volume)
        {
            Index = index;
            Girth = girth;
            Height = height;
            Volume = volume;
            
        }

        public override string ToString()
        {
            return Index+"\t"+"\t"+Girth+"\t"+"\t"+Height+"\t"+"\t"+Volume+"\t"+"\t"+Width+"\t";
        }
    }
}
