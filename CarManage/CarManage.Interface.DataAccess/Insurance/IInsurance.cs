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

using CarManage.Model.Insurance;

namespace CarManage.Interface.DataAccess.Insurance
{
    ///<summary>
    ///<summary>保险信息数据访问接口对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-10</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public interface IInsurance
    {
        /// <summary>
        /// 新增保险信息
        /// </summary>
        /// <param name="insuranceInfo">保险信息</param>
        void Add(InsuranceInfo insuranceInfo);

        /// <summary>
        /// 更新保险信息
        /// </summary>
        /// <param name="insuranceInfo">保险信息信息对象</param>
        void Update(InsuranceInfo insuranceInfo);

        /// <summary>
        /// 删除保险信息
        /// </summary>
        /// <param name="id">保险信息Id</param>
        void Delete(string id);

        /// <summary>
        /// 获取保险信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回保险信息对象，如果无匹配则返回null。</returns>
        InsuranceInfo Load(string id);

        /// <summary>
        /// 查询保险信息
        /// </summary>
        /// <returns>保险信息集合</returns>
        List<InsuranceInfo> Search(InsuranceInfo queryInfo);
    }
}