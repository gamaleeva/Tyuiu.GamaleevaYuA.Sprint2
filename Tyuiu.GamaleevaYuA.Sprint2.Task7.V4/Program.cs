﻿using Tyuiu.GamaleevaYuA.Sprint2.Task7.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
        Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
        Console.WriteLine("* X,Y в заштрихованной области.                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x, y;
        Console.WriteLine("Введите координату X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool res = ds.CheckDotInShadedArea(x, y);
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }
        Console.ReadKey();
    }
}