using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävät_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Noppa();
        }

        //tehtävä 1
        static void Noppa()
        {
            Random r = new Random();

            int sum = 0;

            for (int i = 0; i < 1; i++)
            {
                var roll = r.Next(1, 7);
                sum += roll;
            }
            Console.WriteLine("Noppa, testi heitto: {0}\n", sum);
            

        }
    }
}
