using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManage.Model.Solicit
{
    ///<summary>
    ///<summary>招揽查询条件对象</summary>
    ///<creator>张凯</creator>
    ///<createdate>2015-12-24</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    class SolicitQueryInfo : BaseModel
    {
        
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public SolicitQueryInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///车牌号
        ///</summary>
        public string Number { get; set; }

        ///<summary>
        ///车主/使用人
        ///</summary>
        public string OwnerOrUser { get; set; }

        ///<summary>
        ///手机号
        ///</summary>
        public string Mobile { get; set; }

        ///<summary>
        ///招揽业务员
        ///</summary>
        public string Solicitor { get; set; }

        #endregion

        #region 扩展属性

        #endregion
    }
}
