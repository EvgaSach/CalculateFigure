using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFigure
{
    //для возможности определения типа фигуры  пользователем в Rantime
    public class UserDefinedFigure : Figure
    {
        public double aa { get; set; }
        public double bb { get; set; }
        public double hh { get; set; }
        public int FigureType { get; set; }
        public UserDefinedFigure() { }//конструктор по умолчанию

        public int DefinefigureType()//метод для задания пользователем типа фигуры
        {
            Console.Write("Введите пожалуйста индекс типа фигуры расчет которой вы хотите произвести n/информация об индексах типов:");
            Console.WriteLine("\n 1-трапеция \n 2-квадрат  \n 3-прямоугольник  \n 4-триугольник \n " +
                "Внимание,данный метод находиться в доработки,используйте запятую в качестве раздилителя \n-пример введения" +
                "\n четыре с половинной вводить как -4,5");//2-3-4-in developing
            FigureType = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Вы выбрали тип фигуры:-{FigureType}");
            return FigureType;

        }

        public override double CalculateArea()
        {
            FigureType = DefinefigureType();
            if (FigureType == 1)
            {
                CalculateTrapezoid();
            }
            else if (FigureType == 2)
            {
                return Math.Pow(2, 2);//in developing
            }

            return Squere;
        }

        public double CalculateTrapezoid()
        {
            Console.WriteLine("EnterA:");
            aa = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            bb = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter HH:");
            hh = Double.Parse(Console.ReadLine());
            Squere = (aa + bb) / 2 * hh;
            Console.WriteLine($"Площадь данной фигуры -{Squere}");
            return Squere;
        }



    }
}
