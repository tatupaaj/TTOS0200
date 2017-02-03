using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Kala
    {
        public string Laji { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }
        public Kala() { }
        public Kala(string laji, double pituus, double paino)
        {
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
        }


        public override string ToString()
        {
            return "Laji: " + Laji + Pituus + "cm " + Paino + "kg";
        }
    }


    class Kalastaja
    {
        public string Nimi { get; set; }
        public string PuhNumero { get; set; }

        public Kalastaja() { }
        public Kalastaja(string nimi, string puhnumero)
        {
            Nimi = nimi;
            PuhNumero = puhnumero;
        }
        public override string ToString()
        {
            return "Uusi kalastaja lisätty kalastajarekisteriin: \n-Kalastaja: " + Nimi + " Puhelinnumero: " + PuhNumero;
        }
    }

    class Kalapaikka
    {
        public string Paikannimi { get; set; }
        public string Sijainti { get; set; }

        public Kalapaikka() { }
        public Kalapaikka(string paikannimi, string sijainti)
        {
            Paikannimi = paikannimi;
            Sijainti = sijainti;
        }
        public override string ToString()
        {
            return "-Paikka: " + Paikannimi + "\n" + "-Sijainti: " + Sijainti;
        }
    }
}
