using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HackEDIshaanSharma
{
    public partial class Form1 : Form
    {
        List<Treess> tree = new List<Treess>();
        public Form1()
        {
        
            InitializeComponent();


         
        }

        private void LoadItems()
        {

            string header = ("Index" + "\t" + "\t" + "Girth" + "\t" + "\t" + "Height" + "\t" + "\t" + "Volume" + "\t" + "\t" + "Width");
            OutputListBox1.Items.Add(header);
        }

        private void UpdateLocalityButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox1.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("please select something");
            }

            else if (lbindex == 0)
            {
                MessageBox.Show("Please select something other than header");
            }

            else if (lbindex > 0)
            {
                if(!int.TryParse(UpdateTreeTextBox.Text, out int UpdateTree) || UpdateTree < 0)
                {
                    MessageBox.Show("New tree Height cannot be less than zero");
                }

                else
                {
                    tree[lbindex - 1].Height = UpdateTree;
                    OutputListBox1.Items[lbindex] = tree[lbindex-1];
                }
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamWriter Writes = new StreamWriter("UpdatedTrees.csv"))
                {
                    string Endofline;

                    




                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            LoadItems();

            try
            {
                using (StreamReader read = new StreamReader("trees.csv"))
                {
                    string Endofline;

                    if (! read.EndOfStream)
                    {
                        Endofline = read.ReadLine();
                    }
                    while (!read.EndOfStream)
                    {
                        Endofline = read.ReadLine();

                        string[] arrs = Endofline.Split(',');
                        string index = arrs[0];
                        int.TryParse(index, out int iindex);
                        string Girth = arrs[1];
                        double.TryParse(Girth, out double girth);
                        string Height = arrs[2];
                        int.TryParse(Height, out int height);
                        string Volume = arrs[3];
                        double.TryParse(Volume, out double volume);

                        Treess trees = new Treess(iindex, girth, height, volume);
                        tree.Add(trees);
                        OutputListBox1.Items.Add(trees);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Treess> Sortedlist = tree.OrderBy(tree => tree.Height > 20).ToList();

            Sortedlist = (from tree in Sortedlist
                          where tree.Height > 20.0
                          && tree.Index > 10
                          select tree).ToList();

            Sortedlist = tree;
            try
            {
                using(StreamWriter writes= new StreamWriter("UpdatedTrees.csv"))
                {
                    string limits = ",";
                    string header = "Index,Girth,Height,Volume,Width";

                    writes.WriteLine(header);




                    foreach(Treess treees in Sortedlist)
                    {
                        writes.WriteLine(treees.Index + limits + treees.Girth + limits + treees.Height + limits + treees.Volume + limits + treees.Width);
                        
                    }

                    MessageBox.Show("Done");
                }

                


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteLocalityButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox1.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please make a valid selection, it cannot be empty");
            }

            else if(lbindex == 0)
            {
                MessageBox.Show("Please select something other than header");
            }

            else if(lbindex>0)
            {
                tree.RemoveAt(lbindex - 1);
                OutputListBox1.Items.RemoveAt(lbindex);

                MessageBox.Show("Item Deleted Succesfully");
            }
        }

        private void GetGirthButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox1.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose something");
            }

            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something other than header");
            }

            else if (lbindex > 0)
            {
                GetGirthTextBox.Text = tree[lbindex-1].Girth.ToString();

                MessageBox.Show("Done Successfully");
            }
        }
    }
}
