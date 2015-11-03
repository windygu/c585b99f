using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using ClassLibrary.ExceptionHandling;
using ClassLibrary.WorkingProcess;
using ClassLibrary.Utility.Form;
using CarManage.Business;

namespace CarManage.UI.Client.StartUp
{
    public partial class UIDemo : Form
    {
        /// <summary>
        /// 业务逻辑层对象
        /// </summary>
        BusinessDemo businessDemo = new BusinessDemo();

        /// <summary>
        /// 业务逻辑层相关方法调用委托
        /// 在业务逻辑层方法处理时间较长，且需要和UI进行交互时使用该委托
        /// </summary>
        /// <param name="reportCount"></param>
        delegate void UITestDelegate(int reportCount);

        public UIDemo()
        {
            InitializeComponent();

            //注册工作进度报告事件

            businessDemo.OnTest += businessDemo_OnTest;
            businessDemo.OnTest+=businessDemo_OnTest2;
        }

        void businessDemo_OnTest(object sender, WorkProcessingEventArgs e)
        {
            Console.WriteLine(e.WorkStatus+"---"+e.Data.ToString());
            label1.Text = e.WorkStatus;
        }

        void businessDemo_OnTest2(object sender, WorkProcessingEventArgs e)
        {
            Console.WriteLine(e.WorkStatus + "---" + e.Data.ToString());
            label2.Text = e.WorkStatus;
        }

        void businessDemo_OnReportWorkStatus(object sender, WorkProcessingEventArgs e)
        {
            try
            {
                if (e.Data == null)
                    return;

                int index = Convert.ToInt32(e.Data);

                label1.Text = e.WorkStatus + index.ToString();
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException(
                    "UIProcess error!", ref ex);
            }
        }

        void businessDemo_OnReportWorkStatus2(object sender, WorkProcessingEventArgs e)
        {
            try
            {
                if (e.Data == null)
                    return;

                int index = Convert.ToInt32(e.Data);

                label2.Text = "Now:" + index.ToString();
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException(
                    "UIProcess error!", ref ex);
            }
        }

        private void UIDemo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception();
                businessDemo.Init();
                businessDemo.Test(9);
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException(
                    "UITest error!", ref ex);
            }
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                businessDemo.Init(WorkSyncType.Async);

                UITestDelegate uiTest = new UITestDelegate(businessDemo.Test);

                //异步调用业务逻辑层方法
                uiTest.BeginInvoke(10, new AsyncCallback(UITestCallback), uiTest);
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException(
                    "UITest error!", ref ex);
            }
        }

        /// <summary>
        /// 异步调用回调
        /// 该方法用于完成业务逻辑层方法的异步调用
        /// 业务逻辑层方法抛出的异常会在此回调方法中捕获
        /// </summary>
        /// <param name="result"></param>
        private void UITestCallback(IAsyncResult result)
        {
            try
            {
                UITestDelegate test = result.AsyncState as UITestDelegate;

                test.EndInvoke(result);
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException(
                    "UITest error!", ref ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ClassLibrary.UI.Product.CustomControl.ProductFilter filter = new UI.Product.CustomControl.ProductFilter();

            //FormUtil.ShowDialogControl(filter, new Size(810, 230), new Size(810, 230), new Size(100, 100), string.Empty, this, true, true, true, true);
        }

        //Business.Common.Login login = new Business.Common.Login();

        private void button2_Click(object sender, EventArgs e)
        {
            //ClassLibrary.UI.Product.Forms.BrandForm brand = new UI.Product.Forms.BrandForm();
            //brand.CatalogId = "";
            //brand.Keyword = "";
            //brand.Login = login.GetLogin("chenshuaisong");

            //brand.ShowDialog();
        }
    }
}
