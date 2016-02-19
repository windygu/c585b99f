using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace ClassLibrary.Winform.UI.Controls
{ 
    public partial class PictureBoxEx : System.Windows.Forms.PictureBox
    {
        private bool enableEffect;

        /// <summary>
        /// 获取或设置是否带有特效效果
        /// </summary>
        [Description("获取或设置是否带有特效效果")]
        public bool EnableEffect
        {
            get { return enableEffect; }

            set
            {
                if (enableEffect.Equals(value))
                    return;

                enableEffect = value;

                if (enableEffect)
                {
                    this.MouseHover += PictureBoxEx_MouseHover;
                    this.MouseLeave += PictureBoxEx_MouseLeave;
                    this.MouseDown += PictureBoxEx_MouseDown;
                    this.MouseUp += PictureBoxEx_MouseUp;
                }
                else
                {
                    this.MouseHover -= PictureBoxEx_MouseHover;
                    this.MouseLeave -= PictureBoxEx_MouseLeave;
                    this.MouseClick -= PictureBoxEx_MouseDown;
                    this.MouseUp -= PictureBoxEx_MouseUp;
                }
            }
        }

        private Image normalImage;

        /// <summary>
        /// 获取或设置显示的图片
        /// </summary>
        [Description("获取或设置显示的图片")]
        public Image NormalImage
        {
            get { return this.Image; }

            set
            {
                this.Image = value;
            }
        }

        /// <summary>
        /// 获取或设置鼠标悬浮时显示的图片
        /// </summary>
        [Description("获取或设置鼠标悬浮时显示的图片")]
        public Image HoverImage { get; set; }

        /// <summary>
        /// 获取或设置鼠标点击时显示的图片
        /// </summary>
        [Description("获取或设置鼠标点击时显示的图片")]
        public Image ClickImage { get; set; }

        public PictureBoxEx()
        {
            InitializeComponent();
            InitControl();
        }

        public PictureBoxEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            enableEffect = false;
            normalImage = null;
            HoverImage = null;
            ClickImage = null;
        }

        private void PictureBoxEx_MouseHover(object sender, EventArgs e)
        {
            if (HoverImage != null)
                this.Image = HoverImage;
        }

        private void PictureBoxEx_MouseLeave(object sender, EventArgs e)
        {
            if (NormalImage != null)
                this.Image = Image;
        }
        void PictureBoxEx_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button.Equals(System.Windows.Forms.MouseButtons.Left) && ClickImage != null)
                this.Image = ClickImage;
        }

        void PictureBoxEx_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button.Equals(System.Windows.Forms.MouseButtons.Left) && NormalImage != null)
                this.Image = NormalImage;
        } 
    }
}
