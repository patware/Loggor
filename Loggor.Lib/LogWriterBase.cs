using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.Lib
{
    public abstract class LogWriterBase
    {
        protected internal abstract ILogEntry GetNewLog();
        protected internal abstract bool IsLoggingEnabled();
        protected internal abstract bool ShouldLog(ILogEntry logEntry);
        protected internal abstract void Write(ILogEntry logEntry);
        public abstract ShortLive NewShortLiveLog(int startEventId, string startMessage, int stopEventId, string stopMessage, string title, params object[] args);

        public void Log(int eventId, string message, string title, System.Diagnostics.TraceEventType eventType)
        {
            var log = GetNewLog();

            log.EventId = eventId;
            log.Message = message;
            log.Title = title;
            log.Severity = System.Diagnostics.TraceEventType.Information;

            if (IsLoggingEnabled() && ShouldLog(log))
                Write(log);
            
            Console.WriteLine(log.Message);

#if DEBUG
            System.Diagnostics.Debug.Write(message);
#endif

        }

        public void Log(ILogEntry logEntry)
        {
            if (IsLoggingEnabled() && ShouldLog(logEntry))
                Write(logEntry);
            

            Console.WriteLine(logEntry.Message);


#if DEBUG
            System.Diagnostics.Debug.Write(logEntry.Message);
#endif

        }

    }


}
