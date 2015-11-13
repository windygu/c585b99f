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
using CarManage.Interface.DataAccess.Common;
using CarManage.Model.Common;
using CarManage.DataAccess.MySql;

namespace CarManage.DataAccess.MySql.Common
{
    ///<summary>
    ///<summary>基础代码信息数据访问对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-14</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class CodeBook : DataAccessBase, ICodeBook
    {
        /// <summary>
        /// 新增基础代码信息
        /// </summary>
        /// <param name="codeBookInfo">基础代码信息对象</param>
        public void Add(CodeBookInfo codeBookInfo)
        {
            string commandText = "INSERT INTO CodeBook(Id,Type,Code,Name,Remark,SortOrder,Valid)" 
                + " VALUES(@Id,@Type,@Code,@Name,@Remark,@SortOrder,@Valid)";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: codeBookInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("新增基础代码信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新基础代码信息
        /// </summary>
        /// <param name="codeBookInfo">基础代码信息对象</param>
        public void Update(CodeBookInfo codeBookInfo)
        {
            string commandText = "UPDATE CodeBook SET "
                + "Type=@Type,Code=@Code,Name=@Name,Remark=@Remark,SortOrder=@SortOrder,Valid=@Valid " 
                + "WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: codeBookInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("更新基础代码信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键删除指定基础代码信息数据
        /// </summary>
        /// <param name="id">基础代码信息Id</param>
        public void Delete(int id)
        {
            string commandText = "UPDATE CodeBook SET Valid=0 WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("删除基础代码信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键获取基础代码信息实体数据
        /// </summary>
        /// <param name="recordId">主键</param>
        /// <returns>返回产品实体类。如果没有符合条件的数据则返回null。</returns>
        public CodeBookInfo Load(int id)
        {
            CodeBookInfo codeBookInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM CodeBook WHERE Id=@Id";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                codeBookInfo = base.Load<CodeBookInfo>(commandText, connection, param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取基础代码信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return codeBookInfo;
        }


        /// <summary>
        /// 获得所有基础代码信息集合
        /// </summary>
        /// <returns>基础代码信息集合</returns>
        public List<CodeBookInfo> Search(CodeBookInfo queryInfo)
        {
            IDbConnection connection = null;

            List<CodeBookInfo> codeList = new List<CodeBookInfo>();

            try
            {
                string field = "*";

                string table = "CodeBook";
                string order = "ORDER BY Id";

                StringBuilder filter = new StringBuilder();

                #region 查询条件


                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM CodeBook {0}", filterText);

                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText, 
                    connection: connection, param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return codeList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                codeList = base.Query<CodeBookInfo>(commandText, connection, param: queryInfo).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询基础代码信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return codeList;
        }

        /// <summary>
        /// 获取基础代码信息对象集合
        /// </summary>
        /// <param name="type">代码分类</param>
        /// <returns>返回基础代码信息对象集合</returns>
        public List<CodeBookInfo> GetCodes(string type)
        {
            List<CodeBookInfo> codeList = new List<CodeBookInfo>();
            string commandText = "SELECT * FROM CodeBook WHERE Type=@Type AND Valid=1 ORDER BY SortOrder";
            IDbConnection connection = null;

            try
            {
                codeList = base.Query<CodeBookInfo>(commandText, connection, param: new { Type = type }).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("获取基础代码信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return codeList;
        }
    }
}