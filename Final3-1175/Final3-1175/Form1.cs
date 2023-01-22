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

namespace Final3_1175
{
    public partial class Form1 : Form
    {
        List<Manatee> sealife = new List<Manatee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadListBox_Click(object sender, EventArgs e)
        {
            try
            {

                using(StreamReader read= new StreamReader("ManateeSampleData.csv"))
                {
                    string Endofline;

                    if (!read.EndOfStream)
                    {
                        Endofline = read.ReadLine();
                    }

                    while (!read.EndOfStream)
                    {
                        Endofline = read.ReadLine();
                        string[] arrs = Endofline.Split(',');
                        string loc = arrs[0];
                        string dates = arrs[4];
                        string counts = arrs[4];


                      //  Manatee newManatee = new Manatee(loc//                    }

                }

            } //catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
