using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Diagnostics;

namespace GoodbyeDPIHelper
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }


        Process p = new Process();
        public string FilePath_x86 = Application.StartupPath + "\\goodbyedpi-0.1.5\\x86\\goodbyedpi.exe";
        public string FilePath_x64 = Application.StartupPath + "\\goodbyedpi-0.1.5\\x86_64\\goodbyedpi.exe";

        private void MainForm_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check x32 x64
            if (OSRB1.Checked)
            {
                p.StartInfo.FileName = FilePath_x86;
            }
            else if(OSRB2.Checked)
            {
                p.StartInfo.FileName = FilePath_x64;
            }

            // check DPI option
            if (DPISetRB1.Checked)
            {
                p.StartInfo.Arguments = " -1";
            }
            else if (DPISetRB2.Checked)
            {
                p.StartInfo.Arguments = " -2";
            }
            else if (DPISetRB3.Checked)
            {
                p.StartInfo.Arguments = " -3";
            }
            else if (DPISetRB4.Checked)
            {
                p.StartInfo.Arguments = " -4";
            }

            // WindowStyli => Minimized
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Process Start
            p.Start();

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Process process in Process.GetProcesses())
            {
                if(process.ProcessName.StartsWith("goodbyedpi"))
                {
                    process.Kill();
                }
            }

            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
