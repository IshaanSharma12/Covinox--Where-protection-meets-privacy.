using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayIshaan_Final
{
    internal class Grocery
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int QtyMinForRestock { get; set; }
        public int IniQty { get; set; }
        public int QtySold { get; set; }
        public int QtyRestocked { get; set; }

        public int AvailableQty
        {
            get
            {
                return IniQty - QtySold + QtyRestocked;
            }
        }

        public double TotalSales
        {
            get
            {
                return QtySold * UnitPrice;
            }
        }

        public Grocery(string icode, string iname, double up, int qtyminforrestock, int iniqty, int qtysold, int qtyrestocked)
        {
            ItemCode = icode;
            ItemName = iname;
            UnitPrice = up;
            QtyMinForRestock = qtyminforrestock;
            IniQty = iniqty;
            QtySold = qtysold;
            QtyRestocked = qtyrestocked;
        }

        public override string ToString()
        {
            return ItemCode + "\t" + "\t" + ItemName.PadRight(17) + "\t" + "\t" + UnitPrice.ToString() + "\t" + "\t"+"\t" + QtyMinForRestock.ToString() + "\t" + "\t" + IniQty.ToString() + "\t" + "\t" + QtySold.ToString() + "\t" + "\t" + QtyRestocked.ToString() + "\t" + "\t" + AvailableQty.ToString() + "\t" + "\t" + TotalSales.ToString("C");
        }
    }
}
