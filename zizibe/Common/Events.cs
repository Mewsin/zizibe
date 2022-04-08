using System;
using System.Collections.Generic;
using System.Drawing;
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
    public class CaptureEventArgs : EventArgs
    {
        private Bitmap _bmp;
        public Bitmap Bmp { get { return _bmp; } }
        public CaptureEventArgs(Bitmap bmp)
        {
            _bmp = bmp;
        }
    }
}
