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
    ///<summary>客户信息数据访问对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-10</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Customer : DataAccessBase, ICustomer
    {
        /// <summary>
        /// 新增客户信息
        /// </summary>
        /// <param name="customerInfo">客户信息对象</param>
        public void Add(CustomerInfo customerInfo)
        {
            string commandText = "INSERT INTO Customer(Id,Owner,OwnerAddress,UserName,Sex,Alias,Tel,Mobile,"
                + "UserAddress,Email,WeChat,FreeTime,PreferSupport,PreferSale,PreferDrink,Character,SaleType,"
                + "CreateDate,UpdateDate,Creator,Operator,Valid)VALUES(@Id,@Owner,@OwnerAddress,@UserName,"
                + "@Sex,@Alias,@Tel,@Mobile,@UserAddress,@Email,@WeChat,@FreeTime,@PreferSupport,@PreferSale,"
                + "@PreferDrink,@Character,@SaleType,@CreateDate,@UpdateDate,@Creator,@Operator,@Valid)";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: customerInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("新增客户信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新客户信息
        /// </summary>
        /// <param name="customerInfo">客户信息对象</param>
        public void Update(CustomerInfo customerInfo)
        {
            string commandText = "UPDATE Customer SET " 
                + "Owner=@Owner,OwnerAddress=@OwnerAddress,UserName=@UserName,Sex=@Sex,Alias=@Alias,Tel=@Tel,"
                + "Mobile=@Mobile,UserAddress=@UserAddress,Email=@Email,WeChat=@WeChat,FreeTime=@FreeTime,"
                + "PreferSupport=@PreferSupport,PreferSale=@PreferSale,PreferDrink=@PreferDrink,Character=@Character,"
                + "SaleType=@SaleType,CreateDate=@CreateDate,UpdateDate=@UpdateDate,Creator=@Creator,Operator=@Operator,"
                + "Valid=@Valid  WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: customerInfo);
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("更新客户信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键删除指定客户信息数据
        /// </summary>
        /// <param name="id">客户信息Id</param>
        public void Delete(string id)
        {
            string commandText = "DELETE FROM Customer WHERE Id=@Id";

            try
            {
                base.Execute(commandText, connectionString: CarManageConfig.Instance.ConnectionString, 
                    param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException("删除客户信息失败！", ex);
            }
        }

        /// <summary>
        /// 根据主键获取客户信息实体数据
        /// </summary>
        /// <param name="recordId">主键</param>
        /// <returns>返回产品实体类。如果没有符合条件的数据则返回null。</returns>
        public CustomerInfo Load(string id)
        {
            CustomerInfo customerInfo = null;
            IDbConnection connection = null;
            string commandText = "SELECT * FROM Customer WHERE Id=@Id";

            try
            {
                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);
                customerInfo = base.Load<CustomerInfo>(commandText, connection, param: new { Id = id });
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "读取客户信息详细信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return customerInfo;
        }


        /// <summary>
        /// 获得所有客户信息集合
        /// </summary>
        /// <returns>客户信息集合</returns>
        public List<CustomerInfo> Search(CustomerInfo queryInfo)
        {
            IDbConnection connection = null;
            List<CustomerInfo> customerList = new List<CustomerInfo>();

            try
            {
                string field = "*";

                string table = "Customer";
                string order = "ORDER BY Id";

                StringBuilder filter = new StringBuilder();

                #region 查询条件


                #endregion

                string filterText = string.Empty;

                if (filter.Length > 0)
                {
                    filterText = filter.ToString().TrimStart(' ').Remove(0, 3).Insert(0, " WHERE ");
                }

                string commandText = string.Format("SELECT COUNT(*) FROM Customer {0}", filterText);

                connection = base.CreateConnection(CarManageConfig.Instance.ConnectionString);

                queryInfo.TotalCount = base.ExecuteObject<int>(commandText: commandText,
                    connection: connection, param: queryInfo);

                if (queryInfo.TotalCount.Equals(0))
                    return customerList;

                int pageCount = queryInfo.TotalCount / queryInfo.PageSize + 1;

                if (queryInfo.TotalCount % queryInfo.PageSize != 0)
                    pageCount++;

                int startIndex = queryInfo.PageIndex * queryInfo.PageSize;

                commandText = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3} LIMIT {4},{5}",
                    field, table, filterText, order, startIndex, queryInfo.PageSize);

                customerList = base.Query<CustomerInfo>(commandText, connection, param: startIndex).ToList();
            }
            catch (Exception ex)
            {
                DataAccessExceptionHandler.HandlerException(
                    "查询客户信息失败！", ex);
            }
            finally
            {
                CloseConnection(connection);
            }

            return customerList;
        }
    }
}