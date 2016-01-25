using System;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Design;
using System.Collections;
using System.Reflection;

namespace ClassLibrary.Winform.UI.Controls.PluggableTabControl
{
    [TypeConverter(typeof(TabControlBorderStyleConverter))]
    public class TabControlBorderStyle : IDisposable
    {
        private Color color = Color.Empty;
        private int width = 1;

        public TabControlBorderStyle(Color color, int width)
        {
            this.color = color;
            this.width = width;
        }

        /// <summary>
        /// 获取或设置边框颜色
        /// </summary>
        [Description("获取或设置边框颜色")]
        [Browsable(true)]
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// 获取或设置边框颜色
        /// </summary>
        [Description("获取或设置边框颜色")]
        [Browsable(true)]
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    class TabControlBorderStyleConverter : ExpandableObjectConverter
    {
        ~TabControlBorderStyleConverter()
        {
            GC.SuppressFinalize(this);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            else
                return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;
            else
                return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, object value)
        {
            if (value == null || !(value is string))
            {
                return base.ConvertFrom(context, culture, value);
            }

            string[] result = value.ToString().Split(new char[] { char.Parse(",") },
                StringSplitOptions.RemoveEmptyEntries);

            if (result.Length != 2)
                throw new ArgumentException("解析TabControlBorderStyle失败,格式应为Color,Width!");

            TypeConverter converter = new ColorConverter();

            //解析字符串并实例化对象 
            return new TabControlBorderStyle((Color)converter.ConvertFromString(result[0]), int.Parse(result[1]));
        }

        public override object ConvertTo(ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            //将对象转换为字符串："Black,1" 
            if (destinationType == typeof(string))
            {
                TabControlBorderStyle style = value as TabControlBorderStyle;
                TypeConverter converter = new ColorConverter();

                return string.Format("{0},{1}", converter.ConvertToString(style.Color), style.Width.ToString());
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        //public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        //{
        //    TypeConverter converter = new ColorConverter();
        //    Color color = Color.Empty;
        //    string input = propertyValues["Color"].ToString();

        //    if (input.Contains(","))
        //    {
        //        int startIndex = input.IndexOf("A=") + 2;
        //        int a = int.Parse(input.Substring(startIndex, input.IndexOf(",", startIndex) - startIndex));

        //        startIndex = input.IndexOf("R=") + 2;
        //        int r = int.Parse(input.Substring(startIndex, input.IndexOf(",", startIndex) - startIndex));

        //        startIndex = input.IndexOf("G=") + 2;
        //        int g = int.Parse(input.Substring(startIndex, input.IndexOf(",", startIndex) - startIndex));

        //        startIndex = input.IndexOf("B=") + 2;
        //        int b = int.Parse(input.Substring(startIndex, input.IndexOf("]", startIndex) - startIndex));

        //        color = Color.FromArgb(a, r, g, b);
        //    }
        //    else
        //    {
        //        color = Color.FromName(input);
        //    }

        //    int width = (int)propertyValues["Width"];

        //    return new TabControlBorderStyle(color, width);
        //}

        //public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context,
        //    object value, Attribute[] attributes)
        //{
        //    if (value is TabControlBorderStyle)
        //        return TypeDescriptor.GetProperties(value, attributes);

        //    return base.GetProperties(context, value, attributes);
        //}

        //public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        //{
        //    return true;
        //}

        //public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        //{
        //    return true;
        //}
    }
}
