using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx3
{
    internal class Manatee
    {
        public string Location { get; set; }
        public string[] Dates { get; set; }
        public int[] Counts { get; set; }

        public int MinSightingCount
        {
            get
            {         
                return Counts.Min();
            }

        }

        public int MaxSightingCount
        {
            get
            {           
                return Counts.Max();
            }
        }
        public double AvgSightingCount
        {
            get
            {
                return Counts.Average();
            }
        }



        public Manatee(string location, string[] dates, int[] counts)
        {
            Location = location;
            Dates = dates;
            Counts = counts;
        }

        public override string ToString()
        {

            string OutputStr = Location.PadRight(27);
            for (int i=0; i<Dates.Length; i++)
            {
                OutputStr += Dates[i].PadRight(15) + "\t";
            }

            for (int i = 0; i < Counts.Length; i++)
            {
                OutputStr += Counts[i].ToString().PadRight(14);
            }

            OutputStr += MinSightingCount.ToString().PadRight(15) + MaxSightingCount.ToString().PadRight(15)
                                +AvgSightingCount;
            return OutputStr;
        }
    }
}
