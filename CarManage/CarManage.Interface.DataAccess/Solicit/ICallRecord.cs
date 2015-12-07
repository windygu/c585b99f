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

using CarManage.Model.Solicit;

namespace CarManage.Interface.DataAccess.Solicit
{
    ///<summary>
    ///<summary>通话录音信息数据访问接口对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-12-07</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public interface ICallRecord
    {
        /// <summary>
        /// 新增通话录音信息
        /// </summary>
        /// <param name="callRecordInfo">通话录音信息</param>
        void Add(CallRecordInfo callRecordInfo);

        /// <summary>
        /// 更新通话录音信息
        /// </summary>
        /// <param name="callRecordInfo">通话录音信息信息对象</param>
        void Update(CallRecordInfo callRecordInfo);

        /// <summary>
        /// 删除通话录音信息
        /// </summary>
        /// <param name="id">通话录音信息Id</param>
        void Delete(string id);

        /// <summary>
        /// 获取通话录音信息对象
        /// </summary>
        /// <param name="customerId">主键</param>
        /// <returns>返回通话录音信息对象，如果无匹配则返回null。</returns>
        CallRecordInfo Load(string id);

        /// <summary>
        /// 获取通话录音信息对象
        /// </summary>
        /// <param name="customerId">客户主键</param>
        /// <returns>返回通话录音信息对象集合。</returns>
        List<CallRecordInfo> GetRecordsByCustomerId(string customerId);

        /// <summary>
        /// 查询通话录音信息
        /// </summary>
        /// <returns>通话录音信息集合</returns>
        List<CallRecordInfo> Search(CallRecordInfo queryInfo);
    }
}