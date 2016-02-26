namespace CarManage.UI.Generic.Forms
{
    partial class CustomTitleBarBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCustomTitleBar = new ClassLibrary.Winform.UI.Controls.Panel(this.components);
            this.pbxMin = new ClassLibrary.Winform.UI.Controls.PictureBoxEx(this.components);
            this.pbxMax = new ClassLibrary.Winform.UI.Controls.PictureBoxEx(this.components);
            this.pbxClose = new ClassLibrary.Winform.UI.Controls.PictureBoxEx(this.components);
            this.pnlCustomTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomTitleBar
            // 
            this.pnlCustomTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(153)))), ((int)(((byte)(206)))));
            this.pnlCustomTitleBar.Controls.Add(this.pbxMin);
            this.pnlCustomTitleBar.Controls.Add(this.pbxMax);
            this.pnlCustomTitleBar.Controls.Add(this.pbxClose);
            this.pnlCustomTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCustomTitleBar.Name = "pnlCustomTitleBar";
            this.pnlCustomTitleBar.Size = new System.Drawing.Size(284, 20);
            this.pnlCustomTitleBar.TabIndex = 0;
            this.pnlCustomTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCustomTitleBar_MouseDown);
            // 
            // pbxMin
            // 
            this.pbxMin.ClickImage = null;
            this.pbxMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxMin.EnableEffect = true;
            this.pbxMin.HoverImage = null;
            this.pbxMin.Location = new System.Drawing.Point(224, 0);
            this.pbxMin.Name = "pbxMin";
            this.pbxMin.NormalImage = null;
            this.pbxMin.Size = new System.Drawing.Size(20, 20);
            this.pbxMin.TabIndex = 2;
            this.pbxMin.TabStop = false;
            this.pbxMin.Click += new System.EventHandler(this.pbxMin_Click);
            // 
            // pbxMax
            // 
            this.pbxMax.ClickImage = null;
            this.pbxMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxMax.EnableEffect = true;
            this.pbxMax.HoverImage = null;
            this.pbxMax.Location = new System.Drawing.Point(244, 0);
            this.pbxMax.Name = "pbxMax";
            this.pbxMax.NormalImage = null;
            this.pbxMax.Size = new System.Drawing.Size(20, 20);
            this.pbxMax.TabIndex = 1;
            this.pbxMax.TabStop = false;
            this.pbxMax.Click += new System.EventHandler(this.pbxMax_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.ClickImage = null;
            this.pbxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxClose.EnableEffect = true;
            this.pbxClose.HoverImage = null;
            this.pbxClose.Location = new System.Drawing.Point(264, 0);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.NormalImage = null;
            this.pbxClose.Size = new System.Drawing.Size(20, 20);
            this.pbxClose.TabIndex = 0;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // CustomTitleBarBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlCustomTitleBar);
            this.Name = "CustomTitleBarBaseForm";
            this.Load += new System.EventHandler(this.CustomTitleBarBaseForm_Load);
            this.pnlCustomTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary.Winform.UI.Controls.Panel pnlCustomTitleBar;
        private ClassLibrary.Winform.UI.Controls.PictureBoxEx pbxClose;
        private ClassLibrary.Winform.UI.Controls.PictureBoxEx pbxMin;
        private ClassLibrary.Winform.UI.Controls.PictureBoxEx pbxMax;
    }
}