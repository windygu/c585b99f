using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManage.Model.Customer
{
    [Serializable]
    public class CustomerListInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public CustomerListInfo()
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
        ///排量
        ///</summary>
        public decimal? Displacement { get; set; }

        ///<summary>
        ///车主
        ///</summary>
        public string Owner { get; set; }

        ///<summary>
        ///车身颜色
        ///</summary>
        public string BodyColor { get; set; }

        ///<summary>
        ///上牌日期
        ///</summary>
        public string RegisterDate { get; set; }

        ///<summary>
        ///行驶里程
        ///</summary>
        public string Mileage { get; set; }

        ///<summary>
        ///客户顾问
        ///</summary>
        public string Solicitor { get; set; }

        ///<summary>
        ///更新日期
        ///</summary>
        public string UpdateDate { get; set; }

        ///<summary>
        ///客户ID
        ///</summary>
        public string CustomerID { get; set; }

        ///<summary>
        ///车辆ID
        ///</summary>
        public string CarID { get; set; }

        #endregion

        #region 扩展属性

        #endregion

    }
}
