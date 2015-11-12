using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CarManage.UI.Component.Forms;

namespace CarManage.UI.Test
{
    public partial class Form1 : CustomTitleBarForm
    {
        private string s = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            s = DateTime.Now.ToString();
            base.Init();
        }
    }
}
