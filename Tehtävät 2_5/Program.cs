﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_2_5
{
   
    class Opiskelija
    {
        static void Main(string[] args)
        {
        Opiskelija[] opiskelija = new Opiskelija[5];

            for (int i = 0; i < 5; i++)
            {
                opiskelija[i] = new Opiskelija();
            }

            opiskelija[0].Nimi = "Joku1";
            opiskelija[0].Opiskelijanumero = "K8200";
            opiskelija[0].Osoite = "Niksi 52";

            opiskelija[1].Nimi = "Joku2";
            opiskelija[1].Opiskelijanumero = "K8181";
            opiskelija[1].Osoite = "Miksi 5";

            opiskelija[2].Nimi = "Joku3";
            opiskelija[2].Opiskelijanumero = "K8800";
            opiskelija[2].Osoite = "Pallokatu 2";

            opiskelija[3].Nimi = "Joku4";
            opiskelija[3].Opiskelijanumero = "K5000";
            opiskelija[3].Osoite = "pöllökuja 10";

            opiskelija[4].Nimi = "Joku5";
            opiskelija[4].Opiskelijanumero = "K5252";
            opiskelija[4].Osoite = "Jyväskyläkatu 1";

            Console.Clear();
            for (int i = 0; i < 5; i++)
            { opiskelija[i].Tulosta(); }

            Console.WriteLine("Minkä opiskelijan tietoja muutetaan? (0-4)");
            int muutos = int.Parse(Console.ReadLine());

            opiskelija[muutos].VaihdaNimi();
            opiskelija[muutos].VaihdaOsoite();

            opiskelija[muutos].Tulosta();

            Console.WriteLine("Tiedot päivitetty!");
            opiskelija[muutos].Tulosta();
        }
    }
}

