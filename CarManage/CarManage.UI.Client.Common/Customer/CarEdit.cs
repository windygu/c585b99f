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

                CarInfo carInfo = GetCarInfo(string.Empty);

                if (carInfo == null)
                {
                    return;
                }

                txtNumber.Text = carInfo.Number;
                txtBrand.Text = carInfo.Brand;
                txtModel.Text = carInfo.Model;
                txtDisplacement.Text = carInfo.Displacement.ToString();
                txtFrameNumber.Text = carInfo.FrameNumber;
                txtEngineNumber.Text = carInfo.EngineNumber;
                txtBodyColor.Text = carInfo.BodyColor;
                txtInteriorColor.Text = carInfo.InteriorColor;

                if (carInfo.InvoiceDate.HasValue)
                    dtpInvoiceDate.Text = carInfo.InvoiceDate.Value.ToShortDateString();

                if (carInfo.BuyMileage.HasValue)
                    txtBuyMileage.Text = carInfo.BuyMileage.Value.ToString();

                if (carInfo.RegisterDate.HasValue)
                    dtpRegisterDate.Text = carInfo.RegisterDate.Value;

                txtMileage.Text = carInfo.Mileage.ToString();
                ControlUtil.SetListControlSelectedByValue(cbxMaintenancePeriod, carInfo.MaintenancePeriod);
                txtMaintenancePeriod.Text = carInfo.MaintenancePeriod;
                txtMaintenanceMileage.Text = carInfo.MaintenanceMileage;
                txtNextMaintenanceDate.Text = carInfo.NextMaintenanceDate;
                txtNextMaintenanceMileage.Text = carInfo.NextMaintenanceMileage;
                txtGuaranteePeriod.Text = carInfo.GuaranteePeriod;
                txtGuaranteeMileage.Text = carInfo.GuaranteeMileage;
                txtActualGuaranteeDate.Text = carInfo.ActualGuaranteeDate;
                txtActualGuaranteeMileage.Text = carInfo.ActualGuaranteeMileage;
                txtCreateDate.Text = carInfo.CreateDate;
                txtUpdateDate.Text = carInfo.UpdateDate;
                txtCreator.Text = carInfo.Creator;
                txtOperator.Text = carInfo.Operator;
                txtValid.Text = carInfo.Valid;
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("绑定车辆信息失败！", ref ex);
            }
        }

        private CarInfo GetCarInfo(string id)
        {
            return new CarInfo();
        }
    }
}
