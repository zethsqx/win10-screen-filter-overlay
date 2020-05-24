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
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
            if (e.Button is MouseButtons.Left)
            {
                Show();
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
