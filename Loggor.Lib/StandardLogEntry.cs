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
        private readonly IList<string> _errorMessages = new List<string>();
        
        Guid Lib.ILogEntry.ActivityId { get; set; }


        string Lib.ILogEntry.ActivityIdString
        {
            get { return ((Lib.ILogEntry)this).ActivityId.ToString(); }
        }

        void Lib.ILogEntry.AddErrorMessage(string message)
        {
            _errorMessages.Add(message);
        }

        string Lib.ILogEntry.AppDomainName { get; set; }

        ICollection<string> Lib.ILogEntry.Categories { get; set; }

        string[] Lib.ILogEntry.CategoriesStrings
        {
            get
            {

                if (((Lib.ILogEntry)this).Categories != null)
                    return ((Lib.ILogEntry)this).Categories.ToArray();
                else
                    return new string[] { };
                                
            }
        }

        IList<string> Lib.ILogEntry.ErrorMessages
        {
            get { return _errorMessages; }
        }

        int Lib.ILogEntry.EventId { get; set; }

        IDictionary<string, object> Lib.ILogEntry.ExtendedProperties { get; set; }

        string Lib.ILogEntry.LoggedSeverity
        {
            get
            {
                return string.Empty;
            }
        }

        string Lib.ILogEntry.MachineName { get; set; }

        string Lib.ILogEntry.ManagedThreadName { get; set; }

        string Lib.ILogEntry.Message { get; set; }

        int Lib.ILogEntry.Priority { get; set; }

        string Lib.ILogEntry.ProcessId { get; set; }

        string Lib.ILogEntry.ProcessName { get; set; }

        Guid? Lib.ILogEntry.RelatedActivityId { get; set; }

        System.Diagnostics.TraceEventType Lib.ILogEntry.Severity { get; set; }

        
        DateTime Lib.ILogEntry.TimeStamp { get; set; }

        string Lib.ILogEntry.TimeStampString()
        {
            return ((Lib.ILogEntry)this).TimeStamp.ToString(System.Globalization.CultureInfo.CurrentCulture); 
        }
        string Lib.ILogEntry.TimeStampString(IFormatProvider provider)
        {
            return ((Lib.ILogEntry)this).TimeStamp.ToString(provider);
        }
        string Lib.ILogEntry.TimeStampString(string format)
        {
            return ((Lib.ILogEntry)this).TimeStamp.ToString(format);
        }
        string Lib.ILogEntry.TimeStampString(string format, IFormatProvider provider)
        {
            return ((Lib.ILogEntry)this).TimeStamp.ToString(format, provider);
        }

        string Lib.ILogEntry.Title { get; set; }

        string Lib.ILogEntry.Win32ThreadId { get; set; }
       
        System.Diagnostics.TraceEventType Lib.ILogEntry.EventType { get; set; }
    }
}
