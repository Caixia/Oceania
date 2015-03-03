/*****************************************************************************************
 * FileName：FSItemModel.cs
 * 
 * Description：FSItem实体类
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

namespace WebUI.Model.FSModel
{
    [Serializable]
    public class FSItemModel : BaseModel
    {
        // Properties
        public string ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public string ItemUM { get; set; }
        public string ItemRevision { get; set; }
        public string MakeBuyCode { get; set; }
        public string ItemType { get; set; }
        public string ItemStatus { get; set; }
        public string IsLotTraced { get; set; }
        public string IsSerialized { get; set; }
        public string OrderPolicy { get; set; }
        public string IsInspectionRequired { get; set; }
        public string DrawingNumber { get; set; }
        public string ItemClass1 { get; set; }
        public string ItemClass2 { get; set; }
        public string ItemClass3 { get; set; }
        public string ItemClass4 { get; set; }
        public string ItemClass5 { get; set; }
        public string ItemClass6 { get; set; }
        public string ItemClass7 { get; set; }
        public string ItemClass8 { get; set; }
        public string ItemReference1 { get; set; }
        public string ItemReference2 { get; set; }
        public string ItemReference3 { get; set; }
        public string ItemReference4 { get; set; }
        public string ItemReference5 { get; set; }
        public string Planner { get; set; }
        public string Buyer { get; set; }
        public string PlanningPolicy { get; set; }
        public int RunLeadTime { get; set; }
        public int FixLeadTime { get; set; }
        public int InspLeadTime { get; set; }
        public int LotSizeDays { get; set; }
        public int LotSizeQuantity { get; set; }
        public int SafetyStock { get; set; }
        public int LotSizeMin { get; set; }
        public int LotSizeMult { get; set; }
        public string Eccn { get; set; }
        public string AtpCode { get; set; }
        public string DmndFnc { get; set; }
        public int DecPrecision { get; set; }
        public string PreferredStk { get; set; }
        public string PreferredBin { get; set; }
    }
}
