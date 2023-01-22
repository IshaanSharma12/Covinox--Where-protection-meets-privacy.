using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3Forms
{
    public partial class Form1 : Form
    { 
       List <ChildDetails> Childs = new List <ChildDetails>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Addchildbutton_Click(object sender, EventArgs e)
        {
            if (ChildnameTextBox.Text == "")
            {
                MessageBox.Show("Error found nothing entered");

            }

             if (ChildcityTextBox.Text == " ")
            {

                MessageBox.Show("Error Nothing has been entered");
            }

             else
            {
                ChildDetails cobject = new ChildDetails(ChildnameTextBox.Text, ChildcityTextBox.Text);
                OutputListbox.Items.Add("THE NAME IS" + "\t" + "THE CITY IS");
                OutputListbox.Items.Add(cobject);
                statuslabel.Text = "Thanks for adding" + ChildnameTextBox.Text;
            }

             
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OutputListbox.Items.Clear();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (OutputListbox.SelectedIndex < 0)
            {

                
            }
        }
    }
}
