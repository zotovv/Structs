using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructNotebookAfterCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Show();

            Notebook notebook2 = new Notebook("TT-45", "DELL", 589.99);
            notebook2.Show();

            Notebook notebook3 = new Notebook("RR-34");
            notebook3.Show();

            Console.ReadKey();
        }
    }
}
