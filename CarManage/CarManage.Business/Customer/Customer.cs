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
using CarManage.Model.Customer;
using CarManage.Model.Enum;
using CarManage.Business.Common;

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

        private CodeBook codeBook = new CodeBook();

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

        /// <summary>
        /// 获取客户称呼字典集合
        /// </summary>
        /// <returns>返回客户称呼字典集合</returns>
        public Dictionary<string, string> GetAlias()
        {
            return codeBook.GetCodes(CodeBook.AliasCodeType).ToDictionary(k => k.Code, v => v.Name);
        }

        /// <summary>
        /// 获取性别字典集合
        /// </summary>
        /// <returns>返回性别字典集合</returns>
        public Dictionary<string, string> GetSex()
        {
            return new Dictionary<string, string>();
        }

        /// <summary>
        /// 获取客户空闲时间字典集合
        /// </summary>
        /// <returns>返回客户空闲时间字典集合</returns>
        public Dictionary<string, string> GetFreeTime()
        {
            return new Dictionary<string, string>();
        }

        /// <summary>
        /// 获取喜欢的销售活动字典集合
        /// </summary>
        /// <returns>返回喜欢的销售活动字典集合</returns>
        public Dictionary<string, string> GetPreferSale()
        {
            return codeBook.GetCodes(CodeBook.PreferSaleCodeType).ToDictionary(k => k.Code, v => v.Name);
        }

        /// <summary>
        /// 获取喜欢的售后活动字典集合
        /// </summary>
        /// <returns>返回喜欢的售后活动字典集合</returns>
        public Dictionary<string, string> GetPreferSupport()
        {
            return codeBook.GetCodes(CodeBook.PreferSupportCodeType).ToDictionary(k => k.Code, v => v.Name);
        }

        /// <summary>
        /// 获取喜欢的饮品字典集合
        /// </summary>
        /// <returns>返回喜欢的饮品字典集合</returns>
        public Dictionary<string, string> GetPreferDrink()
        {
            return codeBook.GetCodes(CodeBook.PreferDrinkCodeType).ToDictionary(k => k.Code, v => v.Name);
        }

        /// <summary>
        /// 获取性格类型字典集合
        /// </summary>
        /// <returns>返回性格类型字典集合</returns>
        public Dictionary<string, string> GetCharacter()
        {
            return new Dictionary<string, string>();
        }

        /// <summary>
        /// 获取销售类型字典集合
        /// </summary>
        /// <returns>返回销售类型字典集合</returns>
        public Dictionary<string, string> GetSaleType()
        {
            return codeBook.GetCodes(CodeBook.SaleTypeCodeType).ToDictionary(k => k.Code, v => v.Name);
        }
    }
}