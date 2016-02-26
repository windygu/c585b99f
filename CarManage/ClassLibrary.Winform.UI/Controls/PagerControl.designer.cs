namespace ClassLibrary.Winform.UI.Controls
{
    partial class PagerControl
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
            this.lnkbtnNext = new System.Windows.Forms.Label();
            this.pnlControllMaster = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.pnlNavigator = new System.Windows.Forms.Panel();
            this.lnkbtnPrevious = new System.Windows.Forms.Label();
            this.lnkbtnFirst = new System.Windows.Forms.Label();
            this.lnkbtnLast = new System.Windows.Forms.Label();
            this.pnlPageIndex = new System.Windows.Forms.Panel();
            this.nudPageIndex = new System.Windows.Forms.NumericUpDown();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblPageIndex = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxPageSize = new System.Windows.Forms.ComboBox();
            this.pnlLeftPlaceHolder = new System.Windows.Forms.Panel();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlControllMaster.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlNavigator.SuspendLayout();
            this.pnlPageIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageIndex)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlLeftPlaceHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkbtnNext
            // 
            this.lnkbtnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnkbtnNext.AutoSize = true;
            this.lnkbtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkbtnNext.Enabled = false;
            this.lnkbtnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lnkbtnNext.Location = new System.Drawing.Point(93, 14);
            this.lnkbtnNext.Name = "lnkbtnNext";
            this.lnkbtnNext.Size = new System.Drawing.Size(41, 12);
            this.lnkbtnNext.TabIndex = 1;
            this.lnkbtnNext.TabStop = true;
            this.lnkbtnNext.Text = "下一页";
            this.lnkbtnNext.Click += new System.EventHandler(this.lnkbtnNext_Click);
            // 
            // pnlControllMaster
            // 
            this.pnlControllMaster.Controls.Add(this.tableLayoutPanel1);
            this.pnlControllMaster.Controls.Add(this.lblPageIndex);
            this.pnlControllMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControllMaster.Location = new System.Drawing.Point(300, 0);
            this.pnlControllMaster.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControllMaster.Name = "pnlControllMaster";
            this.pnlControllMaster.Size = new System.Drawing.Size(450, 40);
            this.pnlControllMaster.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlNavigator, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPageIndex, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 40);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTotalPage.Location = new System.Drawing.Point(204, 13);
            this.lblTotalPage.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(35, 14);
            this.lblTotalPage.TabIndex = 11;
            this.lblTotalPage.Text = "/{0}";
            // 
            // pnlNavigator
            // 
            this.pnlNavigator.Controls.Add(this.lnkbtnPrevious);
            this.pnlNavigator.Controls.Add(this.lnkbtnFirst);
            this.pnlNavigator.Controls.Add(this.lnkbtnNext);
            this.pnlNavigator.Controls.Add(this.lnkbtnLast);
            this.pnlNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigator.Location = new System.Drawing.Point(270, 0);
            this.pnlNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavigator.Name = "pnlNavigator";
            this.pnlNavigator.Size = new System.Drawing.Size(180, 40);
            this.pnlNavigator.TabIndex = 14;
            // 
            // lnkbtnPrevious
            // 
            this.lnkbtnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnkbtnPrevious.AutoSize = true;
            this.lnkbtnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkbtnPrevious.Enabled = false;
            this.lnkbtnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lnkbtnPrevious.Location = new System.Drawing.Point(46, 14);
            this.lnkbtnPrevious.Name = "lnkbtnPrevious";
            this.lnkbtnPrevious.Size = new System.Drawing.Size(41, 12);
            this.lnkbtnPrevious.TabIndex = 2;
            this.lnkbtnPrevious.TabStop = true;
            this.lnkbtnPrevious.Text = "上一页";
            this.lnkbtnPrevious.Click += new System.EventHandler(this.lnkbtnPrevious_Click);
            // 
            // lnkbtnFirst
            // 
            this.lnkbtnFirst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnkbtnFirst.AutoSize = true;
            this.lnkbtnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkbtnFirst.Enabled = false;
            this.lnkbtnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lnkbtnFirst.Location = new System.Drawing.Point(11, 14);
            this.lnkbtnFirst.Name = "lnkbtnFirst";
            this.lnkbtnFirst.Size = new System.Drawing.Size(29, 12);
            this.lnkbtnFirst.TabIndex = 1;
            this.lnkbtnFirst.TabStop = true;
            this.lnkbtnFirst.Text = "首页";
            this.lnkbtnFirst.Click += new System.EventHandler(this.lnkbtnFirst_Click);
            // 
            // lnkbtnLast
            // 
            this.lnkbtnLast.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnkbtnLast.AutoSize = true;
            this.lnkbtnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkbtnLast.Enabled = false;
            this.lnkbtnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lnkbtnLast.Location = new System.Drawing.Point(140, 14);
            this.lnkbtnLast.Name = "lnkbtnLast";
            this.lnkbtnLast.Size = new System.Drawing.Size(29, 12);
            this.lnkbtnLast.TabIndex = 3;
            this.lnkbtnLast.TabStop = true;
            this.lnkbtnLast.Text = "尾页";
            this.lnkbtnLast.Click += new System.EventHandler(this.lnkbtnLast_Click);
            // 
            // pnlPageIndex
            // 
            this.pnlPageIndex.Controls.Add(this.nudPageIndex);
            this.pnlPageIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPageIndex.Location = new System.Drawing.Point(0, 0);
            this.pnlPageIndex.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPageIndex.Name = "pnlPageIndex";
            this.pnlPageIndex.Size = new System.Drawing.Size(204, 40);
            this.pnlPageIndex.TabIndex = 15;
            // 
            // nudPageIndex
            // 
            this.nudPageIndex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudPageIndex.Location = new System.Drawing.Point(151, 11);
            this.nudPageIndex.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPageIndex.Name = "nudPageIndex";
            this.nudPageIndex.Size = new System.Drawing.Size(50, 21);
            this.nudPageIndex.TabIndex = 13;
            this.nudPageIndex.ValueChanged += new System.EventHandler(this.nudPageIndex_ValueChanged);
            this.nudPageIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPageIndex_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.Color.White;
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.Location = new System.Drawing.Point(242, 8);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(25, 23);
            this.btnGo.TabIndex = 16;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblPageIndex
            // 
            this.lblPageIndex.AutoSize = true;
            this.lblPageIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblPageIndex.Location = new System.Drawing.Point(2, -12);
            this.lblPageIndex.Name = "lblPageIndex";
            this.lblPageIndex.Size = new System.Drawing.Size(65, 12);
            this.lblPageIndex.TabIndex = 12;
            this.lblPageIndex.Text = "当前页码：";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTotalCount.Location = new System.Drawing.Point(46, 13);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(26, 12);
            this.lblTotalCount.TabIndex = 9;
            this.lblTotalCount.Text = "{0}";
            this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.pnlLeftPlaceHolder);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 40);
            this.pnlLeft.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxPageSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(183, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 40);
            this.panel1.TabIndex = 1;
            // 
            // cbxPageSize
            // 
            this.cbxPageSize.BackColor = System.Drawing.SystemColors.Window;
            this.cbxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPageSize.FormattingEnabled = true;
            this.cbxPageSize.Items.AddRange(new object[] {
            "30",
            "50",
            "80",
            "200"});
            this.cbxPageSize.Location = new System.Drawing.Point(3, 9);
            this.cbxPageSize.Margin = new System.Windows.Forms.Padding(0);
            this.cbxPageSize.Name = "cbxPageSize";
            this.cbxPageSize.Size = new System.Drawing.Size(43, 20);
            this.cbxPageSize.TabIndex = 13;
            this.cbxPageSize.SelectedIndexChanged += new System.EventHandler(this.cbxPageSize_SelectedIndexChanged);
            // 
            // pnlLeftPlaceHolder
            // 
            this.pnlLeftPlaceHolder.AutoSize = true;
            this.pnlLeftPlaceHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLeftPlaceHolder.Controls.Add(this.lblPageSize);
            this.pnlLeftPlaceHolder.Controls.Add(this.label2);
            this.pnlLeftPlaceHolder.Controls.Add(this.lblTotalCount);
            this.pnlLeftPlaceHolder.Controls.Add(this.label1);
            this.pnlLeftPlaceHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftPlaceHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftPlaceHolder.Name = "pnlLeftPlaceHolder";
            this.pnlLeftPlaceHolder.Padding = new System.Windows.Forms.Padding(5, 13, 0, 0);
            this.pnlLeftPlaceHolder.Size = new System.Drawing.Size(183, 40);
            this.pnlLeftPlaceHolder.TabIndex = 0;
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPageSize.Location = new System.Drawing.Point(113, 13);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPageSize.Size = new System.Drawing.Size(70, 12);
            this.lblPageSize.TabIndex = 12;
            this.lblPageSize.Text = "每页显示：";
            this.lblPageSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(72, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "条数据";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "当前共";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.pnlControllMaster);
            this.Controls.Add(this.pnlLeft);
            this.DoubleBuffered = true;
            this.Name = "PagerControl";
            this.Size = new System.Drawing.Size(750, 40);
            this.pnlControllMaster.ResumeLayout(false);
            this.pnlControllMaster.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlNavigator.ResumeLayout(false);
            this.pnlNavigator.PerformLayout();
            this.pnlPageIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPageIndex)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlLeftPlaceHolder.ResumeLayout(false);
            this.pnlLeftPlaceHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lnkbtnNext;
        private System.Windows.Forms.Panel pnlControllMaster;
        private System.Windows.Forms.Label lnkbtnLast;
        private System.Windows.Forms.Label lnkbtnPrevious;
        private System.Windows.Forms.Label lnkbtnFirst;
        private System.Windows.Forms.Label lblPageIndex;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.NumericUpDown nudPageIndex;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLeftPlaceHolder;
        private System.Windows.Forms.ComboBox cbxPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNavigator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlPageIndex;
        private System.Windows.Forms.Button btnGo;
    }
}
