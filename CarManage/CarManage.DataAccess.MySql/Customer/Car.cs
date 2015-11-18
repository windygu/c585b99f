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
using System.Data.Common;
using System.Data;
using System.Text;
using System.Linq;

using ClassLibrary.ExceptionHandling;
using ClassLibrary.Utility.Common;
using CarManage.Configuration;
using CarManage.Interface.DataAccess.Customer;
using CarManage.Model.Customer;
using CarManage.DataAccess.MySql;

namespace CarManage.DataAccess.MySql.Customer
{
    ///<summary>
    ///<summary>车辆信息数据访问对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-09</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Car : DataAccessBase, ICar
    {
        /// <summary>
        /// 新增车辆信息
        /// </summary>
        /// <param name="carInfo">车辆信息对象</param>
        public void Add(CarInfo carInfo)
        {
            string commandText = "INSERT INTO Car(Id,CustomerId,Number,Brand,Model,Displacement,"
                + "FrameNumber,EngineNumber,BodyColor,InteriorColor,InvoiceDate,BuyMileage,"
                + "RegisterDate,Mileage,MaintenancePeriod,MaintenanceMileage,NextMaintenanceDate,"
                + "NextMaintenanceMileage,GuaranteePeriod,GuaranteeMileage,ActualGuaranteeDate,"
                + "ActualGuaranteeMileage,CreateDate,UpdateDate,Creator,Operator,Valid)"
                + " VALUES(@Id,@CustomerId,@Number,@Brand,@Model,@Displacement,@FrameNumber,"
                + "@EngineNumber,@BodyColor,@InteriorColor,@InvoiceDate,@BuyMileage,@RegisterDate,"
                + "@Mileage,@MaintenancePeriod,@MaintenanceMileage,@NextMaintenanceDate,"
                + "@NextMaintenanceMileage,@GuaranteePeriod,@GuaranteeMileage,@ActualGuaranteeDate,"
                + "@ActualGuaranteeMileage,@CreateDate,@UpdateDate,@Creator,@Operator,@Valid)"; 

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: carInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("新增车辆信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新车辆信息
        /// </summary>
        /// <param name="carInfo">车辆信息对象</param>
        public void Update(CarInfo carInfo)
        {
            string commandText = "UPDATE Car SET " +
                "CustomerId=@CustomerId,Number=@Number,Brand=@Brand,Model=@Model,Displacement=@Displacement,"
                + "FrameNumber=@FrameNumber,EngineNumber=@EngineNumber,BodyColor=@BodyColor,"
                + "InteriorColor=@InteriorColor,InvoiceDate=@InvoiceDate,BuyMileage=@BuyMileage,"
                + "RegisterDate=@RegisterDate,Mileage=@Mileage,MaintenancePeriod=@MaintenancePeriod,"
                + "MaintenanceMileage=@MaintenanceMileage,NextMaintenanceDate=@NextMaintenanceDate,"
                + "NextMaintenanceMileage=@NextMaintenanceMileage,GuaranteePeriod=@GuaranteePeriod,"
                + "GuaranteeMileage=@GuaranteeMileage,ActualGuaranteeDate=@ActualGuaranteeDate,"
                + "ActualGuaranteeMileage=@ActualGuaranteeMileage,CreateDate=@CreateDate,"
                + "UpdateDate=@UpdateDate,Creator=@Creator,Operator=@Operator,Valid=@Valid "
                + "WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: carInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("更新车辆信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键删除指定车辆信息数据
        /// </summary>
        /// <param name="id">车辆信息Id</param>
        public void Delete(string id)
        {
            string commandText = "DELETE FROM Car WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("删除车辆信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键获取车辆信息实体数据
        /// </summary>
        /// <param name="recordId">主键</param>
        /// <returns>返回产品实体类。如果没有符合条件的数据则返回null。</returns>
        public CarInfo Load(string id)
        {
            CarInfo carInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM Car WHERE Id=@Id";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                carInfo = base.Load<CarInfo>(commandText, connection, param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取车辆信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return carInfo;
        }

        /// <summary>
        /// 获取车辆信息对象集合
        /// </summary>
        /// <param name="customerId">客户主键</param>
        /// <returns>返回车辆信息对象集合</returns>
        public List<CarInfo> GetCars(string customerId)
        {
            List<CarInfo> carList = new List<CarInfo>();
            IDbConnection connection = null;

            try
            {
                string commandText = "SELECT * FROM Car WHERE CustomerId=@CustomerId AND Valid=1 ORDER BY CreateDate";
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                carList = base.Query<CarInfo>(commandText, connection: connection, 
                    param: new { CustomerId = customerId }).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询车辆信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return carList;
        }


        /// <summary>
        /// 获得所有车辆信息集合
        /// </summary>
        /// <returns>车辆信息集合</returns>
        public List<CarInfo> Search(CarInfo queryInfo)
        {
            IDbConnection connection = null;
            List<CarInfo> carList = new List<CarInfo>();
            
            try
            {
                string field = "*";

                string table = "Car";
                string order = "ORDER BY Id";

                StringBuilder filter = new StringBuilder();

                #region 查询条件


                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM Car {0}", filterText);

                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText, 
                    connection: connection, param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return carList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                carList = base.Query<CarInfo>(commandText, connection, param: queryInfo).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询车辆信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return carList;
        }
    }
}
