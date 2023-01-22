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

namespace SampleFormsPractice
{
    public partial class Form1 : Form
    {
        List <Class> newl = new List<Class>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadUsers_Click(object sender, EventArgs e)
        {

            if (NameTextBox.Text == "")
            {

                MessageBox.Show("Name cannot be empty");
            }

            else if (AgeTextBox.Text == "")
            {

                MessageBox.Show("Age Cannot be empty");
            }

            else if(!int.TryParse(AgeTextBox.Text, out int Age)|| Age < 0)
            {
                MessageBox.Show("Age cannot be zero, it must be a whole number and greater than zero");

            }

            else
            {
                Class newobj = new Class(NameTextBox.Text, Age);

                newl.Add(newobj);

                UserDetailsListBox.Items.Add( newobj.Name);
                UserDetailsListBox.Items.Add( + newobj.Age);
            }

        }

        private void DisplayAllUsers()
        {

            UserDetailsListBox.Items.Add("Username" + "\t" + "User ID");

            foreach( Class user in newl)
            {

                newl.Add(user);

            }


        }

        private void LoadUserstoText_Click(object sender, EventArgs e)
        {
            if (UserDetailsListBox.SelectedIndex <= 0)
            {

                if (UserDetailsListBox.SelectedIndex == 0)
                {
                    MessageBox.Show("You are selecting header");


                }
                else
                {
                    int LB= UserDetailsListBox.SelectedIndex;

                    NameTextBox.Text = newl[LB - 1].Name;
                    AgeTextBox.Text = newl[LB - 1].Age.ToString();

                }
                    
               

            }




        }
    }
}
