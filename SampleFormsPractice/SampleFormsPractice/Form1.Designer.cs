namespace SampleFormsPractice
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
            this.Namelabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.UserDetailsListBox = new System.Windows.Forms.ListBox();
            this.LoadUsers = new System.Windows.Forms.Button();
            this.LoadUserstoText = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(12, 89);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(63, 13);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Enter Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(75, 89);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(57, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(15, 141);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(54, 13);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Enter Age";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(75, 141);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(57, 20);
            this.AgeTextBox.TabIndex = 4;
            // 
            // UserDetailsListBox
            // 
            this.UserDetailsListBox.FormattingEnabled = true;
            this.UserDetailsListBox.Location = new System.Drawing.Point(341, 29);
            this.UserDetailsListBox.Name = "UserDetailsListBox";
            this.UserDetailsListBox.Size = new System.Drawing.Size(432, 251);
            this.UserDetailsListBox.TabIndex = 5;
            // 
            // LoadUsers
            // 
            this.LoadUsers.Location = new System.Drawing.Point(75, 239);
            this.LoadUsers.Name = "LoadUsers";
            this.LoadUsers.Size = new System.Drawing.Size(151, 23);
            this.LoadUsers.TabIndex = 6;
            this.LoadUsers.Text = "Load users to List";
            this.LoadUsers.UseVisualStyleBackColor = true;
            this.LoadUsers.Click += new System.EventHandler(this.LoadUsers_Click);
            // 
            // LoadUserstoText
            // 
            this.LoadUserstoText.Location = new System.Drawing.Point(75, 284);
            this.LoadUserstoText.Name = "LoadUserstoText";
            this.LoadUserstoText.Size = new System.Drawing.Size(151, 23);
            this.LoadUserstoText.TabIndex = 7;
            this.LoadUserstoText.Text = "Load Users to Text";
            this.LoadUserstoText.UseVisualStyleBackColor = true;
            this.LoadUserstoText.Click += new System.EventHandler(this.LoadUserstoText_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(75, 334);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(151, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoadUserstoText);
            this.Controls.Add(this.LoadUsers);
            this.Controls.Add(this.UserDetailsListBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Namelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.ListBox UserDetailsListBox;
        private System.Windows.Forms.Button LoadUsers;
        private System.Windows.Forms.Button LoadUserstoText;
        private System.Windows.Forms.Button ClearButton;
    }
}

