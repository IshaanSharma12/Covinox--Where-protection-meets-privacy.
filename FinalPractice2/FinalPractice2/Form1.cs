using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPractice2
{
    public partial class Form1 : Form
    {
        List<Grocery> items = new List<Grocery> ();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadDetails()
        {
          string header = " Itemcode\t\t Itemname \t\t UnitPrice \t QtyminRestock \t IniQty \t\t QtySold\t QtyRestocked\t\t AailableQty \t\t TotalSales";

          OutputListBox.Items.Add(header);

         foreach(Grocery item in items)
            {
                OutputListBox.Items.Add(item);

            }
        
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            // IGNORE THIS DONT DELETE THIS 

        }

        private void LoadItemsButton_Click(object sender, EventArgs e)
        {
            LoadDetails();
            try
            {
                using(StreamReader newstream= new StreamReader("superstore.csv"))
                {
                    string EndofLine;

                    if (!newstream.EndOfStream)
                    {
                        EndofLine = newstream.ReadLine();

                    }

                    while (!newstream.EndOfStream)
                    {
                        EndofLine= newstream.ReadLine();

                        string[] arrs= EndofLine.Split(',');
                        string ItemCode= arrs[0];
                        string ItemName= arrs[1];
                        string UnitPricestr = arrs[2];
                        double.TryParse(UnitPricestr, out double Unitprice);
                        string QtyminforRestockstr = arrs[3];
                        int.TryParse(QtyminforRestockstr, out int QtyminforRestock);
                        string Iniqtystr = arrs[4];
                        int.TryParse(Iniqtystr, out int Iniqty);
                        string qtysoldstr= arrs[5];
                        int.TryParse(qtysoldstr, out int Qtysold);
                        string QtyRestockedstr= arrs[6];
                        int.TryParse(QtyRestockedstr, out int QtyRestocked);

                        // creating the object 
                        

                        Grocery newgroc = new Grocery(ItemCode.ToString(), ItemName, Unitprice, QtyminforRestock,Iniqty, Qtysold, QtyRestocked);
                        items.Add(newgroc);
                        OutputListBox.Items.Add(newgroc);
                    }
                }



            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void UpdateSoldQtyButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                StatusLabelTextBox.Text = "Please choose a valid option";
            }

            else if (lbindex == 0)
            {
                StatusLabelTextBox.Text = "This is Header please choose another option";   
            }

            else if(lbindex>0)
            {
                if (!int.TryParse(QtySoldTextBox.Text, out int qtysoldd) || qtysoldd <= 0|| qtysoldd > items[lbindex-1].Iniqty)
                {
                    StatusLabelTextBox.Text = "Please ensure Qty sold is greater than 0 and less than min qty for restock";
                }

                else
                {
                    items[lbindex-1].QtySold= qtysoldd;
                    OutputListBox.Items[lbindex] = items[lbindex-1];
                }

            }
        }

        private void DeleteSelectedQtyButton_Click(object sender, EventArgs e)
        {
            int lbindex= OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                StatusLabelTextBox.Text = "Please choose value more than 0";
            }
            else if (lbindex == 0)
            {
                StatusLabelTextBox.Text = "Please choose some other value, this is header";
            }

            else if (lbindex > 0)
            {
                items.RemoveAt(lbindex-1);
                OutputListBox.Items.RemoveAt(lbindex);

                


            }
        }

        private void UpdateQtyRestockedButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                StatusLabelTextBox.Text = "Please choose value more than zero";
            }

            else if (lbindex == 0)
            {
                StatusLabelTextBox.Text = "Please choose value more than this, its a header";
                            
            }

            else if (lbindex > 0)
            {
                if(!int.TryParse(QtyRestockedTextBox.Text, out int Qtyrestocked)|| Qtyrestocked < 0)
                {
                    StatusLabelTextBox.Text = "Please fill in something greater than zero";
                }

                else
                {

                    items[lbindex-1].QtyRestocked= Qtyrestocked;
                    OutputListBox.Items[lbindex] = items[lbindex - 1];
                }
            }
        }

        private void SortUsersButton_Click(object sender, EventArgs e)
        {
            List <Grocery> SortedList= items.OrderByDescending(users => users.QtySold).ToList();
            items = SortedList;
            LoadDetails();
           
        }

        private void SaveGroceryData_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamWriter write= new StreamWriter("datawrite.csv"))
                {
                    string limits = ",";

                    string header = "Itemcode,Itemname,UnitPrice,QtyminRestock,IniQty,QtySold,QtyRestocked";

                    write.WriteLine(header);

                    foreach(Grocery groc in items)
                    {
                        write.WriteLine(groc.ItemCode + limits + groc.ItemName + limits + groc.UnitPrice + limits + groc.QtyMinforRestock + limits + groc.Iniqty + limits + groc.QtySold + limits + groc.QtyRestocked);

                        StatusLabelTextBox.Text = "Items written in list are" + items.Count;
                    }

                }

            } catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SaveSalesReport_Click(object sender, EventArgs e)
        {
           
            try
            {
                List<Grocery> Sortedlist = items.OrderBy(users => users.QtySold > 0).ToList();
                Sortedlist = (from user in Sortedlist
                              where user.QtySold > 0
                              orderby user.ItemName
                              select user).ToList();

                using(StreamWriter write=new StreamWriter("grocerysale.csv"))
                {
                    string limits = ",";
                    string header = "Itemcode,Itemname,Qtysold,Unitprice,sales";

                    write.WriteLine(header);

                    foreach(Grocery user in Sortedlist)
                    {
                        write.WriteLine(user.ItemCode+ limits + user.ItemName+limits+ user.QtySold+limits+ user.UnitPrice+user.TotalSales);

                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveRestockNeedsButton_Click(object sender, EventArgs e)
        { 
            try
            {
                List<Grocery> SortedList= items.OrderBy(user=>user.AvailableQty>0).ToList();

                SortedList = (from user in SortedList
                              where user.AvailableQty > user.QtyMinforRestock
                              select user).ToList();

                using(StreamWriter writes= new StreamWriter("upditto.csv"))
                {
                    string limits = ",";
                    string header = "Itemcode,Itemname,Qtyminforrestock,AvailableQty";

                    writes.WriteLine(header);

                    foreach(Grocery newl in SortedList)
                    {
                        writes.WriteLine(newl.ItemCode + limits + newl.ItemName + limits + newl.QtyMinforRestock + limits + newl.AvailableQty);

                    }


                }

            }catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
