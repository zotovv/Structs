using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = new Train[2];

            MyClass.AddingAnArray(train);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Вы ввели такую информацию о поездах: ");
            Console.WriteLine(new string('-', 50));

            MyClass.Sort(train);
            MyClass.Show(train);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Введите номер поезда: ");
            int find = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 50));
            MyClass.Search(train, find);

            Console.ReadKey();
        }
    }
}
