using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using ClassLibrary.Winform.UI.Common;

namespace ClassLibrary.Winform.UI.Controls
{
    [ToolboxBitmap(typeof(System.Windows.Forms.DataGridView))]
    public partial class DataGridView : System.Windows.Forms.DataGridView
    {
        #region 属性

        /// <summary>
        /// 是否绘制行标
        /// </summary>
        private bool paintRowNumber = false;

        /// <summary>
        /// 复选框边框颜色
        /// </summary>
        [Browsable(true),
        Category(ControlManager.CustomPropertyCategory),
        DefaultValue("Color.FromArgb(243,92,47)"),
        Description("复选框边框颜色")]
        public Color CheckBoxBorderColor { get; set; }

        /// <summary>
        /// 复选框选中状态图标
        /// </summary>
        [Browsable(true),
        Category(ControlManager.CustomPropertyCategory),
        Description("复选框选中状态图标")]
        public Image CheckedImage { get; set; }

        /// <summary>
        /// 列表头背景图片
        /// </summary>
        [Browsable(true),
        Category(ControlManager.CustomPropertyCategory),
        Description("列表头背景图片")]
        public Image ColumnHeaderBackgroundImage { get; set; }

        /// <summary>
        /// 获取或设置在RowHeader上是否绘制行标
        /// </summary>
        [Category(ControlManager.CustomPropertyCategory),
        Browsable(true), Description("在RowHeader上是否绘制行标")]
        public Boolean PaintRowNumber
        {
            get { return this.paintRowNumber; }
            set { this.paintRowNumber = value; }
        }

        /// <summary>
        /// 获取或设置“选择全部”列的列名,确保此列为DataGridViewCheckBoxColumn,
        /// 若给次属性指定列名，则会为此列在表头增加“选择全部”复选框
        /// </summary>
        private string checkAllColumnName = string.Empty;
        [Browsable(true),
        Category(ControlManager.CustomPropertyCategory),
        DefaultValue(""),
        Description("“选择全部”列的列名")]
        public string CheckAllColumnName
        {
            get { return checkAllColumnName; }
            set { checkAllColumnName = value; }
        }

        /// <summary>
        /// 当点击表头全选复选框时引发的事件
        /// </summary>
        [Browsable(true), Description("当点击表头全选复选框时引发的事件")]
        public event DataGridViewCheckBoxHeaderEventHander OnCheckedAllClick;

        public bool CheckedAll { get; set; }

        /// <summary>
        /// 全选表头单元格
        /// </summary>
        private CheckBoxColumnHeaderCell checkAllHeaderCell;

        #endregion

        #region 构造函数

        /// <summary>
        /// 
        /// </summary>
        public DataGridView()
            : base()
        {
            //base.CellPainting += new DataGridViewCellPaintingEventHandler(Base_CellPainting);
            //base.MouseDown += new MouseEventHandler(Base_MouseDown);
            //base.CellClick += new DataGridViewCellEventHandler(Base_CellClick);
            base.AutoGenerateColumns = false;
            base.AllowUserToDeleteRows = false;
            base.AllowUserToResizeRows = false;
            base.RowHeadersVisible = false;
            this.PaintRowNumber = false;
            this.BackColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            //this.CheckBoxBorderColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            //this.CheckedImage = DHGateAssistant.Resource.Common.ImageResource.check;
            InitializeComponent();
        }

        /// <summary>
        /// 当选中箭头时，选中整行数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Base_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            if (base.Columns[e.ColumnIndex].Name == "colListArrow")
            {
                base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                base.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Base_MouseDown(object sender, MouseEventArgs e)
        {
            int intColumnIndex = HitTest(e.X, e.Y).ColumnIndex;

            if (intColumnIndex == -1)
                return;

            if (base.Columns[intColumnIndex].Name == "colListArrow")
            {
                base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                base.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            }
        }

        /// <summary>
        /// 重绘单元格复选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Base_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                Rectangle newRect = new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, 
                    e.CellBounds.Width - 14, e.CellBounds.Height - 13);

                string checkFlag = string.Empty;

                using (Brush gridBrush = new SolidBrush(base.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    if (base.ColumnHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    {
                        using (Pen gridLinePen = new Pen(gridBrush))
                        {
                            // 填充单元格背景色
                            e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                            //绘制单元格边框线
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom - 1);
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                                e.CellBounds.Top, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom);
                        }
                    }

                    using (Pen borderLinePen = new Pen(this.CheckBoxBorderColor))
                    {
                        //绘制复选框
                        e.Graphics.DrawRectangle(borderLinePen, newRect);

                        //当复选框选中状态为checked时，绘制选中图标
                        if (base.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
                        {
                            checkFlag = "√";
                            //e.Graphics.DrawImage(CheckedImage, newRect);
                        }
                        else if (base.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "False")
                        {
                            checkFlag = "";
                        }

                        e.Graphics.DrawString(checkFlag, new Font("Arial", 10), new SolidBrush(Color.Black), e.CellBounds.X + 6, e.CellBounds.Y + 6);
                    }

                    e.Handled = true;
                }
            }
        }

