/*****************************************************************************************
 * FileName：NavModel.cs
 * 
 * Description：导航
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

namespace WebUI.Model
{
    [Serializable]
    public class NavModel: BaseModel
    {
        public string MenuLevel { get; set; }
        public string parent { get; set; }
        public string value { get; set; }
        public string webaddress { get; set; }
        public string ordernumber { get; set; }
        public string valuepath { get; set; }
        public string ispublic { get; set; }
        public string hasCost { get; set; }
        public string hasAudt { get; set; }
        public string MenuIcon { get; set; }
    }
}
