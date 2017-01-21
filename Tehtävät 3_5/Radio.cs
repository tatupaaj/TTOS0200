using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Radio
    {
        public bool OnkoPaalla { get; set; }
        int voimakkuus;
        public int Voimakkuus
        {
            get { return voimakkuus; }
            set
            {
                voimakkuus = value;
                if (value >= 0 || value <= 9)
                {
                    voimakkuus = value;
                }
            }
        }
        float taajuus;
        public float Taajuus
        {
            get { return taajuus; }
            set
            {
                taajuus = value;
                if (value >= 20000.0 || value <= 26000.0)
                {
                    taajuus = value;
                }
            }

        }
    }
}
