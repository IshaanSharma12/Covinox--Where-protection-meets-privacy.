using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;

namespace CovinoxFamilyCompanion
{
    public partial class Form1 : Form
    {
        List<families> vaccinedata = new List<families>();
        
        public void LoadDetails()
        {
            string header = "Name" + "\t"+"\t" + "Dose" + "\t\t" + "Age" + "\t" + "Month" + "\t" + "Months Left";
            OutputListbox.Items.Add(header);


        }
     
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDetails();

            try
            {
                using (StreamReader reads = new StreamReader("CovidVaccineInfoUpdates.csv"))
                {
                    string EndOfLine;

                    if (!reads.EndOfStream)
                    {
                        EndOfLine = reads.ReadLine();


                    }
                    while (!reads.EndOfStream)
                    {
                        EndOfLine=reads.ReadLine();

                        String[] arrs = EndOfLine.Split(',');
                        string Name = arrs[0];
                        string Dose = arrs[1];
                        string Age = arrs[2];
                        int.TryParse(Age, out int age);
                        string Month = arrs[3];
                        int.TryParse(Month, out int month);

                        // Creating the Object 

                        families newdata = new families(Name, Dose,age,month);
                        vaccinedata.Add(newdata);
                        OutputListbox.Items.Add(newdata);




                    }

                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListbox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose something");
            }
            if (lbindex == 0)
            {
                MessageBox.Show("Pleae choose something other than header");
            }
            else if(lbindex>0)
            {
                if(!int.TryParse(UpdateValueTextBox.Text, out int value)|| value < 0|| value>12)
                {
                    MessageBox.Show("Please enter a value greater than zero, less than twelve");
                    
                }
                else
                {
                    vaccinedata[lbindex-1].Month = value;
                    OutputListbox.Items[lbindex] = vaccinedata[lbindex - 1];
                }

            }

            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListbox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose some value to delete");
            }

            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something other than header to delete");
            }

            else
            {

                vaccinedata.RemoveAt(lbindex - 1);
                OutputListbox.Items.RemoveAt(lbindex);
            }
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ChangeDateofDoseButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListbox.SelectedIndex;

            if (lbindex < 0)
            {

                MessageBox.Show("Please make a selection");

            }

            else if (lbindex == 0)
            {

                MessageBox.Show("Please choose something other than header");
            }

            else if (lbindex > 0)
            {

                if(!int.TryParse(AgeTextBox.Text, out int age)||age<0 || age > 100)
                {

                    MessageBox.Show("Age cannot be less than 0 or more than 100");
                }

                else
                {
                    vaccinedata[lbindex-1].Age= age;
                    OutputListbox.Items[lbindex] = vaccinedata[lbindex-1];

                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Changenamebutton_Click_1(object sender, EventArgs e)
        {
            int lbindex=OutputListbox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose something");
            }

            else if (lbindex == 0)
            {

                MessageBox.Show("Please choose something other than header");
            
            }
            else if (lbindex > 0)
            {
                if (TextFieldName.Text == "")
                {
                    MessageBox.Show("This section cannot be empty put in some value");
                }

                else
                {
                    vaccinedata[lbindex - 1].Names = TextFieldName.Text;
                    OutputListbox.Items[lbindex]= vaccinedata[lbindex-1];

                }

            }
        }

        private void ChangeDoseNameButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListbox.SelectedIndex;

            if (lbindex == 0)
            {
                MessageBox.Show("Please Choose something other than header");
            }

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose something to change");
            }

             else if (lbindex > 0)
            {
                if (DoseNameTextBox.Text == "")
                {
                    MessageBox.Show("Dose name cannot be left empty");
                }

                

                else
                {

                    vaccinedata[lbindex-1].Dose=DoseNameTextBox.Text;
                    OutputListbox.Items[lbindex] = vaccinedata[lbindex-1];
                        
                }
            }
        }

        private void GetValueButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListbox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose something to shown");
            }

            else if (lbindex== 0)
            {

                MessageBox.Show("Please choose something other than header to be shown");
            }

            if (lbindex > 0)
            {
                ValueDisplayTextBox.Text = vaccinedata[lbindex-1].Names;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<families> Sortedlist = vaccinedata.OrderBy(vaccinedata => vaccinedata.Names).ToList();

                vaccinedata = Sortedlist;

                Sortedlist = (from users in Sortedlist
                              where users.MonthLeft <3 
                              orderby users.Month
                              select users).ToList();

                using (StreamWriter writes= new StreamWriter("Updatedfamily.csv"))
                {
                    String limit = ",";
                    String header = "Name,Dose,Age,Month,Monthleft";
                    writes.WriteLine(header);

                    foreach(families fams in vaccinedata)
                    {

                        writes.WriteLine(fams.Names + limit + fams.Dose + limit + fams.Age + limit + fams.Month + fams.MonthLeft);
                    }


                }



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void WritetoFileButton_Click(object sender, EventArgs e)
        {
            OutputListbox.Items.Add(TextFieldName.Text +"\t"+ AgeTextBox.Text);
            
        }
    }
    }
