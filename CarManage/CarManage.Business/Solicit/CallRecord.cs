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
    ///<summary>通话录音信息业务对象</summary>
    ///<creator>王旭</creator>
    ///<createdate>2015-12-07</createdate>
    ///<modifier></modifier>
    ///<modifynote></modifynote>
    ///<modifydate></modifydate>
    ///<other></other>    
    ///</summary>
    public class CallRecord
    {
        private static CarManage.Interface.DataAccess.Solicit.ICallRecord callRecord = 
            DataAccessFactory.CreateInstance<ICallRecord>();

        /// <summary>
        /// 新增通话录音信息
        /// </summary>
        /// <param name="callRecordInfo">通话录音信息</param>
        public void Add(CallRecordInfo callRecordInfo)
        {
            try
            {
                callRecord.Add(callRecordInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("新增通话录音信息失败！", ex);
            }
        }

        /// <summary>
        /// 更新通话录音信息
        /// </summary>
        /// <param name="callRecordInfo">通话录音信息信息对象</param>
        public void Update(CallRecordInfo callRecordInfo)
        {
            try
            {
                callRecord.Update(callRecordInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("更新通话录音信息失败！", ex);
            }
        }

        /// <summary>
        /// 删除通话录音信息
        /// </summary>
        /// <param name="id">通话录音信息Id</param>
        public void Delete(string id)
        {
            try
            {
                callRecord.Delete(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("删除通话录音信息失败！", ex);
            }
        }

        /// <summary>
        /// 获取通话录音信息对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回通话录音信息对象，如果无匹配则返回null。</returns>
        public CallRecordInfo Load(string id)
        {
            CallRecordInfo callRecordInfo = null;

            try
            {
                callRecordInfo = callRecord.Load(id);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取通话录音信息失败！", ex);
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
            List<CallRecordInfo> callRecordList = new List<CallRecordInfo>();

            try
            {
                callRecordList = callRecord.GetRecordsByCustomerId(customerId);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("获取通话录音信息失败！", ex);
            }

            return callRecordList;
        }

        /// <summary>
        /// 查询通话录音信息
        /// </summary>
        /// <returns>通话录音信息集合</returns>
        public List<CallRecordInfo> Search(CallRecordInfo queryInfo)
        {
            List<CallRecordInfo> callRecordList = new List<CallRecordInfo>();

            try
            {
                callRecordList = callRecord.Search(queryInfo);
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("查询通话录音信息失败！", ex);
            }

            return callRecordList;
        }
    }
}