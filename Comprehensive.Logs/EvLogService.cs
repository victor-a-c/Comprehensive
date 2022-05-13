using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Comprehensive.Logs
{
    public class EvLogService : IEvLogService
    {
        private readonly NLog.Logger Logger = NLog.LogManager.GetLogger("databaseLogger");
        private readonly StringBuilder logTrace = new StringBuilder();
        public Exception? Exception { get; private set; }
        public string Notifications { get { return logTrace.ToString(); } }

        public EvLogService Error(Exception exception, string message, params object[] parameters)
        {
            if(Exception == null)
            {
                Exception = exception;
            }

            // NLog is missing "AddData()"
            //if (parameters?.Count() > 0)
            //{
            //    parameters?.ToList().ForEach(item => { this.Exception.AddData(item); });
            //}

            return this;
        }
    }
}
