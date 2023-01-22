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

namespace Final4_1175
{
    public partial class Form1 : Form
    {
        List<Names> names= new List<Names>();   
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDetails()
        {
            OutputListBox.Items.Add("LastName");

            foreach(Names name in names)
            {
                names.Add(name);
            }

        }

        private void LoadUsersButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDetails();
                using (StreamReader read = new StreamReader("Names.csv"))
                {
                    string Endofline;

                    if (!read.EndOfStream)
                    {
                        Endofline= read.ReadLine();
                    }

                    while (!read.EndOfStream)
                    {
                        Endofline= read.ReadLine();

                        string[] arrs= Endofline.Split(',');

                        string fname = arrs[0];
                        string lname= arrs[1];

                        //creating the object

                        Names newnames = new Names(fname,lname);

                        names.Add(newnames);
                        OutputListBox.Items.Add(newnames);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchNamesButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.FindString(NameTextBox.Text);

            if (lbindex <= 0)
            {
                MessageBox.Show("This doesnt exist");

            }
            else
            {
                OutputListBox.SelectedIndex = lbindex;

            }
        }

        private void GetFirstNameButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;
            if (lbindex < 0)
            {
                MessageBox.Show("please choose some option");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("This is header please choose somthing else");
            }
            else
            {
                GetFirstNameTextBox.Text = names[lbindex - 1].ToString();
            }
        }

        private void CreateNewFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Names> SortedList= names.OrderBy(name=>name.Lastname).ToList();

                using(StreamWriter write= new StreamWriter("sortednames.csv"))
                {
                    string header = "Firstname\t\tLastname";
                    write.WriteLine(header);

                    foreach(Names users in SortedList)
                    {
                        write.WriteLine(users);
                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
