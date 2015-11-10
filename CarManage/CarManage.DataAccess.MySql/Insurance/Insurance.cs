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
using CarManage.Interface.DataAccess.Insurance;
using CarManage.Model.Insurance;
using CarManage.DataAccess.MySql;

namespace CarManage.DataAccess.DataAccess.MySql.Insurance
{
    ///<summary>
    ///<summary>保险信息数据访问对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-10</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Insurance : DataAccessBase, IInsurance
    {
        /// <summary>
        /// 新增保险信息
        /// </summary>
        /// <param name="insuranceInfo">保险信息对象</param>
        public void Add(InsuranceInfo insuranceInfo)
        {
            IDbTransaction transaction = base.BeginTransaction(CarManageConfig.Instance.ConnectionString);

            string commandText = @"INSERT INTO Insurance(Id,CarNumber,FrameNumber,EngineNumber,Insurant,"
                + "InsurantPhone,InsurantId,InsuranceCompany,Amount,Local,InsuranceDate,NextInsuranceDate,"
                + "RemindDate,CreateDate,UpdateDate,Creator,Operator,Valid)VALUES(@Id,@CarNumber,@FrameNumber,"
                + "@EngineNumber,@Insurant,@InsurantPhone,@InsurantId,@InsuranceCompany,@Amount,@Local,"
                + "@InsuranceDate,@NextInsuranceDate,@RemindDate,@CreateDate,@UpdateDate,@Creator,@Operator,@Valid)";

            try
            {
                base.Execute(commandText, transaction:transaction, param: insuranceInfo);

                commandText = "INSERT INTO InsuranceItem(Id,InsuranceId,ItemCode,Amount)VALUES(@Id,@InsuranceId,@ItemCode,@Amount)";

                base.Execute(commandText, transaction: transaction, param: insuranceInfo.Items);

                base.Commit(transaction);
            }
            catch (Exception ex)
            {
                base.Rollback(transaction);
                DataAccessExceptionHandler.HandlerException("新增保险信息失败！", ex);
            }
            finally
            {
                CloseConnection(transaction.Connection);
            }
        }

        /// <summary>
        /// 更新保险信息
        /// </summary>
        /// <param name="insuranceInfo">保险信息对象</param>
        public void Update(InsuranceInfo insuranceInfo)
        {
            IDbTransaction transaction = base.BeginTransaction(CarManageConfig.Instance.ConnectionString);

            string commandText = "UPDATE Insurance SET "
                + "CarNumber=@CarNumber,FrameNumber=@FrameNumber,EngineNumber=@EngineNumber,Insurant=@Insurant,"
                + "InsurantPhone=@InsurantPhone,InsurantId=@InsurantId,InsuranceCompany=@InsuranceCompany,"
                + "Amount=@Amount,Local=@Local,InsuranceDate=@InsuranceDate,NextInsuranceDate=@NextInsuranceDate,"
                + "RemindDate=@RemindDate,CreateDate=@CreateDate,UpdateDate=@UpdateDate,Creator=@Creator,"
                + "Operator=@Operator,Valid=@Valid WHERE Id=@Id";

            try
            {
                base.Execute(commandText, transaction: transaction, param: insuranceInfo);

                commandText = "DELETE FROM InsuranceItem WHERE InsuranceId=@InsuranceId";

                base.Execute(commandText, transaction: transaction, param: new { InsuranceId = insuranceInfo.Id });

                commandText = "INSERT INTO InsuranceItem(Id,InsuranceId,ItemCode,Amount)VALUES(@Id,@InsuranceId,@ItemCode,@Amount)";

                base.Execute(commandText, transaction: transaction, param: insuranceInfo.Items);

                base.Commit(transaction);
            }
            catch (Exception ex)
            {
                base.Rollback(transaction);
                DataAccessExceptionHandler.HandlerException("更新保险信息失败！", ex);
            }
            finally
            {
                CloseConnection(transaction.Connection);
            }
        }

        /// <summary>
        /// 根据主键删除指定保险信息数据
        /// </summary>
        /// <param name="id">保险信息Id</param>
        public void Delete(string id)
        {
            IDbTransaction transaction = base.BeginTransaction(CarManageConfig.Instance.ConnectionString);

            string commandText = "DELETE FROM Insurance WHERE Id=@Id";

            try
            {
                base.Execute(commandText, transaction:transaction, param: new { Id = id });

                commandText = "DELETE FROM InsuranceItem WHERE InsuranceId=@InsuranceId";

                base.Execute(commandText, transaction: transaction, param: new { InsuranceId = id });

                base.Commit(transaction);
            }
            catch (Exception ex)
            {
                base.Rollback(transaction);
                DataAccessExceptionHandler.HandlerException("删除保险信息失败！", ex);
            }
            finally
            {
                CloseConnection(transaction.Connection);
            }
        }

        /// <summary>
        /// 根据主键获取保险信息实体数据
        /// </summary>
        /// <param name="recordId">主键</param>
        /// <returns>返回产品实体类。如果没有符合条件的数据则返回null。</returns>
        public InsuranceInfo Load(string id)
        {
            InsuranceInfo insuranceInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM Insurance WHERE Id=@Id";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                insuranceInfo = base.Load<InsuranceInfo>(commandText, connection, param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取保险信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return insuranceInfo;
        }


        /// <summary>
        /// 获得所有保险信息集合
        /// </summary>
        /// <returns>保险信息集合</returns>
        public List<InsuranceInfo> Search(InsuranceInfo queryInfo)
        {
            List<InsuranceInfo> insuranceList = new List<InsuranceInfo>();

            try
            {
                string field = "*";

                string table = "Insurance";
                string order = "ORDER BY Id";

                StringBuilder filter = new StringBuilder();

                #region 查询条件


                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM Insurance {0}", filterText);

                IDbConnection connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText, connection: connection, param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return insuranceList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                insuranceList = base.Query<InsuranceInfo>(commandText, connection, param: startIndex).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询保险信息失败！", ex);
            }

            return insuranceList;
        }
    }
}