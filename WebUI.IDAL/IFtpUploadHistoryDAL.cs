using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.IDAL
{
    public interface IFtpUploadHistoryDAL
    {
        DataSet GetFtpUploadAllHistory(string uploadDate);
    }
}
