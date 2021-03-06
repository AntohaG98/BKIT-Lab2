﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{ public class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    public override double Area()
        {  return Height* Width;  }
        public override string ToString()
        {
            return $"Прямоугольник с высотой {Height} и шириной {Width} имеет площадь {Area()}" ;
 }
    }
}
