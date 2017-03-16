using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Tavarat : Lompakko
    {
        public int Raha { get; set; }
        public string Kortti { get; set; }

        public override string ToString()
        {
            return "rahaa: " + Raha + "Kortti: " + Kortti;
        }
    }

    class Lompakko
    {
        public List<Tavarat> Lompsa { get; }

        public Lompakko()
        {
            Lompsa = new List<Tavarat>();
        }

        public void LisaaTavara(Tavarat tavara)
        {
            Lompsa.Add(tavara);
        }

        public void PoistaTavara(Tavarat tavara)
        {
            Lompsa.Remove(tavara);
        }
    }


    
}
