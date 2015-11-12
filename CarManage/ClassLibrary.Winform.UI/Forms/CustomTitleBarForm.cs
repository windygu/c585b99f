using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClassLibrary.Winform.UI.Forms
{
    public partial class CustomTitleBarForm : BaseForm
    {
        #region  WIN32常量

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        #endregion

        #region  WIN32API

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        //protected override void WndProc(ref Message Msg)
        //{
        //    if (Msg.Msg == FormUtil.WM_NCHITTEST)
        //    {
        //        //获取鼠标位置
        //        int nPosX = (Msg.LParam.ToInt32() & 65535);
        //        int nPosY = (Msg.LParam.ToInt32() >> 16);
        //        //右下角
        //        if (nPosX >= this.Right - 6 && nPosY >= this.Bottom - 6)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_BOTTOMRIGHT);
        //            return;
        //        }
        //        //左上角
        //        else if (nPosX <= this.Left + 6 && nPosY <= this.Top + 6)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_TOPLEFT);
        //            return;
        //        }
        //        //左下角
        //        else if (nPosX <= this.Left + 6 && nPosY >= this.Bottom - 6)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_BOTTOMLEFT);
        //            return;
        //        }
        //        //右上角
        //        else if (nPosX >= this.Right - 6 && nPosY <= this.Top + 6)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_TOPRIGHT);
        //            return;
        //        }
        //        else if (nPosX >= this.Right - 2)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_RIGHT);
        //            return;
        //        }
        //        else if (nPosY >= this.Bottom - 2)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_BOTTOM);
        //            return;
        //        }
        //        else if (nPosX <= this.Left + 2)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_LEFT);
        //            return;
        //        }
        //        else if (nPosY <= this.Top + 2)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_TOP);
        //            return;
        //        }
        //        else
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_CAPTION);
        //            return;
        //        }
        //    }

        //    base.WndProc(ref Msg);
        //}

        #endregion

        #region  事件

        /// <summary>
        /// 当窗体关闭时发生的事件
        /// </summary>
        public event EventHandler<FormClosingEventArgs> OnFormClosing;

        /// <summary>
        /// 当窗体关闭时的自定义事件
        /// </summary>
        public event EventHandler<EventArgs> OnFormClose;

        #endregion

        /// <summary>
        /// 窗体名称
        /// </summary>
        [Browsable(true), Description("菜单项图标")]
        public virtual string FormName { get; set; }

        /// <summary>
        /// 是否显示最大化按钮
        /// </summary>
        [Browsable(true), Description("最大化按钮")]
        public virtual bool IsMaximumSize { get; set; }

        /// <summary>
        /// 是否显示最小化按钮
        /// </summary>
        [Browsable(true), Description("最小化按钮")]
        public virtual bool IsMinimumSize { get; set; }

        public CustomTitleBarForm()
        {
            //解决最大化后铺满全屏的问题
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            InitializeComponent();

            IsMaximumSize = IsMinimumSize = false;
        }

        /// <summary>
        /// 移动窗体
        /// </summary>
        private void MoveForm()
        {
            if (this.WindowState.Equals(FormWindowState.Maximized))
                return;

            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
