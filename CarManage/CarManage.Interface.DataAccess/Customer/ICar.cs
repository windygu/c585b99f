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

using CarManage.Model.Customer;

namespace CarManage.Interface.DataAccess.Customer
{
    ///<summary>
	///<summary>车辆信息数据访问接口对象</summary>
	///<creator>王旭</creator>
	///<createdate>2015-11-09</createdate>
	///<modifier></modifier>
	///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
	///</summary>
     public interface ICar
     {
        /// <summary>
        /// 新增车辆信息
        /// </summary>
        /// <param name="carInfo">车辆信息</param>
        void Add(CarInfo carInfo);
        
        /// <summary>
        /// 更新车辆信息
        /// </summary>
        /// <param name="carInfo">车辆信息信息对象</param>
        void Update(CarInfo carInfo);
        
        /// <summary>
        /// 删除车辆信息
        /// </summary>
        /// <param name="id">车辆信息Id</param>
        void Delete(string id);
        
        /// <summary>
        /// 获取车辆信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回车辆信息对象，如果无匹配则返回null。</returns>
        CarInfo Load(string id);
        
        /// <summary>
        /// 查询车辆信息
        /// </summary>
        /// <returns>车辆信息集合</returns>
        List<CarInfo> Search(CarInfo queryInfo);
     }
}