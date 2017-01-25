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
            TestaaHenkiloRekisteri();
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
    }
}
