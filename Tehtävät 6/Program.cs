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
            Dictionary<int, Pelaaja> pelaajat = new Dictionary<int, Pelaaja>();

            Joukkue arsenal = new Joukkue {Nimi = "Arsenal", KotiKaupunki = "Lontoo" };
            Pelaaja gunner = new Pelaaja { Etunimi = "Petr", Sukunimi = "Cech", Ika = 31, Numero = 34 };
            Pelaaja gunner1 = new Pelaaja { Etunimi = "David", Sukunimi = "Ospina", Ika = 29, Numero = 13 };
            Pelaaja gunner2 = new Pelaaja { Etunimi = "Kieran", Sukunimi = "Gibbs", Ika = 27, Numero = 3 };
            Pelaaja gunner3 = new Pelaaja { Etunimi = "Nacho", Sukunimi = "Monreal", Ika = 30, Numero = 18 };
            Pelaaja gunner4 = new Pelaaja { Etunimi = "Per", Sukunimi = "Mertesacker", Ika = 32, Numero = 4 };
            Pelaaja gunner5 = new Pelaaja { Etunimi = "Shakodran", Sukunimi = "Mustafi", Ika = 23, Numero = 20 };
            Pelaaja gunner6 = new Pelaaja { Etunimi = "Gabriel", Sukunimi = "Paulista", Ika = 26, Numero = 6 };
            Pelaaja gunner7 = new Pelaaja { Etunimi = "Hector", Sukunimi = "Bellerin", Ika = 21, Numero = 24 };
            Pelaaja gunner8 = new Pelaaja { Etunimi = "Laurent", Sukunimi = "Koscielny", Ika = 31, Numero = 6 };
            Pelaaja gunner9 = new Pelaaja { Etunimi = "Aaron", Sukunimi = "Ramsey", Ika = 26, Numero = 8 };
            Pelaaja gunner10 = new Pelaaja { Etunimi = "Granit", Sukunimi = "Xhaka", Ika = 24, Numero = 29 };
            Pelaaja gunner11 = new Pelaaja { Etunimi = "Mesut", Sukunimi = "Özil", Ika = 28, Numero = 11 };
            Pelaaja gunner12 = new Pelaaja { Etunimi = "Alex", Sukunimi = "Oxlade-Chamberlain", Ika = 23, Numero = 16 };
            Pelaaja gunner13 = new Pelaaja { Etunimi = "Francis", Sukunimi = "Coquelin", Ika = 25, Numero = 34 };
            Pelaaja gunner14 = new Pelaaja { Etunimi = "Santi", Sukunimi = "Cazorla", Ika = 32, Numero = 19 };
            Pelaaja gunner15 = new Pelaaja { Etunimi = "Mohamed", Sukunimi = "Elneny", Ika = 24, Numero = 35 };
            Pelaaja gunner16 = new Pelaaja { Etunimi = "Alexis", Sukunimi = "sanchez", Ika = 28, Numero = 7 };
            Pelaaja gunner17 = new Pelaaja { Etunimi = "Alex", Sukunimi = "Iwobi", Ika = 20, Numero = 17 };
            Pelaaja gunner18 = new Pelaaja { Etunimi = "Lucas", Sukunimi = "Perez", Ika = 28, Numero = 9 };
            Pelaaja gunner19 = new Pelaaja { Etunimi = "Olivier", Sukunimi = "Giroud", Ika = 30, Numero = 12 };
            Pelaaja gunner20 = new Pelaaja { Etunimi = "Danny", Sukunimi = "Welbeck", Ika = 26, Numero = 23 };
            Pelaaja gunner21 = new Pelaaja { Etunimi = "Theo", Sukunimi = "Walcott", Ika = 27, Numero = 14 };
            Pelaaja gunner22 = new Pelaaja { Etunimi = "Jack", Sukunimi = "Wilshere", Ika = 25, Numero = 10 };


            pelaajat.Add(gunner.Numero, gunner);
            pelaajat.Add(gunner1.Numero, gunner1);



            arsenal.LisaaPelaaja(gunner);
            arsenal.LisaaPelaaja(gunner1);
            arsenal.LisaaPelaaja(gunner2);
            arsenal.LisaaPelaaja(gunner3);
            arsenal.LisaaPelaaja(gunner4);
            arsenal.LisaaPelaaja(gunner5);
            arsenal.LisaaPelaaja(gunner6);
            arsenal.LisaaPelaaja(gunner7);
            arsenal.LisaaPelaaja(gunner8);
            arsenal.LisaaPelaaja(gunner9);
            arsenal.LisaaPelaaja(gunner10);
            arsenal.LisaaPelaaja(gunner11);
            arsenal.LisaaPelaaja(gunner12);
            arsenal.LisaaPelaaja(gunner13);
            arsenal.LisaaPelaaja(gunner14);
            arsenal.LisaaPelaaja(gunner15);
            arsenal.LisaaPelaaja(gunner16);
            arsenal.LisaaPelaaja(gunner17);
            arsenal.LisaaPelaaja(gunner18);
            arsenal.LisaaPelaaja(gunner19);
            arsenal.LisaaPelaaja(gunner20);
            arsenal.LisaaPelaaja(gunner21);
            arsenal.LisaaPelaaja(gunner22);

            foreach (var item in arsenal.PelaajaLista)
            {
                Console.WriteLine("{0}", item.ToString());
            }

            int tmp = Console.Read();
            Console.Write("Pelaaja numerolla: {0} on pelaaja: {1}", tmp, pelaajat[tmp].Numero);
        }
    }
}