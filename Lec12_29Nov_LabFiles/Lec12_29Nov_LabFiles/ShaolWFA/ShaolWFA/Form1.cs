using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShaolWFA
{
    public partial class Form1 : Form
    {
        List<Shoal> ShoalList = new List<Shoal>(); //maintains a list of all shoal objects added so far, called field property of the form
        //This demo is based on problem given in textbook in page 888 Chapter 13
        //Shoal Water Depth Application
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            //if you accidentally create a method like this, leave it alone.
            //if you need to remove it, it needs to be removed in the Designer code and here.
            //better to leave it alone for now
            //changing the name of a control after you create handler will not rename the event handler
            //for this reason, you must always create the control, change its name to the appropriate name,
            //before create the event handler for this control
        }

        private void AddShoalButton_Click(object sender, EventArgs e)
        {
            //MessageBox just for testing button click
            //MessageBox.Show("You clicked " +
            //    "on the add shoal button");

            //When this button is clicked, values from the textboxes are used, parsed if numeric, and 
            //used to create one shoal object, then that object is added to the list of shoal objects (ShoalList)


            //Create Shoal Object and add it to a list of shoals (ShoalList)
            AddItem();

            //Load all shoal objects from ShoalList list to output list box, 
            //ListBox contains a list of items, each item corresponds to one object coverted to String using
            //ToString() method defined in the class.
            LoadToListBox();

            //Clear TextBox Fields. Note that we do not want to clear the textbox text property unil the item is added to the list
            ClearFields();

            statusLabel.Text = "Added shoal object to the list and output list box";

        }

        private void AddItem()
        {
            //This method gets all values from TextBoxes, converts numeric values into numbers from string
            //got from Text property, create a shoal object, and then add it to the list

            //you can add several else if for validation if you like
            if(locationTextBox.Text=="" || stateTextBox.Text == "" || mileMarkerTextBox.Text == "")
            {
                MessageBox.Show("Please Enter LOcation state and mile marker");

            } else
            {

                double milemarker;
                double[] lowtides= new double[4];
                double[] hightides = new double[4];
                double.TryParse(mileMarkerTextBox.Text, out milemarker);
                double.TryParse(lowTidesTB1.Text, out lowtides[0]);
                double.TryParse(lowTidesTB2.Text, out lowtides[1]); 
                double.TryParse(lowTidesTB3.Text, out lowtides[2]);
                double.TryParse(lowTidesTB4.Text, out lowtides[3]);

                //For high tides
                double.TryParse(highTidesTB1.Text, out hightides[0]);
                double.TryParse(highTidesTB2.Text, out hightides[1]);
                double.TryParse(highTidesTB3.Text, out hightides[2]);
                double.TryParse(highTidesTB4.Text, out hightides[3]);

                string location = locationTextBox.Text;
                string state = stateTextBox.Text;

                Shoal eachshoal= new Shoal(location, state, milemarker,lowtides, hightides);

                ShoalList.Add(eachshoal);
            }
            
            
        }

        private void LoadToListBox()
        {
            //clear listbox and then load all shoal objects 
            //from shoal list to list box 

            //After clearing output list box, load all shoal objects from ShoalList list to output list box, 
            //ListBox contains a list of items, each item corresponds to one object coverted to String using
            //ToString() method defined in the class, and then add the string to the listbox
            //Make sure you understand the purpose of listbox and list of shoal objects, and the difference between
            //ShoalList and outputListBox here. outputListBox is just for viewing the data
            //ShoalList is the actual data

            outputListBox.Items.Clear(); //first clear previous items from listbox
            string headerStr = "Location\tState\tMileMarker....add rest of fields"; //creating header string, does not add it to the listbox
            outputListBox.Items.Add(headerStr); //this is what adds header line to the listbox

            foreach (Shoal shoualObj in ShoalList)
            {
                outputListBox.Items.Add(shoualObj.ToString()); //because is ToString() is defined in the Shoal class
            }

        }

        private void ClearFields()
        {
            //all textboxes are rest to empty strings
            locationTextBox.Text = ""; //resets the location textbox to empty
            stateTextBox.Text = "";
            mileMarkerTextBox.Text = "";
            lowTidesTB1.Text = "";
            lowTidesTB2.Text = "";
            lowTidesTB3.Text = "";
            lowTidesTB4.Text = "";
            highTidesTB1.Text = "";
            highTidesTB2.Text = "";
            highTidesTB3.Text = "";
            highTidesTB4.Text = "";
        }





        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = outputListBox.SelectedIndex; //value will be -1 if nothing selected

            //Load Item into Textboxes. This way whatever item is selected can be easily updated in the listbox when 
            //update button is clicked

            LoadItem(index-1); //ith item in listbox corresponds to (i-1)th item in the list
        }
        private void LoadItem(int index)
        {
            if(index>0 && ShoalList.Count > 0)
            {
                locationTextBox.Text = ShoalList[index].Location;
                stateTextBox.Text = ShoalList[index].State;
                mileMarkerTextBox.Text = ShoalList[index].MileMarker.ToString("F1");
                lowTidesTB1.Text = ShoalList[index].DepthLowTides[1].ToString();
                lowTidesTB2.Text = ShoalList[index].DepthLowTides[2].ToString();
                lowTidesTB3.Text = ShoalList[index].DepthLowTides[3].ToString();
                lowTidesTB4.Text = ShoalList[index].DepthLowTides[4].ToString();
                highTidesTB1.Text = ShoalList[index].DepthHighTides[1].ToString();
                highTidesTB2.Text = ShoalList[index].DepthHighTides[2].ToString();
                highTidesTB3.Text = ShoalList[index].DepthHighTides[3].ToString();
                highTidesTB4.Text = ShoalList[index].DepthHighTides[4].ToString();
                
            }
            else
            {
                ClearFields();

            }

        }

        

        private void updateSelectedItemButton_Click(object sender, EventArgs e)
        {
            UpdateItem(); //updates selected item in the list (not list box)

            LoadToListBox(); //loads the list to listbox

            statusLabel.Text = "Updated the selected item in the list and loaded list into output listbox";
        }

        private void UpdateItem()
        {
            
            
        }
        
        private void BtnReadFromFile_Click(object sender, EventArgs e)
        {
            //Read from file method using file name
            ReadFromFile("ShoalInputFile.csv");
            //load to listbox
            LoadToListBox();

            statusLabel.Text = "Read " + ShoalList.Count() + " records from input file";
        }

        private void ReadFromFile(string fileName)
        {
            ShoalList= new List<Shoal>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string eachline;
                    if (!reader.EndOfStream)
                    {

                        eachline = reader.ReadLine();

                    }

                    while (!reader.EndOfStream)
                    {
                        eachline= reader.ReadLine();

                        string[] fieldsarray= eachline.Split(',');
                        string location= fieldsarray[0];
                        string state= fieldsarray[1];
                        double.TryParse(fieldsarray[2], out double milemarker);
                        string lowtidestr= fieldsarray[3];
                        string hightidestr= fieldsarray[4];

                        double[] lowtides = new double[4];
                        double[] hightides = new double[5];

                        string[] lowtidesStrArray = lowtidestr.Split('-');
                        for(int i=0; i<lowtidesStrArray.Length; i++)
                        {
                            double.TryParse(lowtidesStrArray[i], out lowtides[i]);

                        }

                        string[] hightidesStrArray= hightidestr.Split('-');
                        for(int i=0; i<hightidesStrArray.Length; i++)
                        {

                            double.TryParse(hightidesStrArray[i], out hightides[i]);

                        }
                    }


                }
                    
                 



                




            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void BtnWriteFile_Click(object sender, EventArgs e)
        {
            
        }
        private void WriteToFile(string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    string headerline= ("location, state, MileMarker, LowTideAvg, HighTideAvg");
                    writer.WriteLine(headerline);
                    foreach(Shoal shoal in ShoalList)
                    {
                        writer.WriteLine(shoal.Location + "," + shoal.MileMarker.ToString("f1") + "," +
                            shoal.LowTideAvg.ToString("f1") + "," + shoal.HighTideAvg.ToString("f1"));






                    }
                }


            }catch(Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //accidentally created when form was double clicked
            //will talk about this in the online session
        }
    }
}
