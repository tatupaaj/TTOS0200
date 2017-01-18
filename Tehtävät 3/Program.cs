using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hissi();
            //2. Vahvistin();
            Tietoja();
        }

        //tehtävä 1
        static void Hissi()
        {
            Hissi hissi = new Hissi();

            Console.WriteLine("Elevator is now on floor: 1");
            string retval = "";
            while (true)
            {
                Console.WriteLine("give a new number: ");
                retval = Console.ReadLine();
                if (retval == "x")
                    break;
                else
                {
                    hissi.Kerros = Convert.ToInt32(retval);
                    Console.WriteLine(hissi.Nayta(hissi.Kerros));
                }
            }
        }

        //tehtävä 2
        static void Vahvistin()
        {
            Vahvistin vahvistin = new Vahvistin();

            Console.WriteLine("Give a new volume value (0-100): ");
            string retval = "";
            while (true)
            {
                Console.WriteLine("Give a new volume value (0-100): ");
                retval = Console.ReadLine();
                if (retval == "T")
                    break;
                else
                {
                    vahvistin.Volume = Convert.ToInt32(retval);
                    Console.WriteLine(vahvistin.Volume);
                }
            }
        }

        // tehtävä 3

        static void Tietoja()
        {

        }
}
}
