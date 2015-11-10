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

using CarManage.Model.Customer;

namespace CarManage.Interface.DataAccess.Customer
{
    ///<summary>
    ///<summary>客户信息数据访问接口对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-10</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public interface ICustomer
    {
        /// <summary>
        /// 新增客户信息
        /// </summary>
        /// <param name="customerInfo">客户信息</param>
        void Add(CustomerInfo customerInfo);

        /// <summary>
        /// 更新客户信息
        /// </summary>
        /// <param name="customerInfo">客户信息信息对象</param>
        void Update(CustomerInfo customerInfo);

        /// <summary>
        /// 删除客户信息
        /// </summary>
        /// <param name="id">客户信息Id</param>
        void Delete(string id);

        /// <summary>
        /// 获取客户信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回客户信息对象，如果无匹配则返回null。</returns>
        CustomerInfo Load(string id);

        /// <summary>
        /// 查询客户信息
        /// </summary>
        /// <returns>客户信息集合</returns>
        List<CustomerInfo> Search(CustomerInfo queryInfo);
    }
}