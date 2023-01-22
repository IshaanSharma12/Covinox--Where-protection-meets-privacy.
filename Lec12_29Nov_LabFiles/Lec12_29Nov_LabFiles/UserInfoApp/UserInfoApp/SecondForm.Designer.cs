namespace UserInfoApp
{
    partial class SecondForm
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
            this.SecondFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondFormLabel
            // 
            this.SecondFormLabel.Location = new System.Drawing.Point(127, 159);
            this.SecondFormLabel.Name = "SecondFormLabel";
            this.SecondFormLabel.Size = new System.Drawing.Size(525, 109);
            this.SecondFormLabel.TabIndex = 0;
            this.SecondFormLabel.Text = "label1";
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecondFormLabel);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label SecondFormLabel;
    }
}