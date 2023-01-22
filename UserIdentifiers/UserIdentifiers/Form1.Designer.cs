namespace UserIdentifiers
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
            this.ChangeUnameLabel = new System.Windows.Forms.Label();
            this.NewUsernameTextBox = new System.Windows.Forms.TextBox();
            this.NewFnameLabel = new System.Windows.Forms.Label();
            this.NewFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.StatusLabelTextBox = new System.Windows.Forms.TextBox();
            this.OldNameLabel = new System.Windows.Forms.Label();
            this.OldNameDisplayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeUnameLabel
            // 
            this.ChangeUnameLabel.AutoSize = true;
            this.ChangeUnameLabel.Location = new System.Drawing.Point(52, 52);
            this.ChangeUnameLabel.Name = "ChangeUnameLabel";
            this.ChangeUnameLabel.Size = new System.Drawing.Size(113, 13);
            this.ChangeUnameLabel.TabIndex = 0;
            this.ChangeUnameLabel.Text = "Enter New User Name";
            // 
            // NewUsernameTextBox
            // 
            this.NewUsernameTextBox.Location = new System.Drawing.Point(213, 52);
            this.NewUsernameTextBox.Name = "NewUsernameTextBox";
            this.NewUsernameTextBox.Size = new System.Drawing.Size(125, 20);
            this.NewUsernameTextBox.TabIndex = 1;
            // 
            // NewFnameLabel
            // 
            this.NewFnameLabel.AutoSize = true;
            this.NewFnameLabel.Location = new System.Drawing.Point(52, 94);
            this.NewFnameLabel.Name = "NewFnameLabel";
            this.NewFnameLabel.Size = new System.Drawing.Size(110, 13);
            this.NewFnameLabel.TabIndex = 2;
            this.NewFnameLabel.Text = "Enter New First Name";
            // 
            // NewFirstNameTextBox
            // 
            this.NewFirstNameTextBox.Location = new System.Drawing.Point(212, 87);
            this.NewFirstNameTextBox.Name = "NewFirstNameTextBox";
            this.NewFirstNameTextBox.Size = new System.Drawing.Size(125, 20);
            this.NewFirstNameTextBox.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(460, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 355);
            this.listBox1.TabIndex = 4;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(27, 265);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDataButton.TabIndex = 5;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(212, 265);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateDataButton.TabIndex = 6;
            this.UpdateDataButton.Text = "Update Button";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // StatusLabelTextBox
            // 
            this.StatusLabelTextBox.Location = new System.Drawing.Point(27, 338);
            this.StatusLabelTextBox.Name = "StatusLabelTextBox";
            this.StatusLabelTextBox.Size = new System.Drawing.Size(406, 20);
            this.StatusLabelTextBox.TabIndex = 7;
            // 
            // OldNameLabel
            // 
            this.OldNameLabel.AutoSize = true;
            this.OldNameLabel.Location = new System.Drawing.Point(55, 165);
            this.OldNameLabel.Name = "OldNameLabel";
            this.OldNameLabel.Size = new System.Drawing.Size(129, 13);
            this.OldNameLabel.TabIndex = 8;
            this.OldNameLabel.Text = "Old Name Displayed Here";
            // 
            // OldNameDisplayTextBox
            // 
            this.OldNameDisplayTextBox.Location = new System.Drawing.Point(212, 165);
            this.OldNameDisplayTextBox.Name = "OldNameDisplayTextBox";
            this.OldNameDisplayTextBox.Size = new System.Drawing.Size(125, 20);
            this.OldNameDisplayTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OldNameDisplayTextBox);
            this.Controls.Add(this.OldNameLabel);
            this.Controls.Add(this.StatusLabelTextBox);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NewFirstNameTextBox);
            this.Controls.Add(this.NewFnameLabel);
            this.Controls.Add(this.NewUsernameTextBox);
            this.Controls.Add(this.ChangeUnameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChangeUnameLabel;
        private System.Windows.Forms.TextBox NewUsernameTextBox;
        private System.Windows.Forms.Label NewFnameLabel;
        private System.Windows.Forms.TextBox NewFirstNameTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.TextBox StatusLabelTextBox;
        private System.Windows.Forms.Label OldNameLabel;
        private System.Windows.Forms.TextBox OldNameDisplayTextBox;
    }
}

