using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF.Business.Model.EntityFramework;

namespace DF.Business.Interfaces
{
   public interface IErrologs
    {
        void inserterorlogs(ErrorLog errLog);
        List<ErrorLog> getAllErrorLogs();
    }
}
