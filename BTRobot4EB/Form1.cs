using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BTRobot4EB
{
    public partial class mainForm : Form
    {
        [DllImport("QR_Encode.dll")]
        static extern int generate(string str, string dir);

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        string imgDir;
        Bitmap bmp = null;
        string iniPath;

        public mainForm()
        {
            InitializeComponent();

            textBoxQR.GotFocus += new EventHandler(textBoxQR_GotFocus);
            textBoxQR.DoubleClick += new EventHandler(textBoxQR_DoubleClick);

            textBoxDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        }

        private void textBoxQR_GotFocus(object sender, EventArgs e)
        {
            textBoxQR.SelectAll();
        }


        private void textBoxQR_DoubleClick(object sender, EventArgs e)
        {
            textBoxQR.SelectAll();
        }

        private void buttonGe_Click(object sender, EventArgs e)
        {
            if (checkBoxAI.Checked)
            {
                if (Directory.Exists(textBoxAIDir.Text))
                {
                    if (!File.Exists(textBoxAIDir.Text + "\\Support Files\\Contents\\Windows\\Illustrator.exe"))
                    {
                        MessageBox.Show("请确认 AI 安装路径是否正确!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("请先设置 AI 安装路径!");
                    return;
                }
            }

            imgDir = textBoxDir.Text + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";
            generate(textBoxQR.Text, imgDir);
            if (bmp != null)
            {
                bmp.Dispose();
                bmp = null;
            }
            bmp = new Bitmap(imgDir);
            pictureBoxQR.Image = (Image)bmp;

            if (checkBoxAI.Checked)
                Process.Start(textBoxAIDir.Text + "\\Support Files\\Contents\\Windows\\Illustrator.exe", imgDir);
        }

        private void qr_create_Click(object sender, EventArgs e)
        {
            groupBoxQR.Text = "QR生成设置";
        }

        private void buttonDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDir.Text = folderDialog.SelectedPath;
            }
        }

        private void buttonCodbar_Click(object sender, EventArgs e)
        {
            groupBoxQR.Text = "条码生成设置";
        }

        private void checkBoxAI_CheckedChanged(object sender, EventArgs e)
        {
            if (!textBoxAIDir.Visible)
            {
                textBoxAIDir.Enabled = true;
                textBoxAIDir.Visible = true;
                buttonAIDir.Enabled = true;
                buttonAIDir.Visible = true;
                iniPath = Process.GetCurrentProcess().MainModule.FileName;
                iniPath = iniPath.Replace("exe", "ini");
                if (File.Exists(iniPath))
                {
                    StringBuilder temp = new StringBuilder(500);
                    int i = GetPrivateProfileString("Config", "AI_DIR", "", temp, 500, iniPath);
                    textBoxAIDir.Text = temp.ToString();
                }
            }
            else
            {
                textBoxAIDir.Enabled = false;
                textBoxAIDir.Visible = false;
                buttonAIDir.Enabled = false;
                buttonAIDir.Visible = false;
            }
        }

        private void buttonAIDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAIDir.Text = folderDialog.SelectedPath;
                if (!File.Exists(iniPath))
                {
                    StreamWriter sw = File.CreateText(iniPath);
                    sw.Close();
                }
                WritePrivateProfileString("Config", "AI_DIR", textBoxAIDir.Text, iniPath);
            }
        }

    }
}
