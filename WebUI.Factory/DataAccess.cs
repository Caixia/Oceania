using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace WebUI.Factory
{
    public sealed class DataAccess
    {
        public static T CreateInstence<T>(string classFullName)
           where T : class
        {
            T obj = default(T);
            obj = CacheManager.GetObjFromCache<T>(classFullName);
            if (obj == null)
            {
                obj = Assembly.Load("WebUI.DAL").CreateInstance(classFullName, true) as T;
                CacheManager.SaveObjIntoCache(classFullName, obj);
            }
            return obj;
        }
    }
}
