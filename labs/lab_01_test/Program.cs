using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "hello";
            Console.WriteLine(someString[0]); //should return 'h'

            //==objects==
            //invoke new = 'constructor'
            var object1 = new Object();

            //object literal
            var object2 = new
            {
                name = "Amira",
                age = 24,
                dob = "07/12/94"
            };


            //==bytes==
            byte b = 128; // 1000 0000
            byte bMin = 0;
            byte bMax = 255;

            //byte array = buffer - buffer size = data sent in blocks 
            byte[] buffer = new byte[4000];
            




        }
    }
}
