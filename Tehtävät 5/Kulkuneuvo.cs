using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

// \\ghost\temp\TTOS0200

namespace JAMK.IT
{
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        private int MaxRenkaat = 4;
        private int lkmRenkaat = 0;

        public List<Rengas> Renkaat { get; }

        public Kulkuneuvo()
        {
            Renkaat = new List<Rengas>();
        }

        public void LisaaRengas(Rengas rengas)
        {
            if (lkmRenkaat < MaxRenkaat)
            {
                Renkaat.Add(rangas);
                lkmRenkaat++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Malli, Nimi);
            }
            else
            {
                Console.WriteLine("Enää ei mahdu rankaita");
            }
        }
        public override string ToString()
        {
            string s = "Pirssissä: " + Nimi + " malli :" + Malli + "\nrenkaat:";
            foreach (Rengas r in Renkaat)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
}
