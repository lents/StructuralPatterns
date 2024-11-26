using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LoggerAdapter : ILogger
    {
        private readonly LegacyLogger _legacyLogger;

        public LoggerAdapter(LegacyLogger legacyLogger)
        {
            _legacyLogger = legacyLogger;
        }

        public void Log(string message)
        {
            // Translate the call to the legacy system
            _legacyLogger.WriteToLog(message);
        }
    }

}
