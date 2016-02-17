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

        private const int Guying_HTLEFT = 10;
        private const int Guying_HTRIGHT = 11;
        private const int Guying_HTTOP = 12;
        private const int Guying_HTTOPLEFT = 13;
        private const int Guying_HTTOPRIGHT = 14;
        private const int Guying_HTBOTTOM = 15;
        private const int Guying_HTBOTTOMLEFT = 0x10;
        private const int Guying_HTBOTTOMRIGHT = 17;

        #endregion

        #region  WIN32API

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
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
            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMLEFT;
                        else
                            m.Result = (IntPtr)Guying_HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMRIGHT;
                        else
                            m.Result = (IntPtr)Guying_HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)Guying_HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)Guying_HTBOTTOM;
                    break;
                case 0x0201://鼠标左键按下的消息
                    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标
                    m.LParam = IntPtr.Zero; //默认值
                    m.WParam = new IntPtr(2);//鼠标放在标题栏内
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

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
        /// 移动窗体（在允许点击按钮移动窗体的控件上调用此方法）
        /// </summary>
        protected void MoveForm()
        {
            if (this.WindowState.Equals(FormWindowState.Maximized))
                return;

            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
