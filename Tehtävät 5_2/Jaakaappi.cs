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
        public string Nimi { get; set; }
        public string Valmistaja { get; set; }
        private const int maxTarvikkeet = 4;
        private int lkmTarvikkeet = 0;

        public List<Elintarvike> Elintarvikkeet { get; }

        public Jaakaappi()
        {
            Elintarvikkeet = new List<Elintarvike>();
        }

        public void LisääElintarvike(Elintarvike elintarvike)
        {
            if (lkmTarvikkeet < maxTarvikkeet)
            {
                Elintarvikkeet.Add(elintarvike);
                lkmTarvikkeet++;
                Console.WriteLine("Elintarvikeet {0} ja {1} lisätty {2}", elintarvike.Ruoka, elintarvike.Juoma, Nimi);
            }
            else
            {
                Console.WriteLine("Jaakaappi on valitettavasti taynna!");
            }
        }

        public override string ToString()
        {
            string s = "Jaakaaapi on: " + Nimi + " Valmistaja: " + Valmistaja + "\nElintarvikkeet:";
            foreach (Elintarvike r in Elintarvikkeet)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
}
