using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CarManage.UI.Generic.Forms
{
    public partial class CustomTitleBarBaseForm : ClassLibrary.Winform.UI.Forms.CustomTitleBarForm
    {
        public override bool AllowMinSize
        {
            get
            {
                return pbxMin.Visible;
            }
            set
            {
                pbxMin.Visible = value;
            }
        }

        public override bool AllowMaxSize
        {
            get
            {
                return pbxMax.Visible;
            }
            set
            {
                pbxMax.Visible = value;
            }
        }

        public CustomTitleBarBaseForm()
        {
            InitializeComponent();

            InitControl();

            AllowMinSize = AllowMaxSize = true;
        }

        private void InitControl()
        {
            pbxMin.NormalImage = CarManage.Resources.Common.ImageResource.Title_Min;
            pbxMin.HoverImage = CarManage.Resources.Common.ImageResource.Title_Min;
            pbxMin.ClickImage = CarManage.Resources.Common.ImageResource.Title_Min;

            pbxMax.NormalImage = CarManage.Resources.Common.ImageResource.Title_Max;
            pbxMax.HoverImage = CarManage.Resources.Common.ImageResource.Title_Max;
            pbxMax.ClickImage = CarManage.Resources.Common.ImageResource.Title_Max;

            pbxClose.NormalImage = CarManage.Resources.Common.ImageResource.Title_Close;
            pbxClose.HoverImage = CarManage.Resources.Common.ImageResource.Title_Close;
            pbxClose.ClickImage = CarManage.Resources.Common.ImageResource.Title_Close;
        }

        private void CustomTitleBarBaseForm_Load(object sender, EventArgs e)
        {
            if (this.WindowState.Equals(FormWindowState.Normal))
            {
                pbxMax.NormalImage = CarManage.Resources.Common.ImageResource.Title_Max;
                pbxMax.HoverImage = CarManage.Resources.Common.ImageResource.Title_Max;
                pbxMax.ClickImage = CarManage.Resources.Common.ImageResource.Title_Max;
            }
            else if (this.WindowState.Equals(FormWindowState.Maximized))
            {
                pbxMax.NormalImage = CarManage.Resources.Common.ImageResource.Title_DownRestore;
                pbxMax.HoverImage = CarManage.Resources.Common.ImageResource.Title_DownRestore;
                pbxMax.ClickImage = CarManage.Resources.Common.ImageResource.Title_DownRestore;
            }
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width,
                    Screen.PrimaryScreen.WorkingArea.Height);

                this.WindowState = FormWindowState.Maximized;

                pbxMax.NormalImage = CarManage.Resources.Common.ImageResource.Title_DownRestore;
                pbxMax.HoverImage = CarManage.Resources.Common.ImageResource.Title_DownRestore;
                pbxMax.ClickImage = CarManage.Resources.Common.ImageResource.Title_DownRestore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                pbxMax.NormalImage = CarManage.Resources.Common.ImageResource.Title_Max;
                pbxMax.HoverImage = CarManage.Resources.Common.ImageResource.Title_Max;
                pbxMax.ClickImage = CarManage.Resources.Common.ImageResource.Title_Max;
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCustomTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            base.MoveForm();
        }
    }
}
