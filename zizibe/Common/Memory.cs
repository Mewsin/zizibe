using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zizibe.Common
{
    public static class Memory
    {
        private static Dictionary<int, AppInfo> _dicAppinfo = new Dictionary<int, AppInfo>();
        public static Dictionary<int, AppInfo> Appinfo { get { return _dicAppinfo; } }

        public static Process[] pRocess { get; set; }
    }
}
