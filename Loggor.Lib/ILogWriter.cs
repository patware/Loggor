using System;
namespace Loggor.Lib
{
    public interface ILogWriter
    {
        bool IsLoggingEnabled();
        bool IsTracingEnabled();
        bool ShouldLog(ILogEntry log);
        ILogEntry NewLog();
        ShortLive NewShortLiveLog(int startEventId, string startMessage, int stopEventId, string stopMessage, string title, params object[] args);
        void Write(ILogEntry log);
        void Write(object message);
        void Write(object message, System.Collections.Generic.IDictionary<string, object> properties);
        void Write(object message, System.Collections.Generic.IEnumerable<string> categories);
        void Write(object message, System.Collections.Generic.IEnumerable<string> categories, System.Collections.Generic.IDictionary<string, object> properties);
        void Write(object message, System.Collections.Generic.IEnumerable<string> categories, int priority);
        void Write(object message, System.Collections.Generic.IEnumerable<string> categories, int priority, System.Collections.Generic.IDictionary<string, object> properties);
        void Write(object message, System.Collections.Generic.IEnumerable<string> categories, int priority, int eventId);
        void Write(object message, System.Collections.Generic.IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity);
        void Write(object message, System.Collections.Generic.IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title);
        void Write(object message, System.Collections.Generic.IEnumerable<string> categories, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title, System.Collections.Generic.IDictionary<string, object> properties);
        void Write(object message, string category);
        void Write(object message, string category, System.Collections.Generic.IDictionary<string, object> properties);
        void Write(object message, string category, int priority);
        void Write(object message, string category, int priority, System.Collections.Generic.IDictionary<string, object> properties);
        void Write(object message, string category, int priority, int eventId);
        void Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity);
        void Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title);
        void Write(object message, string category, int priority, int eventId, System.Diagnostics.TraceEventType severity, string title, System.Collections.Generic.IDictionary<string, object> properties);

        void Log(int eventId, string message, string title, System.Diagnostics.TraceEventType eventType);
        void Log(ILogEntry le);


    }
}
