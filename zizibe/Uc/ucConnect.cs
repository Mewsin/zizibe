using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zizibe.Common;

namespace zizibe.Uc
{
    public partial class ucConnect : DevExpress.XtraEditors.XtraUserControl
    {
        private List<AppInfo> _lstAppinfo = new List<AppInfo>();
        public ucConnect()
        {
            InitializeComponent();
            GetProcessList();
        }

        private void GetProcessList()
        {
            //lst.Items.Clear();
            //_lstAppinfo.Clear();

            var process = Process.GetProcessesByName("LineageM");
            if (process.Length == 0)
            {
                return;
            }

            Memory.pRocess = process;
            int idx = 0;
            foreach (var item in process)
            {
                AppInfo info = new AppInfo();
                info.idx = idx;
                info.Name = item.MainWindowTitle;
                info.hWnd = item.MainWindowHandle;
                info.pID = item.Id;
                _lstAppinfo.Add(info);
                lst.Items.Add(string.Format("{0} | {1}", info.Name, info.pID));
            }
        }

        private void LayoutSplit(TableLayoutPanel tp, int count)
        {
            tp.Controls.Clear();
            tp.ColumnCount = 3;

            for (int i = 1; i <= count; i++)
            {
                tp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                double value = (double)count / i;

                if (count > 1)
                {
                    tp.ColumnCount = count;
                    tp.RowCount = (int)Math.Round(value, 0);
                    break;
                }
            }

            if (count > 0)
            {
            }
        }
    }
}
