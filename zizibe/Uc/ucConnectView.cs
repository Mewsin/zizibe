using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zizibe.Common;
using zizibe.Work;

namespace zizibe.Uc
{
    public partial class ucConnectView : DevExpress.XtraEditors.XtraUserControl
    {
        public static event EventHandler<LogEventArgs> OnLog;

        public AppInfo _info = new AppInfo();
        public int idx { get; set; }
        public IntPtr hWnd { get; set; }

        private bool _isConnect = false;
        public bool isConnect { get { return _isConnect; } }
        public ucConnectView()
        {
            InitializeComponent();
        }

        private void OnCapture(object sender, CaptureEventArgs e)
        {
            picView.Invoke((MethodInvoker)(() =>
            {
                picView.Image = e.Bmp;
            }));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text.Equals("Connect"))
            {
                btnConnect.Text = "DisConnect";
                Log(string.Format("<color=purple><b>[{0}]</b></color> 연결 완료", _info.Name));
                ConnectedState(lblConnectState, true);

                _info.idx = idx;
                _info.hWnd = hWnd;

            }
            else
            {
                btnConnect.Text = "Connect";
                Log(string.Format("<color=purple><b>[{0}]</b></color> 연결 해제", _info.Name));
                ConnectedState(lblConnectState, false);
            }
            //MessageBox.Show(Appinfo.hWnd.ToString()) ;
        }
        
        private void ConnectedState(LabelControl lbl, bool state)
        {
            lbl.Invoke((MethodInvoker)(() =>
            {
                if (state)
                {
                    lbl.BackColor = Color.Lime;
                    lbl.ForeColor = Color.Black;
                    lbl.Text = "Connected";
                    _isConnect = true;
                    Memory.Appinfo.Add(idx, _info);
                }
                else
                {
                    lbl.BackColor = Color.Red;
                    lbl.ForeColor = Color.White;
                    lbl.Text = "Not Connected";
                    _isConnect = false;
                    Memory.Appinfo.Remove(idx);
                }
            }));
        }
        private void Log(string log)
        {
            OnLog?.Invoke(this, new LogEventArgs(log));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isConnect)
            {
                _info = new AppInfo();
                _info.idx = idx;
                _info.hWnd = hWnd;
                _info.OnCapture += OnCapture;

                _info.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            _info.OnCapture -= OnCapture;
            _info.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
