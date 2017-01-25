using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
   abstract class Nisakas
    {
        public int Ika { get; set; }
        public string Liiku { get; set; }

        public Nisakas()
        {
        }

        public Nisakas(string liiku)
        {
            Liiku = liiku;
        }

        public void Liike()
        {
            Console.WriteLine("Liike");
        }

        public abstract void Jotain(); 
    }
}
