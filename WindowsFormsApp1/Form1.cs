using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printfile_Click(object sender, EventArgs e)
        {
            const int ERROR_FILE_NOT_FOUND = 2;
            const int ERROR_ACCESS_DENIED = 5;

            Process myProcess = new Process();

            try
            {
                // Get the path that stores user documents.
                string myDocumentsPath =
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                myProcess.StartInfo.FileName = myDocumentsPath + "\\Document.txt";
                myProcess.StartInfo.Verb = "Print";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            catch (Win32Exception ex)
            {
                if (ex.NativeErrorCode == ERROR_FILE_NOT_FOUND)
                {
                    String msg = ex.Message + ". Check the path.";
                    MessageBox.Show(msg, "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (ex.NativeErrorCode == ERROR_ACCESS_DENIED)
                {
                    // Note that if your word processor might generate exceptions
                    // such as this, which are handled first.
                    String msg = ex.Message + ". Permission denied";
                    MessageBox.Show(msg, "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        // Start a Program Forever
        private void startForever_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "NotePad";
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            myProcess.Start();
        }

        // Start a Program some Sec
        private void startSomeSecs_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "Notepad";
            process.Start();

            process.WaitForInputIdle();
            Thread.Sleep(5000);
            if (!process.CloseMainWindow())
            {
                process.Kill();
            }
        }

        //Stop NotePad if running
        private void exitProcess_Click(object sender, EventArgs e)
        {
            Process[] myProcesses;
            //array containing all instances of Notepad
            myProcesses = Process.GetProcessesByName("Notepad");
            foreach (Process myProcess in myProcesses)
            {
                myProcess.CloseMainWindow();
            }
        }

        private void showRunning_Click(object sender, EventArgs e)
        {
            Process[] myProcesses = Process.GetProcesses();
            String msg = "";
            foreach (Process myProcess in myProcesses)
            {
                //if(myProcess.ProcessName != "svchost")
                    msg += myProcess.ProcessName + "\n";
            }
            MessageBox.Show(msg, "Processes running",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
