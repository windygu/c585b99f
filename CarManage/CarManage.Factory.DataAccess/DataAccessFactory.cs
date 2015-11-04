using System;
using System.Reflection;

using CarManage.Configuration;

namespace CarManage.Factory.DataAccess
{
    public class DataAccessFactory
    {
        public static T CreateInstance<T>(T instance) where T:class
        {
            T result = null;

            try
            {
                Type type = typeof(T);
                string moduleName = type.Assembly.FullName.Split(',')[0];

                string provider = type.FullName.Replace(moduleName, CarManageConfig.Instance.DataAccessProvider);
                result = (T)Assembly.Load(CarManageConfig.Instance.DataAccessProvider).CreateInstance(provider);
            }
            catch
            {

            }

            return result;
        }
    }
}
