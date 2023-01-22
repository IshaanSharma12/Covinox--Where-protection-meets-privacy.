namespace Namesandgrades
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
            this.GradesLabel = new System.Windows.Forms.Label();
            this.GradesTextBox = new System.Windows.Forms.TextBox();
            this.FinalListBox = new System.Windows.Forms.ListBox();
            this.StatusLabelTextBox = new System.Windows.Forms.TextBox();
            this.LoadDetailsButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LoadBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(36, 63);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(63, 13);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Enter Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(122, 63);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // GradesLabel
            // 
            this.GradesLabel.AutoSize = true;
            this.GradesLabel.Location = new System.Drawing.Point(36, 113);
            this.GradesLabel.Name = "GradesLabel";
            this.GradesLabel.Size = new System.Drawing.Size(69, 13);
            this.GradesLabel.TabIndex = 2;
            this.GradesLabel.Text = "Enter Grades";
            // 
            // GradesTextBox
            // 
            this.GradesTextBox.Location = new System.Drawing.Point(122, 110);
            this.GradesTextBox.Name = "GradesTextBox";
            this.GradesTextBox.Size = new System.Drawing.Size(100, 20);
            this.GradesTextBox.TabIndex = 3;
            // 
            // FinalListBox
            // 
            this.FinalListBox.FormattingEnabled = true;
            this.FinalListBox.Items.AddRange(new object[] {
            "UserName                                      Grade"});
            this.FinalListBox.Location = new System.Drawing.Point(423, 63);
            this.FinalListBox.Name = "FinalListBox";
            this.FinalListBox.Size = new System.Drawing.Size(314, 290);
            this.FinalListBox.TabIndex = 4;
            // 
            // StatusLabelTextBox
            // 
            this.StatusLabelTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.StatusLabelTextBox.Location = new System.Drawing.Point(3, 332);
            this.StatusLabelTextBox.Name = "StatusLabelTextBox";
            this.StatusLabelTextBox.Size = new System.Drawing.Size(414, 20);
            this.StatusLabelTextBox.TabIndex = 5;
            // 
            // LoadDetailsButton
            // 
            this.LoadDetailsButton.Location = new System.Drawing.Point(39, 227);
            this.LoadDetailsButton.Name = "LoadDetailsButton";
            this.LoadDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDetailsButton.TabIndex = 6;
            this.LoadDetailsButton.Text = "Load Details";
            this.LoadDetailsButton.UseVisualStyleBackColor = true;
            this.LoadDetailsButton.Click += new System.EventHandler(this.LoadDetailsButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(148, 227);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LoadBack
            // 
            this.LoadBack.Location = new System.Drawing.Point(253, 227);
            this.LoadBack.Name = "LoadBack";
            this.LoadBack.Size = new System.Drawing.Size(75, 23);
            this.LoadBack.TabIndex = 8;
            this.LoadBack.Text = "Load Back";
            this.LoadBack.UseVisualStyleBackColor = true;
            this.LoadBack.Click += new System.EventHandler(this.LoadBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadBack);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoadDetailsButton);
            this.Controls.Add(this.StatusLabelTextBox);
            this.Controls.Add(this.FinalListBox);
            this.Controls.Add(this.GradesTextBox);
            this.Controls.Add(this.GradesLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Namelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label GradesLabel;
        private System.Windows.Forms.TextBox GradesTextBox;
        private System.Windows.Forms.ListBox FinalListBox;
        private System.Windows.Forms.TextBox StatusLabelTextBox;
        private System.Windows.Forms.Button LoadDetailsButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button LoadBack;
    }
}

