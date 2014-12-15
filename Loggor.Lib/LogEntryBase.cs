using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.Lib
{
    public class LogEntryBase
    {
        private TraceEventType _eventType = TraceEventType.Information;

        public TraceEventType EventType
        {
            get
            {
                return _eventType;
            }
            set
            {
                _eventType = value;
            }
        }
    }
}
