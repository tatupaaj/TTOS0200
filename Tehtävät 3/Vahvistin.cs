using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävät_3
{
    class Vahvistin
    {
        int volume;
        public int Volume
        {
            get
            {
                return Volume;
            }
            set
            {
                volume = value;
                if (value >= 0 || value <= 100)
                {
                    volume = 0;
                }
            }
        }
}
}
