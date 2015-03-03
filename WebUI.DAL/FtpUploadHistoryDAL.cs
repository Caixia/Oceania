using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.IDAL;
using System.Data;
using Common.Utility.Extension;

namespace WebUI.DAL
{
    public class FtpUploadHistoryDAL : BaseDAL, IFtpUploadHistoryDAL
    {
        public FtpUploadHistoryDAL()
        {
            this.DBHelper = Common.DBUtility.DBFactory.GetDbHelper("ConnectionString");
        }

        /// <summary>
        /// 获取FTP上传的所有的历史记录
        /// </summary>
        /// <param name="uploadDate"></param>
        /// <param name="PagerNumber"></param>
        /// <param name="RecordCount"></param>
        /// <returns></returns>
        public DataSet GetFtpUploadAllHistory(string uploadDate)
        {
            DataSet ds = new DataSet();
            StringBuilder CmdText = new StringBuilder();
            CmdText.Append(@" select  OrderType
                                    ,SiteCode
                                    ,PONumber
                                    ,POLinenumber
                                    ,ItemNumber
                                    ,VendorItemNumber
                                    ,VendorItemDescription
                                    ,ContractId
                                    ,ItemUnitCost
                                    ,LoadedCostFlag
                                    ,cast(OrderValue as decimal(30,2)) as OrderValue
                                    ,LineItemOrderedQuantity
                                    ,ReturnQuantity
                                    ,CommitDate
                                    ,PromisedDate
                                    ,Status
                                    ,CurrencyCode
                                    ,UnitOfMeasure
                            from Z_POLoadToFtpHistory 
                            where convert(nvarchar(10),LoadToFtpDate,120)=@LoadToFtpDate
                            order by ponumber,polinenumber ");
            IDictionary<string, object> paraList = new Dictionary<string, object>();
            paraList.AddOrReplace("@LoadToFtpDate", uploadDate); ;
            ds = this.DBHelper.ExecuteDataSet(CmdText.ToString(), paraList);
            return ds;
        }
    }
}
