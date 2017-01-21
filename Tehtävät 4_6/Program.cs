using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Levyt levyt1 = new Levyt();
            levyt1.Esine = "CD";
            levyt1.Nimi = "Amon Amath - Jomsviking";
            levyt1.Hinta = 25;
            levyt1.Tekija = "Sony music";
            levyt1.Pituus = 45;
            Console.WriteLine(levyt1.ToString());

            Levyt levyt2 = new Levyt();
            levyt2.Esine = "DVD";
            levyt2.Nimi = "The Hobbit";
            levyt2.Hinta = 15;
            levyt2.Tekija = "Warner Bros.";
            levyt2.Pituus = 169;
            Console.WriteLine(levyt2.ToString());

            levyt1.LevyMethod();
            levyt2.LevyMethod();

        }
    }
}
