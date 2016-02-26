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
using CarManage.Model.Customer;
using CarManage.Model.Insurance;
using CarManage.Model.Enum;

namespace CarManage.UI.Client.Common.Customer
{
    public partial class InsuranceEdit : UserControlBase
    {
        #region 公共属性

        /// <summary>
        /// 客户主键
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// 车辆主键
        /// </summary>
        public string CarId { get; set; }

        /// <summary>
        /// 保险记录主键
        /// </summary>
        public string InsuranceId { get; set; }

        #endregion

        #region 私有变量

        CarManage.Business.Customer.Car car;
        CarManage.Business.Insurance.Insurance insurance;

        #endregion

        public InsuranceEdit()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            dgvInsurance.ColumnHeaderBackgroundImage = ImageResource.List_Header_Lower_BG;
            dgvInsurance.AutoGenerateColumns = false;
        }

        protected override void Init()
        {
            car = new Business.Customer.Car();
            insurance = new Business.Insurance.Insurance();

            base.Init();
        }

        private void InsuranceEdit_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定保险公司
                ControlUtil.BindListControl(cbxInsuranceCompany, insurance.GetInsuranceCompany(), 
                    "Value", "Key", "请选择", string.Empty, 0);

                BindCars();

                if (string.IsNullOrEmpty(InsuranceId))
                {
                    //绑定保险项目
                    chklstItems.DataTextField = "Value";
                    chklstItems.DataValueField = "Key";
                    chklstItems.DataBind(insurance.GetInsuranceItems());
                }
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("信息初始化失败！", ref ex);
            }
        }

        private void cbxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarId = string.Empty;

            if (cbxCars.SelectedValue != null)
            {
                CarId = cbxCars.SelectedValue.ToString();
            }

            BindInsurance();
        }

        private void BindCars()
        {
            if (string.IsNullOrEmpty(CustomerId))
                return;

            List<CarInfo> carList = car.GetCars(CustomerId);

            carList.ForEach(info => info.Number = info.Number + info.Model);

            ControlUtil.BindListControl(cbxCars, carList, "Number", "Id", 0);
        }

        private void BindInsurance()
        {
            List<InsuranceInfo> insuranceList = insurance.GetMaintenances(CarId);

            if (insuranceList.Count.Equals(0))
            {
                dgvInsurance.DataSource = null;
            }
            else
            {
                dgvInsurance.DataSource = insuranceList;
            }
        }

        public void BindMaintenanceDetail()
        {
            try
            {
                if (string.IsNullOrEmpty(InsuranceId))
                    return;

                InsuranceInfo insuranceInfo = insurance.Load(InsuranceId);

                if (insuranceInfo == null)
                    return;

                txtFrameNumber.Text = insuranceInfo.FrameNumber;
                txtEngineNumber.Text = insuranceInfo.EngineNumber;
                txtInsurant.Text = insuranceInfo.Insurant;
                txtInsurantPhone.Text = insuranceInfo.InsurantPhone;
                ControlUtil.SetListControlSelectedByValue(cbxInsuranceCompany, insuranceInfo.InsuranceCompanyCode);
                chkLocal.Checked = insuranceInfo.Local.HasValue && insuranceInfo.Local.Value;

                chklstItems.DataTextField = "ItemName";
                chklstItems.DataValueField = "ItemCode";
                chklstItems.CheckedValues.AddRange(insuranceInfo.Items.Select(info => info.ItemCode).ToList());
                chklstItems.DataBind(insuranceInfo.Items);

                txtAmount.Text = insuranceInfo.Amount.ToString();

                if (insuranceInfo.NextInsuranceDate.HasValue)
                    dtpNextInsuranceDate.Text = insuranceInfo.NextInsuranceDate.Value.ToString();
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("绑定车辆保险失败！", ref ex);
            }
        }

        public void Save()
        {
            try
            {
                InsuranceInfo insuranceInfo = new InsuranceInfo();

                if (string.IsNullOrEmpty(InsuranceId))
                {
                    insuranceInfo.Id = Guid.NewGuid().ToString();
                    insuranceInfo.CreateDate = DateTime.Now;
                    insuranceInfo.Creator = CarManageConfig.Instance.UserData.UserName;
                }
                else
                {
                    insuranceInfo = insurance.Load(InsuranceId);
                }

                insuranceInfo.FrameNumber = CommonUtil.FilterInput(txtFrameNumber.Text);
                insuranceInfo.EngineNumber = CommonUtil.FilterInput(txtEngineNumber.Text);
                insuranceInfo.Insurant = CommonUtil.FilterInput(txtInsurant.Text);
                insuranceInfo.InsurantPhone = CommonUtil.FilterInput(txtInsurantPhone.Text);
                insuranceInfo.InsuranceCompanyCode = cbxInsuranceCompany.SelectedValue.ToString();
                insuranceInfo.Local = chkLocal.Checked;

                foreach (ListControlItem item in chklstItems.SelectedItem)
                {
                    insuranceInfo.Items.Add(new InsuranceItemInfo()
                    {
                        Id = Guid.NewGuid().ToString(),
                        InsuranceId = insuranceInfo.Id,
                        CarId = this.CarId,
                        ItemName = item.Text,
                        ItemCode = item.Value,
                    });
                }

                insuranceInfo.Amount = ConvertUtil.ToDecimal(CommonUtil.FilterInput(txtAmount.Text));
                insuranceInfo.NextInsuranceDate = ConvertUtil.ToNullableDateTime(dtpNextInsuranceDate.Text);
                insuranceInfo.Operator = CarManageConfig.Instance.UserData.UserName;
                insuranceInfo.UpdateDate = DateTime.Now;
                insuranceInfo.Valid = true;

                if (string.IsNullOrEmpty(InsuranceId))
                {
                    insurance.Add(insuranceInfo);
                }
                else
                {
                    insurance.Update(insuranceInfo);
                }
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("保存保险信息失败！", ref ex);
            }
        }

        public void Reset()
        {
            InsuranceId = string.Empty;

            txtFrameNumber.Text = string.Empty;
            txtEngineNumber.Text = string.Empty;
            txtInsurant.Text = string.Empty;
            txtInsurantPhone.Text = string.Empty;
            cbxInsuranceCompany.SelectedIndex = 0;
            chkLocal.Checked = false;
            chklstItems.ClearCheckedItems();
            txtAmount.Text = string.Empty;
            dtpNextInsuranceDate.Text = string.Empty;
            //绑定保险项目
            chklstItems.DataTextField = "Value";
            chklstItems.DataValueField = "Key";
            chklstItems.DataBind(insurance.GetInsuranceItems());
        }
    }
}
