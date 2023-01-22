namespace Familydetails
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
            this.ChildnameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ChildAgetextBox1 = new System.Windows.Forms.TextBox();
            this.ChildnametextBox2 = new System.Windows.Forms.TextBox();
            this.DetailslistBox1 = new System.Windows.Forms.ListBox();
            this.UserclickButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChildnameLabel
            // 
            this.ChildnameLabel.AutoSize = true;
            this.ChildnameLabel.Location = new System.Drawing.Point(43, 31);
            this.ChildnameLabel.Name = "ChildnameLabel";
            this.ChildnameLabel.Size = new System.Drawing.Size(61, 13);
            this.ChildnameLabel.TabIndex = 0;
            this.ChildnameLabel.Text = "Child Name";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(43, 98);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(52, 13);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Child Age";
            // 
            // ChildAgetextBox1
            // 
            this.ChildAgetextBox1.Location = new System.Drawing.Point(110, 95);
            this.ChildAgetextBox1.Name = "ChildAgetextBox1";
            this.ChildAgetextBox1.Size = new System.Drawing.Size(100, 20);
            this.ChildAgetextBox1.TabIndex = 2;
            // 
            // ChildnametextBox2
            // 
            this.ChildnametextBox2.Location = new System.Drawing.Point(110, 28);
            this.ChildnametextBox2.Name = "ChildnametextBox2";
            this.ChildnametextBox2.Size = new System.Drawing.Size(100, 20);
            this.ChildnametextBox2.TabIndex = 3;
            // 
            // DetailslistBox1
            // 
            this.DetailslistBox1.FormattingEnabled = true;
            this.DetailslistBox1.Location = new System.Drawing.Point(330, 28);
            this.DetailslistBox1.Name = "DetailslistBox1";
            this.DetailslistBox1.Size = new System.Drawing.Size(252, 134);
            this.DetailslistBox1.TabIndex = 4;
            // 
            // UserclickButton
            // 
            this.UserclickButton.Location = new System.Drawing.Point(264, 247);
            this.UserclickButton.Name = "UserclickButton";
            this.UserclickButton.Size = new System.Drawing.Size(75, 23);
            this.UserclickButton.TabIndex = 5;
            this.UserclickButton.Text = "Enter Details";
            this.UserclickButton.UseVisualStyleBackColor = true;
            this.UserclickButton.Click += new System.EventHandler(this.UserclickButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserclickButton);
            this.Controls.Add(this.DetailslistBox1);
            this.Controls.Add(this.ChildnametextBox2);
            this.Controls.Add(this.ChildAgetextBox1);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.ChildnameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChildnameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox ChildAgetextBox1;
        private System.Windows.Forms.TextBox ChildnametextBox2;
        private System.Windows.Forms.ListBox DetailslistBox1;
        private System.Windows.Forms.Button UserclickButton;
    }
}

