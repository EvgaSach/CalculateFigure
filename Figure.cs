using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFigure
{
    ///Абстрактный класс
    public abstract class Figure
    {
        //т.к данное свойство предпологается у всех фигур
        //поднимаю его в basicClass
        public double Squere { get; set; }
        
        public abstract double CalculateArea();

    }
}
