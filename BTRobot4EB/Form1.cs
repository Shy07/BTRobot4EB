using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //string dir = textBoxDir.Text + "\\" + textBoxQR.Text.Substring(textBoxQR.Text.Length - 12, 12) + ".bmp";
            string dir = textBoxDir.Text + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";
            generate(textBoxQR.Text, dir);
            if (checkBoxAI.Checked)
            {
                return;
            }
        }

        private void qr_create_Click(object sender, EventArgs e)
        {
            groupBoxQR.Visible = true;
            groupBoxQR.Enabled = true;
        }

        private void buttonDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDir.Text = folderDialog.SelectedPath;
            }
            //else
            //{
            //    textBoxDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //}
        }

    }
}
