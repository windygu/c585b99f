namespace CarManage.UI.Client.Common.Task
{
    partial class TodoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoList));
            this.tlpSeatchCondition = new System.Windows.Forms.TableLayoutPanel();
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
            this.ColModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstimateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFreeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSeatchCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
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
            this.tlpSeatchCondition.Controls.Add(this.txtOwner, 3, 0);
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
            this.tlpSeatchCondition.TabIndex = 2;
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
            this.txtOwner.Location = new System.Drawing.Point(281, 6);
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
            this.btnSearch.ButtonType = ClassLibrary.Winform.UI.Controls.ButtonType.Primary;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(22)))));
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
            this.btnNew.ButtonType = ClassLibrary.Winform.UI.Controls.ButtonType.Primary;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(22)))));
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
            this.ColModel,
            this.ColOwner,
            this.ColActivity,
            this.ColContent,
            this.ColEstimateDate,
            this.ColFreeTime,
            this.ColStatus});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 33);
            this.dgvList.Name = "dgvList";
            this.dgvList.PaintRowNumber = false;
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(900, 467);
            this.dgvList.TabIndex = 3;
            // 
            // colNumber
            // 
            this.colNumber.DataPropertyName = "Number";
            this.colNumber.HeaderText = "车牌号";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 80;
            // 
            // ColModel
            // 
            this.ColModel.DataPropertyName = "Model";
            this.ColModel.HeaderText = "车型";
            this.ColModel.Name = "ColModel";
            this.ColModel.ReadOnly = true;
            // 
            // ColOwner
            // 
            this.ColOwner.DataPropertyName = "Owner";
            this.ColOwner.HeaderText = "车主/使用人";
            this.ColOwner.Name = "ColOwner";
            this.ColOwner.ReadOnly = true;
            // 
            // ColActivity
            // 
            this.ColActivity.DataPropertyName = "Activity";
            this.ColActivity.HeaderText = "业务活动";
            this.ColActivity.Name = "ColActivity";
            this.ColActivity.ReadOnly = true;
            // 
            // ColContent
            // 
            this.ColContent.DataPropertyName = "Content";
            this.ColContent.HeaderText = "招揽内容";
            this.ColContent.Name = "ColContent";
            this.ColContent.ReadOnly = true;
            // 
            // ColEstimateDate
            // 
            this.ColEstimateDate.DataPropertyName = "EstimateDate";
            this.ColEstimateDate.HeaderText = "预计招揽日期";
            this.ColEstimateDate.Name = "ColEstimateDate";
            this.ColEstimateDate.ReadOnly = true;
            this.ColEstimateDate.Width = 120;
            // 
            // ColFreeTime
            // 
            this.ColFreeTime.DataPropertyName = "FreeTime";
            this.ColFreeTime.HeaderText = "习惯接电话时间";
            this.ColFreeTime.Name = "ColFreeTime";
            this.ColFreeTime.ReadOnly = true;
            this.ColFreeTime.Width = 120;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.HeaderText = "状态";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Width = 80;
            // 
            // TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.tlpSeatchCondition);
            this.Name = "TodoList";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.TodoList_Load);
            this.tlpSeatchCondition.ResumeLayout(false);
            this.tlpSeatchCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSeatchCondition;
        private ClassLibrary.Winform.UI.Controls.TextBox txtNumber;
        private ClassLibrary.Winform.UI.Controls.Label lblNumber;
        private ClassLibrary.Winform.UI.Controls.TextBox txtOwner;
        private ClassLibrary.Winform.UI.Controls.Label lblOwner;
        private ClassLibrary.Winform.UI.Controls.Label lblMobile;
        private ClassLibrary.Winform.UI.Controls.TextBox txtMobile;
        private ClassLibrary.Winform.UI.Controls.DataGridView dgvList;
        private ClassLibrary.Winform.UI.Controls.ButtonEx btnSearch;
        private ClassLibrary.Winform.UI.Controls.ButtonEx btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstimateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFreeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;

    }
}
