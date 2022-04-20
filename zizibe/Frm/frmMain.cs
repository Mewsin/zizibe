using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zizibe.Common;
using zizibe.Uc;

namespace zizibe.Form
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static event EventHandler<LogEventArgs> OnLog;

        // 레이아웃을 저장하기 위한 xml 파일 경로
        private string _TabLayoutPath = Application.StartupPath + @"\MainLayout.xml";
        // 초기 생성 된 유저컨트롤을 담아 둘 딕셔너리
        private Dictionary<string, Tabs> _dicTabControls = new Dictionary<string, Tabs>();
        // 오픈 된 탭을 확인 하기 위한 리스트
        private List<string> _lstOpenTabCheck = new List<string>();

        public frmMain()
        {
            InitializeComponent();
            TabInit();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (new CenterWinDialog(this))
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Mewsin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TabLayoutSave();
                    e.Cancel = false;
                    // 완전히 종료
                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void TabInit()
        {
            string[] tabs = new string[]
            {
                "Telegram", "Log", "Connect"
            };

            foreach (string tabName in tabs)
            {
                Tabs t = new Tabs();
                t.Name = tabName;

                switch (tabName)
                {
                    case "Telegram":
                        ucTelegram ucTelegram = new ucTelegram();
                        t.ctr = ucTelegram;
                        t.dockStyle = DockingStyle.Fill;
                        t.isDoc = true;
                        break;
                    case "Log":
                        ucLogs ucLogs = new ucLogs();
                        t.ctr = ucLogs;
                        t.dockStyle = DockingStyle.Bottom;
                        t.isDoc = false;
                        break;
                    case "Connect":
                        ucConnect ucConnect = new ucConnect(this);
                        t.ctr = ucConnect;
                        t.dockStyle = DockingStyle.Fill;
                        t.isDoc = true;
                        break;
                    default:
                        break;
                }
                _dicTabControls.Add(tabName, t);
            }

            //레이아웃을 불러와서 패널을 띄운 뒤, 패널 속에 유저컨트롤 넣기
            TabLayoutLoad();
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                string controlName = dockManager.Panels[i].Text;
                if (dockManager.Panels[i].CanActivate)
                {
                    if (!_lstOpenTabCheck.Contains(controlName))
                    {
                        _lstOpenTabCheck.Add(controlName);
                        _dicTabControls[controlName].ctr.Dock = DockStyle.Fill;
                        //_dicTabControls[controlName].ctr.Name = controlName;
                        dockManager.Panels[i].Name = _dicTabControls[controlName].Name;
                        dockManager.Panels[i].Text = controlName;
                        dockManager.Panels[i].Controls.Add(_dicTabControls[controlName].ctr);
                    }
                }
            }
            Log("<color=orange><b>Program Start...</b></color>");
        }
        private void TabLayoutSave()
        {
            try
            {
                dockManager.SaveLayoutToXml(_TabLayoutPath);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Function : {0}, Error : {1}", "TabLayoutSave()", ex.ToString()));
            }
        }
        private void TabLayoutLoad()
        {
            try
            {
                if (File.Exists(_TabLayoutPath))
                {
                    dockManager.RestoreLayoutFromXml(_TabLayoutPath);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Function : {0}, Error : {1}", "TabLayoutLoad()", ex.ToString()));

            }
        }
        private void TabADD(string controlName)
        {
            // 이미 열려있는지 확인
            if (_lstOpenTabCheck.Contains(controlName))
            {
                for (int i = 0; i < dockManager.Panels.Count; i++)
                {
                    if (dockManager.Panels[i].Name.Equals(controlName))
                    {
                        dockManager.Panels[i].Select();
                    }
                }
                return;
            }
            else
            {
                _lstOpenTabCheck.Add(controlName);
            }

            Tabs t = _dicTabControls[controlName];
            SetDockPanel(t);
        }
        private void SetDockPanel(Tabs t)
        {
            DockPanel dPanel;
            dPanel = dockManager.AddPanel(t.dockStyle);
            _dicTabControls[t.Name].ctr.Dock = DockStyle.Fill;
            dPanel.Controls.Add(t.ctr);
            dPanel.DockedAsTabbedDocument = t.isDoc;
            dPanel.Options.ShowCloseButton = t.isCloseBtn;
            dPanel.Text = t.Name;
            dPanel.Name = _dicTabControls[t.Name].Name;
        }

        private void Log(string log)
        {
            OnLog?.Invoke(this, new LogEventArgs(log));
        }

        private void dockManager_ClosingPanel(object sender, DockPanelCancelEventArgs e)
        {
            if (_lstOpenTabCheck.Contains(e.Panel.Name.ToString()))
            {
                _lstOpenTabCheck.Remove(e.Panel.Name.ToString());
            }
        }
        private void bbtnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabADD(e.Item.Tag.ToString());
        }

        private void bbtnConnect_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabADD(e.Item.Tag.ToString());
        }
    }
}