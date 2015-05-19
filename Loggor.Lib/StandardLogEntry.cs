using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.Lib
{
    /// <summary>
    /// This is a standard, normal LogEntry.
    /// </summary>
    public class StandardLogEntry : ILogEntry
    {
        private IList<string> _errorMessages = new List<string>();
        private Guid _activityId;
        Guid Lib.ILogEntry.ActivityId
        {
            get { return _activityId; }
            set { _activityId = value; }
        }


        string Lib.ILogEntry.ActivityIdString
        {
            get { return _activityId.ToString(); }
        }

        void Lib.ILogEntry.AddErrorMessage(string message)
        {
            _errorMessages.Add(message);
        }

        private string _appDomainName;
        string Lib.ILogEntry.AppDomainName
        {
            get { return _appDomainName; }
            set { _appDomainName = value; }
        }

        private ICollection<string> _categories;
        ICollection<string> Lib.ILogEntry.Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        string[] Lib.ILogEntry.CategoriesStrings
        {
            get
            {
                if (_categories != null)
                    return _categories.ToArray();
                else
                    return new string[] { };
            }
        }

        string Lib.ILogEntry.ErrorMessages
        {
            get { return string.Join("\r\n", _errorMessages); }
        }

        private int _eventId;
        int Lib.ILogEntry.EventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }

        private IDictionary<string, object> _extendedProperties;
        IDictionary<string, object> Lib.ILogEntry.ExtendedProperties
        {
            get { return _extendedProperties; }
            set { _extendedProperties = value; }
        }

        string Lib.ILogEntry.LoggedSeverity
        {
            get
            {
                //if (base._severity != null)
                //                    return _severity.ToString();
                //else 
                return string.Empty;
            }
        }

        private string _machineName;
        string Lib.ILogEntry.MachineName
        {
            get { return _machineName; }
            set { _machineName = value; }
        }

        private string _managedThreadName;
        string Lib.ILogEntry.ManagedThreadName
        {
            get { return _managedThreadName; }
            set { _managedThreadName = value; }
        }

        private string _message = string.Empty;
        string Lib.ILogEntry.Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private int _priority;
        int Lib.ILogEntry.Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        private string _processId;
        string Lib.ILogEntry.ProcessId
        {
            get { return _processId; }
            set { _processId = value; }
        }

        private string _processName;
        string Lib.ILogEntry.ProcessName
        {
            get { return _processName; }
            set { _processName = value; }
        }

        private Guid? _relatedActivityId;
        Guid? Lib.ILogEntry.RelatedActivityId
        {
            get { return _relatedActivityId; }
            set { _relatedActivityId = value; }
        }

        private System.Diagnostics.TraceEventType _severity;
        System.Diagnostics.TraceEventType Lib.ILogEntry.Severity
        {
            get { return _severity; }
            set { _severity = value; }
        }

        private DateTime _timeStamp;
        DateTime Lib.ILogEntry.TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        string Lib.ILogEntry.TimeStampString
        {
            get { return _timeStamp.ToString(); }
        }

        private string _title;
        string Lib.ILogEntry.Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _win32ThreadId;
        string Lib.ILogEntry.Win32ThreadId
        {
            get { return _win32ThreadId; }
            set { _win32ThreadId = value; }
        }

        private System.Diagnostics.TraceEventType _eventType;
        System.Diagnostics.TraceEventType Lib.ILogEntry.EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }
    }
}
