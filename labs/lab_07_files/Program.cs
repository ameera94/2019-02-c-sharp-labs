using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_07_files
{
    class Program
    {
        static void Main(string[] args)
        {
            //==EXCEPTIONS==
            //try - code which can possibly crash
            try
            {
                //file read as string

                string data01 = File.ReadAllText("file.txt");
            }

            //catch - specific exceptions: handling the exception
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Make that file!");
            }
            //finally - always runs regardless
            finally
            {
                Console.WriteLine("and make it quick");
            }
            
        }
    }
}
