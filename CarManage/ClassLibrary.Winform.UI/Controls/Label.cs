using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class Label : System.Windows.Forms.Label
    {
        public Label()
        {
            InitializeComponent();
        }

        public Label(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
