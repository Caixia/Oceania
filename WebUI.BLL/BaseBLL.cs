/*****************************************************************************************
 * FileName：BaseDAL.cs
 * 
 * Description：BLL层的基类
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

namespace WebUI.BLL
{
    public class BaseBLL
    {
        private IBaseDAL _BaseDAL;
        public BaseBLL()
        {
            _BaseDAL = DALProvider.DefaultProvide.BaseDAL;
        }

    }
}
