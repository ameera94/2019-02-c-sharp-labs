using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace lab_19_streaming
{
    class Program
    {

        static string line;
        static List<string> listed = new List<string>();

        static void Main(string[] args)
        {

            //READING ASYNCHRONOUSLY
            //If our read is going to take a while then the code can 'hang'.
            //This is because the main 'thread' is doing all the work. 
            //Asynchronous code creates a new 'thread' leaving the main thread free to continue our code.
            //Asynchronous methods always have the same pattern 
            //async ..... MethodName() {
            //await .. do task which takes a long time
            //}
            //NOTE: one CPU core can still run multiple threads. 

            //This thread = main thread (MAIN)

            Console.WriteLine("Program has started");

            ReadData(); 
            Console.WriteLine("Sleeping finished. Starting work NOW!");
            ReadDataAsync();
            Thread.Sleep(30);
            Console.WriteLine("Code has finished");
            Console.ReadLine();

        }

        static void ReadData()
        {
            //Will start running ("Program has started").. take 2 second delay then finish ("Code has finished"). 
            Thread.Sleep(2000);
        }

        static async void ReadDataAsync()
        {
            using (var reader = new StreamReader("data.txt"))
            {
                while(true)
                {
                    line = await reader.ReadLineAsync();

                    if (line == null)
                    {
                        break;
                    }

                    listed.Add(line);
                    Console.WriteLine(line);

                }
            }
            Thread.Sleep(3000);
            Console.WriteLine("Work has finished reading 1000 text lines");

        }
    }
}
