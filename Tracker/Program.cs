using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taker
{

    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        

        static void Main(string[] args)
        {
            MyClass testClass = new MyClass();  // экземпляр класса передаётся по ссылке
            MyStruct testStruct = new MyStruct(); // структура передаётся по значению

            testClass.change = "не изменено";
            testStruct.change = "не изменено";

            ClassTaker(testClass);
            StructTaker(testStruct);

            Console.WriteLine("Поле класса: {0}", testClass.change);
            Console.WriteLine("Поле структуры: {0}", testStruct.change);

            Console.ReadKey();
        }
    }
}
