using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7
{
    public partial class FileForm : Form
    {
        private FileInfo fileInfo;

        public FileForm()
        {
            InitializeComponent();
            fileInfo = new FileInfo();

            label3.Text = fileInfo.GetStartupPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = fileInfo.GetExtenstion(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = fileInfo.GetFileNameWithoutExtension(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = fileInfo.GetRootPath(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = fileInfo.GetCurrentDrives();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fileInfo.CopyFile(textBox2.Text, textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fileInfo.MoveFile(textBox2.Text, textBox3.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = fileInfo.OpenFileDiaglogPath();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = fileInfo.OpenFileDiaglogPath();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fileInfo.DeleteFile(textBox4.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string[] info = fileInfo.GetPersonInfo();
            textBox5.Text = info[0];
            textBox6.Text = info[1];
            textBox7.Text = info[2];
            textBox8.Text = info[3];
            textBox9.Text = info[4];
            textBox10.Text = info[5];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] info = new string[6];
            info[0] =  textBox5.Text;
            info[1] =  textBox6.Text;
            info[2] =  textBox7.Text;
            info[3] =  textBox8.Text;
            info[4] =  textBox9.Text;
            info[5] =  textBox10.Text;

            fileInfo.SavePersonInfo(info);
        }
    }
}
