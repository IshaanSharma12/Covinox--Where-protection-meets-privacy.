namespace UserInfoApp
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserAgeLabel = new System.Windows.Forms.Label();
            this.UserAgeTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.UserBioGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.UpdateSelectedUserBtn = new System.Windows.Forms.Button();
            this.SortUsersByAgeBtn = new System.Windows.Forms.Button();
            this.DeleteSelUserBtn = new System.Windows.Forms.Button();
            this.ReadFromFileBtn = new System.Windows.Forms.Button();
            this.WriteToFileBtn = new System.Windows.Forms.Button();
            this.Add10ToEachUserBtn = new System.Windows.Forms.Button();
            this.Sub10FromSelUserBtn = new System.Windows.Forms.Button();
            this.UserBioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(15, 21);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(93, 16);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(68, 20);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(41, 222);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(60, 45);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add User To List";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(33, 41);
            this.UserIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(44, 13);
            this.UserIdLabel.TabIndex = 3;
            this.UserIdLabel.Text = "User Id:";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(93, 38);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(68, 20);
            this.UserIdTextBox.TabIndex = 4;
            // 
            // UserAgeLabel
            // 
            this.UserAgeLabel.AutoSize = true;
            this.UserAgeLabel.Location = new System.Drawing.Point(23, 62);
            this.UserAgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserAgeLabel.Name = "UserAgeLabel";
            this.UserAgeLabel.Size = new System.Drawing.Size(54, 13);
            this.UserAgeLabel.TabIndex = 5;
            this.UserAgeLabel.Text = "User Age:";
            // 
            // UserAgeTextBox
            // 
            this.UserAgeTextBox.Location = new System.Drawing.Point(93, 59);
            this.UserAgeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserAgeTextBox.Name = "UserAgeTextBox";
            this.UserAgeTextBox.Size = new System.Drawing.Size(68, 20);
            this.UserAgeTextBox.TabIndex = 6;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(123, 304);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(361, 70);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Status will be displayed here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // UserBioGroupBox
            // 
            this.UserBioGroupBox.BackColor = System.Drawing.Color.PeachPuff;
            this.UserBioGroupBox.Controls.Add(this.UserAgeTextBox);
            this.UserBioGroupBox.Controls.Add(this.UserAgeLabel);
            this.UserBioGroupBox.Controls.Add(this.UserIdTextBox);
            this.UserBioGroupBox.Controls.Add(this.UserIdLabel);
            this.UserBioGroupBox.Controls.Add(this.UserNameTextBox);
            this.UserBioGroupBox.Controls.Add(this.UserNameLabel);
            this.UserBioGroupBox.Location = new System.Drawing.Point(19, 29);
            this.UserBioGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserBioGroupBox.Name = "UserBioGroupBox";
            this.UserBioGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserBioGroupBox.Size = new System.Drawing.Size(195, 112);
            this.UserBioGroupBox.TabIndex = 8;
            this.UserBioGroupBox.TabStop = false;
            this.UserBioGroupBox.Text = "User Bio";
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(311, 23);
            this.OutputListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(293, 173);
            this.OutputListBox.TabIndex = 9;
            this.OutputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // UpdateSelectedUserBtn
            // 
            this.UpdateSelectedUserBtn.Location = new System.Drawing.Point(123, 213);
            this.UpdateSelectedUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateSelectedUserBtn.Name = "UpdateSelectedUserBtn";
            this.UpdateSelectedUserBtn.Size = new System.Drawing.Size(73, 61);
            this.UpdateSelectedUserBtn.TabIndex = 11;
            this.UpdateSelectedUserBtn.Text = "Update Selected User";
            this.UpdateSelectedUserBtn.UseVisualStyleBackColor = true;
            this.UpdateSelectedUserBtn.Click += new System.EventHandler(this.UpdateSelectedUserBtn_Click);
            // 
            // SortUsersByAgeBtn
            // 
            this.SortUsersByAgeBtn.Location = new System.Drawing.Point(669, 191);
            this.SortUsersByAgeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SortUsersByAgeBtn.Name = "SortUsersByAgeBtn";
            this.SortUsersByAgeBtn.Size = new System.Drawing.Size(120, 34);
            this.SortUsersByAgeBtn.TabIndex = 22;
            this.SortUsersByAgeBtn.Text = "Sort Users By Age";
            this.SortUsersByAgeBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteSelUserBtn
            // 
            this.DeleteSelUserBtn.Location = new System.Drawing.Point(560, 237);
            this.DeleteSelUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteSelUserBtn.Name = "DeleteSelUserBtn";
            this.DeleteSelUserBtn.Size = new System.Drawing.Size(123, 39);
            this.DeleteSelUserBtn.TabIndex = 21;
            this.DeleteSelUserBtn.Text = "Delete Selected User";
            this.DeleteSelUserBtn.UseVisualStyleBackColor = true;
            // 
            // ReadFromFileBtn
            // 
            this.ReadFromFileBtn.Location = new System.Drawing.Point(680, 84);
            this.ReadFromFileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReadFromFileBtn.Name = "ReadFromFileBtn";
            this.ReadFromFileBtn.Size = new System.Drawing.Size(120, 42);
            this.ReadFromFileBtn.TabIndex = 20;
            this.ReadFromFileBtn.Text = "Read Users From File";
            this.ReadFromFileBtn.UseVisualStyleBackColor = true;
            // 
            // WriteToFileBtn
            // 
            this.WriteToFileBtn.Location = new System.Drawing.Point(649, 141);
            this.WriteToFileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WriteToFileBtn.Name = "WriteToFileBtn";
            this.WriteToFileBtn.Size = new System.Drawing.Size(169, 39);
            this.WriteToFileBtn.TabIndex = 19;
            this.WriteToFileBtn.Text = "Write Users To File";
            this.WriteToFileBtn.UseVisualStyleBackColor = true;
            // 
            // Add10ToEachUserBtn
            // 
            this.Add10ToEachUserBtn.Location = new System.Drawing.Point(387, 226);
            this.Add10ToEachUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add10ToEachUserBtn.Name = "Add10ToEachUserBtn";
            this.Add10ToEachUserBtn.Size = new System.Drawing.Size(143, 54);
            this.Add10ToEachUserBtn.TabIndex = 18;
            this.Add10ToEachUserBtn.Text = "Add 10 Years to Every User";
            this.Add10ToEachUserBtn.UseVisualStyleBackColor = true;
            // 
            // Sub10FromSelUserBtn
            // 
            this.Sub10FromSelUserBtn.Location = new System.Drawing.Point(218, 222);
            this.Sub10FromSelUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sub10FromSelUserBtn.Name = "Sub10FromSelUserBtn";
            this.Sub10FromSelUserBtn.Size = new System.Drawing.Size(153, 57);
            this.Sub10FromSelUserBtn.TabIndex = 17;
            this.Sub10FromSelUserBtn.Text = "Subtract 10 Years From Selected User";
            this.Sub10FromSelUserBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 380);
            this.Controls.Add(this.SortUsersByAgeBtn);
            this.Controls.Add(this.DeleteSelUserBtn);
            this.Controls.Add(this.ReadFromFileBtn);
            this.Controls.Add(this.WriteToFileBtn);
            this.Controls.Add(this.Add10ToEachUserBtn);
            this.Controls.Add(this.Sub10FromSelUserBtn);
            this.Controls.Add(this.UpdateSelectedUserBtn);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.UserBioGroupBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.AddUserButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UserBioGroupBox.ResumeLayout(false);
            this.UserBioGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label UserAgeLabel;
        private System.Windows.Forms.TextBox UserAgeTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox UserBioGroupBox;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Button UpdateSelectedUserBtn;
        private System.Windows.Forms.Button SortUsersByAgeBtn;
        private System.Windows.Forms.Button DeleteSelUserBtn;
        private System.Windows.Forms.Button ReadFromFileBtn;
        private System.Windows.Forms.Button WriteToFileBtn;
        private System.Windows.Forms.Button Add10ToEachUserBtn;
        private System.Windows.Forms.Button Sub10FromSelUserBtn;
    }
}

