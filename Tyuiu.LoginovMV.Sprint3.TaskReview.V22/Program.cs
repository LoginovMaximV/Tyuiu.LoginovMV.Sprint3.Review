using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint3.TaskReview.V22.Lib;

namespace Tyuiu.LoginovMV.Sprint3.TaskReview.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
            Console.WriteLine("* Задание #SprintReview                                                                                      *");
            Console.WriteLine("* Вариант #22                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений фунции f(x) = ((5*x + 2,5)/(sin(x) - 2)) + 2          *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. Произвести проверку деления на 0   *");
            Console.WriteLine("* при делении на 0 вернуть значение 0. Значение округлить до двух знаков после запятой                       *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага:" + startValue);
            Console.WriteLine("Конец шага:" + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueA;
            valueA = new double[len];
            valueA = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("+--------+---------+");
            Console.WriteLine("|    x   |   f(x)  |");
            Console.WriteLine("+--------+---------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}   | {1,5:f2}   |", startValue, valueA[i]);
                startValue++;
            }
            Console.WriteLine("+--------+---------+");
            Console.ReadKey();
        }
    }
}
