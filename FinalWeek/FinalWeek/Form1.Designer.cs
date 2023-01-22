namespace FinalWeek
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
            this.LoadItemsButton = new System.Windows.Forms.Button();
            this.ChangeRestockedQtyButton = new System.Windows.Forms.Button();
            this.ChangeSoldQtyButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.UpdateSoldQtyTextBox = new System.Windows.Forms.TextBox();
            this.UpdateRestockedQtyTextBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(12, 53);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1211, 186);
            this.OutputListBox.TabIndex = 0;
            // 
            // LoadItemsButton
            // 
            this.LoadItemsButton.Location = new System.Drawing.Point(33, 300);
            this.LoadItemsButton.Name = "LoadItemsButton";
            this.LoadItemsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadItemsButton.TabIndex = 1;
            this.LoadItemsButton.Text = "Load Items";
            this.LoadItemsButton.UseVisualStyleBackColor = true;
            this.LoadItemsButton.Click += new System.EventHandler(this.LoadItemsButton_Click);
            // 
            // ChangeRestockedQtyButton
            // 
            this.ChangeRestockedQtyButton.Location = new System.Drawing.Point(393, 300);
            this.ChangeRestockedQtyButton.Name = "ChangeRestockedQtyButton";
            this.ChangeRestockedQtyButton.Size = new System.Drawing.Size(159, 23);
            this.ChangeRestockedQtyButton.TabIndex = 2;
            this.ChangeRestockedQtyButton.Text = "ChangeRestockedQty";
            this.ChangeRestockedQtyButton.UseVisualStyleBackColor = true;
            this.ChangeRestockedQtyButton.Click += new System.EventHandler(this.ChangeRestockedQtyButton_Click);
            // 
            // ChangeSoldQtyButton
            // 
            this.ChangeSoldQtyButton.Location = new System.Drawing.Point(193, 300);
            this.ChangeSoldQtyButton.Name = "ChangeSoldQtyButton";
            this.ChangeSoldQtyButton.Size = new System.Drawing.Size(154, 23);
            this.ChangeSoldQtyButton.TabIndex = 3;
            this.ChangeSoldQtyButton.Text = "ChangeSoldQty";
            this.ChangeSoldQtyButton.UseVisualStyleBackColor = true;
            this.ChangeSoldQtyButton.Click += new System.EventHandler(this.ChangeSoldQtyButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(593, 300);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(123, 23);
            this.DeleteItemButton.TabIndex = 4;
            this.DeleteItemButton.Text = "Delete Selected Item";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // UpdateSoldQtyTextBox
            // 
            this.UpdateSoldQtyTextBox.Location = new System.Drawing.Point(193, 373);
            this.UpdateSoldQtyTextBox.Name = "UpdateSoldQtyTextBox";
            this.UpdateSoldQtyTextBox.Size = new System.Drawing.Size(154, 20);
            this.UpdateSoldQtyTextBox.TabIndex = 5;
            // 
            // UpdateRestockedQtyTextBox
            // 
            this.UpdateRestockedQtyTextBox.Location = new System.Drawing.Point(393, 372);
            this.UpdateRestockedQtyTextBox.Name = "UpdateRestockedQtyTextBox";
            this.UpdateRestockedQtyTextBox.Size = new System.Drawing.Size(159, 20);
            this.UpdateRestockedQtyTextBox.TabIndex = 6;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(607, 360);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 7;
            this.SortButton.Text = "Sort Users";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.UpdateRestockedQtyTextBox);
            this.Controls.Add(this.UpdateSoldQtyTextBox);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.ChangeSoldQtyButton);
            this.Controls.Add(this.ChangeRestockedQtyButton);
            this.Controls.Add(this.LoadItemsButton);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Button LoadItemsButton;
        private System.Windows.Forms.Button ChangeRestockedQtyButton;
        private System.Windows.Forms.Button ChangeSoldQtyButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.TextBox UpdateSoldQtyTextBox;
        private System.Windows.Forms.TextBox UpdateRestockedQtyTextBox;
        private System.Windows.Forms.Button SortButton;
    }
}

