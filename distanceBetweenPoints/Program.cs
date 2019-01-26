using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задание №3
    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
*/

namespace distanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки:");
            Console.WriteLine("X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите координаты второй точки:");
            Console.WriteLine("X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"\nРасстояние между точками: {r:F2}");
            Console.ReadLine();
        }

        // б)
        static double Distance(double x1, double y1, double x2, double y2)
        {
            double R = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return R;
        }
    }
}
