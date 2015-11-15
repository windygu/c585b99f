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
using CarManage.Model.Customer;
using CarManage.Model.Enum;

namespace CarManage.UI.Client.Common.Customer
{
    public partial class CustomerEdit : UserControlBase
    {
        #region 公共属性

        public string CustomerId { get; set; }

        #endregion

        #region 私有变量

        CarManage.Business.Customer.Customer customer;

        #endregion

        public CustomerEdit()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            customer = new Business.Customer.Customer();

            base.Init();
        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定客户称呼
                ControlUtil.BindListControl(cbxAlias, customer.GetAlias(), "Value", "Key",
                    "请选择", string.Empty, 0);
                //绑定性别
                ControlUtil.BindListControl(cbxAlias, customer.GetSex(), "Value", "Key",
                    "请选择", string.Empty, 0);
                //绑定习惯接电话时间
                ControlUtil.BindListControl(cbxAlias, customer.GetFreeTime(), "Value", "Key",
                    "请选择", string.Empty, 0);
                //绑定喜欢的销售活动
                ControlUtil.BindListControl(cbxAlias, customer.GetPreferSale(), "Value", "Key",
                    "请选择", string.Empty, 0);
                //绑定喜欢的时候活动
                ControlUtil.BindListControl(cbxAlias, customer.GetPreferSupport(), "Value", "Key",
                    "请选择", string.Empty, 0);
                //绑定喜欢的饮品
                ControlUtil.BindListControl(cbxAlias, customer.GetPreferDrink(), "Value", "Key",
                    "请选择", string.Empty, 0);
                //绑定性格类型
                ControlUtil.BindListControl(cbxAlias, customer.GetCharacter(), "Value", "Key",
                    "请选择", string.Empty, 0);
                //绑定销售类型
                ControlUtil.BindListControl(cbxAlias, customer.GetSaleType(), "Value", "Key",
                    "请选择", string.Empty, 0);

                BindCustomer();
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("信息初始化失败！", ref ex);
            }
        }

        public void BindCustomer()
        {
            try
            {
                if (string.IsNullOrEmpty(CustomerId))
                    return;

                CustomerInfo customerInfo = customer.Load(CustomerId);

                if (customerInfo == null)
                {
                    return;
                }

                txtOwner.Text = customerInfo.Owner;
                txtOwnerAddress.Text = customerInfo.OwnerAddress;
                txtUserName.Text = customerInfo.UserName;
                txtUserAddress.Text = customerInfo.UserAddress;
                ControlUtil.SetListControlSelectedByValue(cbxSex, ((int)customerInfo.Sex).ToString());
                ControlUtil.SetListControlSelectedByValue(cbxAlias, customerInfo.Alias);
                txtTel.Text = customerInfo.Tel;
                txtMobile.Text = customerInfo.Mobile;
                txtEmail.Text = customerInfo.Email;
                txtWeChat.Text = customerInfo.WeChat;
                ControlUtil.SetListControlSelectedByValue(cbxFreeTime, ((int)customerInfo.FreeTime).ToString());
                ControlUtil.SetListControlSelectedByValue(cbxPreferSupport, customerInfo.PreferSupport);
                ControlUtil.SetListControlSelectedByValue(cbxPreferSale, customerInfo.PreferSale);
                ControlUtil.SetListControlSelectedByValue(cbxPreferDrink, customerInfo.PreferDrink);
                ControlUtil.SetListControlSelectedByValue(cbxCharacter, ((int)customerInfo.Character).ToString());
                ControlUtil.SetListControlSelectedByValue(cbxSaleType, customerInfo.SaleType);
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("绑定客户信息失败！", ref ex);
            }
        }

        public void Save()
        {
            CustomerInfo customerInfo = new CustomerInfo();

            if (!string.IsNullOrEmpty(CustomerId))
                customerInfo = customer.Load(CustomerId);
            else
            {
                customerInfo.Id = Guid.NewGuid().ToString();
                customerInfo.CreateDate = DateTime.Now;
                customerInfo.Creator = CarManageConfig.Instance.UserData.UserName;
            }

            customerInfo.Owner = CommonUtil.FilterInput(txtOwner.Text);
            customerInfo.OwnerAddress = CommonUtil.FilterInput(txtOwnerAddress.Text);
            customerInfo.UserName = CommonUtil.FilterInput(txtUserName.Text);
            customerInfo.UserAddress = CommonUtil.FilterInput(txtUserAddress.Text);

            if (!CommonUtil.IsNullOrEmpty(cbxSex.SelectedValue))
                customerInfo.Sex = ConvertUtil.ToEnum<Sex>(cbxSex.SelectedValue);

            if (!CommonUtil.IsNullOrEmpty(cbxAlias.SelectedValue))
                customerInfo.Alias = cbxAlias.SelectedValue.ToString();

            customerInfo.Tel = CommonUtil.FilterInput(txtTel.Text);
            customerInfo.Mobile = CommonUtil.FilterInput(txtMobile.Text);
            customerInfo.Email = CommonUtil.FilterInput(txtEmail.Text);
            customerInfo.WeChat = CommonUtil.FilterInput(txtWeChat.Text);

            if (!CommonUtil.IsNullOrEmpty(cbxFreeTime.SelectedValue))
                customerInfo.FreeTime = ConvertUtil.ToEnum<FreeTime>(cbxFreeTime.SelectedValue);

            if (!CommonUtil.IsNullOrEmpty(cbxPreferSupport.SelectedValue))
                customerInfo.PreferSupport = cbxPreferSupport.SelectedValue.ToString();

            if (!CommonUtil.IsNullOrEmpty(cbxPreferSale.SelectedValue))
                customerInfo.PreferSale = cbxPreferSale.SelectedValue.ToString();

            if (!CommonUtil.IsNullOrEmpty(cbxPreferDrink.SelectedValue))
                customerInfo.PreferDrink = cbxPreferSale.SelectedValue.ToString();

            if (!CommonUtil.IsNullOrEmpty(cbxCharacter.SelectedValue))
                customerInfo.Character = ConvertUtil.ToEnum<CustomerCharacter>(cbxCharacter.SelectedValue);

            if (!CommonUtil.IsNullOrEmpty(cbxSaleType.SelectedValue))
                customerInfo.SaleType = cbxSaleType.SelectedValue.ToString();

            customerInfo.UpdateDate = DateTime.Now;
            customerInfo.Operator = CarManageConfig.Instance.UserData.UserName;

            if (string.IsNullOrEmpty(CustomerId))
                customer.Add(customerInfo);
            else
                customer.Update(customerInfo);
        }
    }
}
