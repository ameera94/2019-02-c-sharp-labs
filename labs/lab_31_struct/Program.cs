using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_31_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Point(10, 10);
            var p02 = new Point(20, 20);

        }
    }

    class X
    {

    }

    struct Point
    {
        public int X;
        public int Y;

        //Constructor
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
