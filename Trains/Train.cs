using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    public struct Train
    {
        private string point;
        private int number;
        private DateTime time;

        public Train(string point, int number, DateTime time)
        {
            this.point = point;
            this.number = number;
            this.time = time;
        }

        public string Point
        {
            get => point;
        }

        public int Number
        {
            get => number;
        }

        public DateTime Time
        {
            get => time;
        }

    }
}
