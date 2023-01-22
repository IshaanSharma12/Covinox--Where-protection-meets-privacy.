namespace WinformAppPractice
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
            this.PassNameLabel = new System.Windows.Forms.Label();
            this.PnameTextBox = new System.Windows.Forms.TextBox();
            this.PassengerIDLabel = new System.Windows.Forms.Label();
            this.PidTextBox = new System.Windows.Forms.TextBox();
            this.DisplayDetailsListBox = new System.Windows.Forms.ListBox();
            this.CalculateDetailsButton = new System.Windows.Forms.Button();
            this.ReverseNamesButton = new System.Windows.Forms.Button();
            this.ClearAlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PassNameLabel
            // 
            this.PassNameLabel.AutoSize = true;
            this.PassNameLabel.Location = new System.Drawing.Point(69, 72);
            this.PassNameLabel.Name = "PassNameLabel";
            this.PassNameLabel.Size = new System.Drawing.Size(88, 13);
            this.PassNameLabel.TabIndex = 0;
            this.PassNameLabel.Text = "Passenger Name";
            // 
            // PnameTextBox
            // 
            this.PnameTextBox.Location = new System.Drawing.Point(229, 72);
            this.PnameTextBox.Name = "PnameTextBox";
            this.PnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PnameTextBox.TabIndex = 1;
            // 
            // PassengerIDLabel
            // 
            this.PassengerIDLabel.AutoSize = true;
            this.PassengerIDLabel.Location = new System.Drawing.Point(69, 135);
            this.PassengerIDLabel.Name = "PassengerIDLabel";
            this.PassengerIDLabel.Size = new System.Drawing.Size(71, 13);
            this.PassengerIDLabel.TabIndex = 2;
            this.PassengerIDLabel.Text = "Passenger ID";
            // 
            // PidTextBox
            // 
            this.PidTextBox.Location = new System.Drawing.Point(229, 135);
            this.PidTextBox.Name = "PidTextBox";
            this.PidTextBox.Size = new System.Drawing.Size(100, 20);
            this.PidTextBox.TabIndex = 3;
            // 
            // DisplayDetailsListBox
            // 
            this.DisplayDetailsListBox.FormattingEnabled = true;
            this.DisplayDetailsListBox.Location = new System.Drawing.Point(509, 53);
            this.DisplayDetailsListBox.Name = "DisplayDetailsListBox";
            this.DisplayDetailsListBox.Size = new System.Drawing.Size(198, 264);
            this.DisplayDetailsListBox.TabIndex = 4;
            // 
            // CalculateDetailsButton
            // 
            this.CalculateDetailsButton.Location = new System.Drawing.Point(136, 278);
            this.CalculateDetailsButton.Name = "CalculateDetailsButton";
            this.CalculateDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateDetailsButton.TabIndex = 5;
            this.CalculateDetailsButton.Text = "Calculate Details";
            this.CalculateDetailsButton.UseVisualStyleBackColor = true;
            this.CalculateDetailsButton.Click += new System.EventHandler(this.CalculateDetailsButton_Click);
            // 
            // ReverseNamesButton
            // 
            this.ReverseNamesButton.Location = new System.Drawing.Point(319, 278);
            this.ReverseNamesButton.Name = "ReverseNamesButton";
            this.ReverseNamesButton.Size = new System.Drawing.Size(137, 23);
            this.ReverseNamesButton.TabIndex = 6;
            this.ReverseNamesButton.Text = "ReverseName";
            this.ReverseNamesButton.UseVisualStyleBackColor = true;
            this.ReverseNamesButton.Click += new System.EventHandler(this.ReverseNamesButton_Click);
            // 
            // ClearAlButton
            // 
            this.ClearAlButton.Location = new System.Drawing.Point(229, 326);
            this.ClearAlButton.Name = "ClearAlButton";
            this.ClearAlButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAlButton.TabIndex = 7;
            this.ClearAlButton.Text = "Clear All";
            this.ClearAlButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(111, 205);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(362, 20);
            this.StatusLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearAlButton);
            this.Controls.Add(this.ReverseNamesButton);
            this.Controls.Add(this.CalculateDetailsButton);
            this.Controls.Add(this.DisplayDetailsListBox);
            this.Controls.Add(this.PidTextBox);
            this.Controls.Add(this.PassengerIDLabel);
            this.Controls.Add(this.PnameTextBox);
            this.Controls.Add(this.PassNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PassNameLabel;
        private System.Windows.Forms.TextBox PnameTextBox;
        private System.Windows.Forms.Label PassengerIDLabel;
        private System.Windows.Forms.TextBox PidTextBox;
        private System.Windows.Forms.ListBox DisplayDetailsListBox;
        private System.Windows.Forms.Button CalculateDetailsButton;
        private System.Windows.Forms.Button ReverseNamesButton;
        private System.Windows.Forms.Button ClearAlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StatusLabel;
    }
}

