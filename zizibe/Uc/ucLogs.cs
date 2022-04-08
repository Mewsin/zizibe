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
using zizibe.Form;
using zizibe.Work;

namespace zizibe.Uc
{
    public partial class ucLogs : DevExpress.XtraEditors.XtraUserControl
    {
        public ucLogs()
        {
            InitializeComponent();
            
        }

        private void Init()
        {
            frmMain.OnLog += Log;
            ucConnectView.OnLog += Log;
            AppInfo.OnLog += Log;
        }

        private void Log(object sender, Common.LogEventArgs e)
        {
            lstLog.Invoke((MethodInvoker)(() =>
            {
                string str = string.Format("[{0}] {1}", DateTime.Now.ToString("HH:mm:ss.fff"), e.Log);
                lstLog.Items.Insert(0, str);
                lstLog.SelectedIndex = -1;
            }));
        }

        private void ucLogs_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
