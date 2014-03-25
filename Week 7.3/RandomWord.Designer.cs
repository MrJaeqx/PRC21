namespace Week_7._3
{
    partial class RandomWord
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
            this.getwords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getwords
            // 
            this.getwords.Location = new System.Drawing.Point(13, 13);
            this.getwords.Name = "getwords";
            this.getwords.Size = new System.Drawing.Size(94, 23);
            this.getwords.TabIndex = 0;
            this.getwords.Text = "Get Word";
            this.getwords.UseVisualStyleBackColor = true;
            this.getwords.Click += new System.EventHandler(this.getwords_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // RandomWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 87);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getwords);
            this.Name = "RandomWord";
            this.Text = "RandomWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getwords;
        private System.Windows.Forms.Label label1;
    }
}

