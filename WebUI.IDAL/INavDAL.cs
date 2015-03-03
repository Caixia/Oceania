/*****************************************************************************************
 * FileName：INavDAL.cs
 * 
 * Description：导航接口DAL
 * 
 * Developer：caixia yang
 * 
 * CreatDate：2015-02-09
 * 
 ******************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.Model;

namespace WebUI.IDAL
{
    public interface INavDAL: IBaseDAL
    {
        IList<NavModel> getNavList(NavModel model);
    }
}
