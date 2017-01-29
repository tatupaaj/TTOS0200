using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaHenkiloRekisteri();
            //TestaaCD();
            //TestaaKortit();
            TestaaArsenal();
        }

        static void TestaaHenkiloRekisteri()
        {
            // luodaan muutama testi henkilo
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "jack", Sukunimi = "Russell", Hetu = "311270-123A" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Pekka", Sukunimi = "Puupaa", Hetu = "311270-999A" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Jooseppi", Sukunimi = "Poika", Hetu = "336457-666A" };

            // lisätään henkilot poppooseen

            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);

            // tulostetaan poppooo naytolle
            foreach (Henkilo h in poppoo.Henkilolista)
            {
                Console.WriteLine("{0}", h.ToString());
            }
            // Todo kysy käyttäjältä hetu ja haetaan sitä vastaava henkilo naytolle
            Console.Write("Anna Hetu: ");
            string tmp = Console.ReadLine();
            Console.WriteLine("{0}", poppoo.HaeHenkiloHetulla(tmp));


        }

        // tehtävä 2
        static void TestaaCD()
        {
            Console.WriteLine("CD data: ");
            Songs music = new Songs();
            CD track = new CD();
            track.Name = "Name: Imaginations From The Other Side";
            track.Artist = "\nAtrist: Blind Guargian";
            CD track1 = new CD();
            track1.Song = "Imaginations from the other side 7.18";
            CD track2 = new CD();
            track2.Song = "I'm alive 5.19";
            CD track3 = new CD();
            track3.Song = "A bast and future secret 3.47";
            CD track4 = new CD();
            track4.Song = "The script for my reguiem 6.08";
            CD track5 = new CD();
            track5.Song = "Mordred's song 5.27";
            CD track6 = new CD();
            track6.Song = "Born in the mourning hall 5.12";
            CD track7 = new CD();
            track7.Song = "Bright eyes 5.15";
            CD track8 = new CD();
            track8.Song = "Another holy war 4.31";
            CD track9 = new CD();
            track9.Song = "And the story ends 5.59";


            music.NewSong(track);
            music.NewSong(track1);
            music.NewSong(track2);
            music.NewSong(track3);
            music.NewSong(track4);
            music.NewSong(track5);
            music.NewSong(track6);
            music.NewSong(track7);
            music.NewSong(track8);
            music.NewSong(track9);

            foreach (CD cd in music.SongList)
            {
                Console.WriteLine("{0}", cd.ToString());
            }
        }

        //tehtävä 3

        static void TestaaKortit()
        {
            KorttiPakka kortteja = new KorttiPakka();

            foreach (var item in kortteja.Kortit)
            {
                Console.WriteLine(item.ToString());
            }
        }


        // tehtävä 4

        static void TestaaArsenal()
        {

            Joukkue joukkue = new Joukkue {Nimi = "Arsenal\n", KotiKaupunki = "Lontoo\n" };

            foreach (var item in joukkue.Nimi)
            {
                Console.Write(item.ToString());
            }

            foreach (var item in joukkue.KotiKaupunki)
            {
                Console.Write(item.ToString());
            }

            List<Pelaaja> pelaajat = new List<Pelaaja>();

            pelaajat.Add(new Pelaaja() { Etunimi = "Petr", Sukunimi = "Cech", Ika = 31, Numero = 34 });
            pelaajat.Add(new Pelaaja() { Etunimi = "David", Sukunimi = "Ospina", Ika = 29, Numero = 13 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Kieran", Sukunimi = "Gibbs", Ika = 27, Numero = 3 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Nacho", Sukunimi = "Monreal", Ika = 30, Numero = 18 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Per", Sukunimi = "Mertesacker", Ika = 32, Numero = 4 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Shakodran", Sukunimi = "Mustafi", Ika = 23, Numero = 20 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Gabriel", Sukunimi = "Paulista", Ika = 26, Numero = 6 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Hector", Sukunimi = "Bellerin", Ika = 21, Numero = 24 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Laurent", Sukunimi = "Koscielny", Ika = 31, Numero = 6 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Aaron", Sukunimi = "Ramsey", Ika = 26, Numero = 8 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Granit", Sukunimi = "Xhaka", Ika = 24, Numero = 29 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Mesut", Sukunimi = "Özil", Ika = 28, Numero = 11 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Alex", Sukunimi = "Oxlade-Chamberlain", Ika = 23, Numero = 16 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Francis", Sukunimi = "Coquelin", Ika = 25, Numero = 34 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Santi", Sukunimi = "Cazorla", Ika = 32, Numero = 19 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Mohamed", Sukunimi = "Elneny", Ika = 24, Numero = 35 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Alexis", Sukunimi = "sanchez", Ika = 28, Numero = 7 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Alex", Sukunimi = "Iwobi", Ika = 20, Numero = 17 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Lucas", Sukunimi = "Perez", Ika = 28, Numero = 9 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Olivier", Sukunimi = "Giroud", Ika = 30, Numero = 12 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Danny", Sukunimi = "Welbeck", Ika = 26, Numero = 23 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Theo", Sukunimi = "Walcott", Ika = 27, Numero = 14 });
            pelaajat.Add(new Pelaaja() { Etunimi = "Jack", Sukunimi = "Wilshere", Ika = 25, Numero = 10 });

            // Listaa pelaajat
            Console.WriteLine();
            foreach (Pelaaja gunner in pelaajat)
            {
                Console.WriteLine(gunner);
            }

            //Lisaa pelaajan
            Console.WriteLine("\nListään paikalle 23 pelaaja numerolla 31 (23, \"31\")");
            pelaajat.Insert(23, new Pelaaja() { Etunimi = "Jeff", Sukunimi = "Reine-Adelaide", Ika = 20, Numero = 31 });

            Console.WriteLine();
            foreach (Pelaaja gunner in pelaajat)
            {
                Console.WriteLine(gunner);
            }

            // Poistaa pelaajan
            Console.WriteLine("\nPoistetaan paikalta 22 pelaaja numerolla 10 (21, \"10\")");
            pelaajat.Remove(new Pelaaja() { Etunimi = "Jack", Sukunimi = "Wilshere", Ika = 25, Numero = 10 });

            Console.WriteLine();
            foreach (Pelaaja gunner in pelaajat)
            {
                Console.WriteLine(gunner);
            }
        }
    }
}
