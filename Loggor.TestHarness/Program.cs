using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.TestHarness
{
    class Program
    {

        protected Program()
        {

        }

        private static ILog _log;

        /// <summary>
        /// Sample Starter
        /// </summary>
        /// <remarks>
        /// <code>
        /// instead, opt for IoC/DI approach... but to make this Test Harness clear and easy to understand by all...
        /// lw = new Loggor.EnterpriseLibraryLoggingHandler.EntLibLogWriter();
        /// lw = new Loggor.DevelopperLoggingHandler.DevLogWriter();
        /// </code>
        /// </remarks>
        static void Main()
        {
            Lib.ILogWriter lw;

            lw = new Loggor.Lib.NoOpWriter();
            
            _log = new MyLog(lw);

            DoFoo();

            DoBar();

            DoLongProcess();
            
            Console.WriteLine();
            Console.WriteLine("Press any key to close this app ...");
            Console.ReadKey();
        }
        private static void DoFoo()
        {
            _log.Foo();
        }
        private static void DoBar()
        {
            _log.Bar(123, "bla bla");

        }

        private static void DoLongProcess()
        {
            
            var cld1 = _log.ThisLongProcess("Patou").Start();
            System.Threading.Thread.Sleep(1234);
            cld1.Stop();

            var cld2 = _log.ThisLongProcess("Sandra").Start();
            System.Threading.Thread.Sleep(2345);
            cld2.Stop();
        }

    }
}
