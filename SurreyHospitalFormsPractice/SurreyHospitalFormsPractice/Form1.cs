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

namespace SurreyHospitalFormsPractice
{
    
    public partial class Form1 : Form
    {
        List<Patient> patients = new List<Patient>();

        public Form1()
        {
            
            InitializeComponent();
            MainListBox.Items.Add("Patient Name" + "\t" + "Patient ID" + "\t" + "Patient age");
        }
        
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            
            if (PatientNameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if(!int.TryParse(PatientAgeTextBox.Text, out int age)||age<0 || age>100) 
            {
                MessageBox.Show("Age cannot be empty and needs to be between 0 and 100");

            }

            else if(!int.TryParse(PatientIdTextBox.Text, out int pid)|| pid < 0)
            {
                MessageBox.Show("Pid cannot be less than zero");

            }

            else
            {
                Patient newp = new Patient(PatientNameTextBox.Text, pid,age);
                patients.Add(newp);
                StatusLabelText.Text = ("Patients are" + newp);
                MainListBox.Items.Add(PatientNameTextBox.Text + "\t" + pid + "\t" + age);
            }

        }

        private void UpdateSelectedUserButton_Click(object sender, EventArgs e)
        {
            int lb = MainListBox.SelectedIndex;

            if (lb < 0)
            {
                MessageBox.Show("You have to select index that is greater than zero");

            }

            if (lb == 0)
            {

                MessageBox.Show("You have selected header, please select something else");

            }

            else
            {
               // Patient newform = new Patient(Name,pid,age);

               // patients[lb - 1] = newform;

                MainListBox.Items[lb - 1] = patients[lb - 1];

            }
           
        }

        private void Subtracttenyearsbutton_Click(object sender, EventArgs e)
        {
            int lb = MainListBox.SelectedIndex;
            if (lb<0)
            {
                MessageBox.Show("Please make a valid selection");

            }
            else if (lb > 0)
            {
                patients[lb - 1].Patientage -= 10; // the list updated
                MainListBox.Items[lb]= patients[lb - 1];

            }
        }

        private void AddtenyearsButton_Click(object sender, EventArgs e)
        {
            foreach(Patient ward in patients)
            {
                ward.Patientage += 10;

            } 
        }

        private void SortUserButton_Click(object sender, EventArgs e)
        {
           List<Patient> SortedList= patients.OrderBy(users=>users.Patientage).ToList();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainListBox.SelectedIndex < 0)
            {
                StatusLabelText.Text =("You have to select something");

            }
            else if (MainListBox.SelectedIndex == 0)
            {
                StatusLabelText.Text=("You have selected header");

            }
            else
            {

                int lb = MainListBox.SelectedIndex;

                PatientNameTextBox.Text = patients[lb - 1].PatientName;
                PatientAgeTextBox.Text = patients[lb - 1].Patientage.ToString();
                PatientIdTextBox.Text = patients[lb-1].PatientID.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamWriter write= new StreamWriter("basic.txt"))
                {
                    string header = "Username,userage,UserID\n";

                    write.WriteLine(header);

                    foreach(Patient boy in patients)
                    {
                        write.Write(boy.PatientName + "," + boy.PatientID + "," + boy.Patientage);

                    }

                    StatusLabelText.Text = patients.Count.ToString();
                    patients.Clear();
                    MainListBox.Items.Clear();
                }



            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
