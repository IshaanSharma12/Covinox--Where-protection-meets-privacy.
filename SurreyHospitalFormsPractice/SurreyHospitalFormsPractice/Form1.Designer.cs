namespace SurreyHospitalFormsPractice
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
            this.PatientBio = new System.Windows.Forms.GroupBox();
            this.PatientAgeTextBox = new System.Windows.Forms.TextBox();
            this.PatientAgeLabel = new System.Windows.Forms.Label();
            this.PatientIdTextBox = new System.Windows.Forms.TextBox();
            this.PatientIdLabel = new System.Windows.Forms.Label();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.MainListBox = new System.Windows.Forms.ListBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UpdateSelectedUserButton = new System.Windows.Forms.Button();
            this.Subtracttenyearsbutton = new System.Windows.Forms.Button();
            this.AddtenyearsButton = new System.Windows.Forms.Button();
            this.SortUserButton = new System.Windows.Forms.Button();
            this.ReadUsersbutton = new System.Windows.Forms.Button();
            this.StatusLabelText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PatientBio.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientBio
            // 
            this.PatientBio.Controls.Add(this.PatientAgeTextBox);
            this.PatientBio.Controls.Add(this.PatientAgeLabel);
            this.PatientBio.Controls.Add(this.PatientIdTextBox);
            this.PatientBio.Controls.Add(this.PatientIdLabel);
            this.PatientBio.Controls.Add(this.PatientNameTextBox);
            this.PatientBio.Controls.Add(this.PatientNameLabel);
            this.PatientBio.ForeColor = System.Drawing.Color.IndianRed;
            this.PatientBio.Location = new System.Drawing.Point(12, 28);
            this.PatientBio.Name = "PatientBio";
            this.PatientBio.Size = new System.Drawing.Size(267, 145);
            this.PatientBio.TabIndex = 0;
            this.PatientBio.TabStop = false;
            this.PatientBio.Text = "groupBox1";
            // 
            // PatientAgeTextBox
            // 
            this.PatientAgeTextBox.Location = new System.Drawing.Point(118, 107);
            this.PatientAgeTextBox.Name = "PatientAgeTextBox";
            this.PatientAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatientAgeTextBox.TabIndex = 5;
            // 
            // PatientAgeLabel
            // 
            this.PatientAgeLabel.AutoSize = true;
            this.PatientAgeLabel.Location = new System.Drawing.Point(10, 107);
            this.PatientAgeLabel.Name = "PatientAgeLabel";
            this.PatientAgeLabel.Size = new System.Drawing.Size(62, 13);
            this.PatientAgeLabel.TabIndex = 4;
            this.PatientAgeLabel.Text = "Patient Age";
            // 
            // PatientIdTextBox
            // 
            this.PatientIdTextBox.Location = new System.Drawing.Point(118, 54);
            this.PatientIdTextBox.Name = "PatientIdTextBox";
            this.PatientIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatientIdTextBox.TabIndex = 3;
            // 
            // PatientIdLabel
            // 
            this.PatientIdLabel.AutoSize = true;
            this.PatientIdLabel.Location = new System.Drawing.Point(7, 57);
            this.PatientIdLabel.Name = "PatientIdLabel";
            this.PatientIdLabel.Size = new System.Drawing.Size(54, 13);
            this.PatientIdLabel.TabIndex = 2;
            this.PatientIdLabel.Text = "Patient ID";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(118, 20);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatientNameTextBox.TabIndex = 1;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Location = new System.Drawing.Point(7, 20);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(71, 13);
            this.PatientNameLabel.TabIndex = 0;
            this.PatientNameLabel.Text = "Patient Name";
            // 
            // MainListBox
            // 
            this.MainListBox.FormattingEnabled = true;
            this.MainListBox.Location = new System.Drawing.Point(434, 28);
            this.MainListBox.Name = "MainListBox";
            this.MainListBox.Size = new System.Drawing.Size(344, 225);
            this.MainListBox.TabIndex = 1;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(36, 304);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 53);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add User To List";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UpdateSelectedUserButton
            // 
            this.UpdateSelectedUserButton.Location = new System.Drawing.Point(154, 304);
            this.UpdateSelectedUserButton.Name = "UpdateSelectedUserButton";
            this.UpdateSelectedUserButton.Size = new System.Drawing.Size(100, 53);
            this.UpdateSelectedUserButton.TabIndex = 3;
            this.UpdateSelectedUserButton.Text = "Update Selected User";
            this.UpdateSelectedUserButton.UseVisualStyleBackColor = true;
            this.UpdateSelectedUserButton.Click += new System.EventHandler(this.UpdateSelectedUserButton_Click);
            // 
            // Subtracttenyearsbutton
            // 
            this.Subtracttenyearsbutton.Location = new System.Drawing.Point(337, 304);
            this.Subtracttenyearsbutton.Name = "Subtracttenyearsbutton";
            this.Subtracttenyearsbutton.Size = new System.Drawing.Size(75, 53);
            this.Subtracttenyearsbutton.TabIndex = 4;
            this.Subtracttenyearsbutton.Text = "Subtract 10 Years";
            this.Subtracttenyearsbutton.UseVisualStyleBackColor = true;
            this.Subtracttenyearsbutton.Click += new System.EventHandler(this.Subtracttenyearsbutton_Click);
            // 
            // AddtenyearsButton
            // 
            this.AddtenyearsButton.Location = new System.Drawing.Point(490, 304);
            this.AddtenyearsButton.Name = "AddtenyearsButton";
            this.AddtenyearsButton.Size = new System.Drawing.Size(75, 53);
            this.AddtenyearsButton.TabIndex = 5;
            this.AddtenyearsButton.Text = "Add 10 Years";
            this.AddtenyearsButton.UseVisualStyleBackColor = true;
            this.AddtenyearsButton.Click += new System.EventHandler(this.AddtenyearsButton_Click);
            // 
            // SortUserButton
            // 
            this.SortUserButton.Location = new System.Drawing.Point(633, 304);
            this.SortUserButton.Name = "SortUserButton";
            this.SortUserButton.Size = new System.Drawing.Size(75, 53);
            this.SortUserButton.TabIndex = 6;
            this.SortUserButton.Text = "Sort User";
            this.SortUserButton.UseVisualStyleBackColor = true;
            this.SortUserButton.Click += new System.EventHandler(this.SortUserButton_Click);
            // 
            // ReadUsersbutton
            // 
            this.ReadUsersbutton.Location = new System.Drawing.Point(54, 230);
            this.ReadUsersbutton.Name = "ReadUsersbutton";
            this.ReadUsersbutton.Size = new System.Drawing.Size(75, 23);
            this.ReadUsersbutton.TabIndex = 7;
            this.ReadUsersbutton.Text = "Read Users";
            this.ReadUsersbutton.UseVisualStyleBackColor = true;
            // 
            // StatusLabelText
            // 
            this.StatusLabelText.ForeColor = System.Drawing.Color.Gainsboro;
            this.StatusLabelText.Location = new System.Drawing.Point(153, 399);
            this.StatusLabelText.Name = "StatusLabelText";
            this.StatusLabelText.Size = new System.Drawing.Size(521, 20);
            this.StatusLabelText.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatusLabelText);
            this.Controls.Add(this.ReadUsersbutton);
            this.Controls.Add(this.SortUserButton);
            this.Controls.Add(this.AddtenyearsButton);
            this.Controls.Add(this.Subtracttenyearsbutton);
            this.Controls.Add(this.UpdateSelectedUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.MainListBox);
            this.Controls.Add(this.PatientBio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PatientBio.ResumeLayout(false);
            this.PatientBio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PatientBio;
        private System.Windows.Forms.TextBox PatientIdTextBox;
        private System.Windows.Forms.Label PatientIdLabel;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.TextBox PatientAgeTextBox;
        private System.Windows.Forms.Label PatientAgeLabel;
        private System.Windows.Forms.ListBox MainListBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button UpdateSelectedUserButton;
        private System.Windows.Forms.Button Subtracttenyearsbutton;
        private System.Windows.Forms.Button AddtenyearsButton;
        private System.Windows.Forms.Button SortUserButton;
        private System.Windows.Forms.Button ReadUsersbutton;
        private System.Windows.Forms.TextBox StatusLabelText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

