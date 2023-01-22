using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FridayIshaan_Final
{
    
    public partial class Form1 : Form
    {
        List<Grocery> items = new List<Grocery>(); // Creating the List Here 
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadItems()
        {
            string header = "ITEMCODE\t\tITEMNAME\t\tUNITPRICE\tQTYMINFORRESTOCK\tINIQTY\t\tQTYSOLD\tQTYRESTOCKED\tAVAILABLEQTY\tTotalSales";
            OutPutListBox.Items.Add(header);
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            LoadItems();
            try
            {
                using (StreamReader read = new StreamReader("superstore.csv"))
                {
                    string EndofLine;

                    if (!read.EndOfStream)
                    {
                       EndofLine= read.ReadLine();
                    }

                    while (!read.EndOfStream)
                    {
                        EndofLine= read.ReadLine();
                        string[]arrs= EndofLine.Split(',');
                        string icode = arrs[0];
                        string iname = arrs[1];
                        string unitpricestr = arrs[2];
                        double.TryParse(unitpricestr, out double unitprice);
                        string qtyminforrestockstr = arrs[3];
                        int.TryParse(qtyminforrestockstr, out int qtyminforrestock);
                        string intqtystr = arrs[4];
                        int.TryParse(intqtystr, out int iniqty);
                        string qtysoldstr = arrs[5];
                        int.TryParse(qtysoldstr, out int qtysold);
                        string qtyrestockedstr = arrs[6];
                        int.TryParse(qtyrestockedstr, out int qtyrestocked);

                        // creating the object

                        Grocery store = new Grocery(icode, iname, unitprice, qtyminforrestock, iniqty, qtysold, qtyrestocked); 
                        items.Add(store);
                        OutPutListBox.Items.Add(store);
                    }
                }



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateNewItemName_Click(object sender, EventArgs e)
        {
            int lbindex = OutPutListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose a value");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose a valid value this is header");
            }

            else if (lbindex > 0)
            {
                if(!int.TryParse(NewItemNameTextBox.Text, out int newqty)|| newqty<0|| newqty > items[lbindex-1].AvailableQty)
                {
                    MessageBox.Show("please ensure that new qty is more than zero and less than the available qty");
                }
                else
                {
                    items[lbindex - 1].QtySold = newqty;
                    OutPutListBox.Items[lbindex] = items[lbindex - 1];
                }
            }
        }

        private void GetItemNameinTextBox_Click(object sender, EventArgs e)
        {
            int lbindex = OutPutListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose a valid value");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("please choose something else this is header");
            }

            else if (lbindex > 0)
            {
                ItemNameTextBox.Text = items[lbindex-1].ItemName;
            }
        }

        private void UpdateRestockedQtyButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutPutListBox.SelectedIndex;
            if (lbindex < 0)
            {

                MessageBox.Show("Please choose something");
            }

            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something else, this is header");
            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(RestockedQtyTextBox.Text,  out int restockdqty)|| restockdqty <= 0)
                {
                    MessageBox.Show("This cannot be true please enter values more than zero");

                    
                }
                else
                {
                    items[lbindex - 1].QtyRestocked = restockdqty;
                    OutPutListBox.Items[lbindex] = items[lbindex - 1];

                }

            }

        }

        private void DeleteSelectedElementButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutPutListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose a valid value");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something more than header");
            }
            else if (lbindex > 0)
            {
                items.RemoveAt(lbindex - 1);

                OutPutListBox.Items.RemoveAt(lbindex);
            }
        }

        private void SortElementsBasedonSales_Click(object sender, EventArgs e)
        {
            try
            {
                List<Grocery> SortedList = items.OrderBy(users => users.QtySold).ToList();

                items = SortedList;

                SortedList = (from users in SortedList
                              where users.QtySold > 20
                              orderby users.UnitPrice
                              select users).ToList();
               
                using (StreamWriter write= new StreamWriter("sale.csv"))
                {
                    string limit = ",";

                    string header = "Itemcode,Itemname,Unitprice,Qtyminforrestock,InitialQty,Qtysold,Qtyrestocked,AvailableQty,TotalSales";

                    write.WriteLine(header);

                    foreach(Grocery users in SortedList)
                    {
                        write.WriteLine(users.ItemCode + limit + users.ItemName + users.UnitPrice+limit+users.UnitPrice+limit+users.IniQty+limit+users.QtySold+limit+users.QtyRestocked+limit+users.AvailableQty+limit+users.TotalSales);

                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lbindex = OutPutListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Sorry you need to select something");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Sorry you need to select something more than header");
            }
            else if (lbindex > 0)
            {
               if(UpdateItemNameTextBox.Text=="")
                {
                    MessageBox.Show("Sorry Itemcode cannot be below zero");

                }
                else
                {
                    items[lbindex - 1].ItemCode = UpdateItemNameTextBox.Text;
                    OutPutListBox.Items[lbindex-1]= items[lbindex-1];

                }
            }
        }
    }
}
