using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zizibe.Common
{
    public static class Controller
    {
        [DllImport("Mewsin.dll")]
        public static extern bool extSendMessageA(IntPtr hWnd, uint msg, uint wParam, IntPtr lParam);
        [DllImport("Mewsin.dll")]
        public static extern bool extSendMessageW(IntPtr hWnd, uint msg, uint wParam, IntPtr lParam);
        [DllImport("Mewsin.dll")]
        public static extern bool extPostMessageW(IntPtr hWnd, uint msg, uint wParam, IntPtr lParam);
        [DllImport("Mewsin.dll")]
        public static extern bool extPostMessageA(IntPtr hWnd, uint msg, uint wParam, IntPtr lParam);

        private const uint WM_MOUSEMOVE = 0x0200;
        private const uint WM_LBUTTONDOWN = 0x0201;
        private const uint WM_LBUTTONUP = 0x0202;
        private const uint WM_KEYDOWN = 0x100;
        private const uint WM_MOUSEWHEEL = 0x020A;
        private const uint WM_KEYUP = 0x101;

        private const int MK_LBUTTON = 0x0001;

        [Flags]
        public enum WinMsgMouseKey : int
        {
            MK_NONE = 0x0000,
            MK_LBUTTON = 0x0001,
            MK_RBUTTON = 0x0002,
            MK_SHIFT = 0x0004,
            MK_CONTROL = 0x0008,
            MK_MBUTTON = 0x0010,
            MK_XBUTTON1 = 0x0020,
            MK_XBUTTON2 = 0x0040
        }

        private static IntPtr MakeLParam(int x, int y) => (IntPtr)((y << 16) | (x & 0xFFFF));
        private static uint MAKEWPARAM(int direction, float multiplier, WinMsgMouseKey button)
        {
            int delta = (int)(SystemInformation.MouseWheelScrollDelta * multiplier);
            return (uint)(((delta << 16) * Math.Sign(direction) | (ushort)button));
        }
        private static IntPtr MAKELPARAM(int low, int high)
        {
            return (IntPtr)((high << 16) | (low & 0xFFFF));
        }


        public static void Click(IntPtr hWnd, int X, int Y)
        {
            extPostMessageA(hWnd, WM_MOUSEMOVE, 0, MakeLParam(X, Y));
            extPostMessageA(hWnd, WM_LBUTTONDOWN, MK_LBUTTON, MakeLParam(X, Y));
            extPostMessageA(hWnd, WM_MOUSEMOVE, 0, MakeLParam(X, Y));
            extPostMessageA(hWnd, WM_LBUTTONUP, MK_LBUTTON, MakeLParam(X, Y));
        }

        public static void TEST(IntPtr hWnd, int X, int Y)
        {
            int directionUp = 1;
            int directionDown = -1;

            // Scrolls [Handle] down by 1/2 wheel rotation with Left Button pressed
            uint wParam = MAKEWPARAM(directionDown, .5f, WinMsgMouseKey.MK_LBUTTON);
            IntPtr lParam = MAKELPARAM(X, Y);

            extPostMessageA(hWnd, WM_MOUSEWHEEL, wParam, lParam);
        }

    }
}
