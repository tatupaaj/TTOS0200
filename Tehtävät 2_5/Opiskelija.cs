using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    public class Opiskelija

    {
        public string Nimi { get; set; }
        public string Osoite { get; set; }
        public string Opiskelijanumero { get; set; }


        public void Nayta()
        {
            Console.WriteLine("OPISKELIJA!");
            Console.WriteLine("Nimi: {0}", Nimi);
            Console.WriteLine("Opiskelijanumero: {0}", Opiskelijanumero);
            Console.WriteLine("Osoite: {0}", Osoite);
        }
    }
}
