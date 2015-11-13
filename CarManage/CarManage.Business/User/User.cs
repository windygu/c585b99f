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
using System.Xml;

using ClassLibrary.ExceptionHandling;
using ClassLibrary.Utility.Common;
using ClassLibrary.Configuration;
using CarManage.Factory.DataAccess;
using CarManage.Interface.DataAccess.User;
using CarManage.Configuration;
using CarManage.Model.User;
using CarManage.Model.Enum;

namespace CarManage.Business.User
{
    ///<summary>
    ///<summary>用户信息业务对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-13</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class User
    {
        private static CarManage.Interface.DataAccess.User.IUser user = DataAccessFactory.CreateInstance<IUser>();

        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="userInfo">用户信息</param>
        public void Add(UserInfo userInfo)
        {
            try
            {
                user.Add(userInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("新增用户信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userInfo">用户信息信息对象</param>
        public void Update(UserInfo userInfo)
        {
            try
            {
                user.Update(userInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("更新用户信息失败！", ex);
            }
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="id">用户信息Id</param>
        public void Delete(string id)
        {
            try
            {
                user.Delete(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("删除用户信息失败！", ex);
            }
        }

        /// <summary>
        /// 获取用户信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回用户信息对象，如果无匹配则返回null。</returns>
        public UserInfo Load(string id)
        {
            UserInfo userInfo = null;

            try
            {
                userInfo = user.Load(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取用户信息失败！", ex);
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

            try
            {
                userInfo = user.LoadByUserName(userName);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException(
                    "读取用户信息详细信息失败！", ex);
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

            try
            {
                result = user.Exists(userName);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException(
                    "检查用户是否存在失败！", ex);
            }

            return result;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void SignIn(string userName, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(userName))
                    throw new BusinessCustomException("请输入用户名！");

                if (string.IsNullOrEmpty(password))
                    throw new BusinessCustomException("请输入密码！");

                UserInfo userInfo = user.LoadByUserName(userName);

                if (userInfo == null)
                    throw new BusinessCustomException("用户不存在！");

                if (!userInfo.Password.Equals(password))
                    throw new BusinessCustomException("密码错误！");
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException(
                    "登录失败！", ex);
            }
        }

        public List<UserInfo> GetRecentUsers()
        {
            List<UserInfo> userList = new List<UserInfo>();

            try
            {
                userList = CarManageConfig.Instance.RecentUsers;
            }
            catch
            { 
                
            }

            return userList;
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <returns>用户信息集合</returns>
        public List<UserInfo> Search(UserInfo queryInfo)
        {
            List<UserInfo> userList = new List<UserInfo>();

            try
            {
                userList = user.Search(queryInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("查询用户信息失败！", ex);
            }

            return userList;
        }
    }
}