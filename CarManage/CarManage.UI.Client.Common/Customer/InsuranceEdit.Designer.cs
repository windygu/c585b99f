namespace CarManage.UI.Client.Common.Customer
{
    partial class InsuranceEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsuranceEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpCarDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumber = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.cbxCars = new ClassLibrary.Winform.UI.Controls.ComboBox();
            this.lblEngineNumber = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblFrameNumber = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblInsurant = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.txtInsurant = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.lblInsurantPhone = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblInsuranceCompany = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblItems = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.chklstItems = new ClassLibrary.Winform.UI.Controls.CheckBoxList();
            this.lblAmount = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.txtFrameNumber = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.cbxInsuranceCompany = new ClassLibrary.Winform.UI.Controls.ComboBox();
            this.txtAmount = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.lblLocal = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblNextInsuranceDate = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.dgvInsurance = new ClassLibrary.Winform.UI.Controls.DataGridView();
            this.colStatusText = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colItemSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoseSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsurant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsurantPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNextInsuranceDate = new ClassLibrary.Winform.UI.Controls.DateTimePicker(this.components);
            this.chkLocal = new ClassLibrary.Winform.UI.Controls.CheckBox(this.components);
            this.txtInsurantPhone = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtEngineNumber = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.tlpCarDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).BeginInit();
            this.SuspendLayout();
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
            this.tlpCarDetail.Controls.Add(this.txtEngineNumber, 3, 1);
            this.tlpCarDetail.Controls.Add(this.lblEngineNumber, 2, 1);
            this.tlpCarDetail.Controls.Add(this.lblFrameNumber, 0, 1);
            this.tlpCarDetail.Controls.Add(this.lblInsurant, 0, 2);
            this.tlpCarDetail.Controls.Add(this.txtInsurant, 1, 2);
            this.tlpCarDetail.Controls.Add(this.lblInsurantPhone, 2, 2);
            this.tlpCarDetail.Controls.Add(this.txtInsurantPhone, 3, 2);
            this.tlpCarDetail.Controls.Add(this.lblItems, 0, 4);
            this.tlpCarDetail.Controls.Add(this.chklstItems, 1, 4);
            this.tlpCarDetail.Controls.Add(this.lblAmount, 0, 6);
            this.tlpCarDetail.Controls.Add(this.txtFrameNumber, 1, 1);
            this.tlpCarDetail.Controls.Add(this.txtAmount, 1, 6);
            this.tlpCarDetail.Controls.Add(this.lblInsuranceCompany, 0, 3);
            this.tlpCarDetail.Controls.Add(this.cbxInsuranceCompany, 1, 3);
            this.tlpCarDetail.Controls.Add(this.lblLocal, 2, 3);
            this.tlpCarDetail.Controls.Add(this.chkLocal, 3, 3);
            this.tlpCarDetail.Controls.Add(this.lblNextInsuranceDate, 2, 6);
            this.tlpCarDetail.Controls.Add(this.dtpNextInsuranceDate, 3, 6);
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
            this.tlpCarDetail.TabIndex = 3;
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
            // lblEngineNumber
            // 
            this.lblEngineNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEngineNumber.AutoSize = true;
            this.lblEngineNumber.Location = new System.Drawing.Point(375, 34);
            this.lblEngineNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEngineNumber.Name = "lblEngineNumber";
            this.lblEngineNumber.Size = new System.Drawing.Size(59, 12);
            this.lblEngineNumber.TabIndex = 4;
            this.lblEngineNumber.Text = "发动机号:";
            // 
            // lblFrameNumber
            // 
            this.lblFrameNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFrameNumber.AutoSize = true;
            this.lblFrameNumber.Location = new System.Drawing.Point(60, 34);
            this.lblFrameNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrameNumber.Name = "lblFrameNumber";
            this.lblFrameNumber.Size = new System.Drawing.Size(47, 12);
            this.lblFrameNumber.TabIndex = 1;
            this.lblFrameNumber.Text = "车架号:";
            // 
            // lblInsurant
            // 
            this.lblInsurant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInsurant.AutoSize = true;
            this.lblInsurant.Location = new System.Drawing.Point(48, 61);
            this.lblInsurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsurant.Name = "lblInsurant";
            this.lblInsurant.Size = new System.Drawing.Size(59, 12);
            this.lblInsurant.TabIndex = 14;
            this.lblInsurant.Text = "被保险人:";
            // 
            // txtInsurant
            // 
            this.txtInsurant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsurant.BackColor = System.Drawing.SystemColors.Window;
            this.txtInsurant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInsurant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsurant.BorderWidth = 1;
            this.txtInsurant.DecimalPrecision = 0;
            this.txtInsurant.Location = new System.Drawing.Point(111, 57);
            this.txtInsurant.Margin = new System.Windows.Forms.Padding(2);
            this.txtInsurant.MaxLength = 50;
            this.txtInsurant.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtInsurant.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtInsurant.Name = "txtInsurant";
            this.txtInsurant.Size = new System.Drawing.Size(214, 21);
            this.txtInsurant.TabIndex = 30;
            this.txtInsurant.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // lblInsurantPhone
            // 
            this.lblInsurantPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInsurantPhone.AutoSize = true;
            this.lblInsurantPhone.Location = new System.Drawing.Point(351, 61);
            this.lblInsurantPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsurantPhone.Name = "lblInsurantPhone";
            this.lblInsurantPhone.Size = new System.Drawing.Size(83, 12);
            this.lblInsurantPhone.TabIndex = 22;
            this.lblInsurantPhone.Text = "被保险人电话:";
            // 
            // lblInsuranceCompany
            // 
            this.lblInsuranceCompany.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInsuranceCompany.AutoSize = true;
            this.lblInsuranceCompany.Location = new System.Drawing.Point(48, 88);
            this.lblInsuranceCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsuranceCompany.Name = "lblInsuranceCompany";
            this.lblInsuranceCompany.Size = new System.Drawing.Size(59, 12);
            this.lblInsuranceCompany.TabIndex = 12;
            this.lblInsuranceCompany.Text = "保险公司:";
            // 
            // lblItems
            // 
            this.lblItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(48, 115);
            this.lblItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(59, 12);
            this.lblItems.TabIndex = 67;
            this.lblItems.Text = "保险项目:";
            // 
            // chklstItems
            // 
            this.chklstItems.CheckedValues = ((System.Collections.Generic.List<string>)(resources.GetObject("chklstItems.CheckedValues")));
            this.tlpCarDetail.SetColumnSpan(this.chklstItems, 3);
            this.chklstItems.DataTextField = null;
            this.chklstItems.DataValueField = null;
            this.chklstItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklstItems.Location = new System.Drawing.Point(111, 110);
            this.chklstItems.Margin = new System.Windows.Forms.Padding(2);
            this.chklstItems.Name = "chklstItems";
            this.tlpCarDetail.SetRowSpan(this.chklstItems, 2);
            this.chklstItems.Size = new System.Drawing.Size(542, 50);
            this.chklstItems.TabIndex = 68;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(72, 169);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(35, 12);
            this.lblAmount.TabIndex = 71;
            this.lblAmount.Text = "金额:";
            // 
            // txtFrameNumber
            // 
            this.txtFrameNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrameNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtFrameNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrameNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrameNumber.BorderWidth = 1;
            this.txtFrameNumber.DecimalPrecision = 0;
            this.txtFrameNumber.Location = new System.Drawing.Point(111, 30);
            this.txtFrameNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrameNumber.MaxLength = 50;
            this.txtFrameNumber.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtFrameNumber.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtFrameNumber.Name = "txtFrameNumber";
            this.txtFrameNumber.Size = new System.Drawing.Size(214, 21);
            this.txtFrameNumber.TabIndex = 73;
            this.txtFrameNumber.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // cbxInsuranceCompany
            // 
            this.cbxInsuranceCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxInsuranceCompany.BackColor = System.Drawing.Color.White;
            this.cbxInsuranceCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInsuranceCompany.FormattingEnabled = true;
            this.cbxInsuranceCompany.Location = new System.Drawing.Point(111, 84);
            this.cbxInsuranceCompany.Margin = new System.Windows.Forms.Padding(2);
            this.cbxInsuranceCompany.Name = "cbxInsuranceCompany";
            this.cbxInsuranceCompany.Size = new System.Drawing.Size(214, 20);
            this.cbxInsuranceCompany.TabIndex = 75;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.BorderWidth = 1;
            this.txtAmount.DecimalPrecision = 0;
            this.txtAmount.Location = new System.Drawing.Point(111, 165);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.MaxLength = 20;
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
            this.txtAmount.TabIndex = 76;
            this.txtAmount.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Numeric;
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(375, 88);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(59, 12);
            this.lblLocal.TabIndex = 77;
            this.lblLocal.Text = "店内投保:";
            // 
            // lblNextInsuranceDate
            // 
            this.lblNextInsuranceDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNextInsuranceDate.AutoSize = true;
            this.lblNextInsuranceDate.Location = new System.Drawing.Point(351, 169);
            this.lblNextInsuranceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextInsuranceDate.Name = "lblNextInsuranceDate";
            this.lblNextInsuranceDate.Size = new System.Drawing.Size(83, 12);
            this.lblNextInsuranceDate.TabIndex = 79;
            this.lblNextInsuranceDate.Text = "下次续保日期:";
            // 
            // dgvInsurance
            // 
            this.dgvInsurance.AllowUserToAddRows = false;
            this.dgvInsurance.AllowUserToDeleteRows = false;
            this.dgvInsurance.AllowUserToResizeRows = false;
            this.dgvInsurance.BackgroundColor = System.Drawing.Color.White;
            this.dgvInsurance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dgvInsurance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInsurance.CheckBoxBorderColor = System.Drawing.Color.Empty;
            this.dgvInsurance.CheckedAll = false;
            this.dgvInsurance.CheckedImage = null;
            this.dgvInsurance.ColumnHeaderBackgroundImage = null;
            this.dgvInsurance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInsurance.ColumnHeadersHeight = 21;
            this.dgvInsurance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInsurance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStatusText,
            this.colItemSummary,
            this.colAmount,
            this.colLoseSales,
            this.colInsurant,
            this.colInsurantPhone,
            this.colDate,
            this.colId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsurance.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInsurance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvInsurance.Location = new System.Drawing.Point(0, 189);
            this.dgvInsurance.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInsurance.MultiSelect = false;
            this.dgvInsurance.Name = "dgvInsurance";
            this.dgvInsurance.PaintRowNumber = false;
            this.dgvInsurance.ReadOnly = true;
            this.dgvInsurance.RowHeadersVisible = false;
            this.dgvInsurance.RowTemplate.Height = 30;
            this.dgvInsurance.Size = new System.Drawing.Size(655, 197);
            this.dgvInsurance.TabIndex = 63;
            // 
            // colStatusText
            // 
            this.colStatusText.DataPropertyName = "Number";
            this.colStatusText.HeaderText = "保单号";
            this.colStatusText.Name = "colStatusText";
            this.colStatusText.ReadOnly = true;
            this.colStatusText.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatusText.Width = 80;
            // 
            // colItemSummary
            // 
            this.colItemSummary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemSummary.DataPropertyName = "ItemSummary";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colItemSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.colItemSummary.HeaderText = "保险项目";
            this.colItemSummary.Name = "colItemSummary";
            this.colItemSummary.ReadOnly = true;
            this.colItemSummary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAmount.Width = 50;
            // 
            // colLoseSales
            // 
            this.colLoseSales.DataPropertyName = "InsuranceCompanyName";
            this.colLoseSales.HeaderText = "保险公司";
            this.colLoseSales.Name = "colLoseSales";
            this.colLoseSales.ReadOnly = true;
            this.colLoseSales.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLoseSales.Width = 60;
            // 
            // colInsurant
            // 
            this.colInsurant.DataPropertyName = "Insurant";
            this.colInsurant.HeaderText = "被保险人";
            this.colInsurant.Name = "colInsurant";
            this.colInsurant.ReadOnly = true;
            this.colInsurant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colInsurant.Width = 60;
            // 
            // colInsurantPhone
            // 
            this.colInsurantPhone.DataPropertyName = "InsurantPhone";
            this.colInsurantPhone.HeaderText = "电话";
            this.colInsurantPhone.Name = "colInsurantPhone";
            this.colInsurantPhone.ReadOnly = true;
            this.colInsurantPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colInsurantPhone.Width = 80;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "InsuranceDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDate.HeaderText = "投保日期";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDate.Width = 60;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "主键";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // dtpNextInsuranceDate
            // 
            this.dtpNextInsuranceDate.AllowDateNull = false;
            this.dtpNextInsuranceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNextInsuranceDate.Checked = false;
            this.dtpNextInsuranceDate.CustomFormat = " ";
            this.dtpNextInsuranceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextInsuranceDate.Location = new System.Drawing.Point(439, 165);
            this.dtpNextInsuranceDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpNextInsuranceDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpNextInsuranceDate.Name = "dtpNextInsuranceDate";
            this.dtpNextInsuranceDate.Size = new System.Drawing.Size(213, 21);
            this.dtpNextInsuranceDate.TabIndex = 80;
            // 
            // chkLocal
            // 
            this.chkLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLocal.AutoSize = true;
            this.chkLocal.Location = new System.Drawing.Point(439, 84);
            this.chkLocal.Name = "chkLocal";
            this.chkLocal.Size = new System.Drawing.Size(36, 21);
            this.chkLocal.TabIndex = 78;
            this.chkLocal.Text = "是";
            this.chkLocal.UseVisualStyleBackColor = true;
            this.chkLocal.Value = null;
            // 
            // txtInsurantPhone
            // 
            this.txtInsurantPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsurantPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtInsurantPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInsurantPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsurantPhone.BorderWidth = 1;
            this.txtInsurantPhone.DecimalPrecision = 0;
            this.txtInsurantPhone.Location = new System.Drawing.Point(438, 57);
            this.txtInsurantPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtInsurantPhone.MaxLength = 20;
            this.txtInsurantPhone.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtInsurantPhone.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtInsurantPhone.Name = "txtInsurantPhone";
            this.txtInsurantPhone.Size = new System.Drawing.Size(215, 21);
            this.txtInsurantPhone.TabIndex = 53;
            this.txtInsurantPhone.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEngineNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtEngineNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEngineNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEngineNumber.BorderWidth = 1;
            this.txtEngineNumber.DecimalPrecision = 0;
            this.txtEngineNumber.Location = new System.Drawing.Point(438, 30);
            this.txtEngineNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtEngineNumber.MaxLength = 50;
            this.txtEngineNumber.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtEngineNumber.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtEngineNumber.Name = "txtEngineNumber";
            this.txtEngineNumber.Size = new System.Drawing.Size(215, 21);
            this.txtEngineNumber.TabIndex = 29;
            this.txtEngineNumber.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // InsuranceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvInsurance);
            this.Controls.Add(this.tlpCarDetail);
            this.Name = "InsuranceEdit";
            this.Size = new System.Drawing.Size(655, 386);
            this.Load += new System.EventHandler(this.InsuranceEdit_Load);
            this.tlpCarDetail.ResumeLayout(false);
            this.tlpCarDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCarDetail;
        private ClassLibrary.Winform.UI.Controls.Label lblNumber;
        private ClassLibrary.Winform.UI.Controls.ComboBox cbxCars;
        private ClassLibrary.Winform.UI.Controls.Label lblEngineNumber;
        private ClassLibrary.Winform.UI.Controls.Label lblFrameNumber;
        private ClassLibrary.Winform.UI.Controls.Label lblInsurant;
        private ClassLibrary.Winform.UI.Controls.TextBox txtInsurant;
        private ClassLibrary.Winform.UI.Controls.Label lblInsurantPhone;
        private ClassLibrary.Winform.UI.Controls.Label lblInsuranceCompany;
        private ClassLibrary.Winform.UI.Controls.Label lblItems;
        private ClassLibrary.Winform.UI.Controls.CheckBoxList chklstItems;
        private ClassLibrary.Winform.UI.Controls.Label lblAmount;
        private ClassLibrary.Winform.UI.Controls.DataGridView dgvInsurance;
        private ClassLibrary.Winform.UI.Controls.TextBox txtFrameNumber;
        private ClassLibrary.Winform.UI.Controls.ComboBox cbxInsuranceCompany;
        private ClassLibrary.Winform.UI.Controls.TextBox txtAmount;
        private ClassLibrary.Winform.UI.Controls.Label lblLocal;
        private ClassLibrary.Winform.UI.Controls.Label lblNextInsuranceDate;
        private System.Windows.Forms.DataGridViewLinkColumn colStatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoseSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsurant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsurantPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private ClassLibrary.Winform.UI.Controls.TextBox txtEngineNumber;
        private ClassLibrary.Winform.UI.Controls.TextBox txtInsurantPhone;
        private ClassLibrary.Winform.UI.Controls.CheckBox chkLocal;
        private ClassLibrary.Winform.UI.Controls.DateTimePicker dtpNextInsuranceDate;
    }
}
