
namespace zizibe.Form
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnConnect = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDisconnect = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnStart = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnHuntingStart = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnStop = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTelegram = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLog = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bbtnConnect,
            this.bbtnDisconnect,
            this.bbtnStart,
            this.bbtnHuntingStart,
            this.bbtnStop,
            this.bbtnSetting,
            this.bbtnTelegram,
            this.barButtonItem1,
            this.bbtnLog});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(926, 151);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbtnConnect
            // 
            this.bbtnConnect.Caption = "Connect";
            this.bbtnConnect.Id = 2;
            this.bbtnConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnConnect.ImageOptions.Image")));
            this.bbtnConnect.Name = "bbtnConnect";
            this.bbtnConnect.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnConnect.Tag = "Connect";
            this.bbtnConnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnConnect_ItemClick);
            // 
            // bbtnDisconnect
            // 
            this.bbtnDisconnect.Caption = "Disconnect";
            this.bbtnDisconnect.Enabled = false;
            this.bbtnDisconnect.Id = 3;
            this.bbtnDisconnect.ImageOptions.Image = global::zizibe.Properties.Resources.disconnect;
            this.bbtnDisconnect.Name = "bbtnDisconnect";
            this.bbtnDisconnect.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbtnStart
            // 
            this.bbtnStart.Caption = "Start";
            this.bbtnStart.Enabled = false;
            this.bbtnStart.Id = 4;
            this.bbtnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnStart.ImageOptions.Image")));
            this.bbtnStart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnStart.ImageOptions.LargeImage")));
            this.bbtnStart.Name = "bbtnStart";
            this.bbtnStart.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbtnHuntingStart
            // 
            this.bbtnHuntingStart.Caption = "HuntingStart";
            this.bbtnHuntingStart.Enabled = false;
            this.bbtnHuntingStart.Id = 5;
            this.bbtnHuntingStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnHuntingStart.ImageOptions.Image")));
            this.bbtnHuntingStart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnHuntingStart.ImageOptions.LargeImage")));
            this.bbtnHuntingStart.Name = "bbtnHuntingStart";
            this.bbtnHuntingStart.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbtnStop
            // 
            this.bbtnStop.Caption = "Stop";
            this.bbtnStop.Enabled = false;
            this.bbtnStop.Id = 6;
            this.bbtnStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnStop.ImageOptions.Image")));
            this.bbtnStop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnStop.ImageOptions.LargeImage")));
            this.bbtnStop.Name = "bbtnStop";
            // 
            // bbtnSetting
            // 
            this.bbtnSetting.Caption = "Setting";
            this.bbtnSetting.Id = 7;
            this.bbtnSetting.ImageOptions.Image = global::zizibe.Properties.Resources.settings;
            this.bbtnSetting.Name = "bbtnSetting";
            this.bbtnSetting.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // bbtnTelegram
            // 
            this.bbtnTelegram.Caption = "Telegram Setting";
            this.bbtnTelegram.Id = 8;
            this.bbtnTelegram.ImageOptions.Image = global::zizibe.Properties.Resources.telegram1;
            this.bbtnTelegram.Name = "bbtnTelegram";
            this.bbtnTelegram.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Monitoring(HP/MP)";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = global::zizibe.Properties.Resources.monitoring;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbtnLog
            // 
            this.bbtnLog.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bbtnLog.Caption = "Log";
            this.bbtnLog.Id = 10;
            this.bbtnLog.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnLog.ImageOptions.SvgImage")));
            this.bbtnLog.Name = "bbtnLog";
            this.bbtnLog.Tag = "Log";
            this.bbtnLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnLog_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Mewsin";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnConnect);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnDisconnect);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnStart);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnHuntingStart);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnStop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnSetting);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnTelegram);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnLog);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 757);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(926, 23);
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            this.dockManager.ClosingPanel += new DevExpress.XtraBars.Docking.DockPanelCancelEventHandler(this.dockManager_ClosingPanel);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.ribbon;
            this.documentManager.View = this.tabbedView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 780);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbtnConnect;
        private DevExpress.XtraBars.BarButtonItem bbtnDisconnect;
        private DevExpress.XtraBars.BarButtonItem bbtnStart;
        private DevExpress.XtraBars.BarButtonItem bbtnHuntingStart;
        private DevExpress.XtraBars.BarButtonItem bbtnStop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbtnSetting;
        private DevExpress.XtraBars.BarButtonItem bbtnTelegram;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbtnLog;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}