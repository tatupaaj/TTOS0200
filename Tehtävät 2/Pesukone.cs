using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Pesukone
    {
        public bool OnkoPaalla { get; set; }
        int pesuaste;
        public int Pesuaste
        {
            get { return pesuaste; }
            set
            {
                pesuaste = value;
                if (pesuaste == 40 || pesuaste == 60) { }
            }
        }
    }
}
