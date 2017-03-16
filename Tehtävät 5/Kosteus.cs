using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Kosteus
    {
       // private int min = 10;
       // private int max = 100;

        public int Min { get; set; }
        public int Max { get; set; }

        public string Tieto(int Min)
        {
            if (Min < 1)
            {
                return "alin kosteus on 1";
            }
            else if (Min > 10)
            {
                return "ylinkosteus on 10";
            }
            else return "Minimi arvo on: " + Min;
        }

        public string YlinArvo(int Max)
        {
            if (Min > Max)
            {
                return "Maximi arvo on: " + Min;
            }
            else if (Max > 10)
            {
                return "Ylinkosteus on 10";
            }
            else return "Maximi arvo on: " + Max;
        }

    }
}
