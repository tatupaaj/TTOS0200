using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Vene : Kulkuneuvo
    {
        public string Millane { get; set; }
        public int Istuin { get; set; }

        public Vene()
        {
        }

        public Vene(string valine, string nimi, string malli, string millane)
            : base(valine, nimi, malli)
        {
            Millane = millane;
        }

        public void VeneMethod()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " " + Millane + " " + Istuin;
        }
    }
}
