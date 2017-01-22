using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvoja();
        }


        //tehtävä 4
        static void Kulkuneuvoja()
        {
            Pyora pyora1 = new Pyora();
            pyora1.Valine = "Pyora";
            pyora1.Nimi = "JOPO";
            pyora1.Malli = "Katu";
            pyora1.VuosiMalli = 2015;
            pyora1.Vari = "Musta";
            pyora1.Vaihde = true;
            if(pyora1.Vaihde)
            {
                pyora1.VaihdeMalli = "monivaihde";
            }
            Console.WriteLine(pyora1.ToString());

            Pyora pyora2 = new Pyora();
            pyora2.Valine = "Pyora";
            pyora2.Nimi = "Tunturi";
            pyora2.Malli = "Maasto";
            pyora2.VuosiMalli = 1995;
            pyora2.Vari = "Sininen";
            pyora2.Vaihde = true;
            if (pyora2.Vaihde)
            {
                pyora2.VaihdeMalli = "monivaihde";
            }
            Console.WriteLine(pyora2.ToString());

            Vene vene1 = new Vene();
            vene1.Valine = "Vene";
            vene1.Nimi = "Yamaha";
            vene1.Malli = "Model 1000";
            vene1.Millane = "Moottorivene";
            vene1.Istuin = 4;
            Console.WriteLine(vene1.ToString());

            pyora1.PyoraMethod();
            pyora1.KulkuneuvoMethod();

            pyora2.PyoraMethod();
            pyora2.KulkuneuvoMethod();

            vene1.VeneMethod();
            vene1.KulkuneuvoMethod();
        }
    }
}
