using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK13._01_KR_4zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] products = new int[3, 5]
            {
                {2, 3, 1, 3, 0},
                {7, 1, 4, 5, 0},
                {4, 6, 9, 2, 0}
            };

            int result = products[0, 0] * 80 + products[0, 2] * 10 + products[1, 0] * 60 +
                products[1, 1] * 510 + products[1, 4] * 130 + products[2, 0] * 30 + products[2, 3] * 20;
            Console.WriteLine($"Минимальные затраты: {result}");
        }
    }
}
