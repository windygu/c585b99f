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
using CarManage.Interface.DataAccess.Customer;
using CarManage.Business.Common;
using CarManage.Model.Customer;
using CarManage.Model.Enum;

namespace CarManage.Business.Customer
{
    ///<summary>
    ///<summary>业务对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-09</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Car
    {
        private static ICar car = DataAccessFactory.CreateInstance<ICar>();

        private CodeBook codeBook = new CodeBook();

        /// <summary>
        /// 新增车辆信息
        /// </summary>
        /// <param name="carInfo">车辆信息</param>
        public void Add(CarInfo carInfo)
        {
            try
            {
                SetGuaratee(carInfo);
                car.Add(carInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("新增车辆信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新车辆信息
        /// </summary>
        /// <param name="carInfo">车辆信息信息对象</param>
        public void Update(CarInfo carInfo)
        {
            try
            {
                SetGuaratee(carInfo);
                car.Update(carInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("更新车辆信息失败！", ex);
            }
        }

        /// <summary>
        /// 删除车辆信息
        /// </summary>
        /// <param name="id">车辆信息Id</param>
        public void Delete(string id)
        {
            try
            {
                car.Delete(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("删除车辆信息失败！", ex);
            }
        }

        /// <summary>
        /// 获取车辆信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回车辆信息对象，如果无匹配则返回null。</returns>
        public CarInfo Load(string id)
        {
            CarInfo carInfo = null;

            try
            {
                carInfo = car.Load(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取车辆信息失败！", ex);
            }

            return carInfo;
        }

        /// <summary>
        /// 查询车辆信息
        /// </summary>
        /// <returns>车辆信息集合</returns>
        public List<CarInfo> Search(CarInfo queryInfo)
        {
            List<CarInfo> carList = new List<CarInfo>();

            try
            {
                carList = car.Search(queryInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("查询车辆信息失败！", ex);
            }

            return carList;
        }

        /// <summary>
        /// 获取车辆保养周期字典集合
        /// </summary>
        /// <returns>返回喜欢的销售活动字典集合</returns>
        public Dictionary<string, string> GetMaintenancePeriod()
        {
            return codeBook.GetCodes(CodeBook.MaintenancePeriodCodeType).ToDictionary(k => k.Code, v => v.Name);
        }

        /// <summary>
        /// 获取保养间隔里程字典集合
        /// </summary>
        /// <returns>返回喜欢的销售活动字典集合</returns>
        public Dictionary<string, string> GetMaintenanceMileage()
        {
            return codeBook.GetCodes(CodeBook.MaintenanceMileageCodeType).ToDictionary(k => k.Code, v => v.Name);
        }

        /// <summary>
        /// 设置实际质保到期日期及里程
        /// </summary>
        /// <param name="carInfo">车辆信息对象</param>
        private void SetGuaratee(CarInfo carInfo)
        {
            if (carInfo.InvoiceDate.HasValue && carInfo.GuaranteePeriod.HasValue)
            {
                carInfo.ActualGuaranteeDate = carInfo.InvoiceDate.Value.AddYears(carInfo.GuaranteePeriod.Value);
            }

            if (carInfo.GuaranteeMileage.HasValue)
                carInfo.ActualGuaranteeMileage = carInfo.GuaranteeMileage.Value;
        }
    }
}