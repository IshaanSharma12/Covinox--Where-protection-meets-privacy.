namespace Final4_1175
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.LoadUsersGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadUsersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SearchNamesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetFirstNameLabel = new System.Windows.Forms.Label();
            this.GetFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.GetFirstNameButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CreateNewFileButton = new System.Windows.Forms.Button();
            this.LoadUsersGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(13, 33);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1039, 199);
            this.OutputListBox.TabIndex = 0;
            // 
            // LoadUsersGroupBox
            // 
            this.LoadUsersGroupBox.Controls.Add(this.LoadUsersButton);
            this.LoadUsersGroupBox.Location = new System.Drawing.Point(14, 277);
            this.LoadUsersGroupBox.Name = "LoadUsersGroupBox";
            this.LoadUsersGroupBox.Size = new System.Drawing.Size(156, 161);
            this.LoadUsersGroupBox.TabIndex = 1;
            this.LoadUsersGroupBox.TabStop = false;
            this.LoadUsersGroupBox.Text = "Load Users Group Box";
            // 
            // LoadUsersButton
            // 
            this.LoadUsersButton.Location = new System.Drawing.Point(6, 59);
            this.LoadUsersButton.Name = "LoadUsersButton";
            this.LoadUsersButton.Size = new System.Drawing.Size(145, 23);
            this.LoadUsersButton.TabIndex = 2;
            this.LoadUsersButton.Text = "LOAD NAMES";
            this.LoadUsersButton.UseVisualStyleBackColor = true;
            this.LoadUsersButton.Click += new System.EventHandler(this.LoadUsersButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchNamesButton);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.SearchNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(176, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching Group Box";
            // 
            // SearchNameLabel
            // 
            this.SearchNameLabel.AutoSize = true;
            this.SearchNameLabel.Location = new System.Drawing.Point(6, 43);
            this.SearchNameLabel.Name = "SearchNameLabel";
            this.SearchNameLabel.Size = new System.Drawing.Size(126, 13);
            this.SearchNameLabel.TabIndex = 0;
            this.SearchNameLabel.Text = "Enter the name to search";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(138, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // SearchNamesButton
            // 
            this.SearchNamesButton.Location = new System.Drawing.Point(6, 66);
            this.SearchNamesButton.Name = "SearchNamesButton";
            this.SearchNamesButton.Size = new System.Drawing.Size(166, 23);
            this.SearchNamesButton.TabIndex = 2;
            this.SearchNamesButton.Text = "Search the Names";
            this.SearchNamesButton.UseVisualStyleBackColor = true;
            this.SearchNamesButton.Click += new System.EventHandler(this.SearchNamesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetFirstNameButton);
            this.groupBox2.Controls.Add(this.GetFirstNameTextBox);
            this.groupBox2.Controls.Add(this.GetFirstNameLabel);
            this.groupBox2.Location = new System.Drawing.Point(439, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 161);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get First Name";
            // 
            // GetFirstNameLabel
            // 
            this.GetFirstNameLabel.AutoSize = true;
            this.GetFirstNameLabel.Location = new System.Drawing.Point(6, 31);
            this.GetFirstNameLabel.Name = "GetFirstNameLabel";
            this.GetFirstNameLabel.Size = new System.Drawing.Size(77, 13);
            this.GetFirstNameLabel.TabIndex = 0;
            this.GetFirstNameLabel.Text = "Get First Name";
            // 
            // GetFirstNameTextBox
            // 
            this.GetFirstNameTextBox.Location = new System.Drawing.Point(89, 24);
            this.GetFirstNameTextBox.Name = "GetFirstNameTextBox";
            this.GetFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetFirstNameTextBox.TabIndex = 1;
            // 
            // GetFirstNameButton
            // 
            this.GetFirstNameButton.Location = new System.Drawing.Point(21, 69);
            this.GetFirstNameButton.Name = "GetFirstNameButton";
            this.GetFirstNameButton.Size = new System.Drawing.Size(129, 23);
            this.GetFirstNameButton.TabIndex = 2;
            this.GetFirstNameButton.Text = "Get First Name";
            this.GetFirstNameButton.UseVisualStyleBackColor = true;
            this.GetFirstNameButton.Click += new System.EventHandler(this.GetFirstNameButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CreateNewFileButton);
            this.groupBox3.Location = new System.Drawing.Point(732, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 151);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // CreateNewFileButton
            // 
            this.CreateNewFileButton.Location = new System.Drawing.Point(79, 59);
            this.CreateNewFileButton.Name = "CreateNewFileButton";
            this.CreateNewFileButton.Size = new System.Drawing.Size(143, 23);
            this.CreateNewFileButton.TabIndex = 0;
            this.CreateNewFileButton.Text = "Create New File";
            this.CreateNewFileButton.UseVisualStyleBackColor = true;
            this.CreateNewFileButton.Click += new System.EventHandler(this.CreateNewFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoadUsersGroupBox);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoadUsersGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.GroupBox LoadUsersGroupBox;
        private System.Windows.Forms.Button LoadUsersButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchNamesButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SearchNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetFirstNameButton;
        private System.Windows.Forms.TextBox GetFirstNameTextBox;
        private System.Windows.Forms.Label GetFirstNameLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreateNewFileButton;
    }
}

