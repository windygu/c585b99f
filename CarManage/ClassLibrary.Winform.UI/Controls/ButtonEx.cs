using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

using CarManage.Resources.Common;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class ButtonEx : System.Windows.Forms.Button
    {
        private Color primaryForeColor = Color.FromArgb(155, 90, 22);

        private Color primaryHoverForeColor = Color.FromArgb(107, 46, 0);

        private Color secondaryForeColor = Color.Black;

        private Color secondaryHoverForeColor = Color.Black;

        private Color disabledForeColor = Color.FromArgb(194, 194, 194);

        private ButtonType buttonType;

        public ButtonType ButtonType
        {
            get { return buttonType; }

            set
            {
                buttonType = value;

                if (buttonType.Equals(ButtonType.Primary))
                {
                    this.ForeColor = primaryForeColor;

                    switch (buttonLevel)
                    {
                        case ButtonLevel.First:
                            this.BackgroundImage = ImageResource.Button_First_Primary_BG;
                            break;
                        case ButtonLevel.Second:
                            this.BackgroundImage = ImageResource.Button_Second_Primary_BG;
                            break;
                        case ButtonLevel.Third:
                            this.BackgroundImage = ImageResource.Button_Third_Primary_BG;
                            break;
                    }
                }
                else if (buttonType.Equals(ButtonType.Secondary))
                {
                    this.ForeColor = secondaryForeColor;

                    switch (buttonLevel)
                    {
                        case ButtonLevel.First:
                            this.BackgroundImage = ImageResource.Button_First_Secondary_BG;
                            break;
                        case ButtonLevel.Second:
                            this.BackgroundImage = ImageResource.Button_Second_Secondary_BG;
                            break;
                        case ButtonLevel.Third:
                            this.BackgroundImage = ImageResource.Button_Third_Secondary_BG;
                            break;
                    }
                }
            }
        }

        private ButtonLevel buttonLevel;

        public ButtonLevel ButtonLevel
        {
            get { return buttonLevel; }

            set
            {
                buttonLevel = value;

                switch (buttonLevel)
                { 
                    case ButtonLevel.First:
                        if (buttonType.Equals(ButtonType.Primary))
                            this.BackgroundImage = ImageResource.Button_First_Primary_BG;
                        else if(buttonType.Equals(ButtonType.Secondary))
                            this.BackgroundImage = ImageResource.Button_First_Secondary_BG;

                        this.Size = ImageResource.Button_First_Primary_BG.Size;
                        break;
                    case ButtonLevel.Second:
                        if (buttonType.Equals(ButtonType.Primary))
                            this.BackgroundImage = ImageResource.Button_Second_Primary_BG;
                        else if (buttonType.Equals(ButtonType.Secondary))
                            this.BackgroundImage = ImageResource.Button_Second_Secondary_BG;

                        this.Size = ImageResource.Button_Second_Primary_BG.Size;
                        break;
                    case ButtonLevel.Third:
                        if (buttonType.Equals(ButtonType.Primary))
                            this.BackgroundImage = ImageResource.Button_Third_Primary_BG;
                        else if (buttonType.Equals(ButtonType.Secondary))
                            this.BackgroundImage = ImageResource.Button_Third_Secondary_BG;

                        this.Size = ImageResource.Button_Third_Primary_BG.Size;
                        break;
                }
            }
        }
        public ButtonEx()
        {
            InitializeComponent();

            InitControl();
        }

        public ButtonEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            InitControl();
        }

        private void InitControl()
        {
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = FlatStyle.Flat;
            base.BackgroundImageLayout = ImageLayout.Stretch;
            base.ForeColor = System.Drawing.Color.FromArgb(130, 45, 45);
            base.UseVisualStyleBackColor = true;
            base.BackColor = System.Drawing.Color.Transparent;

            ButtonType = ButtonType.Primary;
            ButtonLevel = ButtonLevel.Third;
            this.Cursor = Cursors.Hand;
        }

        private void ButtonEx_MouseEnter(object sender, EventArgs e)
        {
            if (!this.Enabled)
                return;

            if (buttonType.Equals(ButtonType.Primary))
            {
                this.ForeColor = primaryHoverForeColor;

                switch (buttonLevel)
                {
                    case ButtonLevel.First:
                        this.BackgroundImage = ImageResource.Button_First_Primary_Hover_BG;
                        break;
                    case ButtonLevel.Second:
                        this.BackgroundImage = ImageResource.Button_Second_Primary_Hover_BG;
                        break;
                    case ButtonLevel.Third:
                        this.BackgroundImage = ImageResource.Button_Third_Primary_Hover_BG;
                        break;
                }
            }
            else if (buttonType.Equals(ButtonType.Secondary))
            {
                this.ForeColor = secondaryHoverForeColor;

                switch (buttonLevel)
                {
                    case ButtonLevel.First:
                        this.BackgroundImage = ImageResource.Button_First_Secondary_Hover_BG;
                        break;
                    case ButtonLevel.Second:
                        this.BackgroundImage = ImageResource.Button_Second_Secondary_Hover_BG;
                        break;
                    case ButtonLevel.Third:
                        this.BackgroundImage = ImageResource.Button_Third_Secondary_Hover_BG;
                        break;
                }
            }
        }

        private void ButtonEx_MouseLeave(object sender, EventArgs e)
        {
            if (!this.Enabled)
                return;

            if (buttonType.Equals(ButtonType.Primary))
            {
                this.ForeColor = primaryForeColor;

                switch (buttonLevel)
                {
                    case ButtonLevel.First:
                        this.BackgroundImage = ImageResource.Button_First_Primary_BG;
                        break;
                    case ButtonLevel.Second:
                        this.BackgroundImage = ImageResource.Button_Second_Primary_BG;
                        break;
                    case ButtonLevel.Third:
                        this.BackgroundImage = ImageResource.Button_Third_Primary_BG;
                        break;
                }
            }
            else if (buttonType.Equals(ButtonType.Secondary))
            {
                this.ForeColor = secondaryForeColor;

                switch (buttonLevel)
                {
                    case ButtonLevel.First:
                        this.BackgroundImage = ImageResource.Button_First_Secondary_BG;
                        break;
                    case ButtonLevel.Second:
                        this.BackgroundImage = ImageResource.Button_Second_Secondary_BG;
                        break;
                    case ButtonLevel.Third:
                        this.BackgroundImage = ImageResource.Button_Third_Secondary_BG;
                        break;
                }
            }
        }

        public new bool Enabled
        {
            get { return base.Enabled; }

            set
            {
                base.Enabled = value;

                if (base.Enabled)
                {
                    if (buttonType.Equals(ButtonType.Primary))
                    {
                        this.ForeColor = primaryForeColor;

                        switch (buttonLevel)
                        {
                            case ButtonLevel.First:
                                this.BackgroundImage = ImageResource.Button_First_Primary_BG;
                                break;
                            case ButtonLevel.Second:
                                this.BackgroundImage = ImageResource.Button_Second_Primary_BG;
                                break;
                            case ButtonLevel.Third:
                                this.BackgroundImage = ImageResource.Button_Third_Primary_BG;
                                break;
                        }
                    }
                    else if (buttonType.Equals(ButtonType.Secondary))
                    {
                        this.ForeColor = secondaryForeColor;

                        switch (buttonLevel)
                        {
                            case ButtonLevel.First:
                                this.BackgroundImage = ImageResource.Button_First_Secondary_BG;
                                break;
                            case ButtonLevel.Second:
                                this.BackgroundImage = ImageResource.Button_Second_Secondary_BG;
                                break;
                            case ButtonLevel.Third:
                                this.BackgroundImage = ImageResource.Button_Third_Secondary_BG;
                                break;
                        }
                    }
                }
                else
                {
                    this.ForeColor = disabledForeColor;

                    switch (buttonLevel)
                    {
                        case ButtonLevel.First:
                            this.BackgroundImage = ImageResource.Button_First_Disabled_BG;
                            break;
                        case ButtonLevel.Second:
                            this.BackgroundImage = ImageResource.Button_Seconed_Disabled_BG;
                            break;
                        case ButtonLevel.Third:
                            this.BackgroundImage = ImageResource.Button_Third_Disabled_BG;
                            break;
                    } 
                }
            }
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }


    public enum ButtonType
    {
        Primary,
        Secondary
    }

    public enum ButtonLevel
    {
        First,
        Second,
        Third
    }
}
