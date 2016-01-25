using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class Accordion : System.Windows.Forms.Panel
    {
        /// <summary>
        /// 显示文本的Padding
        /// </summary>
        [Description("显示文本的Padding")]
        public Padding TextPadding { get; set; }

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


        /// <summary>
        /// 当前选中控件时引发的事件
        /// </summary>
        [Description("当前选中控件时引发的事件")]
        public event EventHandler<EventArgs> OnSelectedIndexChanged;

        /// <summary>
        /// Item项集合
        /// </summary>
        private List<AccordionItem> Items { get; set; }


        private int selectedIndex;

        /// <summary>
        /// 选中项索引
        /// </summary>
        [Description("选中项索引")]
        public int SelectedIndex 
        {
            get
            {
                return selectedIndex;
            }

            set
            {
                if (selectedIndex == value)
                    return;

                if (selectedIndex >= 0)
                {
                    Items[selectedIndex].Status = SelectionStatus.Normal;
                    Items[selectedIndex].SetStyle();
                }

                selectedIndex = value;
                Items[selectedIndex].Status = SelectionStatus.Selected;
                Items[selectedIndex].SetStyle();

                if (OnSelectedIndexChanged != null)
                    OnSelectedIndexChanged(Items[selectedIndex], new EventArgs());
            }
        }

        /// <summary>
        /// Item项的高度
        /// </summary>
        [Description("Item项的高度")]
        public int ItemHeight { get; set; }

        /// <summary>
        /// Item项的外边距
        /// </summary>
        [Description("Item项的外边距")]
        public Padding ItemMargin { get; set; }


        private int x;
        private int y;

        public Accordion()
        {
            Items = new List<AccordionItem>();
            InitializeComponent();

            InitControl();
        }

        public Accordion(IContainer container)
        {
            Items = new List<AccordionItem>();
            container.Add(this);

            InitializeComponent();

            InitControl();
        }

        private void InitControl()
        {
            
            ItemHeight = 30;
            selectedIndex = -1;

            TextPadding = new Padding(0, 0, 0, 0);
            ItemMargin = new System.Windows.Forms.Padding(1, 1, 1, 1);

            x = ItemMargin.Left;
            y = ItemMargin.Top;

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

        public void AddItem(string itemText, Image icon = null)
        {
            AccordionItem item = new AccordionItem();
            item.ItemText = itemText;
            item.ItemIndex = Items.Count;

            if (icon != null)
                item.Icon = icon;

            item.TextPadding = new Padding(TextPadding.Left, TextPadding.Top, TextPadding.Right, TextPadding.Bottom);
            item.BorderColor = BorderColor;
            item.NormalBackColor = NormalBackColor;
            item.HoverBackColor = HoverBackColor;
            item.ActiveBackColor = ActiveBackColor;
            item.NormalForeColor = NormalForeColor;
            item.HoverForeColor = HoverForeColor;
            item.ActiveForeColor = ActiveForeColor;
            item.NormalBackgroundImage = NormalBackgroundImage;
            item.HoverBackgroundImage = HoverBackgroundImage;
            item.ActiveBackgroundImage = ActiveBackgroundImage;

            item.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            item.Height = ItemHeight;
            item.Width = this.Width - ItemMargin.Left - ItemMargin.Right;
            item.Location = new Point(ItemMargin.Left, y + ItemMargin.Top);

            y += item.Height + ItemMargin.Bottom;

            item.OnSelected += item_OnSelected;
            Items.Add(item);
            this.Controls.Add(item);
        }

        void item_OnSelected(object sender, EventArgs e)
        {
            AccordionItem item = sender as AccordionItem;

            if (item != null)
            {
                SelectedIndex = item.ItemIndex;
            }
        }
    }
}
