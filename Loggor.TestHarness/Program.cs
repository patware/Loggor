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
            ILog log = new LogEntlib();

            log.Foo();

            log.Bar(123, "bin des s");

            var cld = log.ThisLongProcess("Patou").Start();
            System.Threading.Thread.Sleep(1234);
            cld.Stop();

            var cld2 = log.ThisLongProcess("Sandra").Start();
            System.Threading.Thread.Sleep(234);
            cld2.Stop();

        }
    }
}
