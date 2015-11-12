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
using CarManage.Interface.DataAccess.Solicit;
using CarManage.Model.Solicit;
using CarManage.Model.Enum;

namespace CarManage.Business.Solicit
{
    ///<summary>
    ///<summary>招揽信息业务对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-11-12</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class Solicit
    {
        private static CarManage.Interface.DataAccess.Solicit.ISolicit solicit = 
            DataAccessFactory.CreateInstance<ISolicit>();

        /// <summary>
        /// 新增招揽信息
        /// </summary>
        /// <param name="solicitInfo">招揽信息</param>
        public void Add(SolicitInfo solicitInfo)
        {
            try
            {
                solicit.Add(solicitInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("新增招揽信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新招揽信息
        /// </summary>
        /// <param name="solicitInfo">招揽信息信息对象</param>
        public void Update(SolicitInfo solicitInfo)
        {
            try
            {
                solicit.Update(solicitInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("更新招揽信息失败！", ex);
            }
        }

        /// <summary>
        /// 删除招揽信息
        /// </summary>
        /// <param name="id">招揽信息Id</param>
        public void Delete(string id)
        {
            try
            {
                solicit.Delete(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("删除招揽信息失败！", ex);
            }
        }

        /// <summary>
        /// 获取招揽信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回招揽信息对象，如果无匹配则返回null。</returns>
        public SolicitInfo Load(string id)
        {
            SolicitInfo solicitInfo = null;

            try
            {
                solicitInfo = solicit.Load(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取招揽信息失败！", ex);
            }

            return solicitInfo;
        }

        /// <summary>
        /// 查询招揽信息
        /// </summary>
        /// <returns>招揽信息集合</returns>
        public List<SolicitInfo> Search(SolicitInfo queryInfo)
        {
            List<SolicitInfo> solicitList = new List<SolicitInfo>();

            try
            {
                solicitList = solicit.Search(queryInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("查询招揽信息失败！", ex);
            }

            return solicitList;
        }
    }
}