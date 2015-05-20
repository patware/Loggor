using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.Lib
{
    /// <summary>
    /// Log Writer that does nothing !  NoOp (or No Operation) is an Assembler Instructor.
    /// </summary>
    public class NoOpWriter : ILogWriter
    {
        bool ILogWriter.IsLoggingEnabled()
        {
            return false;
        }

        bool ILogWriter.IsTracingEnabled()
        {
            return false;
        }

        bool ILogWriter.ShouldLog(ILogEntry log)
        {
            return false;
        }

        ILogEntry ILogWriter.NewLog()
        {
            return new StandardLogEntry();
        }

        ShortLive ILogWriter.NewShortLiveLog(int startEventId, string startMessage, int stopEventId, string stopMessage, string title, params object[] args)
        {
            return new ShortLive(this, startEventId, startMessage, stopEventId, stopMessage, title, args);
        }

        void ILogWriter.Write(ILogEntry log){}
        void ILogWriter.Write(object message){}
        void ILogWriter.Write(object message, IDictionary<string, object> properties){}
        void ILogWriter.Write(object message, IEnumerable<string> categories){}
        void ILogWriter.Write(object message, IEnumerable<string> categories, IDictionary<string, object> properties){}
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority){}
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, IDictionary<string, object> properties){}
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId){}
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity){}
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title){}
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title, IDictionary<string, object> properties){}
        void ILogWriter.Write(object message, string category){}
        void ILogWriter.Write(object message, string category, IDictionary<string, object> properties){}
        void ILogWriter.Write(object message, string category, int priority){}
        void ILogWriter.Write(object message, string category, int priority, IDictionary<string, object> properties){}
        void ILogWriter.Write(object message, string category, int priority, int eventId){}
        void ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity){}
        void ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title){}
        void ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title, IDictionary<string, object> properties){}
        void ILogWriter.Log(int eventId, string message, string title, System.Diagnostics.TraceEventType eventType){}
        void ILogWriter.Log(ILogEntry le){}
    }
}
