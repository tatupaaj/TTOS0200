using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kulkuneuvo();
            //TestaaLompakkko();
            TestaaKosteus();
        }

        // tehtävä 1

        static void Kulkuneuvo()
        {
            Rengas tyre1 = new Rengas { Merkki = "Nokia", Malli = "Hakkapeliitta", RengasKoko = "205R16" };
            Kulkuneuvo kaara = new Kulkuneuvo { Nimi = "Porsche", Malli = "911" };
            Console.WriteLine("Luotu uusi pirssi {0} {1}", kaara.Nimi, kaara.Malli);
            kaara.LisaaRengas(tyre1);
            kaara.LisaaRengas(tyre1);
            kaara.LisaaRengas(tyre1);
            kaara.LisaaRengas(tyre1);
            Console.WriteLine(kaara.ToString());
        }


        static void TestaaLompakkko()
        {
            Lompakko sisalto = new Lompakko();

            Tavarat tavarat = new Tavarat { Raha = 300, Kortti = "töttöröö" };

            sisalto.LisaaTavara(tavarat);

            foreach (var item in sisalto.Lompsa)
            {
                Console.WriteLine("-Raha: " + item.Raha + "\n-Kortti: " + item.Kortti);
            }
        }


        static void TestaaKosteus()
        {
            Kosteus kosteus = new Kosteus();

            Console.WriteLine("Kosteus on nollassa kunnes annat arvoja");
            string retval1 = "";
            string retval2 = "";
            while (true)
            {
                Console.WriteLine("anna minimi arvo: ");
                retval1 = Console.ReadLine();
                Console.WriteLine("anna maximiarvo arvo: ");
                retval2 = Console.ReadLine();

                if (retval1 == "x" || retval2 == "x")
                    break;
                else
                {
                    kosteus.Min = Convert.ToInt32(retval1);
                    Console.WriteLine(kosteus.Tieto(kosteus.Min));

                    kosteus.Max = Convert.ToInt32(retval2);
                    Console.WriteLine(kosteus.YlinArvo(kosteus.Max));
                }
            }
        }
    }
}
