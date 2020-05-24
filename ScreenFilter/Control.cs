using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenFilter
{
    public partial class Control : Form
    {
        readonly Filter filter = new Filter();
        public Control()
        {
            InitializeComponent();
            filter.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Debug.WriteLine((double)trackBar1.Value / 10);
            filter.Opacity = ((double)trackBar1.Value / 10);
            filter.TopMost = true;
            this.TopMost = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
            if (e.Button is MouseButtons.Left)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Normal;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For more information, visit \n https://github.com/zethsqx/win10-screen-filter-overlay", "About",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
