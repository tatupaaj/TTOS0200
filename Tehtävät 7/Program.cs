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
            LukeeNimiä();
        }

        //tehtävä 1
        static void Merkkijonot()
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"D:\K8838\test.txt");
            while (true)
            {
                Console.WriteLine("Anna nimi, x kaitkaisee.");
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




        // tehtävä 2
        static void LukeeNimiä()
        {
            //string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                string[] texts = System.IO.File.ReadAllText(@"d:\K8838\temp.txt");
                string[] nimi = new string[texts.lenght];
                int n = 0;
                foreach (string text in texts) 
                {
                    nimi[n] = text;
                    n++;
                }
                System.Console.WriteLine("Contents of temp.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
