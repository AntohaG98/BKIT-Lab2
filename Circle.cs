using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI* Radius * Radius;
        }
        public override string ToString()
        {
            return $"Круг с радиусом {Radius} имеет площадь {Area()}";
        }
    }
}