        #endregion

        /// <summary>
        /// 自定义，绘制行标
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);

            if (this.paintRowNumber && base.RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
            {
                using (SolidBrush b = new SolidBrush(base.RowHeadersDefaultCellStyle.ForeColor))
                {
                    e.Graphics.DrawString(((Int32)(e.RowIndex + 1)).ToString(System.Globalization.CultureInfo.CurrentUICulture),
                        e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 16, e.RowBounds.Location.Y + 4);
                }
            }
        }

        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            base.OnDataBindingComplete(e);
            //SetHeaderColor(System.Drawing.Color.FromArgb(235, 245, 255));
            InitDataGridViewList();
        }

        #region 自定义方法

        /// <summary>
        /// 设置箭头列
        /// </summary>
        public void SetArrowColumn()
        {
            System.Windows.Forms.DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "colListArrow";
            imageColumn.HeaderText = "";
            imageColumn.Frozen = true;
            imageColumn.ReadOnly = true;
            imageColumn.Width = 30;
            imageColumn.Resizable = DataGridViewTriState.False;
            base.Columns.Insert(0, imageColumn);
        }

        /// <summary>
        /// 禁止所有数据列排序
        /// </summary>
        public void DisabledAllColumnsSort()
        {
            foreach (DataGridViewColumn column in this.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// 设置头部背景颜色
        /// </summary>
        /// <param name="color"></param>
        private void SetHeaderColor(System.Drawing.Color color)
        {
            this.EnableHeadersVisualStyles = false;

            this.RowHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));

            this.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
        }

        /// <summary>
        /// 初始化页面控件
        /// </summary>
        private void InitDataGridViewList()
        {
            if (string.IsNullOrEmpty(PaintRowNumber.ToString()))
                return;

            //CommonMethod.SetGridViewColumns(this);

            if (string.IsNullOrEmpty(checkAllColumnName) || !this.Columns.Contains(checkAllColumnName))
                return;

            //if (checkAllHeaderCell == null)
            //{
            //    checkAllHeaderCell = new CheckBoxColumnHeaderCell(this, 
            //        this.Columns[checkAllColumnName].Index, CheckedAll);

            //    checkAllHeaderCell.OnCheckBoxClicked += new DataGridViewCheckBoxHeaderEventHander(
            //        chkheadercell_OnCheckBoxClicked);
            //}

            CheckBoxColumnHeaderCell c = new CheckBoxColumnHeaderCell(this,
                    this.Columns[checkAllColumnName].Index, CheckedAll);

            c.OnCheckBoxClicked += new DataGridViewCheckBoxHeaderEventHander(
                chkheadercell_OnCheckBoxClicked);

            this.Columns[checkAllColumnName].Width = 30;

            foreach (DataGridViewColumn column in this.Columns)
            {
                if (column.Index == this.Columns[checkAllColumnName].Index)
                    column.ReadOnly = false;
            }
        }

        void chkheadercell_OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            if (OnCheckedAllClick != null)
                OnCheckedAllClick(sender, e);
        }

        #endregion

        private void DataGridView_CellPainting(object sender,
            DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && ColumnHeaderBackgroundImage != null)
            {
                int x = e.CellBounds.X;
                int y = e.CellBounds.Y;
                int width = e.CellBounds.Width;
                int height = e.CellBounds.Height;

                TextureBrush brush = new TextureBrush(ColumnHeaderBackgroundImage);

                e.Graphics.FillRectangle(brush, new Rectangle(x, y, width, height));

                #region 边框

                //Pen borderPen = new Pen(Color.FromArgb(190, 190, 190));//边框颜色

                ////画表头边框
                //if (e.ColumnIndex == 0)
                //{
                //    e.Graphics.DrawRectangle(borderPen,
                //        new Rectangle(x, y + 1, width - 1, height - 2));
                //}
                //else
                //{
                //    e.Graphics.DrawRectangle(borderPen,
                //        new Rectangle(x - 1, y + 1, width, height - 2));
                //}

                #endregion

                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }
    }
    /// <summary>
    /// 自定义CustomCheckBoxColumn模板类型
    /// </summary>
    public class CustomCheckBoxColumn : DataGridViewCheckBoxColumn
    {
        public CustomCheckBoxColumn()
        {
            this.CellTemplate = new DataGridViewCheckBoxChangeBorderCell();
        }
    }

    /// <summary>
    /// 继承datagridview的DataGridViewCheckBoxCell
    /// 自定义DataGridViewCheckBoxChangeBorderCell复选框，实现更改边框颜色
    /// </summary>
    public class DataGridViewCheckBoxChangeBorderCell : DataGridViewCheckBoxCell
    {
        /// <summary>
        /// 边框颜色
        /// </summary>
        private Color borderColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        /// <summary>
        /// 重写clone方法，可以自定义datagridview模板类型添加某些属性
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            DataGridViewCheckBoxChangeBorderCell cell =
                (DataGridViewCheckBoxChangeBorderCell)base.Clone();

            return cell;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public DataGridViewCheckBoxChangeBorderCell()
        {

        }

        /// <summary>
        /// 重写Paint，绘制checkbox复选框边框
        /// </summary>
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds,
            int rowIndex, DataGridViewElementStates elementState, object value,
            object formattedValue, string errorText, DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            Rectangle checkBoxArea = new Rectangle(cellBounds.X + ((cellBounds.Width - 10) / 2) - 2, cellBounds.Y + 5, 12, 12);
            graphics.DrawRectangle(new Pen(borderColor, 1f), checkBoxArea);

        }
    }

    public class DataGridViewCheckboxHeaderEventArgs : EventArgs
    {
        private bool checkedState = false;

        public bool CheckedState
        {
            get { return checkedState; }
            set { checkedState = value; }
        }
    }

    //定义触发单击事件的委托

    public delegate void DataGridViewCheckBoxHeaderEventHander(object sender, DataGridViewCheckboxHeaderEventArgs e);


    class DataGridViewCheckboxHeaderCell : DataGridViewColumnHeaderCell
    {
        Point checkBoxLocation;
        Size checkBoxSize;
        bool isChecked = false;

        Point cellLocation = new Point();
        System.Windows.Forms.VisualStyles.CheckBoxState state = System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;

        public event DataGridViewCheckBoxHeaderEventHander OnCheckBoxClicked;

        public DataGridViewCheckboxHeaderCell(bool isChecked)
        {
            this.isChecked = isChecked;
        }

        public DataGridViewCheckboxHeaderCell()
        {

        }

        //绘制列头checkbox
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                dataGridViewElementState, value,
                formattedValue, errorText, cellStyle,
               advancedBorderStyle, paintParts);

            Point point = new Point();
            Size size = CheckBoxRenderer.GetGlyphSize(graphics, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);

            point.X = cellBounds.Location.X + (cellBounds.Width / 2) - (size.Width / 2) - 1;//列头checkbox的X坐标
            point.Y = cellBounds.Location.Y + (cellBounds.Height / 2) - (size.Height / 2);//列头checkbox的Y坐标

            cellLocation = cellBounds.Location;
            checkBoxLocation = point;
            checkBoxSize = size;

            if (isChecked)
                state = System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal;
            else
                state = System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;

            CheckBoxRenderer.DrawCheckBox(graphics, checkBoxLocation, state);
        }

        /// <summary>
        /// 点击列头checkbox单击事件
        /// </summary>
        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            Point point = new Point(e.X + cellLocation.X, e.Y + cellLocation.Y);

            if (point.X >= checkBoxLocation.X && point.X <= checkBoxLocation.X + checkBoxSize.Width
                && point.Y >= checkBoxLocation.Y && point.Y <= checkBoxLocation.Y + checkBoxSize.Height)
            {
                isChecked = !isChecked;

                //获取列头checkbox的选择状态

                DataGridViewCheckboxHeaderEventArgs args = new DataGridViewCheckboxHeaderEventArgs();
                args.CheckedState = isChecked;

                object sender = new object();//此处不代表选择的列头checkbox，只是作为参数传递。应该列头checkbox是绘制出来的，无法获得它的实例

                if (OnCheckBoxClicked != null)
                {
                    OnCheckBoxClicked(sender, args);//触发单击事件

                    try
                    {
                        if (this != null && this.DataGridView != null)
                        {
                            this.DataGridView.InvalidateCell(this); //列头checkbox无效，不能是Datagridview列无效

                            DataGridViewCell currentCell = this.DataGridView.CurrentCell;

                            this.DataGridView.CurrentCell = null;

                            if (currentCell != null)
                                this.DataGridView.CurrentCell = currentCell;
                        }
                    }
                    catch
                    {

                    }
                }
            }

            base.OnMouseClick(e);
        }
    }

    public class CheckBoxColumnHeaderCell
    {
        private System.Windows.Forms.DataGridView gridView;
        private int chkColumnIndex; //checkbox列的索引
        private bool checkedAll;

        public event DataGridViewCheckBoxHeaderEventHander OnCheckBoxClicked;

        public System.Windows.Forms.DataGridView BindDataGridView
        {
            get { return gridView; }
            set { gridView = value; }

        }

        public int BindColumIndex
        {
            get { return chkColumnIndex; }
            set { chkColumnIndex = value; }

        }

        public CheckBoxColumnHeaderCell(System.Windows.Forms.DataGridView gridView, int columnIndex)
        {
            this.gridView = gridView;
            chkColumnIndex = columnIndex;

            InitDataGridViewHeaderCell(this, null);

            BindDataGridView.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(InitDataGridViewHeaderCell);
            BindDataGridView.CellContentClick += new DataGridViewCellEventHandler(BindDataGridView_CellContentClick);
            BindDataGridView.CellClick += new DataGridViewCellEventHandler(BindDataGridView_CellClick);
        }

        public CheckBoxColumnHeaderCell(System.Windows.Forms.DataGridView gridView, int columnIndex, bool checkedAll)
        {
            this.gridView = gridView;
            chkColumnIndex = columnIndex;
            this.checkedAll = checkedAll;

            InitDataGridViewHeaderCell(this, null);

            BindDataGridView.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(InitDataGridViewHeaderCell);
            BindDataGridView.CellContentClick += new DataGridViewCellEventHandler(BindDataGridView_CellContentClick);
            BindDataGridView.CellClick += new DataGridViewCellEventHandler(BindDataGridView_CellClick);
        }

        private void InitDataGridViewHeaderCell(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewCheckboxHeaderCell chkCell = new DataGridViewCheckboxHeaderCell(checkedAll);
            chkCell.OnCheckBoxClicked += new DataGridViewCheckBoxHeaderEventHander(ch_OnCheckBoxClicked);//关联单击事件

            //设置DataGridViewCheckBoxColumn列索引
            try
            {
                DataGridViewCheckBoxColumn chkColumn = BindDataGridView.Columns[BindColumIndex] as DataGridViewCheckBoxColumn;
                chkColumn.HeaderCell = chkCell;
                chkColumn.HeaderCell.Value = string.Empty;//消除列头checkbox旁出现的文字
            }
            catch
            {
                //throw;
            }
        }

        private void BindDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == BindColumIndex)
                {
                    if (CheckedAll(BindDataGridView, e.RowIndex))
                    {
                        RePaintCheckBox(true);

                    }
                    else
                    {
                        RePaintCheckBox(false);

                    }
                }

                DataGridViewCell currentCell = BindDataGridView.CurrentCell;
                BindDataGridView.CurrentCell = null;
                BindDataGridView.CurrentCell = currentCell;
            }
            catch
            {

            }
        }


        private void BindDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (CheckedAll(BindDataGridView, e.RowIndex))
                    {
                        RePaintCheckBox(true);
                    }
                    else
                    {
                        RePaintCheckBox(false);
                    }
                }

                //DataGridViewCell curcell = BindDataGridView.CurrentCell;
                //BindDataGridView.CurrentCell = null;
                //BindDataGridView.CurrentCell = curcell;
            }
            catch
            {

            }
        }


        private void RePaintCheckBox(bool isChecked)
        {
            DataGridViewCheckboxHeaderCell headerCell = new DataGridViewCheckboxHeaderCell(isChecked);
            headerCell.OnCheckBoxClicked += new DataGridViewCheckBoxHeaderEventHander(ch_OnCheckBoxClicked);//关联单击事件

            try
            {
                DataGridViewCheckBoxColumn chkColumn = BindDataGridView.Columns[BindColumIndex] as DataGridViewCheckBoxColumn;
                chkColumn.HeaderCell = headerCell;
                chkColumn.HeaderCell.Value = string.Empty;
            }
            catch
            {
                //throw;
            }
        }

        private bool CheckedAll(System.Windows.Forms.DataGridView dataGridView, int index)
        {
            bool result = true;

            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    result = Convert.ToBoolean((row.Cells[BindColumIndex]).Value);
                    //if (gdvRow.Index == index)
                    //    flag = !flag;

                    if (result == false)
                    {
                        break;
                    }
                }
            }
            catch
            {

            }

            return result;
        }


        /// <summary>
        /// 单击事件
        /// </summary>
        private void ch_OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            foreach (DataGridViewRow row in BindDataGridView.Rows)
            {
                if (e.CheckedState)
                {
                    row.Cells[BindColumIndex].Value = true;
                }
                else
                {
                    row.Cells[BindColumIndex].Value = false;
                }
            }

            if (OnCheckBoxClicked != null)
                OnCheckBoxClicked(sender, e);
        }
    }
}
