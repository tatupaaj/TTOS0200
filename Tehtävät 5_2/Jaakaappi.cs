using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Jaakaappi
    {
        public List<Elintarvike> elinTarvike = new List<Elintarvike>();

        public List<Elintarvike> ElinTarvike
        {
            get { return elinTarvike; }
        }

        public void LisaaElinTarvike (Elintarvike tavara)
        {
            elinTarvike.Add(tavara);
        }

        public void PoistaElinTarvike (Elintarvike tavara)
        {
            elinTarvike.Remove(tavara);
        }
    }
}
