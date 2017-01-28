using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Ika + " " + Numero;
        }
    }

    class Joukkue
    {
        public string Nimi { get; set; }
        public string KotiKaupunki { get; set; }
        private List<Pelaaja> joukkue;
        public List<Pelaaja> PelaajaLista
        { get { return joukkue; } }

        public Joukkue()
        {
            joukkue = new List<Pelaaja>();
        }

        public void LisaaPelaaja(Pelaaja gunner)
        {
            joukkue.Add(gunner);
        }

        public Pelaaja HaePelaaja(int index)
        {
            if (index < joukkue.Count)
            {
                return joukkue.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public Pelaaja HaeHenkiloHetulla(int numero)
        {
            foreach (Pelaaja gunner in joukkue)
            {
                if (gunner.Numero == numero)
                {
                    return gunner;
                }
            }
            return null;
        }
    }
}
