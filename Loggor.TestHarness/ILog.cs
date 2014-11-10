using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.TestHarness
{
    public interface ILog
    {
        /// <summary>
        /// Juste Fou
        /// <para>Output: Juste Fou</para>
        /// </summary>
        void Foo();

        /// <summary>
        /// C'est une fois un gars qui rentre dans un bar et qui sort de l'autre.
        /// <para>Output: i is <paramref name="i"/> and sss is <paramref name="sss"/></para>
        /// </summary>
        /// <param name="i">I que c'est beau</param>
        /// <param name="sss">son d'un serpent</param>
        /// <example>i is <paramref name="i"/> and sss is <paramref name="sss"/></example>
        void Bar(int i, string sss);

        /// <summary>
        /// Long processus.
        /// <para>Start: It will take some time to do this LongProcess for <paramref name="who"/>.  Anyhow, it started at {StartTime}</para>
        /// <para>Stop: <paramref name="who"/> will be happy, the long process is finished, it started at {StartTime}, it finished at {StopTime}, for a total of {TotalSeconds:0.##} seconds.</para>
        /// </summary>
        /// <param name="who">Kekun</param>
        /// <returns></returns>
        Loggor.Lib.ShortLive ThisLongProcess(string who);
    }
}
