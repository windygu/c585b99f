using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClassLibrary.ExceptionHandling;
using ClassLibrary.Utility.Common;
using ClassLibrary.Utility.Form;
using CarManage.Configuration;
using ClassLibrary.Winform.UI.Controls;
using CarManage.Resources.Common;
using CarManage.Model.Solicit;
using CarManage.Model.Enum;

namespace CarManage.UI.Client.Common.Customer
{
    public partial class CallRecordHistory : UserControlBase
    {
        #region 公共属性

        /// <summary>
        /// 客户主键
        /// </summary>
        public string CustomerId { get; set; }

        #endregion

        #region 私有变量

        CarManage.Business.Solicit.CallRecord callRecord;

        #endregion

        public CallRecordHistory()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            dgvCallRecord.ColumnHeaderBackgroundImage = ImageResource.List_Header_Lower_BG;
            dgvCallRecord.AutoGenerateColumns = false;
        }

        protected override void Init()
        {
            callRecord = new Business.Solicit.CallRecord();

            base.Init();
        }

        private void CallRecordHistory_Load(object sender, EventArgs e)
        {
            try
            {
                BindCallRecords();
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("初始化信息失败！", ref ex);
            }
        }

        private void BindCallRecords()
        {
            try
            {
                if (string.IsNullOrEmpty(CustomerId))
                    return;

                List<CallRecordInfo> recordList = callRecord.GetRecordsByCustomerId(CustomerId);

                if (recordList.Count.Equals(0))
                {
                    dgvCallRecord.DataSource = null;
                    dgvCallRecord.Visible = false;
                }
                else
                {
                    dgvCallRecord.DataSource = recordList;
                    dgvCallRecord.Visible = true;
                }
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("显示通话记录信息失败！", ref ex);
            }
        }
    }
}
