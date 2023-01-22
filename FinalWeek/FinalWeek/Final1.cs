using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWeek
{
    internal class Final1
    {
        public string ItemId { get; set; }

        public string ItemName { get; set; }

        public double UnitPrice { get; set; }

        public int QtyMinRestock { get; set; }

        public int InitialQty { get; set; }

        public int QtySold { get; set; }

        public int QtyRestocked { get; set; }

        public int AvailableQty
        {
            get
            {
                return InitialQty - QtySold + QtyRestocked;
            }
        }
        

        public double TotalSales
        {
            get
            {
                return UnitPrice * QtySold;
            }
        }


        public Final1(string sid, string iname,double up, int minqtyrestock, int iniqty, int qtysold, int qtyrestocked)
        {
            ItemId = sid;
            ItemName = iname;
            UnitPrice = up;
            QtyMinRestock = minqtyrestock;
            InitialQty = iniqty;
            QtySold= qtysold;
            QtyRestocked = qtyrestocked;
            




        }

        public override string ToString()
        {
            return ItemId + "\t" + ItemName.PadRight(17) +"\t"+"\t"+UnitPrice.ToString("c") + "\t"+"\t" + QtyMinRestock + "\t"+"\t" + InitialQty + "\t"+ "\t" + QtySold + "\t" +"\t"+"\t"+ QtyRestocked + "\t" + AvailableQty + "\t" + TotalSales;
        }
    }
}
