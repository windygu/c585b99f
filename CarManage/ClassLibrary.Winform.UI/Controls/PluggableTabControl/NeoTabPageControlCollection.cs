using System;
using System.Windows.Forms;

namespace ClassLibrary.Winform.UI.Controls.PluggableTabControl
{
    [System.ComponentModel.Editor(typeof(ClassLibrary.Winform.UI.Controls.PluggableTabControl.Design.NeoTabPageCollectionEditor), 
        typeof(System.Drawing.Design.UITypeEditor))]
    public class NeoTabPageControlCollection : Control.ControlCollection
    {
        #region Constructor

        public NeoTabPageControlCollection(Control owner)
            : base(owner)
        { }

        #endregion

        #region Destructor

        ~NeoTabPageControlCollection()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Override Methods

        public override void Add(Control value)
        {
            if (value is NeoTabPage)
                base.Add(value);
            else
                throw new NotSupportedException("Only, NeoTabPage controls can be added to a NeoTabWindow control.");
        }

        #endregion
    }
}