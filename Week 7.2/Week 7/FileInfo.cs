using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7
{
    class FileInfo
    {

        public FileInfo()
        {

        }

        public string GetExtenstion(string path)
        {
            return Path.GetExtension(path);
        }

        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public string GetRootPath(string path)
        {
            return Path.GetPathRoot(path);
        }

        public string GetCurrentDrives() {
            DriveInfo[] drives = DriveInfo.GetDrives();
            string drivesAsStrings = "";
            foreach(DriveInfo drive in drives) {
                drivesAsStrings += drive.ToString() + ", ";
            }
            return drivesAsStrings;
        }

        public void CopyFile(string fromPath, string toPath)
        {
            File.Copy(fromPath, toPath);
        }

        public void MoveFile(string fromPath, string toPath)
        {
            File.Move(fromPath, toPath);
        }

        public string OpenFileDiaglogPath()
        {
            //String myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            dialog.ShowDialog();

            return dialog.SelectedPath;
        }

        public string GetStartupPath()
        {
            return Application.StartupPath;
        }

        public void DeleteFile(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }

        public string[] GetPersonInfo()
        {
            string[] personInfo = new string[6];

            OpenFileDialog dialog = new OpenFileDialog();;
            dialog.ShowDialog();

            StreamReader sr = new StreamReader(dialog.OpenFile());

            personInfo[0] = sr.ReadLine();
            personInfo[1] = sr.ReadLine();
            personInfo[2] = sr.ReadLine();
            personInfo[3] = sr.ReadLine();
            personInfo[4] = sr.ReadLine();
            personInfo[5] = sr.ReadLine();

            sr.Close();

            return personInfo;
        }

        public void SavePersonInfo(string[] info)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = info[0] + info[1];
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text File (*.txt)|*.txt";
            dialog.ShowDialog();

            StreamWriter sw = new StreamWriter(dialog.OpenFile());

            for (int i = 0; i < info.Length; i++)
            {
                sw.WriteLine(info[i]);
            }

            sw.Close();
        }
    }
}
