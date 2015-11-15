namespace CarManage.UI.Test
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new ClassLibrary.Winform.UI.Controls.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControl21 = new CarManage.UI.Test.UserControl2();
            this.userControl11 = new CarManage.UI.Test.UserControl1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 51);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.BorderWidth = 1;
            this.textBox1.DecimalPrecision = 0;
            this.textBox1.Location = new System.Drawing.Point(184, 7);
            this.textBox1.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.textBox1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextMode = ClassLibrary.Winform.UI.Controls.TextMode.Numeric;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl21);
            this.panel2.Controls.Add(this.userControl11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 592);
            this.panel2.TabIndex = 3;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(65, 37);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1320, 675);
            this.userControl21.TabIndex = 1;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.userControl11.Location = new System.Drawing.Point(23, 6);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1113, 642);
            this.userControl11.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
        private ClassLibrary.Winform.UI.Controls.TextBox textBox1;
    }
}