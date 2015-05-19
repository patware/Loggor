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
    public interface ILog
    {
        /// <summary>
        /// Normal foo
        /// </summary>
        /// <example>This is Foo</example>
        [Loggor.Lib.Log(EventId=1000)]
        void Foo();

        /// <summary>
        /// A guy enters a bar
        /// <para>Output: i is <paramref name="i"/> and sss is <paramref name="sss"/></para>
        /// </summary>
        /// <param name="i">some number</param>
        /// <param name="sss">some string</param>
        /// <example>i is <paramref name="i"/> and sss is <paramref name="sss"/></example>
        [Loggor.Lib.Log(EventId = 1001)]
        void Bar(int i, string sss);

        /// <summary>
        /// Short running processus.
        /// <para>Start a ThisLongProcess for <paramref name="who"/>.  Started at {StartTime}</para>
        /// <para>ThisLongProcess finished for <paramref name="who"/> Started at {StartTime}, finished at {StopTime}, for a total of {TotalSeconds:0.##} seconds.</para>
        /// </summary>
        /// <param name="who">The person you're doing the process for.</param>
        /// <returns></returns>
        [Loggor.Lib.LogShortLive(StartEventId = 1002, StopEventId= 1003)]
        Loggor.Lib.ShortLive ThisLongProcess(string who);
    }
}
