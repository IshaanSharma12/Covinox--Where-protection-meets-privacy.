using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshaanSharmaFinal
{
    internal class Manatee
    {
        public string Location { get; set; }

        public string[] Dates { get; set; }

        public int[] SC { get; set; }

        public int MaxSinghtingCount
        {
            get
            {
                return SC.Max();
            }
        }

        public int MinSightingCount
        {
            get
            {
                return SC.Min();
            }
        }

        public double AverageCounts
        {
            get
            {
                return SC.Average();
            }
        }

        public Manatee(string loc, string[]date, int[] sc)
        {
            Location = loc;
            Dates = date;
            SC = sc;
        }

        public override string ToString()
        {
            string Outputstr = Location.ToString().PadRight(15);

            for(int i=0; i<Dates.Length; i++)
            {

                Outputstr += Dates[i].PadRight(15);
            }

            for(int i=0; i< SC.Length; i++)
            {
                Outputstr += SC[i].ToString().PadRight(15);
            }

            Outputstr += MaxSinghtingCount.ToString().PadRight(15) + MinSightingCount.ToString().PadRight(15) + AverageCounts.ToString().PadRight(15);
       
          return Outputstr;
        }

    }
}
