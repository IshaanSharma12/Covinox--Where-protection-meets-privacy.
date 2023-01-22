using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namesandgrades
{
    public partial class Form1 : Form
    {
        List <Student> newlist = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadDetailsButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {

                 MessageBox.Show("Sorry the name field cannot be empty");
            
            }

            if (GradesTextBox.Text == "")
            {

                
                 MessageBox.Show("Sorry The grades cannot be empty and needs to be greater than zero");

                
            }

            else
            {
                Student child = new Student(NameTextBox.Text, GradesTextBox.Text);
                    

                newlist.Add(child);
                StatusLabelTextBox.Text = ("Users are" + newlist.Count+"\t" + "Name of User is" + NameTextBox.Text + "\t"  + "Grade is"+ GradesTextBox.Text);


                FinalListBox.Items.Add(child.Name + child.Grades);
            }

           
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text ="";
            GradesTextBox.Text = "";
            StatusLabelTextBox.Text = "";
            FinalListBox.Items.Clear();
        }

      

        private void LoadBack_Click(object sender, EventArgs e)
        {
            if (FinalListBox.SelectedIndex <= 0)
            {

                MessageBox.Show("Please make a valid selection you have selected a header or selected nothing");

            }

            else if(newlist.Count>0)
            {

                int ld = FinalListBox.SelectedIndex;

                NameTextBox.Text = newlist[ld - 1].Name;
                GradesTextBox.Text = newlist[ld - 1].Grades;

            }



        }
    }
}
