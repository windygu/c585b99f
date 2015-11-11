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
using CarManage.Interface.DataAccess.Maintenance;
using CarManage.Model.Maintenance;
using CarManage.DataAccess.MySql;

namespace CarManage.DataAccess.MySql.Maintenance
{
    ///<summary>
    ///<summary>保养信息数据访问对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-11</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Maintenance : DataAccessBase, IMaintenance
    {
        /// <summary>
        /// 新增保养信息
        /// </summary>
        /// <param name="maintenanceInfo">保养信息对象</param>
        public void Add(MaintenanceInfo maintenanceInfo)
        {
            IDbTransaction transaction = null;

            string commandText = "INSERT INTO Maintenance(Id,CarId,Date,Mileage,Amount,LoseSales,"
                + "PrevDate,PrevMileage,NextDate,NextMileage,EstimateDate,EstimateMileage,Worker,"
                + "Type,Status,Creator,Operator,CreateDate,UpdateDate,ValidVALUES(@Id,@CarId,@Date,"
                + "@Mileage,@Amount,@LoseSales,@PrevDate,@PrevMileage,@NextDate,@NextMileage,"
                + "@EstimateDate,@EstimateMileage,@Worker,@Type,@Status,@Creator,@Operator,"
                + "@CreateDate,@UpdateDate,@Valid)";

            try
            {
                transaction = base.BeginTransaction(CarManageConfig.Instance.ConnectionString);
                base.Execute(commandText, transaction: transaction, param: maintenanceInfo);

                commandText = "INSERT INTO MaintenanceItem(Id,MaintenanceId,ItemCode,Canceled,Valid)"
                    + " VALUES(@Id,@MaintenanceId,@ItemCode,@Canceled,@Valid)";
                base.Execute(commandText, transaction: transaction, param: maintenanceInfo.Items);
                base.Commit(transaction);
            }
            catch (Exception ex)
            {
                Rollback(transaction);
                DataAccessExceptionHandler.HandlerException("新增保养信息失败！", ex);
            }
            finally
            {
                CloseConnection(transaction.Connection);
            }
        }

        /// <summary>
        /// 更新保养信息
        /// </summary>
        /// <param name="maintenanceInfo">保养信息对象</param>
        public void Update(MaintenanceInfo maintenanceInfo)
        {
            IDbTransaction transaction = null;

            string commandText = "UPDATE Maintenance SET "
                + "CarId=@CarId,Date=@Date,Mileage=@Mileage,Amount=@Amount,LoseSales=@LoseSales,"
                + "PrevDate=@PrevDate,PrevMileage=@PrevMileage,NextDate=@NextDate,NextMileage=@NextMileage,"
                + "EstimateDate=@EstimateDate,EstimateMileage=@EstimateMileage,Worker=@Worker,Type=@Type,"
                + "Status=@Status,Creator=@Creator,Operator=@Operator,CreateDate=@CreateDate,"
                + "UpdateDate=@UpdateDate,Valid=@Valid WHERE Id=@Id";

            try
            {
                transaction = base.BeginTransaction(CarManageConfig.Instance.ConnectionString);
                base.Execute(commandText, transaction: transaction, param: maintenanceInfo);

                commandText = "DELETE FROM MaintenanceItem WHERE MaintenanceId=@MaintenanceId";
                base.Execute(commandText, transaction: transaction, param: new { MaintenanceId = maintenanceInfo.Id });

                commandText = "INSERT INTO MaintenanceItem(Id,MaintenanceId,ItemCode,Canceled,Valid)"
                    + " VALUES(@Id,@MaintenanceId,@ItemCode,@Canceled,@Valid)";
                base.Execute(commandText, transaction: transaction, param: maintenanceInfo.Items);
                base.Commit(transaction);
            }
            catch (Exception ex)
            {
                Rollback(transaction);
                DataAccessExceptionHandler.HandlerException("更新保养信息失败！", ex);
            }
            finally
            {
                CloseConnection(transaction.Connection);
            }
        }

        /// <summary>
        /// 根据主键删除指定保养信息数据
        /// </summary>
        /// <param name="id">保养信息Id</param>
        public void Delete(string id)
        {
            IDbTransaction transaction = null;

            string commandText = "DELETE FROM Maintenance WHERE Id=@Id";

            try
            {
                transaction = base.BeginTransaction(CarManageConfig.Instance.ConnectionString);
                base.Execute(commandText, transaction: transaction, param: new { Id = id });

                commandText = "DELETE FROM MaintenanceItem WHERE MaintenanceId=@MaintenanceId";
                base.Execute(commandText, transaction: transaction, param: new { MaintenanceId = id });
                base.Commit(transaction);
            }
            catch (Exception ex)
            {
                Rollback(transaction);
                DataAccessExceptionHandler.HandlerException("删除保养信息失败！", ex);
            }
            finally
            {
                CloseConnection(transaction.Connection);
            }
        }

        /// <summary>
        /// 根据主键获取保养信息实体数据
        /// </summary>
        /// <param name="recordId">主键</param>
        /// <returns>返回产品实体类。如果没有符合条件的数据则返回null。</returns>
        public MaintenanceInfo Load(string id)
        {
            MaintenanceInfo maintenanceInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM Maintenance WHERE Id=@Id";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                maintenanceInfo = base.Load<MaintenanceInfo>(commandText, connection, param: new { Id = id });

                if (maintenanceInfo != null)
                {
                    commandText = "SELECT * FROM MaintenanceItem WHERE MaintenanceId=@MaintenanceId";
                    maintenanceInfo.Items = base.Query<MaintenanceItemInfo>(commandText, connection: connection,
                        param: new { MaintenanceId = id }).ToList();
                }
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取保养信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return maintenanceInfo;
        }


        /// <summary>
        /// 获得所有保养信息集合
        /// </summary>
        /// <returns>保养信息集合</returns>
        public List<MaintenanceInfo> Search(MaintenanceInfo queryInfo)
        {
            IDbConnection connection = null;

            List<MaintenanceInfo> maintenanceList = new List<MaintenanceInfo>();

            try
            {
                string field = "*";

                string table = "Maintenance";
                string order = "ORDER BY Id";

                StringBuilder filter = new StringBuilder();

                #region 查询条件


                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM Maintenance {0}", filterText);

                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText,
                    connection: connection, param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return maintenanceList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                maintenanceList = base.Query<MaintenanceInfo>(commandText, connection,
                    param: queryInfo).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询保养信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return maintenanceList;
        }
    }
}