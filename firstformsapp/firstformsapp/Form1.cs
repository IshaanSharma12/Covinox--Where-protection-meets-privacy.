namespace firstformsapp
{
    public partial class Form1 : Form
    {    // Form Data/ Data Structure can be declared here
        // Form Data
       //Form Data Member

        List <Userinfo> UserList= new List<Userinfo> ();    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {

                MessageBox.Show("UserName Must Be Entered");


            }

            else if (UserIdTextBox.Text == "")
            {

                MessageBox.Show("User ID Must be Entered");


            }

            else if (UserAgeTextBox.Text == "")
            {

                MessageBox.Show("User Age Must be Entered");

            }
            else if (!int.TryParse(UserAgeTextBox.Text, out int UserAge)|| UserAge <= 0)
            {

                MessageBox.Show("User age cannot be zero");

            }

            else
            {
                MessageBox.Show("Yes! A Valid Input");

                Userinfo eachUser = new Userinfo(UserNameTextBox.Text, UserIdTextBox.Text, UserAge);
                
                UserList.Add(eachUser);

                Statuslabel.Text = ("Added user" + eachUser.Username+ eachUser.UserId+ eachUser.UserAge);
                Statuslabel.Text=("The Number of Users are"+ UserList.Count); // return the number of users in the list so far.
                OutputListBox.Items.Clear();

                 OutputListBox.Items.Add("User Name :" + eachUser.Username);
                OutputListBox.Items.Add("User ID :" + eachUser.UserId);
                OutputListBox.Items.Add("User age :" + eachUser.UserAge.ToString("F1"));

                //t not recognized in label, recongnized in listbox
                //n not recognized in listbox, recognized in label.
            }

            DisplayAllUsers();
            ClearTextFields();
            
           
        }

        private void ClearTextFields()
        {
            UserNameTextBox.Text = "";
            UserAgeTextBox.Text = "";
            UserIdTextBox.Text = "";
        }

         void DisplayAllUsers()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("USER ID \t USER NAME \t USER AGE");

            foreach ( Userinfo user in UserList )
            {
                UserList.Add(user);
               

            }


        }

        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OutputListBox.SelectedIndex >= 0)
            {
                if (OutputListBox.SelectedIndex == 0)
                {
                    MessageBox.Show("You have selected header");

                }

                else if (OutputListBox.SelectedIndex == 1)
                {
                    MessageBox.Show("You have selected data");

                }
            }
        }
    }
}