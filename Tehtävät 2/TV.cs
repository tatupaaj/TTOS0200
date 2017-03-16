using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class TV
    {
        public bool OnkoPaalla { get; set; }
        int kanava;
        public int Kanava
        {
            get { return kanava; }
            set
            {
                kanava = value;
                if (kanava < 0 || kanava > 101)
                {
                    kanava = 0;
                }
            }
        }
    }
}
