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

using CarManage.Model.Maintenance;

namespace CarManage.Interface.DataAccess.Maintenance
{
    ///<summary>
    ///<summary>保养信息数据访问接口对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-11</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public interface IMaintenance
    {
        /// <summary>
        /// 新增保养信息
        /// </summary>
        /// <param name="maintenanceInfo">保养信息</param>
        void Add(MaintenanceInfo maintenanceInfo);

        /// <summary>
        /// 更新保养信息
        /// </summary>
        /// <param name="maintenanceInfo">保养信息信息对象</param>
        void Update(MaintenanceInfo maintenanceInfo);

        /// <summary>
        /// 删除保养信息
        /// </summary>
        /// <param name="id">保养信息Id</param>
        void Delete(string id);

        /// <summary>
        /// 获取保养信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回保养信息对象，如果无匹配则返回null。</returns>
        MaintenanceInfo Load(string id);

        /// <summary>
        /// 查询保养信息
        /// </summary>
        /// <returns>保养信息集合</returns>
        List<MaintenanceInfo> Search(MaintenanceInfo queryInfo);
    }
}