namespace Week1
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewCijfers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddCijfer = new System.Windows.Forms.Button();
            this.numericUpDownCijfer = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTel = new System.Windows.Forms.Label();
            this.numericUpDownTel = new System.Windows.Forms.NumericUpDown();
            this.buttonTel = new System.Windows.Forms.Button();
            this.labelAantal = new System.Windows.Forms.Label();
            this.buttonAantal = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelGemiddelde = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonGemiddelde = new System.Windows.Forms.Button();
            this.buttonOpdracht7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijfer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listViewCijfers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listViewCijfers
            // 
            this.listViewCijfers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCijfers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCijfers.Location = new System.Drawing.Point(3, 3);
            this.listViewCijfers.Name = "listViewCijfers";
            this.listViewCijfers.Size = new System.Drawing.Size(406, 387);
            this.listViewCijfers.TabIndex = 0;
            this.listViewCijfers.UseCompatibleStateImageBehavior = false;
            this.listViewCijfers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cijfer";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonOpdracht7, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(415, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(407, 387);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cijfer toevoegen";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.Controls.Add(this.buttonAddCijfer, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownCijfer, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 35);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonAddCijfer
            // 
            this.buttonAddCijfer.Location = new System.Drawing.Point(323, 3);
            this.buttonAddCijfer.Name = "buttonAddCijfer";
            this.buttonAddCijfer.Size = new System.Drawing.Size(69, 23);
            this.buttonAddCijfer.TabIndex = 1;
            this.buttonAddCijfer.Text = "Toevoegen";
            this.buttonAddCijfer.UseVisualStyleBackColor = true;
            this.buttonAddCijfer.Click += new System.EventHandler(this.buttonAddCijfer_Click);
            // 
            // numericUpDownCijfer
            // 
            this.numericUpDownCijfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownCijfer.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownCijfer.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCijfer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCijfer.Name = "numericUpDownCijfer";
            this.numericUpDownCijfer.Size = new System.Drawing.Size(314, 20);
            this.numericUpDownCijfer.TabIndex = 2;
            this.numericUpDownCijfer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acties";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTel);
            this.panel1.Controls.Add(this.numericUpDownTel);
            this.panel1.Controls.Add(this.buttonTel);
            this.panel1.Controls.Add(this.labelAantal);
            this.panel1.Controls.Add(this.buttonAantal);
            this.panel1.Controls.Add(this.labelMin);
            this.panel1.Controls.Add(this.labelMax);
            this.panel1.Controls.Add(this.labelGemiddelde);
            this.panel1.Controls.Add(this.buttonMin);
            this.panel1.Controls.Add(this.buttonMax);
            this.panel1.Controls.Add(this.buttonGemiddelde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 175);
            this.panel1.TabIndex = 0;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(136, 124);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(13, 13);
            this.labelTel.TabIndex = 10;
            this.labelTel.Text = "0";
            // 
            // numericUpDownTel
            // 
            this.numericUpDownTel.Location = new System.Drawing.Point(84, 122);
            this.numericUpDownTel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTel.Name = "numericUpDownTel";
            this.numericUpDownTel.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTel.TabIndex = 9;
            this.numericUpDownTel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTel.ValueChanged += new System.EventHandler(this.numericUpDownTel_ValueChanged);
            // 
            // buttonTel
            // 
            this.buttonTel.Location = new System.Drawing.Point(3, 119);
            this.buttonTel.Name = "buttonTel";
            this.buttonTel.Size = new System.Drawing.Size(75, 23);
            this.buttonTel.TabIndex = 8;
            this.buttonTel.Text = "Tel";
            this.buttonTel.UseVisualStyleBackColor = true;
            // 
            // labelAantal
            // 
            this.labelAantal.AutoSize = true;
            this.labelAantal.Location = new System.Drawing.Point(84, 95);
            this.labelAantal.Name = "labelAantal";
            this.labelAantal.Size = new System.Drawing.Size(13, 13);
            this.labelAantal.TabIndex = 7;
            this.labelAantal.Text = "0";
            // 
            // buttonAantal
            // 
            this.buttonAantal.Location = new System.Drawing.Point(3, 90);
            this.buttonAantal.Name = "buttonAantal";
            this.buttonAantal.Size = new System.Drawing.Size(75, 23);
            this.buttonAantal.TabIndex = 6;
            this.buttonAantal.Text = "Aantal";
            this.buttonAantal.UseVisualStyleBackColor = true;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(84, 66);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(13, 13);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "0";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(84, 37);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(13, 13);
            this.labelMax.TabIndex = 4;
            this.labelMax.Text = "0";
            // 
            // labelGemiddelde
            // 
            this.labelGemiddelde.AutoSize = true;
            this.labelGemiddelde.Location = new System.Drawing.Point(84, 8);
            this.labelGemiddelde.Name = "labelGemiddelde";
            this.labelGemiddelde.Size = new System.Drawing.Size(13, 13);
            this.labelGemiddelde.TabIndex = 3;
            this.labelGemiddelde.Text = "0";
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(3, 61);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(75, 23);
            this.buttonMin.TabIndex = 2;
            this.buttonMin.Text = "Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(3, 32);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(75, 23);
            this.buttonMax.TabIndex = 1;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            // 
            // buttonGemiddelde
            // 
            this.buttonGemiddelde.Location = new System.Drawing.Point(3, 3);
            this.buttonGemiddelde.Name = "buttonGemiddelde";
            this.buttonGemiddelde.Size = new System.Drawing.Size(75, 23);
            this.buttonGemiddelde.TabIndex = 0;
            this.buttonGemiddelde.Text = "Gemiddelde";
            this.buttonGemiddelde.UseVisualStyleBackColor = true;
            // 
            // buttonOpdracht7
            // 
            this.buttonOpdracht7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOpdracht7.Location = new System.Drawing.Point(3, 361);
            this.buttonOpdracht7.Name = "buttonOpdracht7";
            this.buttonOpdracht7.Size = new System.Drawing.Size(401, 23);
            this.buttonOpdracht7.TabIndex = 2;
            this.buttonOpdracht7.Text = "Opdracht 7";
            this.buttonOpdracht7.UseVisualStyleBackColor = true;
            this.buttonOpdracht7.Click += new System.EventHandler(this.buttonOpdracht7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 393);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Sjpealer cijfers ++";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijfer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewCijfers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonAddCijfer;
        private System.Windows.Forms.NumericUpDown numericUpDownCijfer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAantal;
        private System.Windows.Forms.Button buttonAantal;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelGemiddelde;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonGemiddelde;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.NumericUpDown numericUpDownTel;
        private System.Windows.Forms.Button buttonTel;
        private System.Windows.Forms.Button buttonOpdracht7;
    }
}

