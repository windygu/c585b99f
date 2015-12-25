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
using CarManage.Interface.DataAccess.Solicit;
using CarManage.Model.Solicit;
using CarManage.DataAccess.MySql;

namespace CarManage.DataAccess.MySql.Solicit
{
    ///<summary>
    ///<summary>招揽信息数据访问对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-12</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Solicit : DataAccessBase, ISolicit
    {
        /// <summary>
        /// 新增招揽信息
        /// </summary>
        /// <param name="solicitInfo">招揽信息对象</param>
        public void Add(SolicitInfo solicitInfo)
        {
            string commandText = "INSERT INTO Solicit(Id,BizId,CustomerId,CarId,ActivityCode,EstimateDate,"
                + "Content,Feedback,Solicitor,SolicitDate,Result,Status,CreateDate,Creator,UpdateDate,Updater,"
                + "Valid) VALUES(@Id,@BizId,@CustomerId,@CarId,@ActivityCode,@EstimateDate,@Content,@Feedback,"
                + "@Solicitor,@SolicitDate,@Result,@Status,@CreateDate,@Creator,@UpdateDate,@Updater,@Valid)";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: solicitInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("新增招揽信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新招揽信息
        /// </summary>
        /// <param name="solicitInfo">招揽信息对象</param>
        public void Update(SolicitInfo solicitInfo)
        {
            string commandText = "UPDATE Solicit SET "
                + "BizId=@BizId,CustomerId=@CustomerId,CarId=@CarId,ActivityCode=@ActivityCode,EstimateDate=@EstimateDate,"
                + "Content=@Content,Feedback=@Feedback,Solicitor=@Solicitor,SolicitDate=@SolicitDate,Result=@Result,"
                + "Status=@Status,CreateDate=@CreateDate,Creator=@Creator,UpdateDate=@UpdateDate,Updater=@Updater,"
                + "Valid=@Valid WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: solicitInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("更新招揽信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键删除指定招揽信息数据
        /// </summary>
        /// <param name="id">招揽信息Id</param>
        public void Delete(string id)
        {
            string commandText = "DELETE FROM Solicit WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("删除招揽信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键获取招揽信息实体数据
        /// </summary>
        /// <param name="recordId">主键</param>
        /// <returns>返回产品实体类。如果没有符合条件的数据则返回null。</returns>
        public SolicitInfo Load(string id)
        {
            SolicitInfo solicitInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM Solicit WHERE Id=@Id";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                solicitInfo = base.Load<SolicitInfo>(commandText, connection, param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取招揽信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return solicitInfo;
        }


        /// <summary>
        /// 获得所有招揽信息集合
        /// </summary>
        /// <returns>招揽信息集合</returns>
        public List<SolicitInfo> Search(SolicitInfo queryInfo)
        {
            IDbConnection connection = null;

            List<SolicitInfo> solicitList = new List<SolicitInfo>();

            try
            {
                string field = "*";

                string table = "Solicit";
                string order = "ORDER BY Id";

                StringBuilder filter = new StringBuilder();

                #region 查询条件


                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM Solicit {0}", filterText);

                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText, 
                    connection: connection, param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return solicitList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                solicitList = base.Query<SolicitInfo>(commandText, connection, param: queryInfo).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询招揽信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return solicitList;
        }

        /// <summary>
        /// 获得所有招揽信息集合
        /// </summary>
        /// <returns>招揽信息集合</returns>
        public List<SolicitListInfo> Search(SolicitQueryInfo queryInfo)
        {
            IDbConnection connection = null;

            List<SolicitListInfo> solicitList = new List<SolicitListInfo>();

            try
            {
                string field = "c.Number, c.Model, b.Owner, a.ActivityCode, a.Content, a.EstimateDate, b.FreeTime, a.Status";

                string table = "Solicit a, Customer b, Car c";
                string order = "ORDER BY a.EstimateDate, c.Number";

                StringBuilder filter = new StringBuilder();

                #region 查询条件

                if (!string.IsNullOrWhiteSpace(queryInfo.Number))
                    filter.Append("and c.Number like '%'+@Number+'%' ");

                if (!string.IsNullOrWhiteSpace(queryInfo.Owner))
                    filter.Append("and b.Owner like '%'+@Owner+'%' ");

                if (!string.IsNullOrWhiteSpace(queryInfo.Mobile))
                    filter.Append("and b.Mobile like '%'+@Mobile+'%' ");

                if (!string.IsNullOrWhiteSpace(queryInfo.Solicitor))
                    filter.Append("and a.Solicitor=@Solicitor ");

                if (!string.IsNullOrWhiteSpace(queryInfo.ActivityCode))
                    filter.Append("and a.ActivityCode=@ActivityCode ");

                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM {0} {1}", table, filterText);

                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText,
                    connection: connection, param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return solicitList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                solicitList = base.Query<SolicitListInfo>(commandText, connection, param: queryInfo).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询招揽信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return solicitList;
        }
    }
}