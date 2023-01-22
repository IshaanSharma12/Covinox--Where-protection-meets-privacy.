namespace FinalPractice2
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
            this.TitleGrocery = new System.Windows.Forms.Label();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LoadGroupbox = new System.Windows.Forms.GroupBox();
            this.LoadItemsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuantitySoldLabel = new System.Windows.Forms.Label();
            this.QtySoldTextBox = new System.Windows.Forms.TextBox();
            this.UpdateSoldQtyButton = new System.Windows.Forms.Button();
            this.DeleteSelectedQtyButton = new System.Windows.Forms.Button();
            this.QtyRestockedLabel = new System.Windows.Forms.Label();
            this.QtyRestockedTextBox = new System.Windows.Forms.TextBox();
            this.UpdateQtyRestockedButton = new System.Windows.Forms.Button();
            this.SortUsersButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveGroceryData = new System.Windows.Forms.Button();
            this.SaveSalesReport = new System.Windows.Forms.Button();
            this.SaveRestockNeedsButton = new System.Windows.Forms.Button();
            this.StatusLabelTextBox = new System.Windows.Forms.TextBox();
            this.LoadGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleGrocery
            // 
            this.TitleGrocery.AutoSize = true;
            this.TitleGrocery.Location = new System.Drawing.Point(356, 9);
            this.TitleGrocery.Name = "TitleGrocery";
            this.TitleGrocery.Size = new System.Drawing.Size(163, 13);
            this.TitleGrocery.TabIndex = 0;
            this.TitleGrocery.Text = "Superstore Grocery Management";
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(13, 27);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1017, 186);
            this.OutputListBox.TabIndex = 1;
            // 
            // LoadGroupbox
            // 
            this.LoadGroupbox.Controls.Add(this.LoadItemsButton);
            this.LoadGroupbox.Location = new System.Drawing.Point(13, 231);
            this.LoadGroupbox.Name = "LoadGroupbox";
            this.LoadGroupbox.Size = new System.Drawing.Size(200, 135);
            this.LoadGroupbox.TabIndex = 2;
            this.LoadGroupbox.TabStop = false;
            this.LoadGroupbox.Text = "Load Group Box";
            // 
            // LoadItemsButton
            // 
            this.LoadItemsButton.Location = new System.Drawing.Point(54, 52);
            this.LoadItemsButton.Name = "LoadItemsButton";
            this.LoadItemsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadItemsButton.TabIndex = 0;
            this.LoadItemsButton.Text = "Load Items";
            this.LoadItemsButton.UseVisualStyleBackColor = true;
            this.LoadItemsButton.Click += new System.EventHandler(this.LoadItemsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SortUsersButton);
            this.groupBox1.Controls.Add(this.UpdateQtyRestockedButton);
            this.groupBox1.Controls.Add(this.QtyRestockedTextBox);
            this.groupBox1.Controls.Add(this.QtyRestockedLabel);
            this.groupBox1.Controls.Add(this.DeleteSelectedQtyButton);
            this.groupBox1.Controls.Add(this.UpdateSoldQtyButton);
            this.groupBox1.Controls.Add(this.QtySoldTextBox);
            this.groupBox1.Controls.Add(this.QuantitySoldLabel);
            this.groupBox1.Location = new System.Drawing.Point(247, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // QuantitySoldLabel
            // 
            this.QuantitySoldLabel.AutoSize = true;
            this.QuantitySoldLabel.Location = new System.Drawing.Point(7, 29);
            this.QuantitySoldLabel.Name = "QuantitySoldLabel";
            this.QuantitySoldLabel.Size = new System.Drawing.Size(47, 13);
            this.QuantitySoldLabel.TabIndex = 0;
            this.QuantitySoldLabel.Text = "Qty Sold";
            // 
            // QtySoldTextBox
            // 
            this.QtySoldTextBox.Location = new System.Drawing.Point(61, 29);
            this.QtySoldTextBox.Name = "QtySoldTextBox";
            this.QtySoldTextBox.Size = new System.Drawing.Size(100, 20);
            this.QtySoldTextBox.TabIndex = 1;
            // 
            // UpdateSoldQtyButton
            // 
            this.UpdateSoldQtyButton.Location = new System.Drawing.Point(10, 55);
            this.UpdateSoldQtyButton.Name = "UpdateSoldQtyButton";
            this.UpdateSoldQtyButton.Size = new System.Drawing.Size(207, 54);
            this.UpdateSoldQtyButton.TabIndex = 2;
            this.UpdateSoldQtyButton.Text = "Update Sold Qty";
            this.UpdateSoldQtyButton.UseVisualStyleBackColor = true;
            this.UpdateSoldQtyButton.Click += new System.EventHandler(this.UpdateSoldQtyButton_Click);
            // 
            // DeleteSelectedQtyButton
            // 
            this.DeleteSelectedQtyButton.Location = new System.Drawing.Point(10, 124);
            this.DeleteSelectedQtyButton.Name = "DeleteSelectedQtyButton";
            this.DeleteSelectedQtyButton.Size = new System.Drawing.Size(207, 54);
            this.DeleteSelectedQtyButton.TabIndex = 3;
            this.DeleteSelectedQtyButton.Text = "Delete Selected Qty";
            this.DeleteSelectedQtyButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedQtyButton.Click += new System.EventHandler(this.DeleteSelectedQtyButton_Click);
            // 
            // QtyRestockedLabel
            // 
            this.QtyRestockedLabel.AutoSize = true;
            this.QtyRestockedLabel.Location = new System.Drawing.Point(236, 35);
            this.QtyRestockedLabel.Name = "QtyRestockedLabel";
            this.QtyRestockedLabel.Size = new System.Drawing.Size(81, 13);
            this.QtyRestockedLabel.TabIndex = 4;
            this.QtyRestockedLabel.Text = "Qty Restocked ";
            // 
            // QtyRestockedTextBox
            // 
            this.QtyRestockedTextBox.Location = new System.Drawing.Point(369, 32);
            this.QtyRestockedTextBox.Name = "QtyRestockedTextBox";
            this.QtyRestockedTextBox.Size = new System.Drawing.Size(100, 20);
            this.QtyRestockedTextBox.TabIndex = 5;
            // 
            // UpdateQtyRestockedButton
            // 
            this.UpdateQtyRestockedButton.Location = new System.Drawing.Point(305, 55);
            this.UpdateQtyRestockedButton.Name = "UpdateQtyRestockedButton";
            this.UpdateQtyRestockedButton.Size = new System.Drawing.Size(164, 54);
            this.UpdateQtyRestockedButton.TabIndex = 6;
            this.UpdateQtyRestockedButton.Text = "Update Qty Restocked";
            this.UpdateQtyRestockedButton.UseVisualStyleBackColor = true;
            this.UpdateQtyRestockedButton.Click += new System.EventHandler(this.UpdateQtyRestockedButton_Click);
            // 
            // SortUsersButton
            // 
            this.SortUsersButton.Location = new System.Drawing.Point(305, 124);
            this.SortUsersButton.Name = "SortUsersButton";
            this.SortUsersButton.Size = new System.Drawing.Size(164, 54);
            this.SortUsersButton.TabIndex = 7;
            this.SortUsersButton.Text = "Sort All";
            this.SortUsersButton.UseVisualStyleBackColor = true;
            this.SortUsersButton.Click += new System.EventHandler(this.SortUsersButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveRestockNeedsButton);
            this.groupBox2.Controls.Add(this.SaveSalesReport);
            this.groupBox2.Controls.Add(this.SaveGroceryData);
            this.groupBox2.Location = new System.Drawing.Point(828, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // SaveGroceryData
            // 
            this.SaveGroceryData.Location = new System.Drawing.Point(17, 33);
            this.SaveGroceryData.Name = "SaveGroceryData";
            this.SaveGroceryData.Size = new System.Drawing.Size(161, 23);
            this.SaveGroceryData.TabIndex = 0;
            this.SaveGroceryData.Text = "Save Grocery Data";
            this.SaveGroceryData.UseVisualStyleBackColor = true;
            this.SaveGroceryData.Click += new System.EventHandler(this.SaveGroceryData_Click);
            // 
            // SaveSalesReport
            // 
            this.SaveSalesReport.Location = new System.Drawing.Point(17, 93);
            this.SaveSalesReport.Name = "SaveSalesReport";
            this.SaveSalesReport.Size = new System.Drawing.Size(161, 23);
            this.SaveSalesReport.TabIndex = 1;
            this.SaveSalesReport.Text = "Save Sales Report";
            this.SaveSalesReport.UseVisualStyleBackColor = true;
            this.SaveSalesReport.Click += new System.EventHandler(this.SaveSalesReport_Click);
            // 
            // SaveRestockNeedsButton
            // 
            this.SaveRestockNeedsButton.Location = new System.Drawing.Point(17, 146);
            this.SaveRestockNeedsButton.Name = "SaveRestockNeedsButton";
            this.SaveRestockNeedsButton.Size = new System.Drawing.Size(161, 23);
            this.SaveRestockNeedsButton.TabIndex = 2;
            this.SaveRestockNeedsButton.Text = "Save Restock Needs button";
            this.SaveRestockNeedsButton.UseVisualStyleBackColor = true;
            this.SaveRestockNeedsButton.Click += new System.EventHandler(this.SaveRestockNeedsButton_Click);
            // 
            // StatusLabelTextBox
            // 
            this.StatusLabelTextBox.Location = new System.Drawing.Point(193, 460);
            this.StatusLabelTextBox.Name = "StatusLabelTextBox";
            this.StatusLabelTextBox.Size = new System.Drawing.Size(706, 20);
            this.StatusLabelTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1079, 492);
            this.Controls.Add(this.StatusLabelTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoadGroupbox);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.TitleGrocery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoadGroupbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleGrocery;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox LoadGroupbox;
        private System.Windows.Forms.Button LoadItemsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SortUsersButton;
        private System.Windows.Forms.Button UpdateQtyRestockedButton;
        private System.Windows.Forms.TextBox QtyRestockedTextBox;
        private System.Windows.Forms.Label QtyRestockedLabel;
        private System.Windows.Forms.Button DeleteSelectedQtyButton;
        private System.Windows.Forms.Button UpdateSoldQtyButton;
        private System.Windows.Forms.TextBox QtySoldTextBox;
        private System.Windows.Forms.Label QuantitySoldLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveRestockNeedsButton;
        private System.Windows.Forms.Button SaveSalesReport;
        private System.Windows.Forms.Button SaveGroceryData;
        private System.Windows.Forms.TextBox StatusLabelTextBox;
    }
}

