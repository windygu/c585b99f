using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary.Winform.UI.Controls.PluggableTabControl
{
    public abstract class RendererBase : IDisposable
    {
        #region 公共属性

        public NeoTabWindow TabControl { get; set; }

        #endregion

        #region Virtual Properties

        public virtual int SmartButtonsBetweenSpacing { get { return 2; } }

        public virtual Size SmartButtonsSize { get { return new Size(14, 13); } }

        /// <summary>
        /// 是否启用智能关闭按钮
        /// </summary>
        public virtual bool EnableSmartCloseButton { get { return false; } }

        /// <summary>
        /// 是否启用智能下拉菜单
        /// </summary>
        public virtual bool EnableSmartDropDownButton { get { return false; } }

        public virtual DrawingOffset SmartButtonsAreaOffset
        {
            get { return new DrawingOffset(0, 0, 3, 6); }
        }

        #endregion

        #region 抽象属性

        /// <summary>
        /// Tab选项卡中的图片和文字的外边距
        ///             margin
        /// （margin图片margin文字margin）
        ///             margin
        /// </summary>
        public abstract int TabContentSpacing { get; }

        /// <summary>
        /// Tab项之间间距
        /// </summary>
        public abstract int TabItemSpacing { get; }

        /// <summary>
        /// TabPage四角间距
        /// </summary>
        public abstract DrawingOffset TabPageAreaCornerOffset { get; }

        /// <summary>
        /// Tab项区域位置(作废)
        /// </summary>
        public abstract TabItemLayout NeoTabPageItemsSide { get; }

        /// <summary>
        /// 选项卡样式（作废）
        /// </summary>
        public abstract TabItemStyle TabItemStyle { get; }

        #endregion
        #region 事件

        public event EventHandler RendererUpdated;

        #endregion

        #region 析构函数

        ~RendererBase()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region 受保护方法

        protected void OnRendererUpdated()
        {
            if (RendererUpdated != null)
                RendererUpdated(this, EventArgs.Empty);
        }

        #endregion

        #region 虚方法

        public virtual void OnRenderTabItemArea(Graphics gfx, Rectangle areaRect)
        {
            //绘制背景色
            if (TabControl.TabItemAreaBackColor != null && !TabControl.TabItemAreaBackColor.Equals(Color.Empty))
            {
                using (Brush brush = new SolidBrush(TabControl.TabItemAreaBackColor))
                {
                    gfx.FillRectangle(brush, areaRect);
                }
            }

            //绘制背景图
            if (TabControl.TabItemAreaBackGroudImage != null)
            {
                gfx.DrawImage(TabControl.TabItemAreaBackGroudImage, areaRect);
            }

            //绘制边框
            if (TabControl.TabItemAreaBorderStyle != null && TabControl.TabItemAreaBorderStyle.Color != null && 
                !TabControl.TabItemAreaBorderStyle.Color.Equals(Color.Empty) && TabControl.TabItemAreaBorderStyle.Width > 0)
            {
                using (Pen pen = new Pen(TabControl.TabItemAreaBorderStyle.Color, TabControl.TabItemAreaBorderStyle.Width))
                {
                    gfx.DrawRectangle(pen, areaRect);
                }
            }
        }

        /// <summary>
        /// 绘制TabPage内容区域
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="tabPageAreaRct"></param>
        public virtual void OnRendererTabPageArea(Graphics gfx, Rectangle tabPageAreaRct)
        {
            if (TabControl == null)
                return;

            Rectangle tabPageRect = tabPageAreaRct;

            //绘制背景色
            if (TabControl.TabPageAreaBackColor != null && !TabControl.TabPageAreaBackColor.Equals(Color.Empty))
            {
                using (Brush brush = new SolidBrush(TabControl.TabPageAreaBackColor))
                {
                    gfx.FillRectangle(brush, tabPageRect);
                }
            }

            if (TabControl.TabPageLeftBorderStyle != null)
            {
                tabPageRect.Width -= TabControl.TabPageLeftBorderStyle.Width;
            }
            else if (TabControl.DefaultTabPageBorderStyle != null)
            {
                tabPageRect.Width -= TabControl.DefaultTabPageBorderStyle.Width;
            }

            if (TabControl.TabPageTopBorderStyle != null)
            {
                tabPageRect.Height -= TabControl.TabPageTopBorderStyle.Width;
            }
            else if (TabControl.DefaultTabPageBorderStyle != null)
            {
                tabPageRect.Width -= TabControl.DefaultTabPageBorderStyle.Width;
            }

            //由于边框宽度大于一时，绘制出来的线是以两点坐标确定出来的轨迹为中轴呈现的
            int topBorderWidth = 1;
            int bottomBorderWidth = 1;

            using (Pen pen = new Pen(Color.Empty, 1))
            {
                //绘制顶部边框
                if (TabControl.TabPageTopBorderStyle != null && !TabControl.TabPageTopBorderStyle.Color.Equals(Color.Empty))
                {
                    pen.Color = TabControl.TabPageTopBorderStyle.Color;
                    pen.Width = TabControl.TabPageTopBorderStyle.Width;
                }
                else if (TabControl.DefaultTabPageBorderStyle != null && !TabControl.DefaultTabPageBorderStyle.Color.Equals(Color.Empty))
                {
                    pen.Color = TabControl.DefaultTabPageBorderStyle.Color;
                    pen.Width = TabControl.DefaultTabPageBorderStyle.Width;
                }

                if (!pen.Color.Equals(Color.Empty))
                {
                    gfx.DrawLine(pen, tabPageRect.X, tabPageRect.Y, tabPageRect.X + tabPageRect.Width, tabPageRect.Y);
                    topBorderWidth = (int)pen.Width;
                }

                pen.Color = Color.Empty;
                pen.Width = 1;

                //绘制底部边框
                if (TabControl.TabPageBottomBorderStyle != null && !TabControl.TabPageBottomBorderStyle.Color.Equals(Color.Empty))
                {
                    pen.Color = TabControl.TabPageBottomBorderStyle.Color;
                    pen.Width = TabControl.TabPageBottomBorderStyle.Width;
                }
                else if (TabControl.DefaultTabPageBorderStyle != null && !TabControl.DefaultTabPageBorderStyle.Color.Equals(Color.Empty))
                {
                    pen.Color = TabControl.DefaultTabPageBorderStyle.Color;
                    pen.Width = TabControl.DefaultTabPageBorderStyle.Width;
                }

                if (!pen.Color.Equals(Color.Empty))
                {
                    gfx.DrawLine(pen, tabPageRect.X, tabPageRect.Y + tabPageRect.Height,
                        tabPageRect.X + tabPageRect.Width, tabPageRect.Y + tabPageRect.Height);

                    bottomBorderWidth = (int)pen.Width;
                }

                pen.Color = Color.Empty;
                pen.Width = 1;

                //绘制右部边框
                if (TabControl.TabPageRightBorderStyle != null && !TabControl.TabPageRightBorderStyle.Color.Equals(Color.Empty))
                {
                    pen.Color = TabControl.TabPageRightBorderStyle.Color;
                    pen.Width = TabControl.TabPageRightBorderStyle.Width;
                }
                else if (TabControl.DefaultTabPageBorderStyle != null && !TabControl.DefaultTabPageBorderStyle.Color.Equals(Color.Empty))
                {
                    pen.Color = TabControl.DefaultTabPageBorderStyle.Color;
                    pen.Width = TabControl.DefaultTabPageBorderStyle.Width;
                }

                if (!pen.Color.Equals(Color.Empty))
                    gfx.DrawLine(pen, tabPageRect.X + tabPageRect.Width, tabPageRect.Y + TabControl.TabPageAreaPadding.Top,
                        tabPageRect.X + tabPageRect.Width, tabPageRect.Y + tabPageRect.Height + bottomBorderWidth / 2);

                pen.Color = Color.Empty;
                pen.Width = 1;

                //绘制左部边框
                if (TabControl.TabPageLeftBorderStyle != null && !TabControl.TabPageLeftBorderStyle.Color.Equals(Color.Empty))
                {
                    pen.Color = TabControl.TabPageLeftBorderStyle.Color;
                    pen.Width = TabControl.TabPageLeftBorderStyle.Width;
                }
                else if (TabControl.DefaultTabPageBorderStyle != null && !TabControl.DefaultTabPageBorderStyle.Color.Equals(Color.Empty))
                {
                    pen.Color = TabControl.DefaultTabPageBorderStyle.Color;
                    pen.Width = TabControl.DefaultTabPageBorderStyle.Width;
                }

                if (!pen.Color.Equals(Color.Empty))
                {
                    //使用FillRectangle方法以避免使用DrawLine方法造成的绘制左侧边框时宽度不够的情况
                    gfx.FillRectangle(new SolidBrush(pen.Color), new Rectangle(tabPageRect.X, tabPageRect.Y, (int)pen.Width, tabPageRect.Height - bottomBorderWidth / 2));
                }
            }
        }

        public virtual void OnDrawSmartCloseButton(Graphics gfx, Rectangle closeButtonRct, ButtonState btnState)
        {
            if (!EnableSmartCloseButton)
                return;
            Pen pen = null;
            Pen borderPen = null;
            Brush brush = null;
            switch (btnState)
            {
                case ButtonState.Normal:
                    pen = new Pen(Color.Black);
                    break;
                case ButtonState.Hover:
                    pen = new Pen(Color.Black);
                    borderPen = new Pen(Color.FromArgb(49, 106, 197));
                    brush = new SolidBrush(Color.FromArgb(195, 211, 237));
                    break;
                case ButtonState.Pressed:
                    pen = new Pen(Color.White);
                    borderPen = new Pen(Color.LightGray);
                    brush = new SolidBrush(Color.FromArgb(41, 57, 85));
                    break;
                case ButtonState.Disabled:
                    pen = new Pen(SystemColors.GrayText);
                    break;
            }
            if (brush != null)
            {
                gfx.FillRectangle(brush, closeButtonRct);
                brush.Dispose();
                if (borderPen != null)
                {
                    gfx.DrawRectangle(borderPen, closeButtonRct.Left, closeButtonRct.Top,
                        closeButtonRct.Width - 1, closeButtonRct.Height - 1);
                    borderPen.Dispose();
                }
            }
            if (pen != null)
            {
                // Draw close button lines.
                gfx.DrawLine(pen, closeButtonRct.Left + 3, closeButtonRct.Top + 4,
                    closeButtonRct.Right - 5, closeButtonRct.Bottom - 3);
                gfx.DrawLine(pen, closeButtonRct.Left + 4, closeButtonRct.Top + 4,
                    closeButtonRct.Right - 4, closeButtonRct.Bottom - 3);
                gfx.DrawLine(pen, closeButtonRct.Right - 4, closeButtonRct.Top + 4,
                    closeButtonRct.Left + 4, closeButtonRct.Bottom - 3);
                gfx.DrawLine(pen, closeButtonRct.Right - 5, closeButtonRct.Top + 4,
                    closeButtonRct.Left + 3, closeButtonRct.Bottom - 3);
                pen.Dispose();
            }
        }

        public virtual void OnDrawSmartDropDownButton(Graphics gfx, Rectangle dropdownButtonRct, ButtonState btnState)
        {
            if (!EnableSmartDropDownButton)
                return;
            Pen pen = null;
            Pen borderPen = null;
            Brush brush = null;
            switch (btnState)
            {
                case ButtonState.Normal:
                    pen = new Pen(Color.Black);
                    break;
                case ButtonState.Hover:
                    pen = new Pen(Color.Black);
                    borderPen = new Pen(Color.FromArgb(49, 106, 197));
                    brush = new SolidBrush(Color.FromArgb(195, 211, 237));
                    break;
                case ButtonState.Pressed:
                    pen = new Pen(Color.White);
                    borderPen = new Pen(Color.LightGray);
                    brush = new SolidBrush(Color.FromArgb(41, 57, 85));
                    break;
                case ButtonState.Disabled:
                    pen = new Pen(SystemColors.GrayText);
                    break;
            }
            if (brush != null)
            {
                gfx.FillRectangle(brush, dropdownButtonRct);
                brush.Dispose();
                if (borderPen != null)
                {
                    gfx.DrawRectangle(borderPen, dropdownButtonRct.Left, dropdownButtonRct.Top,
                        dropdownButtonRct.Width - 1, dropdownButtonRct.Height - 1);
                    borderPen.Dispose();
                }
            }
            if (pen != null)
            {
                using (Brush fill = new SolidBrush(pen.Color))
                {
                    gfx.FillPolygon(fill, new Point[]
                    {
                        new Point(dropdownButtonRct.Left + 3, dropdownButtonRct.Top + 6),
                        new Point(dropdownButtonRct.Right - 3, dropdownButtonRct.Top + 6),
                        new Point(dropdownButtonRct.Left + dropdownButtonRct.Width / 2, dropdownButtonRct.Bottom - 3)});
                }
                pen.Dispose();
            }
        }

        #endregion

        #region 虚方法

        public abstract void InvokeEditor();

        /// <summary>
        /// 绘制控件背景
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="clientRct"></param>
        public abstract void OnRendererBackground(Graphics gfx, Rectangle clientRct);

        public virtual void OnRendererTabPageItem(Graphics gfx, Rectangle tabPageItemRct, string tabPageText, int index, ButtonState btnState)
        {
            Rectangle itemRct = tabPageItemRct;

            using (StringFormat format = new StringFormat(StringFormatFlags.LineLimit))
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                format.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;

                //背景色
                Color backColor = Color.Empty;

                //边框颜色
                Color borderColor = Color.Empty;

                //前景色
                Color foreColor = Color.Empty;

                //图标
                Image image = null;

                //边框宽度
                int borderWidth = 0;

                if (btnState.Equals(ButtonState.Hover))
                {
                    //设置背景色，如果没有指定悬浮背景色，则使用正常选项卡的
                    if (TabControl.TabItemHoverBackColor != null && !TabControl.TabItemHoverBackColor.Equals(Color.Empty))
                        backColor = TabControl.TabItemHoverBackColor;
                    else if (TabControl.TabItemBackColor != null && !TabControl.TabItemBackColor.Equals(Color.Empty))
                        backColor = TabControl.TabItemBackColor;

                    //设置图标，如果没有指定悬浮图标，则使用正常选项卡的
                    if (TabControl.TabItemStyle.Equals(TabItemStyle.Image) || TabControl.TabItemStyle.Equals(TabItemStyle.TextAndImage))
                    {
                        NeoTabPage page = TabControl.TabPages[index] as NeoTabPage;

                        if (page != null)
                        {
                            if (page.TabHoverImage != null)
                                image = page.TabHoverImage;
                            else if (page.TabImage != null)
                                image = page.TabImage;
                        }
                    }

                    //设置边框样式，如果没有指定悬浮样式，则使用正常选项卡的
                    if (TabControl.TabItemHoverBorderStyle != null)
                    {
                        if (!TabControl.TabItemHoverBorderStyle.Color.Equals(Color.Empty))
                            borderColor = TabControl.TabItemHoverBorderStyle.Color;

                        borderWidth = TabControl.TabItemHoverBorderStyle.Width;
                    }
                    else if (TabControl.TabItemBorderStyle != null)
                    {
                        if (!TabControl.TabItemBorderStyle.Color.Equals(Color.Empty))
                            borderColor = TabControl.TabItemBorderStyle.Color;

                        borderWidth = TabControl.TabItemBorderStyle.Width;
                    }

                    //设置前景色，如果没有指定悬浮前景色，则使用正常选项卡的
                    if (TabControl.TabItemHoverForeColor != null && !TabControl.TabItemHoverForeColor.Equals(Color.Empty))
                        foreColor = TabControl.TabItemHoverForeColor;
                    else if (TabControl.TabItemForeColor != null && !TabControl.TabItemForeColor.Equals(Color.Empty))
                        foreColor = TabControl.TabItemForeColor;

                    DrawTabItem(gfx, itemRct, tabPageText, backColor, borderColor, borderWidth, foreColor, image, format);
                }
                else if (btnState.Equals(ButtonState.Normal))
                {
                    //设置背景色
                    if (TabControl.TabItemBackColor != null && !TabControl.TabItemBackColor.Equals(Color.Empty))
                        backColor = TabControl.TabItemBackColor;

                    //设置图标，如果没有指定悬浮图标，则使用正常选项卡的
                    if (TabControl.TabItemStyle.Equals(TabItemStyle.Image) || TabControl.TabItemStyle.Equals(TabItemStyle.TextAndImage))
                    {
                        NeoTabPage page = TabControl.TabPages[index] as NeoTabPage;

                        if (page != null && page.TabImage != null)
                        {
                            image = page.TabImage;
                        }
                    }

                    //设置边框样式
                    if (TabControl.TabItemBorderStyle != null)
                    {
                        if (!TabControl.TabItemBorderStyle.Color.Equals(Color.Empty))
                            borderColor = TabControl.TabItemBorderStyle.Color;

                        borderWidth = TabControl.TabItemBorderStyle.Width;
                    }

                    //设置前景色，如果没有指定悬浮前景色，则使用正常选项卡的
                    if (TabControl.TabItemForeColor != null && !TabControl.TabItemForeColor.Equals(Color.Empty))
                        foreColor = TabControl.TabItemForeColor;

                    DrawTabItem(gfx, itemRct, tabPageText, backColor, borderColor, borderWidth, foreColor, image, format);
                }
                else if (btnState.Equals(ButtonState.Pressed))
                {
                    //设置背景色，如果没有指定活动选项卡背景色，则使用正常选项卡的
                    if (TabControl.TabItemActiveBackColor != null && !TabControl.TabItemActiveBackColor.Equals(Color.Empty))
                        backColor = TabControl.TabItemActiveBackColor;
                    else if (TabControl.TabItemBackColor != null && !TabControl.TabItemBackColor.Equals(Color.Empty))
                        backColor = TabControl.TabItemBackColor;

                    //设置图标，如果没有指定悬浮图标，则使用正常选项卡的
                    if (TabControl.TabItemStyle.Equals(TabItemStyle.Image) || TabControl.TabItemStyle.Equals(TabItemStyle.TextAndImage))
                    {
                        NeoTabPage page = TabControl.TabPages[index] as NeoTabPage;

                        if (page != null)
                        {
                            if (page.TabActiveImage != null)
                                image = page.TabActiveImage;
                            else if (page.TabImage != null)
                                image = page.TabImage;
                        }
                    }

                    //设置边框样式，如果没有指定悬浮样式，则使用正常选项卡的
                    if (TabControl.TabItemActiveBorderStyle != null)
                    {
                        if (!TabControl.TabItemActiveBorderStyle.Color.Equals(Color.Empty))
                            borderColor = TabControl.TabItemActiveBorderStyle.Color;

                        borderWidth = TabControl.TabItemActiveBorderStyle.Width;
                    }
                    else if (TabControl.TabItemBorderStyle != null)
                    {
                        if (!TabControl.TabItemBorderStyle.Color.Equals(Color.Empty))
                            borderColor = TabControl.TabItemBorderStyle.Color;

                        borderWidth = TabControl.TabItemBorderStyle.Width;
                    }

                    //设置前景色，如果没有指定悬浮前景色，则使用正常选项卡的
                    if (TabControl.TabItemActiveForeColor != null && !TabControl.TabItemActiveForeColor.Equals(Color.Empty))
                        foreColor = TabControl.TabItemActiveForeColor;
                    else if (TabControl.TabItemForeColor != null && !TabControl.TabItemForeColor.Equals(Color.Empty))
                        foreColor = TabControl.TabItemForeColor;

                    DrawTabItem(gfx, itemRct, tabPageText, backColor, borderColor, borderWidth, foreColor, image, format);
                }
                else if (btnState.Equals(ButtonState.Disabled))
                {
                    //设置背景色，如果没有指定悬浮背景色，则使用正常选项卡的
                    if (TabControl.TabItemDisabledBackColor != null && !TabControl.TabItemDisabledBackColor.Equals(Color.Empty))
                        backColor = TabControl.TabItemDisabledBackColor;
                    else if (TabControl.TabItemBackColor != null && !TabControl.TabItemBackColor.Equals(Color.Empty))
                        backColor = TabControl.TabItemBackColor;

                    //设置图标，如果没有指定悬浮图标，则使用正常选项卡的
                    if (TabControl.TabItemStyle.Equals(TabItemStyle.Image) || TabControl.TabItemStyle.Equals(TabItemStyle.TextAndImage))
                    {
                        NeoTabPage page = TabControl.TabPages[index] as NeoTabPage;

                        if (page != null)
                        {
                            if (page.TabDistabledImage != null)
                                image = page.TabDistabledImage;
                            else if (page.TabImage != null)
                                image = page.TabImage;
                        }
                    }

                    //设置边框样式，如果没有指定悬浮样式，则使用正常选项卡的
                    if (TabControl.TabItemDisabledBorderStyle != null)
                    {
                        if (!TabControl.TabItemDisabledBorderStyle.Color.Equals(Color.Empty))
                            borderColor = TabControl.TabItemDisabledBorderStyle.Color;

                        borderWidth = TabControl.TabItemDisabledBorderStyle.Width;
                    }
                    else if (TabControl.TabItemBorderStyle != null)
                    {
                        if (!TabControl.TabItemBorderStyle.Color.Equals(Color.Empty))
                            borderColor = TabControl.TabItemBorderStyle.Color;

                        borderWidth = TabControl.TabItemBorderStyle.Width;
                    }

                    //设置前景色，如果没有指定悬浮前景色，则使用正常选项卡的
                    if (TabControl.TabItemDisabledForeColor != null && !TabControl.TabItemDisabledForeColor.Equals(Color.Empty))
                        foreColor = TabControl.TabItemDisabledForeColor;
                    else if (TabControl.TabItemForeColor != null && !TabControl.TabItemForeColor.Equals(Color.Empty))
                        foreColor = TabControl.TabItemForeColor;

                    DrawTabItem(gfx, itemRct, tabPageText, backColor, borderColor, borderWidth, foreColor, image, format);
                }
            }
        }

        private void DrawTabItem(Graphics gfx, Rectangle itemRect, string tabPageText, Color backColor,
            Color borderColor, int borderWidth, Color foreColor, Image image, StringFormat format1)
        {
            using (StringFormat format = new StringFormat(StringFormatFlags.LineLimit))
            {
                format.LineAlignment = StringAlignment.Center;
                format.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;

                //绘制选项卡背景色
                if (!backColor.Equals(Color.Empty))
                {
                    using (Brush brush = new SolidBrush(backColor))
                    {
                        gfx.FillRectangle(brush, itemRect);
                    }
                }

                //绘制图标及文字
                if (TabControl.TabItemStyle.Equals(TabItemStyle.Image))
                {
                    //gfx.DrawImage(image, itemRect.Left + TabControl.TabContentSpacing,
                    //    itemRect.Top + TabControl.TabContentSpacing, image.Width, image.Height);
                    gfx.DrawImage(image, itemRect.Left + itemRect.Width / 2 - image.Width / 2,
                            itemRect.Top + itemRect.Height / 2 - image.Height / 2,
                            image.Width, image.Height);
                }
                else if (TabControl.TabItemStyle.Equals(TabItemStyle.Text) && !string.IsNullOrEmpty(tabPageText))
                {
                    format.Alignment = StringAlignment.Center;

                    using (Brush brush = new SolidBrush(foreColor))
                    {
                        gfx.DrawString(tabPageText, TabControl.TabItemFont, brush,
                            itemRect, format);
                    }
                }
                else if (TabControl.TabItemStyle.Equals(TabItemStyle.TextAndImage))
                {
                    if (TabControl.TextImageRelation.Equals(TextImageRelation.ImageBeforeText))
                    {
                        gfx.DrawImage(image, itemRect.Left + TabControl.TabContentSpacing,
                            itemRect.Top + itemRect.Height / 2 - image.Height / 2, image.Width, image.Height);

                        format.LineAlignment = StringAlignment.Center;

                        using (Brush brush = new SolidBrush(foreColor))
                        {
                            Rectangle rect = new Rectangle(itemRect.Left + TabControl.TabContentSpacing + image.Width,
                                itemRect.Y,
                                itemRect.Width - TabControl.TabContentSpacing - image.Width,
                                itemRect.Height);

                            //gfx.DrawString(tabPageText, TabControl.TabItemFont, brush,
                            //    itemRect.Left + TabControl.TabContentSpacing * 2 + image.Width,
                            //    itemRect.Top + TabControl.TabContentSpacing,sf);

                            gfx.DrawString(tabPageText, TabControl.TabItemFont, brush, rect, format);
                        }
                    }
                    else if (TabControl.TextImageRelation.Equals(TextImageRelation.TextBeforeImage))
                    {
                        format.LineAlignment = StringAlignment.Center;

                        using (Brush brush = new SolidBrush(foreColor))
                        {
                            Rectangle rect = new Rectangle(itemRect.Left,
                                itemRect.Y,
                                itemRect.Width - TabControl.TabContentSpacing - image.Width,
                                itemRect.Height);

                            //gfx.DrawString(tabPageText, TabControl.TabItemFont, brush,
                            //    itemRect.Left + TabControl.TabContentSpacing,
                            //    itemRect.Top + TabControl.TabContentSpacing);

                            gfx.DrawString(tabPageText, TabControl.TabItemFont, brush, rect, format);
                        }

                        gfx.DrawImage(image, itemRect.Right - TabControl.TabContentSpacing - image.Width,
                            itemRect.Top + itemRect.Height / 2 - image.Height / 2, image.Width, image.Height);
                    }
                    else if (TabControl.TextImageRelation.Equals(TextImageRelation.TextAboveImage))
                    {
                        format.Alignment = StringAlignment.Center;

                        using (Brush brush = new SolidBrush(foreColor))
                        {
                            Rectangle rect = new Rectangle(itemRect.Left, itemRect.Top,
                                itemRect.Width,
                                itemRect.Height - TabControl.TabContentSpacing - image.Height);

                            gfx.DrawString(tabPageText, TabControl.TabItemFont, brush, rect, format);
                        }

                        gfx.DrawImage(image, itemRect.Left + itemRect.Width / 2 - image.Width / 2,
                            itemRect.Bottom - TabControl.TabContentSpacing - image.Height,
                            image.Width, image.Height);
                    }
                    else if (TabControl.TextImageRelation.Equals(TextImageRelation.ImageAboveText))
                    {
                        gfx.DrawImage(image, itemRect.Left + itemRect.Width / 2 - image.Width / 2,
                            itemRect.Top + TabControl.TabContentSpacing,
                            image.Width, image.Height);

                        format.Alignment = StringAlignment.Center;

                        using (Brush brush = new SolidBrush(foreColor))
                        {
                            Rectangle rect = new Rectangle(itemRect.Left,
                                itemRect.Top +TabControl.TabContentSpacing+ image.Height,
                                itemRect.Width,
                                itemRect.Height - TabControl.TabContentSpacing - image.Height);

                            gfx.DrawString(tabPageText, TabControl.TabItemFont, brush, rect, format);
                        }
                    }
                    else if (TabControl.TextImageRelation.Equals(TextImageRelation.Overlay))
                    {
                        gfx.DrawImage(image, itemRect.Left + itemRect.Width / 2 - image.Width / 2,
                            itemRect.Top + itemRect.Height / 2 - image.Height / 2,
                            image.Width, image.Height);

                        format.Alignment = StringAlignment.Center;

                        using (Brush brush = new SolidBrush(foreColor))
                        {
                            gfx.DrawString(tabPageText, TabControl.TabItemFont, brush, itemRect, format);
                        }
                    }
                }

                //绘制边框
                if (!borderColor.Equals(Color.Empty) && borderWidth > 0)
                {
                    itemRect.Width -= borderWidth;
                    itemRect.Height -= borderWidth;

                    using (Pen pen = new Pen(borderColor, borderWidth))
                    {
                        gfx.DrawRectangle(pen, itemRect);
                    }
                }
            }
        }

        #endregion

        #region IDisposable 成员

        public abstract void Dispose();

        #endregion
    }
}