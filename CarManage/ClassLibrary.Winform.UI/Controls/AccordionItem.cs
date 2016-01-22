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

        private Color normalBackColor;

        /// <summary>
        /// 背景色
        /// </summary>
        [Description("背景色")]
        public Color NormalBackColor
        {
            get { return normalBackColor; }

            set 
            {
                normalBackColor = value;

                if (this.Status.Equals(SelectionStatus.Normal))
                    this.BackColor = normalBackColor;
            }
        }

        private Color hoverBackColor;

        /// <summary>
        /// 悬浮背景色
        /// </summary>
        [Description("悬浮背景色")]
        public Color HoverBackColor
        {
            get { return hoverBackColor; }

            set
            {
                hoverBackColor = value;

                if (this.Status.Equals(SelectionStatus.Hover))
                    this.BackColor = hoverBackColor;
            }
        }

        private Color activeBackColor;

        /// <summary>
        /// 选中项背景色
        /// </summary>
        [Description("选中项背景色")]
        public Color ActiveBackColor
        {
            get { return activeBackColor; }

            set
            {
                activeBackColor = value;

                if (this.Status.Equals(SelectionStatus.Selected))
                    this.BackColor = activeBackColor;
            }
        }

        private Color normalForeColor;

        /// <summary>
        /// 前景色
        /// </summary>
        [Description("前景色")]
        public Color NormalForeColor
        {
            get { return normalForeColor; }

            set
            {
                normalForeColor = value;

                if (this.Status.Equals(SelectionStatus.Normal))
                    lblText.ForeColor = normalForeColor;
            }
        }

        private Color hoverForeColor;

        /// <summary>
        /// 悬浮项前景色
        /// </summary>
        [Description("悬浮项前景色")]
        public Color HoverForeColor
        {
            get { return hoverForeColor; }

            set
            {
                hoverForeColor = value;

                if (this.Status.Equals(SelectionStatus.Hover))
                    lblText.ForeColor = hoverForeColor;
            }
        }

        private Color activeForeColor;

        /// <summary>
        /// 选中项前景色
        /// </summary>
        [Description("选中项前景色")]
        public Color ActiveForeColor
        {
            get { return activeForeColor; }

            set
            {
                activeForeColor = value;

                if (this.Status.Equals(SelectionStatus.Selected))
                    lblText.ForeColor = activeForeColor;
            }
        }

        private Image normalBackgroundImage;

        /// <summary>
        /// 背景图
        /// </summary>
        [Description("背景图")]
        public Image NormalBackgroundImage
        {
            get { return normalBackgroundImage; }

            set
            {
                normalBackgroundImage = value;

                if (this.Status.Equals(SelectionStatus.Normal))
                    this.BackgroundImage = normalBackgroundImage;
            }
        }

        private Image hoverBackgroundImage;

        /// <summary>
        /// 选中项背景图
        /// </summary>
        [Description("选中项背景图")]
        public Image HoverBackgroundImage
        {
            get { return hoverBackgroundImage; }

            set
            {
                hoverBackgroundImage = value;

                if (this.Status.Equals(SelectionStatus.Hover))
                    this.BackgroundImage = hoverBackgroundImage;
            }
        }

        private Image activeBackgroundImage;

        /// <summary>
        /// 悬浮项背景图
        /// </summary>
        [Description("悬浮项背景图")]
        public Image ActiveBackgroundImage
        {
            get { return activeBackgroundImage; }

            set
            {
                activeBackgroundImage = value;

                if (this.Status.Equals(SelectionStatus.Selected))
                    this.BackgroundImage = activeBackgroundImage;
            }
        }

        /// <summary>
        /// 当前控件是否为选中项
        /// </summary>
        [Description("当前控件是否为选中项")]
        internal SelectionStatus Status { get; set; }

        /// <summary>
        /// Item项索引序号
        /// </summary>
        internal int ItemIndex { get; set; }

        /// <summary>
        /// 当前选中控件时引发的事件
        /// </summary>
        [Description("当前选中控件时引发的事件")]
        public event EventHandler<EventArgs> OnSelected;

        public AccordionItem()
        {
            InitializeComponent();

            InitControl();
        }

        private void InitControl()
        {
            Icon = null;
            BorderColor = Color.Empty;

            normalBackColor = Color.Empty;
            hoverBackColor = Color.Empty;
            activeBackColor = Color.Empty;

            normalForeColor = SystemColors.ControlText;
            hoverForeColor = SystemColors.ControlText;
            activeForeColor = SystemColors.ControlText;

            normalBackgroundImage = null;
            hoverBackgroundImage = null;
            activeBackgroundImage = null;

            Status = SelectionStatus.Normal;
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

        private void AccordionItem_MouseEnter(object sender, EventArgs e)
        {
            if (this.Status.Equals(SelectionStatus.Selected))
                return;

            this.Status = SelectionStatus.Hover;
            SetStyle();
        }

        private void pbxImage_MouseEnter(object sender, EventArgs e)
        {
            if (this.Status.Equals(SelectionStatus.Selected))
                return;

            this.Status = SelectionStatus.Hover;
            SetStyle();
        }

        private void lblText_MouseEnter(object sender, EventArgs e)
        {
            if (this.Status.Equals(SelectionStatus.Selected))
                return;

            this.Status = SelectionStatus.Hover;
            SetStyle();
        }

        internal void SetStyle()
        {
            if (this.Status.Equals(SelectionStatus.Hover))
            {
                if (hoverBackgroundImage != null)
                {
                    this.BackgroundImage = hoverBackgroundImage;
                }
                else if (HoverBackColor != null && !HoverBackColor.Equals(Color.Empty))
                {
                    this.BackColor = HoverBackColor;
                }

                if (hoverForeColor != null && !hoverForeColor.Equals(Color.Empty))
                {
                    lblText.ForeColor = hoverForeColor;
                }
            }
            else if (this.Status.Equals(SelectionStatus.Normal))
            {
                if (normalBackgroundImage != null)
                {
                    this.BackgroundImage = normalBackgroundImage;
                }
                else if (normalBackColor != null && !normalBackColor.Equals(Color.Empty))
                {
                    this.BackColor = normalBackColor;
                }
                else
                {
                    this.BackgroundImage = null;
                    this.BackColor = Color.Empty;
                }

                if (normalForeColor != null && !normalForeColor.Equals(Color.Empty))
                {
                    lblText.ForeColor = normalForeColor;
                }
                else
                {
                    lblText.ForeColor = SystemColors.ControlText;
                }
            }
            else if (this.Status.Equals(SelectionStatus.Selected))
            {
                if (activeBackgroundImage != null)
                {
                    this.BackgroundImage = activeBackgroundImage;
                }
                else if (activeBackColor != null && !activeBackColor.Equals(Color.Empty))
                {
                    this.BackColor = activeBackColor;
                }
                else
                {
                    this.BackColor = normalBackColor;
                    this.BackgroundImage = normalBackgroundImage;                   
                }

                if (activeForeColor != null && !activeForeColor.Equals(Color.Empty))
                {
                    lblText.ForeColor = activeForeColor;
                }
                else
                {
                    lblText.ForeColor = normalForeColor;
                }

                if (OnSelected != null)
                    OnSelected(this, new EventArgs());
            }
        }

        private void pbxImage_MouseLeave(object sender, EventArgs e)
        {
            if (this.Status.Equals(SelectionStatus.Selected))
                return;

            this.Status = SelectionStatus.Normal;
            SetStyle();
        }

        private void lblText_MouseLeave(object sender, EventArgs e)
        {
            if (this.Status.Equals(SelectionStatus.Selected))
                return;

            this.Status = SelectionStatus.Normal;
            SetStyle();
        }

        private void AccordionItem_MouseLeave(object sender, EventArgs e)
        {
            if (this.Status.Equals(SelectionStatus.Selected))
                return;

            this.Status = SelectionStatus.Normal;
            SetStyle();
        }

        private void pbxImage_Click(object sender, EventArgs e)
        {
            this.Status = SelectionStatus.Selected;
            SetStyle();
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            this.Status = SelectionStatus.Selected;
            SetStyle();
        }

        private void AccordionItem_Click(object sender, EventArgs e)
        {
            this.Status = SelectionStatus.Selected;
            SetStyle();
        }
    }

    internal enum SelectionStatus
    {
        Normal,
        Hover,
        Selected
    }
}
