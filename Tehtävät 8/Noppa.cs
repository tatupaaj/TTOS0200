using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Noppa
    {
        public Random rand = new Random();

        float noppaluku;
        public float NoppaLuku
        {
            get
            {
                noppaluku = rand.Next(1, 7);
                return noppaluku;
            }
            set { }
        }
    }
}
