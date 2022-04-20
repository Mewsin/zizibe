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
using zizibe.Work;
//using zizibe.Form;

namespace zizibe.Uc
{
    public partial class ucConnect : DevExpress.XtraEditors.XtraUserControl
    {
        private List<AppInfo> _lstAppinfo = new List<AppInfo>();
        private System.Windows.Forms.Form frm;
        public ucConnect(System.Windows.Forms.Form onwer)
        {
            InitializeComponent();
            frm = onwer;
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

            lst.SelectedIndex = -1;
        }

        public void tblScreen(TableLayoutPanel tbl)
        {
            tbl.Controls.Clear();
            tbl.ColumnCount = 3;
            int paramCount = 3;
            // 파라미터 화면 표시 갯수 처리
            for (int i = 1; i <= 2; i++)
            {
                double value = (double)paramCount / (double)i;
                double value2 = (double)paramCount % (double)i;

                if (value <= i)
                {
                    tp.ColumnCount = i;
                    tp.RowCount = (int)Math.Round(value, 0);
                    break;
                }
            }

            foreach (ucConnectView item in Memory.ConnectControls.Values)
            {
                item.Dock = DockStyle.Fill;
                tp.Controls.Add(item);
            }

            if (tp.Controls.Count > 2)
            {
                panel1.AutoScrollPosition = new Point(0, tbl.Height);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (new CenterWinDialog(frm))
            {
                if (lst.SelectedIndex < 0)
                {
                    MessageBox.Show("추가 할 퍼플을 선택하세요");
                    return;
                }

                ucConnectView ucConnectView = new ucConnectView();
                ucConnectView.lblTitle.Text = _lstAppinfo[lst.SelectedIndex].Name;
                ucConnectView.idx = Memory.ConnectControls.Count;
                ucConnectView.btnDel.Click += BtnDel_Click;
                ucConnectView.btnDel.Tag = Memory.ConnectControls.Count;
                ucConnectView.hWnd = _lstAppinfo[lst.SelectedIndex].hWnd;
                ucConnectView.Name = _lstAppinfo[lst.SelectedIndex].Name;
                //ucConnectView.Appinfo = _lstAppinfo[lst.SelectedIndex];




                //if (Memory.ConnectControls.Count <= 3)
                //{
                //    foreach (var item in Memory.ConnectControls.Values)
                //    {
                //        if (item.lblTitle.Text == _lstAppinfo[lst.SelectedIndex].Name)
                //        {
                //            MessageBox.Show("이미 추가 된 플레이어 입니다.");
                //            return;
                //        }
                //    }
                //    Memory.ConnectControls.Add(Memory.ConnectControls.Count, ucConnectView);
                //    tblScreen(tp);
                //    lblList.Text = string.Format("추가 된 리스트 ( {0}개 )", Memory.ConnectControls.Count);
                //}
                //else
                //{
                //    MessageBox.Show("4개 이상 추가 할 수 없습니다.");
                //    return;
                //}

                Memory.ConnectControls.Add(Memory.ConnectControls.Count, ucConnectView);
                tblScreen(tp);
                lblList.Text = string.Format("추가 된 리스트 ( {0}개 )", Memory.ConnectControls.Count);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            //MessageBox.Show(btn.Tag.ToString());
            Memory.ConnectControls.Remove(int.Parse(btn.Tag.ToString()));
            tblScreen(tp);
            lblList.Text = string.Format("추가 된 리스트 ( {0}개 )", Memory.ConnectControls.Count);
        }
    }
}
