﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_20_streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {


            //OVERWRITE MODE - writes from scratch
            using (var writer = new StreamWriter("data.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Data line {i}");
                }
            }

            //APPEND MODE - adds to end
            using (var writer = new StreamWriter("data.txt", true))
            {
                writer.WriteLine("and some more");
            }


            //SET ENCODING (UTF8 default)
            using (var writer = new StreamWriter("data.txt", true, Encoding.UTF8))
            {
                writer.WriteLine("and some more");
            }

            //huge files: can speed up process by altering 'buffer size'
            //which is the unit of data transfer
            using (var writer = new StreamWriter("data.txt", true, Encoding.UTF8, 10000))
            {
                writer.WriteLine("Lots and lots and lots ... of data");
            }

          
        }
    }
}
