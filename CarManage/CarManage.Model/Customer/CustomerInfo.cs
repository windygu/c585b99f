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

namespace CarManage.Model.Customer
{
    ///<summary>
    ///<summary>客户信息对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-10</createdate>
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
        ///主键
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        ///车主
        ///</summary>
        public string Owner { get; set; }

        ///<summary>
        ///车主地址
        ///</summary>
        public string OwnerAddress { get; set; }

        ///<summary>
        ///车辆使用人
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        ///性别（1：男，2：女）
        ///</summary>
        public Sex Sex { get; set; }

        ///<summary>
        ///称呼
        ///</summary>
        public string Alias { get; set; }

        ///<summary>
        ///住宅电话
        ///</summary>
        public string Tel { get; set; }

        ///<summary>
        ///移动电话
        ///</summary>
        public string Mobile { get; set; }

        ///<summary>
        ///客户地址
        ///</summary>
        public string UserAddress { get; set; }

        ///<summary>
        ///邮箱
        ///</summary>
        public string Email { get; set; }

        ///<summary>
        ///微信号
        ///</summary>
        public string WeChat { get; set; }

        ///<summary>
        ///习惯接电话时间
        ///</summary>
        public FreeTime FreeTime { get; set; }

        ///<summary>
        ///喜欢的售后市场活动
        ///</summary>
        public string PreferSupport { get; set; }

        ///<summary>
        ///喜欢的销售市场活动
        ///</summary>
        public string PreferSale { get; set; }

        /// <summary>
        /// 喜欢的饮品
        /// </summary>
        public string PreferDrink { get; set; }

        ///<summary>
        ///性格类型
        ///</summary>
        public CustomerCharacter Character { get; set; }

        ///<summary>
        ///销售类型
        ///</summary>
        public string SaleType { get; set; }

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

        #endregion
    }
}