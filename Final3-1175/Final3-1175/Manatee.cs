using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final3_1175
{
    internal class Manatee
    {
        public string Location
        {
            get; set;
        }
        public string[] Dates
        {
            get; set;
        }

        public int[] Counts
        {
            get; set;
        }

        public int MinSightingCount
        {
            get; set;
        }

        public int MaxSightingCount
        {
            get; set; 
        }

        public double AvgSightingCount
        {
            get; set; 
        }

        public Manatee(string location, string[] dates, int[] counts)
        {
            Location = location;
            Dates = dates;
            Counts = counts;
        }

        public override string ToString()
        {
            return Dates[0] + Dates[1] + Dates[2] + Dates[3] + Dates[4] + Counts[1] + Counts[2] + Counts[3] + Counts[4] + MinSightingCount + MaxSightingCount + AvgSightingCount;
        }
    }
}
