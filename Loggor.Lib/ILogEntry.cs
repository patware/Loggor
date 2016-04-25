using System;
namespace Loggor.Lib
{
    public interface ILogEntry
    {
        Guid ActivityId { get; set; }
        string ActivityIdString { get; }
        void AddErrorMessage(string message);
        string AppDomainName { get; set; }
        System.Collections.Generic.ICollection<string> Categories { get; set; }
        string[] CategoriesStrings { get; }
        System.Collections.Generic.IList<string> ErrorMessages { get; }
        int EventId { get; set; }
        System.Collections.Generic.IDictionary<string, object> ExtendedProperties { get; set; }
        string LoggedSeverity { get; }
        string MachineName { get; set; }
        string ManagedThreadName { get; set; }
        string Message { get; set; }
        int Priority { get; set; }
        string ProcessId { get; set; }
        string ProcessName { get; set; }
        Guid? RelatedActivityId { get; set; }
        System.Diagnostics.TraceEventType Severity { get; set; }
        DateTime TimeStamp { get; set; }
        string TimeStampString();
        string TimeStampString(IFormatProvider provider);
        string TimeStampString(string format);
        string TimeStampString(string format, IFormatProvider provider);
        string Title { get; set; }
        string Win32ThreadId { get; set; }

        System.Diagnostics.TraceEventType EventType { get; set; }
    }
}
