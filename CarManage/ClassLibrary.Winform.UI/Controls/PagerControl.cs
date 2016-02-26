using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
//using DHGateAssistant.Model.Event;
using System.Threading;
using System.Drawing;

//using DHGateAssistant.Utility.Configuration;
//using DHGateAssistant.Utility.Result;

namespace ClassLibrary.Winform.UI.Controls
{
    public partial class PagerControl : UserControlBase
    {
        #region  自定义事件委托

        /// <summary>
        /// 声明数据分页事件
        /// </summary>
        public event EventHandler<PageIndexChangedEventArgs> OnPageIndexChanged;

        /// <summary>
        /// 声明自定义事件参数类PageIndexChangedEventArgs对象
        /// </summary>
        PageIndexChangedEventArgs pce;

        /// <summary>
        /// 当页码发生改变时引发的事件
        /// </summary>
        public event EventHandler<EventArgs> OnPageSizeChanged;

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public PagerControl()
        {
            InitializeComponent();

            nudPageIndex.Maximum = this.PageCount;
            //cbxPageSize.SelectedIndex = 0;
        }

        #endregion

        #region 基类方法


        //protected override void CustomLoad()
        //{
        //    cbxPageSize.SelectedIndexChanged -= new EventHandler(cbxPageSize_SelectedIndexChanged);

        //    bool found = false;

        //    foreach (object item in cbxPageSize.Items)
        //    {
        //        int pageSize = int.Parse(item.ToString());

        //        if (pageSize.Equals(DHGateAssistantConfig.Instance.PageSize))
        //        {
        //            cbxPageSize.Text = DHGateAssistantConfig.Instance.PageSize.ToString();
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (!found && cbxPageSize.Items.Count > 0)
        //        cbxPageSize.SelectedIndex = 0;

        //    cbxPageSize.SelectedIndexChanged += new EventHandler(cbxPageSize_SelectedIndexChanged);

        //    base.CustomLoad();
        //}

        #endregion

        #region 私有变量/属性


        #endregion

        #region 公共变量/属性

        /// <summary>
        /// 总行数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 每页显示行数
        /// </summary>
        public int PageSize
        {
            get
            {
                ////if (string.IsNullOrEmpty(cbxPageSize.Text))
                ////    return DHGateAssistantConfig.Instance.PageSize;

                return int.Parse(cbxPageSize.Text);
            }

            set
            {
                //bool found = false;

                //foreach (object item in cbxPageSize.Items)
                //{
                //    int pageSize = int.Parse(item.ToString());

                //    if (pageSize.Equals(value))
                //    {
                //        cbxPageSize.Text = value.ToString();
                //        found = true;
                //        break;
                //    }
                //}

                //if (!found && cbxPageSize.Items.Count > 0)
                //    cbxPageSize.SelectedIndex = 0;
            }
        }


        public bool ShowPageSize
        {
            get { return lblPageSize.Visible; }

            set
            {
                lblPageSize.Visible = cbxPageSize.Visible = value;
            }
        }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 页数=总行数/每页显示行数
        /// </summary>
        public int PageCount { get; set; }

        #endregion

        #region 公共方法

        public void InitPageSize(params int[] pageSizes)
        {
            cbxPageSize.SelectedIndexChanged -= new EventHandler(
                cbxPageSize_SelectedIndexChanged);

            cbxPageSize.Items.Clear();

            if (pageSizes.Length.Equals(0))
            {
                ////cbxPageSize.Items.Add(DHGateAssistantConfig.Instance.PageSize);
            }

            foreach (int pageSize in pageSizes)
            {
                cbxPageSize.Items.Add(pageSize);
            }

            cbxPageSize.SelectedIndex = 0;

            cbxPageSize.SelectedIndexChanged -= new EventHandler(
                cbxPageSize_SelectedIndexChanged);
        }

        #endregion

        #region  处理方法

        /// <summary>
        /// 声明负责引发事件的方法
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnNewOnPageIndexChanged(PageIndexChangedEventArgs e)
        {
            //处于线程安全的考虑，现将委托字段的引用复制到一个临时字段中
            EventHandler<PageIndexChangedEventArgs> args =
                Interlocked.CompareExchange(ref OnPageIndexChanged, null, null);

            //任何方法登记了对我们事件的关注，就通知他们
            if (args != null)
            {
                args(this, e);
            }
        }

