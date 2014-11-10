using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggor.Lib
{
    public class LogShortLiveAttribute : Attribute
    {
        public int StartEventId;
        public int StopEventId;
    }

}
