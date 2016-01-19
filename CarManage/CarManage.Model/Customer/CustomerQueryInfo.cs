using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManage.Model.Customer
{
    [Serializable]
    public class CustomerQueryInfo : BaseModel
    {
        
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public CustomerQueryInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///车牌号
        ///</summary>
        public string Number { get; set; }

        ///<summary>
        ///车主
        ///</summary>
        public string Owner { get; set; }

        ///<summary>
        ///手机号
        ///</summary>
        public string Mobile { get; set; }

        #endregion

        #region 扩展属性

        #endregion

    }
}
