using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Ihminen : Nisakas
    {
        public int Paino { get; set; }
        public float Pituus { get; set; }
        public string Nimi { get; set; }

        public Ihminen()
        {
        }
        public override string Liiku()
        {
            Console.WriteLine("Liikun");
        }

        public void Kasva()
        {
            Ika++;
        }
    }
}
