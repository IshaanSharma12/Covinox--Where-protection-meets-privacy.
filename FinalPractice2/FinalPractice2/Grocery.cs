using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPractice2
{
    internal class Grocery
    {
        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public double UnitPrice { get; set; }

        public int Iniqty { get; set; }

        public int QtyMinforRestock { get; set; }

        public int QtySold { get; set; }

        public int QtyRestocked { get; set; }

        public int AvailableQty
        {
            get
            {
                return Iniqty - QtySold + QtyRestocked;

            }
        }

        public double TotalSales
        {
            get
            {
                return QtySold * UnitPrice;

            }
        }

        public Grocery(string icode, string iname, double up, int iniqty, int qtyminrestock, int qtysold, int qtyrestocked)
        {
            ItemCode = icode;
            ItemName = iname;
            UnitPrice = up;
            Iniqty = iniqty;
            QtyMinforRestock = qtyminrestock;
            QtySold = qtysold;
            QtyRestocked = qtyrestocked;
        }

        public override string ToString()
        {
            
            
            string outputstr= ItemCode + "\t"+"\t" + ItemName.PadRight(17)+"\t"+"\t" + UnitPrice.ToString("C") + "\t" + "\t" + Iniqty.ToString() + "\t" + "\t" + QtyMinforRestock.ToString() + "\t" + "\t" + QtySold.ToString() + "\t" + "\t" + QtyRestocked.ToString() + "\t" + "\t" + AvailableQty.ToString() + "\t" + "\t" + TotalSales.ToString("C");

            return outputstr;

        }

    }
}






