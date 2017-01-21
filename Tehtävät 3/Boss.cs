using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävät_3
{
    class Boss : Työntekijät
    {
        public string Pomo { get; set; }
        public int Boonus { get; set; }

        public Boss()
        {

        }

        public Boss(string Name, string Profession, string Car, int Bonus)
            : base(Name,Profession)
        {
            Pomo = Car;
            Boonus = Bonus;
        }

        public void BossMethod()
        {
            Console.WriteLine("This method belongs to Boss!");
        }

        public override string ToString()
        {
            return base.ToString() + " "+ Pomo + " "+ Boonus;
        }
    }
}
