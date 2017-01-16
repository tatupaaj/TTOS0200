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
           //tehtävä1 TestaaKiuas();
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

     }
}
