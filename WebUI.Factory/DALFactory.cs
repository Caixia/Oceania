using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebUI.IDAL;
using System.Reflection;
using Common.Utility;

namespace WebUI.Factory
{
    public class DALFactory
    {
        string methodName = "";
        string className = "";
        private const string CONFIG_SECTION = "DALConfig";

        private string GetClassFullNameByMethodName(string methodName)
        {
            methodName = methodName.Substring(4);
            return ConfigurationUtil.GetConfigFromSection(CONFIG_SECTION, methodName);
        }

        /// <summary>
        /// 基类
        /// </summary>
        public IBaseDAL BaseDAL
        {
            get
            {
                IBaseDAL dal;
                methodName = MethodBase.GetCurrentMethod().Name;
                className = GetClassFullNameByMethodName(methodName);
                dal = DataAccess.CreateInstence<IBaseDAL>(className);
                return dal;

            }
        }

        public INavDAL NavDAL
        {
            get
            {
                INavDAL dal;
                methodName = MethodBase.GetCurrentMethod().Name;
                className = GetClassFullNameByMethodName(methodName);
                dal = DataAccess.CreateInstence<INavDAL>(className);
                return dal;

            }
        }

        /// <summary>
        /// 实例化FtpUploadHistory
        /// </summary>
        public IFtpUploadHistoryDAL FtpUploadHistory
        {
            get
            {
                IFtpUploadHistoryDAL dal;
                methodName = MethodBase.GetCurrentMethod().Name;
                className = GetClassFullNameByMethodName(methodName);
                dal = DataAccess.CreateInstence<IFtpUploadHistoryDAL>(className);
                return dal;

            }
        }
       
    }
}
