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

namespace IshaanSharmaFinal
{
    public partial class Form1 : Form
    {
        List<Manatee> manaatee= new List<Manatee>() { };

        private void LoadAll()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("lOCATION\tDate1\tDate2\tDate3\tDate4\tSc1\tSc2\tSc2\tSc3\tSc4\tAvg");



        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadUsers_Click(object sender, EventArgs e)
        {
            LoadAll();

            try
            {
                using(StreamReader newreads= new StreamReader("ManateeSampleData.csv"))
                {
                    string EndofLine;

                    if (!newreads.EndOfStream)
                    {
                        EndofLine= newreads.ReadLine();

                    }

                    while (!newreads.EndOfStream)
                    {
                        EndofLine= newreads.ReadLine();

                        string[]arrs= EndofLine.Split(',');

                        string locs = arrs[0];
                        string date1 = arrs[1];
                        string date2 = arrs[2]; 
                        string date3 = arrs[3];
                        string date4 = arrs[4];
                        string sc1str = arrs[5];
                        int.TryParse(sc1str, out int sc1);
                        string sc2str= arrs[6];
                        int.TryParse(sc2str, out int sc2);
                        string sc3str= arrs[7];
                        int.TryParse(sc3str, out int sc3);
                        string sc4str= arrs[8];
                        int.TryParse(sc4str, out int sc4);

                        // creating the array for dates

                        string[] dates = new string[4];
                        dates[0]= date1;
                        dates[1]= date2;
                        dates[2]= date3;
                        dates[3]= date4;

                        // creating the Array for the scs

                        int[] scss = new int[4];

                        scss[0]= sc1;
                        scss[1]= sc2;
                        scss[2]= sc3;
                        scss[3]= sc4;

                        // Creating the Object 

                        Manatee newm= new Manatee(locs,dates,scss);

                        manaatee.Add(newm);
                        OutputListBox.Items.Add(newm);

                        

                    }

                }



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateSC1Button_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose something");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("please choose something else this is header");
            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(Sc1TextBox.Text, out int scSS) || scSS < 0)
                {
                    MessageBox.Show("sc cannot be less than zero");
                }

                else if (Sc1TextBox.Text == "")
                {
                    MessageBox.Show("Sorry this cannot be true, this field cannot be left empty");
                }

                else
                {
                    manaatee[lbindex - 1].SC[0]= scSS;
                    OutputListBox.Items[lbindex]= manaatee[lbindex-1];

                }

                ///////////////REST YOU KNOW ////////////////////////////////////////////////
            }
        }

        private void GetAvgButton_Click(object sender, EventArgs e)
        {
            double sum = 0;

            foreach(Manatee vals in manaatee)
            {
                sum += vals.AverageCounts;

            }


        }
    }
}
