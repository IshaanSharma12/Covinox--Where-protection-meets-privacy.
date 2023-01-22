//ISHAAN SHARMA
//300362679

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IshaanSharmaAssignment2
{
    public partial class Form1 : Form
    {
        List <Stock> Grocery= new List<Stock> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAllusers()
        {
            outputListBox.Items.Clear ();
            outputListBox.Items.Add("Itemcode\t \t  ItemName\t\tUnitPrice\tQtyminforrestock\t " +
                "IniQty\tQtySold\t\tQtyRestocked\tAvailableQty\tTotalSales");
            

            foreach(Stock stock in Grocery)
            {
                outputListBox.Items.Add(stock);
            }
        }

        private void LoadGroceryDataButton_Click(object sender, EventArgs e)
        {
            
            LoadAllusers();
            
            try
            {
                using (StreamReader mystream= new StreamReader("superstore.csv"))
                {
                    string EndOfLine;
                    if (!mystream.EndOfStream)
                    {
                        EndOfLine= mystream.ReadLine ();

                    }
                    while(!mystream.EndOfStream)
                    {
                        EndOfLine= mystream.ReadLine ();
                        string[] arr1= EndOfLine.Split (',');
                        string ItemCode= arr1[0];
                        string ItemName= arr1[1];
                        string UnitPriceStr= arr1[2];
                        double.TryParse(UnitPriceStr, out double UnitPrice);
                        string QtyMinforRestockstr= arr1[3];
                        int.TryParse(QtyMinforRestockstr, out int QtyMinforRestock);
                        string iniqtystr= arr1[4];
                        int.TryParse(iniqtystr, out int iniqty);
                        string QtySoldstr= arr1[5];
                        int.TryParse(QtySoldstr, out int QtySold);
                        string QtyRestockedstr= arr1[6];
                        int.TryParse(QtyRestockedstr, out int QtyRestocked);
                        
                         
                        Stock newstock = new Stock(ItemCode.ToString(), ItemName, UnitPrice, QtyMinforRestock, iniqty, QtySold, QtyRestocked);

                        Grocery.Add(newstock);
                        outputListBox.Items.Add(newstock);

                        StatusLabelTextBox.Text = Grocery.Count + "Items added in the list";
                    }

                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void UpdateSoldQtyButton_Click(object sender, EventArgs e)
        {
            int lbindex = outputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                StatusLabelTextBox.Text = "Please choose some option";
            }

            else if (lbindex == 0)
            {
                StatusLabelTextBox.Text = "please choose some other option, this is header";
            }

            else if (lbindex > 0)
            {
                if(!int.TryParse(QuantitySoldTextBox.Text, out int Qty) || Qty < 0|| Qty > Grocery[lbindex-1].AvailableQty)
                {
                    StatusLabelTextBox.Text = "please fill value more than zero and Ensure that the Quantity sold updated is less than available Qty";
                }
                else
                {
                    Grocery[lbindex-1].QtySold = Qty;
                    outputListBox.Items[lbindex] = Grocery[lbindex-1];

                    StatusLabelTextBox.Text = (" Sold Qty Updated for item list" + Grocery[lbindex - 1].ItemCode);
                }

            }
        }

        private void DeleteSelectedGroceryItemButton_Click(object sender, EventArgs e)
        {
            int lbindex = outputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                StatusLabelTextBox.Text = "Please choose option";
            }

            else if (lbindex == 0)
            {
                StatusLabelTextBox.Text = "Please choose some other option this is header";
            }

            else if (lbindex > 0)
            {

                Grocery.RemoveAt(lbindex-1);
                outputListBox.Items.RemoveAt(lbindex);

                StatusLabelTextBox.Text = "Element deleted for" + Grocery[lbindex-1].ItemCode;
            }
        }

        private void UpdateRestockedQtyButton_Click(object sender, EventArgs e)
        {
            int lbindex = outputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                StatusLabelTextBox.Text = "Please choose some value";
            }

            else if (lbindex == 0)
            {
                StatusLabelTextBox.Text = "Please choose somethig greater than header";
            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(QuantityRestockedTextBox.Text, out int Quantityrestocked)|| Quantityrestocked < 0)
                {
                    StatusLabelTextBox.Text = "Please fill value greater than zero";

                }

                else
                {
                    Grocery[lbindex-1].QtyRestocked= Quantityrestocked;
                    outputListBox.Items[lbindex] = Grocery[lbindex - 1];


                }
                

            }
        }

        private void SortItemsButton_Click(object sender, EventArgs e)
        {
            List<Stock> SortedList = Grocery.OrderByDescending(user => user.QtySold).ToList();
            Grocery = SortedList;
            LoadAllusers();
        }

        private void SavegroceryDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                string limit = ",";
                using (StreamWriter newwrite = new StreamWriter("updatedgrocery.csv"))
                {
                    String header = ("Itemcode,Itemname,Unitprice,Qtyminforrestock,Iniqty,Qtysold,Qtyrestocked");
                    newwrite.Write(header);

                    foreach(Stock groc in Grocery)
                    {
                        newwrite.WriteLine(groc.ItemCode + limit + groc.Itemname + limit + groc.Unitprice + limit + groc.QtyMinforRestock + limit +
                            groc.QtyMinforRestock + limit + groc.InitialQty + groc.QtySold + groc.QtyRestocked);

                        StatusLabelTextBox.Text = ("Items added are" + Grocery.Count);
                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveSalesReportbutton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Stock> SortedList = Grocery.OrderBy(user => user.QtySold > 0).ToList();

                SortedList = (from user in SortedList
                              where user.QtySold > 0
                              select user).ToList();

                using (StreamWriter newstream= new StreamWriter("grocerysales.csv"))
                {
                    string limit = ",";
                    string header = ("Itemcode,Itemname,Unitprice,QtySold,Sales");
                    newstream.WriteLine(header);

                    foreach(Stock newstock in SortedList)
                    {

                        newstream.WriteLine(newstock.ItemCode + limit + newstock.Itemname +limit+ newstock.Unitprice +limit+ newstock.QtySold +limit+ newstock.TotalSales);

                        

                    }

                    StatusLabelTextBox.Text = "Items added are" + SortedList.Count;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveRestockNeedsReport_Click(object sender, EventArgs e)
        {
            try
            {
                List<Stock> SortedList= Grocery.OrderBy(user=>user.AvailableQty>0).ToList();
                SortedList = (from user in SortedList
                              where user.AvailableQty < user.QtyMinforRestock
                              select user).ToList();

                using (StreamWriter newwrite = new StreamWriter("groceryrestocks.csv"))
                {
                    String limit = ",";
                    string header = "itemcode,itemname,Qtyminforrestock,AvailableQty";
                    newwrite.WriteLine(header);

                    foreach(Stock item in SortedList)
                    {
                        newwrite.WriteLine(item.ItemCode +limit+ item.Itemname +limit+ item.QtyMinforRestock +limit+ item.AvailableQty);

                    }

                    StatusLabelTextBox.Text="Items added are"+ SortedList.Count;
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
