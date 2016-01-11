using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class AccordionItem : UserControl
    {
        /// <summary>
        /// 显示文本
        /// </summary>
        [Description("显示文本")]
        public string ItemText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        /// <summary>
        /// 图标
        /// </summary>
        [Description("图标")]
        public Image Icon
        {
            get { return pbxImage.Image; }
            set 
            { 
                pbxImage.Image = value;
                pbxImage.Visible = pbxImage.Image != null;
            }
        }

        /// <summary>
        /// 显示文本的Padding
        /// </summary>
        [Description("显示文本的Padding")]
        public Padding TextPadding
        {
            get { return lblText.Padding; }
            set { lblText.Padding = value; }
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        [Description("边框颜色")]
        public Color BorderColor { get; set; }

        /// <summary>
        /// 背景色
        /// </summary>
        [Description("背景色")]
        public Color NormalBackColor { get; set; }

        /// <summary>
        /// 悬浮背景色
        /// </summary>
        [Description("悬浮背景色")]
        public Color HoverBackColor { get; set; }

        /// <summary>
        /// 选中项背景色
        /// </summary>
        [Description("选中项背景色")]
        public Color ActiveBackColor { get; set; }

        /// <summary>
        /// 前景色
        /// </summary>
        [Description("前景色")]
        public Color NormalForeColor { get; set; }

        /// <summary>
        /// 悬浮项前景色
        /// </summary>
        [Description("悬浮项前景色")]
        public Color HoverForeColor { get; set; }

        /// <summary>
        /// 选中项前景色
        /// </summary>
        [Description("选中项前景色")]
        public Color ActiveForeColor { get; set; }

        /// <summary>
        /// 背景图
        /// </summary>
        [Description("背景图")]
        public Image NormalBackgroundImage { get; set; }

        /// <summary>
        /// 选中项背景图
        /// </summary>
        [Description("选中项背景图")]
        public Image HoverBackgroundImage { get; set; }

        /// <summary>
        /// 悬浮项背景图
        /// </summary>
        [Description("悬浮项背景图")]
        public Image ActiveBackgroundImage { get; set; }

        public AccordionItem()
        {
            InitializeComponent();

            InitControl();
        }

        private void InitControl()
        {
            Icon = null;
            BorderColor = Color.Empty;

            NormalBackColor = Color.Empty;
            HoverBackColor = Color.Empty;
            ActiveBackColor = Color.Empty;

            NormalForeColor = SystemColors.ControlText;
            HoverForeColor = SystemColors.ControlText;
            ActiveForeColor = SystemColors.ControlText;

            NormalBackgroundImage = null;
            HoverBackgroundImage = null;
            ActiveBackgroundImage = null;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (BorderColor != null && !BorderColor.Equals(Color.Empty))
            {
                using (Pen pen = new Pen(BorderColor))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }
}
