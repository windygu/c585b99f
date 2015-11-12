using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace DHGateAssistant.UI.Common
{
    public partial class Login : Form
    {
        #region 私有变量

        private int currentX = 0;
        private int currentY = 0;
        //private bool isMove = false;

        //private User user = new User();

        //private DHGateAssistant.Business.Common.PlatformAccount platformAccount =
        //    new PlatformAccount();

        #endregion

        #region  构造函数

        public Login()
        {
            InitializeComponent();
        }

        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            BindUsers();
        }

        #region 处理方法

        #region 为Windows Form画圆角

        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 8);
            this.Region = new Region(FormPath);
        }
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            //path.AddRectangle(arcRect);

            // 左上角
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            this.Refresh();
            //SetWindowRegion();
        }
        //protected override void WndProc(ref Message Msg)
        //{
        //    if (Msg.Msg == FormUtil.WM_NCHITTEST)
        //    {
        //        //获取鼠标位置
        //        int nPosX = (Msg.LParam.ToInt32() & 65535);
        //        int nPosY = (Msg.LParam.ToInt32() >> 16);
        //        //右下角
        //        if (nPosX >= this.Right - 6 && nPosY >= this.Bottom - 6)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_BOTTOMRIGHT);
        //            return;
        //        }
        //        //左上角
        //        else if (nPosX <= this.Left + 6 && nPosY <= this.Top + 6)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_TOPLEFT);
        //            return;
        //        }
        //        //左下角
        //        else if (nPosX <= this.Left + 6 && nPosY >= this.Bottom - 6)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_BOTTOMLEFT);
        //            return;
        //        }
        //        //右上角
        //        else if (nPosX >= this.Right - 6 && nPosY <= this.Top + 6)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_TOPRIGHT);
        //            return;
        //        }
        //        else if (nPosX >= this.Right - 2)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_RIGHT);
        //            return;
        //        }
        //        else if (nPosY >= this.Bottom - 2)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_BOTTOM);
        //            return;
        //        }
        //        else if (nPosX <= this.Left + 2)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_LEFT);
        //            return;
        //        }
        //        else if (nPosY <= this.Top + 2)
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_TOP);
        //            return;
        //        }
        //        else
        //        {
        //            Msg.Result = new IntPtr(FormUtil.HT_CAPTION);
        //            return;
        //        }
        //    }


        //    const int WM_NCLBUTTONDBLCLK = 0xA3;
        //    if (Msg.Msg == WM_NCLBUTTONDBLCLK)
        //    {
        //        return;
        //    }
        //    base.WndProc(ref Msg);
        //}
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1; private const int HTCAPTION = 0x2;
        private const int WM_NCLBUTTONDBLCLK = 0xA3;//鼠标双击标题栏消息
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
                case WM_NCLBUTTONDBLCLK:
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

        ///窗体阴影特效
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams createParams = base.CreateParams;
        //        createParams.ClassStyle |= 0x00020000;
        //        return createParams;
        //    }
        //}

        #endregion

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
            //try
            //{
            //    string userId = CommonUtil.FilterInput(cbxUserName.Text);
            //    string password = CommonUtil.FilterInput(txtPassword.Text);

            //    if (string.IsNullOrEmpty(password))
            //    {
            //        ShowPasswordMessage("请输入密码！", Color.Red);
            //        this.pnlPassword.BackColor = Color.FromArgb(255, 139, 139);
            //        this.txtPassword.Focus();
            //        //this.pnlPasswordForm.BackColor = this.txtPassword.BackColor = Color.FromArgb(255, 229, 229);
            //        return;
            //    }

            //    if (!user.Login(userId, password))
            //    {
            //        ShowMessage("请输入正确的用户名或密码！", Color.Red);
            //        this.pnlUserName.BackColor = Color.FromArgb(255, 139, 139);
            //        this.cbxUserName.Focus();
            //        //this.pnlUserNameForm.BackColor = this.cbxUserName.BackColor = Color.FromArgb(255, 229, 229);
            //        return;
            //    }
            //    else
            //    {
            //        lblMessage.Text = string.Empty;
            //    }

            //    this.Hide();
            //    if (string.IsNullOrEmpty(userId))
            //        return;

            //    UserInfo userinfo = user.Load(userId);
            //    userinfo.Repassword = this.chkRememberPwd.Checked;
            //    user.Update(userinfo);

            //    //if (platformAccount.GetAccountCount().Equals(0))
            //    //{
            //    //    if (ControlManager.ShowConfirmForm("您还没有添加敦煌账号，"
            //    //        + "为保证正常使用，建议您立即添加！").Equals(DialogResult.OK))
            //    //    {
            //    //        SysUserSettingDHAccountAdd accountForm =
            //    //            new SysUserSettingDHAccountAdd();

            //    //        accountForm.ShowDialog();
            //    //    }
            //    //}

            //    ProductManageNew productManage = new ProductManageNew();
            //    productManage.Show();
            //}
            //catch (Exception ex)
            //{
            //    UserInterfaceExceptionHandler.HandlerException("登录失败！", ref ex);
            //    ShowMessage(ex.Message, Color.Red);
            //}
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
        private void ShowMessage(string message, Color foreColor)
        {
            lblMessage.ForeColor = foreColor;
            lblMessage.Text = message;
        }

        private void ShowPasswordMessage(string message, Color foreColor)
        {
            lblPasswordMessage.ForeColor = foreColor;
            lblPasswordMessage.Text = message;
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
            //List<UserInfo> users =user.GetUsers().OrderByDescending(a=>a.SignInDate).ToList(); 
            //    ControlUtil.BindListControl(cbxUserName, users, "UserId", "Repassword");
        }

        private void cbxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.pnlUserName.BackColor = Color.FromArgb(210, 210, 210);
            //this.lblMessage.Text = string.Empty;

            //if (ConvertUtil.ToBoolean(this.cbxUserName.SelectedValue))
            //{
            //    UserInfo userInfo = user.Load(this.cbxUserName.Text.Trim());
            //    this.chkRememberPwd.Checked = true;
            //    this.txtPassword.Text = userInfo.Password;
            //    this.txtPassword.Select(this.txtPassword.Text.Length, 0);
            //}
            //else
            //{
            //    this.chkRememberPwd.Checked = false;
            //    this.txtPassword.Text = string.Empty;
            //}
            //this.btnLogin.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //this.pnlUserName.BackColor = this.pnlPassword.BackColor = Color.FromArgb(210, 210, 210);
            //this.lblMessage.Text = this.lblPasswordMessage.Text = string.Empty;
        }
    }
}
