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

using ClassLibrary.ExceptionHandling;
using ClassLibrary.Utility.Common;
using CarManage.Factory.DataAccess;
using CarManage.Interface.DataAccess.Common;
using CarManage.Model.Common;
using CarManage.Model.Enum;

namespace CarManage.Business.Common
{
    ///<summary>
    ///<summary>基础代码信息业务对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-14</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class CodeBook
    {
        private static CarManage.Interface.DataAccess.Common.ICodeBook codeBook = 
            DataAccessFactory.CreateInstance<ICodeBook>();

        /// <summary>
        /// 新增基础代码信息
        /// </summary>
        /// <param name="codeBookInfo">基础代码信息</param>
        public void Add(CodeBookInfo codeBookInfo)
        {
            try
            {
                codeBook.Add(codeBookInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("新增基础代码信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新基础代码信息
        /// </summary>
        /// <param name="codeBookInfo">基础代码信息信息对象</param>
        public void Update(CodeBookInfo codeBookInfo)
        {
            try
            {
                codeBook.Update(codeBookInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("更新基础代码信息失败！", ex);
            }
        }

        /// <summary>
        /// 删除基础代码信息
        /// </summary>
        /// <param name="id">基础代码信息Id</param>
        public void Delete(int id)
        {
            try
            {
                codeBook.Delete(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("删除基础代码信息失败！", ex);
            }
        }

        /// <summary>
        /// 获取基础代码信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回基础代码信息对象，如果无匹配则返回null。</returns>
        public CodeBookInfo Load(int id)
        {
            CodeBookInfo codeBookInfo = null;

            try
            {
                codeBookInfo = codeBook.Load(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取基础代码信息失败！", ex);
            }

            return codeBookInfo;
        }

        /// <summary>
        /// 查询基础代码信息
        /// </summary>
        /// <returns>基础代码信息集合</returns>
        public List<CodeBookInfo> Search(CodeBookInfo queryInfo)
        {
            List<CodeBookInfo> codeBookList = new List<CodeBookInfo>();

            try
            {
                codeBookList = codeBook.Search(queryInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("查询基础代码信息失败！", ex);
            }

            return codeBookList;
        }

        /// <summary>
        /// 获取基础代码信息对象集合
        /// </summary>
        /// <param name="type">代码分类</param>
        /// <returns>返回基础代码信息对象集合</returns>
        public List<CodeBookInfo> GetCodes(string type)
        {
            List<CodeBookInfo> codeList = new List<CodeBookInfo>();

            try
            {
                codeList = codeBook.GetCodes(type);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取基础代码信息失败！", ex);
            }

            return codeList;
        }
    }
}