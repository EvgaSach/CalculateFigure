using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFigure
{
    public class Triangle : Figure
    {
        public double AA { get; set; }
        public double BB { get; set; }
        public double CC { get; set; }
        public Triangle(double a, double b, double c)
        {
            AA = a;
            BB = b;
            CC = c;
        }
        public override double CalculateArea()
        {
            double p = (AA + BB + CC) / 2;
            double formul = p * (p - AA) * (p - BB) * (p - CC);
            Squere = Math.Pow(formul, 0.5);
            return Squere;
        }
        public void CheckTriangle()
        {
            Console.WriteLine("This method is working");
            if (Math.Pow(AA, 2) + Math.Pow(BB, 2) == Math.Pow(CC, 2))
            {
                Console.WriteLine("This is  right triangle.CC is biggest side");
            }
            else if
                (Math.Pow(AA, 2) + Math.Pow(CC, 2) == Math.Pow(BB, 2))
            {
                Console.WriteLine("This is  right triangle.BB is  biggest side");
            }
            else if (Math.Pow(BB, 2) + Math.Pow(CC, 2) == Math.Pow(AA, 2))
            {
                Console.WriteLine("This is  right triangle.AA is  biggest side");
            }
            else
            {
                Console.WriteLine("This is not right triangle");
            }
        }
    }
}
