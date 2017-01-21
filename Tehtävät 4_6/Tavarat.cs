using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Tavarat
    {
        public string Esine { get; set; }
        public string Nimi { get; set; }
        public string Tekija { get; set; }
        public int Hinta { get; set; }
        public int IlmestymisVuosi { get; set; }

        public Tavarat()
        {
        }

        public Tavarat(string esine, string nimi, string tekija)
        {
            Esine = esine;
            Nimi = nimi;
            Tekija = tekija;
        }

        public void TavaratMethod()
        {
            Console.WriteLine("Tama metodi kuuluu Tavaralle");
        }

        public override string ToString()
        {
            return Esine + " " + Nimi + " " + Tekija + " " + Hinta + " " + IlmestymisVuosi;
        }
    }
}
