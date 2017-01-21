using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Vempaimet : Tavarat
    {
        public string Kayttis { get; set; }
        public string Naytto { get; set; }
        public int Muisti { get; set; }

        public Vempaimet()
        {
        }

        public Vempaimet(string esine, string nimi, string tekija, string kayttis, string naytto)
            : base(esine, nimi, tekija)
        {
            Kayttis = kayttis;
            Naytto = naytto;
        }

        public void VempaimetMethod()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " " + Kayttis + " " + Naytto + " " + Muisti;
        }
    }
}