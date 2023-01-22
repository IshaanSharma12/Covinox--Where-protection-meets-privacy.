namespace IshaanSharmaAssignment2
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadGroceryDataButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortItemsButton = new System.Windows.Forms.Button();
            this.UpdateRestockedQtyButton = new System.Windows.Forms.Button();
            this.QuantityRestockedTextBox = new System.Windows.Forms.TextBox();
            this.QuantityRestockedLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedGroceryItemButton = new System.Windows.Forms.Button();
            this.UpdateSoldQtyButton = new System.Windows.Forms.Button();
            this.QuantitySoldTextBox = new System.Windows.Forms.TextBox();
            this.QuantitySoldLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SavegroceryDataButton = new System.Windows.Forms.Button();
            this.SaveSalesReportbutton = new System.Windows.Forms.Button();
            this.SaveRestockNeedsReport = new System.Windows.Forms.Button();
            this.StatusLabelTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Location = new System.Drawing.Point(385, 9);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(204, 13);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Super Store Grocery Management Project";
            // 
            // outputListBox
            // 
            this.outputListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(1, 25);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(1072, 186);
            this.outputListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadGroceryDataButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load Grocery data";
            // 
            // LoadGroceryDataButton
            // 
            this.LoadGroceryDataButton.Location = new System.Drawing.Point(27, 82);
            this.LoadGroceryDataButton.Name = "LoadGroceryDataButton";
            this.LoadGroceryDataButton.Size = new System.Drawing.Size(149, 23);
            this.LoadGroceryDataButton.TabIndex = 0;
            this.LoadGroceryDataButton.Text = "Load Grocery Data";
            this.LoadGroceryDataButton.UseVisualStyleBackColor = true;
            this.LoadGroceryDataButton.Click += new System.EventHandler(this.LoadGroceryDataButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SortItemsButton);
            this.groupBox2.Controls.Add(this.UpdateRestockedQtyButton);
            this.groupBox2.Controls.Add(this.QuantityRestockedTextBox);
            this.groupBox2.Controls.Add(this.QuantityRestockedLabel);
            this.groupBox2.Controls.Add(this.DeleteSelectedGroceryItemButton);
            this.groupBox2.Controls.Add(this.UpdateSoldQtyButton);
            this.groupBox2.Controls.Add(this.QuantitySoldTextBox);
            this.groupBox2.Controls.Add(this.QuantitySoldLabel);
            this.groupBox2.Location = new System.Drawing.Point(274, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // SortItemsButton
            // 
            this.SortItemsButton.Location = new System.Drawing.Point(314, 129);
            this.SortItemsButton.Name = "SortItemsButton";
            this.SortItemsButton.Size = new System.Drawing.Size(233, 23);
            this.SortItemsButton.TabIndex = 7;
            this.SortItemsButton.Text = "Sort Items Based on Sales";
            this.SortItemsButton.UseVisualStyleBackColor = true;
            this.SortItemsButton.Click += new System.EventHandler(this.SortItemsButton_Click);
            // 
            // UpdateRestockedQtyButton
            // 
            this.UpdateRestockedQtyButton.Location = new System.Drawing.Point(314, 100);
            this.UpdateRestockedQtyButton.Name = "UpdateRestockedQtyButton";
            this.UpdateRestockedQtyButton.Size = new System.Drawing.Size(233, 23);
            this.UpdateRestockedQtyButton.TabIndex = 6;
            this.UpdateRestockedQtyButton.Text = "Update Restocked Quantity For Selected Item";
            this.UpdateRestockedQtyButton.UseVisualStyleBackColor = true;
            this.UpdateRestockedQtyButton.Click += new System.EventHandler(this.UpdateRestockedQtyButton_Click);
            // 
            // QuantityRestockedTextBox
            // 
            this.QuantityRestockedTextBox.Location = new System.Drawing.Point(419, 47);
            this.QuantityRestockedTextBox.Name = "QuantityRestockedTextBox";
            this.QuantityRestockedTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityRestockedTextBox.TabIndex = 5;
            // 
            // QuantityRestockedLabel
            // 
            this.QuantityRestockedLabel.AutoSize = true;
            this.QuantityRestockedLabel.Location = new System.Drawing.Point(311, 47);
            this.QuantityRestockedLabel.Name = "QuantityRestockedLabel";
            this.QuantityRestockedLabel.Size = new System.Drawing.Size(101, 13);
            this.QuantityRestockedLabel.TabIndex = 4;
            this.QuantityRestockedLabel.Text = "Quantity Restocked";
            // 
            // DeleteSelectedGroceryItemButton
            // 
            this.DeleteSelectedGroceryItemButton.Location = new System.Drawing.Point(6, 129);
            this.DeleteSelectedGroceryItemButton.Name = "DeleteSelectedGroceryItemButton";
            this.DeleteSelectedGroceryItemButton.Size = new System.Drawing.Size(226, 23);
            this.DeleteSelectedGroceryItemButton.TabIndex = 3;
            this.DeleteSelectedGroceryItemButton.Text = "Delete Selected Grocery item";
            this.DeleteSelectedGroceryItemButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedGroceryItemButton.Click += new System.EventHandler(this.DeleteSelectedGroceryItemButton_Click);
            // 
            // UpdateSoldQtyButton
            // 
            this.UpdateSoldQtyButton.Location = new System.Drawing.Point(10, 100);
            this.UpdateSoldQtyButton.Name = "UpdateSoldQtyButton";
            this.UpdateSoldQtyButton.Size = new System.Drawing.Size(226, 23);
            this.UpdateSoldQtyButton.TabIndex = 2;
            this.UpdateSoldQtyButton.Text = "Update Sold Quantity For Selected Item";
            this.UpdateSoldQtyButton.UseVisualStyleBackColor = true;
            this.UpdateSoldQtyButton.Click += new System.EventHandler(this.UpdateSoldQtyButton_Click);
            // 
            // QuantitySoldTextBox
            // 
            this.QuantitySoldTextBox.Location = new System.Drawing.Point(102, 41);
            this.QuantitySoldTextBox.Name = "QuantitySoldTextBox";
            this.QuantitySoldTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantitySoldTextBox.TabIndex = 1;
            // 
            // QuantitySoldLabel
            // 
            this.QuantitySoldLabel.AutoSize = true;
            this.QuantitySoldLabel.Location = new System.Drawing.Point(7, 41);
            this.QuantitySoldLabel.Name = "QuantitySoldLabel";
            this.QuantitySoldLabel.Size = new System.Drawing.Size(70, 13);
            this.QuantitySoldLabel.TabIndex = 0;
            this.QuantitySoldLabel.Text = "Quantity Sold";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SavegroceryDataButton);
            this.groupBox3.Controls.Add(this.SaveSalesReportbutton);
            this.groupBox3.Controls.Add(this.SaveRestockNeedsReport);
            this.groupBox3.Location = new System.Drawing.Point(909, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 180);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // SavegroceryDataButton
            // 
            this.SavegroceryDataButton.Location = new System.Drawing.Point(6, 38);
            this.SavegroceryDataButton.Name = "SavegroceryDataButton";
            this.SavegroceryDataButton.Size = new System.Drawing.Size(132, 23);
            this.SavegroceryDataButton.TabIndex = 9;
            this.SavegroceryDataButton.Text = "Save Grocery Data";
            this.SavegroceryDataButton.UseVisualStyleBackColor = true;
            this.SavegroceryDataButton.Click += new System.EventHandler(this.SavegroceryDataButton_Click);
            // 
            // SaveSalesReportbutton
            // 
            this.SaveSalesReportbutton.Location = new System.Drawing.Point(6, 82);
            this.SaveSalesReportbutton.Name = "SaveSalesReportbutton";
            this.SaveSalesReportbutton.Size = new System.Drawing.Size(132, 23);
            this.SaveSalesReportbutton.TabIndex = 8;
            this.SaveSalesReportbutton.Text = "Save Sales Report";
            this.SaveSalesReportbutton.UseVisualStyleBackColor = true;
            this.SaveSalesReportbutton.Click += new System.EventHandler(this.SaveSalesReportbutton_Click);
            // 
            // SaveRestockNeedsReport
            // 
            this.SaveRestockNeedsReport.Location = new System.Drawing.Point(6, 129);
            this.SaveRestockNeedsReport.Name = "SaveRestockNeedsReport";
            this.SaveRestockNeedsReport.Size = new System.Drawing.Size(132, 23);
            this.SaveRestockNeedsReport.TabIndex = 0;
            this.SaveRestockNeedsReport.Text = "Save Restock Needs report";
            this.SaveRestockNeedsReport.UseVisualStyleBackColor = true;
            this.SaveRestockNeedsReport.Click += new System.EventHandler(this.SaveRestockNeedsReport_Click);
            // 
            // StatusLabelTextBox
            // 
            this.StatusLabelTextBox.Location = new System.Drawing.Point(12, 418);
            this.StatusLabelTextBox.Name = "StatusLabelTextBox";
            this.StatusLabelTextBox.Size = new System.Drawing.Size(1035, 20);
            this.StatusLabelTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.StatusLabelTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadGroceryDataButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortItemsButton;
        private System.Windows.Forms.Button UpdateRestockedQtyButton;
        private System.Windows.Forms.TextBox QuantityRestockedTextBox;
        private System.Windows.Forms.Label QuantityRestockedLabel;
        private System.Windows.Forms.Button DeleteSelectedGroceryItemButton;
        private System.Windows.Forms.Button UpdateSoldQtyButton;
        private System.Windows.Forms.TextBox QuantitySoldTextBox;
        private System.Windows.Forms.Label QuantitySoldLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SavegroceryDataButton;
        private System.Windows.Forms.Button SaveSalesReportbutton;
        private System.Windows.Forms.Button SaveRestockNeedsReport;
        private System.Windows.Forms.TextBox StatusLabelTextBox;
    }
}

