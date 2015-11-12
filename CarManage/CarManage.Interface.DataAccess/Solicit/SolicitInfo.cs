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
    ///<summary>招揽信息数据访问接口对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-12</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public interface ISolicit
    {
        /// <summary>
        /// 新增招揽信息
        /// </summary>
        /// <param name="solicitInfo">招揽信息</param>
        void Add(SolicitInfo solicitInfo);

        /// <summary>
        /// 更新招揽信息
        /// </summary>
        /// <param name="solicitInfo">招揽信息信息对象</param>
        void Update(SolicitInfo solicitInfo);

        /// <summary>
        /// 删除招揽信息
        /// </summary>
        /// <param name="id">招揽信息Id</param>
        void Delete(string id);

        /// <summary>
        /// 获取招揽信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回招揽信息对象，如果无匹配则返回null。</returns>
        SolicitInfo Load(string id);

        /// <summary>
        /// 查询招揽信息
        /// </summary>
        /// <returns>招揽信息集合</returns>
        List<SolicitInfo> Search(SolicitInfo queryInfo);
    }
}