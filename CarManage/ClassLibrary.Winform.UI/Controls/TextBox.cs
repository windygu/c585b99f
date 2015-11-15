using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class TextBox : System.Windows.Forms.TextBox
    {
        private Regex regex;

        private TextMode textMode;

        /// <summary>
        /// 输入类型
        /// </summary>
        public TextMode TextMode
        {
            get { return textMode; }

            set
            {
                textMode = value;

                if (textMode.Equals(TextMode.Numeric))
                    regex = new Regex(GetExpression());
            }
        }

        private decimal minValue;

        /// <summary>
        /// 最小值（仅当输入类型为非字符串时有效）
        /// </summary>
        public decimal MinValue
        {
            get { return minValue; }

            set
            {
                minValue = value;
                regex = new Regex(GetExpression());
            }
        }

        private decimal maxValue;

        /// <summary>
        /// 最大值（仅当输入类型为非字符串时有效）
        /// </summary>
        public decimal MaxValue
        {
            get { return maxValue; }

            set
            {
                maxValue = value;
                regex = new Regex(GetExpression());
            }
        }

        private int decimalPrecision;

        /// <summary>
        /// 小数精度（仅当输入类型为Numeric时有效）
        /// </summary>
        public int DecimalPrecision
        {
            get { return decimalPrecision; }

            set
            {
                decimalPrecision = value;

                regex = new Regex(GetExpression());
            }
        }

        public TextBox()
        {
            InitializeComponent();

            BorderColor = Color.FromArgb(226, 226, 226);
            BorderWidth = 1;
            this.BorderStyle = BorderStyle.FixedSingle;

            InitControl();
        }

        public TextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            BorderColor = Color.FromArgb(226, 226, 226);
            BorderWidth = 1;
            this.BorderStyle = BorderStyle.FixedSingle;

            InitControl();
        }

        private void InitControl()
        {
            textMode = TextMode.String;

            minValue = 0;
            maxValue = int.MaxValue;
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

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 22)
                return;

            if (textMode.Equals(TextMode.Numeric))
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) &&
                    e.KeyChar != 45 && e.KeyChar != 46)
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == 45)
                {
                    if (minValue >= 0 || this.SelectionStart > 0 ||
                        this.Text.Trim().StartsWith("-"))
                    {
                        e.Handled = true;
                    }

                    return;
                }

                if (e.KeyChar == 46 && this.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                if (decimalPrecision > 0)
                {
                    int index = this.Text.IndexOf('.');

                    if (index > -1 && this.SelectionStart > index)
                    {
                        if (this.Text.Length - 1 - index >= decimalPrecision)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            else if (textMode.Equals(TextMode.Integer))
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 45)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == 45)
                {
                    if (minValue >= 0 || this.SelectionStart > 0 ||
                        this.Text.Trim().StartsWith("-"))
                    {
                        e.Handled = true;
                    }

                    return;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (textMode.Equals(TextMode.Integer) ||
                textMode.Equals(TextMode.Numeric))
            {
                decimal result = 0;

                if (!decimal.TryParse(this.Text.Trim(), out result))
                {
                    this.Text = string.Empty;
                    return;
                }

                this.Text = result.ToString();

                if (!regex.IsMatch(this.Text))
                    this.Text = string.Empty;

                if (result < minValue)
                {
                    this.Text = minValue.ToString();
                    this.SelectionStart = this.Text.Length;
                }

                if (result > maxValue)
                {
                    this.Text = maxValue.ToString();
                    this.SelectionStart = this.Text.Length;
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (textMode.Equals(TextMode.Numeric) ||
                textMode.Equals(TextMode.Integer))
            {
                string input = this.Text.Trim();

                if (string.IsNullOrEmpty(input) || input.Equals("-") || input.Equals("."))
                    return;

                decimal value = 0;

                if (!decimal.TryParse(this.Text.Trim(), out value))
                {
                    this.Text = string.Empty;
                    return;
                }

                //if (value < minValue)
                //{
                //    this.Text = minValue.ToString();
                //    this.SelectionStart = this.Text.Length;
                //}

                if (value > maxValue)
                {
                    this.Text = maxValue.ToString();
                    this.SelectionStart = this.Text.Length;
                }

            }
        }

        private string GetExpression()
        {
            string expression = string.Empty;

            if (textMode.Equals(TextMode.Numeric))
            {
                expression = "^";

                if (minValue < 0)
                {
                    expression += "\\-?";
                }

                expression += "[0-9]+";

                if (decimalPrecision > 0)
                    expression += "(.[0-9]{0," + decimalPrecision + "})?";
                else
                {
                    expression = "^(-?\\d+)(\\.\\d+)?";
                }

                expression += "$";
            }
            else if (textMode.Equals(TextMode.Integer))
            {
                expression = "^";

                if (minValue < 0)
                {
                    expression += "\\-?";
                }

                expression += "[0-9]*$";
            }

            return expression;
        }
    }

    public enum TextMode
    {
        String,
        Integer,
        Numeric
    }
}
