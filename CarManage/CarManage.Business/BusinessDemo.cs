using System;

using ClassLibrary.ExceptionHandling;
using ClassLibrary.WorkingProcess;
using ClassLibrary.Event;

namespace CarManage.Business
{
    public class BusinessDemo:WorkProcessManager
    {
        public BusinessDemo()
        {
            //base.RegisterEvent(this.OnTest);
        }

        private object OnTestKey = new object();

        /// <summary>
        /// 工作开始事件
        /// </summary>
        public event EventHandler<WorkProcessingEventArgs> OnTest
        {
            add { base.RegisterEvent(OnTestKey, value); }
            remove { base.RemoveEvent(OnTestKey,value);}
        }

        public void Test(int reportCount)
        {
            try
            {
                for (int i = 0; i < reportCount; i++)
                {
                    //DO somthing....

                    //PostReportWorkStatus("当前进度：", i);
                    WorkProcessingEventArgs e = new WorkProcessingEventArgs(i.ToString(), reportCount, 
                        i, base.ProcessTime, base.UserState);

                    e.Data = DateTime.Now;
                    base.InvokeEvent<WorkProcessingEventArgs>(this.OnTestKey, e);
                    //OnTest(this, e);
                    System.Threading.Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                BusinessExceptionHandler.HandlerException("Test error!", ex);
            }
        }
    }
}
