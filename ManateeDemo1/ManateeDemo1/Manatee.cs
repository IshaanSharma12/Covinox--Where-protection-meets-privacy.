using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManateeDemo1
{
    internal class Manatee
    {
        public string Location { get; set; }
        public string[] Date { get; set; }
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

        public double AvgSightCount
        {
            get
            {
                return Counts.Average();
            }
        }

        public Manatee(string location, string[] date, int[] count)
        {
            Location=location;
            Date = date;
            Counts= count;
        }

        public override string ToString()
        {
            string outputstr = Location.PadRight(17);

            for(int i=0; i<Date.Length; i++)
            {
                outputstr += Date[i].PadRight(15);
            }

            for(int i=0; i< Counts.Length; i++)
            {
                outputstr += Counts[i].ToString().PadRight(17);
            }

            outputstr += MinSightingCount.ToString().PadRight(15) + MaxSightingCount.ToString().PadRight(15) + AvgSightCount.ToString().PadRight(15);

            return outputstr;
        }
    }
}
