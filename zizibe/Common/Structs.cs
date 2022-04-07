using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zizibe.Common
{
    public class Tabs
    {
        public int idx = 0;
        public string Name = "";
        public XtraUserControl ctr;
        public DockingStyle dockStyle = 0;
        public bool isDoc = false;
        public bool isDefaultOpen = false;
        public bool isCloseBtn = true;
        
    }

    public class AppInfo
    {
        public int idx = 0;
        public IntPtr hWnd = IntPtr.Zero;
        public int pID = 0;
        public string Name = "";
        public Bitmap Capture = null;
    }
 
}
