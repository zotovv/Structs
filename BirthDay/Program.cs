using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime birthday;
            TimeSpan wait;

            Console.WriteLine("Введите дату вашего рождения в формате 'гггг, мм, дд'");
            birthday = Convert.ToDateTime(Console.ReadLine());

            DateTime thisYear = new DateTime(now.Year, birthday.Month, birthday.Day);

            if (thisYear < now)
            {
                thisYear = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
                wait = thisYear - now;
            }
            else
            {
                wait = thisYear - now;
            }

            Console.WriteLine("До дня рождения осталось {0} дней", wait.Days);


            Console.ReadKey();
        }
    }
}
