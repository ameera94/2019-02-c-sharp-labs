using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_25_checked_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            int x = int.MaxValue;
            Console.WriteLine(++x);

            int y = 400000000;
            int z = y * 10;
            Console.WriteLine(z);

            //Integers are NOT CHECKED FOR OVERFLOW BECAUSE CPU INTENSIVE

            //Explicitly check for overflow

            checked
            {
                double b = double.MaxValue;
                Console.WriteLine(++b);

            }

        }
    }
}
