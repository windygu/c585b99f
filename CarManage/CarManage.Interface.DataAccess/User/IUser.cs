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

using CarManage.Model.User;

namespace CarManage.Interface.DataAccess.User
{
    ///<summary>
    ///<summary>用户信息数据访问接口对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-13</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public interface IUser
    {
        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="userInfo">用户信息</param>
        void Add(UserInfo userInfo);

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userInfo">用户信息信息对象</param>
        void Update(UserInfo userInfo);

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="id">用户信息Id</param>
        void Delete(string id);

        /// <summary>
        /// 获取用户信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回用户信息对象，如果无匹配则返回null。</returns>
        UserInfo Load(string id);

        /// <summary>
        /// 获取用户信息对象
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>返回用户信息对象，如果无匹配则返回null。</returns>
        UserInfo LoadByUserName(string userName);

        /// <summary>
        /// 用户是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>返回一个布尔值，true表示存在，false不存在。</returns>
        bool Exists(string userName);

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <returns>用户信息集合</returns>
        List<UserInfo> Search(UserInfo queryInfo);
    }
}