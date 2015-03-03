/*****************************************************************************************
 * FileName：BaseDAL.cs
 * 
 * Description：DAL层的基类
 * 
 * Developer：caixia yang
 * 
 * CreatDate：2015-02-10
 * 
 ******************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DBUtility;
using WebUI.IDAL;

namespace WebUI.DAL
{
    public class BaseDAL: IBaseDAL
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        protected DBHelper DBHelper { get; set; }
    }
}
