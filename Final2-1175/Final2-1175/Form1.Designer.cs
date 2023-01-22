namespace Final2_1175
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
            this.GradeCalculatorLabel = new System.Windows.Forms.Label();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.LoadDataGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.UpdateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdatedMidtermGradeLabel = new System.Windows.Forms.Label();
            this.MidTermGradeTextBox = new System.Windows.Forms.TextBox();
            this.UpdatedQuizGradeLabel = new System.Windows.Forms.Label();
            this.QuizGradeTextBox = new System.Windows.Forms.TextBox();
            this.UpdatedFinalGradeLabel = new System.Windows.Forms.Label();
            this.FinalGradeTextBox = new System.Windows.Forms.TextBox();
            this.UpdateMidtermGradeButton = new System.Windows.Forms.Button();
            this.UpdateQuizGradeButton = new System.Windows.Forms.Button();
            this.UpdateFinalGradeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.DeleteSelectedQtyButton = new System.Windows.Forms.Button();
            this.LoadDataGroupBox.SuspendLayout();
            this.UpdateDataGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GradeCalculatorLabel
            // 
            this.GradeCalculatorLabel.AutoSize = true;
            this.GradeCalculatorLabel.Location = new System.Drawing.Point(399, 9);
            this.GradeCalculatorLabel.Name = "GradeCalculatorLabel";
            this.GradeCalculatorLabel.Size = new System.Drawing.Size(86, 13);
            this.GradeCalculatorLabel.TabIndex = 0;
            this.GradeCalculatorLabel.Text = "Grade Calculator";
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(13, 54);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1082, 212);
            this.OutputListBox.TabIndex = 1;
            // 
            // LoadDataGroupBox
            // 
            this.LoadDataGroupBox.Controls.Add(this.LoadDataButton);
            this.LoadDataGroupBox.Location = new System.Drawing.Point(13, 285);
            this.LoadDataGroupBox.Name = "LoadDataGroupBox";
            this.LoadDataGroupBox.Size = new System.Drawing.Size(212, 137);
            this.LoadDataGroupBox.TabIndex = 3;
            this.LoadDataGroupBox.TabStop = false;
            this.LoadDataGroupBox.Text = "Load Data";
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(54, 59);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDataButton.TabIndex = 0;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // UpdateDataGroupBox
            // 
            this.UpdateDataGroupBox.Controls.Add(this.UpdateFinalGradeButton);
            this.UpdateDataGroupBox.Controls.Add(this.UpdateQuizGradeButton);
            this.UpdateDataGroupBox.Controls.Add(this.UpdateMidtermGradeButton);
            this.UpdateDataGroupBox.Controls.Add(this.FinalGradeTextBox);
            this.UpdateDataGroupBox.Controls.Add(this.UpdatedFinalGradeLabel);
            this.UpdateDataGroupBox.Controls.Add(this.QuizGradeTextBox);
            this.UpdateDataGroupBox.Controls.Add(this.UpdatedQuizGradeLabel);
            this.UpdateDataGroupBox.Controls.Add(this.MidTermGradeTextBox);
            this.UpdateDataGroupBox.Controls.Add(this.UpdatedMidtermGradeLabel);
            this.UpdateDataGroupBox.Location = new System.Drawing.Point(255, 285);
            this.UpdateDataGroupBox.Name = "UpdateDataGroupBox";
            this.UpdateDataGroupBox.Size = new System.Drawing.Size(415, 153);
            this.UpdateDataGroupBox.TabIndex = 4;
            this.UpdateDataGroupBox.TabStop = false;
            this.UpdateDataGroupBox.Text = "Update Data";
            // 
            // UpdatedMidtermGradeLabel
            // 
            this.UpdatedMidtermGradeLabel.AutoSize = true;
            this.UpdatedMidtermGradeLabel.Location = new System.Drawing.Point(6, 29);
            this.UpdatedMidtermGradeLabel.Name = "UpdatedMidtermGradeLabel";
            this.UpdatedMidtermGradeLabel.Size = new System.Drawing.Size(101, 13);
            this.UpdatedMidtermGradeLabel.TabIndex = 0;
            this.UpdatedMidtermGradeLabel.Text = "New Midterm Grade";
            // 
            // MidTermGradeTextBox
            // 
            this.MidTermGradeTextBox.Location = new System.Drawing.Point(135, 29);
            this.MidTermGradeTextBox.Name = "MidTermGradeTextBox";
            this.MidTermGradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.MidTermGradeTextBox.TabIndex = 1;
            // 
            // UpdatedQuizGradeLabel
            // 
            this.UpdatedQuizGradeLabel.AutoSize = true;
            this.UpdatedQuizGradeLabel.Location = new System.Drawing.Point(9, 81);
            this.UpdatedQuizGradeLabel.Name = "UpdatedQuizGradeLabel";
            this.UpdatedQuizGradeLabel.Size = new System.Drawing.Size(85, 13);
            this.UpdatedQuizGradeLabel.TabIndex = 2;
            this.UpdatedQuizGradeLabel.Text = "New Quiz Grade";
            // 
            // QuizGradeTextBox
            // 
            this.QuizGradeTextBox.Location = new System.Drawing.Point(135, 78);
            this.QuizGradeTextBox.Name = "QuizGradeTextBox";
            this.QuizGradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuizGradeTextBox.TabIndex = 3;
            // 
            // UpdatedFinalGradeLabel
            // 
            this.UpdatedFinalGradeLabel.AutoSize = true;
            this.UpdatedFinalGradeLabel.Location = new System.Drawing.Point(12, 134);
            this.UpdatedFinalGradeLabel.Name = "UpdatedFinalGradeLabel";
            this.UpdatedFinalGradeLabel.Size = new System.Drawing.Size(86, 13);
            this.UpdatedFinalGradeLabel.TabIndex = 4;
            this.UpdatedFinalGradeLabel.Text = "New Final Grade";
            // 
            // FinalGradeTextBox
            // 
            this.FinalGradeTextBox.Location = new System.Drawing.Point(135, 126);
            this.FinalGradeTextBox.Name = "FinalGradeTextBox";
            this.FinalGradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.FinalGradeTextBox.TabIndex = 5;
            // 
            // UpdateMidtermGradeButton
            // 
            this.UpdateMidtermGradeButton.Location = new System.Drawing.Point(252, 27);
            this.UpdateMidtermGradeButton.Name = "UpdateMidtermGradeButton";
            this.UpdateMidtermGradeButton.Size = new System.Drawing.Size(141, 23);
            this.UpdateMidtermGradeButton.TabIndex = 6;
            this.UpdateMidtermGradeButton.Text = "Update Midterm Grade";
            this.UpdateMidtermGradeButton.UseVisualStyleBackColor = true;
            this.UpdateMidtermGradeButton.Click += new System.EventHandler(this.UpdateMidtermGradeButton_Click);
            // 
            // UpdateQuizGradeButton
            // 
            this.UpdateQuizGradeButton.Location = new System.Drawing.Point(252, 76);
            this.UpdateQuizGradeButton.Name = "UpdateQuizGradeButton";
            this.UpdateQuizGradeButton.Size = new System.Drawing.Size(141, 23);
            this.UpdateQuizGradeButton.TabIndex = 7;
            this.UpdateQuizGradeButton.Text = "Update Quiz Grade";
            this.UpdateQuizGradeButton.UseVisualStyleBackColor = true;
            this.UpdateQuizGradeButton.Click += new System.EventHandler(this.UpdateQuizGradeButton_Click);
            // 
            // UpdateFinalGradeButton
            // 
            this.UpdateFinalGradeButton.Location = new System.Drawing.Point(252, 124);
            this.UpdateFinalGradeButton.Name = "UpdateFinalGradeButton";
            this.UpdateFinalGradeButton.Size = new System.Drawing.Size(141, 23);
            this.UpdateFinalGradeButton.TabIndex = 8;
            this.UpdateFinalGradeButton.Text = "Update Final Grade";
            this.UpdateFinalGradeButton.UseVisualStyleBackColor = true;
            this.UpdateFinalGradeButton.Click += new System.EventHandler(this.UpdateFinalGradeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteSelectedQtyButton);
            this.groupBox1.Controls.Add(this.ClearAllButton);
            this.groupBox1.Location = new System.Drawing.Point(711, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clear & Delete";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(98, 32);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(110, 23);
            this.ClearAllButton.TabIndex = 0;
            this.ClearAllButton.Text = "Delete All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // DeleteSelectedQtyButton
            // 
            this.DeleteSelectedQtyButton.Location = new System.Drawing.Point(98, 95);
            this.DeleteSelectedQtyButton.Name = "DeleteSelectedQtyButton";
            this.DeleteSelectedQtyButton.Size = new System.Drawing.Size(110, 23);
            this.DeleteSelectedQtyButton.TabIndex = 1;
            this.DeleteSelectedQtyButton.Text = "Delete Selected Qty";
            this.DeleteSelectedQtyButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedQtyButton.Click += new System.EventHandler(this.DeleteSelectedQtyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateDataGroupBox);
            this.Controls.Add(this.LoadDataGroupBox);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.GradeCalculatorLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoadDataGroupBox.ResumeLayout(false);
            this.UpdateDataGroupBox.ResumeLayout(false);
            this.UpdateDataGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GradeCalculatorLabel;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.GroupBox LoadDataGroupBox;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.GroupBox UpdateDataGroupBox;
        private System.Windows.Forms.Button UpdateFinalGradeButton;
        private System.Windows.Forms.Button UpdateQuizGradeButton;
        private System.Windows.Forms.Button UpdateMidtermGradeButton;
        private System.Windows.Forms.TextBox FinalGradeTextBox;
        private System.Windows.Forms.Label UpdatedFinalGradeLabel;
        private System.Windows.Forms.TextBox QuizGradeTextBox;
        private System.Windows.Forms.Label UpdatedQuizGradeLabel;
        private System.Windows.Forms.TextBox MidTermGradeTextBox;
        private System.Windows.Forms.Label UpdatedMidtermGradeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteSelectedQtyButton;
        private System.Windows.Forms.Button ClearAllButton;
    }
}

