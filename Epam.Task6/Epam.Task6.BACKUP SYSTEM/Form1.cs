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

namespace Epam.Task6.BACKUP_SYSTEM
{
    public partial class BACKUPSYSTEM : Form
    {
        private string pathforwatch;
        private string subpath = @"BACKUP";
        private DirectoryInfo dirInfo;
        private FileSystemWatcher fileWatcher;
        
        public BACKUPSYSTEM()
        {
            this.InitializeComponent();
            this.dirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            if (!this.dirInfo.Exists)
            {
                this.dirInfo.Create();
            }

            this.dirInfo.CreateSubdirectory(this.subpath);
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.fileWatcher.EnableRaisingEvents = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            this.fileWatcher.EnableRaisingEvents = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.pathforwatch = this.folderBrowserDialog1.SelectedPath;
            if (!this.pathforwatch.Equals(string.Empty))
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                dateTimePicker1.Enabled = true;
                this.fileWatcher = new FileSystemWatcher(this.pathforwatch);
                this.fileWatcher.Changed += new FileSystemEventHandler(this.Savechanges);
                this.fileWatcher.Created += new FileSystemEventHandler(this.Savechanges);
                this.fileWatcher.Deleted += new FileSystemEventHandler(this.Savechanges);
                this.fileWatcher.Renamed += new RenamedEventHandler(this.Savechanges);
                this.fileWatcher.EnableRaisingEvents = true;
            }
        }

        private void Savechanges(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            DirectoryCopy(this.pathforwatch, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, this.subpath, DateTime.Now.ToString("dd.MMMM.yyyy.HH.mm.ss")), false);
        }
 
        private void Button1_Click(object sender, EventArgs e)
        {
            int twoday = 172800;
            DateTimePicker d = dateTimePicker1;
            this.dirInfo = new DirectoryInfo(this.pathforwatch);
            TimeSpan onesec = new TimeSpan(0, 0, 0, 1);

            for (int i = 0; i < twoday; i++)
            {
                this.dateTimePicker1 = d;
                if (Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, this.subpath, dateTimePicker1.Text)))
                {
                    foreach (FileInfo f in this.dirInfo.GetFiles())
                    {
                        f.Delete();
                    }

                    DirectoryCopy(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, this.subpath, dateTimePicker1.Text), this.pathforwatch, false);
                    break;
                }

                d.Value -= onesec;
                if (i == twoday - 1)
                {
                    MessageBox.Show("at that time  and 2 days ago there were no changes");
                }
            }
        }
    }
}
