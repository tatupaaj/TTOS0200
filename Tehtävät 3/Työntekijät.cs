using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävät_3
{
    class Työntekijät
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Työntekijät()
        {
        }

        public Työntekijät(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name + " " + Profession + " " + Salary + " ";
        }
    }
}
