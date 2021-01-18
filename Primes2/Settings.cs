using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes2
{
    class Settings
    {
        public ulong maximum = 100;

        [Category("Settings")]
        public ulong Maximum
        {
            get { return maximum; }
            set { maximum = value; }
        }

    }
}