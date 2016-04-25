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

        void ILogWriter.Write(ILogEntry log)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IDictionary<string, object> properties)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IEnumerable<string> categories)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IEnumerable<string> categories, IDictionary<string, object> properties)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, IDictionary<string, object> properties)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title, IDictionary<string, object> properties)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, string category)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, string category, IDictionary<string, object> properties)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, string category, int priority)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, string category, int priority, IDictionary<string, object> properties)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, string category, int priority, int eventId)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title, IDictionary<string, object> properties)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Log(int eventId, string message, string title, System.Diagnostics.TraceEventType eventType)
        {
            // Method intentionally left empty.
        }
        void ILogWriter.Log(ILogEntry le)
        {
            // Method intentionally left empty.
        }
    }
}
