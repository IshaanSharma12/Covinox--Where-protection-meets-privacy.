namespace HackEDIshaanSharma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.OutputListBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateTreeTextBox = new System.Windows.Forms.TextBox();
            this.UpdateLocalityButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteLocalityButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WriteButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GetGirthTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GetGirthButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edmonton Area Tree Entry Database- A Boon for Nature Lovers!!!";
            // 
            // OutputListBox1
            // 
            this.OutputListBox1.FormattingEnabled = true;
            this.OutputListBox1.Location = new System.Drawing.Point(12, 81);
            this.OutputListBox1.Name = "OutputListBox1";
            this.OutputListBox1.Size = new System.Drawing.Size(776, 173);
            this.OutputListBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update Tree";
            // 
            // UpdateTreeTextBox
            // 
            this.UpdateTreeTextBox.Location = new System.Drawing.Point(115, 23);
            this.UpdateTreeTextBox.Name = "UpdateTreeTextBox";
            this.UpdateTreeTextBox.Size = new System.Drawing.Size(100, 20);
            this.UpdateTreeTextBox.TabIndex = 3;
            // 
            // UpdateLocalityButton
            // 
            this.UpdateLocalityButton.Location = new System.Drawing.Point(57, 58);
            this.UpdateLocalityButton.Name = "UpdateLocalityButton";
            this.UpdateLocalityButton.Size = new System.Drawing.Size(120, 23);
            this.UpdateLocalityButton.TabIndex = 4;
            this.UpdateLocalityButton.Text = "Update The Tree";
            this.UpdateLocalityButton.UseVisualStyleBackColor = true;
            this.UpdateLocalityButton.Click += new System.EventHandler(this.UpdateLocalityButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UpdateLocalityButton);
            this.groupBox1.Controls.Add(this.UpdateTreeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update The Tree";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteLocalityButton);
            this.groupBox2.Location = new System.Drawing.Point(367, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete The Tree";
            // 
            // DeleteLocalityButton
            // 
            this.DeleteLocalityButton.Location = new System.Drawing.Point(54, 32);
            this.DeleteLocalityButton.Name = "DeleteLocalityButton";
            this.DeleteLocalityButton.Size = new System.Drawing.Size(155, 23);
            this.DeleteLocalityButton.TabIndex = 0;
            this.DeleteLocalityButton.Text = "Delete The Tree";
            this.DeleteLocalityButton.UseVisualStyleBackColor = true;
            this.DeleteLocalityButton.Click += new System.EventHandler(this.DeleteLocalityButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MADE WITH LOVE IN VANCOUVER BC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReadButton);
            this.groupBox3.Controls.Add(this.WriteButton);
            this.groupBox3.Location = new System.Drawing.Point(21, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 132);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write and Read To File";
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(93, 32);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(113, 23);
            this.WriteButton.TabIndex = 0;
            this.WriteButton.Text = "Write to File ";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GetGirthButton);
            this.groupBox4.Controls.Add(this.GetGirthTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(367, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 121);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Get Tree Details";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(93, 86);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(113, 23);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Read To File";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Girth is";
            // 
            // GetGirthTextBox
            // 
            this.GetGirthTextBox.Location = new System.Drawing.Point(76, 30);
            this.GetGirthTextBox.Name = "GetGirthTextBox";
            this.GetGirthTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetGirthTextBox.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(649, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 257);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sort Items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sort Elements";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetGirthButton
            // 
            this.GetGirthButton.Location = new System.Drawing.Point(76, 75);
            this.GetGirthButton.Name = "GetGirthButton";
            this.GetGirthButton.Size = new System.Drawing.Size(75, 23);
            this.GetGirthButton.TabIndex = 2;
            this.GetGirthButton.Text = "Get Girth";
            this.GetGirthButton.UseVisualStyleBackColor = true;
            this.GetGirthButton.Click += new System.EventHandler(this.GetGirthButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(893, 535);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutputListBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "v";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OutputListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpdateTreeTextBox;
        private System.Windows.Forms.Button UpdateLocalityButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteLocalityButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox GetGirthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GetGirthButton;
    }
}

