using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    public static class MyClass
    {
        public static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].Number <= trains[j].Number)
                    {
                        Train x = trains[i];
                        trains[i] = trains[j];
                        trains[j] = x;
                    }
                }
            }
        }

        public static void Search(Train[] train, int find)
        {
            bool ok = false;

            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].Number == find)
                {
                    Console.WriteLine("Номер поезда {0}, пункт назначения {1}, дата и время отправления {2}",
                                       train[i].Number, train[i].Point, train[i].Time);

                    ok = true;


                }
            }
            if (!ok)
                Console.WriteLine("Поезд не найден!");
        }

        public static void AddingAnArray(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write("Введите пункт назначения: ");
                string point = Console.ReadLine();
                point = string.IsNullOrEmpty(point) ? "Не указан пункт назначения" : point;

                Console.Write("Введите номер поезда: ");
                string d = Console.ReadLine();
                int number = string.IsNullOrEmpty(d) ? 0 : Convert.ToInt32(d);

                Console.Write("Дату отправления: ");
                d = Console.ReadLine();
                DateTime time = string.IsNullOrEmpty(d) ? DateTime.Now : DateTime.Parse(d);

                train[i] = new Train(point, number, time);
            }
        }

        public static void Show(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Номер поезда: {0}, пункт назначения: {1}, дата и время отправления: {2}", +
                                  train[i].Number, train[i].Point, train[i].Time);
            }
        }

    }
}
