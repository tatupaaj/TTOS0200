using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaRadio();
        }

        //tehtävä 5
        static void TestaaRadio()
        {
            while (true)
            {
            string paallaVaiEi;
            Radio radio = new Radio();
            Console.WriteLine("Laita radio paalle? on / off : ");
            paallaVaiEi = Console.ReadLine();    
            radio.OnkoPaalla = true;
            switch (paallaVaiEi)
                {
                    case "on":
                        radio.OnkoPaalla = true;
                        break;
                    case "off":
                        radio.OnkoPaalla = false;
                        break;
                    default:
                        Console.WriteLine("Kyseista valintaa ei ole");
                        break;
                }
                if (paallaVaiEi == "off")
                {
                    Console.WriteLine("Radio on pois paalta");
                    break;
                }
                if (radio.OnkoPaalla == true)
                {
                    Console.WriteLine("Aseta taajuus valilta 2000.0 - 26000.0 : ");
                    radio.Taajuus = float.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);

                    Console.WriteLine("Aseta aanen voimakkuus 1-9 : ");
                    radio.Voimakkuus = int.Parse(Console.ReadLine());

                    Console.WriteLine("Radio on paalla: " + radio.OnkoPaalla);
                    Console.WriteLine("Valitse taajuus: " + radio.Taajuus);
                    Console.WriteLine("Aanen voimakkuus: " + radio.Voimakkuus);
                    break;
                }
                else
                {
                    Console.WriteLine("Radio on pois paalta");
                    break;
                }

           }
        }
    }
}
