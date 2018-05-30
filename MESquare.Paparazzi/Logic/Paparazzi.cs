using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MESquare.Paparazzi.Logic
{
    public class Paparazzi : IDisposable
    {

        public Action<double,double> OnCountDownUpdated = null;

        public Settings Settings { get; set; } = new Settings();

        private Timer timer = new Timer();
        private Camera camera = new Camera();
        private bool requiredRestart = false;

        private double countDown = 0;
        private double CountDown
        {
            get
            {
                return countDown;
            }
            set
            {
                var previousValue = this.CountDown;
                var newValue = value;

                this.countDown = newValue;
                this.OnCountDownUpdated?.Invoke(previousValue, newValue);
            }
        }

        public bool IsRunning { get; set; }

        public void Start()
        {
            if (!this.IsRunning)
            {
                this.requiredRestart = this.timer.Interval != this.Settings.TimerInterval;
                this.timer.Interval = this.Settings.CountDownInterval;
                this.timer.Elapsed += this.OnTimerElapsed;
                this.CountDown = this.Settings.TimerInterval;
                this.timer.Start();
                this.IsRunning = true;
            }
        }

        public void Stop()
        {
            if (this.IsRunning)
            {
                this.timer.Stop();
                this.IsRunning = false;
            }
        }

        public void Restart(bool lazzy = false)
        {
            //lazzy - restart only if need to restart.
            if (this.IsRunning && ( lazzy && this.requiredRestart || !lazzy))
            {
                this.Stop();
                this.Start();
            }
        }

        private void OnTimerElapsed(Object sender, ElapsedEventArgs e)
        {
            if (this.CountDown <= 0)
            {
                this.TakeScreenshot();
                this.CountDown = this.Settings.TimerInterval;
            }
            else
            {
                this.CountDown -= this.Settings.CountDownInterval;
            }
        }

        public void TakeScreenshot()
        {
            this.camera.CaptureAllScreensToFile(GetScreenshotPath());
        }

        private string GetScreenshotPath()
        {
            var path = Path.Combine(
                this.Settings.DestinyFolder
                ,DateTime.Now.Year.ToString("D4")
                ,DateTime.Now.Month.ToString("D2")
            );

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path;
        }

        public void Dispose()
        {
            this.timer.Dispose();
        }
    }
}
