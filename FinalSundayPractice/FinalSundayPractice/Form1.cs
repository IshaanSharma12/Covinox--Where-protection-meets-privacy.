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

namespace FinalSundayPractice
{
    public partial class Form1 : Form
    {
        List <Details> users= new List <Details> ();    
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAllDetails()
        {
            string header = "Name\t\tSex\t\tAge\t\tHeight\t\t\tWeight\t\tBmi\t\tYob";
            OutputListBox.Items.Add(header);

            foreach(Details user in users)
            {
                users.Add(user);
            }

        }

        private void ReadContentsButton_Click(object sender, EventArgs e)
        {
            LoadAllDetails();

            try
            {
                using(StreamReader displayfile= new StreamReader("biostats.csv"))
                {
                    string EndOfLine;

                    if (!displayfile.EndOfStream)
                    {
                        EndOfLine = displayfile.ReadLine();
                    }
                    while (!displayfile.EndOfStream)
                    {
                        EndOfLine= displayfile.ReadLine();

                        string[] arrs = EndOfLine.Split(',');

                        string Uname = arrs[0];
                        string gender = arrs[1];
                        string agestr = arrs[2];
                        int.TryParse(agestr, out int age);
                        string Heightstr = arrs[3];
                        int.TryParse(Heightstr, out int Hieght);
                        string Weightstr = arrs[4]; 
                        int.TryParse(Weightstr, out int Weight);

                        Details newusers = new Details(Uname, gender, age, Hieght, Weight);
                        users.Add(newusers);
                        OutputListBox.Items.Add(newusers);
                        
                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetNewAgeButton_Click(object sender, EventArgs e)
        {
            int lbindex= OutputListBox.SelectedIndex;
            if (lbindex < 0)
            {
                MessageBox.Show("Please choose a user to update the age");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("This is header please choose something else");

            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(NewAgeTextBox.Text, out int newwage) || newwage > 100 || newwage < 0)
                {
                    MessageBox.Show("Sorry the age cannot be more than 100 or less than zero");
                }
                else
                {
                    users[lbindex-1].Age = newwage;
                    OutputListBox.Items[lbindex] = users[lbindex - 1];

                }
            }
        }

        private void GetNewWeightButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose some option to delete");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something other than header");
            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(NewWeightTextBox.Text, out int nweight) || nweight < 0)
                {
                    MessageBox.Show("Sorry weight cannot be less than zero");
                }
                else
                {
                    users[lbindex - 1].Weight = nweight;
                    OutputListBox.Items[lbindex] = users[lbindex - 1];
                }

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose option to delete");

            }

            if (lbindex == 0)
            {
                MessageBox.Show("Please choose something else this is header");
            }
            else if (lbindex > 0)
            {

                users.RemoveAt(lbindex - 1);
                OutputListBox.Items.RemoveAt(lbindex);

                MessageBox.Show("Element deleted succesfully");
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            List<Details> SortedList = users.OrderBy(user => user.Weight < 60).ToList();

            SortedList = (from users in SortedList
                          where users.Weight < 160
                          && users.Age > 40
                          orderby users
                          select users).ToList();
            SortedList = users;
            try
            {
                using (StreamWriter write= new StreamWriter("updatedWeights.csv"))
                {
                    string limits = ",";

                    string header = "Username,Gender,Age,Height,Weight";

                    write.WriteLine(header);

                    foreach(Details dets in SortedList)
                    {

                        write.WriteLine(dets.Name+limits+dets.Sex+limits+dets.Age+limits+dets.Height+limits+dets.Weight+dets.BMI+limits+dets.Yob);

                    }

                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.FindString(SearchNameTextBox.Text);

            if (lbindex < 0)
            {
                MessageBox.Show("Sorry name not found");
                SearchNameTextBox.Text = "";
            }
            else
            {
                lbindex = OutputListBox.SelectedIndex;

                MessageBox.Show("Congrats its been found");


            }
        }

        private void CopyNameButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose valid option");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("This is header");
            }
            else if (lbindex > 0)
            {
                CopyNameTextBox.Text = users[lbindex - 1].Name;

            }
        }
    }
}
