namespace Final1_1175
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.ComputationGroupBox = new System.Windows.Forms.GroupBox();
            this.ComputeAvgButton = new System.Windows.Forms.Button();
            this.ComputeMaxButton = new System.Windows.Forms.Button();
            this.ComputeMinButton = new System.Windows.Forms.Button();
            this.GetAverageTextBox = new System.Windows.Forms.TextBox();
            this.GetAvgLabel = new System.Windows.Forms.Label();
            this.GetMaximumTextBox = new System.Windows.Forms.TextBox();
            this.GetMaxLabel = new System.Windows.Forms.Label();
            this.GetMinTextBox = new System.Windows.Forms.TextBox();
            this.GetMinLabel = new System.Windows.Forms.Label();
            this.LoadDetailsButton = new System.Windows.Forms.Button();
            this.ComputationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Location = new System.Drawing.Point(263, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(277, 23);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Computing Avg,Max,Min,Sum etc";
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(13, 45);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1043, 238);
            this.OutputListBox.TabIndex = 1;
            // 
            // ComputationGroupBox
            // 
            this.ComputationGroupBox.Controls.Add(this.ComputeAvgButton);
            this.ComputationGroupBox.Controls.Add(this.ComputeMaxButton);
            this.ComputationGroupBox.Controls.Add(this.ComputeMinButton);
            this.ComputationGroupBox.Controls.Add(this.GetAverageTextBox);
            this.ComputationGroupBox.Controls.Add(this.GetAvgLabel);
            this.ComputationGroupBox.Controls.Add(this.GetMaximumTextBox);
            this.ComputationGroupBox.Controls.Add(this.GetMaxLabel);
            this.ComputationGroupBox.Controls.Add(this.GetMinTextBox);
            this.ComputationGroupBox.Controls.Add(this.GetMinLabel);
            this.ComputationGroupBox.Location = new System.Drawing.Point(13, 317);
            this.ComputationGroupBox.Name = "ComputationGroupBox";
            this.ComputationGroupBox.Size = new System.Drawing.Size(1016, 185);
            this.ComputationGroupBox.TabIndex = 2;
            this.ComputationGroupBox.TabStop = false;
            this.ComputationGroupBox.Text = "Computation GroupBox";
            // 
            // ComputeAvgButton
            // 
            this.ComputeAvgButton.Location = new System.Drawing.Point(695, 102);
            this.ComputeAvgButton.Name = "ComputeAvgButton";
            this.ComputeAvgButton.Size = new System.Drawing.Size(159, 32);
            this.ComputeAvgButton.TabIndex = 7;
            this.ComputeAvgButton.Text = "Compute Avg";
            this.ComputeAvgButton.UseVisualStyleBackColor = true;
            this.ComputeAvgButton.Click += new System.EventHandler(this.ComputeAvgButton_Click);
            // 
            // ComputeMaxButton
            // 
            this.ComputeMaxButton.Location = new System.Drawing.Point(354, 102);
            this.ComputeMaxButton.Name = "ComputeMaxButton";
            this.ComputeMaxButton.Size = new System.Drawing.Size(124, 32);
            this.ComputeMaxButton.TabIndex = 6;
            this.ComputeMaxButton.Text = "Compute Max";
            this.ComputeMaxButton.UseVisualStyleBackColor = true;
            this.ComputeMaxButton.Click += new System.EventHandler(this.ComputeMaxButton_Click);
            // 
            // ComputeMinButton
            // 
            this.ComputeMinButton.Location = new System.Drawing.Point(19, 102);
            this.ComputeMinButton.Name = "ComputeMinButton";
            this.ComputeMinButton.Size = new System.Drawing.Size(140, 32);
            this.ComputeMinButton.TabIndex = 3;
            this.ComputeMinButton.Text = "Compute Min";
            this.ComputeMinButton.UseVisualStyleBackColor = true;
            this.ComputeMinButton.Click += new System.EventHandler(this.ComputeMinButton_Click);
            // 
            // GetAverageTextBox
            // 
            this.GetAverageTextBox.Location = new System.Drawing.Point(806, 44);
            this.GetAverageTextBox.Name = "GetAverageTextBox";
            this.GetAverageTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetAverageTextBox.TabIndex = 5;
            // 
            // GetAvgLabel
            // 
            this.GetAvgLabel.AutoSize = true;
            this.GetAvgLabel.Location = new System.Drawing.Point(704, 51);
            this.GetAvgLabel.Name = "GetAvgLabel";
            this.GetAvgLabel.Size = new System.Drawing.Size(67, 13);
            this.GetAvgLabel.TabIndex = 4;
            this.GetAvgLabel.Text = "Get Average";
            // 
            // GetMaximumTextBox
            // 
            this.GetMaximumTextBox.Location = new System.Drawing.Point(477, 42);
            this.GetMaximumTextBox.Name = "GetMaximumTextBox";
            this.GetMaximumTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetMaximumTextBox.TabIndex = 3;
            // 
            // GetMaxLabel
            // 
            this.GetMaxLabel.AutoSize = true;
            this.GetMaxLabel.Location = new System.Drawing.Point(351, 45);
            this.GetMaxLabel.Name = "GetMaxLabel";
            this.GetMaxLabel.Size = new System.Drawing.Size(71, 13);
            this.GetMaxLabel.TabIndex = 2;
            this.GetMaxLabel.Text = "Get Maximum";
            // 
            // GetMinTextBox
            // 
            this.GetMinTextBox.Location = new System.Drawing.Point(100, 45);
            this.GetMinTextBox.Name = "GetMinTextBox";
            this.GetMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetMinTextBox.TabIndex = 1;
            // 
            // GetMinLabel
            // 
            this.GetMinLabel.AutoSize = true;
            this.GetMinLabel.Location = new System.Drawing.Point(16, 45);
            this.GetMinLabel.Name = "GetMinLabel";
            this.GetMinLabel.Size = new System.Drawing.Size(58, 13);
            this.GetMinLabel.TabIndex = 0;
            this.GetMinLabel.Text = "Minimum is";
            // 
            // LoadDetailsButton
            // 
            this.LoadDetailsButton.Location = new System.Drawing.Point(464, 288);
            this.LoadDetailsButton.Name = "LoadDetailsButton";
            this.LoadDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDetailsButton.TabIndex = 3;
            this.LoadDetailsButton.Text = "Load Details";
            this.LoadDetailsButton.UseVisualStyleBackColor = true;
            this.LoadDetailsButton.Click += new System.EventHandler(this.LoadDetailsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 522);
            this.Controls.Add(this.LoadDetailsButton);
            this.Controls.Add(this.ComputationGroupBox);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ComputationGroupBox.ResumeLayout(false);
            this.ComputationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.GroupBox ComputationGroupBox;
        private System.Windows.Forms.Button ComputeMinButton;
        private System.Windows.Forms.TextBox GetAverageTextBox;
        private System.Windows.Forms.Label GetAvgLabel;
        private System.Windows.Forms.TextBox GetMaximumTextBox;
        private System.Windows.Forms.Label GetMaxLabel;
        private System.Windows.Forms.TextBox GetMinTextBox;
        private System.Windows.Forms.Label GetMinLabel;
        private System.Windows.Forms.Button ComputeAvgButton;
        private System.Windows.Forms.Button ComputeMaxButton;
        private System.Windows.Forms.Button LoadDetailsButton;
    }
}

