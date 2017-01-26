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
            TestaaKorttipeli();
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
        static void TestaaKorttipeli()
        {

        }
    }
}
