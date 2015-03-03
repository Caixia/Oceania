using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.IDAL;

namespace WebUI.BLL
{
    public class FtpUploadHistoryBLL
    {
        /// <summary>
        /// 定义IFSVendorDAL
        /// </summary>
        private IFtpUploadHistoryDAL FtpUploadHistoryDAL;

        /// <summary>
        /// Initializes a new instance of the FSVendorBLL class.实例化FSVendorDAL
        /// </summary>
        public FtpUploadHistoryBLL()
        {
            this.FtpUploadHistoryDAL = DALProvider.DefaultProvide.FtpUploadHistory;
        }

        /// <summary>
        /// 获取所有的FTP上传的历史信息列表
        /// </summary>
        /// <param name="uploadDate"></param>
        /// <returns></returns>
        public DataSet GetFtpUploadAllHistory(string uploadDate)
        {
            return this.FtpUploadHistoryDAL.GetFtpUploadAllHistory(uploadDate);
        }
    }
}
