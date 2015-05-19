using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.DevelopperLoggingHandler
{
    public class DevLogWriter: Loggor.Lib.ILogWriter
    {
        #region ILogWriter

        bool Lib.ILogWriter.IsLoggingEnabled()
        {
            return true;
        }

        bool Lib.ILogWriter.IsTracingEnabled()
        {
            return true;
        }

        bool Lib.ILogWriter.ShouldLog(Lib.ILogEntry log)
        {
            return true;
        }

        Lib.ILogEntry Lib.ILogWriter.NewLog()
        {
            return new Loggor.Lib.StandardLogEntry();
        }

        Lib.ShortLive Lib.ILogWriter.NewShortLiveLog(int startEventId, string startMessage, int stopEventId, string stopMessage, string title, params object[] args)
        {
            return new Lib.ShortLive(this, startEventId, startMessage, stopEventId, stopMessage, title, args);
        }

        void Lib.ILogWriter.Write(Lib.ILogEntry log)
        {
            System.Diagnostics.Trace.WriteLine(log.Message);
        }

        void Lib.ILogWriter.Write(object message)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IDictionary<string, object> properties)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, IDictionary<string, object> properties)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, IDictionary<string, object> properties)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title, IDictionary<string, object> properties)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, string category)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, string category, IDictionary<string, object> properties)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, IDictionary<string, object> properties)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, int eventId)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title, IDictionary<string, object> properties)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Log(int eventId, string message, string title, System.Diagnostics.TraceEventType eventType)
        {
            System.Diagnostics.Trace.WriteLine(message);
        }

        void Lib.ILogWriter.Log(Lib.ILogEntry le)
        {
            System.Diagnostics.Trace.WriteLine(le.Message);
        }
        #endregion

        /*
        #region LogWriterBase
        public override Loggor.Lib.ShortLive NewShortLiveLog(int startEventId, string startMessage, int stopEventId, string stopMessage, string title, params object[] args)
        {
            var sl = new Loggor.Lib.ShortLive(this, startEventId, startMessage, stopEventId, stopMessage, title, args);
            return sl;

        }        
        protected override Lib.ILogEntry GetNewLog()
        {
            return new Loggor.Lib.StandardLogEntry();
        }
        protected override bool IsLoggingEnabled()
        {
            return true;
        }
        protected override bool ShouldLog(Loggor.Lib.ILogEntry logEntry)
        {
            return true;
        }

        protected override void Write(Loggor.Lib.ILogEntry logEntry)
        {
            if (logEntry != null)
                System.Diagnostics.Trace.WriteLine(logEntry.Message);
        }

        #endregion
         */
    }
}
