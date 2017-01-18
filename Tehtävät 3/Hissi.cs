using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Hissi
    {
        
         public int Kerros { get; set; }

         public string Nayta(int Kerros)
         {
             if (Kerros < 1)
             {
                 return "There is no lower level than 1";
             }
             else if (Kerros > 5)
             {
                 return "There is no higher level than 5";
             }
             else return "Elevator is on floor: " + Kerros;
         }
        /*
        private const int minfloor = 1;
        private const int maxfloor = 5;
        */
    }
}
