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
            Elintarvike elintarvike1 = new Elintarvike { Ruoka = "Paisti", Juoma = "Maito" };
           
            Jaakaappi jaakaappi = new Jaakaappi { Nimi = "Kallenjaakaappi", Valmistaja = "Samsung" };
            Console.WriteLine("Nyt on {0} hommattu {1}", jaakaappi.Nimi, jaakaappi.Valmistaja);
            jaakaappi.LisääElintarvike(elintarvike1);
            jaakaappi.LisääElintarvike(elintarvike1);
            jaakaappi.LisääElintarvike(elintarvike1);
            jaakaappi.LisääElintarvike(elintarvike1);
            Console.WriteLine(jaakaappi.ToString());
        }
    }
}
