 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество отработанных часов: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Acc a = new Acc();

            if (a.AskForBonus(Post.Developer, hours))
            {
                Console.WriteLine("Дать премию.");
            }
            else
            {
                Console.WriteLine("Не давать премию.");
            }

            Console.ReadKey();
        }
    }
}
