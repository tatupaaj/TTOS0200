using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Tehtävät_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ihminen ihminen = new Ihminen();
            ihminen.Nimi = "Tollo";
            ihminen.Ika = 20;
            ihminen.Jotain();

            Aikuinen aikuinen = new Aikuinen();
            aikuinen.Nimi = "Pollo";
            aikuinen.Ika = 30;
            aikuinen.Jotain();

            Vauva vauva = new Vauva();
            vauva.Nimi = "Rodler";
            vauva.Ika = 1;
            vauva.Jotain();
        }
    }
}
