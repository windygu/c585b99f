namespace CarManage.UI.Client.Common
{
    partial class MainForm
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tcMain = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabWindow();
            this.tpTask = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage();
            this.tpCustomer = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage();
            this.tpCallRecord = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage();
            this.tpRemind = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage();
            this.tpDistribute = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage();
            this.tpStatistics = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage();
            this.tpSettings = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 703);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1243, 43);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tcMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1243, 703);
            this.pnlMain.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpTask);
            this.tcMain.Controls.Add(this.tpCustomer);
            this.tcMain.Controls.Add(this.tpCallRecord);
            this.tcMain.Controls.Add(this.tpRemind);
            this.tcMain.Controls.Add(this.tpDistribute);
            this.tcMain.Controls.Add(this.tpStatistics);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.DefaultTabPageBorderStyle.Color = System.Drawing.SystemColors.ActiveBorder;
            this.tcMain.DefaultTabPageBorderStyle.Width = 1;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.RendererName = null;
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1243, 703);
            this.tcMain.TabContentSpacing = 1;
            this.tcMain.TabIndex = 1;
            this.tcMain.TabItemActiveBackColor = System.Drawing.Color.Empty;
            this.tcMain.TabItemActiveBorderStyle.Color = System.Drawing.SystemColors.ActiveBorder;
            this.tcMain.TabItemActiveBorderStyle.Width = 1;
            this.tcMain.TabItemActiveForeColor = System.Drawing.SystemColors.ControlText;
            this.tcMain.TabItemAreaBackColor = System.Drawing.Color.Empty;
            this.tcMain.TabItemAreaBackGroudImage = null;
            this.tcMain.TabItemAreaBorderStyle.Color = System.Drawing.Color.Empty;
            this.tcMain.TabItemAreaBorderStyle.Width = 1;
            this.tcMain.TabItemAreaMargin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.tcMain.TabItemBackColor = System.Drawing.Color.Empty;
            this.tcMain.TabItemBorderStyle.Color = System.Drawing.SystemColors.ActiveBorder;
            this.tcMain.TabItemBorderStyle.Width = 1;
            this.tcMain.TabItemDisabledBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tcMain.TabItemDisabledBorderStyle.Color = System.Drawing.SystemColors.InactiveBorder;
            this.tcMain.TabItemDisabledBorderStyle.Width = 1;
            this.tcMain.TabItemDisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.tcMain.TabItemFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcMain.TabItemForeColor = System.Drawing.SystemColors.ControlText;
            this.tcMain.TabItemHeight = 50;
            this.tcMain.TabItemHoverBackColor = System.Drawing.Color.Empty;
            this.tcMain.TabItemHoverBorderStyle.Color = System.Drawing.SystemColors.ActiveBorder;
            this.tcMain.TabItemHoverBorderStyle.Width = 1;
            this.tcMain.TabItemHoverForeColor = System.Drawing.SystemColors.ControlText;
            this.tcMain.TabItemLayout = ClassLibrary.Winform.UI.Controls.PluggableTabControl.TabItemLayout.Top;
            this.tcMain.TabItemSpacing = 10;
            this.tcMain.TabItemStyle = ClassLibrary.Winform.UI.Controls.PluggableTabControl.TabItemStyle.Text;
            this.tcMain.TabItemWidth = 80;
            this.tcMain.TabPageAreaBackColor = System.Drawing.Color.Empty;
            this.tcMain.TabPageAreaPadding = new System.Windows.Forms.Padding(0);
            this.tcMain.TabPageBottomBorderStyle.Color = System.Drawing.Color.Empty;
            this.tcMain.TabPageBottomBorderStyle.Width = 1;
            this.tcMain.TabPageLeftBorderStyle.Color = System.Drawing.Color.Empty;
            this.tcMain.TabPageLeftBorderStyle.Width = 1;
            this.tcMain.TabPageRightBorderStyle.Color = System.Drawing.Color.Empty;
            this.tcMain.TabPageRightBorderStyle.Width = 1;
            this.tcMain.TabPageTopBorderStyle.Color = System.Drawing.Color.Empty;
            this.tcMain.TabPageTopBorderStyle.Width = 1;
            this.tcMain.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // tpTask
            // 
            this.tpTask.BackColor = System.Drawing.Color.Transparent;
            this.tpTask.Name = "tpTask";
            this.tpTask.TabActiveImage = null;
            this.tpTask.TabDistabledImage = null;
            this.tpTask.TabHoverImage = null;
            this.tpTask.TabImage = null;
            this.tpTask.Text = "我的待办";
            this.tpTask.ToolTipText = "我的待办";
            // 
            // tpCustomer
            // 
            this.tpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.TabActiveImage = null;
            this.tpCustomer.TabDistabledImage = null;
            this.tpCustomer.TabHoverImage = null;
            this.tpCustomer.TabImage = null;
            this.tpCustomer.Text = "客户档案";
            this.tpCustomer.ToolTipText = "客户档案";
            // 
            // tpCallRecord
            // 
            this.tpCallRecord.BackColor = System.Drawing.Color.Transparent;
            this.tpCallRecord.Name = "tpCallRecord";
            this.tpCallRecord.TabActiveImage = null;
            this.tpCallRecord.TabDistabledImage = null;
            this.tpCallRecord.TabHoverImage = null;
            this.tpCallRecord.TabImage = null;
            this.tpCallRecord.Text = "电话记录";
            this.tpCallRecord.ToolTipText = "电话记录";
            // 
            // tpRemind
            // 
            this.tpRemind.BackColor = System.Drawing.Color.Transparent;
            this.tpRemind.Name = "tpRemind";
            this.tpRemind.TabActiveImage = null;
            this.tpRemind.TabDistabledImage = null;
            this.tpRemind.TabHoverImage = null;
            this.tpRemind.TabImage = null;
            this.tpRemind.Text = "备忘提醒";
            this.tpRemind.ToolTipText = "备忘提醒";
            // 
            // tpDistribute
            // 
            this.tpDistribute.BackColor = System.Drawing.Color.Transparent;
            this.tpDistribute.Name = "tpDistribute";
            this.tpDistribute.TabActiveImage = null;
            this.tpDistribute.TabDistabledImage = null;
            this.tpDistribute.TabHoverImage = null;
            this.tpDistribute.TabImage = null;
            this.tpDistribute.Text = "客户分配";
            this.tpDistribute.ToolTipText = "客户分配";
            // 
            // tpStatistics
            // 
            this.tpStatistics.BackColor = System.Drawing.Color.Transparent;
            this.tpStatistics.Name = "tpStatistics";
            this.tpStatistics.TabActiveImage = null;
            this.tpStatistics.TabDistabledImage = null;
            this.tpStatistics.TabHoverImage = null;
            this.tpStatistics.TabImage = null;
            this.tpStatistics.Text = "数据统计";
            this.tpStatistics.ToolTipText = "数据统计";
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.Color.Transparent;
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.TabActiveImage = null;
            this.tpSettings.TabDistabledImage = null;
            this.tpSettings.TabHoverImage = null;
            this.tpSettings.TabImage = null;
            this.tpSettings.Text = "系统设置";
            this.tpSettings.ToolTipText = "系统设置";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 746);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabWindow tcMain;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage tpTask;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage tpCustomer;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage tpCallRecord;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage tpRemind;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage tpDistribute;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage tpStatistics;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage tpSettings;


    }
}