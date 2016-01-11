namespace CarManage.UI.Test
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.accordionItem1 = new ClassLibrary.Winform.UI.Controls.AccordionItem();
            this.SuspendLayout();
            // 
            // accordionItem1
            // 
            this.accordionItem1.ActiveBackgroundImage = null;
            this.accordionItem1.ActiveColor = System.Drawing.Color.Empty;
            this.accordionItem1.ActiveForeColor = System.Drawing.Color.Empty;
            this.accordionItem1.BackColor = System.Drawing.SystemColors.Control;
            this.accordionItem1.BorderColor = System.Drawing.Color.Red;
            this.accordionItem1.ForeColor = System.Drawing.Color.Maroon;
            this.accordionItem1.HoverBackgroundImage = null;
            this.accordionItem1.HoverColor = System.Drawing.Color.Empty;
            this.accordionItem1.HoverForeColor = System.Drawing.Color.Empty;
            this.accordionItem1.Icon = null;
            this.accordionItem1.ItemText = "asdasdasd";
            this.accordionItem1.Location = new System.Drawing.Point(39, 57);
            this.accordionItem1.Name = "accordionItem1";
            this.accordionItem1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.accordionItem1.Size = new System.Drawing.Size(203, 30);
            this.accordionItem1.TabIndex = 0;
            this.accordionItem1.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.accordionItem1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary.Winform.UI.Controls.AccordionItem accordionItem1;




    }
}

