namespace CarManage.UI.Client.Common.Customer
{
    partial class CarEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpCarDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtGuaranteeMileage = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtGuaranteePeriod = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtNextMaintenanceMileage = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.dtpNextMaintenanceDate = new ClassLibrary.Winform.UI.Controls.DateTimePicker(this.components);
            this.txtEngineNumber = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtFrameNumber = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.lblGuaranteePeriod = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.cbxMaitenanceMileage = new ClassLibrary.Winform.UI.Controls.ComboBox();
            this.cbxMaintenancePeriod = new ClassLibrary.Winform.UI.Controls.ComboBox();
            this.txtBuyMileage = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtInteriorColor = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtBodyColor = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtDisplacement = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtModel = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtBrand = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.lblNextMaintenanceDate = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblBuyMileage = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblInvoiceDate = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblBodyColor = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblModel = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblNumber = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblBrand = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblMaintenancePeriod = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblMaintenanceMileage = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblNextMaintenanceMileage = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblDisplacement = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblInterriorColor = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.txtNumber = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.lblGuaranteeMileage = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblFrameNumber = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblEngineNumner = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblRegisterDate = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblMileage = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.txtMileage = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.dtpRegisterDate = new ClassLibrary.Winform.UI.Controls.DateTimePicker(this.components);
            this.dtpInvoiceDate = new ClassLibrary.Winform.UI.Controls.DateTimePicker(this.components);
            this.dgvCars = new ClassLibrary.Winform.UI.Controls.DataGridView();
            this.colCarNumber = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextMaintenanceMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextMaintenanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpCarDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
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
            this.tlpCarDetail.Controls.Add(this.txtGuaranteeMileage, 3, 8);
            this.tlpCarDetail.Controls.Add(this.txtGuaranteePeriod, 1, 8);
            this.tlpCarDetail.Controls.Add(this.txtNextMaintenanceMileage, 3, 7);
            this.tlpCarDetail.Controls.Add(this.dtpNextMaintenanceDate, 1, 7);
            this.tlpCarDetail.Controls.Add(this.txtEngineNumber, 3, 5);
            this.tlpCarDetail.Controls.Add(this.txtFrameNumber, 1, 5);
            this.tlpCarDetail.Controls.Add(this.lblGuaranteePeriod, 0, 8);
            this.tlpCarDetail.Controls.Add(this.cbxMaitenanceMileage, 3, 6);
            this.tlpCarDetail.Controls.Add(this.cbxMaintenancePeriod, 1, 6);
            this.tlpCarDetail.Controls.Add(this.txtBuyMileage, 3, 4);
            this.tlpCarDetail.Controls.Add(this.txtInteriorColor, 3, 3);
            this.tlpCarDetail.Controls.Add(this.txtBodyColor, 1, 3);
            this.tlpCarDetail.Controls.Add(this.txtDisplacement, 3, 1);
            this.tlpCarDetail.Controls.Add(this.txtModel, 1, 1);
            this.tlpCarDetail.Controls.Add(this.txtBrand, 3, 0);
            this.tlpCarDetail.Controls.Add(this.lblNextMaintenanceDate, 0, 7);
            this.tlpCarDetail.Controls.Add(this.lblBuyMileage, 2, 4);
            this.tlpCarDetail.Controls.Add(this.lblInvoiceDate, 0, 4);
            this.tlpCarDetail.Controls.Add(this.lblBodyColor, 0, 3);
            this.tlpCarDetail.Controls.Add(this.lblModel, 0, 1);
            this.tlpCarDetail.Controls.Add(this.lblNumber, 0, 0);
            this.tlpCarDetail.Controls.Add(this.lblBrand, 2, 0);
            this.tlpCarDetail.Controls.Add(this.lblMaintenancePeriod, 0, 6);
            this.tlpCarDetail.Controls.Add(this.lblMaintenanceMileage, 2, 6);
            this.tlpCarDetail.Controls.Add(this.lblNextMaintenanceMileage, 2, 7);
            this.tlpCarDetail.Controls.Add(this.lblDisplacement, 2, 1);
            this.tlpCarDetail.Controls.Add(this.lblInterriorColor, 2, 3);
            this.tlpCarDetail.Controls.Add(this.txtNumber, 1, 0);
            this.tlpCarDetail.Controls.Add(this.lblGuaranteeMileage, 2, 8);
            this.tlpCarDetail.Controls.Add(this.lblFrameNumber, 0, 5);
            this.tlpCarDetail.Controls.Add(this.lblEngineNumner, 2, 5);
            this.tlpCarDetail.Controls.Add(this.lblRegisterDate, 2, 2);
            this.tlpCarDetail.Controls.Add(this.lblMileage, 0, 2);
            this.tlpCarDetail.Controls.Add(this.txtMileage, 1, 2);
            this.tlpCarDetail.Controls.Add(this.dtpRegisterDate, 3, 2);
            this.tlpCarDetail.Controls.Add(this.dtpInvoiceDate, 1, 4);
            this.tlpCarDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCarDetail.Location = new System.Drawing.Point(0, 0);
            this.tlpCarDetail.Name = "tlpCarDetail";
            this.tlpCarDetail.RowCount = 9;
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCarDetail.Size = new System.Drawing.Size(982, 360);
            this.tlpCarDetail.TabIndex = 1;
            // 
            // txtGuaranteeMileage
            // 
            this.txtGuaranteeMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuaranteeMileage.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuaranteeMileage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGuaranteeMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuaranteeMileage.BorderWidth = 1;
            this.txtGuaranteeMileage.DecimalPrecision = 0;
            this.txtGuaranteeMileage.Location = new System.Drawing.Point(656, 326);
            this.txtGuaranteeMileage.MaxLength = 50;
            this.txtGuaranteeMileage.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtGuaranteeMileage.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGuaranteeMileage.Name = "txtGuaranteeMileage";
            this.txtGuaranteeMileage.Size = new System.Drawing.Size(323, 28);
            this.txtGuaranteeMileage.TabIndex = 60;
            this.txtGuaranteeMileage.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Integer;
            // 
            // txtGuaranteePeriod
            // 
            this.txtGuaranteePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuaranteePeriod.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuaranteePeriod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGuaranteePeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuaranteePeriod.BorderWidth = 1;
            this.txtGuaranteePeriod.DecimalPrecision = 0;
            this.txtGuaranteePeriod.Location = new System.Drawing.Point(166, 326);
            this.txtGuaranteePeriod.MaxLength = 50;
            this.txtGuaranteePeriod.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtGuaranteePeriod.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGuaranteePeriod.Name = "txtGuaranteePeriod";
            this.txtGuaranteePeriod.Size = new System.Drawing.Size(321, 28);
            this.txtGuaranteePeriod.TabIndex = 59;
            this.txtGuaranteePeriod.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Integer;
            // 
            // txtNextMaintenanceMileage
            // 
            this.txtNextMaintenanceMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNextMaintenanceMileage.BackColor = System.Drawing.SystemColors.Window;
            this.txtNextMaintenanceMileage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNextMaintenanceMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNextMaintenanceMileage.BorderWidth = 1;
            this.txtNextMaintenanceMileage.DecimalPrecision = 0;
            this.txtNextMaintenanceMileage.Location = new System.Drawing.Point(656, 286);
            this.txtNextMaintenanceMileage.MaxLength = 50;
            this.txtNextMaintenanceMileage.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtNextMaintenanceMileage.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNextMaintenanceMileage.Name = "txtNextMaintenanceMileage";
            this.txtNextMaintenanceMileage.Size = new System.Drawing.Size(323, 28);
            this.txtNextMaintenanceMileage.TabIndex = 58;
            this.txtNextMaintenanceMileage.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Integer;
            // 
            // dtpNextMaintenanceDate
            // 
            this.dtpNextMaintenanceDate.AllowDateNull = false;
            this.dtpNextMaintenanceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNextMaintenanceDate.Checked = false;
            this.dtpNextMaintenanceDate.CustomFormat = " ";
            this.dtpNextMaintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextMaintenanceDate.Location = new System.Drawing.Point(166, 286);
            this.dtpNextMaintenanceDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpNextMaintenanceDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpNextMaintenanceDate.Name = "dtpNextMaintenanceDate";
            this.dtpNextMaintenanceDate.Size = new System.Drawing.Size(321, 28);
            this.dtpNextMaintenanceDate.TabIndex = 57;
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEngineNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtEngineNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEngineNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEngineNumber.BorderWidth = 1;
            this.txtEngineNumber.DecimalPrecision = 0;
            this.txtEngineNumber.Location = new System.Drawing.Point(656, 206);
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
            this.txtEngineNumber.Size = new System.Drawing.Size(323, 28);
            this.txtEngineNumber.TabIndex = 56;
            this.txtEngineNumber.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // txtFrameNumber
            // 
            this.txtFrameNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrameNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtFrameNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrameNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrameNumber.BorderWidth = 1;
            this.txtFrameNumber.DecimalPrecision = 0;
            this.txtFrameNumber.Location = new System.Drawing.Point(166, 206);
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
            this.txtFrameNumber.Size = new System.Drawing.Size(321, 28);
            this.txtFrameNumber.TabIndex = 55;
            this.txtFrameNumber.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // lblGuaranteePeriod
            // 
            this.lblGuaranteePeriod.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGuaranteePeriod.AutoSize = true;
            this.lblGuaranteePeriod.Location = new System.Drawing.Point(71, 331);
            this.lblGuaranteePeriod.Name = "lblGuaranteePeriod";
            this.lblGuaranteePeriod.Size = new System.Drawing.Size(89, 18);
            this.lblGuaranteePeriod.TabIndex = 52;
            this.lblGuaranteePeriod.Text = "质保年限:";
            // 
            // cbxMaitenanceMileage
            // 
            this.cbxMaitenanceMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMaitenanceMileage.FormattingEnabled = true;
            this.cbxMaitenanceMileage.Location = new System.Drawing.Point(656, 247);
            this.cbxMaitenanceMileage.Name = "cbxMaitenanceMileage";
            this.cbxMaitenanceMileage.Size = new System.Drawing.Size(323, 26);
            this.cbxMaitenanceMileage.TabIndex = 48;
            // 
            // cbxMaintenancePeriod
            // 
            this.cbxMaintenancePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMaintenancePeriod.FormattingEnabled = true;
            this.cbxMaintenancePeriod.Location = new System.Drawing.Point(166, 247);
            this.cbxMaintenancePeriod.Name = "cbxMaintenancePeriod";
            this.cbxMaintenancePeriod.Size = new System.Drawing.Size(321, 26);
            this.cbxMaintenancePeriod.TabIndex = 47;
            // 
            // txtBuyMileage
            // 
            this.txtBuyMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuyMileage.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuyMileage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuyMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuyMileage.BorderWidth = 1;
            this.txtBuyMileage.DecimalPrecision = 0;
            this.txtBuyMileage.Location = new System.Drawing.Point(656, 166);
            this.txtBuyMileage.MaxLength = 50;
            this.txtBuyMileage.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtBuyMileage.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtBuyMileage.Name = "txtBuyMileage";
            this.txtBuyMileage.Size = new System.Drawing.Size(323, 28);
            this.txtBuyMileage.TabIndex = 36;
            this.txtBuyMileage.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Integer;
            // 
            // txtInteriorColor
            // 
            this.txtInteriorColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteriorColor.BackColor = System.Drawing.SystemColors.Window;
            this.txtInteriorColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInteriorColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInteriorColor.BorderWidth = 1;
            this.txtInteriorColor.DecimalPrecision = 0;
            this.txtInteriorColor.Location = new System.Drawing.Point(656, 126);
            this.txtInteriorColor.MaxLength = 20;
            this.txtInteriorColor.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtInteriorColor.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtInteriorColor.Name = "txtInteriorColor";
            this.txtInteriorColor.Size = new System.Drawing.Size(323, 28);
            this.txtInteriorColor.TabIndex = 34;
            this.txtInteriorColor.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // txtBodyColor
            // 
            this.txtBodyColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBodyColor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBodyColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBodyColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodyColor.BorderWidth = 1;
            this.txtBodyColor.DecimalPrecision = 0;
            this.txtBodyColor.Location = new System.Drawing.Point(166, 126);
            this.txtBodyColor.MaxLength = 20;
            this.txtBodyColor.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtBodyColor.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtBodyColor.Name = "txtBodyColor";
            this.txtBodyColor.Size = new System.Drawing.Size(321, 28);
            this.txtBodyColor.TabIndex = 33;
            this.txtBodyColor.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // txtDisplacement
            // 
            this.txtDisplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplacement.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisplacement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDisplacement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplacement.BorderWidth = 1;
            this.txtDisplacement.DecimalPrecision = 0;
            this.txtDisplacement.Location = new System.Drawing.Point(656, 46);
            this.txtDisplacement.MaxLength = 255;
            this.txtDisplacement.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtDisplacement.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDisplacement.Name = "txtDisplacement";
            this.txtDisplacement.Size = new System.Drawing.Size(323, 28);
            this.txtDisplacement.TabIndex = 30;
            this.txtDisplacement.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Numeric;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.BackColor = System.Drawing.SystemColors.Window;
            this.txtModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.BorderWidth = 1;
            this.txtModel.DecimalPrecision = 0;
            this.txtModel.Location = new System.Drawing.Point(166, 46);
            this.txtModel.MaxLength = 50;
            this.txtModel.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtModel.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(321, 28);
            this.txtModel.TabIndex = 29;
            this.txtModel.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrand.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.BorderWidth = 1;
            this.txtBrand.DecimalPrecision = 0;
            this.txtBrand.Location = new System.Drawing.Point(656, 6);
            this.txtBrand.MaxLength = 255;
            this.txtBrand.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtBrand.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(323, 28);
            this.txtBrand.TabIndex = 28;
            this.txtBrand.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // lblNextMaintenanceDate
            // 
            this.lblNextMaintenanceDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNextMaintenanceDate.AutoSize = true;
            this.lblNextMaintenanceDate.Location = new System.Drawing.Point(35, 291);
            this.lblNextMaintenanceDate.Name = "lblNextMaintenanceDate";
            this.lblNextMaintenanceDate.Size = new System.Drawing.Size(125, 18);
            this.lblNextMaintenanceDate.TabIndex = 26;
            this.lblNextMaintenanceDate.Text = "下次保养日期:";
            // 
            // lblBuyMileage
            // 
            this.lblBuyMileage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBuyMileage.AutoSize = true;
            this.lblBuyMileage.Location = new System.Drawing.Point(525, 171);
            this.lblBuyMileage.Name = "lblBuyMileage";
            this.lblBuyMileage.Size = new System.Drawing.Size(125, 18);
            this.lblBuyMileage.TabIndex = 18;
            this.lblBuyMileage.Text = "购买车辆里程:";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(71, 171);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(89, 18);
            this.lblInvoiceDate.TabIndex = 16;
            this.lblInvoiceDate.Text = "发票日期:";
            // 
            // lblBodyColor
            // 
            this.lblBodyColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBodyColor.AutoSize = true;
            this.lblBodyColor.Location = new System.Drawing.Point(71, 131);
            this.lblBodyColor.Name = "lblBodyColor";
            this.lblBodyColor.Size = new System.Drawing.Size(89, 18);
            this.lblBodyColor.TabIndex = 12;
            this.lblBodyColor.Text = "车身颜色:";
            // 
            // lblModel
            // 
            this.lblModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(107, 51);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(53, 18);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "型号:";
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(89, 11);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(71, 18);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "车牌号:";
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(597, 11);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(53, 18);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "品牌:";
            // 
            // lblMaintenancePeriod
            // 
            this.lblMaintenancePeriod.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaintenancePeriod.AutoSize = true;
            this.lblMaintenancePeriod.Location = new System.Drawing.Point(71, 251);
            this.lblMaintenancePeriod.Name = "lblMaintenancePeriod";
            this.lblMaintenancePeriod.Size = new System.Drawing.Size(89, 18);
            this.lblMaintenancePeriod.TabIndex = 23;
            this.lblMaintenancePeriod.Text = "保养周期:";
            // 
            // lblMaintenanceMileage
            // 
            this.lblMaintenanceMileage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaintenanceMileage.AutoSize = true;
            this.lblMaintenanceMileage.Location = new System.Drawing.Point(525, 251);
            this.lblMaintenanceMileage.Name = "lblMaintenanceMileage";
            this.lblMaintenanceMileage.Size = new System.Drawing.Size(125, 18);
            this.lblMaintenanceMileage.TabIndex = 24;
            this.lblMaintenanceMileage.Text = "保养间隔里程:";
            // 
            // lblNextMaintenanceMileage
            // 
            this.lblNextMaintenanceMileage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNextMaintenanceMileage.AutoSize = true;
            this.lblNextMaintenanceMileage.Location = new System.Drawing.Point(525, 291);
            this.lblNextMaintenanceMileage.Name = "lblNextMaintenanceMileage";
            this.lblNextMaintenanceMileage.Size = new System.Drawing.Size(125, 18);
            this.lblNextMaintenanceMileage.TabIndex = 25;
            this.lblNextMaintenanceMileage.Text = "下次保养里程:";
            // 
            // lblDisplacement
            // 
            this.lblDisplacement.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDisplacement.AutoSize = true;
            this.lblDisplacement.Location = new System.Drawing.Point(597, 51);
            this.lblDisplacement.Name = "lblDisplacement";
            this.lblDisplacement.Size = new System.Drawing.Size(53, 18);
            this.lblDisplacement.TabIndex = 14;
            this.lblDisplacement.Text = "排量:";
            // 
            // lblInterriorColor
            // 
            this.lblInterriorColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInterriorColor.AutoSize = true;
            this.lblInterriorColor.Location = new System.Drawing.Point(561, 131);
            this.lblInterriorColor.Name = "lblInterriorColor";
            this.lblInterriorColor.Size = new System.Drawing.Size(89, 18);
            this.lblInterriorColor.TabIndex = 10;
            this.lblInterriorColor.Text = "内饰颜色:";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.BorderWidth = 1;
            this.txtNumber.DecimalPrecision = 0;
            this.txtNumber.Location = new System.Drawing.Point(166, 6);
            this.txtNumber.MaxLength = 50;
            this.txtNumber.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtNumber.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(321, 28);
            this.txtNumber.TabIndex = 27;
            this.txtNumber.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // lblGuaranteeMileage
            // 
            this.lblGuaranteeMileage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGuaranteeMileage.AutoSize = true;
            this.lblGuaranteeMileage.Location = new System.Drawing.Point(561, 331);
            this.lblGuaranteeMileage.Name = "lblGuaranteeMileage";
            this.lblGuaranteeMileage.Size = new System.Drawing.Size(89, 18);
            this.lblGuaranteeMileage.TabIndex = 51;
            this.lblGuaranteeMileage.Text = "质保里程:";
            // 
            // lblFrameNumber
            // 
            this.lblFrameNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFrameNumber.AutoSize = true;
            this.lblFrameNumber.Location = new System.Drawing.Point(89, 211);
            this.lblFrameNumber.Name = "lblFrameNumber";
            this.lblFrameNumber.Size = new System.Drawing.Size(71, 18);
            this.lblFrameNumber.TabIndex = 8;
            this.lblFrameNumber.Text = "车架号:";
            // 
            // lblEngineNumner
            // 
            this.lblEngineNumner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEngineNumner.AutoSize = true;
            this.lblEngineNumner.Location = new System.Drawing.Point(561, 211);
            this.lblEngineNumner.Name = "lblEngineNumner";
            this.lblEngineNumner.Size = new System.Drawing.Size(89, 18);
            this.lblEngineNumner.TabIndex = 6;
            this.lblEngineNumner.Text = "发动机号:";
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.Location = new System.Drawing.Point(561, 91);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(89, 18);
            this.lblRegisterDate.TabIndex = 20;
            this.lblRegisterDate.Text = "上牌日期:";
            // 
            // lblMileage
            // 
            this.lblMileage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(71, 91);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(89, 18);
            this.lblMileage.TabIndex = 22;
            this.lblMileage.Text = "行驶里程:";
            // 
            // txtMileage
            // 
            this.txtMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMileage.BackColor = System.Drawing.SystemColors.Window;
            this.txtMileage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMileage.BorderWidth = 1;
            this.txtMileage.DecimalPrecision = 0;
            this.txtMileage.Location = new System.Drawing.Point(166, 86);
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
            this.txtMileage.Size = new System.Drawing.Size(321, 28);
            this.txtMileage.TabIndex = 53;
            this.txtMileage.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Integer;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.AllowDateNull = false;
            this.dtpRegisterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRegisterDate.Checked = false;
            this.dtpRegisterDate.CustomFormat = " ";
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegisterDate.Location = new System.Drawing.Point(656, 86);
            this.dtpRegisterDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpRegisterDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(323, 28);
            this.dtpRegisterDate.TabIndex = 54;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.AllowDateNull = false;
            this.dtpInvoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInvoiceDate.Checked = false;
            this.dtpInvoiceDate.CustomFormat = " ";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(166, 166);
            this.dtpInvoiceDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpInvoiceDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(321, 28);
            this.dtpInvoiceDate.TabIndex = 61;
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
            this.dgvCars.ColumnHeadersHeight = 42;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarNumber,
            this.colModel,
            this.colDisplacement,
            this.colMileage,
            this.colInvoiceDate,
            this.colNextMaintenanceMileage,
            this.colNextMaintenanceDate,
            this.colId});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCars.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvCars.Location = new System.Drawing.Point(0, 360);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.PaintRowNumber = false;
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowTemplate.Height = 30;
            this.dgvCars.Size = new System.Drawing.Size(982, 182);
            this.dgvCars.TabIndex = 3;
            this.dgvCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellContentClick);
            // 
            // colCarNumber
            // 
            this.colCarNumber.DataPropertyName = "Number";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colCarNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCarNumber.HeaderText = "车牌号";
            this.colCarNumber.Name = "colCarNumber";
            this.colCarNumber.ReadOnly = true;
            this.colCarNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCarNumber.Width = 70;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colModel.DefaultCellStyle = dataGridViewCellStyle3;
            this.colModel.FillWeight = 80F;
            this.colModel.HeaderText = "型号";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            this.colModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDisplacement
            // 
            this.colDisplacement.DataPropertyName = "Displacement";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDisplacement.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDisplacement.HeaderText = "排量";
            this.colDisplacement.Name = "colDisplacement";
            this.colDisplacement.ReadOnly = true;
            this.colDisplacement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDisplacement.Width = 60;
            // 
            // colMileage
            // 
            this.colMileage.DataPropertyName = "Mileage";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMileage.DefaultCellStyle = dataGridViewCellStyle5;
            this.colMileage.HeaderText = "里程";
            this.colMileage.Name = "colMileage";
            this.colMileage.ReadOnly = true;
            this.colMileage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMileage.Width = 60;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            this.colInvoiceDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colInvoiceDate.HeaderText = "发票日期";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            this.colInvoiceDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colInvoiceDate.Width = 80;
            // 
            // colNextMaintenanceMileage
            // 
            this.colNextMaintenanceMileage.DataPropertyName = "NextMaintenanceMileage";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNextMaintenanceMileage.DefaultCellStyle = dataGridViewCellStyle7;
            this.colNextMaintenanceMileage.HeaderText = "下次保养里程";
            this.colNextMaintenanceMileage.Name = "colNextMaintenanceMileage";
            this.colNextMaintenanceMileage.ReadOnly = true;
            this.colNextMaintenanceMileage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNextMaintenanceMileage.Width = 110;
            // 
            // colNextMaintenanceDate
            // 
            this.colNextMaintenanceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNextMaintenanceDate.DataPropertyName = "NextMaintenanceDate";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "d";
            this.colNextMaintenanceDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.colNextMaintenanceDate.HeaderText = "下次保养日期";
            this.colNextMaintenanceDate.Name = "colNextMaintenanceDate";
            this.colNextMaintenanceDate.ReadOnly = true;
            this.colNextMaintenanceDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "主键";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // CarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.tlpCarDetail);
            this.Name = "CarEdit";
            this.Size = new System.Drawing.Size(982, 542);
            this.Load += new System.EventHandler(this.CarEdit_Load);
            this.tlpCarDetail.ResumeLayout(false);
            this.tlpCarDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCarDetail;
        private ClassLibrary.Winform.UI.Controls.ComboBox cbxMaitenanceMileage;
        private ClassLibrary.Winform.UI.Controls.ComboBox cbxMaintenancePeriod;
        private ClassLibrary.Winform.UI.Controls.TextBox txtBuyMileage;
        private ClassLibrary.Winform.UI.Controls.TextBox txtInteriorColor;
        private ClassLibrary.Winform.UI.Controls.TextBox txtBodyColor;
        private ClassLibrary.Winform.UI.Controls.TextBox txtDisplacement;
        private ClassLibrary.Winform.UI.Controls.TextBox txtModel;
        private ClassLibrary.Winform.UI.Controls.TextBox txtBrand;
        private ClassLibrary.Winform.UI.Controls.Label lblNextMaintenanceDate;
        private ClassLibrary.Winform.UI.Controls.Label lblMileage;
        private ClassLibrary.Winform.UI.Controls.Label lblRegisterDate;
        private ClassLibrary.Winform.UI.Controls.Label lblBuyMileage;
        private ClassLibrary.Winform.UI.Controls.Label lblInvoiceDate;
        private ClassLibrary.Winform.UI.Controls.Label lblBodyColor;
        private ClassLibrary.Winform.UI.Controls.Label lblFrameNumber;
        private ClassLibrary.Winform.UI.Controls.Label lblModel;
        private ClassLibrary.Winform.UI.Controls.Label lblNumber;
        private ClassLibrary.Winform.UI.Controls.Label lblBrand;
        private ClassLibrary.Winform.UI.Controls.Label lblMaintenancePeriod;
        private ClassLibrary.Winform.UI.Controls.Label lblMaintenanceMileage;
        private ClassLibrary.Winform.UI.Controls.Label lblNextMaintenanceMileage;
        private ClassLibrary.Winform.UI.Controls.Label lblDisplacement;
        private ClassLibrary.Winform.UI.Controls.Label lblInterriorColor;
        private ClassLibrary.Winform.UI.Controls.Label lblEngineNumner;
        private ClassLibrary.Winform.UI.Controls.TextBox txtNumber;
        private ClassLibrary.Winform.UI.Controls.Label lblGuaranteePeriod;
        private ClassLibrary.Winform.UI.Controls.Label lblGuaranteeMileage;
        private ClassLibrary.Winform.UI.Controls.TextBox txtMileage;
        private ClassLibrary.Winform.UI.Controls.DateTimePicker dtpRegisterDate;
        private ClassLibrary.Winform.UI.Controls.TextBox txtEngineNumber;
        private ClassLibrary.Winform.UI.Controls.TextBox txtFrameNumber;
        private ClassLibrary.Winform.UI.Controls.TextBox txtNextMaintenanceMileage;
        private ClassLibrary.Winform.UI.Controls.DateTimePicker dtpNextMaintenanceDate;
        private ClassLibrary.Winform.UI.Controls.TextBox txtGuaranteeMileage;
        private ClassLibrary.Winform.UI.Controls.TextBox txtGuaranteePeriod;
        private ClassLibrary.Winform.UI.Controls.DateTimePicker dtpInvoiceDate;
        private ClassLibrary.Winform.UI.Controls.DataGridView dgvCars;
        private System.Windows.Forms.DataGridViewLinkColumn colCarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextMaintenanceMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextMaintenanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}
