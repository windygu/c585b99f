using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ClassLibrary.Winform.UI.Controls
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(System.Windows.Forms.ComboBox))]
    public class ComboBox : System.Windows.Forms.ComboBox
    {

        public ComboBox()
            : base()
        {
            this.MouseWheel += new MouseEventHandler(ComboBox_MouseWheel);
        }

        void ComboBox_MouseWheel(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.HandledMouseEventArgs args =
                e as System.Windows.Forms.HandledMouseEventArgs;

            if (args != null)
                args.Handled = true;
        }

        protected override void OnDropDown(EventArgs e)
        {
            AdjustComboBoxDropDownListWidth();
            base.OnDropDown(e);
        }

        private void AdjustComboBoxDropDownListWidth()
        {
            Graphics g = null;
            Font font = null;
            try
            {
                int width = this.Width;
                g = this.CreateGraphics();
                font = this.Font;

                //checks if a scrollbar will be displayed.
                //If yes, then get its width to adjust the size of the drop down list.
                int vertScrollBarWidth =
                    (this.Items.Count > this.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

                int newWidth;
                foreach (object s in this.Items)  //Loop through list items and check size of each items.
                {
                    if (s != null)
                    {
                        newWidth = (int)g.MeasureString(this.GetItemText(s), font).Width
                             + vertScrollBarWidth;
                        if (width < newWidth)
                            width = newWidth;   //set the width of the drop down list to the width of the largest item.
                    }
                }
                this.DropDownWidth = width + 4;
            }
            catch
            { }
            finally
            {
                if (g != null)
                    g.Dispose();
            }
        }
    }
}
