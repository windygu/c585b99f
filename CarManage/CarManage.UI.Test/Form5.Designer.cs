namespace CarManage.UI.Test
{
    partial class Form5
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
            this.accordion1 = new ClassLibrary.Winform.UI.Controls.Accordion(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accordion1
            // 
            this.accordion1.ActiveBackColor = System.Drawing.Color.Empty;
            this.accordion1.ActiveBackgroundImage = null;
            this.accordion1.ActiveForeColor = System.Drawing.SystemColors.ControlText;
            this.accordion1.BorderColor = System.Drawing.Color.Empty;
            this.accordion1.HoverBackColor = System.Drawing.Color.Empty;
            this.accordion1.HoverBackgroundImage = null;
            this.accordion1.HoverForeColor = System.Drawing.SystemColors.ControlText;
            this.accordion1.Location = new System.Drawing.Point(0, 0);
            this.accordion1.Name = "accordion1";
            this.accordion1.NormalBackColor = System.Drawing.Color.Empty;
            this.accordion1.NormalBackgroundImage = null;
            this.accordion1.NormalForeColor = System.Drawing.SystemColors.ControlText;
            this.accordion1.SelectedIndex = -1;
            this.accordion1.Size = new System.Drawing.Size(200, 100);
            this.accordion1.TabIndex = 0;
            this.accordion1.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(314, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 187);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 32);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 30);
            this.panel3.TabIndex = 1;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accordion1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary.Winform.UI.Controls.Accordion accordion1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;

    }
}