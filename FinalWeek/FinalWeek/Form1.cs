using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWeek
{
    public partial class Form1 : Form
    {
        List<Final1> newl= new List<Final1>();  

        public void LoadDetails()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("Itemcode\tItemName\t\tUnitPrice\t\tQtyMinForRestock\t\tInitialQty\t\t\tQtySold\t\tQtyRstocked\tAvailableQty\tSales");
            foreach(Final1 final in newl)
            {
                OutputListBox.Items.Add(final);
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadItemsButton_Click(object sender, EventArgs e)
        {
            LoadDetails();

            try
            {

                using (StreamReader newstream = new StreamReader("superstore.csv"))
                {
                    string EndofLine;

                    if (!newstream.EndOfStream)
                    {
                        EndofLine= newstream.ReadLine();

                    }
                    while (!newstream.EndOfStream)
                    {
                        EndofLine= newstream.ReadLine();
                        string[] arrs = EndofLine.Split(',');

                        string ItemCode= arrs[0];
                        string ItemName= arrs[1];
                        string UnitPricestr = arrs[2];
                        double.TryParse(UnitPricestr, out double unitprice);
                        string QtyMinforRestockstr = arrs[3];
                        int.TryParse(QtyMinforRestockstr, out int QtyMinforRestock);
                        string Iniqtystr = arrs[4];
                        int.TryParse(Iniqtystr, out int iniqty);
                        string QtySoldstr = arrs[5];
                        int.TryParse(QtySoldstr, out int Qtysold);
                        string QtyRestockedstr= arrs[6];
                        int.TryParse(QtyRestockedstr, out int QtyRestocked);

                        // creating the object

                        Final1 newfinals = new Final1(ItemCode, ItemName, unitprice,QtyMinforRestock,iniqty,Qtysold,QtyRestocked);

                        newl.Add(newfinals);
                        OutputListBox.Items.Add(newfinals);
                    }

                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ChangeSoldQtyButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please select a option");
            }

            else if (lbindex == 0)
            {
                MessageBox.Show("PLease select option other than header");
            }

            else if (lbindex > 0)
            {
                if(!int.TryParse(   UpdateSoldQtyTextBox.Text,out int UpdateSoldQty) || UpdateSoldQty < 0)
                {
                    MessageBox.Show("Please fill in different value greater than zero");

                }

                else
                {
                    newl[lbindex-1].QtySold=UpdateSoldQty;
                    OutputListBox.Items[lbindex] = newl[lbindex-1];

                }
            }
        }

        private void ChangeRestockedQtyButton_Click(object sender, EventArgs e)
        {
            int lbindex=OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose element greater than 0");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something other than header");
            }

            else if (lbindex > 0)
            {
                if(!int.TryParse(UpdateRestockedQtyTextBox.Text, out int UpdateRestockedQty) || UpdateRestockedQty < 0)
                {
                    MessageBox.Show("hjdsghdsg");

                }

                else
                {
                    newl[lbindex - 1].QtyRestocked = UpdateRestockedQty;
                    OutputListBox.Items[lbindex] = newl[lbindex - 1];
                }
            }
                    
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;
            if (lbindex < 0)
            {
                MessageBox.Show("please ensure that element chosen is more than zero");
            }

            else if (lbindex == 0)
            {
                MessageBox.Show("You are choosing the header please choose any other element");
            }
            else if (lbindex > 0)
            {
                newl.RemoveAt(lbindex - 1);
                OutputListBox.Items.RemoveAt(lbindex);
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            List<Final1> SortedList = newl.OrderBy(user => user.QtySold).ToList();

            SortedList = (from user in SortedList
                          where user.QtySold>0 && 
                          select user).ToList();

        }
    }
}
