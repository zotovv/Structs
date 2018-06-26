using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountant
{
    enum Post
    {
        Manager = 195,
        Developer = 200,
        Accountant = 192,
        Secretary = 192,
        Cleaner =  192
    }

    class Acc
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
