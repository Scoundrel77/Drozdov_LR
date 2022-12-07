using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK13._01_KR_6zadanie
{
    class Program
    {
        static double Function(int a, int b, int x1, int x2)
        {
            return Math.Pow(x1 - b, 2) + Math.Pow(x2 - a, 2);
        }

        static void Main(string[] args)
        {
            int lastNumber = 7;
            int underLast = 3;
            int x1 = 3, x2 = 4;

            double result = Function(underLast, lastNumber, x1, x2);
            Console.WriteLine($"Ответ на 6-ую задачу: {result}");
        }
    }
}
