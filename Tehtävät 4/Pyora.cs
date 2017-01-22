using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Pyora : Kulkuneuvo
    {
        public bool Vaihde { get; set; }
        public string VaihdeMalli { get; set; }

        public Pyora()
        {
        }

        public Pyora(string valine, string nimi, string malli, string vaihdemalli)
            : base(valine, nimi, malli)
        {
            VaihdeMalli = vaihdemalli;
        }

        public void PyoraMethod()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " " + Vaihde + " " + VaihdeMalli;
        }
    }
}
