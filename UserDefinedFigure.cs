﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFigure
{
    //для возможности определения типа фигуры  пользователем в Rantime
    public class UserDefinedFigure : Figure
    {
        public double aa { get; set; }//сторона
        public double bb { get; set; }//сторона
        public double hh { get; set; }//высота
        public double RR { get; set; }//для правильного многоугольника радиус описанной окружности
        public double alfa { get; set; }//угол правильного многоугольника
       
        public int FigureType { get; set; }
        public UserDefinedFigure() { }//конструктор по умолчанию

        public int DefinefigureType()//метод для задания пользователем типа фигуры
        {
            Console.Write("Введите пожалуйста индекс типа фигуры расчет которой вы хотите произвести n/информация об индексах типов:");
            Console.WriteLine("\n 1-равнобежренная трапеция \n 2- правильный паралелограм  \n 3-ромб  \n 4-правильный многоугольник");
                
            FigureType = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Вы выбрали тип фигуры : {FigureType}");
            return FigureType;

        }

        public override double CalculateArea()
        {
            Console.WriteLine("Внимание,данный метод находиться в доработки,используйте запятую в качестве раздилителя \n-пример введения" +
                "\n четыре с половинной вводить как -4,5");
            FigureType = DefinefigureType();
            if (FigureType == 1)
            {
                CalculateTrapezoidSquere();
            }
            else if (FigureType == 2)
            {
                CalculateTrapezoidSquere();//для паралелограма так же действительна данная формула
            }
            else if(FigureType==3)
            {
                CalculateRombSquere();
            }
            else if (FigureType == 4)
            {
                CalculatePolygonSquere();
            }
            else
            {
                Console.WriteLine("Извините, данному индексу не соответствует никакая фигура");
            }

            return Squere;
        }

        public double CalculateTrapezoidSquere()
        {
            Console.WriteLine("EnterA:");
            aa = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            bb = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter HH:");
            hh = Double.Parse(Console.ReadLine());
            Squere = (aa + bb) / 2 * hh;
            Console.WriteLine($"Площадь данной фигуры :{Squere}см.кв ");
            return Squere;
        }

        public double CalculateRombSquere()
        {
            Console.WriteLine("Пожалуйста введите сторону ромба : (см.кв)");
            aa = Double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите высоту ромба : (см.кв)");
            hh = Double.Parse(Console.ReadLine());
            
            Squere =aa*hh ;
            Console.WriteLine($"Площадь данной фигуры : {Squere}см.кв");
            return Squere;
        }

        public double CalculatePolygonSquere()
        {
            Console.WriteLine("Вычесление площади правильного n-угольника \n");
            Console.WriteLine("Пожалуйста введите радиус описанной окружности :(см.кв)");
            RR= Double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите угол а n-угольника :(градусов)");
            alfa = Double.Parse(Console.ReadLine());
            //---------------------Формула для вычесление формулы описанного n-угольника
            Squere =Math.Abs( (Math.PI) / 2 * Math.Pow(RR, 2) * Math.Sin(alfa));
            Console.WriteLine($"Площадь данной фигуры : {Squere}(см.кв)");
            return Squere;
        }
    }
}
