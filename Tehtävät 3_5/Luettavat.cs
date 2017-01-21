using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Luettavat : Tavarat
    {
        public string Genre { get; set; }
        public int SivuMaara { get; set; }

        public Luettavat()
        {
        }

        public Luettavat(string esine, string nimi, string tekija, string genre)
            : base(esine, nimi, tekija)
        {
            Genre = genre;
        }

        public void LuettavatMethod()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " " + Genre + " " + SivuMaara;
        }
    }
}
