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
using System.Runtime.InteropServices;

namespace GoodbyeDPIHelper
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // ini 파싱
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
                                                        int size, string filePath);


        Process p = new Process();
        string FilePath;
        string FilePath_x86;
        string FilePath_x64;
        StringBuilder DPIFolder = new StringBuilder();


        private void MainForm_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

            //ini 읽기
            GetPrivateProfileString("Settings", "DPIFolder", "", DPIFolder, 200, Application.StartupPath + "\\Settings.ini");

            textBox1.Text = Path.GetDirectoryName(DPIFolder.ToString() +"\\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "폴더선택")
            {
                MessageBox.Show("설정 - 폴더선택 버튼으로 GoodbyeDPI 폴더를 선택 해주세요.");
                return;
            }



            // check x32 x64
            if (OSRB1.Checked)
            {
                p.StartInfo.FileName = textBox1.Text + "\\x86\\goodbyedpi.exe";
            }
            else if(OSRB2.Checked)
            {
                p.StartInfo.FileName = textBox1.Text + "\\x86_64\\goodbyedpi.exe";
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WritePrivateProfileString("Settings", "DPIFolder", textBox1.Text, Application.StartupPath + "\\Settings.ini");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Application.StartupPath;

            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
