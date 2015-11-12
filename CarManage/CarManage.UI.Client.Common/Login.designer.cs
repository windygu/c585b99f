namespace CarManage.UI.Client.Common
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pbxFormClose = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlPasswordForm = new System.Windows.Forms.Panel();
            this.txtPassword = new ClassLibrary.Winform.UI.Controls.TextBox(this.components);
            this.liklblFindPassword = new System.Windows.Forms.LinkLabel();
            this.lblPasswordMessage = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.pnlUserNameForm = new System.Windows.Forms.Panel();
            this.cbxUserName = new ClassLibrary.Winform.UI.Controls.ComboBox();
            this.chkRememberPwd = new ClassLibrary.Winform.UI.Controls.CheckBox(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormClose)).BeginInit();
            this.pnlPassword.SuspendLayout();
            this.pnlPasswordForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            this.pnlUserName.SuspendLayout();
            this.pnlUserNameForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxFormClose
            // 
            this.pbxFormClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxFormClose.BackgroundImage")));
            this.pbxFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFormClose.Location = new System.Drawing.Point(482, 33);
            this.pbxFormClose.Margin = new System.Windows.Forms.Padding(4);
            this.pbxFormClose.Name = "pbxFormClose";
            this.pbxFormClose.Size = new System.Drawing.Size(16, 15);
            this.pbxFormClose.TabIndex = 1;
            this.pbxFormClose.TabStop = false;
            this.pbxFormClose.Click += new System.EventHandler(this.pbxFormClose_Click);
            this.pbxFormClose.MouseLeave += new System.EventHandler(this.pbxFormClose_MouseLeave);
            this.pbxFormClose.MouseHover += new System.EventHandler(this.pbxFormClose_MouseHover);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblUserName.Location = new System.Drawing.Point(34, 308);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户名:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPassword.Location = new System.Drawing.Point(54, 386);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "密码:";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyRight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCopyRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCopyRight.Location = new System.Drawing.Point(48, 573);
            this.lblCopyRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(447, 30);
            this.lblCopyRight.TabIndex = 11;
            this.lblCopyRight.Text = "逸联互通";
            this.lblCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pnlPassword.Controls.Add(this.pnlPasswordForm);
            this.pnlPassword.Location = new System.Drawing.Point(123, 370);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Padding = new System.Windows.Forms.Padding(2);
            this.pnlPassword.Size = new System.Drawing.Size(363, 50);
            this.pnlPassword.TabIndex = 10;
            // 
            // pnlPasswordForm
            // 
            this.pnlPasswordForm.BackColor = System.Drawing.Color.White;
            this.pnlPasswordForm.Controls.Add(this.txtPassword);
            this.pnlPasswordForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPasswordForm.Location = new System.Drawing.Point(2, 2);
            this.pnlPasswordForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPasswordForm.Name = "pnlPasswordForm";
            this.pnlPasswordForm.Size = new System.Drawing.Size(359, 46);
            this.pnlPasswordForm.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Empty;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.BorderWidth = 1;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPassword.Location = new System.Drawing.Point(3, 9);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(354, 28);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.WordWrap = false;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // liklblFindPassword
            // 
            this.liklblFindPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.liklblFindPassword.AutoSize = true;
            this.liklblFindPassword.BackColor = System.Drawing.Color.Transparent;
            this.liklblFindPassword.Font = new System.Drawing.Font("宋体", 9.5F);
            this.liklblFindPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.liklblFindPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.liklblFindPassword.Location = new System.Drawing.Point(394, 531);
            this.liklblFindPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liklblFindPassword.Name = "liklblFindPassword";
            this.liklblFindPassword.Size = new System.Drawing.Size(85, 19);
            this.liklblFindPassword.TabIndex = 19;
            this.liklblFindPassword.TabStop = true;
            this.liklblFindPassword.Text = "找回密码";
            this.liklblFindPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liklblFindPassword_LinkClicked);
            // 
            // lblPasswordMessage
            // 
            this.lblPasswordMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordMessage.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPasswordMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblPasswordMessage.Location = new System.Drawing.Point(123, 424);
            this.lblPasswordMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordMessage.Name = "lblPasswordMessage";
            this.lblPasswordMessage.Size = new System.Drawing.Size(360, 21);
            this.lblPasswordMessage.TabIndex = 15;
            this.lblPasswordMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(123, 345);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(360, 21);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(124, 450);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 52);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pnlUserName.Controls.Add(this.pnlUserNameForm);
            this.pnlUserName.Location = new System.Drawing.Point(123, 291);
            this.pnlUserName.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Padding = new System.Windows.Forms.Padding(2);
            this.pnlUserName.Size = new System.Drawing.Size(363, 50);
            this.pnlUserName.TabIndex = 12;
            // 
            // pnlUserNameForm
            // 
            this.pnlUserNameForm.BackColor = System.Drawing.Color.White;
            this.pnlUserNameForm.Controls.Add(this.cbxUserName);
            this.pnlUserNameForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserNameForm.Location = new System.Drawing.Point(2, 2);
            this.pnlUserNameForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserNameForm.Name = "pnlUserNameForm";
            this.pnlUserNameForm.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.pnlUserNameForm.Size = new System.Drawing.Size(359, 46);
            this.pnlUserNameForm.TabIndex = 11;
            // 
            // cbxUserName
            // 
            this.cbxUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUserName.BackColor = System.Drawing.Color.White;
            this.cbxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUserName.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbxUserName.ItemHeight = 27;
            this.cbxUserName.Items.AddRange(new object[] {
            "                                    "});
            this.cbxUserName.Location = new System.Drawing.Point(2, 3);
            this.cbxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.cbxUserName.Name = "cbxUserName";
            this.cbxUserName.Size = new System.Drawing.Size(355, 35);
            this.cbxUserName.TabIndex = 10;
            this.cbxUserName.SelectedIndexChanged += new System.EventHandler(this.cbxUserName_SelectedIndexChanged);
            this.cbxUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // chkRememberPwd
            // 
            this.chkRememberPwd.AutoSize = true;
            this.chkRememberPwd.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberPwd.Font = new System.Drawing.Font("宋体", 9F);
            this.chkRememberPwd.Location = new System.Drawing.Point(128, 531);
            this.chkRememberPwd.Margin = new System.Windows.Forms.Padding(4);
            this.chkRememberPwd.Name = "chkRememberPwd";
            this.chkRememberPwd.Size = new System.Drawing.Size(106, 22);
            this.chkRememberPwd.TabIndex = 11;
            this.chkRememberPwd.Text = "记住密码";
            this.chkRememberPwd.UseVisualStyleBackColor = false;
            this.chkRememberPwd.Value = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(142)))), ((int)(((byte)(231)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlUserName);
            this.Controls.Add(this.chkRememberPwd);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasswordMessage);
            this.Controls.Add(this.liklblFindPassword);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pbxFormClose);
            this.Controls.Add(this.lblMessage);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "逸联互通-登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormClose)).EndInit();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPasswordForm.ResumeLayout(false);
            this.pnlPasswordForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserNameForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibrary.Winform.UI.Controls.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbxFormClose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlPasswordForm;
        private System.Windows.Forms.LinkLabel liklblFindPassword;
        private System.Windows.Forms.Label lblPasswordMessage;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private ClassLibrary.Winform.UI.Controls.CheckBox chkRememberPwd;
        private ClassLibrary.Winform.UI.Controls.ComboBox cbxUserName;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.Panel pnlUserNameForm;
        private System.Windows.Forms.Button button1;
    }
}