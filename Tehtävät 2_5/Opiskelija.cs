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


        public void Tulosta()
        {
            Console.WriteLine("OPISKELIJA!");
            Console.WriteLine("Nimi: {0}, opiskelijanumero: {1}", Nimi, Opiskelijanumero);
            Console.WriteLine("Osoite: {0}", Osoite);
        }

        public void VaihdaNimi()
        {
            Console.WriteLine("Anna uusi nimi: ");
            Nimi = Console.ReadLine();
        }

        public void VaihdaOsoite()
        {
            Console.WriteLine("Anna uusi osoite: ");
            Osoite = Console.ReadLine();
        }
    }
}
