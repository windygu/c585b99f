namespace ClassLibrary.Winform.UI.Controls
{
    partial class AccordionItem
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
            this.lblText = new ClassLibrary.Winform.UI.Controls.Label(this.components);
            this.pbxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Location = new System.Drawing.Point(25, 5);
            this.lblText.Name = "lblText";
            this.lblText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblText.Size = new System.Drawing.Size(178, 20);
            this.lblText.TabIndex = 1;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            this.lblText.MouseEnter += new System.EventHandler(this.lblText_MouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.lblText_MouseLeave);
            // 
            // pbxImage
            // 
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxImage.Location = new System.Drawing.Point(5, 5);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(20, 20);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            this.pbxImage.Click += new System.EventHandler(this.pbxImage_Click);
            this.pbxImage.MouseEnter += new System.EventHandler(this.pbxImage_MouseEnter);
            this.pbxImage.MouseLeave += new System.EventHandler(this.pbxImage_MouseLeave);
            // 
            // AccordionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbxImage);
            this.Name = "AccordionItem";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.Size = new System.Drawing.Size(203, 30);
            this.Click += new System.EventHandler(this.AccordionItem_Click);
            this.MouseEnter += new System.EventHandler(this.AccordionItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AccordionItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private Label lblText;
    }
}
