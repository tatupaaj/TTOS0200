﻿using System;
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
            Noppa();
        }

        //tehtävä 1
        static void Noppa()
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

    }
}
