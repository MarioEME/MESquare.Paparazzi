using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESquare.Paparazzi.Logic
{
    public class Settings
    {
        public String DestinyFolder
        {
            get
            {
                return Properties.Settings.Default.PAPARAZZI_DESTINY_FOLDER;
            }
            set
            {
                Properties.Settings.Default.PAPARAZZI_DESTINY_FOLDER = value;
            }
        }

        public Int32 TimerInterval
        {
            get
            {
                return Properties.Settings.Default.PAPARAZZI_TIMER_INTERVAL;
            }
            set
            {
                Properties.Settings.Default.PAPARAZZI_TIMER_INTERVAL = value;
            }
        }

        public String TimerIntervalUnit
        {
            get
            {
                return Properties.Settings.Default.PAPARAZZI_TIMER_INTERVAL_UNIT;
            }
            set
            {
                Properties.Settings.Default.PAPARAZZI_TIMER_INTERVAL_UNIT = value;
            }
        }

        public double CountDownInterval
        {
            get
            {
                return Properties.Settings.Default.PAPARAZZI_COUNTDOWN_INTERVAL;
            }
        }
    }
}
