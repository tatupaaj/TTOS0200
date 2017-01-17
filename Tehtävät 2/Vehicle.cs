using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        public string Name { get; set; }

        int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (!(value >= 0 && value <= 200))
                    speed = value;
                else
                    speed = 0;
            }
        }

        int tyres;
        public int Tyres
        {
            get
            {
                return tyres;
            }
            set
            {
                if (!(value >= 4 && value <= 4))
                    tyres = 4;
                else
                    tyres = value;
            }
        }

        public Vehicle (string name, int vechileSpeed, int tires)
        {
            if (!(speed >= 0 && speed <= 200))
                vechileSpeed = 0;

            if (tyres >= 4 && tyres <= 4)
                tires = 4;

            speed = vechileSpeed;
            tyres = tires;
            Name = name;
        }

        public void PrintData()
        {
            Console.WriteLine("Vechile: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        public override string ToString()
        {
            string s = Name + ", " + Speed + ", " + Tyres;
            return "";
        }
    }
}
