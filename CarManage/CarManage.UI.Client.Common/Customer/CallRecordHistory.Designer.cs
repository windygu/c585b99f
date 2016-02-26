namespace CarManage.UI.Client.Common.Customer
{
    partial class CallRecordHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCallRecord = new ClassLibrary.Winform.UI.Controls.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallRecord)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCallRecord
            // 
            this.dgvCallRecord.AllowUserToAddRows = false;
            this.dgvCallRecord.AllowUserToDeleteRows = false;
            this.dgvCallRecord.AllowUserToResizeRows = false;
            this.dgvCallRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvCallRecord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dgvCallRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCallRecord.CheckBoxBorderColor = System.Drawing.Color.Empty;
            this.dgvCallRecord.CheckedAll = false;
            this.dgvCallRecord.CheckedImage = null;
            this.dgvCallRecord.ColumnHeaderBackgroundImage = null;
            this.dgvCallRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCallRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCallRecord.ColumnHeadersHeight = 21;
            this.dgvCallRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCallRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colCarNumber,
            this.colResultText,
            this.colFeedback,
            this.colCreateDate,
            this.colId});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCallRecord.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvCallRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvCallRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvCallRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCallRecord.MultiSelect = false;
            this.dgvCallRecord.Name = "dgvCallRecord";
            this.dgvCallRecord.PaintRowNumber = false;
            this.dgvCallRecord.ReadOnly = true;
            this.dgvCallRecord.RowHeadersVisible = false;
            this.dgvCallRecord.RowTemplate.Height = 30;
            this.dgvCallRecord.Size = new System.Drawing.Size(655, 134);
            this.dgvCallRecord.TabIndex = 4;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTitle.DefaultCellStyle = dataGridViewCellStyle16;
            this.colTitle.FillWeight = 80F;
            this.colTitle.HeaderText = "通话事项";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTitle.Width = 200;
            // 
            // colCarNumber
            // 
            this.colCarNumber.DataPropertyName = "CarNumber";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCarNumber.DefaultCellStyle = dataGridViewCellStyle17;
            this.colCarNumber.HeaderText = "车牌号";
            this.colCarNumber.Name = "colCarNumber";
            this.colCarNumber.ReadOnly = true;
            this.colCarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCarNumber.Width = 50;
            // 
            // colResultText
            // 
            this.colResultText.DataPropertyName = "ResultText";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colResultText.DefaultCellStyle = dataGridViewCellStyle18;
            this.colResultText.HeaderText = "结果";
            this.colResultText.Name = "colResultText";
            this.colResultText.ReadOnly = true;
            this.colResultText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colResultText.Width = 80;
            // 
            // colFeedback
            // 
            this.colFeedback.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFeedback.DataPropertyName = "Feedback";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFeedback.DefaultCellStyle = dataGridViewCellStyle19;
            this.colFeedback.HeaderText = "客户反馈";
            this.colFeedback.Name = "colFeedback";
            this.colFeedback.ReadOnly = true;
            this.colFeedback.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCreateDate
            // 
            this.colCreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "d";
            this.colCreateDate.DefaultCellStyle = dataGridViewCellStyle20;
            this.colCreateDate.HeaderText = "通话日期";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.ReadOnly = true;
            this.colCreateDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCreateDate.Width = 80;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "主键";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(208, 171);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 153);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1asdasdasdasdasd";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 109);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CallRecordHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvCallRecord);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CallRecordHistory";
            this.Size = new System.Drawing.Size(655, 361);
            this.Load += new System.EventHandler(this.CallRecordHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallRecord)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary.Winform.UI.Controls.DataGridView dgvCallRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
