/*****************************************************************************************
 * FileName：NavBLL.cs
 * 
 * Description：导航的BLL层
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

namespace WebUI.BLL
{
    public class NavBLL: BaseBLL
    {

        private INavDAL _NavDAL;

        public NavBLL()
        {
            _NavDAL = DALProvider.DefaultProvide.NavDAL;
        }

        public IList<NavModel> getNavList(NavModel model)
        {
            return _NavDAL.getNavList(model);
        }
    }
}