        /// <summary>
        /// 计算页数
        /// </summary>
        private void GetPageCount()
        {
            if (this.TotalCount > 0)
            {
                this.PageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.TotalCount) / Convert.ToDouble(this.PageSize)));
            }
            else
            {
                this.PageCount = 0;
            }
        }

        /// <summary>
        /// 控件数据相关计算的方法
        /// </summary>
        public void Bind()
        {
            GetPageCount();//计算页码

            if (this.PageIndex > this.PageCount)
            {
                this.PageIndex = this.PageCount;
            }
            if (this.PageCount == 1)
            {
                this.PageIndex = 1;
            }

            //限定nudPageIndex最大值（达到或超过最大值后，nudPageIndex.value取最大值Maximum）
            nudPageIndex.Maximum = this.PageCount;

            //显示初始化总页数
            lblTotalPage.Text = string.Format("/{0}页", this.PageCount);
            //显示数据总条数
            this.lblTotalCount.Text = string.Format("{0}", this.TotalCount);

            //根据数据行数，设置nudPageIndex的Minimum值
            if (this.TotalCount == 0)
            {
                this.nudPageIndex.Minimum = 0;
            }
            else
            {
                this.nudPageIndex.Minimum = 1;
            }

            //显示当前页码
            this.nudPageIndex.Value = this.PageIndex;

            //根据总页数，调整nudPageIndex控件宽度
            nudPageIndex.Width = TextRenderer.MeasureText(this.PageCount.ToString(), this.Font).Width + 37;

            //ResetLocation();
            if (this.PageIndex == 1)
            {
                lnkbtnPrevious.Enabled = false;
                lnkbtnFirst.Enabled = false;
            }
            else
            {
                lnkbtnPrevious.Enabled = true;
                lnkbtnFirst.Enabled = true;
            }

            if (this.PageIndex == this.PageCount)
            {
                lnkbtnLast.Enabled = false;
                lnkbtnNext.Enabled = false;
            }
            else
            {
                lnkbtnLast.Enabled = true;
                lnkbtnNext.Enabled = true;
            }

            if (this.TotalCount == 0)
            {
                lnkbtnNext.Enabled = false;
                lnkbtnLast.Enabled = false;
                lnkbtnFirst.Enabled = false;
                lnkbtnPrevious.Enabled = false;
            }

            if (TotalCount.Equals(0) || PageCount.Equals(1))
            {
                btnGo.Enabled = false;
            }
            else
            {
                btnGo.Enabled = true;
            }
        }

        #endregion

        #region  页面跳转相关事件

        private void lnkbtnFirst_Click(object sender, EventArgs e)
        {
            PageIndex = 1;

            //实例化自定义扩展类PageIndexChangedEventArgs
            pce = new PageIndexChangedEventArgs(this.PageIndex);
            OnNewOnPageIndexChanged(pce);
            Bind();
        }

        private void lnkbtnPrevious_Click(object sender, EventArgs e)
        {
            PageIndex -= 1;

            if (PageIndex <= 0)
            {
                PageIndex = 1;
            }

            //实例化自定义扩展类PageIndexChangedEventArgs
            pce = new PageIndexChangedEventArgs(this.PageIndex);
            OnNewOnPageIndexChanged(pce);
            Bind();
        }

        private void lnkbtnNext_Click(object sender, EventArgs e)
        {
            this.PageIndex += 1;
            if (PageIndex > PageCount)
            {
                PageIndex = PageCount;
            }
            //实例化自定义扩展类PageIndexChangedEventArgs
            pce = new PageIndexChangedEventArgs(this.PageIndex);
            OnNewOnPageIndexChanged(pce);
            Bind();
        }

        private void lnkbtnLast_Click(object sender, EventArgs e)
        {
            PageIndex = PageCount;
            //实例化自定义扩展类PageIndexChangedEventArgs
            pce = new PageIndexChangedEventArgs(this.PageIndex);
            OnNewOnPageIndexChanged(pce);
            Bind();
        }

        /// <summary>
        /// 截取键盘Enter（回车）事件，跳转到某页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudPageIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.PageIndex = Convert.ToInt32(nudPageIndex.Value);
                pce = new PageIndexChangedEventArgs(this.PageIndex);
                OnNewOnPageIndexChanged(pce);
                Bind();
            }
        }

        /// <summary>
        /// 限制跳转页码范围
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudPageIndex_ValueChanged(object sender, EventArgs e)
        {
            //限定nudPageIndex最大值（达到或超过最大值后，nudPageIndex.value取最大值Maximum）
            nudPageIndex.Maximum = this.PageCount;
        }

        /// <summary>
        /// 页码下拉框选中项发生改变时引发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////DHGateAssistantConfig.Instance.PageSize = this.PageSize;
            ////DHGateAssistantConfig.Instance.Save();

            PageIndex = 1;

            //实例化自定义扩展类PageIndexChangedEventArgs
            pce = new PageIndexChangedEventArgs(this.PageIndex);
            OnNewOnPageIndexChanged(pce);
            Bind();

            if (this.OnPageSizeChanged != null)
                OnPageSizeChanged(this, e);
        }

        #endregion

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.PageIndex = Convert.ToInt32(nudPageIndex.Value);
            pce = new PageIndexChangedEventArgs(this.PageIndex);
            OnNewOnPageIndexChanged(pce);
            Bind();
        }

        void btnGo_MouseEnter(object sender, System.EventArgs e)
        {
            btnGo.BackColor = Color.White;
        }
    }

    public class PageIndexChangedEventArgs : EventArgs
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        public PageIndexChangedEventArgs(int pageIndex)
        {
            PageIndex = pageIndex;
        }
    }
}
