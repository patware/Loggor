using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.TestHarness
{
    /// <summary>
    /// Logging for application TestHarness
    /// </summary>
    public class MyLog : ILog
    {
        /// <summary>
        /// Event Ids.
        /// </summary>
        public enum MyLogEventIds
        {
            /// <summary>
            /// Normal foo
            /// </summary>
            Foo = 1000,

            /// <summary>
            /// A guy enters a bar
            /// <para>Output: i is <paramref name="i"/> and sss is <paramref name="sss"/></para>
            /// </summary>
            Bar = 1001,

            /// <summary>
            /// Start of a Short running processus.  Start a ThisLongProcess for {who}.  Started at {StartTime}.
            /// </summary>
            /// <seealso cref="MyLogEventIds.ThisLongProcessStop"/>
            ThisLongProcessStart = 1002,

            /// <summary>
            /// Stop of a Short running processus. ThisLongProcess finished for {who}, started at {StartTime}, finished at {StopTime}, for a total of {TotalSeconds:0.##} seconds
            /// </summary>
            /// <seealso cref="MyLogEventIds.ThisLongProcessStart"/>
            ThisLongProcessStop = 1003
        }

        /// <summary>
        /// The actual LogWriter
        /// </summary>
        public Loggor.Lib.ILogWriter LogWriter = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logWriter"></param>
        public MyLog(Loggor.Lib.ILogWriter logWriter)
        {
            this.LogWriter = logWriter;
        }

        /// <summary>
        /// Normal foo
        /// </summary>
        /// <example>This is Foo</example>
        void ILog.Foo()
        {
            var le = LogWriter.NewLog();
            le.EventId = 1000;
            le.Message = "This is Foo";
            le.Title = "Normal foo";
            le.EventType = System.Diagnostics.TraceEventType.Information;

            LogWriter.Log(le);
        }

        /// <summary>
        /// A guy enters a bar
        /// <para>Output: i is <paramref name="i"/> and sss is <paramref name="sss"/></para>
        /// </summary>
        /// <param name="i">some number</param>
        /// <param name="sss">some string</param>
        /// <example>i is <paramref name="i"/> and sss is <paramref name="sss"/></example>
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
        /// <summary>
        /// Short running processus.
        /// <para>Start a ThisLongProcess for <paramref name="who"/>.  Started at {StartTime}</para>
        /// <para>ThisLongProcess finished for <paramref name="who"/>, started at {StartTime}, finished at {StopTime}, for a total of {TotalSeconds:0.##} seconds.</para>
        /// </summary>
        /// <param name="who">The person you're doing the process for.</param>
        /// <returns></returns>
        Lib.ShortLive ILog.ThisLongProcess(string who)
        {
            var startEventId = 1002;
            var startMessageStringFormat = "Start a ThisLongProcess for {0}.  Started at {1}";

            var stopEventId = 1003;
            var stopMessageStringFormat = "ThisLongProcess finished for {0}, started at {1}, finished at {2}, for a total of {3:0.##} seconds.";

            var title = "Short running processus.";

            _longProcess = this.LogWriter.NewShortLiveLog(startEventId, startMessageStringFormat, stopEventId, stopMessageStringFormat, title, who);
            return _longProcess;
        }
    }
}
