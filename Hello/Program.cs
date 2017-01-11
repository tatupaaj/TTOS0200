
using System;

namespace Hello
{
    class Henkilo
    {
        public string Nimi { get; set; }// ominaisuudet isolla
        public int Ika { get; set; }

    }
    class Testi // substantiivejä ja yksikköjä
    {
        static void Main(string[] args)
        {
           // SayHello();
            ShowNames();
        }

        static void ShowNames()
        {
            // TODO
            // kysytään nimet
            string[] nimet = new string[5];
           
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine("Annan nimi: ");
                nimet[i] = Console.ReadLine();
            }
            // näytetään nimet
            Console.WriteLine("Annetut nimet olivat: ");
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine(nimet[i]);
            }
            // sortataan ja näytetään
            Console.WriteLine("Annetut nimet aakkosjarjestyksessa ovat: ");
            Array.Sort(nimet);
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine(nimet[i]);
            }
            // lopetus
            Console.WriteLine("Ohjelma suoritettu onnistuneesti");
        }

        static void SayHello()
        {
            // määritellään muuttuja
            string nimi = "Jack Rusell";
            // luodaan olio Henkilo-luokasta
            Henkilo hlo = new Henkilo();
            hlo.Ika = 42;
            hlo.Nimi = "Max Mickelson";
            // konsolille
            Console.WriteLine("Terve: {0} ikäsi on: {1}", hlo.Nimi, hlo.Ika); // kapselointi

            // pidetään sovelluksen ajoikkuna auki
            // Console.ReadLine(); : tätä ei kannata käyttää
        }
    }
}



