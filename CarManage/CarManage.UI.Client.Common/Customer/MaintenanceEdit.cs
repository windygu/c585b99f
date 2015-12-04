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
using CarManage.Model.Maintenance;
using CarManage.Model.Enum;

namespace CarManage.UI.Client.Common.Customer
{
    public partial class MaintenanceEdit : UserControlBase
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
        /// 保养记录主键
        /// </summary>
        public string MaintenanceId { get; set; }

        #endregion

        #region 私有变量

        CarManage.Business.Customer.Car car;
        CarManage.Business.Maintenance.Maintenance maintenance;

        #endregion

        public MaintenanceEdit()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            dgvMaintenance.ColumnHeaderBackgroundImage = ImageResource.List_Header_Lower_BG;
            dgvMaintenance.AutoGenerateColumns = false;
        }

        protected override void Init()
        {
            car = new Business.Customer.Car();
            maintenance = new Business.Maintenance.Maintenance();

            base.Init();
        }

        #region 事件

        private void MaintenanceEdit_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定下次保养项目
                chklstNextMaintenance.DataTextField = "Value";
                chklstNextMaintenance.DataValueField = "Key";
                chklstNextMaintenance.DataBind(maintenance.GetMaintenanceItems());

                BindCars();
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

            BindMaintenance();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxStatus.SelectedValue == null || string.IsNullOrEmpty(cbxStatus.SelectedValue.ToString()))
                    throw new Exception("保养状态不能为空！");

                //if(!string.IsNullOrEmpty(MaintenanceId))
                //MaintenanceInfo nextInfo = maintenance.GetNextMaintenance();

                MaintenanceStatus status = ConvertUtil.ToEnum<MaintenanceStatus>(cbxStatus.SelectedValue);

                if (status.Equals(MaintenanceStatus.待保养))
                {
                    dtpNextDate.Text = string.Empty;
                    txtNextMileage.Text = string.Empty;
                    tlpNext.Visible = false;
                }
                else
                {
                    tlpNext.Visible = true;
                }
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("切换是否显示下次保养信息失败！", ref ex);
            }
        }

        #endregion

        private void BindCars()
        {
            if (string.IsNullOrEmpty(CustomerId))
                return;

            List<CarInfo> carList = car.GetCars(CustomerId);

            carList.ForEach(info => info.Number = info.Number + info.Model);

            ControlUtil.BindListControl(cbxCars, carList, "Number", "Id", 0);
        }

        private void BindMaintenance()
        {
            List<MaintenanceInfo> maintenanceList = maintenance.GetMaintenances(CarId);

            dgvMaintenance.DataSource = maintenanceList;
        }

        public void BindMaintenanceDetail()
        {
            try
            {
                if (string.IsNullOrEmpty(MaintenanceId))
                    return;

                MaintenanceInfo maintenanceInfo = maintenance.Load(MaintenanceId);

                if (maintenanceInfo == null)
                    return;

                if (maintenanceInfo.Date.HasValue)
                    dtpDate.Text = maintenanceInfo.Date.ToString();

                if (maintenanceInfo.Mileage.HasValue)
                    txtMileage.Text = maintenanceInfo.Mileage.ToString();

                if (maintenanceInfo.Amount.HasValue)
                    txtAmount.Text = maintenanceInfo.Amount.ToString();

                if (maintenanceInfo.LoseSales.HasValue)
                    txtLoseSales.Text = maintenanceInfo.LoseSales.ToString();

                if (maintenanceInfo.PrevDate.HasValue)
                    dtpPrevDate.Text = maintenanceInfo.PrevDate.Value.ToString();

                if (maintenanceInfo.PrevMileage.HasValue)
                    txtPrevMileage.Text = maintenanceInfo.PrevMileage.Value.ToString();

                if (maintenanceInfo.NextDate.HasValue)
                    dtpNextDate.Text = maintenanceInfo.NextDate.Value.ToString();

                if (maintenanceInfo.NextMileage.HasValue)
                    txtNextMileage.Text = maintenanceInfo.NextMileage.Value.ToString();
                
                chklstMaintenance.DataTextField = "ItemName";
                chklstMaintenance.DataValueField = "ItemCode";
                chklstMaintenance.CheckedValues.AddRange(maintenanceInfo.Items.Select(info => info.ItemCode).ToList());
                chklstMaintenance.DataBind(maintenanceInfo.Items);

                ControlUtil.SetListControlSelectedByValue(cbxStatus, ((int)maintenanceInfo.Status).ToString());
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("绑定车辆信息失败！", ref ex);
            }
        }

        public void Save()
        {
            try
            {
                MaintenanceInfo maintenanceInfo = new MaintenanceInfo();

                if (string.IsNullOrEmpty(MaintenanceId))
                {
                    maintenanceInfo.Id = Guid.NewGuid().ToString();
                    maintenanceInfo.CreateDate = DateTime.Now;
                    maintenanceInfo.Creator = CarManageConfig.Instance.UserData.UserName;
                }
                else
                {
                    maintenanceInfo = maintenance.Load(MaintenanceId);
                }

                maintenanceInfo.CarId = CarId;
                maintenanceInfo.Date = ConvertUtil.ToNullableDateTime(dtpDate.Text);

                maintenanceInfo.Mileage = ConvertUtil.ToNullableInt32(txtMileage.Text);
                maintenanceInfo.Amount = ConvertUtil.ToNullableDecimal(txtAmount.Text);
                maintenanceInfo.LoseSales = ConvertUtil.ToNullableDecimal(CommonUtil.FilterInput(txtLoseSales.Text));
                maintenanceInfo.PrevDate = ConvertUtil.ToNullableDateTime(dtpPrevDate.Text);
                maintenanceInfo.PrevMileage = ConvertUtil.ToNullableInt32(CommonUtil.FilterInput(txtPrevMileage.Text));

                maintenanceInfo.Status = ConvertUtil.ToEnum<MaintenanceStatus>(cbxStatus.SelectedValue);

                if (maintenanceInfo.Status.Equals(MaintenanceStatus.已保养))
                {
                    maintenanceInfo.NextDate = maintenanceInfo.EstimateDate = ConvertUtil.ToNullableDateTime(dtpNextDate.Text);

                    maintenanceInfo.NextMileage = maintenanceInfo.EstimateMileage =
                        ConvertUtil.ToNullableInt32(CommonUtil.FilterInput(txtNextMileage.Text));

                    foreach (ListControlItem item in chklstNextMaintenance.SelectedItem)
                    {
                        maintenanceInfo.NextMaintenanceItems.Add(new MaintenanceItemInfo()
                        {
                            Id = Guid.NewGuid().ToString(),
                            MaintenanceId = maintenanceInfo.Id,
                            CarId = this.CarId,
                            ItemName = item.Text,
                            ItemCode = item.Value,
                            Canceled = false
                        });
                    }
                }

                maintenanceInfo.Operator = CarManageConfig.Instance.UserData.UserName;
                maintenanceInfo.UpdateDate = DateTime.Now;
                maintenanceInfo.Valid = true;

                if (string.IsNullOrEmpty(MaintenanceId))
                {
                    maintenance.Add(maintenanceInfo);
                }
                else
                {
                    maintenance.Update(maintenanceInfo);
                }
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("保存保养信息失败！", ref ex);
            }
        }

        public void Reset()
        {
            MaintenanceId = string.Empty;

            dtpDate.Text = string.Empty;
            txtMileage.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtLoseSales.Text = string.Empty;
            dtpPrevDate.Text = string.Empty;
            txtPrevMileage.Text = string.Empty;

            chklstNextMaintenance.DataTextField = "Value";
            chklstNextMaintenance.DataValueField = "Key";
            chklstNextMaintenance.DataBind(maintenance.GetMaintenanceItems());

            ControlUtil.SetListControlSelectedByValue(cbxStatus, ((int)MaintenanceStatus.待保养).ToString());
            dtpNextDate.Text = string.Empty;
            txtNextMileage.Text = string.Empty;
        }

        private void dgvMaintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(colStatusText.Index))
                {
                    string id = dgvMaintenance.Rows[e.RowIndex].Cells[colId.Index].Value.ToString();

                    if (string.IsNullOrEmpty(id))
                        throw new Exception("保养信息Id无效！");

                    MaintenanceId = id;
                    BindMaintenanceDetail();
                }
            }
            catch (Exception ex)
            {
                UserInterfaceExceptionHandler.HandlerException("查看指定保养记录信息失败！", ref ex);
            }
        }
    }
}
