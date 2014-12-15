using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.Lib
{
    public class ShortLive
    {

        public class ShortLiveData
        {
            private ILogWriter LogWriter = null;

            private int startEventId;
            private int stopEventId;
            private string startMessage = string.Empty;
            private string stopMessage = string.Empty;
            private string title = string.Empty;
            private DateTime StartTime;
            private DateTime StopTime;
            private object[] args;

            public ShortLiveData(ILogWriter logWriter, int startEventId, int stopEventId, string startMessage, string stopMessage, string title, params object[] args)
            {
                this.LogWriter = logWriter;
                this.startEventId = startEventId;
                this.stopEventId = stopEventId;
                this.startMessage = startMessage;
                this.stopMessage = stopMessage;
                this.StartTime = DateTime.Now;
                this.args = args;
            }

            internal void Start()
            {
                var message = startMessage;

                switch (args == null ? 0 : Math.Min(6, args.Length))
                {
                    case 0:
                        message = string.Format(startMessage, this.StartTime);
                        break;
                    case 1:
                        message = string.Format(startMessage, args[0], this.StartTime);
                        break;
                    case 2:
                        message = string.Format(startMessage, args[0], args[1], this.StartTime);
                        break;
                    case 3:
                        message = string.Format(startMessage, args[0], args[1], args[2], this.StartTime);
                        break;
                    case 4:
                        message = string.Format(startMessage, args[0], args[1], args[2], args[3], this.StartTime);
                        break;
                    case 5:
                        message = string.Format(startMessage, args[0], args[1], args[2], args[3], args[4], this.StartTime);
                        break;
                    case 6:
                        message = string.Format(startMessage, args[0], args[1], args[2], args[3], args[4], args[5], this.StartTime);
                        break;
                }

                this.LogWriter.Log(this.startEventId, message, title, System.Diagnostics.TraceEventType.Information);
            }
            public void Stop()
            {
                this.StopTime = DateTime.Now;

                var e = this.StopTime - this.StartTime;

                var message = this.stopMessage;

                switch (args.Length)
                {
                    case 0:
                        message = string.Format(stopMessage, this.StartTime, this.StopTime, e.TotalSeconds);
                        break;
                    case 1:
                        message = string.Format(stopMessage, args[0], this.StartTime, this.StopTime, e.TotalSeconds);
                        break;
                    case 2:
                        message = string.Format(stopMessage, args[0], args[1], this.StartTime, this.StopTime, e.TotalSeconds);
                        break;
                    case 3:
                        message = string.Format(stopMessage, args[0], args[1], args[2], this.StartTime, this.StopTime, e.TotalSeconds);
                        break;
                    case 4:
                        message = string.Format(stopMessage, args[0], args[1], args[2], args[3], this.StartTime, this.StopTime, e.TotalSeconds);
                        break;
                    case 5:
                        message = string.Format(stopMessage, args[0], args[1], args[2], args[3], args[4], this.StartTime, this.StopTime, e.TotalSeconds);
                        break;
                    case 6:
                        message = string.Format(stopMessage, args[0], args[1], args[2], args[3], args[4], args[5], this.StartTime, this.StopTime, e.TotalSeconds);
                        break;
                }

                this.LogWriter.Log(this.stopEventId, message, this.title, System.Diagnostics.TraceEventType.Information);
            }
        }

        private ShortLiveData _sld;

        public ShortLive(ILogWriter logWriter, int startEventId, string startMessage, int stopEventId, string stopMessage, string title, params object[] args)
        {
            _sld = new ShortLiveData(logWriter, startEventId, stopEventId, startMessage, stopMessage, title, args);
        }

        public ShortLiveData Start()
        {
            _sld.Start();
            return _sld;
        }
    }
}
