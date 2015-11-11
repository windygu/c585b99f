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

using ClassLibrary.ExceptionHandling;
using ClassLibrary.Utility.Common;
using CarManage.Factory.DataAccess;
using CarManage.Interface.DataAccess.Insurance;
using CarManage.Model.Insurance;
using CarManage.Model.Enum;

namespace CarManage.Business.Insurance
{
    ///<summary>
    ///<summary>保险信息业务对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-11</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Insurance
    {
        private static CarManage.Interface.DataAccess.Insurance.IInsurance insurance = 
            DataAccessFactory.CreateInstance<IInsurance>();

        /// <summary>
        /// 新增保险信息
        /// </summary>
        /// <param name="insuranceInfo">保险信息</param>
        public void Add(InsuranceInfo insuranceInfo)
        {
            try
            {
                insurance.Add(insuranceInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("新增保险信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新保险信息
        /// </summary>
        /// <param name="insuranceInfo">保险信息信息对象</param>
        public void Update(InsuranceInfo insuranceInfo)
        {
            try
            {
                insurance.Update(insuranceInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("更新保险信息失败！", ex);
            }
        }

        /// <summary>
        /// 删除保险信息
        /// </summary>
        /// <param name="id">保险信息Id</param>
        public void Delete(string id)
        {
            try
            {
                insurance.Delete(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("删除保险信息失败！", ex);
            }
        }

        /// <summary>
        /// 获取保险信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回保险信息对象，如果无匹配则返回null。</returns>
        public InsuranceInfo Load(string id)
        {
            InsuranceInfo insuranceInfo = null;

            try
            {
                insuranceInfo = insurance.Load(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取保险信息失败！", ex);
            }

            return insuranceInfo;
        }

        /// <summary>
        /// 查询保险信息
        /// </summary>
        /// <returns>保险信息集合</returns>
        public List<InsuranceInfo> Search(InsuranceInfo queryInfo)
        {
            List<InsuranceInfo> insuranceList = new List<InsuranceInfo>();

            try
            {
                insuranceList = insurance.Search(queryInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("查询保险信息失败！", ex);
            }

            return insuranceList;
        }
    }
}