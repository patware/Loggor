using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.EnterpriseLibraryLoggingHandler
{
    class EntLibLogEntry : Loggor.Lib.ILogEntry
    {

        public Microsoft.Practices.EnterpriseLibrary.Logging.LogEntry Entry { get; private set; }

        public EntLibLogEntry()
        {
            this.Entry = new Microsoft.Practices.EnterpriseLibrary.Logging.LogEntry();
        }
        
        #region ILogEntry Implementation
        Guid Lib.ILogEntry.ActivityId
        {
            get
            {
                return this.Entry.ActivityId;
            }
            set
            {
                this.Entry.ActivityId = value;
            }
        }

        string Lib.ILogEntry.ActivityIdString
        {
            get { return this.Entry.ActivityIdString; }
        }

        void Lib.ILogEntry.AddErrorMessage(string message)
        {
            this.Entry.AddErrorMessage(message);
        }

        string Lib.ILogEntry.AppDomainName
        {
            get
            {
                return this.Entry.AppDomainName;
            }
            set
            {
                this.Entry.AppDomainName = value;
            }
        }

        ICollection<string> Lib.ILogEntry.Categories
        {
            get
            {
                return this.Entry.Categories;
            }
            set
            {
                this.Entry.Categories = value;
            }
        }

        string[] Lib.ILogEntry.CategoriesStrings
        {
            get { return this.Entry.CategoriesStrings; }
        }

        string Lib.ILogEntry.ErrorMessages
        {
            get { return this.Entry.ErrorMessages; }
        }

        int Lib.ILogEntry.EventId
        {
            get
            {
                return this.Entry.EventId;
            }
            set
            {
                this.Entry.EventId = value;
            }
        }

        IDictionary<string, object> Lib.ILogEntry.ExtendedProperties
        {
            get
            {
                return this.Entry.ExtendedProperties;
            }
            set
            {
                this.Entry.ExtendedProperties = value;
            }
        }

        string Lib.ILogEntry.LoggedSeverity
        {
            get { return this.Entry.LoggedSeverity; }
        }

        string Lib.ILogEntry.MachineName
        {
            get
            {
                return this.Entry.MachineName;
            }
            set
            {
                this.Entry.MachineName = value;
            }
        }

        string Lib.ILogEntry.ManagedThreadName
        {
            get
            {
                return this.Entry.ManagedThreadName;
            }
            set
            {
                this.Entry.ManagedThreadName = value;
            }
        }

        string Lib.ILogEntry.Message
        {
            get
            {
                return this.Entry.Message;
            }
            set
            {
                this.Entry.Message = value;
            }
        }

        int Lib.ILogEntry.Priority
        {
            get
            {
                return this.Entry.Priority;
            }
            set
            {
                this.Entry.Priority = value;
            }
        }

        string Lib.ILogEntry.ProcessId
        {
            get
            {
                return this.Entry.ProcessId;
            }
            set
            {
                this.Entry.ProcessId = value;
            }
        }

        string Lib.ILogEntry.ProcessName
        {
            get
            {
                return this.Entry.ProcessName;
            }
            set
            {
                this.Entry.ProcessName = value;
            }
        }

        Guid? Lib.ILogEntry.RelatedActivityId
        {
            get
            {
                return this.Entry.RelatedActivityId;
            }
            set
            {
                this.Entry.RelatedActivityId = value;
            }
        }

        TraceEventType Lib.ILogEntry.Severity
        {
            get
            {
                return this.Entry.Severity;
            }
            set
            {
                this.Entry.Severity = value;
            }
        }

        DateTime Lib.ILogEntry.TimeStamp
        {
            get
            {
                return this.Entry.TimeStamp;
            }
            set
            {
                this.Entry.TimeStamp = value;
            }
        }

        string Lib.ILogEntry.TimeStampString
        {
            get { return this.Entry.TimeStampString; }
        }

        string Lib.ILogEntry.Title
        {
            get
            {
                return this.Entry.Title;
            }
            set
            {
                this.Entry.Title = value;
            }
        }

        string Lib.ILogEntry.Win32ThreadId
        {
            get
            {
                return this.Entry.Win32ThreadId;
            }
            set
            {
                this.Entry.Win32ThreadId = value;
            }
        }

        TraceEventType Lib.ILogEntry.EventType
        {
            get
            {
                return this.Entry.Severity;
            }
            set
            {
                this.Entry.Severity = value;
            }
        }

        #endregion




    }
}
