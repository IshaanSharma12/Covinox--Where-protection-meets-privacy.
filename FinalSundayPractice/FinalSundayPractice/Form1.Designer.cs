namespace FinalSundayPractice
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
            this.components = new System.ComponentModel.Container();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReadContentsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateAgeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewAgeTextBox = new System.Windows.Forms.TextBox();
            this.GetNewAgeButton = new System.Windows.Forms.Button();
            this.UpdateWeightLabel = new System.Windows.Forms.Label();
            this.NewWeightTextBox = new System.Windows.Forms.TextBox();
            this.GetNewWeightButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SearchNames = new System.Windows.Forms.Label();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchNameButton = new System.Windows.Forms.Button();
            this.GetNameLabel = new System.Windows.Forms.Label();
            this.CopyNameTextBox = new System.Windows.Forms.TextBox();
            this.CopyNameButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(465, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(76, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "BMI Calculator";
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(13, 36);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1056, 160);
            this.OutputListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReadContentsButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Contents";
            // 
            // ReadContentsButton
            // 
            this.ReadContentsButton.Location = new System.Drawing.Point(32, 79);
            this.ReadContentsButton.Name = "ReadContentsButton";
            this.ReadContentsButton.Size = new System.Drawing.Size(138, 23);
            this.ReadContentsButton.TabIndex = 3;
            this.ReadContentsButton.Text = "Load Contents";
            this.ReadContentsButton.UseVisualStyleBackColor = true;
            this.ReadContentsButton.Click += new System.EventHandler(this.ReadContentsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetNewWeightButton);
            this.groupBox2.Controls.Add(this.NewWeightTextBox);
            this.groupBox2.Controls.Add(this.UpdateWeightLabel);
            this.groupBox2.Controls.Add(this.GetNewAgeButton);
            this.groupBox2.Controls.Add(this.NewAgeTextBox);
            this.groupBox2.Controls.Add(this.UpdateAgeLabel);
            this.groupBox2.Location = new System.Drawing.Point(273, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 218);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Contents";
            // 
            // UpdateAgeLabel
            // 
            this.UpdateAgeLabel.AutoSize = true;
            this.UpdateAgeLabel.Location = new System.Drawing.Point(7, 37);
            this.UpdateAgeLabel.Name = "UpdateAgeLabel";
            this.UpdateAgeLabel.Size = new System.Drawing.Size(79, 13);
            this.UpdateAgeLabel.TabIndex = 0;
            this.UpdateAgeLabel.Text = "Enter New Age";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NewAgeTextBox
            // 
            this.NewAgeTextBox.Location = new System.Drawing.Point(123, 37);
            this.NewAgeTextBox.Name = "NewAgeTextBox";
            this.NewAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewAgeTextBox.TabIndex = 1;
            // 
            // GetNewAgeButton
            // 
            this.GetNewAgeButton.Location = new System.Drawing.Point(79, 83);
            this.GetNewAgeButton.Name = "GetNewAgeButton";
            this.GetNewAgeButton.Size = new System.Drawing.Size(119, 23);
            this.GetNewAgeButton.TabIndex = 2;
            this.GetNewAgeButton.Text = "Get New Age";
            this.GetNewAgeButton.UseVisualStyleBackColor = true;
            this.GetNewAgeButton.Click += new System.EventHandler(this.GetNewAgeButton_Click);
            // 
            // UpdateWeightLabel
            // 
            this.UpdateWeightLabel.AutoSize = true;
            this.UpdateWeightLabel.Location = new System.Drawing.Point(7, 148);
            this.UpdateWeightLabel.Name = "UpdateWeightLabel";
            this.UpdateWeightLabel.Size = new System.Drawing.Size(94, 13);
            this.UpdateWeightLabel.TabIndex = 3;
            this.UpdateWeightLabel.Text = "Enter New Weight";
            // 
            // NewWeightTextBox
            // 
            this.NewWeightTextBox.Location = new System.Drawing.Point(123, 140);
            this.NewWeightTextBox.Name = "NewWeightTextBox";
            this.NewWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewWeightTextBox.TabIndex = 4;
            // 
            // GetNewWeightButton
            // 
            this.GetNewWeightButton.Location = new System.Drawing.Point(76, 189);
            this.GetNewWeightButton.Name = "GetNewWeightButton";
            this.GetNewWeightButton.Size = new System.Drawing.Size(122, 23);
            this.GetNewWeightButton.TabIndex = 5;
            this.GetNewWeightButton.Text = "Get New Weight";
            this.GetNewWeightButton.UseVisualStyleBackColor = true;
            this.GetNewWeightButton.Click += new System.EventHandler(this.GetNewWeightButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SortButton);
            this.groupBox3.Controls.Add(this.DeleteButton);
            this.groupBox3.Location = new System.Drawing.Point(621, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 218);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort And Delete";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(26, 32);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete Chosen Button";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(26, 124);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(131, 23);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Sort Button";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CopyNameButton);
            this.groupBox4.Controls.Add(this.CopyNameTextBox);
            this.groupBox4.Controls.Add(this.GetNameLabel);
            this.groupBox4.Controls.Add(this.SearchNameButton);
            this.groupBox4.Controls.Add(this.SearchNameTextBox);
            this.groupBox4.Controls.Add(this.SearchNames);
            this.groupBox4.Location = new System.Drawing.Point(859, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 218);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search And Get";
            // 
            // SearchNames
            // 
            this.SearchNames.AutoSize = true;
            this.SearchNames.Location = new System.Drawing.Point(0, 43);
            this.SearchNames.Name = "SearchNames";
            this.SearchNames.Size = new System.Drawing.Size(72, 13);
            this.SearchNames.TabIndex = 0;
            this.SearchNames.Text = "Search Name";
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Location = new System.Drawing.Point(89, 43);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchNameTextBox.TabIndex = 1;
            // 
            // SearchNameButton
            // 
            this.SearchNameButton.Location = new System.Drawing.Point(39, 96);
            this.SearchNameButton.Name = "SearchNameButton";
            this.SearchNameButton.Size = new System.Drawing.Size(129, 23);
            this.SearchNameButton.TabIndex = 2;
            this.SearchNameButton.Text = "Search Name";
            this.SearchNameButton.UseVisualStyleBackColor = true;
            this.SearchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
            // 
            // GetNameLabel
            // 
            this.GetNameLabel.AutoSize = true;
            this.GetNameLabel.Location = new System.Drawing.Point(0, 148);
            this.GetNameLabel.Name = "GetNameLabel";
            this.GetNameLabel.Size = new System.Drawing.Size(84, 13);
            this.GetNameLabel.TabIndex = 3;
            this.GetNameLabel.Text = "Get Name Label";
            // 
            // CopyNameTextBox
            // 
            this.CopyNameTextBox.Location = new System.Drawing.Point(91, 139);
            this.CopyNameTextBox.Name = "CopyNameTextBox";
            this.CopyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CopyNameTextBox.TabIndex = 4;
            // 
            // CopyNameButton
            // 
            this.CopyNameButton.Location = new System.Drawing.Point(39, 177);
            this.CopyNameButton.Name = "CopyNameButton";
            this.CopyNameButton.Size = new System.Drawing.Size(75, 23);
            this.CopyNameButton.TabIndex = 5;
            this.CopyNameButton.Text = "Copy Name";
            this.CopyNameButton.UseVisualStyleBackColor = true;
            this.CopyNameButton.Click += new System.EventHandler(this.CopyNameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReadContentsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetNewWeightButton;
        private System.Windows.Forms.TextBox NewWeightTextBox;
        private System.Windows.Forms.Label UpdateWeightLabel;
        private System.Windows.Forms.Button GetNewAgeButton;
        private System.Windows.Forms.TextBox NewAgeTextBox;
        private System.Windows.Forms.Label UpdateAgeLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CopyNameButton;
        private System.Windows.Forms.TextBox CopyNameTextBox;
        private System.Windows.Forms.Label GetNameLabel;
        private System.Windows.Forms.Button SearchNameButton;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.Label SearchNames;
    }
}

