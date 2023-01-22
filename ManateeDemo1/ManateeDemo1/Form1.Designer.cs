namespace ManateeDemo1
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
            this.ReadFromFileButton = new System.Windows.Forms.Button();
            this.UpdateSC1Button = new System.Windows.Forms.Button();
            this.WriteDataButton = new System.Windows.Forms.Button();
            this.Sc1Label = new System.Windows.Forms.Label();
            this.SC1TextBox = new System.Windows.Forms.TextBox();
            this.Sc2Label = new System.Windows.Forms.Label();
            this.SC2TextBox = new System.Windows.Forms.TextBox();
            this.SC3Label = new System.Windows.Forms.Label();
            this.SC3TextBox = new System.Windows.Forms.TextBox();
            this.SC4Label = new System.Windows.Forms.Label();
            this.SC4TextBox = new System.Windows.Forms.TextBox();
            this.GetAvgButton = new System.Windows.Forms.Button();
            this.StatusLabelTextBox = new System.Windows.Forms.TextBox();
            this.UpdateSC2Button = new System.Windows.Forms.Button();
            this.UpdateSC3Button = new System.Windows.Forms.Button();
            this.UpdateSC4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(12, 12);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1150, 173);
            this.OutputListBox.TabIndex = 0;
            // 
            // ReadFromFileButton
            // 
            this.ReadFromFileButton.Location = new System.Drawing.Point(12, 263);
            this.ReadFromFileButton.Name = "ReadFromFileButton";
            this.ReadFromFileButton.Size = new System.Drawing.Size(123, 23);
            this.ReadFromFileButton.TabIndex = 1;
            this.ReadFromFileButton.Text = "Read From File";
            this.ReadFromFileButton.UseVisualStyleBackColor = true;
            this.ReadFromFileButton.Click += new System.EventHandler(this.ReadFromFileButton_Click);
            // 
            // UpdateSC1Button
            // 
            this.UpdateSC1Button.Location = new System.Drawing.Point(12, 415);
            this.UpdateSC1Button.Name = "UpdateSC1Button";
            this.UpdateSC1Button.Size = new System.Drawing.Size(145, 23);
            this.UpdateSC1Button.TabIndex = 2;
            this.UpdateSC1Button.Text = "Update SC1";
            this.UpdateSC1Button.UseVisualStyleBackColor = true;
            this.UpdateSC1Button.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // WriteDataButton
            // 
            this.WriteDataButton.Location = new System.Drawing.Point(360, 263);
            this.WriteDataButton.Name = "WriteDataButton";
            this.WriteDataButton.Size = new System.Drawing.Size(127, 23);
            this.WriteDataButton.TabIndex = 3;
            this.WriteDataButton.Text = "Write Data";
            this.WriteDataButton.UseVisualStyleBackColor = true;
            this.WriteDataButton.Click += new System.EventHandler(this.WriteDataButton_Click);
            // 
            // Sc1Label
            // 
            this.Sc1Label.AutoSize = true;
            this.Sc1Label.Location = new System.Drawing.Point(40, 337);
            this.Sc1Label.Name = "Sc1Label";
            this.Sc1Label.Size = new System.Drawing.Size(74, 13);
            this.Sc1Label.TabIndex = 4;
            this.Sc1Label.Text = "String Count 1";
            // 
            // SC1TextBox
            // 
            this.SC1TextBox.Location = new System.Drawing.Point(149, 337);
            this.SC1TextBox.Name = "SC1TextBox";
            this.SC1TextBox.Size = new System.Drawing.Size(100, 20);
            this.SC1TextBox.TabIndex = 5;
            // 
            // Sc2Label
            // 
            this.Sc2Label.AutoSize = true;
            this.Sc2Label.Location = new System.Drawing.Point(37, 386);
            this.Sc2Label.Name = "Sc2Label";
            this.Sc2Label.Size = new System.Drawing.Size(77, 13);
            this.Sc2Label.TabIndex = 6;
            this.Sc2Label.Text = "String Count 2 ";
            // 
            // SC2TextBox
            // 
            this.SC2TextBox.Location = new System.Drawing.Point(149, 386);
            this.SC2TextBox.Name = "SC2TextBox";
            this.SC2TextBox.Size = new System.Drawing.Size(100, 20);
            this.SC2TextBox.TabIndex = 7;
            // 
            // SC3Label
            // 
            this.SC3Label.AutoSize = true;
            this.SC3Label.Location = new System.Drawing.Point(317, 343);
            this.SC3Label.Name = "SC3Label";
            this.SC3Label.Size = new System.Drawing.Size(77, 13);
            this.SC3Label.TabIndex = 8;
            this.SC3Label.Text = "String Count 3 ";
            // 
            // SC3TextBox
            // 
            this.SC3TextBox.Location = new System.Drawing.Point(422, 335);
            this.SC3TextBox.Name = "SC3TextBox";
            this.SC3TextBox.Size = new System.Drawing.Size(100, 20);
            this.SC3TextBox.TabIndex = 9;
            // 
            // SC4Label
            // 
            this.SC4Label.AutoSize = true;
            this.SC4Label.Location = new System.Drawing.Point(320, 386);
            this.SC4Label.Name = "SC4Label";
            this.SC4Label.Size = new System.Drawing.Size(77, 13);
            this.SC4Label.TabIndex = 10;
            this.SC4Label.Text = "String Count  4";
            // 
            // SC4TextBox
            // 
            this.SC4TextBox.Location = new System.Drawing.Point(422, 386);
            this.SC4TextBox.Name = "SC4TextBox";
            this.SC4TextBox.Size = new System.Drawing.Size(100, 20);
            this.SC4TextBox.TabIndex = 11;
            // 
            // GetAvgButton
            // 
            this.GetAvgButton.Location = new System.Drawing.Point(609, 262);
            this.GetAvgButton.Name = "GetAvgButton";
            this.GetAvgButton.Size = new System.Drawing.Size(112, 23);
            this.GetAvgButton.TabIndex = 12;
            this.GetAvgButton.Text = "Get Average";
            this.GetAvgButton.UseVisualStyleBackColor = true;
            this.GetAvgButton.Click += new System.EventHandler(this.GetAvgButton_Click);
            // 
            // StatusLabelTextBox
            // 
            this.StatusLabelTextBox.Location = new System.Drawing.Point(544, 343);
            this.StatusLabelTextBox.Name = "StatusLabelTextBox";
            this.StatusLabelTextBox.Size = new System.Drawing.Size(205, 20);
            this.StatusLabelTextBox.TabIndex = 13;
            // 
            // UpdateSC2Button
            // 
            this.UpdateSC2Button.Location = new System.Drawing.Point(191, 415);
            this.UpdateSC2Button.Name = "UpdateSC2Button";
            this.UpdateSC2Button.Size = new System.Drawing.Size(75, 23);
            this.UpdateSC2Button.TabIndex = 14;
            this.UpdateSC2Button.Text = "Update SC2";
            this.UpdateSC2Button.UseVisualStyleBackColor = true;
            this.UpdateSC2Button.Click += new System.EventHandler(this.UpdateSC2Button_Click);
            // 
            // UpdateSC3Button
            // 
            this.UpdateSC3Button.Location = new System.Drawing.Point(321, 415);
            this.UpdateSC3Button.Name = "UpdateSC3Button";
            this.UpdateSC3Button.Size = new System.Drawing.Size(75, 23);
            this.UpdateSC3Button.TabIndex = 15;
            this.UpdateSC3Button.Text = "Update SC3";
            this.UpdateSC3Button.UseVisualStyleBackColor = true;
            this.UpdateSC3Button.Click += new System.EventHandler(this.UpdateSC3Button_Click);
            // 
            // UpdateSC4
            // 
            this.UpdateSC4.Location = new System.Drawing.Point(460, 415);
            this.UpdateSC4.Name = "UpdateSC4";
            this.UpdateSC4.Size = new System.Drawing.Size(75, 23);
            this.UpdateSC4.TabIndex = 16;
            this.UpdateSC4.Text = "Update SC4";
            this.UpdateSC4.UseVisualStyleBackColor = true;
            this.UpdateSC4.Click += new System.EventHandler(this.UpdateSC3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.UpdateSC4);
            this.Controls.Add(this.UpdateSC3Button);
            this.Controls.Add(this.UpdateSC2Button);
            this.Controls.Add(this.StatusLabelTextBox);
            this.Controls.Add(this.GetAvgButton);
            this.Controls.Add(this.SC4TextBox);
            this.Controls.Add(this.SC4Label);
            this.Controls.Add(this.SC3TextBox);
            this.Controls.Add(this.SC3Label);
            this.Controls.Add(this.SC2TextBox);
            this.Controls.Add(this.Sc2Label);
            this.Controls.Add(this.SC1TextBox);
            this.Controls.Add(this.Sc1Label);
            this.Controls.Add(this.WriteDataButton);
            this.Controls.Add(this.UpdateSC1Button);
            this.Controls.Add(this.ReadFromFileButton);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Button ReadFromFileButton;
        private System.Windows.Forms.Button UpdateSC1Button;
        private System.Windows.Forms.Button WriteDataButton;
        private System.Windows.Forms.Label Sc1Label;
        private System.Windows.Forms.TextBox SC1TextBox;
        private System.Windows.Forms.Label Sc2Label;
        private System.Windows.Forms.TextBox SC2TextBox;
        private System.Windows.Forms.Label SC3Label;
        private System.Windows.Forms.TextBox SC3TextBox;
        private System.Windows.Forms.Label SC4Label;
        private System.Windows.Forms.TextBox SC4TextBox;
        private System.Windows.Forms.Button GetAvgButton;
        private System.Windows.Forms.TextBox StatusLabelTextBox;
        private System.Windows.Forms.Button UpdateSC2Button;
        private System.Windows.Forms.Button UpdateSC3Button;
        private System.Windows.Forms.Button UpdateSC4;
    }
}

