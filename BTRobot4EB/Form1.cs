using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTRobot4EB
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            textBoxQR.Tag = false;
            textBoxQR.GotFocus += new EventHandler(textBoxQR_GotFocus);
            textBoxQR.MouseUp += new MouseEventHandler(textBoxQR_MouseUp);


        }

        private void textBoxQR_GotFocus(object sender, EventArgs e)
        {
            textBoxQR.Tag = true;
            textBoxQR.SelectAll();
        }

        private void textBoxQR_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (bool)textBoxQR.Tag == true)
            {
                textBoxQR.SelectAll();
            }
            textBoxQR.Tag = false;
        }

    }
}
