using MESquare.Paparazzi.Forms;
using MESquare.Paparazzi.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESquare.Paparazzi
{
    public partial class frmMain : Form
    {
        private Logic.Paparazzi paparazzi = null;

        public frmMain()
        {
            InitializeComponent();
            InitializeProperties();
            this.lblStatus.Text = "Press 'Start' to start the process";
        }

        private void InitializeProperties()
        {
            paparazzi = new Logic.Paparazzi()
            {
                Settings = new Settings(),
                OnCountDownUpdated = (p,n) =>
                {
                    lblStatus.Text = $"Next Screen Capture in {n} ms";
                }
            };
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void TakeScreenshot()
        {
            this.paparazzi.TakeScreenshot();
        }

        private void ShowSettings()
        {
            using (var frm = new frmSettings())
            {
                frm.ShowDialog();
                this.paparazzi.Restart(true);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Stop();
        }

        private void Stop()
        { 
            this.paparazzi.Stop();
            this.btnStop.Enabled = false;
            this.btnStart.Enabled = true;
            this.btnMenuItemStart.Enabled = true;
            this.btnMenuItemStop.Enabled = false;
            this.lblStatus.Text = "Press 'Start' to start the process";
        }

        private void btnTakeScreenshot_Click(object sender, EventArgs e)
        {
            //opacity also works.
            //this.Opacity = 0;
            this.Hide();
            TakeScreenshot();
            this.Show();
            //this.Opacity = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        { 
            this.paparazzi.Start();
            this.btnStop.Enabled = true;
            this.btnStart.Enabled = false;
            this.btnMenuItemStart.Enabled = false;
            this.btnMenuItemStop.Enabled = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Open();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.paparazzi.IsRunning)
            {
                if( MessageBox.Show("Paparazzi is running. Do you want to close the application?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Open();
        }

        private void Open()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Stop();
        }
    }
}
