using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Kortti
    {
        public string KortinMaa { get; set; }
        public int KorttienMaara { get; set; }

        public Kortti()
        {
        }

        public override string ToString()
        {
            return KorttienMaara + " Kortti on: " + KortinMaa;
        }
    }

        class KorttiPakka
        {
            //public Kortti[] Kortit;
            public List<Kortti> Kortit;

            public KorttiPakka()
            {
                Kortit = new List<Kortti>();
                int i = 0;
                for (i = 0; i < 13; i++)
                {
                    Kortit[i] = new Kortti() { KortinMaa = "Hertta", KorttienMaara = i + 1 };
                }
                for (i = 0; i < 13; i++)
                {
                    Kortit[i + 13] = new Kortti() { KortinMaa = "Pata", KorttienMaara = i + 1 };
                }
                for (i = 0; i < 13; i++)
                {
                    Kortit[i + 26] = new Kortti() { KortinMaa = "Ruutu", KorttienMaara = i + 1 };
                }
                for (i = 0; i < 13; i++)
                {
                    Kortit[i + 39] = new Kortti() { KortinMaa = "Risti", KorttienMaara = i + 1 };
                }
              }
           }
     
            
}

