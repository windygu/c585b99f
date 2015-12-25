using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManage.Model.Solicit
{
    ///<summary>
    ///<summary>招揽查询结果对象</summary>
    ///<creator>张凯</creator>
    ///<createdate>2015-12-24</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class SolicitListInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public SolicitListInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///车牌号
        ///</summary>
        public string Number { get; set; }

        ///<summary>
        ///车型
        ///</summary>
        public string Model { get; set; }

        ///<summary>
        ///车主
        ///</summary>
        public string Owner { get; set; }

        ///<summary>
        ///业务活动
        ///</summary>
        public string Activity { get; set; }

        ///<summary>
        ///招揽内容
        ///</summary>
        public string Content { get; set; }

        ///<summary>
        ///预计招揽日期
        ///</summary>
        public string EstimateDate { get; set; }

        ///<summary>
        ///习惯接电话时间
        ///</summary>
        public string FreeTime { get; set; }

        ///<summary>
        ///状态
        ///</summary>
        public string Status { get; set; }

        #endregion

        #region 扩展属性

        #endregion

    }
}
