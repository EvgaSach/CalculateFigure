using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFigure
{
    //класс-предусматривающий определение типа фигуры 
    //в зависимости от параметров передоваемых в метод вычесления площяди
    public  class RandomFigure:Figure
    {
        public RandomFigure() { }
        public double AA { get; set; }
        public double BB { get; set; }
        //public double CC { get; set; }
        //public double DD { get; set; }
        public override double CalculateArea()
        {
            return 0.0;//если пользователь создал фигуру.но не передал ее координаты
        }

        public double CalculateArea(double AA)
        {
            Squere = Math.Pow(AA, 2);
            Console.WriteLine($"площадь данного квадрата : {Squere} (см.кв)");
            return Squere;
        }

        public double CalculateArea(double AA,double BB)       
        {
            Squere = AA*BB;
            Console.WriteLine($"Площадь данного прямоугольника : {Squere} (см.кв)");
            return Squere;
        }
        /// <summary>
        /// хотелось бы получить обратную связь о правильности-коректности метода
        /// вычесления площади триугольника в данном классе
        /// </summary>
        
       
        public double CalculateArea(double AA,double BB,double CC)
        {
            Triangle rf3 = new Triangle(AA, BB, CC);
            Squere=rf3.CalculateArea();
            rf3.CheckTriangle();
            return Squere;

        }
        
    }
}
