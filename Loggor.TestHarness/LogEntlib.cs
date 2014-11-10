using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.TestHarness
{
    public class LogEntlib : ILog
    {
        void ILog.Foo()
        {
            var message = "Juste Fou";
            Console.WriteLine(message);
        }

        void ILog.Bar(int i, string sss)
        {
            var message = string.Format("i is {0} and sss is {1}",
                arg0:i,
                arg1:sss);

            Console.WriteLine(message);
        }

        Lib.ShortLive _longProcess = null;
        Lib.ShortLive ILog.ThisLongProcess(string who)
        {
            var startMessage = "It will take some time to do something like for {0}.  Anyhow, it started at {1}";
            var stopMessage = "{0} will be happy, the long process is finished, it started at {1}, it finished at {2}, for a total of {3:0.##} seconds.";

            _longProcess = new Lib.ShortLive(startMessage, stopMessage, who);
            return _longProcess;
        }
    }
}
