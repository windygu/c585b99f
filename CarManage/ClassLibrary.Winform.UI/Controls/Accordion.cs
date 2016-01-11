using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class Accordion : Component
    {
        public Accordion()
        {
            InitializeComponent();
        }

        public Accordion(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
