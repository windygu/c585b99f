using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class TextBox : System.Windows.Forms.TextBox
    {
        public TextBox()
        {
            InitializeComponent();

            BorderColor = Color.FromArgb(226, 226, 226);
            BorderWidth = 1;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public TextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            BorderColor = Color.FromArgb(226, 226, 226);
            BorderWidth = 1;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        public Color BorderColor { get; set; }

        /// <summary>
        /// 边框粗细（单位像素）
        /// </summary>
        public int BorderWidth { get; set; }

        #region textbox 红色边框 lzk

        /// <summary>   
        /// 获得当前进程，以便重绘控件   
        /// </summary>   
        /// <param name="hWnd"></param>   
        /// <returns></returns>   
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);


        /// <summary>   
        /// 获得操作系统消息   
        /// </summary>   
        /// <param name="m"></param>   
        protected override void WndProc(ref Message m)
        {

            base.WndProc(ref m);
            if (m.Msg == 0xf || m.Msg == 0x133)
            {
                //拦截系统消息，获得当前控件进程以便重绘。   
                //一些控件（如TextBox、Button等）是由系统进程绘制，重载OnPaint方法将不起作用.   
                //所有这里并没有使用重载OnPaint方法绘制TextBox边框。   
                //   
                //MSDN:重写 OnPaint 将禁止修改所有控件的外观。   
                //那些由 Windows 完成其所有绘图的控件（例如 Textbox）从不调用它们的 OnPaint 方法，   
                //因此将永远不会使用自定义代码。请参见您要修改的特定控件的文档，   
                //查看 OnPaint 方法是否可用。如果某个控件未将 OnPaint 作为成员方法列出，   
                //则您无法通过重写此方法改变其外观。   
                //   
                //MSDN:要了解可用的 Message.Msg、Message.LParam 和 Message.WParam 值，   
                //请参考位于 MSDN Library 中的 Platform SDK 文档参考。可在 Platform SDK（“Core SDK”一节）   
                //下载中包含的 windows.h 头文件中找到实际常数值，该文件也可在 MSDN 上找到。   
                IntPtr hDC = GetWindowDC(m.HWnd);
                if (hDC.ToInt32() == 0)
                {
                    return;
                }

                //只有在边框样式为FixedSingle时自定义边框样式才有效   
                if (this.BorderStyle == BorderStyle.FixedSingle)
                {
                    if (BorderColor == null || BorderWidth == null || BorderWidth <= 0)
                        return;

                    //边框Width为1个像素   
                    System.Drawing.Pen pen = new Pen(BorderColor, BorderWidth);

                    //绘制边框   
                    System.Drawing.Graphics g = Graphics.FromHdc(hDC);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                    pen.Dispose();
                }
                //返回结果   
                m.Result = IntPtr.Zero;
                //释放   
                ReleaseDC(m.HWnd, hDC);
            }
        }

        #endregion

    }
}
