namespace firstformsapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UserAgelabel = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserAgeTextBox = new System.Windows.Forms.TextBox();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(23, 40);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(65, 15);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name";
            // 
            // AddUserButton
            // 
            this.AddUserButton.AutoSize = true;
            this.AddUserButton.Location = new System.Drawing.Point(120, 220);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(137, 30);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Add User To List";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(120, 32);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(149, 23);
            this.UserNameTextBox.TabIndex = 2;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(23, 81);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(46, 15);
            this.UserIdLabel.TabIndex = 3;
            this.UserIdLabel.Text = "User Id:";
            // 
            // UserAgelabel
            // 
            this.UserAgelabel.AutoSize = true;
            this.UserAgelabel.Location = new System.Drawing.Point(23, 125);
            this.UserAgelabel.Name = "UserAgelabel";
            this.UserAgelabel.Size = new System.Drawing.Size(57, 15);
            this.UserAgelabel.TabIndex = 4;
            this.UserAgelabel.Text = "User Age:";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(120, 78);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(149, 23);
            this.UserIdTextBox.TabIndex = 5;
            // 
            // UserAgeTextBox
            // 
            this.UserAgeTextBox.Location = new System.Drawing.Point(120, 122);
            this.UserAgeTextBox.Name = "UserAgeTextBox";
            this.UserAgeTextBox.Size = new System.Drawing.Size(149, 23);
            this.UserAgeTextBox.TabIndex = 6;
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 15;
            this.OutputListBox.Items.AddRange(new object[] {
            "Line 1",
            "Line 2 ",
            "Line 3 "});
            this.OutputListBox.Location = new System.Drawing.Point(296, 32);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(284, 124);
            this.OutputListBox.TabIndex = 7;
            this.OutputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // Statuslabel
            // 
            this.Statuslabel.BackColor = System.Drawing.Color.PeachPuff;
            this.Statuslabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Statuslabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Statuslabel.Location = new System.Drawing.Point(12, 307);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(356, 27);
            this.Statuslabel.TabIndex = 8;
            this.Statuslabel.Text = "Status Will Be Displayed Here";
            this.Statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.UserAgeTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.UserAgelabel);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.UserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UserName;
        private Button AddUserButton;
        private TextBox UserNameTextBox;
        private Label UserIdLabel;
        private Label UserAgelabel;
        private TextBox UserIdTextBox;
        private TextBox UserAgeTextBox;
        private ListBox OutputListBox;
        private Label Statuslabel;
    }
}