using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFigure
{
    
        public class Circle : Figure
        {
            public double Radius { get; set; }
            public Circle(double r)
            {
                Radius = r;
            
            }
            public override double CalculateArea()
            {
                Squere = Math.PI * (Radius * Radius);
                return Squere;
            }
        }
}
