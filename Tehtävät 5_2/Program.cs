using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jaakaappi jaakaappi = new Jaakaappi();

            Elintarvike elintarvike1 = new Elintarvike { Ruoka = "Paisti", Juoma = "Maito"};
            Elintarvike elintarvike2 = new Elintarvike { Ruoka = "Hernerokka", Juoma = "Maito" };

            jaakaappi.LisaaElinTarvike(elintarvike1);
            jaakaappi.LisaaElinTarvike(elintarvike2);


            Console.WriteLine("Jaakaapissa");
            foreach (Elintarvike t in jaakaappi.ElinTarvike)
            {
                Console.WriteLine(t.Ruoka, t.Juoma);
                Console.WriteLine(t.Ruoka, t.Juoma);
            }

            Console.WriteLine("Paisti on homeessa");
            jaakaappi.PoistaElinTarvike(elintarvike2);

            Console.WriteLine("\nJaakaapissa");
            foreach (Elintarvike t in jaakaappi.ElinTarvike)
            {
                Console.WriteLine(t.Ruoka, t.Juoma);
            }
        }
    }
}
