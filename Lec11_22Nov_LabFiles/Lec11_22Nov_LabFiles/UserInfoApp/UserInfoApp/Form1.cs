using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInfoApp
{
    public partial class Form1 : Form
    {
        //form field members
        //form data, form data members
        //form data structure
        List<UserInfo> UserList = new List<UserInfo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //accidentally created by double clicking form
            //DO NOT DELETE
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World\nMy name is Priya");
            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("User Name must be entered");
            } else if (UserIdTextBox.Text == "")
            {
                MessageBox.Show("User Id cannot be empty");
            } else if (UserAgeTextBox.Text == "")
            {
                MessageBox.Show("User Age cannot be empty");
            } else if (!int.TryParse(UserAgeTextBox.Text, out int UserAge) 
                            || UserAge <= 0)
            {
                MessageBox.Show("Age must be whole number > 0");
            } else
            {
               // MessageBox.Show("Yay! valid input");
                //Create UserInfo object
                UserInfo eachUser = new UserInfo(UserNameTextBox.Text,
                                                 UserIdTextBox.Text, UserAge);


                OutputListBox.Items.Clear();
                OutputListBox.Items.Add("User Name:" + eachUser.UserName);
                OutputListBox.Items.Add("User Id: " + eachUser.UserId);
                OutputListBox.Items.Add("User Age: " + eachUser.UserAge.ToString("F1"));

                //Add user info object to list of objects
                UserList.Add(eachUser);

                //update status label
                //\t - not recognized in a label, tab is recognized in listbox
                //\n - is recognized in a label, \n not recognized in listbox
                StatusLabel.Text = "Added user: " + eachUser.ToString();
                StatusLabel.Text += "\nTotal Users: " + UserList.Count;

                //display all objects from list into listbox
                LoadAllUsersToListBox();

                //reset text fields
                ClearTextFields();
            }

        }

        private void ClearTextFields()
        {
            UserNameTextBox.Text = "";
            UserIdTextBox.Text = "";
            UserAgeTextBox.Text = "";
        }
        private void LoadAllUsersToListBox()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("UserId\tUserName\tUserAge"); //header line added to the listbox
            foreach(UserInfo user in UserList)
            {
                OutputListBox.Items.Add(user);
            }
        }

        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OutputListBox.SelectedIndex >= 0)
            {
                if (OutputListBox.SelectedIndex == 0)
                {
                    StatusLabel.Text = "You have selected the header";

                }
                else
                {
                    int lbs = OutputListBox.SelectedIndex;
                    UserNameTextBox.Text = UserList[lbs - 1].UserName;
                    UserIdTextBox.Text = UserList[lbs - 1].UserId;
                    UserAgeTextBox.Text = UserList[lbs - 1].UserAge.ToString();

                }
            }
        }

        private void UpdateSelectedUserBtn_Click(object sender, EventArgs e)
        {
            if(OutputListBox.SelectedIndex <= 0)
            {
                StatusLabel.Text = "Nothing Has been selected please select the data to update";


            }
            else if(UserNameTextBox.Text=="" || UserIdTextBox.Text==""|| UserAgeTextBox.Text == "")
            {
                MessageBox.Show("Fill All fields");

            }else if(!int.TryParse(UserAgeTextBox.Text, out int usrage ) || usrage < 0) {

                MessageBox.Show("Age cannot be less than zero");
            }
            else
            {
                UserInfo users = new UserInfo(UserNameTextBox.Text, UserIdTextBox.Text, usrage);

                int ls= OutputListBox.SelectedIndex;

                UserList[ls - 1] = users;

                OutputListBox.Items[ls] = UserList[ls - 1];

            }

            
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            //Ignore 
        }
    }
}
