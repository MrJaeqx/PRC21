namespace Week_7._4_AnimalFileImporter
{
    partial class AnimalFileImporter
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
            this.catBox = new System.Windows.Forms.ListBox();
            this.dogBox = new System.Windows.Forms.ListBox();
            this.importButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catBox
            // 
            this.catBox.FormattingEnabled = true;
            this.catBox.Location = new System.Drawing.Point(12, 42);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(327, 290);
            this.catBox.TabIndex = 0;
            // 
            // dogBox
            // 
            this.dogBox.FormattingEnabled = true;
            this.dogBox.Location = new System.Drawing.Point(345, 42);
            this.dogBox.Name = "dogBox";
            this.dogBox.Size = new System.Drawing.Size(330, 290);
            this.dogBox.TabIndex = 1;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(12, 13);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(97, 23);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import Animals";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // AnimalFileImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 344);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.dogBox);
            this.Controls.Add(this.catBox);
            this.Name = "AnimalFileImporter";
            this.Text = "AnimalFileImporter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox catBox;
        private System.Windows.Forms.ListBox dogBox;
        private System.Windows.Forms.Button importButton;
    }
}

