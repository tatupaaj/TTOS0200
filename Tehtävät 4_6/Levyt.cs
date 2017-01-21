using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Levyt : Tavarat
    {
        public float Pituus { get; set; }
        public int IkaRaja { get; set; }

        public Levyt()
        {
        }

        public Levyt(string esine, string nimi, string tekija)
            : base(esine, nimi, tekija)
        {

        }

        public void LevyMethod()
        {
            Console.WriteLine("Tama metodi kuuluu CD:lle");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Pituus + " " + IkaRaja;
        }
    }
}