using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructNotebook
{
    public struct Notebook
    {
         public string name;
        public string vendor;
        public int price;

        public Notebook(string name, string vendor, int price)
        {
            this.name = name;
            this.vendor = vendor;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("Название: {0}", name);
            Console.WriteLine("Производитель: {0}", vendor);
            Console.WriteLine("Цена: {0}", price);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {   
        // Инициализируем структуру при помощи пользовательского конструктора.

            Notebook notebook1 = new Notebook("Lenovo", "China", 500);
            notebook1.Show();

            Console.WriteLine(new string('-', 30));

        // Иницаилизация полей без использования ключевого слова "new" - уникальная возможность структур.

            Notebook notebook2;
            notebook2.name = "Mac";
            notebook2.vendor = "Apple";
            notebook2.price = 100;

            notebook2.Show();




            Console.ReadKey();
        }
    }
}
