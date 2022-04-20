using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using zizibe.Common;

namespace zizibe.Work
{
    public class AppInfo : Function
    {
        public event EventHandler<CaptureEventArgs> OnCapture;
        public static event EventHandler<LogEventArgs> OnLog;

        public int idx = 0;
        public IntPtr hWnd = IntPtr.Zero;
        public int pID = 0;
        public string Name = "";

        private static readonly object BitmapLock = new object();
        private static Bitmap _snapshot;

        private Thread _thread = null;
        private bool _isRun = false;
        public bool isRun { get { return _isRun; } }

        public static Bitmap Capture
        {
            get
            {
                lock (BitmapLock)
                    return new Bitmap(_snapshot);
            }
            set
            {
                Bitmap oldSnapshot;
                Bitmap newSnapshot = new Bitmap(value, value.Width, value.Height);
                lock (BitmapLock)
                {
                    oldSnapshot = _snapshot;
                    _snapshot = newSnapshot;
                    if (oldSnapshot != null)
                    {
                        oldSnapshot.Dispose();
                    }
                }
            }
        }
        private void Log(string log)
        {
            string str = string.Format("[{0}] {1}", Name, log);
            OnLog?.Invoke(this, new LogEventArgs(idx.ToString()));
        }

        public void Start()
        {
            if (!_isRun)
            {
                _thread = new Thread(new ThreadStart(Run));
                _isRun = true;
                _thread.Start();
            }
        }

        public void Stop()
        {
            if (_isRun)
            {
                _thread.Abort();
                _isRun = false;
            }
        }

        private void Run()
        {
            while (_isRun)
            {
                Bitmap b = setCapture(hWnd);
                OnCapture?.Invoke(this, new CaptureEventArgs(b));
                Log(idx.ToString());
                Thread.Sleep(100);
            }
        }
    }
}
