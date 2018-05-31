using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructNotebookAfterCheck
{
    public struct Notebook
    {
        readonly string model;
        readonly string producer;
        readonly double price;

        public string Model
        {
            get => model;
        }

        public string Producer
        {
            get => producer;
        }

        public double Price
        {
            get => price;
        }

        public Notebook(string model, string producer, double price)
        {
            this.model = model;
            this.producer = producer;
            this.price = Math.Abs(price);
        }

        // Перегрузка пользовательского конструктора.

        public Notebook(string model)
        : this(model, "", 0)
        {
        }

        public Notebook(double price)
        :this("", "", price)
        {
        }

        public void Show()
        {
            Console.WriteLine("Модель {0} от {1} стоимостью {2} $", model, producer, price);
        }

    }
}
