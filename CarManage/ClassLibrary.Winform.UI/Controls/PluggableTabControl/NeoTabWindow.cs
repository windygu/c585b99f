﻿/*注意事项：
     * TabPage对象一定要在构造函数里初始化背景色，否则，只能显示第一个选项卡的边框颜色
     */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ClassLibrary.Winform.UI.Controls.PluggableTabControl
{
    [Designer(typeof(ClassLibrary.Winform.UI.Controls.PluggableTabControl.Design.NeoTabWindowDesigner))]
    [DefaultEvent("SelectedIndexChanged"), DefaultProperty("TabPages")]
    [ToolboxItem(typeof(ClassLibrary.Winform.UI.Controls.PluggableTabControl.Design.NeoTabWindowToolboxItem))]
    public class NeoTabWindow : Control, ISupportInitialize, ICloneable
    {
        #region Events

        /// <summary>
        /// Event raised when the current renderer is updated/edited.
        /// </summary>
        [Description("Event raised when the current renderer is updated/edited")]
        public event EventHandler RendererUpdated;

        /// <summary>
        /// Occurs when the value of the Renderer property changes.
        /// </summary>
        [Description("Occurs when the value of the Renderer property changes")]
        public event EventHandler RendererChanged;

        /// <summary>
        /// Occurs when the value of the SelectedIndex property changes.
        /// </summary>
        [Description("Occurs when the value of the SelectedIndex property changes")]
        public event EventHandler<SelectedIndexChangedEventArgs> SelectedIndexChanged;

        /// <summary>
        /// Occurs when a NeoTabPage control is being selected.
        /// </summary>
        [Description("Occurs when a NeoTabPage control is being selected")]
        public event EventHandler<SelectedIndexChangingEventArgs> SelectedIndexChanging;

        /// <summary>
        /// Event raised when a NeoTabPage control is removed from this control.
        /// </summary>
        [Description("Event raised when a NeoTabPage control is removed from this control")]
        public event EventHandler<TabPageRemovedEventArgs> TabPageRemoved;

        /// <summary>
        /// Occurs when a NeoTabPage control is being removed.
        /// </summary>
        [Description("Occurs when a NeoTabPage control is being removed")]
        public event EventHandler<TabPageRemovingEventArgs> TabPageRemoving;

        /// <summary>
        /// Event raised when the smart drop down button is clicked on the control.
        /// </summary>
        [Description("Event raised when the smart drop down button is clicked on the control")]
        public event EventHandler<DropDownButtonClickedEventArgs> DropDownButtonClicked;

        #endregion

        #region 枚举

        /// <summary>
        /// 拖拽效果（选项卡移动、页移动）
        /// </summary>
        public enum DragDropStyle
        {
            /// <summary>
            /// 页移动
            /// </summary>
            PageEffect,
            /// <summary>
            /// 选项卡移动
            /// </summary>
            TabPageItemEffect
        };

        #endregion

        #region Symbolic Constants

        /// <summary>
        /// TabControl默认尺寸
        /// </summary>
        protected static readonly Size DEFAULT_SIZE = new Size(300, 200);

        #endregion

        #region Static Members Of The Class

        private static int barMaxValue = 1;
        private static ToolTips myTooltipForm = null;
        private static DDPaintCursor myDdCursor = null;

        #endregion

        #region Instance Members

        /// <summary>
        /// 选中项索引
        /// </summary>
        private int selectedIndex = -1;

        /// <summary>
        /// 选项卡UI渲染对象
        /// </summary>
        private RendererBase renderer = null;
        private TooltipRenderer tooltipRenderer = null;
        private Point queueTooltipPoint = Point.Empty;

        /// <summary>
        /// 拖拽效果（选项卡移动、页移动）
        /// </summary>
        private DragDropStyle draggingStyle = DragDropStyle.TabPageItemEffect;

        /// <summary>
        /// 选项卡页集合
        /// </summary>
        private NeoTabPageControlCollection tabPages = null;

        /// <summary>
        /// 选项卡Tab位置和状态集合（此集合中保存每一个选项卡的位置以及Tab的状态）
        /// </summary>
        private Dictionary<Rectangle, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState> tpItemRectangles =
            new Dictionary<Rectangle, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState>();

        /// <summary>
        /// 选项卡Tab菜单位置和状态集合（包括一个存放所有Tab的ToolTrip菜单和关闭按钮的位置）
        /// </summary>
        private Dictionary<Rectangle, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState> smartButtonRectangles =
            new Dictionary<Rectangle, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState>(2);


        private NeoTabPageHidedMembersCollection hidedMembers =
            new NeoTabPageHidedMembersCollection();

        #endregion

        #region Constructor

        public NeoTabWindow()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint |
                 ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw,
                 true);

            renderer = new DefaultRenderer();
            renderer.TabControl = this;
            tooltipRenderer = new TooltipRenderer();

            InitStyles();
        }

        /// <summary>
        /// 初始化控件样式
        /// </summary>
        private void InitStyles()
        {
            TabItemLayout = TabItemLayout.Top;
            TabItemStyle = TabItemStyle.Text;
            TabContentSpacing = 1;
            TabItemSpacing = 0;
            
            TabItemWidth = 0;
            TabItemHeight = 0;

            this.TextImageRelation = TextImageRelation.Overlay;

            TabItemActiveBackColor = Color.Empty;
            TabItemActiveBorderStyle = new TabControlBorderStyle(SystemColors.ActiveBorder, 1);
            TabItemActiveForeColor = SystemColors.ControlText;

            TabItemAreaMargin = new Padding(0, 0, 0, 0);
            TabItemAreaBackColor = Color.Empty;
            TabItemAreaBackGroudImage = null;
            TabItemAreaBorderStyle = new TabControlBorderStyle(Color.Empty, 1);

            TabItemForeColor = SystemColors.ControlText;
            TabItemBackColor = Color.Empty;
            TabItemFont = this.Font;
            TabItemBorderStyle = new TabControlBorderStyle(SystemColors.ActiveBorder, 1);

            TabItemDisabledForeColor = SystemColors.GrayText;
            TabItemDisabledBackColor = SystemColors.InactiveBorder;
            TabItemDisabledBorderStyle = new TabControlBorderStyle(SystemColors.InactiveBorder, 1);

            TabItemHoverForeColor = SystemColors.ControlText;
            TabItemHoverBackColor = Color.Empty;
            TabItemHoverBorderStyle = new TabControlBorderStyle(SystemColors.ActiveBorder, 1);

            TabPageAreaPadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            TabPageAreaBackColor = Color.Empty;
            DefaultTabPageBorderStyle = new TabControlBorderStyle(SystemColors.ActiveBorder, 1);

            TabPageTopBorderStyle = new TabControlBorderStyle(Color.Empty, 1);

            TabPageRightBorderStyle = new TabControlBorderStyle(Color.Empty, 1);

            TabPageBottomBorderStyle = new TabControlBorderStyle(Color.Empty, 1);

            TabPageLeftBorderStyle = new TabControlBorderStyle(Color.Empty, 1);
        }

        #endregion

        #region Destructor

        ~NeoTabWindow()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 选项卡位置
        /// </summary>
        [Description("选项卡位置")]
        public TabItemLayout TabItemLayout { get; set; }

        /// <summary>
        /// 选项卡样式
        /// </summary>
        [Description("选项卡样式")]
        public TabItemStyle TabItemStyle { get; set; }

        /// <summary>
        /// 获取选中的Tab页
        /// </summary>
        [Browsable(false)]
        public NeoTabPage SelectedTab
        {
            get
            {
                if (selectedIndex != -1)
                    return TabPages[selectedIndex] as NeoTabPage;
                else
                    return null;
            }
        }

        /// <summary>
        /// 获取或设置选中项索引
        /// </summary>
        [Description("获取或设置选中项索引")]
        [DefaultValue(-1)]
        public int SelectedIndex
        {
            get { return selectedIndex; }

            set
            {
                if (!value.Equals(selectedIndex))
                {
                    // Check to see if there is an item at the supplied index.
                    if ((value >= TabPages.Count) || (value < 0))
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        selectedIndex = value;

                        if (!DesignMode)
                            CustomControlsLogic.SuspendLogic(Parent);

                        for (int i = 0; i < this.Controls.Count; i++)
                        {
                            NeoTabPage tp = TabPages[i] as NeoTabPage;
                            if (i == selectedIndex)
                            {
                                tp.ProgressUsedValue++;
                                tp.Visible = true;
                            }
                            else
                                tp.Visible = false;

                            barMaxValue = Math.Max(barMaxValue, tp.ProgressUsedValue);
                        }

                        if (initializing)
                        {
                            if (DesignMode)
                            {
                                ISelectionService selectionService =
                                    (ISelectionService)GetService(typeof(ISelectionService));
                                if (selectionService != null)
                                    selectionService.SetSelectedComponents(new IComponent[] { SelectedTab });
                            }
                            using (SelectedIndexChangedEventArgs e =
                                new SelectedIndexChangedEventArgs(TabPages[selectedIndex] as NeoTabPage, selectedIndex))
                            {
                                OnSelectedIndexChanged(e);
                            }
                        }

                        if (!DesignMode)
                            CustomControlsLogic.ResumeLogic(Parent);
                        else
                        {
                            Invalidate();
                            Update();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 获取或设置是否启用Tooltip，若启用，则当鼠标悬浮在Tab上时会显示Tooltip内容。
        /// </summary>
        [Description("获取或设置是否启用Tooltip，若启用，则当鼠标悬浮在Tab上时会显示Tooltip内容")]
        [DefaultValue(false)]
        [IsCloneable(true)]
        public bool TooltipEnabled { get; set; }

        /// <summary>
        /// 获取或设置Tab拖拽效果
        /// </summary>
        [Description("获取或设置Tab拖拽效果")]
        [DefaultValue(typeof(DragDropStyle), "TabPageItemEffect")]
        [IsCloneable(true)]
        public DragDropStyle DraggingStyle
        {
            get { return draggingStyle; }
            set
            {
                if (!value.Equals(draggingStyle))
                    draggingStyle = value;
            }
        }

        /// <summary>
        /// 获取或设置TabControl样式渲染对象名称
        /// </summary>
        [Description("获取或设置TabControl样式渲染对象名称")]
        [DefaultValue("DefaultRenderer")]
        [Editor(typeof(ClassLibrary.Winform.UI.Controls.PluggableTabControl.Design.RendererNameEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [IsCloneable(true)]
        public string RendererName { get; set; }

        /// <summary>
        /// 获取或设置TabControl样式渲染对象
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [IsCloneable(true)]
        public RendererBase Renderer
        {
            get { return renderer; }
            set
            {
                try
                {
                    if (!value.Equals(renderer))
                    {
                        renderer.RendererUpdated -= OnRendererUpdated;
                        if (!DesignMode)
                        {
                            CustomControlsLogic.SuspendLogic(Parent);
                            renderer = value;
                            RebuildControl();
                            RebuildSmartButtons();
                            UpdateStyles();
                            OnRendererChanged();
                            CustomControlsLogic.ResumeLogic(Parent);
                        }
                        else
                        {
                            renderer = value;
                            RebuildControl();
                            RebuildSmartButtons();
                            UpdateStyles();
                        }
                        renderer.RendererUpdated += new EventHandler(OnRendererUpdated);

                        if (renderer.TabControl == null)
                            renderer.TabControl = this;
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Value cannot be null!, please enter a valid value.");
                }
            }
        }

        /// <summary>
        /// 获取或设置Tooltip样式渲染对象
        /// </summary>
        [Description("获取或设置Tooltip样式渲染对象")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [IsCloneable(true)]
        public TooltipRenderer TooltipRenderer
        {
            get { return tooltipRenderer; }
            set
            {
                try
                {
                    if (!value.Equals(tooltipRenderer))
                        tooltipRenderer = value;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Value cannot be null!, please enter a valid value.");
                }
            }
        }

        /// <summary>
        /// TabPage集合
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public NeoTabPageControlCollection TabPages
        {
            get { return tabPages; }
        }

        public override Rectangle DisplayRectangle
        {
            get
            {
                return new Rectangle(
                    base.DisplayRectangle.Left + Padding.Left, // x
                    base.DisplayRectangle.Top + Padding.Top,   // y
                    base.DisplayRectangle.Width - (Padding.Left + Padding.Right),   // width
                    base.DisplayRectangle.Height - (Padding.Top + Padding.Bottom)); // height
            }
        }

        /// <summary>
        /// TabControl控件默认尺寸
        /// </summary>
        protected override Size DefaultSize
        {
            get
            {
                return DEFAULT_SIZE;
            }
        }

        /// <summary>
        /// 获取或设置控件page页的默认边框样式。
        /// </summary>
        [Description("获取或设置控件page页的默认边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle DefaultTabPageBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置控件page页的上边框样式。
        /// </summary>
        [Description("获取或设置控件page页的上边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabPageTopBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置控件page页的右边框样式。
        /// </summary>
        //[Description("获取或设置控件page页的右边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabPageRightBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置控件page页的下边框样式。
        /// </summary>
        [Description("获取或设置控件page页的下边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabPageBottomBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置控件page页的左边框样式。
        /// </summary>
        [Description("获取或设置控件page页的左边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabPageLeftBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的文本和图像彼此之间的相对位置。
        /// </summary>
        [Description("获取或设置Tab选项卡的文本和图像彼此之间的相对位置")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TextImageRelation TextImageRelation { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的宽度，如果实际宽度超出此宽度，则以实际宽度为准。
        /// </summary>
        [Description("获取或设置Tab选项卡的宽度，如果实际宽度超出此宽度，则以实际宽度为准")]
        public int TabItemWidth { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的高度，如果实际宽度超出此高度，则以实际高度为准。
        /// </summary>
        [Description("获取或设置Tab选项卡的高度，如果实际宽度超出此高度，则以实际高度为准")]
        public int TabItemHeight { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的边框样式。
        /// </summary>
        [Description("获取或设置Tab选项卡的边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabItemBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的背景色。
        /// </summary>
        [Description("获取或设置Tab选项卡的背景色")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Color TabItemBackColor { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的前景色。
        /// </summary>
        [Description("获取或设置Tab选项卡的前景色")]
        public Color TabItemForeColor { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的悬浮背景色。
        /// </summary>
        [Description("获取或设置Tab选项卡的悬浮背景色")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Color TabItemHoverBackColor { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的悬浮前景色。
        /// </summary>
        [Description("获取或设置Tab选项卡的悬浮前景色")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Color TabItemHoverForeColor { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的悬浮边框样式。
        /// </summary>
        [Description("获取或设置Tab选项卡的悬浮边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabItemHoverBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的悬浮背景色。
        /// </summary>
        [Description("获取或设置活动Tab选项卡的景色")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Color TabItemActiveBackColor { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的悬浮前景色。
        /// </summary>
        [Description("获取或设置活动Tab选项卡的前景色")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Color TabItemActiveForeColor { get; set; }

        /// <summary>
        /// 获取或设置Tab活动选项卡的边框样式。
        /// </summary>
        [Description("获取或设置Tab活动选项卡的边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabItemActiveBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置禁用Tab选项卡的背景色。
        /// </summary>
        [Description("获取或设置禁用Tab选项卡的背景色")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Color TabItemDisabledBackColor { get; set; }

        /// <summary>
        /// 获取或设置禁用Tab选项卡的前景色。
        /// </summary>
        [Description("获取或设置禁用Tab选项卡的前景色")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Color TabItemDisabledForeColor { get; set; }

        /// <summary>
        /// 获取或设置禁用Tab选项卡的边框样式。
        /// </summary>
        [Description("获取或设置禁用Tab选项卡的边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabItemDisabledBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡中文字、图标之间以及它们和四周的间距。
        /// </summary>
        [Description("获取或设置Tab选项卡中文字、图标之间以及它们和四周的间距")]
        public int TabContentSpacing { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡之间的间距。
        /// </summary>
        [Description("获取或设置Tab选项卡之间的间距")]
        public int TabItemSpacing { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡区域背景图。
        /// </summary>
        [Description("获取或设置Tab选项卡区域背景图")]
        public Image TabItemAreaBackGroudImage { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡区域背景色。
        /// </summary>
        [Description("获取或设置Tab选项卡区域背景色")]
        public Color TabItemAreaBackColor { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡区域边框样式。
        /// </summary>
        [Description("获取或设置Tab选项卡区域边框样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabControlBorderStyle TabItemAreaBorderStyle { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡区域位置和大小。
        /// </summary>
        [Description("获取或设置Tab选项卡区域位置和大小")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Rectangle TabItemArea { get; set; }

        /// <summary>
        /// 获取或设置Tab选项卡的字体。
        /// </summary>
        [Description("获取或设置Tab选项卡的字体")]
        public Font TabItemFont { get; set; }

        /// <summary>
        /// Tab项区域相对于TabPage区域的外边距（当Tab位置为上：Left和Bottom有效，下：Left和Top有效，左：Top和Right有效，右：Top和Left有效）
        /// </summary>
        [Description("Tab项区域相对于TabPage区域的外边距（当Tab位置为上：Left和Bottom有效，下：Left和Top有效，左：Top和Right有效，右：Top和Left有效）")]
        public Padding TabItemAreaMargin { get; set; }

        /// <summary>
        /// TabPage区域Padding（若padding为0，则无法显示TabPage边框）
        /// </summary>
        [Description("TabPage区域Padding（若padding为0，则无法显示TabPage边框）")]
        public Padding TabPageAreaPadding { get; set; }

        /// <summary>
        /// TabPage区域背景色
        /// </summary>
        [Description("TabPage区域背景色")]
        public Color TabPageAreaBackColor { get; set; }

        #endregion

        #region 重写基类方法

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Visible)
            {
                //绘制控件背景
                renderer.OnRendererBackground(e.Graphics, ClientRectangle);

                Rectangle tabPageAreaRct = DisplayRectangle;
                tabPageAreaRct.X -= this.TabPageAreaPadding.Left;
                tabPageAreaRct.Y -= this.TabPageAreaPadding.Top;
                tabPageAreaRct.Width += (this.TabPageAreaPadding.Left + this.TabPageAreaPadding.Right);
                tabPageAreaRct.Height += (this.TabPageAreaPadding.Top + this.TabPageAreaPadding.Bottom);
                // Draw panel area.
                renderer.OnRendererTabPageArea(e.Graphics, tabPageAreaRct);

                //绘制TabItem区域背景
                renderer.OnRenderTabItemArea(e.Graphics, TabItemArea);

                if (tpItemRectangles.Count == 0)
                    return;
                // Draw smart buttons.
                int i = -1;
                Rectangle checkingSmartBtnRct = Rectangle.Empty;
                foreach (KeyValuePair<Rectangle, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState> current in smartButtonRectangles)
                {
                    i++;
                    switch (i)
                    {
                        /*** SmartCloseButton. ***/
                        case 0: 
                            if (!current.Key.IsEmpty)
                                renderer.OnDrawSmartCloseButton(e.Graphics, current.Key,
                                    SelectedTab.IsCloseable ? current.Value : ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Disabled);
                            break;
                        /*** SmartDropDownButton. ***/
                        default:
                            renderer.OnDrawSmartDropDownButton(e.Graphics, current.Key, current.Value);
                            break;
                    }
                    checkingSmartBtnRct = current.Key;
                }
                // Draw tabPage items.
                i = -1;
                foreach (KeyValuePair<Rectangle, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState> current in tpItemRectangles)
                {
                    i++;
                    bool isWrapped = false;
                    // Always draw first tab page.
                    if (i > 0)
                    {
                        switch (this.TabItemLayout)
                        {
                            case TabItemLayout.Top:
                            case TabItemLayout.Bottom:
                                if (current.Key.Right >=
                                    (checkingSmartBtnRct.IsEmpty ? DisplayRectangle.Right : checkingSmartBtnRct.Left))
                                    isWrapped = true;
                                break;
                            default:
                                if (current.Key.Bottom >=
                                    (checkingSmartBtnRct.IsEmpty ? DisplayRectangle.Bottom : checkingSmartBtnRct.Top))
                                    isWrapped = true;
                                break;
                        }
                    }
                    if (!isWrapped)
                    {
                        NeoTabPage tp = TabPages[i] as NeoTabPage;
                        ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState btnState;
                        if (selectedIndex == i)
                            btnState = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Pressed;
                        else
                        {
                            if (!tp.IsSelectable)
                                btnState = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Disabled;
                            else
                                btnState = current.Value;
                        }

                        renderer.OnRendererTabPageItem(e.Graphics, current.Key,
                            String.IsNullOrEmpty(tp.Text) ? tp.Name : tp.Text,
                            i, btnState);
                    }
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (tpItemRectangles.Count == 0)
                return;
            if (renderer.EnableSmartCloseButton || renderer.EnableSmartDropDownButton)
                RebuildSmartButtons();
            if ((this.TabItemLayout == TabItemLayout.Bottom) ||
                (this.TabItemLayout == TabItemLayout.Right))
            {
                RebuildControl();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            foreach (NeoTabPage tabPage in this.Controls)
            {
                int x, y, w, h;

                x = DisplayRectangle.Location.X;
                y = DisplayRectangle.Location.Y;

                w = DisplayRectangle.Size.Width;
                h = DisplayRectangle.Size.Height;

                tabPage.SetBounds(x, y, w, h, BoundsSpecified.All);
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            if (e.Control is NeoTabPage)
            {
                NeoTabPage tp = e.Control as NeoTabPage;
                if (String.IsNullOrEmpty(tp.Name))
                {
                    int value = 0;
                    foreach (NeoTabPage tabPage in this.Controls)
                    {
                        try
                        {
                            if (tabPage.Name.Contains("neoTabPage"))
                            {
                                int current;
                                if (Int32.TryParse(tabPage.Name.Substring(10, tabPage.Name.Length - 10),
                                    out current))
                                {
                                    value = Math.Max(value, current);
                                }
                            }
                        }
                        catch { ;}
                    }
                    tp.Name = String.Format("neoTabPage{0}", ++value);
                }
                if (String.IsNullOrEmpty(tp.Text))
                {
                    tp.Text = tp.Name;
                }
                if (String.IsNullOrEmpty(tp.ToolTipText))
                {
                    tp.ToolTipText = tp.Text;
                }
                tp.Dock = DockStyle.Fill;
                tp.TextChanged += (sender, ea) =>
                    {
                        if (initializing)
                        {
                            RebuildControl();
                            UpdateStyles();
                        }
                    };
                base.OnControlAdded(e);
                if (Controls.Count == 1)
                    selectedIndex = 0;
                if (initializing)
                {
                    RebuildControl();
                    UpdateStyles();
                }
            }
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            RebuildControl();
            SelectNextAvailableTabPage();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button != System.Windows.Forms.MouseButtons.None)
                return;
            Rectangle checkingSmartBtnRct = Rectangle.Empty;
            if (this.Controls.Count > 0)
            {
                int itemIndex = -1;
                List<Rectangle> list = new List<Rectangle>(smartButtonRectangles.Keys);
                foreach (Rectangle smartButtonRectangle in list)
                {
                    itemIndex++;
                    if (!smartButtonRectangle.Contains(e.Location))
                    {
                        if (smartButtonRectangles[smartButtonRectangle]
                            == ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover)
                        {
                            smartButtonRectangles[smartButtonRectangle] = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal;
                            Invalidate(smartButtonRectangle);
                        }
                    }
                    else
                    {
                        ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState smartButtonState = smartButtonRectangles[smartButtonRectangle];
                        if (itemIndex == 0 ? (SelectedTab.IsCloseable && smartButtonState
                            != ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover) : smartButtonState
                            != ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover)
                        {
                            smartButtonRectangles[smartButtonRectangle] = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover;
                            Invalidate(smartButtonRectangle);
                        }
                    }
                    checkingSmartBtnRct = smartButtonRectangle;
                }
            }
            if (this.Controls.Count > 1)
            {
                int itemIndex = -1;
                List<Rectangle> list = new List<Rectangle>(tpItemRectangles.Keys);
                foreach (Rectangle itemRectangle in list)
                {
                    itemIndex++;
                    if (!itemRectangle.Contains(e.Location))
                    {
                        if (tpItemRectangles[itemRectangle]
                            == ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover)
                        {
                            tpItemRectangles[itemRectangle] = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal;
                            Invalidate(itemRectangle);
                        }
                    }
                    else
                    {
                        NeoTabPage tp = TabPages[itemIndex] as NeoTabPage;
                        ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState itemState = tpItemRectangles[itemRectangle];
                        if (itemState != ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover && tp != null &&
                            selectedIndex != itemIndex && tp.IsSelectable)
                        {
                            bool isAvailable = true;
                            switch (this.TabItemLayout)
                            {
                                case TabItemLayout.Top:
                                case TabItemLayout.Bottom:
                                    if (itemRectangle.Right >=
                                        (checkingSmartBtnRct.IsEmpty ? DisplayRectangle.Right : checkingSmartBtnRct.Left))
                                        isAvailable = false;
                                    break;
                                default:
                                    if (itemRectangle.Bottom >=
                                        (checkingSmartBtnRct.IsEmpty ? DisplayRectangle.Bottom : checkingSmartBtnRct.Top))
                                        isAvailable = false;
                                    break;
                            }
                            if (isAvailable)
                            {
                                tpItemRectangles[itemRectangle] = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover;
                                Invalidate(itemRectangle);
                                if (!DesignMode && TooltipEnabled)
                                {
                                    queueTooltipPoint = e.Location;
                                    // Shows a tooltip to the user for currently active tab page.
                                    ShowTooltip(tp, itemRectangle);
                                }
                            }
                        }
                    }
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Controls.Count > 0)
                {
                    int result = -1;
                    Rectangle smartButtonRectangle;
                    ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState smartButtonState;
                    GetSmartButtonHitTest(e.Location, out smartButtonRectangle,
                        out smartButtonState, out result);
                    switch (result)
                    {
                        /*** Is on the SmartCloseButton. ***/
                        case 0:
                            NeoTabPage stp = this.SelectedTab;
                            if (stp.IsCloseable)
                                Remove(stp);
                            break;
                        /*** Is on the SmartDropDownButton. ***/
                        case 1:
                            ContextMenuStrip dropDownMenu = new ContextMenuStrip();
                            Point menuLocation = PointToScreen(new Point(smartButtonRectangle.Left, smartButtonRectangle.Bottom));
                            using (DropDownButtonClickedEventArgs ea = 
                                new DropDownButtonClickedEventArgs(dropDownMenu, menuLocation))
                            {
                                // Fire a Notification Event.
                                OnDropDownButtonClicked(ea);
                            }
                            break;
                        /*** Is not found! ***/
                        default:
                            if (this.Controls.Count > 1)
                            {
                                int itemIndex = -1;
                                Rectangle itemRectangle;
                                ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState itemState;
                                NeoTabPage tabItem = GetHitTest(e.Location,
                                    out itemRectangle, out itemState, out itemIndex);
                                if (tabItem != null && tabItem.IsSelectable)
                                {
                                    bool isAvailable = true;
                                    switch (this.TabItemLayout)
                                    {
                                        case TabItemLayout.Top:
                                        case TabItemLayout.Bottom:
                                            if (itemRectangle.Right >= 
                                                (smartButtonRectangle.IsEmpty ? DisplayRectangle.Right : smartButtonRectangle.Left))
                                                isAvailable = false;
                                            break;
                                        default:
                                            if (itemRectangle.Bottom >= 
                                                (smartButtonRectangle.IsEmpty ? DisplayRectangle.Bottom : smartButtonRectangle.Top))
                                                isAvailable = false;
                                            break;
                                    }
                                    if (isAvailable)
                                    {
                                        if (selectedIndex != itemIndex)
                                        {
                                            using (SelectedIndexChangingEventArgs ea =
                                                new SelectedIndexChangingEventArgs(tabItem, itemIndex))
                                            {
                                                // Fire a Notification Event.
                                                OnSelectedIndexChanging(ea);

                                                if (!ea.Cancel)
                                                    this.SelectedIndex = ea.TabPageIndex;
                                            }
                                        }
                                        else
                                        {
                                            if (!DesignMode && AllowDrop)
                                            {
                                                // Starts a drag & drop operation for currently selected tab page.
                                                BeginDragDrop(tabItem, itemRectangle,
                                                    ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Pressed, itemIndex);
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (this.Controls.Count > 0)
            {
                List<Rectangle> list = new List<Rectangle>(smartButtonRectangles.Keys);
                foreach (Rectangle smartButtonRectangle in list)
                {
                    if (smartButtonRectangles[smartButtonRectangle]
                        == ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover)
                    {
                        smartButtonRectangles[smartButtonRectangle] = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal;
                        Invalidate(smartButtonRectangle);
                    }
                }
            }
            if (this.Controls.Count > 1)
            {
                queueTooltipPoint = new Point(-1, -1);
                List<Rectangle> list = new List<Rectangle>(tpItemRectangles.Keys);
                foreach (Rectangle itemRectangle in list)
                {
                    if (tpItemRectangles[itemRectangle]
                        == ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Hover)
                    {
                        tpItemRectangles[itemRectangle] = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal;
                        Invalidate(itemRectangle);
                    }
                }
            }
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);
            if (!DesignMode && drgevent.Data.GetDataPresent(typeof(NeoTabPage)))
            {
                Point pt = PointToClient(new Point(drgevent.X, drgevent.Y));
                int result = -1;
                Rectangle smartButtonRectangle;
                ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState smartButtonState;
                GetSmartButtonHitTest(pt, out smartButtonRectangle,
                    out smartButtonState, out result);
                if (result >= 0)
                    return;
                int itemIndex = -1;
                Rectangle itemRectangle;
                ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState itemState;
                NeoTabPage overTab = GetHitTest(pt,
                    out itemRectangle, out itemState, out itemIndex);
                if (overTab != null)
                {
                    bool isAvailable = true;
                    switch (this.TabItemLayout)
                    {
                        case TabItemLayout.Top:
                        case TabItemLayout.Bottom:
                            if (itemRectangle.Right >=
                                (smartButtonRectangle.IsEmpty ? DisplayRectangle.Right : smartButtonRectangle.Left))
                                isAvailable = false;
                            break;
                        default:
                            if (itemRectangle.Bottom >= 
                                (smartButtonRectangle.IsEmpty ? DisplayRectangle.Bottom : smartButtonRectangle.Top))
                                isAvailable = false;
                            break;
                    }
                    if (isAvailable)
                    {
                        NeoTabPage draggingTab =
                            drgevent.Data.GetData(typeof(NeoTabPage)) as NeoTabPage;
                        if (!draggingTab.Equals(overTab))// If itself.
                        {
                            if (!draggingTab.Parent.Equals(overTab.Parent))
                            {
                                ((NeoTabWindow)draggingTab.Parent).Controls.Remove(draggingTab);
                                Controls.Add(draggingTab);
                                Controls.SetChildIndex(draggingTab, itemIndex);
                            }
                            else
                            {
                                // Switching tab indexes, we don't remove the dragging tab because, dragging tab already within the current collection.
                                Controls.SetChildIndex(overTab, selectedIndex);
                                Controls.SetChildIndex(draggingTab, itemIndex);
                            }
                            RebuildControl();
                            this.SelectedIndex = itemIndex;
                        }
                    }
                }
            }
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            base.OnDragOver(drgevent);
            if (!DesignMode)
            {
                if (drgevent.KeyState == 1 && drgevent.Data.GetDataPresent(typeof(NeoTabPage)))
                    drgevent.Effect = DragDropEffects.Move;
                else
                    drgevent.Effect = DragDropEffects.None;
            }
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            base.OnGiveFeedback(gfbevent);
            if (!DesignMode)
            {
                if ((gfbevent.Effect & DragDropEffects.Move) == DragDropEffects.Move)
                {
                    gfbevent.UseDefaultCursors = false;
                    Cursor.Current = myDdCursor.DDCursor;
                }
            }
        }

        protected override bool ProcessMnemonic(char charCode)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                NeoTabPage tp = TabPages[i] as NeoTabPage;
                if (IsMnemonic(charCode, tp.Text))
                {
                    if (tp.IsSelectable && selectedIndex != i)
                    {
                        using (SelectedIndexChangingEventArgs e =
                            new SelectedIndexChangingEventArgs(tp, i))
                        {
                            // Fire a Notification Event.
                            OnSelectedIndexChanging(e);

                            if (!e.Cancel)
                                this.SelectedIndex = e.TabPageIndex;
                        }
                    }
                    break;
                }
            }

            return base.ProcessMnemonic(charCode);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // Selects last tab.
                case Keys.End:
                    OnNavigateTabPage(this.Controls.Count - 1);
                    break;
                // Selects first tab.
                case Keys.Home:
                    OnNavigateTabPage(0);
                    break;
                // Selects the tab on the left side of the currently selected tab.
                case Keys.Left:
                case Keys.Tab | Keys.Control | Keys.Shift:
                    OnNavigateTabPage(selectedIndex - 1);
                    break;
                // Selects the tab on the right side of the currently selected tab.
                case Keys.Right:
                case Keys.Tab | Keys.Control:
                    OnNavigateTabPage(selectedIndex + 1);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override ControlCollection CreateControlsInstance()
        {
            if (tabPages == null)
                tabPages = new NeoTabPageControlCollection(this);

            return tabPages;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            /* Managed Resources */
            if (disposing)
            {
                // Dispose renderer class.
                renderer.Dispose();
                // Dispose tooltip renderer class.
                tooltipRenderer.Dispose();
                // Dispose the NeoTabPageHidedMembersCollection class.
                hidedMembers.Dispose();
                // Dispose all child controls.
                foreach (Control control in this.Controls)
                    control.Dispose();
            }

            base.Dispose(disposing);
        }

        #endregion

        #region Virtual Methods

        protected virtual void OnRendererChanged()
        {
            if (RendererChanged != null)
                RendererChanged(this, EventArgs.Empty);
        }

        protected virtual void OnRendererUpdated(object sender, EventArgs e)
        {
            CustomControlsLogic.SuspendLogic(Parent);
            RebuildControl();
            UpdateStyles();
            if (RendererUpdated != null)
                RendererUpdated(sender, e);
            CustomControlsLogic.ResumeLogic(Parent);
        }

        protected virtual void OnSelectedIndexChanged(SelectedIndexChangedEventArgs e)
        {
            if (SelectedIndexChanged != null)
                SelectedIndexChanged(this, e);
        }

        protected virtual void OnSelectedIndexChanging(SelectedIndexChangingEventArgs e)
        {
            if (SelectedIndexChanging != null)
                SelectedIndexChanging(this, e);
        }

        protected virtual void OnTabPageRemoved(TabPageRemovedEventArgs e)
        {
            if (TabPageRemoved != null)
                TabPageRemoved(this, e);
        }

        protected virtual void OnTabPageRemoving(TabPageRemovingEventArgs e)
        {
            if (TabPageRemoving != null)
                TabPageRemoving(this, e);
        }

        protected virtual void OnDropDownButtonClicked(DropDownButtonClickedEventArgs e)
        {
            if (this.Controls.Count > 0)
            {
                ToolStripMenuItem menuItem = null;
                menuItem = new ToolStripMenuItem("Close", null, null,
                    Keys.Control | Keys.C);
                menuItem.ImageScaling = ToolStripItemImageScaling.None;
                menuItem.Enabled = SelectedTab.IsCloseable ? true : false;
                if (menuItem.Enabled)
                {
                    menuItem.Click += (sender, ea) =>
                    {
                        Remove(SelectedTab);
                    };
                }
                e.ContextMenu.Items.Add(menuItem);
                menuItem = new ToolStripMenuItem("Show/Hide Tab Items", null, null,
                    Keys.Control | Keys.M);
                menuItem.ImageScaling = ToolStripItemImageScaling.None;
                menuItem.Click += (sender, ea) =>
                {
                    ShowTabManager();
                };
                e.ContextMenu.Items.Add(menuItem);
                if (this.Controls.Count > 1)
                {
                    e.ContextMenu.Items.Add(new ToolStripSeparator());
                    int n = -1;
                    foreach (NeoTabPage tp in this.TabPages)
                    {
                        n++;
                        if (!tp.Equals(SelectedTab))
                        {
                            menuItem = new ToolStripMenuItem(tp.Text, null, null, n.ToString());
                            menuItem.ImageScaling = ToolStripItemImageScaling.None;
                            menuItem.Enabled = tp.IsSelectable ? true : false;
                            if (menuItem.Enabled)
                            {
                                menuItem.Click += (sender, ea) =>
                                {
                                    OnNavigateTabPage(Int32.Parse(((ToolStripItem)sender).Name));
                                };
                            }
                            e.ContextMenu.Items.Add(menuItem);
                        }
                    }
                }
                if (DropDownButtonClicked != null)
                    DropDownButtonClicked(this, e);
                e.ContextMenu.Show(e.MenuLocation);
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Do its base processes for control creating.
        /// </summary>
        private void RebuildControl()
        {
            InitControl();
        }

        /// <summary>
        /// 初始化TabControl的Tab项位置尺寸状态以及TabControl的尺寸
        /// </summary>
        private void InitControl()
        {
            //清除原有Tab项
            tpItemRectangles.Clear();

            ////设置背景色
            //this.BackColor = renderer.BackColor;

            using (Graphics g = this.CreateGraphics())
            {
                //Tab的X坐标
                int x = 0;
                //Tab的Y坐标
                int y = 0;
                //Tab项宽度
                int itemWidth = 0;
                //Tab项高度
                int itemHeight = 0;

                //Tab项最大宽度
                int maxWidth = 0;
                //Tab项最大高度
                int maxHeight = 0;

                //计算Tab集合中最大的Tab宽度和高度，此最大值为加上ItemObjectsDrawingMargin之后的值。
                GetMaxSize(g, out maxWidth, out maxHeight);

                //控件的Padding值
                Padding padding = new Padding();

                //如果Tab选项卡的位置为上或下
                if (this.TabItemLayout.Equals(TabItemLayout.Top) || this.TabItemLayout.Equals(TabItemLayout.Bottom))
                {
                    //设置TabControl的Padding，Tab选项卡的X起始位置为Tab区域的左间距,Y为0
                    if (this.TabItemLayout.Equals(TabItemLayout.Top))
                    {
                        x = this.TabItemAreaMargin.Left;
                        y = this.TabItemAreaMargin.Top;

                        padding.Left = this.TabPageAreaPadding.Left;
                        padding.Top = this.TabPageAreaPadding.Top + maxHeight
                            + this.TabItemAreaMargin.Top + this.TabItemAreaMargin.Bottom;
                        padding.Right = this.TabPageAreaPadding.Right;
                        padding.Bottom = this.TabPageAreaPadding.Bottom;

                        TabItemArea = new Rectangle(0, 0, this.ClientRectangle.Width, padding.Top);
                    }
                    else if (this.TabItemLayout.Equals(TabItemLayout.Bottom))
                    {
                        //设置Tab选项卡X为Tab区域的左间距，Y为控件高度减去选项卡高度
                        x = this.TabItemAreaMargin.Left;
                        y = this.ClientRectangle.Bottom - this.TabItemAreaMargin.Bottom - maxHeight;

                        padding.Left = this.TabPageAreaPadding.Left;
                        padding.Top = this.TabPageAreaPadding.Top;
                        padding.Right = this.TabPageAreaPadding.Right;
                        padding.Bottom = this.TabPageAreaPadding.Bottom + maxHeight
                            + this.TabItemAreaMargin.Top + this.TabItemAreaMargin.Bottom;

                        TabItemArea = new Rectangle(0, this.ClientRectangle.Height - padding.Bottom, this.ClientRectangle.Width, padding.Bottom);
                    }

                    foreach (NeoTabPage tabPage in this.Controls)
                    {
                        if (this.TabItemStyle.Equals(TabItemStyle.Text))
                        {
                            //计算文本尺寸
                            Size txtSize = g.MeasureString(tabPage.Text, this.TabItemFont, Int32.MaxValue).ToSize();
                            //Tab项的宽度为文本宽度加上Tab项左右外边距
                            if (TabItemWidth > 0)
                                itemWidth = Math.Max(txtSize.Width + this.TabContentSpacing * 2, TabItemWidth);
                            else
                                itemWidth = txtSize.Width + this.TabContentSpacing * 2;

                            //Tab项的高度为文本高度加上Tab项上下外边距
                            itemHeight = maxHeight;
                        }
                        else if (this.TabItemStyle.Equals(TabItemStyle.Image))
                        {
                            //Tab项的宽度为图像宽度加上Tab项左右外边距
                            if (TabItemWidth > 0)
                                itemWidth = Math.Max(tabPage.TabImage.Width + this.TabContentSpacing * 2, TabItemWidth);
                            else
                                itemWidth = tabPage.TabImage.Width + this.TabContentSpacing * 2;

                            //Tab项的高度为图像高度加上Tab项上下外边距
                            itemHeight = maxHeight;
                        }
                        else if (this.TabItemStyle.Equals(TabItemStyle.TextAndImage))
                        {
                            //计算文本尺寸
                            Size txtSize = g.MeasureString(tabPage.Text, this.TabItemFont, Int32.MaxValue).ToSize();

                            if (this.TextImageRelation.Equals(TextImageRelation.ImageBeforeText) ||
                                this.TextImageRelation.Equals(TextImageRelation.TextBeforeImage))
                            {
                                if (TabItemWidth > 0)
                                    itemWidth = Math.Max(txtSize.Width + tabPage.TabImage.Width + this.TabContentSpacing * 3, TabItemWidth);
                                else
                                    itemWidth = txtSize.Width + tabPage.TabImage.Width + this.TabContentSpacing * 3;

                                itemHeight = maxHeight;
                            }
                            else if (this.TextImageRelation.Equals(TextImageRelation.ImageAboveText) ||
                                this.TextImageRelation.Equals(TextImageRelation.TextAboveImage))
                            {
                                if (TabItemWidth > 0)
                                {
                                    itemWidth = Math.Max(
                                        Math.Max(txtSize.Width, tabPage.TabImage.Width) + this.TabContentSpacing * 2,
                                        TabItemWidth);
                                }
                                else
                                    itemWidth = Math.Max(txtSize.Width, tabPage.TabImage.Width) + this.TabContentSpacing * 2;

                                itemHeight = maxHeight;
                            }
                            else if (this.TextImageRelation.Equals(TextImageRelation.Overlay))
                            {
                                if (TabItemWidth > 0)
                                {
                                    itemWidth = Math.Max(
                                        Math.Max(txtSize.Width, tabPage.TabImage.Width) + this.TabContentSpacing * 2,
                                        TabItemWidth);
                                }
                                else
                                    itemWidth = Math.Max(txtSize.Width, tabPage.TabImage.Width) + this.TabContentSpacing * 2;

                                itemHeight = maxHeight;
                            }
                        }

                        tpItemRectangles.Add(new Rectangle(x, y, itemWidth, itemHeight), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                        x += itemWidth + this.TabItemSpacing;
                    }
                }
                else if (this.TabItemLayout.Equals(TabItemLayout.Left) || this.TabItemLayout.Equals(TabItemLayout.Right))
                {
                    //设置TabControl的Padding，TabPage区域为控件去掉Padding后的尺寸
                    if (this.TabItemLayout.Equals(TabItemLayout.Left))
                    {
                        //设置Tab选项卡的X起始位置为Tab区域的左间距,Y为0
                        x = this.TabItemAreaMargin.Left;
                        y = this.TabItemAreaMargin.Top;

                        padding.Left = this.TabPageAreaPadding.Left + maxWidth + this.TabItemAreaMargin.Left + this.TabItemAreaMargin.Right;
                        padding.Top = this.TabPageAreaPadding.Top;
                        padding.Right = this.TabPageAreaPadding.Right;
                        padding.Bottom = this.TabPageAreaPadding.Bottom;

                        TabItemArea = new Rectangle(0, 0, padding.Left, this.ClientRectangle.Height);
                    }
                    else if (this.TabItemLayout.Equals(TabItemLayout.Right))
                    {
                        //设置Tab选项卡X为Tab区域的左间距，Y为控件高度减去选项卡高度
                        x = this.ClientRectangle.Right - this.TabItemAreaMargin.Right - maxWidth;
                        y = this.TabItemAreaMargin.Top;

                        padding.Left = this.TabPageAreaPadding.Left;
                        padding.Top = this.TabPageAreaPadding.Top;
                        padding.Right = this.TabPageAreaPadding.Right + maxWidth + this.TabItemAreaMargin.Left + this.TabItemAreaMargin.Right;
                        padding.Bottom = this.TabPageAreaPadding.Bottom;

                        TabItemArea = new Rectangle(this.ClientRectangle.Width - padding.Right, 0, padding.Right, this.ClientRectangle.Height);
                    }

                    foreach (NeoTabPage tabPage in this.Controls)
                    {
                        if (this.TabItemStyle.Equals(TabItemStyle.Text))
                        {
                            //计算文本尺寸
                            Size txtSize = g.MeasureString(tabPage.Text, this.TabItemFont, Int32.MaxValue).ToSize();
                            //Tab项的宽度为文本宽度加上Tab项左右外边距
                            itemWidth = maxWidth;
                            //Tab项的高度为文本高度加上Tab项上下外边距
                            if (TabItemHeight > 0)
                                itemHeight = Math.Max(txtSize.Height + this.TabContentSpacing * 2, TabItemHeight);
                            else
                                itemHeight = txtSize.Height + this.TabContentSpacing * 2;
                        }
                        else if (this.TabItemStyle.Equals(TabItemStyle.Image))
                        {
                            //Tab项的宽度为图像宽度加上Tab项左右外边距
                            itemWidth = maxWidth;
                            //Tab项的高度为图像高度加上Tab项上下外边距
                            if (TabItemHeight > 0)
                                itemHeight = Math.Max(tabPage.TabImage.Height + this.TabContentSpacing * 2, TabItemHeight);
                            else
                                itemHeight = tabPage.TabImage.Height + this.TabContentSpacing * 2;
                        }
                        else if (this.TabItemStyle.Equals(TabItemStyle.TextAndImage))
                        {
                            //计算文本尺寸
                            Size txtSize = g.MeasureString(tabPage.Text, this.TabItemFont, Int32.MaxValue).ToSize();

                            if (this.TextImageRelation.Equals(TextImageRelation.ImageBeforeText) ||
                                this.TextImageRelation.Equals(TextImageRelation.TextBeforeImage))
                            {
                                itemWidth = maxWidth;

                                if (TabItemHeight > 0)
                                {
                                    itemHeight = Math.Max(
                                        Math.Max(txtSize.Height, tabPage.TabImage.Height) + this.TabContentSpacing * 2,
                                        TabItemHeight);
                                }
                                else
                                    itemHeight = Math.Max(txtSize.Height, tabPage.TabImage.Height) + this.TabContentSpacing * 2;
                            }
                            else if (this.TextImageRelation.Equals(TextImageRelation.ImageAboveText) ||
                                this.TextImageRelation.Equals(TextImageRelation.TextAboveImage))
                            {
                                itemWidth = maxWidth;

                                if (TabItemHeight > 0)
                                    itemHeight = Math.Max(txtSize.Height + tabPage.TabImage.Height + this.TabContentSpacing * 3, TabItemHeight);
                                else
                                    itemHeight = txtSize.Height + tabPage.TabImage.Height + this.TabContentSpacing * 3;
                            }
                            else if (this.TextImageRelation.Equals(TextImageRelation.Overlay))
                            {
                                itemWidth = maxWidth;

                                if (TabItemHeight > 0)
                                {
                                    itemHeight = Math.Max(
                                        Math.Max(txtSize.Height, tabPage.TabImage.Height) + this.TabContentSpacing * 2,
                                        TabItemHeight);
                                }
                                else
                                    itemHeight = Math.Max(txtSize.Height, tabPage.TabImage.Height) + this.TabContentSpacing * 2;
                            }
                        }

                        tpItemRectangles.Add(new Rectangle(x, y, itemWidth, itemHeight), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                        y += itemHeight + this.TabItemSpacing;
                    }
                }
                //设置控件的Padding值，TabPage区域的尺寸为控件的尺寸减去Padding值以后的
                this.Padding = new Padding(padding.Left, padding.Top, padding.Right, padding.Bottom);
            }
        }

        /// <summary>
        /// 获取最大宽度和高度
        /// </summary>
        /// <param name="g"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void GetMaxSize(Graphics g, out int width, out int height)
        {
            width = 0;
            height = 0;

            foreach (NeoTabPage tabPage in this.Controls)
            {
                if (this.TabItemStyle.Equals(TabItemStyle.Text))
                {
                    //计算文本尺寸
                    Size txtSize = g.MeasureString(tabPage.Text, this.TabItemFont, Int32.MaxValue).ToSize();

                    width = Math.Max(txtSize.Width + this.TabContentSpacing * 2, width);
                    height = Math.Max(txtSize.Height + this.TabContentSpacing * 2, height);
                }
                else if (this.TabItemStyle.Equals(TabItemStyle.Image))
                {
                    width = Math.Max(tabPage.TabImage.Width + this.TabContentSpacing * 2, width);
                    height = Math.Max(tabPage.TabImage.Height + this.TabContentSpacing * 2, height);
                }
                else if (this.TabItemStyle.Equals(TabItemStyle.TextAndImage))
                {
                    //计算文本尺寸
                    Size txtSize = g.MeasureString(tabPage.Text, this.TabItemFont, Int32.MaxValue).ToSize();

                    if (this.TextImageRelation.Equals(TextImageRelation.ImageBeforeText) ||
                        this.TextImageRelation.Equals(TextImageRelation.TextBeforeImage))
                    {
                        width = Math.Max(txtSize.Width + tabPage.TabImage.Width + this.TabContentSpacing * 3, 
                            width);
                        height = Math.Max(
                            Math.Max(txtSize.Height, tabPage.TabImage.Height) + this.TabContentSpacing * 2, 
                            height);
                    }
                    else if (this.TextImageRelation.Equals(TextImageRelation.ImageAboveText) ||
                        this.TextImageRelation.Equals(TextImageRelation.TextAboveImage))
                    {
                        width = Math.Max(
                            Math.Max(txtSize.Width, tabPage.TabImage.Width) + this.TabContentSpacing * 2, 
                            width);

                        height = Math.Max(txtSize.Height + tabPage.TabImage.Height
                            + this.TabContentSpacing * 3, 
                            height);
                    }
                    else if (this.TextImageRelation.Equals(TextImageRelation.Overlay))
                    {
                        width = Math.Max(
                            Math.Max(txtSize.Width, tabPage.TabImage.Width) + this.TabContentSpacing * 2, 
                            width);

                        height = Math.Max(
                            Math.Max(txtSize.Height, tabPage.TabImage.Height) + this.TabContentSpacing * 2, 
                            height);
                    }
                }
            }

            width = Math.Max(width, TabItemWidth);
            height = Math.Max(height, TabItemHeight);
        }

        /// <summary>
        /// Re-build the smart button rectangles.
        /// </summary>
        private void RebuildSmartButtons()
        {
            Rectangle tabPageAreaRct = DisplayRectangle;
            tabPageAreaRct.X -= this.TabPageAreaPadding.Left;
            tabPageAreaRct.Y -= this.TabPageAreaPadding.Top;
            tabPageAreaRct.Width += (this.TabPageAreaPadding.Left + this.TabPageAreaPadding.Right);
            tabPageAreaRct.Height += (this.TabPageAreaPadding.Top + this.TabPageAreaPadding.Bottom);
            // Removes all items in the collection.
            smartButtonRectangles.Clear();
            Point loc = Point.Empty;
            switch (this.TabItemLayout)
            {
                case TabItemLayout.Top:
                    loc.X = tabPageAreaRct.Right - renderer.SmartButtonsAreaOffset.Right - renderer.SmartButtonsSize.Width;
                    loc.Y = tabPageAreaRct.Top - renderer.SmartButtonsAreaOffset.Bottom - renderer.SmartButtonsSize.Height;
                    if (renderer.EnableSmartCloseButton)
                    {
                        smartButtonRectangles.Add(new Rectangle(loc, renderer.SmartButtonsSize), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                        loc.X -= (renderer.SmartButtonsBetweenSpacing + renderer.SmartButtonsSize.Width);
                    }
                    else
                    {
                        smartButtonRectangles.Add(Rectangle.Empty, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Disabled);
                    }
                    if (renderer.EnableSmartDropDownButton)
                    {
                        smartButtonRectangles.Add(new Rectangle(loc, renderer.SmartButtonsSize), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                    }
                    break;
                case TabItemLayout.Bottom:
                    loc.X = tabPageAreaRct.Right - renderer.SmartButtonsAreaOffset.Right - renderer.SmartButtonsSize.Width;
                    loc.Y = tabPageAreaRct.Bottom + renderer.SmartButtonsAreaOffset.Top;
                    if (renderer.EnableSmartCloseButton)
                    {
                        smartButtonRectangles.Add(new Rectangle(loc, renderer.SmartButtonsSize), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                        loc.X -= (renderer.SmartButtonsBetweenSpacing + renderer.SmartButtonsSize.Width);
                    }
                    else
                    {
                        smartButtonRectangles.Add(Rectangle.Empty, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Disabled);
                    }
                    if (renderer.EnableSmartDropDownButton)
                    {
                        smartButtonRectangles.Add(new Rectangle(loc, renderer.SmartButtonsSize), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                    }
                    break;
                case TabItemLayout.Left:
                    loc.X = tabPageAreaRct.Left - renderer.SmartButtonsAreaOffset.Right - renderer.SmartButtonsSize.Width;
                    loc.Y = tabPageAreaRct.Bottom - renderer.SmartButtonsAreaOffset.Bottom - renderer.SmartButtonsSize.Height;
                    if (renderer.EnableSmartCloseButton)
                    {
                        smartButtonRectangles.Add(new Rectangle(loc, renderer.SmartButtonsSize), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                        loc.Y -= (renderer.SmartButtonsBetweenSpacing + renderer.SmartButtonsSize.Height);
                    }
                    else
                    {
                        smartButtonRectangles.Add(Rectangle.Empty, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Disabled);
                    }
                    if (renderer.EnableSmartDropDownButton)
                    {
                        smartButtonRectangles.Add(new Rectangle(loc, renderer.SmartButtonsSize), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                    }
                    break;
                case TabItemLayout.Right:
                    loc.X = tabPageAreaRct.Right + renderer.SmartButtonsAreaOffset.Left;
                    loc.Y = tabPageAreaRct.Bottom - renderer.SmartButtonsAreaOffset.Bottom - renderer.SmartButtonsSize.Height;
                    if (renderer.EnableSmartCloseButton)
                    {
                        smartButtonRectangles.Add(new Rectangle(loc, renderer.SmartButtonsSize), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                        loc.Y -= (renderer.SmartButtonsBetweenSpacing + renderer.SmartButtonsSize.Height);
                    }
                    else
                    {
                        smartButtonRectangles.Add(Rectangle.Empty, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Disabled);
                    }
                    if (renderer.EnableSmartDropDownButton)
                    {
                        smartButtonRectangles.Add(new Rectangle(loc, renderer.SmartButtonsSize), ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal);
                    }
                    break;
            }
        }

        /// <summary>
        /// Selects a tab page with a specified index of the tab.
        /// </summary>
        /// <param name="tabPageIndex">Index of the tab to select</param>
        private void OnNavigateTabPage(int tabPageIndex)
        {
            if (tabPageIndex == selectedIndex || this.Controls.Count <= 1)
                return;
            if (tabPageIndex > this.Controls.Count - 1)
                tabPageIndex = 0;
            else if (tabPageIndex < 0)
                tabPageIndex = this.Controls.Count - 1;
            try
            {
                NeoTabPage selectingTabPage = TabPages[tabPageIndex] as NeoTabPage;
                if (selectingTabPage == null || !selectingTabPage.IsSelectable)
                    return;
                using (SelectedIndexChangingEventArgs e =
                    new SelectedIndexChangingEventArgs(selectingTabPage, tabPageIndex))
                {
                    // Fire a Notification Event.
                    OnSelectedIndexChanging(e);

                    if (!e.Cancel)
                        this.SelectedIndex = e.TabPageIndex;
                }
            }
            catch (ArgumentOutOfRangeException)
            { ;}
        }

        /// <summary>
        /// Selects next available tab page from the collection.
        /// </summary>
        private void SelectNextAvailableTabPage()
        {
            switch (this.Controls.Count)
            {
                case 0:
                    selectedIndex = -1;
                    break;
                default:
                    bool success = false;
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        NeoTabPage tp = TabPages[i] as NeoTabPage;
                        if (!tp.IsSelectable)
                            continue;
                        if (i != selectedIndex)
                            OnNavigateTabPage(i);
                        else
                        {
                            tp.Visible = true;
                            Invalidate();
                            Update();
                        }
                        // If selection is succeed, exit from the loop.
                        if (selectedIndex == i)
                        {
                            success = true;
                            break;
                        }
                    }
                    if (!success)
                    {
                        TabPages[0].Visible = true;
                        selectedIndex = 0;
                        Invalidate();
                        Update();
                    }
                    break;
            }
        }

        private void ShowTooltip(NeoTabPage tabItem,
            Rectangle itemRectangle)
        {
            try
            {
                if (myTooltipForm == null)
                {
                    myTooltipForm = new ToolTips(tabItem.Text, tabItem.ToolTipText, tabItem.ProgressUsedValue, barMaxValue);
                    myTooltipForm.TaskCompleted += (sender, e) =>
                        {
                            int tpIndex = -1;
                            Rectangle tpRectangle;
                            ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState tpState;
                            NeoTabPage tp = GetHitTest(queueTooltipPoint,
                                out tpRectangle, out tpState, out tpIndex);
                            if (tp != null && tp.Text != myTooltipForm.TITLE)
                            {
                                myTooltipForm.TITLE = tp.Text;
                                myTooltipForm.DESCRIPTION = tp.ToolTipText;
                                myTooltipForm.VALUE = tp.ProgressUsedValue;
                                myTooltipForm.MAXVALUE = barMaxValue;
                                switch (this.TabItemLayout)
                                {
                                    default:
                                        myTooltipForm.Location = PointToScreen(new Point(tpRectangle.Right + 2,
                                            tpRectangle.Bottom + 2));
                                        break;
                                    case TabItemLayout.Bottom:
                                        myTooltipForm.Location = PointToScreen(new Point(tpRectangle.Right + 2,
                                            tpRectangle.Top - 2 - myTooltipForm.Height));
                                        break;
                                    case TabItemLayout.Right:
                                        myTooltipForm.Location = PointToScreen(new Point(tpRectangle.Left - 2 - myTooltipForm.Width,
                                            tpRectangle.Bottom + 2));
                                        break;
                                }
                                myTooltipForm.StartAsyncTooltip();
                            }
                            else
                            {
                                myTooltipForm.Close();
                                myTooltipForm = null;
                            }
                        };
                }
                if (myTooltipForm.Status != ToolTips.StatusState.InProgress)
                {
                    myTooltipForm.TooltipRenderer = tooltipRenderer;
                    switch (this.TabItemLayout)
                    {
                        default:
                            myTooltipForm.Location = PointToScreen(new Point(itemRectangle.Right + 2,
                                itemRectangle.Bottom + 2));
                            break;
                        case TabItemLayout.Bottom:
                            myTooltipForm.Location = PointToScreen(new Point(itemRectangle.Right + 2,
                                itemRectangle.Top - 2 - myTooltipForm.Height));
                            break;
                        case TabItemLayout.Right:
                            myTooltipForm.Location = PointToScreen(new Point(itemRectangle.Left - 2 - myTooltipForm.Width,
                                itemRectangle.Bottom + 2));
                            break;
                    }
                    myTooltipForm.StartAsyncTooltip();
                    myTooltipForm.Show(this);
                }
            }
            catch { ; }
        }

        private void BeginDragDrop(NeoTabPage tabItem,
            Rectangle itemRectangle,
            ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState itemState,
            int itemIndex)
        {
            if (draggingStyle == DragDropStyle.PageEffect)
            {
                Size ps = DisplayRectangle.Size;
                if (ps.Width > 180)
                    ps.Width = 180;
                if (ps.Height > 180)
                    ps.Height = 180;
                using (Bitmap bm = new Bitmap(ps.Width, ps.Height))
                {
                    myDdCursor = new DDPaintCursor();
                    using (Graphics gr = Graphics.FromImage(bm))
                    {
                        Point pt = PointToScreen(DisplayRectangle.Location);
                        gr.CopyFromScreen(pt.X, pt.Y,
                            0, 0, ps);
                    }
                    myDdCursor.DrawDDCursor(bm);
                }
            }
            else
            {
                myDdCursor = new DDPaintCursor(renderer);
                myDdCursor.DrawDDCursor(itemRectangle,
                    String.IsNullOrEmpty(tabItem.Text) ? tabItem.Name : tabItem.Text,
                    itemIndex, itemState);
            }
            DoDragDrop(tabItem, DragDropEffects.Move);
        }

        #endregion

        #region General Methods

        /// <summary>
        /// Removes the specified NeoTabPage control from the control collection.
        /// </summary>
        /// <param name="toBeRemoved">to be removed tab page control</param>
        public void Remove(NeoTabPage toBeRemoved)
        {
            if (toBeRemoved == null)
                return;
            int toBeRemovedIndex = TabPages.IndexOf(toBeRemoved);
            if (toBeRemovedIndex != -1)
                RemoveAt(toBeRemovedIndex);
        }

        /// <summary>
        /// Removes a NeoTabPage control from the control collection at the specified indexed location if it supports removing.
        /// </summary>
        /// <param name="toBeRemovedIndex">to be removed tab page index</param>
        public void RemoveAt(int toBeRemovedIndex)
        {
            // Check to see if there is an item at the supplied index.
            if ((toBeRemovedIndex >= TabPages.Count) || (toBeRemovedIndex < 0))
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                NeoTabPage tp = TabPages[toBeRemovedIndex] as NeoTabPage;
                if (tp.IsCloseable)
                {
                    using (TabPageRemovingEventArgs e =
                        new TabPageRemovingEventArgs(tp, toBeRemovedIndex))
                    {
                        OnTabPageRemoving(e);
                        if (!e.Cancel)
                        {
                            TabPages.RemoveAt(toBeRemovedIndex);
                            using (TabPageRemovedEventArgs ea =
                                new TabPageRemovedEventArgs(tp, toBeRemovedIndex))
                            {
                                OnTabPageRemoved(ea);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The result value is: 0 ( SmartCloseButton ), 1 ( SmartDropDownButton ), -1 ( Not Found ).
        /// </summary>
        /// <param name="pt">Mouse point coordinate</param>
        /// <param name="rectangle">Smart button rectangle</param>
        /// <param name="state">Smart button state</param>
        /// <param name="result">-1, 0 or 1.</param>
        public void GetSmartButtonHitTest(Point pt, out Rectangle rectangle,
            out ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState state, out int result)
        {
            int i = -1;
            rectangle = Rectangle.Empty;
            foreach (KeyValuePair<Rectangle, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState> current in smartButtonRectangles)
            {
                i++;
                rectangle = current.Key;
                if (!rectangle.Contains(pt))
                    continue;

                state = current.Value;
                result = i;
                return;
            }
            state = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Disabled;
            result = -1;
        }

        /// <summary>
        /// Gets the NeoTabPage control at the specified point if it exists in the collection.
        /// </summary>
        /// <param name="pt">Mouse point coordinate</param>
        /// <param name="rectangle">NeoTabPage item rectangle</param>
        /// <param name="state">NeoTabPage item button state</param>
        /// <param name="tabPageIndex">The index of the tab page</param>
        /// <returns>It returns an existing NeoTabPage control if the collection contains the tab page at the specified point; otherwise, null.</returns>
        public NeoTabPage GetHitTest(Point pt, out Rectangle rectangle,
            out ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState state, out int tabPageIndex)
        {
            int i = -1;
            foreach (KeyValuePair<Rectangle, ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState> current in tpItemRectangles)
            {
                i++;

                if (!current.Key.Contains(pt))
                    continue;

                tabPageIndex = i;
                state = current.Value;
                rectangle = current.Key;
                NeoTabPage RetVal = TabPages[i] as NeoTabPage;
                return RetVal;
            }

            tabPageIndex = -1;
            state = ClassLibrary.Winform.UI.Controls.PluggableTabControl.ButtonState.Normal;
            rectangle = Rectangle.Empty;
            return null;
        }

        /// <summary>
        /// Allows you to show or hide an existing tab page items.
        /// </summary>
        public void ShowTabManager()
        {
            using (TabShowHideManager manager =
                new TabShowHideManager())
            {
                /*** Add enabled items to the list. ***/
                foreach (NeoTabPage tp in this.Controls)
                {
                    if (tp.IsCloseable)
                        manager.AddNewItem(tp, true);
                }
                /*** Add hided items to the list. ***/
                foreach (NeoTabPage tp in this.hidedMembers)
                    manager.AddNewItem(tp, false);
                /*** If clicked on the apply button. ***/
                if (manager.ShowDialog()
                    == DialogResult.OK)
                {
                    foreach (NeoTabPage tp in manager.SelectedItems)
                    {
                        if (!this.Controls.Contains(tp))
                            this.Controls.Add(tp);
                    }
                    hidedMembers.Clear();
                    foreach (NeoTabPage tp in manager.UnSelectedItems)
                    {
                        if (this.Controls.Contains(tp))
                            this.Controls.Remove(tp);
                        hidedMembers.Add(tp);
                    }
                }
            }
        }

        /// <summary>
        /// Shows Add-in Manager Form.
        /// </summary>
        public void ShowAddInRendererManager()
        {
            using (AddInRendererManager manager = new AddInRendererManager(typeof(DefaultRenderer)))
            {
                manager.Renderer = this.Renderer;
                if (manager.ShowDialog() == DialogResult.OK)
                {
                    if (manager.Renderer != null)
                    {
                        Type type = manager.Renderer.GetType();
                        if (!type.Equals(this.Renderer.GetType()))
                        {
                            this.Renderer = manager.Renderer;
                            this.RendererName = type.Name;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Shows the editor form of the current renderer, if it supports.
        /// </summary>
        public void ShowAddInRendererEditor()
        {
            try
            {
                this.Renderer.InvokeEditor();
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("Editor support is not implemented for this renderer.", "NeoTabControl Library");
            }
        }

        #endregion

        #region ISupportInitialize Members

        private bool initializing = false;
        void ISupportInitialize.BeginInit()
        {
            // Do nothing.
        }
        void ISupportInitialize.EndInit()
        {
            initializing = true;
            RebuildControl();
            if (tpItemRectangles.Count > 0 &&
                (renderer.EnableSmartCloseButton || renderer.EnableSmartDropDownButton))
                RebuildSmartButtons();
            UpdateStyles();
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            NeoTabWindow toBeCloned = CustomControlsLogic.GetMyClone(this) as NeoTabWindow;
            toBeCloned.AllowDrop = this.AllowDrop;
            ((ISupportInitialize)toBeCloned).EndInit();
            return toBeCloned;
        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NeoTabWindow
            // 
            this.PaddingChanged += new System.EventHandler(this.NeoTabWindow_PaddingChanged);
            this.ResumeLayout(false);

        }

        private void NeoTabWindow_PaddingChanged(object sender, EventArgs e)
        {

        }
    }
}