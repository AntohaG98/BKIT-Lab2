using System;
namespace Lab2
{  class Program
    {  static void PrintFigure(Figure figure) 
           {  var num = figure.Area();
            Console.WriteLine(num);
            figure.Print(); }
        static void Main(string[] args)
        {
            var rect = new Rectangle(12, 34);
            var sqr = new Square(30);
            var crl = new Circle(5.5);
            rect.Print();
            sqr.Print();
            crl.Print();
            Console.WriteLine();
            PrintFigure(rect);
            PrintFigure(sqr);
            PrintFigure(crl);
        }
    }
}