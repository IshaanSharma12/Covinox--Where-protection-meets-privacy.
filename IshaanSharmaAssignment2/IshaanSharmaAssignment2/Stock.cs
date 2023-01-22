using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshaanSharmaAssignment2
{
    internal class Stock
    {
        public string ItemCode { get; set; }
        public string Itemname { get; set; }
        public double Unitprice { get; set; }
        
       public  int QtyMinforRestock { get; set; }

       public  int InitialQty { get; set; }
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
                return QtySold * Unitprice;
            }
        }


        public Stock(string icode, string iname,double up, int qtyminforrestock, int iniqty, int qtysold, int qtyrestocked)
        {
            ItemCode = icode;
            Itemname = iname;
            Unitprice = up;
            QtyMinforRestock= qtyminforrestock;
            InitialQty = iniqty;
            QtySold = qtysold;
            QtyRestocked= qtyrestocked;

           
            

        }

        public override string ToString()
        {
            string outputstr = ItemCode + "\t" + Itemname.PadRight(17) + "\t" + "\t" + Unitprice.ToString("C") + "\t" + "\t" + QtyMinforRestock.ToString() + "\t" + "\t" + "\t" + InitialQty.ToString() + "\t" +"\t"+ QtySold.ToString() + "\t" +"\t"+ QtyRestocked +"\t"+"\t"+ AvailableQty +"\t"+"\t" + TotalSales.ToString("c");
            
            return outputstr.ToString();
        }
    }
}
