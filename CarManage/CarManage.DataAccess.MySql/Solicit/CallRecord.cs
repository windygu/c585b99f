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
    ///<summary>通话录音信息数据访问对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-12-07</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class CallRecord : DataAccessBase, ICallRecord
    {
        /// <summary>
        /// 新增通话录音信息
        /// </summary>
        /// <param name="callRecordInfo">通话录音信息对象</param>
        public void Add(CallRecordInfo callRecordInfo)
        {
            string commandText = "INSERT INTO CallRecord(Id,CustomerId,CarId,SolicitId,"
                + "CustomerName,CarNumber,Tel,Title,Feedback,Result,RecordPath,RecordMD5,"
                + "OperatorCode,OperatorName,CreateDate)VALUES(@Id,@CustomerId,@CarId,"
                + "@SolicitId,@CustomerName,@CarNumber,@Tel,@Title,@Feedback,@Result,"
                + "@RecordPath,@RecordMD5,@OperatorCode,@OperatorName,@CreateDate)";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: callRecordInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("新增通话录音信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新通话录音信息
        /// </summary>
        /// <param name="callRecordInfo">通话录音信息对象</param>
        public void Update(CallRecordInfo callRecordInfo)
        {
            string commandText = "UPDATE CallRecord SET "
                + "CustomerId=@CustomerId,CarId=@CarId,SolicitId=@SolicitId,CustomerName=@CustomerName,"
                + "CarNumber=@CarNumber,Tel=@Tel,Title=@Title,Feedback=@Feedback,Result=@Result,"
                + "RecordPath=@RecordPath,RecordMD5=@RecordMD5,OperatorCode=@OperatorCode,"
                + "OperatorName=@OperatorName,CreateDate=@CreateDate WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: callRecordInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("更新通话录音信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键删除指定通话录音信息数据
        /// </summary>
        /// <param name="id">通话录音信息Id</param>
        public void Delete(string id)
        {
            string commandText = "DELETE FROM CallRecord WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("删除通话录音信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键获取通话录音信息实体数据
        /// </summary>
        /// <param name="recordId">主键</param>
        /// <returns>返回产品实体类。如果没有符合条件的数据则返回null。</returns>
        public CallRecordInfo Load(string id)
        {
            CallRecordInfo callRecordInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM CallRecord WHERE Id=@Id";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                callRecordInfo = base.Load<CallRecordInfo>(commandText, connection, param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取通话录音信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return callRecordInfo;
        }

        /// <summary>
        /// 获取通话录音信息
        /// </summary>
        /// <param name="customerId">客户主键</param>
        /// <returns>返回通话录音信息对象集合。</returns>
        public List<CallRecordInfo> GetRecordsByCustomerId(string customerId)
        {
            IDbConnection connection = null;

            List<CallRecordInfo> callrecordList = new List<CallRecordInfo>();
            string commandText = "SELECT * FROM CallRecord WHERE CustomerId=@CustomerId ORDER BY CreateDate DESC,Title";
            
            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                callrecordList = base.Query<CallRecordInfo>(commandText, connection, 
                    param: new { CustomerId=customerId}).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "获取通话录音信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return callrecordList;
        }

        /// <summary>
        /// 获得所有通话录音信息集合
        /// </summary>
        /// <returns>通话录音信息集合</returns>
        public List<CallRecordInfo> Search(CallRecordInfo queryInfo)
        {
            IDbConnection connection = null;

            List<CallRecordInfo> callrecordList = new List<CallRecordInfo>();

            try
            {
                string field = "*";

                string table = "CallRecord";
                string order = "ORDER BY Id";

                StringBuilder filter = new StringBuilder();

                #region 查询条件


                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM CallRecord {0}", filterText);

                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText, connection: connection, 
                    param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return callrecordList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                callrecordList = base.Query<CallRecordInfo>(commandText, connection, param: queryInfo).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询通话录音信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return callrecordList;
        }
    }
}


