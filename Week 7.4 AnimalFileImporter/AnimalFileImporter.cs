using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7._4_AnimalFileImporter
{
    public partial class AnimalFileImporter : Form
    {
        public AnimalFileImporter()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Open file dialog for selecting file
                OpenFileDialog dialog = new OpenFileDialog(); ;
                dialog.ShowDialog();

                StreamReader sr = new StreamReader(dialog.OpenFile());

                // Check each line
                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();
                    if (line.Substring(0, 3) == "Cat")
                    {
                        catBox.Items.Add(line);
                    }
                    else if (line.Substring(0, 3) == "Dog")
                    {
                        dogBox.Items.Add(line);
                    }

                }
            } // Exception if unauthorized to write in specific dir
            catch(UnauthorizedAccessException ex)
            {
                Debug.WriteLine(ex.Message);
            } // Exception if dir not found
            catch (DirectoryNotFoundException ex)
            {
                Debug.WriteLine(ex.Message);
            } // Exception if worng file format is supplied
            catch (ArgumentOutOfRangeException ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
    }
}
