/*****************************************************************************************
 * FileName：BaseModel.cs
 * 
 * Description：实体类的基类
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
    public class BaseModel
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string PublicColumn { get; set; }
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string CreateUserId { get; set; }
    }
}
