using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zizibe.Common
{
    public class Function
    {
        public Bitmap setCapture(IntPtr hWnd)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            var gdata = Graphics.FromHwnd(hWnd);
            var rect = Rectangle.Round(gdata.VisibleClipBounds);
            var bmp = new Bitmap(Math.Max(1, rect.Width), Math.Max(1, rect.Height));
            if (bmp.Width == 1 && bmp.Height == 1)
            {
                bmp = new Bitmap(960, 540);
                return bmp;
            }

            using (var g = Graphics.FromImage(bmp))
            {
                //this.PurpleWindowHandler?.Restore(!this.checkBox1.Checked);

                IntPtr hdc = g.GetHdc();
                WinAPI.PrintWindow(hWnd, hdc, 0x2);
                g.ReleaseHdc(hdc);
            }

            return bmp;
        }

    }
}

