using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7._3
{
    public partial class RandomWord : Form
    {

        private string filePath;
        private List<string> words;

        public RandomWord()
        {
            InitializeComponent();

            filePath = Application.StartupPath + "\\words.txt";
            words = new List<string>();

            ReadFile();
        }

        private void ReadFile()
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);

                sr.ReadLine();
                string wordString = sr.ReadLine();

                string[] wordArray = wordString.Split(' ');

                foreach (string word in wordArray)
                {
                    words.Add(word);
                }

                sr.Close();
            }catch(FileNotFoundException ex) {
                MessageBox.Show("File Not Found!");
            }            
        }

        private string GetRandomWord()
        {
            string ret = "";
            if (words.Count > 0)
            {
                Random r = new Random();

                ret = words[r.Next(0, words.Count)];
            }
            return ret;
        }

        private void getwords_Click(object sender, EventArgs e)
        {
            label1.Text = GetRandomWord();
        }
    }
}
