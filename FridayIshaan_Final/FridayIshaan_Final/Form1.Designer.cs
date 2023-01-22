namespace FridayIshaan_Final
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
            this.OutPutListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WritetoFileButton = new System.Windows.Forms.Button();
            this.ReadFromFileButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetItemNameinTextBox = new System.Windows.Forms.Button();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.PasteNameLabel = new System.Windows.Forms.Label();
            this.UpdateNewItemName = new System.Windows.Forms.Button();
            this.NewItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SortElementsBasedonSales = new System.Windows.Forms.Button();
            this.DeleteSelectedElementButton = new System.Windows.Forms.Button();
            this.UpdateRestockedQtyButton = new System.Windows.Forms.Button();
            this.RestockedQtyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateItemNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(402, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(137, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Grocery Store Management";
            // 
            // OutPutListBox
            // 
            this.OutPutListBox.FormattingEnabled = true;
            this.OutPutListBox.Location = new System.Drawing.Point(13, 25);
            this.OutPutListBox.Name = "OutPutListBox";
            this.OutPutListBox.Size = new System.Drawing.Size(1227, 173);
            this.OutPutListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WritetoFileButton);
            this.groupBox1.Controls.Add(this.ReadFromFileButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read and Write";
            // 
            // WritetoFileButton
            // 
            this.WritetoFileButton.Location = new System.Drawing.Point(70, 105);
            this.WritetoFileButton.Name = "WritetoFileButton";
            this.WritetoFileButton.Size = new System.Drawing.Size(144, 23);
            this.WritetoFileButton.TabIndex = 1;
            this.WritetoFileButton.Text = "Write to File ";
            this.WritetoFileButton.UseVisualStyleBackColor = true;
            // 
            // ReadFromFileButton
            // 
            this.ReadFromFileButton.Location = new System.Drawing.Point(70, 51);
            this.ReadFromFileButton.Name = "ReadFromFileButton";
            this.ReadFromFileButton.Size = new System.Drawing.Size(144, 23);
            this.ReadFromFileButton.TabIndex = 0;
            this.ReadFromFileButton.Text = "Read From File";
            this.ReadFromFileButton.UseVisualStyleBackColor = true;
            this.ReadFromFileButton.Click += new System.EventHandler(this.ReadFromFileButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetItemNameinTextBox);
            this.groupBox2.Controls.Add(this.ItemNameTextBox);
            this.groupBox2.Controls.Add(this.PasteNameLabel);
            this.groupBox2.Controls.Add(this.UpdateNewItemName);
            this.groupBox2.Controls.Add(this.NewItemNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(351, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 178);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update And Copy";
            // 
            // GetItemNameinTextBox
            // 
            this.GetItemNameinTextBox.Location = new System.Drawing.Point(90, 149);
            this.GetItemNameinTextBox.Name = "GetItemNameinTextBox";
            this.GetItemNameinTextBox.Size = new System.Drawing.Size(75, 23);
            this.GetItemNameinTextBox.TabIndex = 5;
            this.GetItemNameinTextBox.Text = "Get Name";
            this.GetItemNameinTextBox.UseVisualStyleBackColor = true;
            this.GetItemNameinTextBox.Click += new System.EventHandler(this.GetItemNameinTextBox_Click);
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(140, 122);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemNameTextBox.TabIndex = 4;
            // 
            // PasteNameLabel
            // 
            this.PasteNameLabel.AutoSize = true;
            this.PasteNameLabel.Location = new System.Drawing.Point(19, 122);
            this.PasteNameLabel.Name = "PasteNameLabel";
            this.PasteNameLabel.Size = new System.Drawing.Size(58, 13);
            this.PasteNameLabel.TabIndex = 3;
            this.PasteNameLabel.Text = "Item Name";
            // 
            // UpdateNewItemName
            // 
            this.UpdateNewItemName.Location = new System.Drawing.Point(46, 75);
            this.UpdateNewItemName.Name = "UpdateNewItemName";
            this.UpdateNewItemName.Size = new System.Drawing.Size(194, 23);
            this.UpdateNewItemName.TabIndex = 2;
            this.UpdateNewItemName.Text = "Enter New Sold Qty";
            this.UpdateNewItemName.UseVisualStyleBackColor = true;
            this.UpdateNewItemName.Click += new System.EventHandler(this.UpdateNewItemName_Click);
            // 
            // NewItemNameTextBox
            // 
            this.NewItemNameTextBox.Location = new System.Drawing.Point(140, 35);
            this.NewItemNameTextBox.Name = "NewItemNameTextBox";
            this.NewItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewItemNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Sold Qty";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SortElementsBasedonSales);
            this.groupBox3.Controls.Add(this.DeleteSelectedElementButton);
            this.groupBox3.Location = new System.Drawing.Point(703, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 178);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete And Sort ";
            // 
            // SortElementsBasedonSales
            // 
            this.SortElementsBasedonSales.Location = new System.Drawing.Point(73, 120);
            this.SortElementsBasedonSales.Name = "SortElementsBasedonSales";
            this.SortElementsBasedonSales.Size = new System.Drawing.Size(163, 23);
            this.SortElementsBasedonSales.TabIndex = 1;
            this.SortElementsBasedonSales.Text = "Sort Elements";
            this.SortElementsBasedonSales.UseVisualStyleBackColor = true;
            this.SortElementsBasedonSales.Click += new System.EventHandler(this.SortElementsBasedonSales_Click);
            // 
            // DeleteSelectedElementButton
            // 
            this.DeleteSelectedElementButton.Location = new System.Drawing.Point(63, 51);
            this.DeleteSelectedElementButton.Name = "DeleteSelectedElementButton";
            this.DeleteSelectedElementButton.Size = new System.Drawing.Size(173, 23);
            this.DeleteSelectedElementButton.TabIndex = 0;
            this.DeleteSelectedElementButton.Text = "Delete Selected Element";
            this.DeleteSelectedElementButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedElementButton.Click += new System.EventHandler(this.DeleteSelectedElementButton_Click);
            // 
            // UpdateRestockedQtyButton
            // 
            this.UpdateRestockedQtyButton.Location = new System.Drawing.Point(544, 224);
            this.UpdateRestockedQtyButton.Name = "UpdateRestockedQtyButton";
            this.UpdateRestockedQtyButton.Size = new System.Drawing.Size(189, 23);
            this.UpdateRestockedQtyButton.TabIndex = 4;
            this.UpdateRestockedQtyButton.Text = "Update Rstocked Qty";
            this.UpdateRestockedQtyButton.UseVisualStyleBackColor = true;
            this.UpdateRestockedQtyButton.Click += new System.EventHandler(this.UpdateRestockedQtyButton_Click);
            // 
            // RestockedQtyTextBox
            // 
            this.RestockedQtyTextBox.Location = new System.Drawing.Point(788, 226);
            this.RestockedQtyTextBox.Name = "RestockedQtyTextBox";
            this.RestockedQtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.RestockedQtyTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update Item Name Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateItemNameTextBox
            // 
            this.UpdateItemNameTextBox.Location = new System.Drawing.Point(383, 226);
            this.UpdateItemNameTextBox.Name = "UpdateItemNameTextBox";
            this.UpdateItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UpdateItemNameTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 450);
            this.Controls.Add(this.UpdateItemNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RestockedQtyTextBox);
            this.Controls.Add(this.UpdateRestockedQtyButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutPutListBox);
            this.Controls.Add(this.TitleLabel);
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

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox OutPutListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button WritetoFileButton;
        private System.Windows.Forms.Button ReadFromFileButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetItemNameinTextBox;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label PasteNameLabel;
        private System.Windows.Forms.Button UpdateNewItemName;
        private System.Windows.Forms.TextBox NewItemNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SortElementsBasedonSales;
        private System.Windows.Forms.Button DeleteSelectedElementButton;
        private System.Windows.Forms.Button UpdateRestockedQtyButton;
        private System.Windows.Forms.TextBox RestockedQtyTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UpdateItemNameTextBox;
    }
}

