using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT; // helpottaa meidän luokkien löytämistä

namespace Tehtävät_2
{
   class Program
    {
        static void Main(string[] arg)
        {
            //TestaaKiuas();
            //VehiclenToiminta();
            //TestaaPesukone();
            TestaaTV();
        }

        // tehtävä 1 kiuas luokan testaus
        static void TestaaKiuas()
        {
            // luodaan kiuas olio
            Kiuas kiuas = new JAMK.IT.Kiuas();
            // pistetään kiuas lämpenemään ja asetetaan lampöä ja kosteutta
            kiuas.OnkoPaalla = true;
            kiuas.Lampotila = 90;
            kiuas.Kosteus = 50;
            // naytetaan konsolilla
            Console.WriteLine("kiuas on päällä {0}", kiuas.OnkoPaalla);
            Console.WriteLine("kiuakaan lämpötila {0}", kiuas.Lampotila);
            Console.WriteLine("kiukaan kosteus {0}", kiuas.Kosteus);
            // mitä tapahtuu jos kosteus on yli rajojen
            kiuas.Kosteus = 101;
            Console.WriteLine("kiukaan kosteus {0}", kiuas.Kosteus);
        }

        //tehtävä 4
        static void VehiclenToiminta()
        {
            Vehicle vehicle0 = new Vehicle("Volvo", 100, 4);
            Vehicle vehicle1 = new Vehicle("Wolswagen", 120, 4);
            Vehicle vehicle2 = new Vehicle("Ford", 150, 4);
            Vehicle vehicle3 = new Vehicle("Mersu", 200, 4);

            vehicle0.PrintData();
            vehicle1.PrintData();
            vehicle2.PrintData();
            vehicle3.PrintData();

            vehicle0.ToString();
            vehicle1.ToString();
            vehicle2.ToString();
            vehicle3.ToString();
        }  


        static void TestaaPesukone()
        {
            Pesukone pesukone = new Pesukone();
            pesukone.OnkoPaalla = true;
            pesukone.Pesuaste = 40;

            Console.WriteLine("Pesukone on paalla {0}", pesukone.OnkoPaalla);
            Console.WriteLine("Pesuaste: {0}", pesukone.Pesuaste);
        }

        static void TestaaTV()
        {
            TV tv = new TV();
            tv.OnkoPaalla = true;
            tv.Kanava = 7;

            Console.WriteLine("Onko TV päällä {0}", tv.OnkoPaalla);
            Console.WriteLine("Mikä Kanava: {0}", tv.Kanava);
        }
     }
}
