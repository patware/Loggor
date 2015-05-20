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
            Lib.ILogWriter lw;

            // instead, opt for IoC/DI approach... but to make this Test Harness clear and easy to understand by all...
            //lw = new Loggor.EnterpriseLibraryLoggingHandler.EntLibLogWriter();

            //lw = new Loggor.DevelopperLoggingHandler.DevLogWriter();
            lw = new Loggor.Lib.NoOpWriter();
            
            ILog log = new MyLog(lw);

            log.Foo();

            log.Bar(123, "bla bla");

            var cld = log.ThisLongProcess("Patou").Start();
            System.Threading.Thread.Sleep(1234);
            cld.Stop();

            var cld2 = log.ThisLongProcess("Sandra").Start();
            System.Threading.Thread.Sleep(234);
            cld2.Stop();

            Console.WriteLine();
            Console.WriteLine("Press any key to close this app ...");
            Console.ReadKey();
        }
    }
}
