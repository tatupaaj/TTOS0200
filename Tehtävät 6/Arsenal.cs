using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
   public class Pelaaja : IEquatable<Pelaaja>
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Ika + " " + Numero;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Pelaaja objAsPart = obj as Pelaaja;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Numero;
        }
        public bool Equals(Pelaaja other)
        {
            if (other == null) return false;
            return (this.Numero.Equals(other.Numero));
        }
    }

    class Joukkue
    {
        public string Nimi { get; set; }
        public string KotiKaupunki { get; set; }
        public int Pelaajat { get; set; }

        public override string ToString()
        {
            return Nimi + " " + KotiKaupunki;
        }
    }


}
