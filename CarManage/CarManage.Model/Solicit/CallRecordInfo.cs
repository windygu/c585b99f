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

namespace CarManage.Model.Solicit
{
    ///<summary>
    ///<summary>通话录音信息对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-12-07</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class CallRecordInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public CallRecordInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///主键
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        ///客户主键
        ///</summary>
        public string CustomerId { get; set; }

        ///<summary>
        ///车辆主键
        ///</summary>
        public string CarId { get; set; }

        ///<summary>
        ///招揽主键
        ///</summary>
        public string SolicitId { get; set; }

        ///<summary>
        ///客户名称
        ///</summary>
        public string CustomerName { get; set; }

        ///<summary>
        ///车牌号
        ///</summary>
        public string CarNumber { get; set; }

        ///<summary>
        ///电话号码
        ///</summary>
        public string Tel { get; set; }

        ///<summary>
        ///通话事项
        ///</summary>
        public string Title { get; set; }

        ///<summary>
        ///客户反馈
        ///</summary>
        public string Feedback { get; set; }

        ///<summary>
        ///通话结果
        ///</summary>
        public int Result { get; set; }

        ///<summary>
        ///通话录音文件路径
        ///</summary>
        public string RecordPath { get; set; }

        ///<summary>
        ///通话录音MD5值
        ///</summary>
        public string RecordMD5 { get; set; }

        ///<summary>
        ///业务员编号
        ///</summary>
        public string OperatorCode { get; set; }

        ///<summary>
        ///业务员名称
        ///</summary>
        public string OperatorName { get; set; }

        ///<summary>
        ///通话开始时间
        ///</summary>
        public DateTime CreateDate { get; set; }


        #endregion

        #region 扩展属性

        #endregion
    }
}