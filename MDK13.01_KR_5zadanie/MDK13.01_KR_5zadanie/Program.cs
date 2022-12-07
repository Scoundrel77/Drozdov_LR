using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK13._01_KR_5zadanie
{
    class Program
    {
        static double Function(int a, int x, int x2)
        {
            return (a + 7) * x + (a + 8) * x2;
        }

        static void Main(string[] args)
        {
            int underLast = 3;
            int x = 3;
            int x2 = 4;

            double result = Function(underLast, x, x2);
            Console.WriteLine($"Решение 5-ой задачи: {result}");
        }
    }
}
