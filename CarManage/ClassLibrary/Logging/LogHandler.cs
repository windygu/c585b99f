using System;

using ClassLibrary.Configuration;

namespace ClassLibrary.Logging
{
    public class LogHandler
    {
        private static ClassLibrary.Logging.ILog log = ClassLibrary.Logging.LogFactory.CreateLog(CarManageConfig.Instance.LoggingProvider);

        public static void Debug(object message)
        {
            throw new NotImplementedException();
        }

        public static void Debug(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public static void Info(object message)
        {
            throw new NotImplementedException();
        }

        public static void Info(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public static void Warn(object message)
        {
            throw new NotImplementedException();
        }

        public static void Warn(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public static void Error(object message)
        {
            log.Error(message);
        }

        public static void Error(object message, Exception exception)
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
