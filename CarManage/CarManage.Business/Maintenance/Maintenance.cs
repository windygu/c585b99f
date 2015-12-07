#region CopyRight
// -----------------------------------------------------------------------------------
// 版权声明： 
// 使用声明： 任何组织和个人未经许可不得擅自复制或更改其内容
// 软件版本： 1.0
// 公司地址： 
// 公司电话： ***
// -----------------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

using ClassLibrary.ExceptionHandling;
using ClassLibrary.Utility.Common;
using CarManage.Factory.DataAccess;
using CarManage.Interface.DataAccess.Maintenance;
using CarManage.Model.Maintenance;
using CarManage.Model.Common;
using CarManage.Model.Enum;

namespace CarManage.Business.Maintenance
{
    ///<summary>
    ///<summary>保养信息业务对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-11</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Maintenance
    {
        private static CarManage.Interface.DataAccess.Maintenance.IMaintenance maintenance = 
            DataAccessFactory.CreateInstance<IMaintenance>();

        private CarManage.Business.Common.CodeBook codeBook = new Common.CodeBook();

        /// <summary>
        /// 新增保养信息
        /// </summary>
        /// <param name="maintenanceInfo">保养信息</param>
        public void Add(MaintenanceInfo maintenanceInfo)
        {
            try
            {
                maintenanceInfo.ItemSummary = GetItemSummary(maintenanceInfo.Items);

                if (maintenanceInfo.NextDate.HasValue)
                {
                    MaintenanceInfo nextInfo = CreateNextMaintenance(maintenanceInfo);

                    using (ClassLibrary.Transaction.TransactionScope scope = new ClassLibrary.Transaction.TransactionScope())
                    {
                        maintenance.Add(maintenanceInfo);
                        maintenance.Add(nextInfo);
                        scope.Complete();
                    }
                }
                else
                {
                    maintenance.Add(maintenanceInfo);
                }
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("新增保养信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新保养信息
        /// </summary>
        /// <param name="maintenanceInfo">保养信息信息对象</param>
        public void Update(MaintenanceInfo maintenanceInfo)
        {
            try
            {
                maintenanceInfo.ItemSummary = GetItemSummary(maintenanceInfo.Items);

                MaintenanceInfo nextInfo = maintenance.GetNextMaintenance(maintenanceInfo.Id);

                if (nextInfo == null && maintenanceInfo.NextDate.HasValue)
                {
                    nextInfo = CreateNextMaintenance(maintenanceInfo);

                    using (ClassLibrary.Transaction.TransactionScope scope = new ClassLibrary.Transaction.TransactionScope())
                    {
                        maintenance.Update(maintenanceInfo);
                        maintenance.Add(nextInfo);
                        scope.Complete();
                    }
                }
                else
                {
                    maintenance.Update(maintenanceInfo);
                }
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("更新保养信息失败！", ex);
            }
        }

        /// <summary>
        /// 删除保养信息
        /// </summary>
        /// <param name="id">保养信息Id</param>
        public void Delete(string id)
        {
            try
            {
                maintenance.Delete(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("删除保养信息失败！", ex);
            }
        }

        /// <summary>
        /// 获取保养信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回保养信息对象，如果无匹配则返回null。</returns>
        public MaintenanceInfo Load(string id)
        {
            MaintenanceInfo maintenanceInfo = null;

            try
            {
                maintenanceInfo = maintenance.Load(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取保养信息失败！", ex);
            }

            return maintenanceInfo;
        }

        /// <summary>
        /// 获取指定保养记录的下次保养记录
        /// </summary>
        /// <param name="prevId">当前保养记录主键</param>
        /// <returns>返回保养信息对象，如果无匹配则返回null。</returns>
        public MaintenanceInfo GetNextMaintenance(string prevId)
        {
            MaintenanceInfo maintenanceInfo = null;

            try
            {
                maintenanceInfo = maintenance.GetNextMaintenance(prevId);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取下次保养信息失败！", ex);
            }

            return maintenanceInfo;
        }

        /// <summary>
        /// 获取车辆保养信息
        /// </summary>
        /// <param name="carId">车辆主键</param>
        /// <returns>返回车辆保养信息对象集合</returns>
        public List<MaintenanceInfo> GetMaintenances(string carId)
        {
            List<MaintenanceInfo> maintenanceList = new List<MaintenanceInfo>();

            try
            {
                maintenanceList = maintenance.GetMaintenances(carId);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取车辆保养信息失败！", ex);
            }

            return maintenanceList;
        }

        /// <summary>
        /// 查询保养信息
        /// </summary>
        /// <returns>保养信息集合</returns>
        public List<MaintenanceInfo> Search(MaintenanceInfo queryInfo)
        {
            List<MaintenanceInfo> maintenanceList = new List<MaintenanceInfo>();

            try
            {
                maintenanceList = maintenance.Search(queryInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("查询保养信息失败！", ex);
            }

            return maintenanceList;
        }

        /// <summary>
        /// 获取保养项目字典集合
        /// </summary>
        /// <returns>返回保养项目字典集合</returns>
        public Dictionary<string, string> GetMaintenanceItems()
        {
            return codeBook.GetCodes(CodeBookInfo.MaintenanceItemCodeType).ToDictionary(k => k.Code, v => v.Name);
        }

        /// <summary>
        /// 生成保养项目摘要
        /// </summary>
        /// <param name="itemList">保养项目信息对象集合</param>
        /// <returns>返回由分号作为分隔符组成的保养项目摘要</returns>
        private string GetItemSummary(List<MaintenanceItemInfo> itemList)
        {
            string result = string.Empty;

            itemList.ForEach(info => result += info.ItemName + ";");

            return result;
        }

        /// <summary>
        /// 生成下次保养记录
        /// </summary>
        /// <param name="maintenanceInfo"></param>
        /// <returns></returns>
        private MaintenanceInfo CreateNextMaintenance(MaintenanceInfo maintenanceInfo)
        {
            MaintenanceInfo nextInfo = new MaintenanceInfo();

            nextInfo.Id = Guid.NewGuid().ToString();
            nextInfo.PrevId = maintenanceInfo.Id;
            nextInfo.CarId = maintenanceInfo.CarId;
            nextInfo.PrevDate = maintenanceInfo.Date;
            nextInfo.PrevMileage = maintenanceInfo.Mileage;
            nextInfo.ItemSummary = GetItemSummary(nextInfo.Items);
            nextInfo.Status = MaintenanceStatus.待保养;
            nextInfo.EstimateDate = maintenanceInfo.NextDate;
            nextInfo.EstimateMileage = maintenanceInfo.NextMileage;
            nextInfo.CreateDate = DateTime.Now;
            nextInfo.Creator = maintenanceInfo.Creator;
            nextInfo.Operator = maintenanceInfo.Operator;
            nextInfo.UpdateDate = DateTime.Now;
            nextInfo.Valid = true;

            foreach (MaintenanceItemInfo itemInfo in maintenanceInfo.NextMaintenanceItems)
            {
                MaintenanceItemInfo nextItemInfo = CommonUtil.DeepClone<MaintenanceItemInfo>(itemInfo);
                nextItemInfo.MaintenanceId = nextInfo.Id;

                nextInfo.Items.Add(nextItemInfo);
            }

            return nextInfo;
        }
    }
}