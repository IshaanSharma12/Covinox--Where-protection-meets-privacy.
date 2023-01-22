using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Design.Serialization;

namespace FinalEx3
{
    public partial class Form1 : Form
    {
        List <Manatee> myList = new List <Manatee> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            OutputListBox.Items.Clear ();
            OutputListBox.Items.Add("Location\t\tDate1\t\tDate2\t\tDate3\t\tDate4\t\tSC1\t" +
                                    "SC2\tSC3\tSC4\tMin SC\t Max SC\tAvg SC");

            foreach(Manatee data in myList)
            {
                OutputListBox.Items.Add(data);
            }
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            myList.Clear();
            try
            {          
                using(StreamReader  myManateeFile = new StreamReader("ManateeSampleData.csv"))
                {
                    string eachline;
                    if (!myManateeFile.EndOfStream)
                    {
                        eachline = myManateeFile.ReadLine();

                        while (!myManateeFile.EndOfStream)
                        {
                            eachline = myManateeFile.ReadLine();
                            string[] eachField = eachline.Split(',');
                            string location = eachField[0];
                            string date1 = eachField[1];
                            string date2 = eachField[2];
                            string date3 = eachField[3];
                            string date4 = eachField[4];
                            string sC1 = eachField[5];
                            string sC2 = eachField[6];
                            string sC3 = eachField[7];
                            string sC4 = eachField[8];

                            // parses all string data values to integer array values.
                            int.TryParse(sC1, out int D1);
                            int.TryParse(sC2, out int D2);
                            int.TryParse(sC3, out int D3);
                            int.TryParse(sC4, out int D4);

                            //loads all Dates into a string Array
                            string[] DatesArray = new string[4];
                            DatesArray[0] = date1;
                            DatesArray[1] = date2;
                            DatesArray[2] = date3;
                            DatesArray[3] = date4;

                            //loads all SightingCount Values into an integer array
                            int[] SightingCountArray = new int[4];
                            SightingCountArray[0] = D1;
                            SightingCountArray[1] = D2;
                            SightingCountArray[2] = D3;
                            SightingCountArray[3] = D4;


                            Manatee myManatees = new Manatee(location, DatesArray, SightingCountArray);
                            myList.Add(myManatees);
                        }
                    }
                    DisplayData();
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (myList.Count > 1)
            {
                if (lbindex <= 0)
                {
                    MessageBox.Show("Please select a record to update");
                }

                else
                {
                    if ((SC1TextBox.Text == "") || (SC2TextBox.Text == "") ||
                       (SC3TextBox.Text == "") || (SC4TextBox.Text == ""))
                    {
                        MessageBox.Show("Sighting Count Text Fields cannot be empty");
                        StatusLabel.Text = "Sighting Count Text Fields cannot be empty";
                    }

                    else if ((!int.TryParse(SC1TextBox.Text, out int SC1)) || SC1 < 0
                             || (!int.TryParse(SC2TextBox.Text, out int SC2) || SC2 < 0)
                             || (!int.TryParse(SC3TextBox.Text, out int SC3) || SC3 < 0)
                             || (!int.TryParse(SC4TextBox.Text, out int SC4) || SC4 < 0))
                    {
                        StatusLabel.Text = "Please enter a valid integer greater than 0";
                        MessageBox.Show("Please enter a valid integer greater than 0");
                    }

                    else
                    {
                        myList[lbindex - 1].Counts[0] = SC1;
                        myList[lbindex - 1].Counts[1] = SC2;
                        myList[lbindex - 1].Counts[2] = SC3;
                        myList[lbindex - 1].Counts[3] = SC4;

                        OutputListBox.Items[lbindex] = myList[lbindex-1];
                        StatusLabel.Text = "The Sighted Counts for " + myList[lbindex-1].Location + " has been updated!";
                    }

                }
            }
            
        }

        private void AvgButton_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach(Manatee value in myList)
            {
                sum += value.AvgSightingCount;             
            }
            double AvgOfAvg = sum / myList.Count;

            StatusLabel.Text = "The Average of all Sightseeing Counts is " + AvgOfAvg.ToString("F2");
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter newfile = new StreamWriter("UpdatedManateeData.csv"))
                {
                    char delimiter = ',';
                    string header = ("Location,Date1,Date2,Date3,Date4,SightingCount1," +
                                         "SightingCount2,SightingCount3,SightingCount4");
                    newfile.WriteLine(header);

                    foreach(Manatee row in myList)
                    {
                        newfile.WriteLine(row.Location + delimiter + row.Dates[0] + delimiter
                                           + row.Dates[1] + delimiter + row.Dates[2] + delimiter + row.Dates[3]
                                            + delimiter + row.Counts[0] + delimiter + row.Counts[1] + delimiter
                                            + row.Counts[2] + delimiter + row.Counts[3]);
                    }
                    StatusLabel.Text = "Saved " + myList.Count + " records to the file";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
