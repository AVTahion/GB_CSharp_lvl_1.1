using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задание №1 Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
*/

namespace GB_CSharp_lvl_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше Имя:");
            string userName = Console.ReadLine();
            Console.WriteLine("Введите Вашу Фамилию:");
            string userSurname = Console.ReadLine();
            Console.WriteLine("Введите Ваш Возраст:");
            string userAge = Console.ReadLine();
            Console.WriteLine("Введите Ваш Рост:");
            string userHeight = Console.ReadLine();
            Console.WriteLine("Введите Ваш Вес:");
            string userWeight = Console.ReadLine();

            Console.WriteLine("Имя: "+ userName + ", Фамилия: " + userSurname + ", Возраст: " + userAge + ", Рост: " + userHeight + ", Вес: " + userWeight + ".");
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}.", userName, userSurname, userAge, userHeight, userWeight);
            Console.WriteLine($"Имя: {userName}, Фамилия: {userSurname}, Возраст: {userAge}, Рост: {userHeight}, Вес: {userWeight}.");
            Console.WriteLine();

            // Задание №2 Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            double iMT = Convert.ToInt16(userWeight) / Math.Pow(Convert.ToDouble(userHeight) / 100, 2);
            Console.WriteLine($"Ваш индекс массы тела (ИМТ): {iMT}");
            Console.ReadLine();
        }
    }
}
