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
using CarManage.Interface.DataAccess.User;
using CarManage.Model.User;
using CarManage.DataAccess.MySql;

namespace CarManage.DataAccess.MySql.User
{
    ///<summary>
    ///<summary>用户信息数据访问对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-13</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class User : DataAccessBase, IUser
    {
        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="userInfo">用户信息对象</param>
        public void Add(UserInfo userInfo)
        {
            string commandText = "INSERT INTO User(Id,UserName,Password,EmployeeNumber,Tel,Mobile,Dept,"
                + "CreateDate,UpdateDate,Creator,Updator,Valid)VALUES(@Id,@UserName,@Password,@EmployeeNumber,"
                + "@Tel,@Mobile,@Dept,@CreateDate,@UpdateDate,@Creator,@Updator,@Valid)";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: userInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("新增用户信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userInfo">用户信息对象</param>
        public void Update(UserInfo userInfo)
        {
            string commandText = "UPDATE User SET "
                + "UserName=@UserName,Password=@Password,EmployeeNumber=@EmployeeNumber,Tel=@Tel,"
                + "Mobile=@Mobile,Dept=@Dept,CreateDate=@CreateDate,UpdateDate=@UpdateDate,Creator=@Creator,"
                + "Updator=@Updator,Valid=@Valid WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: userInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("更新用户信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键删除指定用户信息数据
        /// </summary>
        /// <param name="id">用户信息Id</param>
        public void Delete(string id)
        {
            string commandText = "DELETE FROM User WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("删除用户信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键获取用户信息实体数据
        /// </summary>
        /// <param name="recordId">主键</param>
        /// <returns>返回产品实体类。如果没有符合条件的数据则返回null。</returns>
        public UserInfo Load(string id)
        {
            UserInfo userInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM User WHERE Id=@Id";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                userInfo = base.Load<UserInfo>(commandText, connection, param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取用户信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return userInfo;
        }

        /// <summary>
        /// 获取用户信息对象
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>返回用户信息对象，如果无匹配则返回null。</returns>
        public UserInfo LoadByUserName(string userName)
        {
            UserInfo userInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM User WHERE UserName=@UserName";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                userInfo = base.Load<UserInfo>(commandText, connection, param: new { UserName = userName });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取用户信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return userInfo;
        }

        /// <summary>
        /// 用户是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>返回一个布尔值，true表示存在，false不存在。</returns>
        public bool Exists(string userName)
        {
            bool result = false;
            string commandText = "SELECT COUNT(1) FROM User WHERE UserName=@UserName";

            try
            {
                //connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                result = !base.ExecuteObject<int>(commandText, param: new { UserName = userName }).Equals(0);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "检查用户是否存在失败！", ex);
            }

            return result;
        }

        /// <summary>
        /// 获得所有用户信息集合
        /// </summary>
        /// <returns>用户信息集合</returns>
        public List<UserInfo> Search(UserInfo queryInfo)
        {
            IDbConnection connection = null;

            List<UserInfo> userList = new List<UserInfo>();

            try
            {
                string field = "*";

                string table = "User";
                string order = "ORDER BY Id";

                StringBuilder filter = new StringBuilder();

                #region 查询条件


                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM User {0}", filterText);

                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText, connection: connection, param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return userList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                userList = base.Query<UserInfo>(commandText, connection, param: queryInfo).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询用户信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return userList;
        }
    }
}