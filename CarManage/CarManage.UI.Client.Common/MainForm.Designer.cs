namespace CarManage.UI.Client.Common
{
    partial class MainForm
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
            this.neoTabWindow1 = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabWindow();
            this.neoTabPage1 = new ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow1)).BeginInit();
            this.neoTabWindow1.SuspendLayout();
            this.SuspendLayout();
            // 
            // neoTabWindow1
            // 
            this.neoTabWindow1.Controls.Add(this.neoTabPage1);
            this.neoTabWindow1.DefaultTabPageBorderStyle.Color = System.Drawing.SystemColors.ActiveBorder;
            this.neoTabWindow1.DefaultTabPageBorderStyle.Width = 1;
            this.neoTabWindow1.Location = new System.Drawing.Point(0, 0);
            this.neoTabWindow1.Name = "neoTabWindow1";
            this.neoTabWindow1.RendererName = null;
            this.neoTabWindow1.SelectedIndex = 0;
            this.neoTabWindow1.Size = new System.Drawing.Size(300, 200);
            this.neoTabWindow1.TabContentSpacing = 1;
            this.neoTabWindow1.TabIndex = 0;
            this.neoTabWindow1.TabItemActiveBackColor = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabItemActiveBorderStyle.Color = System.Drawing.SystemColors.ActiveBorder;
            this.neoTabWindow1.TabItemActiveBorderStyle.Width = 1;
            this.neoTabWindow1.TabItemActiveForeColor = System.Drawing.SystemColors.ControlText;
            this.neoTabWindow1.TabItemAreaBackColor = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabItemAreaBackGroudImage = null;
            this.neoTabWindow1.TabItemAreaBorderStyle.Color = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabItemAreaBorderStyle.Width = 1;
            this.neoTabWindow1.TabItemAreaMargin = new System.Windows.Forms.Padding(0);
            this.neoTabWindow1.TabItemBackColor = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabItemBorderStyle.Color = System.Drawing.SystemColors.ActiveBorder;
            this.neoTabWindow1.TabItemBorderStyle.Width = 1;
            this.neoTabWindow1.TabItemDisabledBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.neoTabWindow1.TabItemDisabledBorderStyle.Color = System.Drawing.SystemColors.InactiveBorder;
            this.neoTabWindow1.TabItemDisabledBorderStyle.Width = 1;
            this.neoTabWindow1.TabItemDisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.neoTabWindow1.TabItemFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neoTabWindow1.TabItemForeColor = System.Drawing.SystemColors.ControlText;
            this.neoTabWindow1.TabItemHeight = 0;
            this.neoTabWindow1.TabItemHoverBackColor = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabItemHoverBorderStyle.Color = System.Drawing.SystemColors.ActiveBorder;
            this.neoTabWindow1.TabItemHoverBorderStyle.Width = 1;
            this.neoTabWindow1.TabItemHoverForeColor = System.Drawing.SystemColors.ControlText;
            this.neoTabWindow1.TabItemLayout = ClassLibrary.Winform.UI.Controls.PluggableTabControl.TabItemLayout.Top;
            this.neoTabWindow1.TabItemSpacing = 0;
            this.neoTabWindow1.TabItemStyle = ClassLibrary.Winform.UI.Controls.PluggableTabControl.TabItemStyle.Text;
            this.neoTabWindow1.TabItemWidth = 0;
            this.neoTabWindow1.TabPageAreaBackColor = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabPageAreaPadding = new System.Windows.Forms.Padding(0);
            this.neoTabWindow1.TabPageBottomBorderStyle.Color = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabPageBottomBorderStyle.Width = 1;
            this.neoTabWindow1.TabPageLeftBorderStyle.Color = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabPageLeftBorderStyle.Width = 1;
            this.neoTabWindow1.TabPageRightBorderStyle.Color = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabPageRightBorderStyle.Width = 1;
            this.neoTabWindow1.TabPageTopBorderStyle.Color = System.Drawing.Color.Empty;
            this.neoTabWindow1.TabPageTopBorderStyle.Width = 1;
            this.neoTabWindow1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // neoTabPage1
            // 
            this.neoTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.neoTabPage1.Name = "neoTabPage1";
            this.neoTabPage1.TabActiveImage = null;
            this.neoTabPage1.TabDistabledImage = null;
            this.neoTabPage1.TabHoverImage = null;
            this.neoTabPage1.TabImage = null;
            this.neoTabPage1.Text = "neoTabPage1";
            this.neoTabPage1.ToolTipText = "neoTabPage1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 746);
            this.Controls.Add(this.neoTabWindow1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow1)).EndInit();
            this.neoTabWindow1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabWindow neoTabWindow1;
        private ClassLibrary.Winform.UI.Controls.PluggableTabControl.NeoTabPage neoTabPage1;
    }
}