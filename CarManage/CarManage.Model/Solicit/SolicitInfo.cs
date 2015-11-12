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

namespace CarManage.Model.Solicit
{
    ///<summary>
    ///<summary>招揽信息对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-12</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class SolicitInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public SolicitInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///主键
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        ///业务表主键
        ///</summary>
        public string BizId { get; set; }

        ///<summary>
        ///客户Id
        ///</summary>
        public string CustomerId { get; set; }

        ///<summary>
        ///车辆主键
        ///</summary>
        public string CarId { get; set; }

        ///<summary>
        ///业务活动编码
        ///</summary>
        public string ActivityCode { get; set; }

        ///<summary>
        ///预计招揽日期
        ///</summary>
        public DateTime EstimateDate { get; set; }

        ///<summary>
        ///招揽内容
        ///</summary>
        public string Content { get; set; }

        ///<summary>
        ///客户反馈
        ///</summary>
        public string Feedback { get; set; }

        ///<summary>
        ///招揽业务员
        ///</summary>
        public string Solicitor { get; set; }

        ///<summary>
        /// 实际招揽日期
        ///</summary>
        public DateTime? SolicitDate { get; set; }

        ///<summary>
        ///招揽结果
        ///</summary>
        public SolicitResult Result { get; set; }

        ///<summary>
        ///状态
        ///</summary>
        public SolicitStatus Status { get; set; }

        ///<summary>
        ///创建日期
        ///</summary>
        public DateTime CreateDate { get; set; }

        ///<summary>
        ///创建人
        ///</summary>
        public string Creator { get; set; }

        ///<summary>
        ///更新日期
        ///</summary>
        public DateTime UpdateDate { get; set; }

        ///<summary>
        ///更新人
        ///</summary>
        public string Updater { get; set; }

        ///<summary>
        ///是否有效
        ///</summary>
        public bool Valid { get; set; }


        #endregion

        #region 扩展属性

        #endregion
    }
}