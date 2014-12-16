using Loggor.Lib;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.EnterpriseLibraryLoggingHandler
{
    public class LogWriter : Loggor.Lib.LogWriterBase, Loggor.Lib.ILogWriter
    {

        public Microsoft.Practices.EnterpriseLibrary.Logging.LogWriter Writer {get; private set;}
        public LogWriter()
        {
            var config = new Microsoft.Practices.EnterpriseLibrary.Logging.LoggingConfiguration();
            this.Writer = new Microsoft.Practices.EnterpriseLibrary.Logging.LogWriter(config);
        }


        #region LogWriterBase Implementation
        public override ShortLive NewShortLiveLog(int startEventId, string startMessage, int stopEventId, string stopMessage, string title, params object[] args)
        {
            var sl = new Loggor.Lib.ShortLive(this, startEventId, startMessage, stopEventId, stopMessage, title, args);
            return sl;

        }
        protected override ILogEntry GetNewLog()
        {
            var nl = new LogEntry();

            return nl;

        }
        protected override bool IsLoggingEnabled()
        {
            return this.Writer.IsLoggingEnabled();
        }

        protected override bool ShouldLog(ILogEntry logEntry)
        {
            var le = logEntry as LogEntry;
            if (le != null)
                return this.Writer.ShouldLog(le.Entry);
            else
                return false;
        }

        protected override void Write(ILogEntry logEntry)
        {
            var le = logEntry as LogEntry;
            if (le != null)
                this.Writer.Write(le.Entry);
        }
        #endregion
        

        #region ILogWriter Implementation
        bool Lib.ILogWriter.IsLoggingEnabled()
        {
            return this.Writer.IsLoggingEnabled();
        }

        bool Lib.ILogWriter.IsTracingEnabled()
        {
            return this.Writer.IsTracingEnabled();
        }

        bool Lib.ILogWriter.ShouldLog(Lib.ILogEntry log)
        {
            var entLibEntry = log as Loggor.EnterpriseLibraryLoggingHandler.LogEntry;

            return this.Writer.ShouldLog(entLibEntry.Entry);
        }
        Lib.ILogEntry Lib.ILogWriter.NewLog()
        {
            var le = new LogEntry();

            return le;
        }

        void Lib.ILogWriter.Write(Lib.ILogEntry log)
        {
            var entLibEntry = log as Loggor.EnterpriseLibraryLoggingHandler.LogEntry;

            this.Writer.Write(entLibEntry.Entry);
        }

        void Lib.ILogWriter.Write(object message)
        {
            this.Writer.Write(message);
        }

        void Lib.ILogWriter.Write(object message, IDictionary<string, object> properties)
        {
            this.Writer.Write(message, properties);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories)
        {
            this.Writer.Write(message, categories);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, IDictionary<string, object> properties)
        {
            this.Writer.Write(message, categories, properties);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority)
        {
            this.Writer.Write(message, categories, priority);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, IDictionary<string, object> properties)
        {
            this.Writer.Write(message, categories, priority, properties);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId)
        {
            this.Writer.Write(message, categories, priority, eventId);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, TraceEventType severity)
        {
            this.Writer.Write(message, categories, priority, eventId, severity);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, TraceEventType severity, string title)
        {
            this.Writer.Write(message, categories, priority, eventId, severity, title);
        }

        void Lib.ILogWriter.Write(object message, IEnumerable<string> categories, int priority, int eventId, TraceEventType severity, string title, IDictionary<string, object> properties)
        {
            this.Writer.Write(message,categories, priority, eventId, severity, title, properties);
        }

        void Lib.ILogWriter.Write(object message, string category)
        {
            this.Writer.Write(message, category);
        }

        void Lib.ILogWriter.Write(object message, string category, IDictionary<string, object> properties)
        {
            this.Writer.Write(message, category, properties);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority)
        {
            this.Writer.Write(message, category, priority);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, IDictionary<string, object> properties)
        {
            this.Writer.Write(message, category, priority, properties);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, int eventId)
        {
            this.Writer.Write(message, category, priority, eventId);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, int eventId, TraceEventType severity)
        {
            this.Writer.Write(message, category, priority, eventId, severity);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, int eventId, TraceEventType severity, string title)
        {
            this.Writer.Write(message, category, priority, eventId, severity, title);
        }

        void Lib.ILogWriter.Write(object message, string category, int priority, int eventId, TraceEventType severity, string title, IDictionary<string, object> properties)
        {
            this.Writer.Write(message, category, priority, eventId, severity, title, properties);
        }
        #endregion



    }
}
