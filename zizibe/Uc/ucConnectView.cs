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
        public Settings _Setting;

        public int idx { get; set; }
        public IntPtr hWnd { get; set; }
        public string Name { get; set; }

        private bool _isConnect = false;
        public bool isConnect { get { return _isConnect; } }
        public ucConnectView()
        {
            InitializeComponent();

        }
        private void ucConnectView_Load(object sender, EventArgs e)
        {
            _Setting = new Settings(Name);
        }

        private void OnCapture(object sender, CaptureEventArgs e)
        {
            Task t = new Task(() =>
            {
                picView.Invoke((MethodInvoker)(() =>
                {
                    picView.Image = e.Bmp;
                }));
            });
            t.Start();
        }
        private void SetBtnEnabled(SimpleButton btn, bool state)
        {
            btn.Invoke((MethodInvoker)(() =>
            {
                btn.Enabled = state;
            }));
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


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text.Equals("Connect"))
            {
                btnConnect.Text = "DisConnect";
                Log(string.Format("<color=purple><b>[{0}]</b></color> 연결 완료", _info.Name));

                ConnectedState(lblConnectState, true);

                SetBtnEnabled(btnStart, true);
                SetBtnEnabled(btnNowStart, true);
                SetBtnEnabled(btnStop, false);

                _info.idx = idx;
                _info.hWnd = hWnd;
                _info.Name = Name;

            }
            else
            {
                btnConnect.Text = "Connect";
                Log(string.Format("<color=purple><b>[{0}]</b></color> 연결 해제", _info.Name));
                
                btnStop_Click(sender, e);

                ConnectedState(lblConnectState, false);

                SetBtnEnabled(btnStart, false);
                SetBtnEnabled(btnNowStart, false);
                SetBtnEnabled(btnStop, false);

            }
            //MessageBox.Show(Appinfo.hWnd.ToString()) ;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isConnect)
            {
                _info = new AppInfo();
                _info.idx = idx;
                _info.hWnd = hWnd;
                _info.Name = Name;
                _info.Setting = _Setting; // 세팅 정보를 담음

                _info.OnCapture += OnCapture;

                _info.Start();

                SetBtnEnabled(btnStart, false);
                SetBtnEnabled(btnNowStart, false);
                SetBtnEnabled(btnStop, true);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            _info.OnCapture -= OnCapture;
            _info.Stop();
            
            SetBtnEnabled(btnStart, true);
            SetBtnEnabled(btnNowStart, true);
            SetBtnEnabled(btnStop, false);
        }

        private void btnNowStart_Click(object sender, EventArgs e)
        {
            Controller.TEST(hWnd, 85, 220);
        }
    }
}
