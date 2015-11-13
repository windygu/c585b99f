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

using CarManage.Model;

namespace CarManage.Model.User
{
    ///<summary>
    ///<summary>用户信息对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-13</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    [Serializable]
    public class UserInfo : BaseModel
    {
        #region 构造函数

        ///<summary>
        ///构造函数
        ///</summary>
        public UserInfo()
        {

        }

        #endregion

        #region 基础属性

        ///<summary>
        ///主键
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        ///用户名
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        ///密码
        ///</summary>
        public string Password { get; set; }

        ///<summary>
        ///工号
        ///</summary>
        public string EmployeeNumber { get; set; }

        ///<summary>
        ///座机
        ///</summary>
        public string Tel { get; set; }

        ///<summary>
        ///手机
        ///</summary>
        public string Mobile { get; set; }

        ///<summary>
        ///部门编码
        ///</summary>
        public string Dept { get; set; }

        ///<summary>
        ///创建日期
        ///</summary>
        public DateTime CreateDate { get; set; }

        ///<summary>
        ///更新日期
        ///</summary>
        public DateTime UpdateDate { get; set; }

        ///<summary>
        ///创建人
        ///</summary>
        public string Creator { get; set; }

        ///<summary>
        ///更新人
        ///</summary>
        public string Updator { get; set; }

        ///<summary>
        ///是否有效
        ///</summary>
        public bool Valid { get; set; }


        #endregion

        #region 扩展属性

        #endregion
    }
}