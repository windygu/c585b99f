using System;
using System.Windows.Forms;

//using DHGateAssistant.Utility.Enum;
//using DHGateAssistant.UI.Generic.Forms;

namespace ClassLibrary.Winform.UI.Common
{
    public class ControlManager
    {
        /// <summary>
        /// 自定义控件的属性类别
        /// </summary>
        public const string CustomPropertyCategory = "CustomProperty";

        /// <summary>
        /// 将Form的四个角绘制成圆角，需要重写WndProc，
        /// 这是在重写WndProc时需要用到的一组常量
        /// </summary>
        public const int WM_NCHITTEST = 0x0084;
        public const int HT_LEFT = 10;
        public const int HT_RIGHT = 11;
        public const int HT_TOP = 12;
        public const int HT_TOPLEFT = 13;
        public const int HT_TOPRIGHT = 14;
        public const int HT_BOTTOM = 15;
        public const int HT_BOTTOMLEFT = 16;
        public const int HT_BOTTOMRIGHT = 17;
        public const int HT_CAPTION = 2;

        ///// <summary>
        ///// 弹出确定和取消模式的窗体(Normal级别)窗体大小为默认(490,250)
        ///// 用于询问(用于关闭当前窗口)
        ///// </summary>
        ///// <param name="message"></param>
        ///// <returns></returns>
        //public static DialogResult ShowConfirmForm(string message)
        //{
        //    return MessageForm.Show(message, "", "", "信息确认", MessageTipType.Normal, MessageBoxButtons.OKCancel, 490, 250);
        //}

        ///// <summary>
        ///// 弹出确定和取消模式的窗体(消息中有加黑提示的信息)默认窗体大小490，250
        ///// (警告级别)用于删除等重要操作的提示
        ///// </summary>
        ///// <param name="message"></param>
        ///// <param name="messageBold">加黑提示的信息</param>
        ///// <param name="messageEnd"></param>
        ///// <returns></returns>
        //public static DialogResult ShowConfirmForm(string message, string messageBold, string messageEnd)
        //{
        //    return MessageForm.Show(message, messageBold, messageEnd, "信息确认", MessageTipType.Warning, MessageBoxButtons.OKCancel);
        //}

        ///// <summary>
        ///// 弹出消息提示(窗体大小(490,250))
        ///// </summary>
        ///// <param name="message"></param>
        ///// <param name="icon"></param>
        //public static void ShowMessageTip(string message, MessageTipType type)
        //{
        //    MessageForm.Show(message, "", "", "提示", type, MessageBoxButtons.OK, 490,250);
        //}

        ///// <summary>
        ///// 弹出消息提示(窗体大小为默认(350,180))
        ///// </summary>
        ///// <param name="message"></param>
        ///// <param name="type"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        //public static void ShowMessageTip(string message,string messagebold,string messageEnd, MessageTipType type)
        //{
        //    MessageForm.Show(message, messagebold, messageEnd, "提示", type, MessageBoxButtons.OK, 400, 230);
        //}
        ///// <summary>
        ///// 弹出消息提示(自定义高度和宽度)
        ///// </summary>
        ///// <param name="message"></param>
        ///// <param name="type"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        //public static void ShowMessageTip(string message, string messageBold, string messageEnd, MessageTipType type, int width, int height)
        //{
        //    MessageForm.Show(message, messageBold, messageEnd, "提示", type, MessageBoxButtons.OK, width, height);
        //}

    }
}

    