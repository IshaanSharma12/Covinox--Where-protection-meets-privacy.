namespace FinalEx3
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
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AvgButton = new System.Windows.Forms.Button();
            this.SC1Label = new System.Windows.Forms.Label();
            this.SC2Label = new System.Windows.Forms.Label();
            this.SC3Label = new System.Windows.Forms.Label();
            this.SC4Label = new System.Windows.Forms.Label();
            this.SC1TextBox = new System.Windows.Forms.TextBox();
            this.SC2TextBox = new System.Windows.Forms.TextBox();
            this.SC3TextBox = new System.Windows.Forms.TextBox();
            this.SC4TextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.WriteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.AutoSize = true;
            this.LoadDataButton.Location = new System.Drawing.Point(52, 286);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(144, 61);
            this.LoadDataButton.TabIndex = 0;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 20;
            this.OutputListBox.Items.AddRange(new object[] {
            "string 1"});
            this.OutputListBox.Location = new System.Drawing.Point(16, 14);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1418, 244);
            this.OutputListBox.TabIndex = 1;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(331, 286);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(157, 60);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update Selected Record";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AvgButton
            // 
            this.AvgButton.Location = new System.Drawing.Point(833, 317);
            this.AvgButton.Name = "AvgButton";
            this.AvgButton.Size = new System.Drawing.Size(155, 52);
            this.AvgButton.TabIndex = 3;
            this.AvgButton.Text = "Avg of Avg:";
            this.AvgButton.UseVisualStyleBackColor = true;
            this.AvgButton.Click += new System.EventHandler(this.AvgButton_Click);
            // 
            // SC1Label
            // 
            this.SC1Label.AutoSize = true;
            this.SC1Label.Location = new System.Drawing.Point(257, 373);
            this.SC1Label.Name = "SC1Label";
            this.SC1Label.Size = new System.Drawing.Size(44, 20);
            this.SC1Label.TabIndex = 4;
            this.SC1Label.Text = "SC1:";
            this.SC1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SC2Label
            // 
            this.SC2Label.AutoSize = true;
            this.SC2Label.Location = new System.Drawing.Point(257, 408);
            this.SC2Label.Name = "SC2Label";
            this.SC2Label.Size = new System.Drawing.Size(44, 20);
            this.SC2Label.TabIndex = 5;
            this.SC2Label.Text = "SC2:";
            this.SC2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SC3Label
            // 
            this.SC3Label.AutoSize = true;
            this.SC3Label.Location = new System.Drawing.Point(409, 373);
            this.SC3Label.Name = "SC3Label";
            this.SC3Label.Size = new System.Drawing.Size(44, 20);
            this.SC3Label.TabIndex = 6;
            this.SC3Label.Text = "SC3:";
            this.SC3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SC4Label
            // 
            this.SC4Label.AutoSize = true;
            this.SC4Label.Location = new System.Drawing.Point(409, 408);
            this.SC4Label.Name = "SC4Label";
            this.SC4Label.Size = new System.Drawing.Size(44, 20);
            this.SC4Label.TabIndex = 7;
            this.SC4Label.Text = "SC4:";
            this.SC4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SC1TextBox
            // 
            this.SC1TextBox.Location = new System.Drawing.Point(307, 373);
            this.SC1TextBox.Name = "SC1TextBox";
            this.SC1TextBox.Size = new System.Drawing.Size(65, 26);
            this.SC1TextBox.TabIndex = 8;
            // 
            // SC2TextBox
            // 
            this.SC2TextBox.Location = new System.Drawing.Point(307, 405);
            this.SC2TextBox.Name = "SC2TextBox";
            this.SC2TextBox.Size = new System.Drawing.Size(65, 26);
            this.SC2TextBox.TabIndex = 9;
            // 
            // SC3TextBox
            // 
            this.SC3TextBox.Location = new System.Drawing.Point(459, 373);
            this.SC3TextBox.Name = "SC3TextBox";
            this.SC3TextBox.Size = new System.Drawing.Size(65, 26);
            this.SC3TextBox.TabIndex = 10;
            // 
            // SC4TextBox
            // 
            this.SC4TextBox.Location = new System.Drawing.Point(459, 405);
            this.SC4TextBox.Name = "SC4TextBox";
            this.SC4TextBox.Size = new System.Drawing.Size(65, 26);
            this.SC4TextBox.TabIndex = 11;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusLabel.Location = new System.Drawing.Point(718, 372);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(390, 69);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Operation Status ";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(547, 290);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(133, 52);
            this.WriteButton.TabIndex = 13;
            this.WriteButton.Text = "Write Date to FIle";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 450);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SC4TextBox);
            this.Controls.Add(this.SC3TextBox);
            this.Controls.Add(this.SC2TextBox);
            this.Controls.Add(this.SC1TextBox);
            this.Controls.Add(this.SC4Label);
            this.Controls.Add(this.SC3Label);
            this.Controls.Add(this.SC2Label);
            this.Controls.Add(this.SC1Label);
            this.Controls.Add(this.AvgButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.LoadDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AvgButton;
        private System.Windows.Forms.Label SC1Label;
        private System.Windows.Forms.Label SC2Label;
        private System.Windows.Forms.Label SC3Label;
        private System.Windows.Forms.Label SC4Label;
        private System.Windows.Forms.TextBox SC1TextBox;
        private System.Windows.Forms.TextBox SC2TextBox;
        private System.Windows.Forms.TextBox SC3TextBox;
        private System.Windows.Forms.TextBox SC4TextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button WriteButton;
    }
}

