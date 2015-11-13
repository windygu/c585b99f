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

using CarManage.Model.Common;

namespace CarManage.Interface.DataAccess.Common
{
    ///<summary>
    ///<summary>基础代码信息数据访问接口对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-14</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public interface ICodeBook
    {
        /// <summary>
        /// 新增基础代码信息
        /// </summary>
        /// <param name="codeBookInfo">基础代码信息</param>
        void Add(CodeBookInfo codeBookInfo);

        /// <summary>
        /// 更新基础代码信息
        /// </summary>
        /// <param name="codeBookInfo">基础代码信息信息对象</param>
        void Update(CodeBookInfo codeBookInfo);

        /// <summary>
        /// 删除基础代码信息
        /// </summary>
        /// <param name="id">基础代码信息Id</param>
        void Delete(int id);

        /// <summary>
        /// 获取基础代码信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回基础代码信息对象，如果无匹配则返回null。</returns>
        CodeBookInfo Load(int id);

        /// <summary>
        /// 查询基础代码信息
        /// </summary>
        /// <returns>基础代码信息集合</returns>
        List<CodeBookInfo> Search(CodeBookInfo queryInfo);

        /// <summary>
        /// 获取基础代码信息对象集合
        /// </summary>
        /// <param name="type">代码分类</param>
        /// <returns>返回基础代码信息对象集合</returns>
        List<CodeBookInfo> GetCodes(string type);
    }
}