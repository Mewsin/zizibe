using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zizibe.Common
{
    public class LogEventArgs : EventArgs
    {
        private string _log;
        public string Log { get { return _log; } }
        public LogEventArgs(string log)
        {
            _log = log;
        }
    }
}
