using System;

namespace ClassLibrary.Winform.UI.Controls
{
    /// <summary>
    /// ListControl项
    /// </summary>
    public class ListControlItem
    {
        public ListControlItem()
        {
            Text = string.Empty;
            Value = string.Empty;
        }

        /// <summary>
        /// 文本
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }
    }
}
