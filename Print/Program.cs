using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    enum Colors
    {
        Blue,
        Red,
        Green
    }

    static class MyClass
    {
        public static void Print(string line, int color)
        {
            switch (color)
            {
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("Введённая вами строка будет выведена на экран цветом по-умолчанию");
                    break;
            }

            Console.WriteLine(line);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string line = Console.ReadLine();

            Console.WriteLine("Укажите цвет: (0-blue, 2-green, 1-red)");
            int color = Convert.ToInt32(Console.ReadLine());

            MyClass.Print(line, color);

            Console.ReadKey();
        }
    }
}
