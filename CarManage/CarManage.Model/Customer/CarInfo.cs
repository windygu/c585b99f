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
    ///<summary>Car对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-04</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class CarInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public CarInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///主键
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        ///客户Id
        ///</summary>
        public string CustomerId { get; set; }

        ///<summary>
        ///车牌号
        ///</summary>
        public string Number { get; set; }

        ///<summary>
        ///品牌
        ///</summary>
        public string Brand { get; set; }

        ///<summary>
        ///车型
        ///</summary>
        public string Model { get; set; }

        ///<summary>
        ///排量
        ///</summary>
        public Decimal Displacement { get; set; }

        ///<summary>
        ///车架号
        ///</summary>
        public string FrameNumber { get; set; }

        ///<summary>
        ///发动机号
        ///</summary>
        public string EngineNumber { get; set; }

        ///<summary>
        ///车身颜色
        ///</summary>
        public string BodyColor { get; set; }

        ///<summary>
        ///内饰颜色
        ///</summary>
        public string InteriorColor { get; set; }

        ///<summary>
        ///发票日期
        ///</summary>
        public DateTime? InvoiceDate { get; set; }

        ///<summary>
        ///购买车辆里程
        ///</summary>
        public int BuyMileage { get; set; }

        ///<summary>
        ///上牌日期
        ///</summary>
        public DateTime RegisterDate { get; set; }

        ///<summary>
        ///行驶里程
        ///</summary>
        public int Mileage { get; set; }

        ///<summary>
        ///保养周期（月）
        ///</summary>
        public int MaintenancePeriod { get; set; }

        ///<summary>
        ///保养间隔里程
        ///</summary>
        public int MaintenanceMileage { get; set; }

        ///<summary>
        ///下次保养日期
        ///</summary>
        public DateTime NextMaintenanceDate { get; set; }

        ///<summary>
        ///下次保养里程
        ///</summary>
        public int NextMaintenanceMileage { get; set; }

        ///<summary>
        ///质保年限
        ///</summary>
        public int GuaranteePeriod { get; set; }

        ///<summary>
        ///质保里程
        ///</summary>
        public int GuaranteeMileage { get; set; }

        ///<summary>
        ///实际质保日期
        ///</summary>
        public DateTime ActualGuaranteeDate { get; set; }

        ///<summary>
        ///实际质保里程
        ///</summary>
        public Enum.CustomerCharacter ActualGuaranteeMileage { get; set; }

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