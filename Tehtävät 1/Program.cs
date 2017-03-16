using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävät_1


{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Numero();
            //2. Koulunumero();
            //3. Keskiarvo();
            //4. Ikanumero();
            //5. Aikamaarre();
            //6. Bensanmaara();
            //7. Karkaus();
            //8. Kokonaisluku();
            //9. Lukujensumma();
            //10. Parillinen();
            //11. Silmukka();
            //12. Kaanteinen();
            //13. Tyylipiste();
            //14. Arvosanat();
            //15. Puukuvio();
            //16. Arvaaja();
            //17. Kolmastaulukko();
            //18. Palindromi();
           // Hirsipuu();


        }

        // Tehtävä 1
        static void Numero()
        {
            int luku;
            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("yksi");
            }

            else if (luku == 2)
            {
                Console.WriteLine("kaksi");
            }

            else if (luku == 3)
            {
                Console.WriteLine("kolme");
            }
            else
            {
                Console.WriteLine("joku muu luku");
            }
        }

        // tehtävä 2
        static void Koulunumero()
        {
            int luku;
            Console.WriteLine("Anna pistemäärä: ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 0 || luku == 1)
            {
                Console.WriteLine("Koulunumero on: 0");
            }

            else if (luku == 2 || luku == 3)
            {
                Console.WriteLine("Koulunumero on: 1");
            }

            else if (luku == 4 || luku == 5)
            {
                Console.WriteLine("Koulunumero on: 2");
            }

            else if (luku == 6 || luku == 7)
            {
                Console.WriteLine("Koulunumero on: 3");
            }

            else if (luku == 8 || luku == 9)
            {
                Console.WriteLine("Koulunumero on: 4");
            }
            else if (luku == 10 || luku == 12)
            {
                Console.WriteLine("Koulunumero on: 5");
            }

        }

        // tehtävä 3
        static void Keskiarvo()
        {
            float luku1;
            float luku2;
            float luku3;
            Console.WriteLine("Anna kolme lukua: ");
            luku1 = float.Parse(Console.ReadLine());
            luku2 = float.Parse(Console.ReadLine());
            luku3 = float.Parse(Console.ReadLine());

            Console.WriteLine(luku1 + luku2 + luku3);
            Console.WriteLine((luku1 + luku2 + luku3) / 3);
        }

        //tehtävä 4
        static void Ikanumero()
        {
            int luku;
            Console.WriteLine("Anna ika: ");
            luku = int.Parse(Console.ReadLine());

            if (luku < 18)
            {
                Console.WriteLine("Alaikainen");
            }
            else if (luku >= 18 && luku <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
        }

        //tehtävä 5
        static void Aikamaarre()
        {
            int tun;
            int min;
            int sek;
            Console.WriteLine("Anna sekunnit: "); //string sek = aika.ToString("%s");
            sek = int.Parse(Console.ReadLine());

            tun = sek / 3600;
            sek = sek % 3600;
            min = sek / 60;
            sek = sek & 60;

            Console.Write("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tun + " tunti " + min + " minuutti " + sek + " sekuntti ");
        }

        //tehtävä 6
        static void Bensanmaara()
        {
            double kilometri;
            double kulutus;
            double kustannukset;
            double bensa = 0.0702;
            double raha = 1.595;
            Console.WriteLine("Anna matka: ");
            kilometri = double.Parse(Console.ReadLine());

            kulutus = kilometri * bensa;
            kustannukset = kulutus * raha;

            Console.Write("Bensaa kuluu: " + kulutus + " kustannukset: " + kustannukset);
        }


        //tehtävä 7
        static void Karkaus()
        {
            int vuosi;
            Console.WriteLine("Anna vuosi: ");
            vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 400 == 0)
                Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
            else if (vuosi % 100 == 0)
                Console.WriteLine("Vuosi {0} ei ole karkausvuosi", vuosi);
            else if (vuosi % 4 == 0)
                Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
            else
                Console.WriteLine("Vuosi {0} ei ole karkausvuosi", vuosi);
        }

        //tehtävä 8
        static void Kokonaisluku()
        {
            int luku1;
            Console.WriteLine("Anna eka luku: ");
            luku1 = int.Parse(Console.ReadLine());
            int luku2;
            Console.WriteLine("Anna toka luku: ");
            luku2 = int.Parse(Console.ReadLine());
            int luku3;
            Console.WriteLine("Anna kolmas luku: ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Suurin luku on: {0}", luku1);
            }
            else if (luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine("Suurin luku on: {0}", luku2);
            }
            else if (luku3 > luku1 && luku3 > luku2)
            {
                Console.WriteLine("Suurin luku on: {0}", luku3);
            }
        }

        //tehtävä 9
        static void Lukujensumma()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Anna luku: ");
                int luku;
                if (int.TryParse(Console.ReadLine(), out luku))
                {
                    if (luku == 0)
                        break;
                    sum += luku;
                }
            }
            Console.WriteLine("Lukujen summa on: " + sum);
        }

        //tehtävä 10
        static void Parillinen()
        {
            //int[] luvut;

            int[] luvut = new int[10];

            luvut[0] = 1;
            luvut[1] = 2;
            luvut[2] = 33;
            luvut[3] = 44;
            luvut[4] = 55;
            luvut[5] = 68;
            luvut[6] = 77;
            luvut[7] = 96;
            luvut[8] = 100;

            for (int i = 0; i < luvut.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(luvut[i] + " hep");
                }
            }

        }

        //tehtävä 11
        static void Silmukka()
        {
            int i, j, luku;
            Console.WriteLine("Anna luku: \n");
            luku = int.Parse(Console.ReadLine());
            for (i = 0; i <= luku; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        //tehtävä 12
        static void Kaanteinen()
        {
            int[] luvut = new int[5];

            Console.WriteLine("Anna luku: ");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luvut[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luvut[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luvut[4] = int.Parse(Console.ReadLine());

            for (int i = 4; i < luvut.Length; i++) Console.WriteLine("luvut ovat: " + luvut[4] + luvut[3] + luvut[2] + luvut[1] + luvut[0]);

        }

        //tehtävä 13
        static void Tyylipiste()
        {
            int[] luvut = new int[6];

            Console.WriteLine("Anna pisteet: ");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna pisteet: ");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna pisteet: ");
            luvut[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna pisteet: ");
            luvut[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna pisteet: ");
            luvut[4] = int.Parse(Console.ReadLine());

            luvut[5] = luvut[0] + luvut[1] + luvut[2] + luvut[3] + luvut[4];

            Console.WriteLine("Kokonaispisteet ovat: " + luvut[5]);
        }

        //tehtävä 14
        static void Arvosanat()
        {
            //input muuttujat
            int[] arvosanat = new int[5];
            int annettuArvo = 0;
            string annettuRivi = string.Empty;

            Console.WriteLine("Anna arvosana, ohjelma loppuu jos et anna mitaan");
            //while laittaa jotainmuuta kuin tyhjän.
            while ((annettuRivi = Console.ReadLine()) != string.Empty)
            {
                //inputArray ei ole enempää muuttujia, uudelleen kootaan se.
                if (annettuArvo == arvosanat.Length)
                {
                    Array.Resize<int>(ref arvosanat, arvosanat.Length + 5);
                }

                // Uusi laitettu arvo on laitettuna array :hin
                arvosanat[annettuArvo] = int.Parse(annettuRivi);
                annettuArvo++;
            }

            //Kaikki yksilölliset muuttujat lasketaan
            //special array. Index on numerot 0-5 välillä. Arvo on lasku arvosta.
            int[] laske = new int[6];
            for (int i = 0; i < annettuArvo; i++)
            {
                int laitettuNumero = arvosanat[i];
                laske[laitettuNumero]++;
            }

            Console.WriteLine("Arvosanat: ");

            //Laskee joakaisen numero 0-5 väliltä.
            for (int i = 0; i < 6; i++)
            {
                //nayttaa luvut, jotka on laitettu edes kerran
                if (laske[i] != 0)
                    Console.WriteLine("{0}: {1}", i, laske[i]);
            }

        }

        //tehtävä 15
        static void Puukuvio()
        {
            int luku;
            Console.WriteLine("Anna luku: ");
            luku = Int32.Parse(Console.ReadLine());
            int count = 1;

            for (int rivi = luku; rivi >= 1; rivi--)
            {

                for (int tila = rivi - 1; tila >= 1; tila--)
                {
                    Console.Write(" ");

                }
                for (int puu = 1; puu <= count; puu++)
                {
                    Console.Write("*");
                    Console.Write(" ");

                }
                count++;
                Console.WriteLine();
            }
            for (int jalka = 1; jalka <= 2; jalka++)
            {
                Console.Write("\n");
                Console.Write("*");
            }

        }

        //tehtävä 16
        static void Arvaaja()
        {
            int yhteensa = 1,
             pienet = 0,
             suuret = 0;
            int ranNum1,
                arvaa;

            string arvaaKohta;

            Random ranNumGen = new Random();
            ranNum1 = ranNumGen.Next(1, 100);

            Console.Write("Arvaa luku: ");
            arvaaKohta = Console.ReadLine();
            arvaa = Convert.ToInt16(arvaaKohta);

            while (arvaa != ranNum1)
            {
                while (arvaa < ranNum1)
                {
                    Console.WriteLine("Luku on suurempi.");
                    Console.Write("\nArvaa luku: ");
                    arvaaKohta = Console.ReadLine();
                    arvaa = Convert.ToInt16(arvaaKohta);
                    ++yhteensa;
                    ++pienet;
                }
                while (arvaa > ranNum1)
                {
                    Console.WriteLine("Luku on pienempi");
                    Console.Write("\nAnna luku: ");
                    arvaaKohta = Console.ReadLine();
                    arvaa = Convert.ToInt16(arvaaKohta);
                    ++yhteensa;
                    ++suuret;
                }
            }
            Console.WriteLine("\nHianoa! Arvasit luvun {0} kerralla.", yhteensa);
        }

        //tehtävä 17
        static void Kolmastaulukko()
        {
            int[] taulukko1 = new int[5];
            int[] taulukko2 = new int[5];
            int[] taulukko3 = new int[5];

            taulukko1[0] = 10;
            taulukko1[1] = 20;
            taulukko1[2] = 30;
            taulukko1[3] = 40;
            taulukko1[4] = 50;
            Console.Write("Luvut taulukossa 1 : ");
            for (int i = 0; i < taulukko1.Length; i++) Console.Write(taulukko1[i] + ",");

            taulukko2[0] = 5;
            taulukko2[1] = 15;
            taulukko2[2] = 25;
            taulukko2[3] = 35;
            taulukko2[4] = 45;
            Console.Write("\nLuvut taulukossa 2 : ");
            for (int i = 0; i < taulukko2.Length; i++) Console.Write(taulukko2[i] + ",");

            Console.Write("\nLuvut yhdistetyssä taulukossa :  ");
            for (int i = 0; i < taulukko3.Length; i++) Console.Write(taulukko2[i] + "," + taulukko1[i] + ",");
        }

        //tehtävä 18
        static void Palindromi()
        {
            string sana, revs = "";
            Console.WriteLine("Anna sana: ");
            sana = Console.ReadLine();
            for (int i = sana.Length - 1; i >= 0; i--) //Sanan käänne
            {
                Console.WriteLine(i);
                revs += sana[i].ToString();
            }
            if (revs == sana) // Tarkistaa, onko sana palindromi
            {
                Console.WriteLine("Sana on Palindromi!");
            }
            else
            {
                Console.WriteLine("Sana ei ole Palindromi!");
            }
        }

        // tehtävä 19
        static void Hirsipuu()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            string[] sanaPankki = { "Pepsi", "Terve", "tietokone", "puhelin" };
            string arvattavaSana = sanaPankki[random.Next(0, sanaPankki.Length)];
            string arvattavaSanaIso = arvattavaSana.ToUpper();

            StringBuilder displayToPlayer = new StringBuilder(arvattavaSana.Length);
            for (int i = 0; i < arvattavaSana.Length; i++)
                displayToPlayer.Append("_");

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            int lives = 5;
            bool won = false;
            int lettersRevealed = 0;

            string input;
            char arvaa;

            while (!won && lives > 0)
            {
                Console.WriteLine("Arvaa kirjain: ");

                input = Console.ReadLine().ToUpper();
                arvaa = input[0];

                if (correctGuesses.Contains(arvaa))
                {
                    Console.WriteLine("Olet jo kokesillut '{0}', ja se oli oikein", arvaa);
                    continue;
                }
                else if (incorrectGuesses.Contains(arvaa))
                {
                    Console.WriteLine("Olet jo kokeillut '{0}', ja se oli vaarin", arvaa);
                    continue;
                }

                if (arvattavaSanaIso.Contains(arvaa))
                {
                    correctGuesses.Add(arvaa);

                    for (int i = 0; i < arvattavaSana.Length; i++)
                    {
                        if (arvattavaSanaIso[i] == arvaa)
                        {
                            displayToPlayer[i] = arvattavaSana[i];
                            lettersRevealed++;
                        }
                    }

                    if (lettersRevealed == arvattavaSana.Length)
                        won = true;
                }
                else
                {
                    incorrectGuesses.Add(arvaa);
                    Console.WriteLine("Ei ole kirjainta '{0}'", arvaa);
                    lives--;
                }
                Console.WriteLine(displayToPlayer.ToString());
            }

            if (won)
                Console.WriteLine("Voitit!");
            else
                Console.WriteLine("Hävisit! Sana oli '{0}'", arvattavaSana);
        }
    }
}
