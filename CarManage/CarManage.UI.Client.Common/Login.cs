using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;

using ClassLibrary.ExceptionHandling;
using CarManage.Configuration;
using ClassLibrary.Utility.Form;
using ClassLibrary.Utility.Common;
using ClassLibrary.Winform.UI.Forms;
using CarManage.Business.User;
using CarManage.Model.User;

namespace CarManage.UI.Client.Common
{
    public partial class Login : CustomTitleBarForm
    {
        #region 私有变量

        private User user;

        #endregion

        #region  构造函数

        public Login()
        {
            InitializeComponent();
        }

        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            CustomLoad();
        }

        protected override void Init()
        {
            user = new User();

            base.Init();
        }

        private void CustomLoad()
        {
            try
            {
                BindUsers();
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("窗体初始化失败！", ref ex);
            }
        }

        #region  事件

        private void liklblFindPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (!e.Button.Equals(MouseButtons.Left))
            //    return;
            //Forms.FindPassword findPassword = new FindPassword();
            //findPassword.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = CommonUtil.FilterInput(cbxUserName.Text);
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(userName)||string.IsNullOrEmpty(password))
                {
                    ShowMessage("请输入用户名和密码！");
                    return;
                }

                user.SignIn(userName, password);

                if (!chkRememberPwd.Checked)
                    password = string.Empty;

                CarManageConfig.Instance.SaveRecentUser(userName, password);

                this.Hide();

                //ProductManageNew productManage = new ProductManageNew();
                //productManage.Show();
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("登录失败！", ref ex);
                ShowMessage(ex.Message);
            }
        }

        private void pbxFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void pbxTopLogo_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (!isMove)
        //    {
        //        currentX = MousePosition.X;
        //        currentY = MousePosition.Y;
        //        isMove = true;
        //    }
        //}

        //private void pbxTopLogo_MouseUp(object sender, MouseEventArgs e)
        //{
        //    isMove = false;
        //}

        //private void pbxTopLogo_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isMove)
        //    {
        //        this.Left = this.Left + (MousePosition.X - currentX);
        //        this.Top = this.Top + (MousePosition.Y - currentY);
        //        currentX = MousePosition.X;
        //        currentY = MousePosition.Y;
        //    }
        //}

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        /// <summary>
        /// 显示登录信息
        /// </summary>
        /// <param name="message"></param>
        private void ShowMessage(string message)
        {
            lblMessage.Text = message;
            lblMessage.Visible = true;
        }

        private void pbxFormClose_MouseHover(object sender, EventArgs e)
        {
            //pbxFormClose.Image =
            //    DHGateAssistant.Resource.Common.ImageResource.Login_Close_Hover;
        }

        private void pbxFormClose_MouseLeave(object sender, EventArgs e)
        {
            //pbxFormClose.Image =
            //    DHGateAssistant.Resource.Common.ImageResource.Login_Close;
        }
        #endregion

        private void BindUsers()
        {
            ControlUtil.BindListControl(cbxUserName, user.GetRecentUsers(), "UserName", "Password", 0);
        }

        private void cbxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxUserName.SelectedValue != null && !string.IsNullOrEmpty(cbxUserName.SelectedValue.ToString()))
                {
                    chkRememberPwd.Checked = true;
                    txtPassword.Text = cbxUserName.SelectedValue.ToString();
                    txtPassword.Select(0, txtPassword.Text.Length);
                }
                else
                {
                    chkRememberPwd.Checked = false;
                    txtPassword.Text = string.Empty;
                }

                this.btnLogin.Focus();
            }
            catch
            { 
                
            }
        }
    }
}
