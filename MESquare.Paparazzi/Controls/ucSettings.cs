using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MESquare.Paparazzi.Logic;

namespace MESquare.Paparazzi.Controls
{
    public partial class ucSettings : UserControl
    {

        public class TimeUnit
        {
            public int NumberOfMilleseconds { get; set; }
            public int Maximum { get; set; }
        }

        public event Action AfterOkPressed;
        public event Action AfterCancelPressed;

        private Settings settings = new Settings();

        public ucSettings()
        {
            InitializeComponent();
            InitializeTimerIntervalUnits();
        }

        private Dictionary<String, TimeUnit> timeUnits = new Dictionary<string, TimeUnit>
        {
            {"Milliseconds",new TimeUnit(){ NumberOfMilleseconds=1,Maximum = 7200000 } }
            ,{"Seconds",new TimeUnit(){ NumberOfMilleseconds=1000,Maximum =  7200 } }
            ,{"Minutes",new TimeUnit(){ NumberOfMilleseconds=60000,Maximum = 120 } }
        };

        private void InitializeTimerIntervalUnits()
        {
            this.timeUnits.ToList().ForEach(kvp => cmbTimerIntervalUnit.Items.Add(kvp.Key));
            cmbTimerIntervalUnit.SelectedIndex = 0;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveSettings();
            AfterOkPressed?.Invoke();
        }

        private void SaveSettings()
        {
            var timerInterval = Convert.ToInt32(nudTimerInterval.Value);
            var timeUnit = this.timeUnits[cmbTimerIntervalUnit.Text];

            this.settings.DestinyFolder = txtPaparazziDestinyFolder.Text;
            this.settings.TimerIntervalUnit = cmbTimerIntervalUnit.Text;
            this.settings.TimerInterval = timerInterval * timeUnit.NumberOfMilleseconds;

            Properties.Settings.Default.Save();
        }

        private void ShowSettings()
        {
            txtPaparazziDestinyFolder.Text = this.settings.DestinyFolder;
            cmbTimerIntervalUnit.Text = this.settings.TimerIntervalUnit;
            var timeUnit = this.timeUnits[cmbTimerIntervalUnit.Text];

            var timerInterval = Convert.ToInt32(this.settings.TimerInterval);

            nudTimerInterval.Value = Math.Max(1, timerInterval / timeUnit.NumberOfMilleseconds);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AfterCancelPressed?.Invoke();
        }

        private void ucSettings_Load(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void btnBrowseDestinyFolder_Click(object sender, EventArgs e)
        {
            ShowBrowseDestinyFolder();
        }

        private void ShowBrowseDestinyFolder()
        {
            folderBrowserDialog.SelectedPath = txtPaparazziDestinyFolder.Text;

            if (String.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if ( folderBrowserDialog.ShowDialog() == DialogResult.OK )
                txtPaparazziDestinyFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void nudTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            AjustTimerInterval();
        }

        private void AjustTimerInterval()
        {
            var timeUnit = this.timeUnits[cmbTimerIntervalUnit.Text];
            nudTimerInterval.Value = Math.Min(nudTimerInterval.Value, timeUnit.Maximum);
        }
    }
}
