using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tehtävät_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Merkkijonot();
            //LukeeNimiä();
            Eriluvut();
            //Ohjelmat();
        }

        //tehtävä 1
        static void Merkkijonot()
        {
            try
            {
                List<string> nimet = new List<string>();
                System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"D:\K8838\test.txt");
                while (true)
                {
                    Console.WriteLine("Anna nimi, x lopettaa.");
                    string retval = Console.ReadLine();

                    if (retval == "x")
                        break;
                    else
                    {
                        outputFile.WriteLine(retval);
                    }
                }
                outputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        // tehtävä 2
        static void LukeeNimiä()
        {
            //string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                Console.WriteLine(System.IO.File.Exists(@"D:\K8838\temp.txt") ? "File exists." : "File does not exist.");
                if (System.IO.File.Exists(@"D:\K8838\temp.txt"))
                {
                    string[] lines = System.IO.File.ReadAllLines(@"D:\K8838\temp.txt");
                    Console.WriteLine("Yhteensä {0} riviä ja {1} nimeä", lines.Length, lines.Distinct().Count());
                    Array.Sort(lines);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //tehtävä 3

        static void Eriluvut()
        {
            try {
            int kokonaisluvut = 0;
            float reaaliluvut = 0.0F;
            string path = @"D:\K8838", joku;

            do
            {
                Console.WriteLine("Anna kokonaisluku tai reaaliluku, kaikki muu lopettaa");
                joku = Console.ReadLine();
                if (int.TryParse(joku, out kokonaisluvut))
                {
                    string intfile = path + @"\kokonaisluvut.txt";
                    System.IO.StreamWriter outputFile = new System.IO.StreamWriter(intfile, true);
                    outputFile.WriteLine(kokonaisluvut);
                    outputFile.Close();
                }
                else if (float.TryParse(joku, out reaaliluvut))
                {
                    string floafile = path + @"\reaaliluvut.txt";
                    System.IO.StreamWriter outputFile = new System.IO.StreamWriter(floafile, true);
                    outputFile.WriteLine(reaaliluvut);
                    outputFile.Close();
                }
            }
            while (float.TryParse(joku, out reaaliluvut) || int.TryParse(joku, out kokonaisluvut));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        // tehtävä 4
        static void Ohjelmat()
        {

        }
    }
}
