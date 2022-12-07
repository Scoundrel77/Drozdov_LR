using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK13._01_KR_3zadanie
{
    class Program
    {
        static int Zadacha3(int a, int d, int b, int c1, int c2)
        {
            return (b / a) * c1 + (b / d) * c2;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int max = 0;
            int a1 = 3, a2 = 3, a3 = 1;
            int d1 = 4, d2 = 1, d3 = 5;
            int b1 = 600, b2 = 357, b3 = 600;
            int c1 = 42000, c2 = 26000;

            int A = Zadacha3(a1, d1, b1, c1, c2);
            int B = Zadacha3(a2, d2, b2, c1, c2);
            int D = Zadacha3(a3, d3, b3, c1, c2);
            list.Add(A);
            list.Add(B);
            list.Add(D);

            foreach (var l in list) 
            {
                if (max < l)
                    max = l;
            }
            Console.WriteLine($"Максимальная сумма: {max}");
        }
    }
}
