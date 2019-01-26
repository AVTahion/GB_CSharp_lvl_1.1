using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задание №5
    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) Сделать задание, только вывод организуйте в центре экрана
    в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
*/

namespace myProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Александр";
            string mySurname = "Кушмилов";
            string myLocation = "Санкт-Петербург";

            Console.WriteLine($"{myName}\n{mySurname}\n{myLocation}\n");
            Console.ReadLine();


            // б)

            int x = 52; // положение курсора по х
            int y = 13; // положение курсора по y

            Console.SetCursorPosition(x, y);
            Console.WriteLine(myName);
            Console.SetCursorPosition(x, y+1);
            Console.WriteLine(mySurname);
            Console.SetCursorPosition(x, y+2);
            Console.WriteLine(myLocation);
            Console.ReadLine();

            Console.Clear();

            Print(myName, x, y);
            Print(mySurname, x, y+1);
            Print(myLocation, x, y+2);
            Console.ReadLine();
        }

        // в)

        static void Print(string ms, int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(ms);
        }
    }
}
