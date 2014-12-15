using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Loggor.TestHarness
{
    public class MyLog : ILog
    {
        public Loggor.Lib.ILogWriter LogWriter = null;

        public MyLog(Loggor.Lib.ILogWriter logWriter)
        {
            this.LogWriter = logWriter;
        }
        
        void ILog.Foo()
        {
            var le = LogWriter.NewLog();
            le.EventId = 1000;
            le.Message = "This is Foo";
            le.Title = "Normal foo";
            le.EventType = System.Diagnostics.TraceEventType.Information;

            LogWriter.Log(le);
        }

        void ILog.Bar(int i, string sss)
        {
            var le = LogWriter.NewLog();

            le.EventId = 1001;
            le.Message = string.Format("i is {0} and sss is {1}",
                arg0: i,
                arg1: sss);
            le.Title = "A guy enters a bar";
            le.EventType = System.Diagnostics.TraceEventType.Information;

            LogWriter.Log(le);
            
        }

        Lib.ShortLive _longProcess = null;
        Lib.ShortLive ILog.ThisLongProcess(string who)
        {
            var startEventId = 1002;
            var startMessage = "Start a ThisLongProcess for {0}.  Started at {1}";

            var stopEventId = 1003;
            var stopMessage = "ThisLongProcess finished for {0}. Started at {1}, finished at {2}, for a total of {3:0.##} seconds.";

            var title = "Short running processus.";

            _longProcess = this.LogWriter.NewShortLiveLog( startEventId, startMessage, stopEventId, stopMessage, title, who);
            return _longProcess;
        }
    }
}
