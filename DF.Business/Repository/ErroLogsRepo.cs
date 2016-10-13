using DF.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF.Business.Model.EntityFramework;

namespace DF.Business.Repository
{
    public class ErroLogsRepo : IErrologs
    {
        public List<ErrorLog> getAllErrorLogs()
        {
            throw new NotImplementedException();
        }

        public void inserterorlogs(ErrorLog errLog)
        {
            var dfEntities = new DF_DefaultEntities();
            try
            {
                var result = dfEntities.DF_CreateErrorLog(errLog.ErrorMessage, errLog.Error_LineNo, errLog.Procedure_Name, errLog.Method);
            }
            catch (Exception ex)
            {
 
            }
        }
    }
}
