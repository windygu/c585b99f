namespace CarManage.UI.Client.Common.Task
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.lblNumber = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.txtNumber = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.txtOwner = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.lblOwner = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.lblMobile = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.txtMobile = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.btnSearch = new ClassLibrary.Winform.UI.Controls.ButtonEx(this.components);
            this.btnNew = new ClassLibrary.Winform.UI.Controls.ButtonEx(this.components);
            this.dgvList = new ClassLibrary.Winform.UI.Controls.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDisplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBodyColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSolicitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSeatchCondition = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tlpSeatchCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(25, 10);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 12);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "车牌号:";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.BorderWidth = 1;
            this.txtNumber.DecimalPrecision = 0;
            this.txtNumber.Location = new System.Drawing.Point(76, 6);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtNumber.Size = new System.Drawing.Size(130, 21);
            this.txtNumber.TabIndex = 27;
            this.txtNumber.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // txtOwner
            // 
            this.txtOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwner.BackColor = System.Drawing.SystemColors.Window;
            this.txtOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOwner.BorderWidth = 1;
            this.txtOwner.DecimalPrecision = 0;
            this.txtOwner.Location = new System.Drawing.Point(329, 33);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(2);
            this.txtOwner.MaxLength = 50;
            this.txtOwner.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtOwner.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(130, 21);
            this.txtOwner.TabIndex = 28;
            this.txtOwner.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // lblOwner
            // 
            this.lblOwner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(242, 10);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(35, 12);
            this.lblOwner.TabIndex = 29;
            this.lblOwner.Text = "车主:";
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(447, 10);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(35, 12);
            this.lblMobile.TabIndex = 30;
            this.lblMobile.Text = "手机:";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.BackColor = System.Drawing.SystemColors.Window;
            this.txtMobile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.BorderWidth = 1;
            this.txtMobile.DecimalPrecision = 0;
            this.txtMobile.Location = new System.Drawing.Point(486, 6);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.MaxLength = 20;
            this.txtMobile.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtMobile.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(130, 21);
            this.txtMobile.TabIndex = 34;
            this.txtMobile.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.String;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ButtonLevel = ClassLibrary.Winform.UI.Controls.ButtonLevel.Third;
            this.btnSearch.ButtonType = ClassLibrary.Winform.UI.Controls.ButtonType.Secondary;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(633, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 21);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.ButtonLevel = ClassLibrary.Winform.UI.Controls.ButtonLevel.Third;
            this.btnNew.ButtonType = ClassLibrary.Winform.UI.Controls.ButtonType.Secondary;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(710, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(60, 21);
            this.btnNew.TabIndex = 36;
            this.btnNew.Text = "新建";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BorderColor = System.Drawing.Color.Empty;
            this.dgvList.CheckBoxBorderColor = System.Drawing.Color.Empty;
            this.dgvList.CheckedAll = false;
            this.dgvList.CheckedImage = null;
            this.dgvList.ColumnHeaderBackgroundImage = null;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.ColOwner,
            this.ColModel,
            this.ColDisplacement,
            this.ColBodyColor,
            this.ColRegisterDate,
            this.ColMileage,
            this.ColSolicitor,
            this.ColUpdateDate,
            this.ColCustomerID,
            this.ColCarID});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 33);
            this.dgvList.Name = "dgvList";
            this.dgvList.PaintRowNumber = false;
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(900, 467);
            this.dgvList.TabIndex = 5;
            // 
            // colNumber
            // 
            this.colNumber.DataPropertyName = "Number";
            this.colNumber.HeaderText = "车牌号";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 80;
            // 
            // ColOwner
            // 
            this.ColOwner.DataPropertyName = "Owner";
            this.ColOwner.HeaderText = "车主";
            this.ColOwner.Name = "ColOwner";
            this.ColOwner.ReadOnly = true;
            this.ColOwner.Width = 80;
            // 
            // ColModel
            // 
            this.ColModel.DataPropertyName = "Model";
            this.ColModel.HeaderText = "车型";
            this.ColModel.Name = "ColModel";
            this.ColModel.ReadOnly = true;
            // 
            // ColDisplacement
            // 
            this.ColDisplacement.DataPropertyName = "Displacement";
            this.ColDisplacement.HeaderText = "排量";
            this.ColDisplacement.Name = "ColDisplacement";
            this.ColDisplacement.ReadOnly = true;
            this.ColDisplacement.Width = 60;
            // 
            // ColBodyColor
            // 
            this.ColBodyColor.DataPropertyName = "BodyColor";
            this.ColBodyColor.HeaderText = "颜色";
            this.ColBodyColor.Name = "ColBodyColor";
            this.ColBodyColor.ReadOnly = true;
            this.ColBodyColor.Width = 70;
            // 
            // ColRegisterDate
            // 
            this.ColRegisterDate.DataPropertyName = "RegisterDate";
            this.ColRegisterDate.HeaderText = "上牌日期";
            this.ColRegisterDate.Name = "ColRegisterDate";
            this.ColRegisterDate.ReadOnly = true;
            this.ColRegisterDate.Width = 80;
            // 
            // ColMileage
            // 
            this.ColMileage.DataPropertyName = "Mileage";
            this.ColMileage.HeaderText = "行驶里程";
            this.ColMileage.Name = "ColMileage";
            this.ColMileage.ReadOnly = true;
            this.ColMileage.Width = 80;
            // 
            // ColSolicitor
            // 
            this.ColSolicitor.DataPropertyName = "Solicitor";
            this.ColSolicitor.HeaderText = "客户顾问";
            this.ColSolicitor.Name = "ColSolicitor";
            this.ColSolicitor.ReadOnly = true;
            this.ColSolicitor.Width = 80;
            // 
            // ColUpdateDate
            // 
            this.ColUpdateDate.DataPropertyName = "UpdateDate";
            this.ColUpdateDate.HeaderText = "更新日期";
            this.ColUpdateDate.Name = "ColUpdateDate";
            this.ColUpdateDate.ReadOnly = true;
            this.ColUpdateDate.Width = 80;
            // 
            // ColCustomerID
            // 
            this.ColCustomerID.DataPropertyName = "CustomerID";
            this.ColCustomerID.HeaderText = "CustomerID";
            this.ColCustomerID.Name = "ColCustomerID";
            this.ColCustomerID.ReadOnly = true;
            this.ColCustomerID.Visible = false;
            // 
            // ColCarID
            // 
            this.ColCarID.DataPropertyName = "CarID";
            this.ColCarID.HeaderText = "CarID";
            this.ColCarID.Name = "ColCarID";
            this.ColCarID.ReadOnly = true;
            this.ColCarID.Visible = false;
            // 
            // tlpSeatchCondition
            // 
            this.tlpSeatchCondition.AutoSize = true;
            this.tlpSeatchCondition.ColumnCount = 8;
            this.tlpSeatchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpSeatchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpSeatchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpSeatchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpSeatchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpSeatchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpSeatchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeatchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpSeatchCondition.Controls.Add(this.lblNumber, 0, 0);
            this.tlpSeatchCondition.Controls.Add(this.txtNumber, 1, 0);
            this.tlpSeatchCondition.Controls.Add(this.lblOwner, 2, 0);
            this.tlpSeatchCondition.Controls.Add(this.lblMobile, 4, 0);
            this.tlpSeatchCondition.Controls.Add(this.txtMobile, 5, 0);
            this.tlpSeatchCondition.Controls.Add(this.btnSearch, 6, 0);
            this.tlpSeatchCondition.Controls.Add(this.btnNew, 7, 0);
            this.tlpSeatchCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpSeatchCondition.Location = new System.Drawing.Point(0, 0);
            this.tlpSeatchCondition.Name = "tlpSeatchCondition";
            this.tlpSeatchCondition.Padding = new System.Windows.Forms.Padding(3);
            this.tlpSeatchCondition.RowCount = 1;
            this.tlpSeatchCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpSeatchCondition.Size = new System.Drawing.Size(900, 33);
            this.tlpSeatchCondition.TabIndex = 4;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.tlpSeatchCondition);
            this.Controls.Add(this.txtOwner);
            this.Name = "CustomerList";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tlpSeatchCondition.ResumeLayout(false);
            this.tlpSeatchCondition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibrary.Winform.UI.Controls.Label lblNumber;
        private ClassLibrary.Winform.UI.Controls.TextBox txtNumber;
        private ClassLibrary.Winform.UI.Controls.TextBox txtOwner;
        private ClassLibrary.Winform.UI.Controls.Label lblOwner;
        private ClassLibrary.Winform.UI.Controls.Label lblMobile;
        private ClassLibrary.Winform.UI.Controls.TextBox txtMobile;
        private ClassLibrary.Winform.UI.Controls.ButtonEx btnSearch;
        private ClassLibrary.Winform.UI.Controls.ButtonEx btnNew;
        private ClassLibrary.Winform.UI.Controls.DataGridView dgvList;
        private System.Windows.Forms.TableLayoutPanel tlpSeatchCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDisplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBodyColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSolicitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCarID;

    }
}
