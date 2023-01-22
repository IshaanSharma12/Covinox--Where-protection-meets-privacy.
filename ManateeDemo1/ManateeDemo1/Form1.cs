using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManateeDemo1
{
    public partial class Form1 : Form
    {
        List<Manatee> manatees= new List<Manatee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDetails()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("Location\t\tDate1\tDate2\tDate3\t\tDate4\tSC1\tSC2\tSC3\t\tSC4\tMinsc\tMaxsc\tAvgSC");

            foreach(Manatee man in manatees)
            {
                manatees.Add(man);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            LoadDetails();

            try
            {
                using(StreamReader reads= new StreamReader("ManateeSampleData.csv"))
                {
                    string EndofLine;

                    if (!reads.EndOfStream)
                    {

                        EndofLine= reads.ReadLine();

                    }

                    while (!reads.EndOfStream)
                    {
                        EndofLine= reads.ReadLine();

                        string[]arrs=EndofLine.Split(',');
                        string location= arrs[0];
                        string d1 = arrs[1];
                        string d2 = arrs[2];
                        string d3 = arrs[3];
                        string d4 = arrs[4];

                        string sctstr1 = arrs[5];
                        int.TryParse(sctstr1, out int sc1);
                        string sctstr2 = arrs[6];
                        int.TryParse(sctstr2, out int sc2);
                        string stcstr3 = arrs[7];
                        int.TryParse(stcstr3, out int sc3);
                        string stcstr4 = arrs[8];
                        int.TryParse(stcstr4, out int sc4);

                        // creating the array for Dates 

                        string[] Darray = new string[4];
                        Darray[0] = d1;
                        Darray[1] = d2;
                        Darray[2] = d3;
                        Darray[3] = d4;

                        // creating the array for the sighting count

                        int[] sccount = new int[4];
                        sccount[0] = sc1;
                        sccount[1] = sc2;
                        sccount[2] = sc3;
                        sccount[3] = sc4;

                        Manatee newobj = new Manatee(location, Darray, sccount);
                        manatees.Add(newobj);
                        OutputListBox.Items.Add(newobj);

                    }

                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("please select a valid input to update");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something greater than header");
            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(SC1TextBox.Text, out int sc1) || sc1 < 0)
                {
                    MessageBox.Show(" New SC1 CANNOT BE LESS THAN ZERO");
                }

                else if (SC1TextBox.Text == "")
                {
                    MessageBox.Show("Please fill a vlue to update");
                }

                else
                {
                    manatees[lbindex - 1].Counts[0] = sc1;
                    OutputListBox.Items[lbindex] = manatees[lbindex - 1];
                }
            }
        }

        private void UpdateSC2Button_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("please choose something to update");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something other than header to update");
            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(SC2TextBox.Text, out int scdo) || scdo < 0)
                {
                    MessageBox.Show("sc2 cannot be zero");
                }
                else if (SC2TextBox.Text == "")
                {
                    MessageBox.Show("TB cannot be empty");
                }

                else
                {
                    manatees[lbindex - 1].Counts[1] = scdo;
                    OutputListBox.Items[lbindex]= manatees[lbindex - 1];
                }
            }
        }

        private void UpdateSC3Button_Click(object sender, EventArgs e)
        {
            int lbindex= OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("please choose something ");
            }

            else if (lbindex ==0)
            {
                MessageBox.Show("Please choose something other than header to update");
            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(SC3TextBox.Text, out int scthree) || scthree < 0)
                {
                    MessageBox.Show("SC3 CANNOT BE LESS THAN ZERO");
                }

                else if (SC3TextBox.Text == "")
                {
                    MessageBox.Show("SC3 Cannot be empty");
                }
                else
                {
                    manatees[lbindex - 1].Counts[2] = scthree;
                    OutputListBox.Items[lbindex-1]= manatees[lbindex-1];


                }

               
                  
            }
        }

        private void UpdateSC3_Click(object sender, EventArgs e)
        {
            int lbindex= OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose  a vlaue");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose a valid value other than header");
            }

            else if (lbindex > 0)
            {
              if(!int.TryParse(SC4TextBox.Text, out int scfour) || scfour < 0)
                {
                    MessageBox.Show("SC4 CANNOT BE LESS THAN ZERO");
                }
              else if (SC4TextBox.Text == "")
                {
                    MessageBox.Show("TB Cannot be empty");
                }
              else
                {
                    manatees[lbindex - 1].Counts[3]= scfour;
                    OutputListBox.Items[lbindex] = manatees[lbindex - 1];

                }
            }
        }

        private void GetAvgButton_Click(object sender, EventArgs e)
        {
            double sum = 0;

            foreach(Manatee value in manatees)
            {
                sum += value.AvgSightCount;
            }

            double AvgofAvg = sum / manatees.Count;

            StatusLabelTextBox.Text = ("The Average is" + AvgofAvg);
        }

        private void WriteDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamWriter news= new StreamWriter("updatedinfo.csv"))
                {
                    string limits = ",";
                    string header = ("location,Date1,Date2,Date3,Date4,SC1,SC2,SC3,SC4,AvgSightingCount");

                    news.WriteLine(header);

                    foreach(Manatee user in manatees)
                    {
                        news.WriteLine(user.Location + limits + user.Date[0] + limits + user.Date[1] + limits + user.Date[2] + limits + user.Date[3] + limits + user.Counts[0] + limits+
                            user.Counts[1] + limits + limits + user.Counts[2] + limits + user.Counts[3]+limits+user.AvgSightCount);

                        StatusLabelTextBox.Text = "users that have been added are" + manatees.Count;
                    }
                }
                

            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
