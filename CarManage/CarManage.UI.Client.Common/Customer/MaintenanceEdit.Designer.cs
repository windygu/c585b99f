namespace CarManage.UI.Client.Common.Customer
{
    partial class MaintenanceEdit
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCars = new ClassLibrary.Winform.UI.Controls.DataGridView();
            this.colItemSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoseSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNextDate = new ClassLibrary.Winform.UI.Controls.DateTimePicker(this.components);
            this.dtpDate = new ClassLibrary.Winform.UI.Controls.DateTimePicker(this.components);
            this.cbxCars = new ClassLibrary.Winform.UI.Controls.ComboBox();
            this.dtpPrevDate = new ClassLibrary.Winform.UI.Controls.DateTimePicker(this.components);
            this.txtLoseSales = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.lblMileage1 = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblPrevDate = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblNextDate = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblAmount = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblDate = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblNumber = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblMileage = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblPrevMileage = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.txtMileage = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtAmount = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtPrevMileage = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.tlpCarDetail = new System.Windows.Forms.TableLayoutPanel();
            this.chklstNextMaintenance = new ClassLibrary.Winform.UI.Controls.CheckBoxList();
            this.lblMaintenance = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.chklstMaintenance = new ClassLibrary.Winform.UI.Controls.CheckBoxList();
            this.lblNextMaintenance = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblNextMileage = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.txtNextMileage = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.lblStatus = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.cbxStatus = new ClassLibrary.Winform.UI.Controls.ComboBox();
            this.tlpNext = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.tlpCarDetail.SuspendLayout();
            this.tlpNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AllowUserToResizeRows = false;
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dgvCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCars.CheckBoxBorderColor = System.Drawing.Color.Empty;
            this.dgvCars.CheckedAll = false;
            this.dgvCars.CheckedImage = null;
            this.dgvCars.ColumnHeaderBackgroundImage = null;
            this.dgvCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCars.ColumnHeadersHeight = 21;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemSummary,
            this.colAmount,
            this.colLoseSales,
            this.colDate,
            this.colMileage,
            this.colNextDate,
            this.colNextMileage,
            this.colId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCars.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvCars.Location = new System.Drawing.Point(0, 270);
            this.dgvCars.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.PaintRowNumber = false;
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowTemplate.Height = 30;
            this.dgvCars.Size = new System.Drawing.Size(655, 116);
            this.dgvCars.TabIndex = 62;
            // 
            // colItemSummary
            // 
            this.colItemSummary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colItemSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.colItemSummary.HeaderText = "保养项目";
            this.colItemSummary.Name = "colItemSummary";
            this.colItemSummary.ReadOnly = true;
            this.colItemSummary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAmount.Width = 50;
            // 
            // colLoseSales
            // 
            this.colLoseSales.HeaderText = "失销金额";
            this.colLoseSales.Name = "colLoseSales";
            this.colLoseSales.ReadOnly = true;
            this.colLoseSales.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLoseSales.Width = 60;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "保养日期";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDate.Width = 60;
            // 
            // colMileage
            // 
            this.colMileage.HeaderText = "里程";
            this.colMileage.Name = "colMileage";
            this.colMileage.ReadOnly = true;
            this.colMileage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMileage.Width = 40;
            // 
            // colNextDate
            // 
            this.colNextDate.HeaderText = "下次保养日期";
            this.colNextDate.Name = "colNextDate";
            this.colNextDate.ReadOnly = true;
            this.colNextDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNextDate.Width = 90;
            // 
            // colNextMileage
            // 
            this.colNextMileage.HeaderText = "下次保养里程";
            this.colNextMileage.Name = "colNextMileage";
            this.colNextMileage.ReadOnly = true;
            this.colNextMileage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNextMileage.Width = 90;
            // 
            // colId
            // 
            this.colId.HeaderText = "主键";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // dtpNextDate
            // 
            this.dtpNextDate.AllowDateNull = false;
            this.dtpNextDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNextDate.Checked = false;
            this.dtpNextDate.CustomFormat = " ";
            this.dtpNextDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextDate.Location = new System.Drawing.Point(111, 3);
            this.dtpNextDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNextDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpNextDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpNextDate.Name = "dtpNextDate";
            this.dtpNextDate.Size = new System.Drawing.Size(214, 21);
            this.dtpNextDate.TabIndex = 64;
            // 
            // dtpDate
            // 
            this.dtpDate.AllowDateNull = false;
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = " ";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(111, 30);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(214, 21);
            this.dtpDate.TabIndex = 63;
            // 
            // cbxCars
            // 
            this.cbxCars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCars.BackColor = System.Drawing.Color.White;
            this.cbxCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCars.FormattingEnabled = true;
            this.cbxCars.Location = new System.Drawing.Point(111, 3);
            this.cbxCars.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCars.Name = "cbxCars";
            this.cbxCars.Size = new System.Drawing.Size(214, 20);
            this.cbxCars.TabIndex = 62;
            this.cbxCars.SelectedIndexChanged += new System.EventHandler(this.cbxCars_SelectedIndexChanged);
            // 
            // dtpPrevDate
            // 
            this.dtpPrevDate.AllowDateNull = false;
            this.dtpPrevDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPrevDate.Checked = false;
            this.dtpPrevDate.CustomFormat = " ";
            this.dtpPrevDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPrevDate.Location = new System.Drawing.Point(111, 84);
            this.dtpPrevDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPrevDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpPrevDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpPrevDate.Name = "dtpPrevDate";
            this.dtpPrevDate.Size = new System.Drawing.Size(214, 21);
            this.dtpPrevDate.TabIndex = 54;
            // 
            // txtLoseSales
            // 
            this.txtLoseSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoseSales.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoseSales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoseSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoseSales.BorderWidth = 1;
            this.txtLoseSales.DecimalPrecision = 0;
            this.txtLoseSales.Location = new System.Drawing.Point(438, 57);
            this.txtLoseSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoseSales.MaxLength = 50;
            this.txtLoseSales.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtLoseSales.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtLoseSales.Name = "txtLoseSales";
            this.txtLoseSales.Size = new System.Drawing.Size(215, 21);
            this.txtLoseSales.TabIndex = 53;
            this.txtLoseSales.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Numeric;
            // 
            // lblMileage1
            // 
            this.lblMileage1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMileage1.AutoSize = true;
            this.lblMileage1.Location = new System.Drawing.Point(375, 61);
            this.lblMileage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMileage1.Name = "lblMileage1";
            this.lblMileage1.Size = new System.Drawing.Size(59, 12);
            this.lblMileage1.TabIndex = 22;
            this.lblMileage1.Text = "失销金额:";
            // 
            // lblPrevDate
            // 
            this.lblPrevDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevDate.AutoSize = true;
            this.lblPrevDate.Location = new System.Drawing.Point(24, 88);
            this.lblPrevDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrevDate.Name = "lblPrevDate";
            this.lblPrevDate.Size = new System.Drawing.Size(83, 12);
            this.lblPrevDate.TabIndex = 20;
            this.lblPrevDate.Text = "上次保养日期:";
            // 
            // lblNextDate
            // 
            this.lblNextDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNextDate.AutoSize = true;
            this.lblNextDate.Location = new System.Drawing.Point(24, 7);
            this.lblNextDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextDate.Name = "lblNextDate";
            this.lblNextDate.Size = new System.Drawing.Size(83, 12);
            this.lblNextDate.TabIndex = 10;
            this.lblNextDate.Text = "下次保养日期:";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(72, 61);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(35, 12);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "金额:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(48, 34);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 12);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "保养日期:";
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(60, 7);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 12);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "车牌号:";
            // 
            // lblMileage
            // 
            this.lblMileage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(375, 34);
            this.lblMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(59, 12);
            this.lblMileage.TabIndex = 4;
            this.lblMileage.Text = "保养里程:";
            // 
            // lblPrevMileage
            // 
            this.lblPrevMileage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevMileage.AutoSize = true;
            this.lblPrevMileage.Location = new System.Drawing.Point(351, 88);
            this.lblPrevMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrevMileage.Name = "lblPrevMileage";
            this.lblPrevMileage.Size = new System.Drawing.Size(83, 12);
            this.lblPrevMileage.TabIndex = 12;
            this.lblPrevMileage.Text = "上次保养里程:";
            // 
            // txtMileage
            // 
            this.txtMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMileage.BackColor = System.Drawing.SystemColors.Window;
            this.txtMileage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMileage.BorderWidth = 1;
            this.txtMileage.DecimalPrecision = 0;
            this.txtMileage.Location = new System.Drawing.Point(438, 30);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMileage.MaxLength = 50;
            this.txtMileage.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtMileage.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(215, 21);
            this.txtMileage.TabIndex = 29;
            this.txtMileage.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Integer;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.BorderWidth = 1;
            this.txtAmount.DecimalPrecision = 0;
            this.txtAmount.Location = new System.Drawing.Point(111, 57);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.MaxLength = 255;
            this.txtAmount.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtAmount.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(214, 21);
            this.txtAmount.TabIndex = 30;
            this.txtAmount.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Numeric;
            // 
            // txtPrevMileage
            // 
            this.txtPrevMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrevMileage.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrevMileage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrevMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrevMileage.BorderWidth = 1;
            this.txtPrevMileage.DecimalPrecision = 0;
            this.txtPrevMileage.Location = new System.Drawing.Point(438, 84);
            this.txtPrevMileage.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrevMileage.MaxLength = 20;
            this.txtPrevMileage.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtPrevMileage.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrevMileage.Name = "txtPrevMileage";
            this.txtPrevMileage.Size = new System.Drawing.Size(215, 21);
            this.txtPrevMileage.TabIndex = 33;
            this.txtPrevMileage.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Integer;
            // 
            // tlpCarDetail
            // 
            this.tlpCarDetail.AutoSize = true;
            this.tlpCarDetail.ColumnCount = 4;
            this.tlpCarDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCarDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCarDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCarDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCarDetail.Controls.Add(this.lblNumber, 0, 0);
            this.tlpCarDetail.Controls.Add(this.cbxCars, 1, 0);
            this.tlpCarDetail.Controls.Add(this.txtMileage, 3, 1);
            this.tlpCarDetail.Controls.Add(this.lblMileage, 2, 1);
            this.tlpCarDetail.Controls.Add(this.lblDate, 0, 1);
            this.tlpCarDetail.Controls.Add(this.dtpDate, 1, 1);
            this.tlpCarDetail.Controls.Add(this.lblAmount, 0, 2);
            this.tlpCarDetail.Controls.Add(this.txtAmount, 1, 2);
            this.tlpCarDetail.Controls.Add(this.lblMileage1, 2, 2);
            this.tlpCarDetail.Controls.Add(this.txtLoseSales, 3, 2);
            this.tlpCarDetail.Controls.Add(this.lblPrevDate, 0, 3);
            this.tlpCarDetail.Controls.Add(this.dtpPrevDate, 1, 3);
            this.tlpCarDetail.Controls.Add(this.lblPrevMileage, 2, 3);
            this.tlpCarDetail.Controls.Add(this.txtPrevMileage, 3, 3);
            this.tlpCarDetail.Controls.Add(this.lblMaintenance, 0, 4);
            this.tlpCarDetail.Controls.Add(this.chklstMaintenance, 1, 4);
            this.tlpCarDetail.Controls.Add(this.lblStatus, 0, 6);
            this.tlpCarDetail.Controls.Add(this.cbxStatus, 1, 6);
            this.tlpCarDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCarDetail.Location = new System.Drawing.Point(0, 0);
            this.tlpCarDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tlpCarDetail.Name = "tlpCarDetail";
            this.tlpCarDetail.RowCount = 7;
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCarDetail.Size = new System.Drawing.Size(655, 189);
            this.tlpCarDetail.TabIndex = 2;
            // 
            // chklstNextMaintenance
            // 
            this.tlpNext.SetColumnSpan(this.chklstNextMaintenance, 3);
            this.chklstNextMaintenance.DataTextField = null;
            this.chklstNextMaintenance.DataValueField = null;
            this.chklstNextMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklstNextMaintenance.Location = new System.Drawing.Point(111, 29);
            this.chklstNextMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.chklstNextMaintenance.Name = "chklstNextMaintenance";
            this.chklstNextMaintenance.Size = new System.Drawing.Size(542, 50);
            this.chklstNextMaintenance.TabIndex = 70;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Location = new System.Drawing.Point(24, 115);
            this.lblMaintenance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(83, 12);
            this.lblMaintenance.TabIndex = 67;
            this.lblMaintenance.Text = "此次保养项目:";
            // 
            // chklstMaintenance
            // 
            this.tlpCarDetail.SetColumnSpan(this.chklstMaintenance, 3);
            this.chklstMaintenance.DataTextField = null;
            this.chklstMaintenance.DataValueField = null;
            this.chklstMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklstMaintenance.Location = new System.Drawing.Point(111, 110);
            this.chklstMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.chklstMaintenance.Name = "chklstMaintenance";
            this.tlpCarDetail.SetRowSpan(this.chklstMaintenance, 2);
            this.chklstMaintenance.Size = new System.Drawing.Size(542, 50);
            this.chklstMaintenance.TabIndex = 68;
            // 
            // lblNextMaintenance
            // 
            this.lblNextMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextMaintenance.AutoSize = true;
            this.lblNextMaintenance.Location = new System.Drawing.Point(24, 33);
            this.lblNextMaintenance.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.lblNextMaintenance.Name = "lblNextMaintenance";
            this.lblNextMaintenance.Size = new System.Drawing.Size(83, 12);
            this.lblNextMaintenance.TabIndex = 69;
            this.lblNextMaintenance.Text = "下次保养项目:";
            // 
            // lblNextMileage
            // 
            this.lblNextMileage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNextMileage.AutoSize = true;
            this.lblNextMileage.Location = new System.Drawing.Point(351, 7);
            this.lblNextMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextMileage.Name = "lblNextMileage";
            this.lblNextMileage.Size = new System.Drawing.Size(83, 12);
            this.lblNextMileage.TabIndex = 65;
            this.lblNextMileage.Text = "下次保养里程:";
            // 
            // txtNextMileage
            // 
            this.txtNextMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNextMileage.BackColor = System.Drawing.SystemColors.Window;
            this.txtNextMileage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNextMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNextMileage.BorderWidth = 1;
            this.txtNextMileage.DecimalPrecision = 0;
            this.txtNextMileage.Location = new System.Drawing.Point(438, 3);
            this.txtNextMileage.Margin = new System.Windows.Forms.Padding(2);
            this.txtNextMileage.MaxLength = 20;
            this.txtNextMileage.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtNextMileage.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNextMileage.Name = "txtNextMileage";
            this.txtNextMileage.Size = new System.Drawing.Size(215, 21);
            this.txtNextMileage.TabIndex = 66;
            this.txtNextMileage.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Integer;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(72, 169);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 12);
            this.lblStatus.TabIndex = 71;
            this.lblStatus.Text = "状态:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(112, 165);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(212, 20);
            this.cbxStatus.TabIndex = 72;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // tlpNext
            // 
            this.tlpNext.ColumnCount = 4;
            this.tlpNext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tlpNext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpNext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tlpNext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpNext.Controls.Add(this.lblNextDate, 0, 0);
            this.tlpNext.Controls.Add(this.dtpNextDate, 1, 0);
            this.tlpNext.Controls.Add(this.lblNextMileage, 2, 0);
            this.tlpNext.Controls.Add(this.txtNextMileage, 3, 0);
            this.tlpNext.Controls.Add(this.lblNextMaintenance, 0, 1);
            this.tlpNext.Controls.Add(this.chklstNextMaintenance, 1, 1);
            this.tlpNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpNext.Location = new System.Drawing.Point(0, 189);
            this.tlpNext.Name = "tlpNext";
            this.tlpNext.RowCount = 2;
            this.tlpNext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpNext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpNext.Size = new System.Drawing.Size(655, 81);
            this.tlpNext.TabIndex = 63;
            // 
            // MaintenanceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.tlpNext);
            this.Controls.Add(this.tlpCarDetail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaintenanceEdit";
            this.Size = new System.Drawing.Size(655, 386);
            this.Load += new System.EventHandler(this.MaintenanceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.tlpCarDetail.ResumeLayout(false);
            this.tlpCarDetail.PerformLayout();
            this.tlpNext.ResumeLayout(false);
            this.tlpNext.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibrary.Winform.UI.Controls.DataGridView dgvCars;
        private ClassLibrary.Winform.UI.Controls.DateTimePicker dtpNextDate;
        private ClassLibrary.Winform.UI.Controls.DateTimePicker dtpDate;
        private ClassLibrary.Winform.UI.Controls.ComboBox cbxCars;
        private ClassLibrary.Winform.UI.Controls.DateTimePicker dtpPrevDate;
        private ClassLibrary.Winform.UI.Controls.TextBox txtLoseSales;
        private ClassLibrary.Winform.UI.Controls.Label lblMileage1;
        private ClassLibrary.Winform.UI.Controls.Label lblPrevDate;
        private ClassLibrary.Winform.UI.Controls.Label lblNextDate;
        private ClassLibrary.Winform.UI.Controls.Label lblAmount;
        private ClassLibrary.Winform.UI.Controls.Label lblDate;
        private ClassLibrary.Winform.UI.Controls.Label lblNumber;
        private ClassLibrary.Winform.UI.Controls.Label lblMileage;
        private ClassLibrary.Winform.UI.Controls.Label lblPrevMileage;
        private ClassLibrary.Winform.UI.Controls.TextBox txtMileage;
        private ClassLibrary.Winform.UI.Controls.TextBox txtAmount;
        private ClassLibrary.Winform.UI.Controls.TextBox txtPrevMileage;
        private System.Windows.Forms.TableLayoutPanel tlpCarDetail;
        private ClassLibrary.Winform.UI.Controls.Label lblNextMileage;
        private ClassLibrary.Winform.UI.Controls.TextBox txtNextMileage;
        private ClassLibrary.Winform.UI.Controls.Label lblMaintenance;
        private ClassLibrary.Winform.UI.Controls.CheckBoxList chklstMaintenance;
        private ClassLibrary.Winform.UI.Controls.Label lblNextMaintenance;
        private ClassLibrary.Winform.UI.Controls.CheckBoxList chklstNextMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoseSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private ClassLibrary.Winform.UI.Controls.Label lblStatus;
        private ClassLibrary.Winform.UI.Controls.ComboBox cbxStatus;
        private System.Windows.Forms.TableLayoutPanel tlpNext;
    }
}
