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
                maintenance.Add(maintenanceInfo);
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
                maintenance.Update(maintenanceInfo);
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
        /// 获取车辆保养信息
        /// </summary>
        /// <param name="carId">车辆主键</param>
        /// <returns>返回车辆保养信息对象集合</returns>
        List<MaintenanceInfo> GetMaintenances(string carId)
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
    }
}