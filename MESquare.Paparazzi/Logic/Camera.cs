using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESquare.Paparazzi.Logic
{
    public class Camera
    {
        public void CaptureAllScreensToFile(String destination)
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                CaptureScreenToFile(Screen.AllScreens[i], destination, i + 1);
            }
        }

        private void CaptureScreenToFile(Screen screen, String destination, int screenIdx)
        {
            using (Bitmap bmpScreenCapture = CreateBitmap(screen))
            {
                using (Graphics g = Graphics.FromImage(bmpScreenCapture))
                {
                    g.CopyFromScreen(
                        screen.Bounds.X,
                        screen.Bounds.Y,
                        0,
                        0,
                        bmpScreenCapture.Size,
                        CopyPixelOperation.SourceCopy
                    );
                }
                bmpScreenCapture.Save(GetFileFullPath(destination, screenIdx), ImageFormat.Png);
            }
        }

        private String GetFileFullPath(String destination, int idx)
        {
            return $@"{destination}\capture_S{idx.ToString("D3")}_{DateTime.Now.ToString("yyyyMMdd_HHmmfff")}.png";
        }

        private Bitmap CreateBitmap(Screen screen)
        {
            return new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
        }
    }
}
