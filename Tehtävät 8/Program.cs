using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using JAMK.IT;

namespace Tehtävät_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                //Noppa();
                //Ostoskarry();
                //Kalastaminen();
                TestaaShape();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //tehtävä 1
        static void Noppa()
        {
            try
            { 
            var sw = new Stopwatch();
            List<float> Numerolista = new List<float>();
            Noppa noppa = new Noppa();
            Console.Write("Kuinka monta kertaa haluat heittää noppaa?: ");
            string Valinta = Console.ReadLine();
            double OnNumero;
            double LaskeNumerot = 0;
            bool OnkoNumero;
            while (true)
            {
                if (OnkoNumero = double.TryParse(Valinta, out OnNumero))
                {
                    break;
                }
                else { Console.WriteLine("Et valinnut numeroa, anna numero : "); }
            }
            sw.Start();
            for (int i = 0; i < OnNumero; i++)
            {
                Numerolista.Add(noppa.NoppaLuku);
            }
            for (int i = 0; i < Numerolista.Count; i++)
            {
                LaskeNumerot = LaskeNumerot + Numerolista[i];
            }
            double KeskiArvo = LaskeNumerot / Numerolista.Count;
            Console.WriteLine("Noppaa on heitetty {0} kertaa, keskiarvo on: {1}", OnNumero, KeskiArvo);
            Numerolista.Sort();
            

            var dictionary = new Dictionary<int, int>();
            int numero = 0;
            for (int i = 0; i < Numerolista.Count; i++)
            {
                numero = Convert.ToInt32(Math.Ceiling(Numerolista[i]));
                dictionary.Add(i, numero);
            }
            Dictionary<int, int> EritteleNumerot = new Dictionary<int, int>();
            foreach (int i in dictionary.Values)
                if (EritteleNumerot.ContainsKey(i))
                    EritteleNumerot[i]++;
                else
                    EritteleNumerot[i] = 1;
            foreach (KeyValuePair<int, int> kvp in EritteleNumerot)
                Console.WriteLine("- Numeroa {0} on heitetty: {1}", kvp.Key, kvp.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        // tehtävä 2
        static void Ostoskarry()
        {
            try
            {
            Products products = new Products();

            Product tuote = new Product { Nimi = "Pahkinoita ", Hinta = "2,50 e" };
            Product tuote1 = new Product { Nimi = "Juusto ", Hinta = "4,00 e\n" };

            products.NewProduct(tuote);
            products.NewProduct(tuote1);

            Console.WriteLine("All products in collection: ");
            foreach (Product product in products.ProductList)
            {
                Console.WriteLine("{0}", product.ToString());
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // tehtävä 3
        static void Kalastaminen()
        {
            try
            {
            Kala kala = new Kala("Hauki", 60, 2.0);
            Kalastaja kalastaja = new Kalastaja("Kirsi Kernel", "040 1234567");
            Kalapaikka kalapaikka = new Kalapaikka("Palokkajarvi", "Jyvaskyla");

            Console.Write(kala.Laji, kala.Pituus, kala.Paino);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // tehtävä 4
        static void TestaaShape()
        {
            try
            {
                Circle circle1 = new Circle { Radius = 3.245 };
                Circle circle2 = new Circle { Radius = 7.745 };
                Circle circle3 = new Circle { Radius = 5.245 };
                Rectangle rectangle1 = new Rectangle { Leveys = 2.34, Pituus = 4.623 };
                Rectangle rectangle2 = new Rectangle { Leveys = 10.34, Pituus = 2.34 };
                Rectangle rectangle3 = new Rectangle { Leveys = 5.23, Pituus = 7.23 };
                Shapes shapes = new Shapes();
                shapes.AddShape(circle1);
                shapes.AddShape(circle2);
                shapes.AddShape(circle3);
                shapes.AddShape(rectangle1);
                shapes.AddShape(rectangle2);
                shapes.AddShape(rectangle3);


                Console.WriteLine(shapes.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
