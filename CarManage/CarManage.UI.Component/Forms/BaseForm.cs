using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace CarManage.UI.Component.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            if (!IsDesignMode)
                Init();
        }

        /// <summary>
        /// 当前控件是否处于设计视图模式
        /// </summary>
        protected bool IsDesignMode
        {
            get
            {
                if (this.GetService(typeof(IDesignerHost)) != null ||
                    LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 窗体成员实例化方法，成员对象的实例化需要在此方法的重载中完成
        /// </summary>
        protected virtual void Init()
        {

        }
    }
}
