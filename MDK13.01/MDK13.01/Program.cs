using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK13._01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, y1, y2;
            Console.Write("Введите число x: ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x >= -2 && x <= 2)
            {
                y = (Math.Pow((x + 1), 2)) - (Math.Pow((x + 2), 2 / 3));
                y1 = (Math.Pow((-2 + 1), 2)) - (Math.Pow((-2 + 2), 2 / 3));
                y2 = (Math.Pow((2 + 1), 2)) - (Math.Pow((2 + 2), 2 / 3));
                Console.WriteLine($"Пользовательское число: {y}");
                Console.WriteLine($"Минимальное число диапазона: {y1}");
                Console.WriteLine($"Максимальное число диапазона: {y2}");
            }

            else
                Console.WriteLine("Число x не входит в диапазон [-2 , 2]");
        }
    }
}
