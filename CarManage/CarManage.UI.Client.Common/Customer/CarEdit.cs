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
    public partial class CarEdit : UserControlBase
    {
        #region 公共属性

        public string CustomerId { get; set; }

        #endregion

        #region 私有变量

        CarManage.Business.Customer.Car car;

        private string currentCarId = string.Empty;

        #endregion

        public CarEdit()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            car = new Business.Customer.Car();

            base.Init();
        }

        private void CarEdit_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定保养周期
                ControlUtil.BindListControl(cbxMaintenancePeriod, car.GetMaintenancePeriod(), "Value", "Key",
                    "请选择", string.Empty, 0);

                //绑定性别
                ControlUtil.BindListControl(cbxMaitenanceMileage, car.GetMaintenanceMileage(), "Value", "Key",
                    "请选择", string.Empty, 0);
                
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

                CarInfo carInfo = GetCarInfo(currentCarId);

                if (carInfo == null)
                {
                    return;
                }

                txtNumber.Text = carInfo.Number;
                txtBrand.Text = carInfo.Brand;
                txtModel.Text = carInfo.Model;

                if (carInfo.Displacement.HasValue)
                    txtDisplacement.Text = carInfo.Displacement.Value.ToString();

                txtFrameNumber.Text = carInfo.FrameNumber;
                txtEngineNumber.Text = carInfo.EngineNumber;
                txtBodyColor.Text = carInfo.BodyColor;
                txtInteriorColor.Text = carInfo.InteriorColor;

                if (carInfo.InvoiceDate.HasValue)
                    dtpInvoiceDate.Text = carInfo.InvoiceDate.Value.ToShortDateString();

                if (carInfo.BuyMileage.HasValue)
                    txtBuyMileage.Text = carInfo.BuyMileage.Value.ToString();

                if (carInfo.RegisterDate.HasValue)
                    dtpRegisterDate.Text = carInfo.RegisterDate.Value.ToShortDateString();

                txtMileage.Text = carInfo.Mileage.ToString();

                ControlUtil.SetListControlSelectedByValue(cbxMaintenancePeriod, carInfo.MaintenancePeriod.ToString());
                ControlUtil.SetListControlSelectedByValue(cbxMaitenanceMileage, carInfo.NextMaintenanceMileage.ToString());

                if (carInfo.NextMaintenanceDate.HasValue)
                    dtpNextMaintenanceDate.Text = carInfo.NextMaintenanceDate.Value.ToShortDateString();

                if (carInfo.NextMaintenanceMileage.HasValue)
                    txtNextMaintenanceMileage.Text = carInfo.NextMaintenanceMileage.Value.ToString();

                if (carInfo.GuaranteePeriod.HasValue)
                    txtGuaranteePeriod.Text = carInfo.GuaranteePeriod.Value.ToString();

                if (carInfo.GuaranteeMileage.HasValue)
                    txtGuaranteeMileage.Text = carInfo.GuaranteeMileage.Value.ToString();
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("绑定车辆信息失败！", ref ex);
            }
        }

        public void Save()
        {
            CarInfo carInfo = new CarInfo();

            if (string.IsNullOrEmpty(currentCarId))
            {
                carInfo.Id = Guid.NewGuid().ToString();
                carInfo.CreateDate = DateTime.Now;
                carInfo.Creator = CarManageConfig.Instance.UserData.UserName;
            }
            else
            {
                carInfo = car.Load(currentCarId);
            }

            carInfo.CustomerId = CustomerId;
            carInfo.Number = CommonUtil.FilterInput(txtNumber.Text);
            carInfo.Brand = CommonUtil.FilterInput(txtBrand.Text);
            carInfo.Model = CommonUtil.FilterInput(txtModel.Text);
            carInfo.Displacement = ConvertUtil.ToNullableDecimal(CommonUtil.FilterInput(txtDisplacement.Text));
            carInfo.FrameNumber = CommonUtil.FilterInput(txtFrameNumber.Text);
            carInfo.EngineNumber = CommonUtil.FilterInput(txtEngineNumber.Text);
            carInfo.BodyColor = CommonUtil.FilterInput(txtBodyColor.Text);
            carInfo.InteriorColor = CommonUtil.FilterInput(txtInteriorColor.Text);
            carInfo.InvoiceDate = ConvertUtil.ToNullableDateTime(dtpInvoiceDate.Text);
            carInfo.BuyMileage = ConvertUtil.ToNullableInt32(CommonUtil.FilterInput(txtBuyMileage.Text));
            carInfo.RegisterDate = ConvertUtil.ToNullableDateTime(dtpRegisterDate.Text);
            carInfo.Mileage = Convert.ToInt32(CommonUtil.FilterInput(txtMileage.Text));
            carInfo.MaintenancePeriod = ConvertUtil.ToInt32(cbxMaintenancePeriod.SelectedValue);
            carInfo.MaintenanceMileage = ConvertUtil.ToInt32(cbxMaitenanceMileage.SelectedValue);
            carInfo.NextMaintenanceDate = ConvertUtil.ToNullableDateTime(dtpNextMaintenanceDate.Text);
            carInfo.NextMaintenanceMileage = ConvertUtil.ToNullableInt32(CommonUtil.FilterInput(txtNextMaintenanceMileage.Text));
            carInfo.GuaranteePeriod = ConvertUtil.ToNullableInt32(CommonUtil.FilterInput(txtGuaranteePeriod.Text));
            carInfo.GuaranteeMileage = ConvertUtil.ToNullableInt32(CommonUtil.FilterInput(txtGuaranteeMileage.Text));
            carInfo.UpdateDate = DateTime.Now;
            carInfo.Operator = CarManageConfig.Instance.UserData.UserName;
            carInfo.Valid = true;

            if (string.IsNullOrEmpty(currentCarId))
            {
                car.Add(carInfo);
                carInfo.Id = Guid.NewGuid().ToString();
            }
            else
            {
                car.Update(carInfo);
            }
        }

        private CarInfo GetCarInfo(string id)
        {
            return new CarInfo();
        }
    }
}
