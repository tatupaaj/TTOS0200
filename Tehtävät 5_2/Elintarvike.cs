using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Elintarvike
    {
        public string Ruoka { get; set; }

        public override string ToString()
        {
            return "Ruoka: " + Ruoka;
        }
    }
}
