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

namespace Final1_1175
{
    public partial class Form1 : Form
    {
        List <Calculations> numbers= new List<Calculations>();
        

        private void LoadDetails()
        {
            OutputListBox.Items.Add("Elements \t min");
            
             foreach( Calculations calc in numbers)
            {
               
                numbers.Add(calc);
            
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ComputeMinButton_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                //
                
            }
            
            
        }

        private void LoadDetailsButton_Click(object sender, EventArgs e)
        {
            LoadDetails();

            try
            {
                using(StreamReader newread= new StreamReader("TestScores.txt"))
                {
                    string Endofline;

                    if (!newread.EndOfStream)
                    {
                        Endofline = newread.ReadLine();

                    }

                    while(!newread.EndOfStream)
                    {
                        Endofline= newread.ReadLine();

                        string[] arrs = Endofline.Split(',');
                        string elementstr= arrs[0];
                        int.TryParse(elementstr, out int elements);

                        // creating the object 

                        Calculations newcalc = new Calculations(elements);
                        numbers.Add(newcalc);
                        OutputListBox.Items.Add(newcalc);


                        

                    }
                }


            }catch(Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ComputeMaxButton_Click(object sender, EventArgs e)
        {

            if (numbers.Count > 2)
            {

                Calculations Max = numbers.Max();


                GetMinTextBox.Text= Max.ToString();



            }
           
            
               
        }

        private void ComputeAvgButton_Click(object sender, EventArgs e)
        {
            GetAverageTextBox.Text = numbers.Max().ToString();
        }
    }
}
