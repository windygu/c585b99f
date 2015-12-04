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

namespace CarManage.Model.Insurance
{
    ///<summary>
    ///<summary>保险信息对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-10</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class InsuranceInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public InsuranceInfo()
        {
            Items = new List<InsuranceItemInfo>();
        }

        #endregion

        #region 基础属性

        ///<summary>
        ///主键
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        ///车牌号
        ///</summary>
        public string CarNumber { get; set; }

        ///<summary>
        ///车架号
        ///</summary>
        public string FrameNumber { get; set; }

        ///<summary>
        ///发动机号
        ///</summary>
        public string EngineNumber { get; set; }

        ///<summary>
        ///被保险人
        ///</summary>
        public string Insurant { get; set; }

        ///<summary>
        ///被保险人电话
        ///</summary>
        public string InsurantPhone { get; set; }

        /// <summary>
        /// 保养项摘要
        /// </summary>
        public string ItemSummary { get; set; }

        ///<summary>
        ///保险公司编码
        ///</summary>
        public string InsuranceCompanyCode { get; set; }

        ///<summary>
        ///保险金额
        ///</summary>
        public decimal Amount { get; set; }

        ///<summary>
        ///本店投保
        ///</summary>
        public bool? Local { get; set; }

        ///<summary>
        ///投保日期
        ///</summary>
        public DateTime InsuranceDate { get; set; }

        ///<summary>
        ///续保日期
        ///</summary>
        public DateTime? NextInsuranceDate { get; set; }

        ///<summary>
        ///续保提醒日期
        ///</summary>
        public DateTime? RemindDate { get; set; }

        ///<summary>
        ///创建日期
        ///</summary>
        public DateTime CreateDate { get; set; }

        ///<summary>
        ///更新日期
        ///</summary>
        public DateTime UpdateDate { get; set; }

        ///<summary>
        ///创建人
        ///</summary>
        public string Creator { get; set; }

        ///<summary>
        ///操作人
        ///</summary>
        public string Operator { get; set; }

        ///<summary>
        ///是否有效
        ///</summary>
        public bool Valid { get; set; }


        #endregion

        #region 扩展属性

        public List<InsuranceItemInfo> Items { get; set; }

        #endregion
    }
}