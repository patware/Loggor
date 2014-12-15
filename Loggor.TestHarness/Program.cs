using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {

            var lw = new Loggor.EnterpriseLibraryLoggingHandler.LogWriter();
            
            ILog log = new MyLog(lw);

            log.Foo();

            log.Bar(123, "bla bla");

            var cld = log.ThisLongProcess("Patou").Start();
            System.Threading.Thread.Sleep(1234);
            cld.Stop();

            var cld2 = log.ThisLongProcess("Sandra").Start();
            System.Threading.Thread.Sleep(234);
            cld2.Stop();

        }
    }
}
