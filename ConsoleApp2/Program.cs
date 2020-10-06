using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static double segment1(double x) //функция для определения значений функции в первом сегменте графика (слева направо)
        {
            double y;

            y = x + 3;

            return y;
        }

        static double segment2(double x, double R)
        {
            double y;

            y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2));

            return y;
        }

        static double segment3(double x)
        {
            double y;

            y = 3 - x / 2.0;

            return y;
        }

        static double segment4(double x)
        {
            double y;

            y = x - 6;

            return y;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите значение аргумента x: ");
            double x = double.Parse(Console.ReadLine());

            if (x <= -3 && x >= -5)
            {
                Console.WriteLine($"y({x}) = {segment1(x)}");
            }
            else if (x <= 0 && x >= -3)
            {
                Console.Write("Введённый аргумент входит в область окружности. Введите радиус R: "); //радиус равен 3
                double R = double.Parse(Console.ReadLine());
                if (R < 3 || R > 3)
                {
                    Console.WriteLine("Неправильно введён радиус. Проверьте его значение и повторите попытку.");
                }
                else
                {
                    Console.WriteLine($"y({x}) = {segment2(x, R)}");
                }

            }
            else if (x >= 0 && x <= 6)
            {
                Console.WriteLine($"y({x}) = {segment3(x)}");
            }
            else if (x >= 6 && x <= 9)
            {
                Console.WriteLine($"y({x}) = {segment4(x)}");
            }
            else if (x < -5 || x > 9)
            {
                Console.WriteLine("Функция в этой точке не определена.");
            }

            //распечтаем значения функции (только нарисованной на графике задания):

            Console.WriteLine("Значения функции с шагом аргумента 0.2: ");

            for (double a = -3; a <= 9; a += 0.2)
            {
                if (a <= -3)
                {
                    Console.WriteLine($"y({a}) = {Math.Round(segment1(a), 3)}");
                }
                else if (a <= 0 && a >= -3)
                {
                    Console.WriteLine($"y({a}) = {Math.Round(segment2(a, 3), 3)}");
                }
                else if (a >= 0 && a <= 6)
                {
                    Console.WriteLine($"y({a}) = {Math.Round(segment3(a), 3)}");
                }
                else if (a >= 6)
                {
                    Console.WriteLine($"y({a}) = {Math.Round(segment4(a), 3)}");
                }
            }

            Console.ReadKey();
        }
    }
}
