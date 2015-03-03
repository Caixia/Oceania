using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Caching;
using System.Web;

namespace WebUI.Factory
{
    public class CacheManager
    {
        public static T GetObjFromCache<T>(string key) where T : class
        {

            if (HttpRuntime.Cache[key] != null)
                return HttpRuntime.Cache[key] as T;
            return null;
        }

        public static void SaveObjIntoCache(string key, object obj)
        {
            if (GetObjFromCache<object>(key) == null)
            {
                HttpRuntime.Cache.Insert(key, obj);
            }
        }
    }
}
