namespace GradeBasic
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
            this.PassengerNameLabel = new System.Windows.Forms.Label();
            this.PassengerNameTextBox = new System.Windows.Forms.TextBox();
            this.PassengerIDLabel = new System.Windows.Forms.Label();
            this.PassengerIDTextBox = new System.Windows.Forms.TextBox();
            this.PassengerAgeLabel = new System.Windows.Forms.Label();
            this.PassengerAgeTextBox = new System.Windows.Forms.TextBox();
            this.DisplayDetailsListBox = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Stauslabel = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PassengerNameLabel
            // 
            this.PassengerNameLabel.AutoSize = true;
            this.PassengerNameLabel.Location = new System.Drawing.Point(83, 52);
            this.PassengerNameLabel.Name = "PassengerNameLabel";
            this.PassengerNameLabel.Size = new System.Drawing.Size(88, 13);
            this.PassengerNameLabel.TabIndex = 0;
            this.PassengerNameLabel.Text = "Passenger Name";
            // 
            // PassengerNameTextBox
            // 
            this.PassengerNameTextBox.Location = new System.Drawing.Point(194, 49);
            this.PassengerNameTextBox.Name = "PassengerNameTextBox";
            this.PassengerNameTextBox.Size = new System.Drawing.Size(124, 20);
            this.PassengerNameTextBox.TabIndex = 1;
            // 
            // PassengerIDLabel
            // 
            this.PassengerIDLabel.AutoSize = true;
            this.PassengerIDLabel.Location = new System.Drawing.Point(86, 89);
            this.PassengerIDLabel.Name = "PassengerIDLabel";
            this.PassengerIDLabel.Size = new System.Drawing.Size(71, 13);
            this.PassengerIDLabel.TabIndex = 2;
            this.PassengerIDLabel.Text = "Passenger ID";
            // 
            // PassengerIDTextBox
            // 
            this.PassengerIDTextBox.Location = new System.Drawing.Point(194, 81);
            this.PassengerIDTextBox.Name = "PassengerIDTextBox";
            this.PassengerIDTextBox.Size = new System.Drawing.Size(124, 20);
            this.PassengerIDTextBox.TabIndex = 3;
            // 
            // PassengerAgeLabel
            // 
            this.PassengerAgeLabel.AutoSize = true;
            this.PassengerAgeLabel.Location = new System.Drawing.Point(86, 127);
            this.PassengerAgeLabel.Name = "PassengerAgeLabel";
            this.PassengerAgeLabel.Size = new System.Drawing.Size(79, 13);
            this.PassengerAgeLabel.TabIndex = 4;
            this.PassengerAgeLabel.Text = "Passenger Age";
            // 
            // PassengerAgeTextBox
            // 
            this.PassengerAgeTextBox.Location = new System.Drawing.Point(194, 127);
            this.PassengerAgeTextBox.Name = "PassengerAgeTextBox";
            this.PassengerAgeTextBox.Size = new System.Drawing.Size(124, 20);
            this.PassengerAgeTextBox.TabIndex = 5;
            // 
            // DisplayDetailsListBox
            // 
            this.DisplayDetailsListBox.FormattingEnabled = true;
            this.DisplayDetailsListBox.Items.AddRange(new object[] {
            "Passenger Name,    Passenger ID, Passenger Age "});
            this.DisplayDetailsListBox.Location = new System.Drawing.Point(336, 52);
            this.DisplayDetailsListBox.Name = "DisplayDetailsListBox";
            this.DisplayDetailsListBox.Size = new System.Drawing.Size(304, 212);
            this.DisplayDetailsListBox.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(292, 277);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(113, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Stauslabel
            // 
            this.Stauslabel.AutoSize = true;
            this.Stauslabel.Location = new System.Drawing.Point(239, 220);
            this.Stauslabel.Name = "Stauslabel";
            this.Stauslabel.Size = new System.Drawing.Size(67, 13);
            this.Stauslabel.TabIndex = 8;
            this.Stauslabel.Text = "DisplayLabel";
            this.Stauslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Stauslabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(86, 241);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(75, 23);
            this.Details.TabIndex = 9;
            this.Details.Text = "UpdateDetails";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Stauslabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DisplayDetailsListBox);
            this.Controls.Add(this.PassengerAgeTextBox);
            this.Controls.Add(this.PassengerAgeLabel);
            this.Controls.Add(this.PassengerIDTextBox);
            this.Controls.Add(this.PassengerIDLabel);
            this.Controls.Add(this.PassengerNameTextBox);
            this.Controls.Add(this.PassengerNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PassengerNameLabel;
        private System.Windows.Forms.TextBox PassengerNameTextBox;
        private System.Windows.Forms.Label PassengerIDLabel;
        private System.Windows.Forms.TextBox PassengerIDTextBox;
        private System.Windows.Forms.Label PassengerAgeLabel;
        private System.Windows.Forms.TextBox PassengerAgeTextBox;
        private System.Windows.Forms.ListBox DisplayDetailsListBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label Stauslabel;
        private System.Windows.Forms.Button Details;
    }
}

