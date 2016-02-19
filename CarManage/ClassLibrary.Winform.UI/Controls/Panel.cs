using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class Panel : System.Windows.Forms.Panel
    {
        public Panel()
        {
            InitializeComponent();
        }

        public Panel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
