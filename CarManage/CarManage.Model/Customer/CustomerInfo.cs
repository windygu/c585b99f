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

namespace CarManage.Model.Customer
{
    ///<summary>
    ///<summary>对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-09</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class CustomerInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public CustomerInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Owner { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string OwnerAddress { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int Sex { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Alias { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Tel { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Mobile { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string UserAddress { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Email { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string WeChat { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int SpareTIme { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int PreferSupport { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int PreferSale { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int Character { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int SaleType { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime CreateDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime UpdateDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Creator { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Operator { get; set; }

        ///<summary>
        ///
        ///</summary>
        public bool Valid { get; set; }


        #endregion

        #region 扩展属性

        #endregion
    }
}