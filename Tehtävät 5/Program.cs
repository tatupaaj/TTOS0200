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
            Kulkuneuvo();
        }

        // tehtävä 1

        static void Kulkuneuvo()
        {
            Rengas tyre1 = new Rengas { Valmistaja = "Nokia", Malli = "Hakkapeliitta", Rengaskoko = "205R16" };
            Kulkuneuvo kaara = new Kulkuneuvo { Nimi = "Porsche", Malli = "911" };
            Console.WriteLine("Luotu uusi pirssi {0} {1}", kaara.Nimi, kaara.Malli);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            Console.WriteLine(kaara.ToString());
        }
    }
}
