namespace Demo3Forms
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
            this.Childnamelabel = new System.Windows.Forms.Label();
            this.Childcitylabel = new System.Windows.Forms.Label();
            this.ChildnameTextBox = new System.Windows.Forms.TextBox();
            this.ChildcityTextBox = new System.Windows.Forms.TextBox();
            this.OutputListbox = new System.Windows.Forms.ListBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Addchildbutton = new System.Windows.Forms.Button();
            this.statuslabel = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Childnamelabel
            // 
            this.Childnamelabel.AutoSize = true;
            this.Childnamelabel.Location = new System.Drawing.Point(80, 49);
            this.Childnamelabel.Name = "Childnamelabel";
            this.Childnamelabel.Size = new System.Drawing.Size(59, 13);
            this.Childnamelabel.TabIndex = 0;
            this.Childnamelabel.Text = "Child name";
            // 
            // Childcitylabel
            // 
            this.Childcitylabel.AutoSize = true;
            this.Childcitylabel.Location = new System.Drawing.Point(80, 144);
            this.Childcitylabel.Name = "Childcitylabel";
            this.Childcitylabel.Size = new System.Drawing.Size(80, 13);
            this.Childcitylabel.TabIndex = 1;
            this.Childcitylabel.Text = "Child city Name";
            // 
            // ChildnameTextBox
            // 
            this.ChildnameTextBox.Location = new System.Drawing.Point(199, 49);
            this.ChildnameTextBox.Name = "ChildnameTextBox";
            this.ChildnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChildnameTextBox.TabIndex = 2;
            // 
            // ChildcityTextBox
            // 
            this.ChildcityTextBox.Location = new System.Drawing.Point(199, 141);
            this.ChildcityTextBox.Name = "ChildcityTextBox";
            this.ChildcityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChildcityTextBox.TabIndex = 3;
            // 
            // OutputListbox
            // 
            this.OutputListbox.FormattingEnabled = true;
            this.OutputListbox.Location = new System.Drawing.Point(460, 49);
            this.OutputListbox.Name = "OutputListbox";
            this.OutputListbox.Size = new System.Drawing.Size(170, 134);
            this.OutputListbox.TabIndex = 4;
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(272, 291);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 5;
            this.Updatebutton.Text = "Update Child";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Addchildbutton
            // 
            this.Addchildbutton.Location = new System.Drawing.Point(84, 291);
            this.Addchildbutton.Name = "Addchildbutton";
            this.Addchildbutton.Size = new System.Drawing.Size(75, 23);
            this.Addchildbutton.TabIndex = 6;
            this.Addchildbutton.Text = "Add child";
            this.Addchildbutton.UseVisualStyleBackColor = true;
            this.Addchildbutton.Click += new System.EventHandler(this.Addchildbutton_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.Location = new System.Drawing.Point(258, 226);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(187, 20);
            this.statuslabel.TabIndex = 7;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(514, 291);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.Addchildbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.OutputListbox);
            this.Controls.Add(this.ChildcityTextBox);
            this.Controls.Add(this.ChildnameTextBox);
            this.Controls.Add(this.Childcitylabel);
            this.Controls.Add(this.Childnamelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Childnamelabel;
        private System.Windows.Forms.Label Childcitylabel;
        private System.Windows.Forms.TextBox ChildnameTextBox;
        private System.Windows.Forms.TextBox ChildcityTextBox;
        private System.Windows.Forms.ListBox OutputListbox;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Addchildbutton;
        private System.Windows.Forms.TextBox statuslabel;
        private System.Windows.Forms.Button DeleteButton;
    }
}

