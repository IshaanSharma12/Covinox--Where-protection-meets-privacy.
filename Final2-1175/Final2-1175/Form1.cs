using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2_1175
{
    public partial class Form1 : Form
    {
        List<Details> students = new List<Details>();

        private void LoadDetails()
        {
            OutputListBox.Items.Add("StudentID\t\tFirstname\t\tLastname\t\tQuiz\t\tMidterm\t\tFinal\t\tTotalGrade\t\tLettergrade");
            foreach (Details child in students)
            {
                students.Add(child);

            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            LoadDetails();

            try
            {
                using (StreamReader read = new StreamReader("student_grades.csv"))
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

                        string sid = arrs[0];
                        string fname = arrs[1];
                        string lname = arrs[2];
                        string quizstr = arrs[3];
                        int.TryParse(quizstr, out int quiz);
                        string midstr = arrs[4];
                        int.TryParse(midstr, out int mid);
                        string finstr = arrs[5];
                        int.TryParse(finstr, out int fin);

                        Details newdetails = new Details(sid, fname, lname, quiz, mid, fin);

                        students.Add(newdetails);
                        OutputListBox.Items.Add(newdetails);
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateMidtermGradeButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("please choose some option");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("this is header, please choose something else");
            }
            else if (lbindex > 0)
            {
                if(!int.TryParse(MidTermGradeTextBox.Text, out int mt))
                {
                    MessageBox.Show("please fill in some marks");
                }
                else
                {
                    students[lbindex - 1].MidTerm = mt;
                    OutputListBox.Items[lbindex] = students[lbindex - 1];
                }
            }
        }

        private void UpdateQuizGradeButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose a valid value");
            }

            else if (lbindex == 0)
            {
                MessageBox.Show("please choose something greater than header");
            }
            else if(lbindex>1)
            {
                if(!int.TryParse(QuizGradeTextBox.Text, out int q))
                {
                    MessageBox.Show("Please ensure that you fill in some value");
                }
                else
                {
                    students[lbindex - 1].Quiz = q;
                    OutputListBox.Items[lbindex]= students[lbindex-1];

                }
            }
        }

        private void UpdateFinalGradeButton_Click(object sender, EventArgs e)
        {
            int lbindex = OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose some value");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose something else this is header");
            }
            else if (lbindex > 0)
            {
               if(!int.TryParse(FinalGradeTextBox.Text, out int fin))
                {
                    MessageBox.Show("Please ensure that you fill in something");
                }
               else
                {
                    students[lbindex-1].Final = fin;
                    OutputListBox.Items[lbindex] = students[lbindex-1]; 
                }
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            QuizGradeTextBox.Clear();
            MidTermGradeTextBox.Clear();
            FinalGradeTextBox.Clear();
        }

        private void DeleteSelectedQtyButton_Click(object sender, EventArgs e)
        {
            int lbindex= OutputListBox.SelectedIndex;

            if (lbindex < 0)
            {
                MessageBox.Show("Please choose a value");
            }
            else if (lbindex == 0)
            {
                MessageBox.Show("Please choose a value this is header");
            }
            else if (lbindex > 0)
            {
                students.RemoveAt(lbindex - 1);
                OutputListBox.Items.RemoveAt(lbindex);

            }
        }
    }
}
