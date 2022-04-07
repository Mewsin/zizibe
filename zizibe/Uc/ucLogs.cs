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

namespace zizibe.Uc
{
    public partial class ucLogs : DevExpress.XtraEditors.XtraUserControl
    {
        public ucLogs()
        {
            InitializeComponent();
            frmMain.OnLog += FrmMain_OnLog;
        }

        private void FrmMain_OnLog(object sender, Common.LogEventArgs e)
        {
            string str = string.Format("[{0}] {1}", DateTime.Now.ToString("HH:mm:ss.fff"), e.Log);
            lstLog.Items.Insert(0, str);
            lstLog.SelectedIndex = -1;
        }
    }
}
