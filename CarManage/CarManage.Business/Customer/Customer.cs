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
using CarManage.Interface.DataAccess.Customer;
using CarManage.Model.Customer;
using CarManage.Model.Enum;

namespace CarManage.Business.Customer
{
    ///<summary>
    ///<summary>客户信息业务对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-10</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Customer
    {
        private static CarManage.Interface.DataAccess.Customer.ICustomer customer = DataAccessFactory.CreateInstance<ICustomer>();

        /// <summary>
        /// 新增客户信息
        /// </summary>
        /// <param name="customerInfo">客户信息</param>
        public void Add(CustomerInfo customerInfo)
        {
            try
            {
                customer.Add(customerInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("新增客户信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新客户信息
        /// </summary>
        /// <param name="customerInfo">客户信息信息对象</param>
        public void Update(CustomerInfo customerInfo)
        {
            try
            {
                customer.Update(customerInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("更新客户信息失败！", ex);
            }
        }

        /// <summary>
        /// 删除客户信息
        /// </summary>
        /// <param name="id">客户信息Id</param>
        public void Delete(string id)
        {
            try
            {
                customer.Delete(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("删除客户信息失败！", ex);
            }
        }

        /// <summary>
        /// 获取客户信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回客户信息对象，如果无匹配则返回null。</returns>
        public CustomerInfo Load(string id)
        {
            CustomerInfo customerInfo = null;

            try
            {
                customerInfo = customer.Load(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取客户信息失败！", ex);
            }

            return customerInfo;
        }

        /// <summary>
        /// 查询客户信息
        /// </summary>
        /// <returns>客户信息集合</returns>
        public List<CustomerInfo> Search(CustomerInfo queryInfo)
        {
            List<CustomerInfo> customerList = new List<CustomerInfo>();

            try
            {
                customerList = customer.Search(queryInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("查询客户信息失败！", ex);
            }

            return customerList;
        }
    }
}