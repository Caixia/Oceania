/*****************************************************************************************
 * FileName：NavDAL.cs
 * 
 * Description：导航的DAL层
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
using WebUI.IDAL;
using WebUI.Model;
using Common.Utility.Extension;
using System.Data;

namespace WebUI.DAL
{
    public class NavDAL: BaseDAL, INavDAL
    {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        public NavDAL()
        {
            this.DBHelper = Common.DBUtility.DBFactory.GetDbHelper("ConnectionString");
        }
        /// <summary>
        /// 获取导航列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IList<NavModel> getNavList(NavModel model)
        {
            List<NavModel> list = new List<NavModel>();
            StringBuilder cmdTxt = new StringBuilder();
            cmdTxt.Append(@"SELECT DISTINCT
                                    MP.*
                            FROM    Z_WebUIMenu M
                                    LEFT JOIN Z_FSWebUIUserRole R ON R.MenuLevel = M.MenuLevel
                                    LEFT JOIN Z_User U ON U.ID = R.UserID
                                    LEFT JOIN Z_WebUIMenu MP ON MP.MenuLevel = M.parent
                            WHERE   UPPER(U.Name) = UPPER(@Name)
                                    AND M.parent <> 0 AND MP.isVisable=0 
                            UNION
                            SELECT  M.*
                            FROM    Z_WebUIMenu M
                                    LEFT JOIN Z_FSWebUIUserRole R ON R.MenuLevel = M.MenuLevel
                                    LEFT JOIN Z_User U ON U.ID = R.UserID
                            WHERE   ( UPPER(U.Name) = UPPER(@Name)
                                      AND M.parent = 0 AND M.isVisable=0 
                                    )
                                    OR ispublic = 1
                            UNION
                            SELECT DISTINCT
                                    ID ,
                                    MenuLevel ,
                                    parent ,
                                    [value] ,
                                    webaddress ,
                                    ordernumber ,
                                    valuepath ,
                                    ispublic ,
                                    hasCost ,
                                    hasAudt ,
                                    MenuIcon ,
                                    isVisable 
                            FROM    Z_View_FSWebUIUserRole
                            WHERE   LOWER(Name) = LOWER(@Name) AND isVisable=0 
                            ORDER BY parent ,
                                    ordernumber");
            IDictionary<string, object> paraList = new Dictionary<string, object>();
            paraList.AddOrReplace("@Name", model.CreateUserId);
            IDataReader dataReader;
            using (dataReader = this.DBHelper.ExecuteReader(cmdTxt.ToString(), paraList))
            {
                while (dataReader.Read())
                {
                    NavModel navmodel = new NavModel();
                    navmodel.Id = dataReader["ID"].ToString();
                    navmodel.MenuLevel = dataReader["MenuLevel"].ToString();
                    navmodel.parent = dataReader["parent"].ToString();
                    navmodel.value = dataReader["value"].ToString();
                    navmodel.webaddress = dataReader["webaddress"].ToString();
                    navmodel.ordernumber = dataReader["ordernumber"].ToString();
                    navmodel.valuepath = dataReader["valuepath"].ToString();
                    navmodel.ispublic = dataReader["ispublic"].ToString();
                    navmodel.hasCost = dataReader["hasCost"].ToString();
                    navmodel.hasAudt = dataReader["hasAudt"].ToString();
                    navmodel.MenuIcon = dataReader["MenuIcon"].ToString();
                    list.Add(navmodel);
                }
            }
            return list;
        }
    }
}
