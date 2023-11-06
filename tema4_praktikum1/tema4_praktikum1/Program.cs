using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema4_praktikum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тема№4 Практикум№1";
            Console.CursorVisible = false;
            Console.WindowWidth = 60;
            Console.WindowHeight = 25;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Введите свое имя");
            string x = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Здравствуйте {x}");
            Console.ReadKey();
        }
    }
}
