using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 4. Написать программу обмена значениями двух переменных.
    а) с использованием третьей переменной;
    б) *без использования третьей переменной.
*/

namespace valueExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c;

            Console.WriteLine($"Значения переменных до обмена: a = {a}, b = {b}\n");

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"Значения переменных после обмена: a = {a}, b = {b}");
            Console.ReadLine();
        }
    }
}
