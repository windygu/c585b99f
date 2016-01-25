using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Winform.UI.Controls.PluggableTabControl
{
    public struct DrawingOffset
    {
        /// <summary>
        /// Top Pixel Offset.
        /// </summary>
        public int Top;

        /// <summary>
        /// Left Pixel Offset.
        /// </summary>
        public int Left;

        /// <summary>
        /// Bottom Pixel Offset.
        /// </summary>
        public int Bottom;

        /// <summary>
        /// Right Pixel Offset.
        /// </summary>
        public int Right;

        public DrawingOffset(int top, int left, int bottom, int right)
        {
            Top = top;
            Left = left;
            Bottom = bottom;
            Right = right;
        }

        public override string ToString()
        {
            return String.Format("Top: {0}px; Left: {1}px; Bottom: {2}px; Right: {3}px",
                Top, Left, Bottom, Right);
        }
    }
}
