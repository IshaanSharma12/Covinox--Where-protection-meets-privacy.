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

namespace WinformAppPractice
{
    public partial class Form1 : Form
    {
        List<User> Passengers = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader stream = new StreamReader("samples.csv"))
                {
                    string eachline;

                    if (!stream.EndOfStream)
                    {
                        eachline= stream.ReadLine();
                        MessageBox.Show(eachline);
                    }
                }



            } catch(Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
         
               
        }

        private void ReverseNamesButton_Click(object sender, EventArgs e)
        {
            int lid = DisplayDetailsListBox.SelectedIndex;

            if (lid < 1)
            {
                MessageBox.Show("your Have selected the header, Please make a valid selection");

            }
           
        }

        private void ClearTextFields()
        {
            StatusLabel.Text = "";
           DisplayDetailsListBox.Items.Clear();
            PnameTextBox.Text = "";
            PidTextBox.Text = "";

        }

        private void displaydetails()
        {
            foreach(User user in Passengers)
            {
                Passengers.Add(user);

            }
                


        }
    }
}
