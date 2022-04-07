using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zizibe.Uc;

namespace zizibe.Common
{
    public static class Memory
    {
        private static Dictionary<int, AppInfo> _dicAppinfo = new Dictionary<int, AppInfo>();
        public static Dictionary<int, AppInfo> Appinfo { get { return _dicAppinfo; } }

        private static Dictionary<int, ucConnectView> _dicCon = new Dictionary<int, ucConnectView>();
        public static Dictionary<int, ucConnectView> ConnectControls 
        { 
            get 
            { 
                return _dicCon; 
            } 
            set 
            { 
                _dicCon = value; 
            } 
        }
        public static Process[] pRocess { get; set; }
    }
}
