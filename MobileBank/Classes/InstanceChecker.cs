using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobileBank.Classes
{
    class InstanceChecker
    {
        static readonly Mutex mutex = new Mutex(false, "MobileBank");
        public static bool TakeMemory()
        {
            return mutex.WaitOne();
        }
    }
}
