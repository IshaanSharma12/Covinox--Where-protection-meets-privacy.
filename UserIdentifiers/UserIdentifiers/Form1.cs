using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserIdentifiers
{
    public partial class Form1 : Form
    {
        List<Patients> Plist = new List<Patients>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader newstream = new StreamReader("username.csv"))
                {
                    string begin;
                    
                    if (!newstream.EndOfStream)
                    {
                        begin = newstream.ReadLine();

                        MessageBox.Show(begin);

                    }

                    while (!newstream.EndOfStream)
                    {
                        begin = newstream.ReadLine();

                        string[] hospital = begin.Split(',');

                        string Uname = hospital[0];
                        string identifierstr = hospital[1];
                        int.TryParse(identifierstr, out int identifier);
                        string fname = hospital[2];
                        string lname = hospital[3];

                        Patients newpatients = new Patients(Uname, identifier, fname, lname);

                        Plist.Add(newpatients);

                        listBox1.Items.Add(Plist);

                        StatusLabelTextBox.Text = ("Total Patients are" + Plist.Count);

                    }


                }



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            {

               

            }


        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex <= 0)
            {
                MessageBox.Show("Sorry you have selected header ");


            }

            else if (listBox1.SelectedIndex > 0)
            {
                int LB = listBox1.SelectedIndex;

                NewUsernameTextBox = Plist[LB - 1].Name; // ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR 

            }
        }
    }
}
