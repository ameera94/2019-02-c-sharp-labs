using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace lab_118_array_of_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Saving some data - ";

            //create stopwatch
            var s = new Stopwatch();
            s.Start();

            //write 1000 times to a file synchronously 
            for (int i = 0; i < 1000; i++)
            {
                File.WriteAllText("data.txt", data + i);
            }

            //read 1000 times that same file

            for (int i = 0; i < 1000; i++)
            {
                File.ReadAllText("data.txt");
            }
            s.Stop();
            Console.WriteLine($"Total time 1000 files write then read is {s.ElapsedMilliseconds}");
            //upgrade to this : create 1000 files
            //string filename = "data" + string.format(i, D3) + ".txt";
            // data000.txt data999.txt

            

        }
    }

    public class FileOperationSynchronous
    {
        public long FileReadWrite(int numberOfFiles)
        {
            string str = "Saving some data: ";
            // create stopwatch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // write to file a 1000 time synchronously
            for (int i = 0; i < numberOfFiles; i++)
            {
                File.WriteAllText("data.txt", str + i);
            }

            // read a 1000 times
            for (int i = 0; i < numberOfFiles; i++)
            {
                File.ReadAllText("data.txt");
            }

            // end stopwatch
            stopwatch.Stop();
            string output = $"Time taken to write and read 1000 files: {stopwatch.ElapsedMilliseconds}";

            // upgrade to creating 1000 files
            // string filename = "data"+ string,format(i,D3)+".txt"
            return stopwatch.ElapsedMilliseconds;
        }

        //public long TaskArrayFileReadWrite(int numberOfFiles)
        //{
        //    //one task .. use lambda method -- (input) => { method body}
        //    var singleTask = Task.Run( ()=> { } );

        //    Task.WaitAll(singleTask);
        //    var st = new Stopwatch();
        //    st.Start();

        //    //array of tasks
        //    Task[] tasks = new Task[numberOfFiles];

        //    string fileName = "data" + i.ToString(D3) + ".txt";
        //        for (int i = 0; i < numberOfFiles; i++)
        //        {
        //            tasks[i] = Task.Run(() =>
        //            {
        //                string fileName = "data" + i.ToString(D3) + ".txt";
        //            });
        //        File.Create("../../../../data");
        //            {
        //            }
        //        }
        //    }

        //    Task.WaitAll(tasks);
        //    st.Stop();
        //    return st.ElapsedMilliseconds;

        //    //Homework 1) complete and test read/write 1000 then 10000 files as task 
        //             //2) Bonus: create new project, add Northwind, update contact name of 1 customer 1000 times using 1000 tasks. 
        }
    }
}
