using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Shape
    {
        public string Nimi { get; set; }
        public abstract double PintaAla();
        public abstract double Piiri();
    }


    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double PintaAla()
        {
            return (double)Math.PI * Radius;
        }
        public override double Piiri()
        {
            return 2 * (double)Math.PI * Radius;
        }
        public override string ToString()
        {
            string n;
            n = string.Format("Circle Radius= {0} Pinta-ala= {1} Piiri= {2}", Radius, Math.Round(PintaAla(), 2), Math.Round(Piiri(), 2));
            return n;
        }
    }


    class Rectangle : Shape
    {
        public double Leveys { get; set; }
        public double Pituus { get; set; }
        public override double PintaAla()
        {
            return Leveys * Pituus;
        }
        public override double Piiri()
        {
            return 2 * (Leveys + Pituus);
        }
        public override string ToString()
        {
            string n;
            n = string.Format("Rectangle Leveys= {0} Pituus= {1} Pinta-ala= {2} Piiri= {3}", Leveys, Pituus, Math.Round(PintaAla(), 2), Math.Round(Piiri(), 2));
            return n;
        }
    }


    class Shapes
    {
        public List<Shape> ShapeList { get; set; }
    
        public Shapes()
        {
            ShapeList = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            ShapeList.Add(shape);
        }

        public override string ToString()
        {
            string n = "Shapes in shape cllection: ";
            foreach (Shape shape in ShapeList)
            {
                n += "\n\n" + shape.ToString();
            }
            return n;
        }
    }
}
