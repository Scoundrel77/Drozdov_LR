using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK13._01ch2
{
    class Program
    {
        static double f(double x1, double x2, double a, double b, double c, double d, double p)
        {
            return (a * x1 + b * x2 + c * Math.Pow(x1, 2) + d * Math.Pow(x2, 2)) + p;
        }

        static double f2(double x1, double x2, double a, double b, double c, double d)
        {
            return a * x1 + b * x2 + Math.Exp(c * Math.Pow(x1, 2) + d * Math.Pow(x2, 2));
        }

        static void Main(string[] args)
        {
            Console.Write("Задайте число x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Задайте число x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double a1 = 22;
            double b1 = 9;
            double c1 = -2;
            double d1 = -4;
            double a2 = 9.0;
            double b2 = -0.6;
            double c2 = 0.81;
            double d2 = 0.19;
            double p = 3;
            double max = 0, min = 0;

            double h = f(x1, x2, a1, b1, c1, d1, p);
            double h1 = f2(x1, x2, a2, b2, c2, d2);
            Console.WriteLine($"Максимум функции: {h}");
            Console.WriteLine($"Минимум функции: {h1}");
        }
    }
}
