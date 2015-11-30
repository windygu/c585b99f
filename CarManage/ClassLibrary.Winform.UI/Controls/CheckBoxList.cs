using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

//using DHGateAssistant.Utility.Form;

namespace ClassLibrary.Winform.UI.Controls
{
    /// <summary>
    /// 产品属性复选列表控件
    /// </summary>s
    public class CheckBoxList : Panel
    {
        #region 私有变量/属性

        private int additionalWidth;

        private int additionalHeight;

        /// <summary>
        /// X坐标
        /// </summary>
        private int x;

        /// <summary>
        /// Y坐标
        /// </summary>
        private int y;

        /// <summary>
        /// 当前Y坐标
        /// </summary>
        private int customerY;

        /// <summary>
        /// 列表项集合
        /// </summary>
        private List<ListControlItem> itemList;

        /// <summary>
        /// 选中项集合
        /// </summary>
        private List<ListControlItem> selectedItem;

        #endregion

        #region 公共变量/属性

        /// <summary>
        /// 文本属性名称
        /// </summary>
        public string DataTextField { get; set; }

        /// <summary>
        /// 值属性名称
        /// </summary>
        public string DataValueField { get; set; }

        /// <summary>
        /// 当控件中的复选框Checked属性发生改变时引发的事件
        /// </summary>
        public event EventHandler OnChecked;

        /// <summary>
        /// 选中项集合
        /// </summary>
        [Bindable(false), Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<ListControlItem> SelectedItem
        {
            get
            {
                List<ListControlItem> items = new List<ListControlItem>();

                foreach (Control control in this.Controls)
                {
                    if (!control.Name.StartsWith("chk_"))
                        continue;

                    ClassLibrary.Winform.UI.Controls.CheckBox chk =
                        control as ClassLibrary.Winform.UI.Controls.CheckBox;

                    if (chk == null || !chk.Checked)
                        continue;

                    items.Add(new ListControlItem()
                    {
                        Text = chk.Text,
                        Value = chk.Value
                    });
                }

                return items;
            }
        }

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public CheckBoxList()
            : base()
        {
            additionalWidth = 25;
            additionalHeight = 5;
            x = 0;
            y = 0;
            customerY = 0;

            itemList = new List<ListControlItem>();
            selectedItem = new List<ListControlItem>();
        }

        #endregion

        #region 事件

        void chk_CheckedChanged(object sender, EventArgs e)
        {
            ClassLibrary.Winform.UI.Controls.CheckBox chk =
                sender as ClassLibrary.Winform.UI.Controls.CheckBox;

            if (chk == null)
                return;

            if (OnChecked != null)
                OnChecked(sender, e);
        }

        #endregion

        #region 公共方法

        public void ClearItems()
        {
            itemList.Clear();

            this.Controls.Clear();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        public void DataBind<T>(ICollection<T> dataSource)
        {
            ClearItems();

            if (dataSource.Count.Equals(0))
                return;

            List<ListControlItem> list = new List<ListControlItem>();
            Type type = typeof(T);
            PropertyInfo textProperty = type.GetProperty(DataTextField);
            PropertyInfo valueProperty = type.GetProperty(DataValueField);

            if (textProperty == null || valueProperty == null)
                return;

            if (dataSource is Dictionary<string, string>)
            {
                Dictionary<string, string> dicDataSource =
                    dataSource as Dictionary<string, string>;

                foreach (KeyValuePair<string, string> pair in dicDataSource)
                {
                    ListControlItem item = new ListControlItem();

                    if (DataTextField.Equals("Key", StringComparison.OrdinalIgnoreCase))
                    {
                        item.Text = pair.Key;
                        item.Value = pair.Value;
                    }

                    if (DataTextField.Equals("Value", StringComparison.OrdinalIgnoreCase))
                    {
                        item.Text = pair.Value;
                        item.Value = pair.Key;
                    }

                    list.Add(item);
                }
            }
            else
            {
                foreach (T item in dataSource)
                {
                    list.Add(new ListControlItem
                    {
                        Text = textProperty.GetValue(item, null).ToString(),
                        Value = valueProperty.GetValue(item, null).ToString()
                    });
                }
            }

            int index = 0;
            this.Height = 0;
            x = y = 0;
            customerY = 0;

            foreach (ListControlItem item in list)
            {
                ClassLibrary.Winform.UI.Controls.CheckBox chk =
                    new ClassLibrary.Winform.UI.Controls.CheckBox();

                chk.Name = "chk_" + item.Value;
                chk.Text = item.Text;
                chk.Value = item.Value;
                chk.CheckedChanged += new EventHandler(chk_CheckedChanged);

                chk.Size = GetCheckBoxSize(chk);

                if (this.Width - x < chk.Size.Width)
                {
                    x = 0;
                    y += chk.Height;
                }

                chk.Location = new System.Drawing.Point(x, y);

                x += chk.Width;
                this.Controls.Add(chk);

                if (index.Equals(list.Count - 1))
                {
                    y += chk.Height;
                }

                index++;
            }

            customerY = y;

            this.Height = y;
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 获取复选框尺寸
        /// </summary>
        /// <param name="chk">复选框</param>
        /// <returns></returns>
        private Size GetCheckBoxSize(ClassLibrary.Winform.UI.Controls.CheckBox chk)
        {
            Size size = new Size();
            Graphics g = CreateGraphics();
            g.PageUnit = GraphicsUnit.Pixel;
            StringFormat format = StringFormat.GenericTypographic;
            format.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
            SizeF sizeF = g.MeasureString(chk.Text, chk.Font, 0, format);

            size.Width = (int)Math.Ceiling(sizeF.Width) + additionalWidth;
            size.Height = (int)Math.Ceiling(sizeF.Height) + additionalHeight;

            g.Dispose();

            return size;
        }

        #endregion
    }
}
