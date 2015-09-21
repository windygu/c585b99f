using System;


namespace ClassLibrary.Logging
{
    public class Log4NetHandler : ILog
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(ClassLibrary.Configuration.CarManageConfig.Instance.LoggingPolicy);

        static Log4NetHandler()
        {
            //log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
        }

        public void Debug(object message)
        {
            throw new NotImplementedException();
        }

        public void Debug(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(object message)
        {
            throw new NotImplementedException();
        }

        public void Info(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(object message)
        {
            log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            log.Error(message, exception);
        }

        public void Fatal(object message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
