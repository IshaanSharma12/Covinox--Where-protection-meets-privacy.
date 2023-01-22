namespace IshaanSharmaFinal
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
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.SC1Label = new System.Windows.Forms.Label();
            this.Sc1TextBox = new System.Windows.Forms.TextBox();
            this.sc2Label = new System.Windows.Forms.Label();
            this.Sc2TextBox = new System.Windows.Forms.TextBox();
            this.Sc3Label = new System.Windows.Forms.Label();
            this.Sc3TextBox = new System.Windows.Forms.TextBox();
            this.Sc4Label = new System.Windows.Forms.Label();
            this.Sc4TextBox = new System.Windows.Forms.TextBox();
            this.LoadUsers = new System.Windows.Forms.Button();
            this.UpdateSC1Button = new System.Windows.Forms.Button();
            this.GetAvgButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(28, 65);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(929, 95);
            this.OutputListBox.TabIndex = 0;
            // 
            // SC1Label
            // 
            this.SC1Label.AutoSize = true;
            this.SC1Label.Location = new System.Drawing.Point(49, 239);
            this.SC1Label.Name = "SC1Label";
            this.SC1Label.Size = new System.Drawing.Size(33, 13);
            this.SC1Label.TabIndex = 1;
            this.SC1Label.Text = "SC 1 ";
            // 
            // Sc1TextBox
            // 
            this.Sc1TextBox.Location = new System.Drawing.Point(150, 239);
            this.Sc1TextBox.Name = "Sc1TextBox";
            this.Sc1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Sc1TextBox.TabIndex = 2;
            // 
            // sc2Label
            // 
            this.sc2Label.AutoSize = true;
            this.sc2Label.Location = new System.Drawing.Point(49, 300);
            this.sc2Label.Name = "sc2Label";
            this.sc2Label.Size = new System.Drawing.Size(33, 13);
            this.sc2Label.TabIndex = 3;
            this.sc2Label.Text = "SC 2 ";
            // 
            // Sc2TextBox
            // 
            this.Sc2TextBox.Location = new System.Drawing.Point(150, 293);
            this.Sc2TextBox.Name = "Sc2TextBox";
            this.Sc2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Sc2TextBox.TabIndex = 4;
            // 
            // Sc3Label
            // 
            this.Sc3Label.AutoSize = true;
            this.Sc3Label.Location = new System.Drawing.Point(367, 245);
            this.Sc3Label.Name = "Sc3Label";
            this.Sc3Label.Size = new System.Drawing.Size(33, 13);
            this.Sc3Label.TabIndex = 5;
            this.Sc3Label.Text = "SC 3 ";
            // 
            // Sc3TextBox
            // 
            this.Sc3TextBox.Location = new System.Drawing.Point(434, 245);
            this.Sc3TextBox.Name = "Sc3TextBox";
            this.Sc3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Sc3TextBox.TabIndex = 6;
            // 
            // Sc4Label
            // 
            this.Sc4Label.AutoSize = true;
            this.Sc4Label.Location = new System.Drawing.Point(367, 293);
            this.Sc4Label.Name = "Sc4Label";
            this.Sc4Label.Size = new System.Drawing.Size(30, 13);
            this.Sc4Label.TabIndex = 7;
            this.Sc4Label.Text = "SC 3";
            // 
            // Sc4TextBox
            // 
            this.Sc4TextBox.Location = new System.Drawing.Point(439, 293);
            this.Sc4TextBox.Name = "Sc4TextBox";
            this.Sc4TextBox.Size = new System.Drawing.Size(100, 20);
            this.Sc4TextBox.TabIndex = 8;
            this.Sc4TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadUsers
            // 
            this.LoadUsers.Location = new System.Drawing.Point(6, 375);
            this.LoadUsers.Name = "LoadUsers";
            this.LoadUsers.Size = new System.Drawing.Size(178, 23);
            this.LoadUsers.TabIndex = 9;
            this.LoadUsers.Text = "Load Users Button";
            this.LoadUsers.UseVisualStyleBackColor = true;
            this.LoadUsers.Click += new System.EventHandler(this.LoadUsers_Click);
            // 
            // UpdateSC1Button
            // 
            this.UpdateSC1Button.Location = new System.Drawing.Point(419, 374);
            this.UpdateSC1Button.Name = "UpdateSC1Button";
            this.UpdateSC1Button.Size = new System.Drawing.Size(75, 23);
            this.UpdateSC1Button.TabIndex = 10;
            this.UpdateSC1Button.Text = "Update SC1";
            this.UpdateSC1Button.UseVisualStyleBackColor = true;
            this.UpdateSC1Button.Click += new System.EventHandler(this.UpdateSC1Button_Click);
            // 
            // GetAvgButton
            // 
            this.GetAvgButton.Location = new System.Drawing.Point(751, 354);
            this.GetAvgButton.Name = "GetAvgButton";
            this.GetAvgButton.Size = new System.Drawing.Size(75, 23);
            this.GetAvgButton.TabIndex = 11;
            this.GetAvgButton.Text = "Get Average";
            this.GetAvgButton.UseVisualStyleBackColor = true;
            this.GetAvgButton.Click += new System.EventHandler(this.GetAvgButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.GetAvgButton);
            this.Controls.Add(this.UpdateSC1Button);
            this.Controls.Add(this.LoadUsers);
            this.Controls.Add(this.Sc4TextBox);
            this.Controls.Add(this.Sc4Label);
            this.Controls.Add(this.Sc3TextBox);
            this.Controls.Add(this.Sc3Label);
            this.Controls.Add(this.Sc2TextBox);
            this.Controls.Add(this.sc2Label);
            this.Controls.Add(this.Sc1TextBox);
            this.Controls.Add(this.SC1Label);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Label SC1Label;
        private System.Windows.Forms.TextBox Sc1TextBox;
        private System.Windows.Forms.Label sc2Label;
        private System.Windows.Forms.TextBox Sc2TextBox;
        private System.Windows.Forms.Label Sc3Label;
        private System.Windows.Forms.TextBox Sc3TextBox;
        private System.Windows.Forms.Label Sc4Label;
        private System.Windows.Forms.TextBox Sc4TextBox;
        private System.Windows.Forms.Button LoadUsers;
        private System.Windows.Forms.Button UpdateSC1Button;
        private System.Windows.Forms.Button GetAvgButton;
    }
}

