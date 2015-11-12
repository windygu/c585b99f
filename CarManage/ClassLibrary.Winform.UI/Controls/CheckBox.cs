using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class CheckBox : System.Windows.Forms.CheckBox
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        public CheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// 复选框控件的值
        /// </summary>
        public string Value { get; set; }
    }
}
