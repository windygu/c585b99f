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

using CarManage.Model;
using CarManage.Model.Enum;

namespace CarManage.Model.Maintenance
{
    ///<summary>
    ///<summary>保养信息对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-11</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class MaintenanceInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public MaintenanceInfo()
        {
            Items = new List<MaintenanceItemInfo>();
        }

        #endregion

        #region 基础属性

        ///<summary>
        ///主键
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        ///车辆主键
        ///</summary>
        public string CarId { get; set; }

        /// <summary>
        /// 保养项摘要
        /// </summary>
        public string ItemSummary { get; set; }

        ///<summary>
        ///实际保养日期
        ///</summary>
        public DateTime? Date { get; set; }

        ///<summary>
        ///实际保养里程
        ///</summary>
        public int? Mileage { get; set; }

        ///<summary>
        ///金额
        ///</summary>
        public decimal? Amount { get; set; }

        ///<summary>
        ///失销金额
        ///</summary>
        public decimal? LoseSales { get; set; }

        ///<summary>
        ///上次保养日期
        ///</summary>
        public DateTime? PrevDate { get; set; }

        ///<summary>
        ///上次保养里程
        ///</summary>
        public int? PrevMileage { get; set; }

        ///<summary>
        ///下次保养日期
        ///</summary>
        public DateTime NextDate { get; set; }

        ///<summary>
        ///下次保养里程
        ///</summary>
        public int NextMileage { get; set; }

        ///<summary>
        ///预计保养日期
        ///</summary>
        public DateTime EstimateDate { get; set; }

        ///<summary>
        ///预计保养里程
        ///</summary>
        public int EstimateMileage { get; set; }

        ///<summary>
        ///保养类型
        ///</summary>
        public int Type { get; set; }

        ///<summary>
        ///状态
        ///</summary>
        public MaintenanceStatus Status { get; set; }

        ///<summary>
        ///创建人
        ///</summary>
        public string Creator { get; set; }

        ///<summary>
        ///更新人
        ///</summary>
        public string Operator { get; set; }

        ///<summary>
        ///创建日期
        ///</summary>
        public DateTime CreateDate { get; set; }

        ///<summary>
        ///更新日期
        ///</summary>
        public DateTime UpdateDate { get; set; }

        ///<summary>
        ///是否有效
        ///</summary>
        public bool Valid { get; set; }


        #endregion

        #region 扩展属性

        /// <summary>
        /// 保养项目
        /// </summary>
        public List<MaintenanceItemInfo> Items { get; set; }

        #endregion
    }
}