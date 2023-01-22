using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Familydetails
{
    public partial class Form1 : Form
    { List <Details> students = new List <Details>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UserclickButton_Click(object sender, EventArgs e)
        {
            if (ChildnametextBox2.Text == "")
            {
                MessageBox.Show("Please enter again, this cant be empty");
            }

            else if(ChildAgetextBox1.Text == "")
            {
                if(!int.TryParse(ChildnametextBox2.Text, out int age)|| age<=0)
                {
                    MessageBox.Show("AGE cannot be Less than or =0");

                }

            }

            else
            {
                MessageBox.Show("Thanks for inputting the details");

            }

            Details dets = new Details(ChildnametextBox2.Text, ChildAgetextBox1.Text); /// ERROR 
        }
    }
}
