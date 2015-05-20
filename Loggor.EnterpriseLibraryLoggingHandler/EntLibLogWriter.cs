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
    public class EntLibLogWriter : Loggor.Lib.ILogWriter
    {

        public Microsoft.Practices.EnterpriseLibrary.Logging.LogWriter Writer {get; private set;}
        public EntLibLogWriter()
        {
            var config = new Microsoft.Practices.EnterpriseLibrary.Logging.LoggingConfiguration();
            this.Writer = new Microsoft.Practices.EnterpriseLibrary.Logging.LogWriter(config);
        }

        /*
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
        */

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
            var entLibEntry = getEntLibEntry(log);

            return this.Writer.ShouldLog(entLibEntry.Entry);
        }

        Lib.ILogEntry Lib.ILogWriter.NewLog()
        {
            var le = new EntLibLogEntry();

            return le;
        }

        void Lib.ILogWriter.Write(Lib.ILogEntry log)
        {
            var entLibEntry = getEntLibEntry(log);

            this.Writer.Write(log);

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


        ShortLive ILogWriter.NewShortLiveLog(int startEventId, string startMessage, int stopEventId, string stopMessage, string title, params object[] args)
        {
            throw new NotImplementedException();
        }

        void ILogWriter.Log(int eventId, string message, string title, TraceEventType eventType)
        {
            var ele = new EntLibLogEntry();
            ele.Entry.EventId = eventId;
            ele.Entry.Message = message;
            ele.Entry.Title = title;
            this.Writer.Write(ele.Entry);
        }

        void ILogWriter.Log(ILogEntry le)
        {
            var ele = new EntLibLogEntry();
            
            this.Writer.Write(le);
        }
        #endregion

        private EntLibLogEntry getEntLibEntry(ILogEntry log)
        {
            var entLibEntry = log as Loggor.EnterpriseLibraryLoggingHandler.EntLibLogEntry;

            if (entLibEntry != null)
                return entLibEntry;
            else
            {
                entLibEntry = new EntLibLogEntry();
                entLibEntry.Entry.ActivityId = log.ActivityId;
                entLibEntry.Entry.AppDomainName = log.AppDomainName;
                entLibEntry.Entry.Categories = log.Categories;
                
                entLibEntry.Entry.EventId = log.EventId;
                entLibEntry.Entry.ExtendedProperties = log.ExtendedProperties;
                entLibEntry.Entry.MachineName = log.MachineName;
                entLibEntry.Entry.ManagedThreadName = log.ManagedThreadName;
                entLibEntry.Entry.Message = log.Message;
                entLibEntry.Entry.Priority = log.Priority;
                entLibEntry.Entry.ProcessId = log.ProcessId;
                entLibEntry.Entry.ProcessName = log.ProcessName;
                entLibEntry.Entry.RelatedActivityId = log.RelatedActivityId;
                entLibEntry.Entry.Severity = log.Severity;
                entLibEntry.Entry.TimeStamp = log.TimeStamp;
                entLibEntry.Entry.Title = log.Title;
                entLibEntry.Entry.Win32ThreadId = log.Win32ThreadId;

                foreach (var em in log.ErrorMessages)
                    entLibEntry.Entry.AddErrorMessage(em);

                return entLibEntry;
            }

        }

    }
}
