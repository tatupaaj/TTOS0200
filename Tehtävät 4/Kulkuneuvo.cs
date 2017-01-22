using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Kulkuneuvo
    {
        public string Valine { get; set; }
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int VuosiMalli { get; set; }
        public string Vari { get; set; }

        public Kulkuneuvo()
        {
        }

        public Kulkuneuvo(string valine, string nimi, string malli)
        {
            Valine = valine;
            Nimi = nimi;
            Malli = malli;
        }

        public void KulkuneuvoMethod()
        {
        }

        public override string ToString()
        {
            return Valine + " " + Nimi + " " + Malli + " " + VuosiMalli + " " + Vari;
        }
    }
}
