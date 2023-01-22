using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBasic
{
    public partial class Form1 : Form
    { List<Details> passinfo = new List<Details>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (PassengerNameTextBox.Text == "")
            {
                MessageBox.Show("Name field Cannot Be Empty Please Try Again");
            }

           else  if (PassengerIDTextBox.Text == "")
            {
                    MessageBox.Show("This Passenger ID Cannot be zero, please try again");
            }

            else if(PassengerAgeTextBox.Text == "")
            {
               if(!int.TryParse(PassengerAgeTextBox.Text, out int ages)|| ages < 0)
                {
                    MessageBox.Show("The ages cannot be less than zero");

                }

            }


            else
            {
                Details passdetails = new Details(PassengerNameTextBox.Text, PassengerIDTextBox.Text, PassengerAgeTextBox.Text);
                {
                    DisplayDetailsListBox.Items.Clear();
                    passinfo.Add(passdetails);
                   DisplayDetailsListBox.Items.Add(PassengerNameTextBox.Text +"\t" + PassengerAgeTextBox.Text + "\t" + PassengerAgeTextBox.Text);
                    
                   
                }


                DisplayTable();
                



            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

         void DisplayTable()
        {
            foreach(Details usr in passinfo)
            {

                DisplayDetailsListBox.Items.Add(usr);
            }


        }

        private void Details_Click(object sender, EventArgs e)
        {
            if (DisplayDetailsListBox.SelectedIndex <= 0)
            {
                MessageBox.Show("You have selected header");

            }

            else
            {
                int lb= DisplayDetailsListBox.SelectedIndex;

                PassengerNameTextBox.Text= passinfo[lb - 1].PassengerName;
                PassengerIDTextBox.Text = passinfo[lb - 1].PassengerId;
                PassengerAgeTextBox.Text = passinfo[lb - 1].PassengerStatus;
            }
        }
    }
}
