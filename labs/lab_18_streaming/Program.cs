using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_18_streaming
{
    class Program
    {

        

        static void Main(string[] args)
        {
            List<string> listed = new List<string>();

            //Not using streaming: writing directly
            string File01 = File.ReadAllText("data.txt");


            //path as a variable 
            //path01 is a relative path
            string path01 = "data.txt";
            //path02 is an absolute path
            string path02 = "C:/data/data.txt";
            //path03 using 'escape characters: \t = tab,  \n = new line 
            // \' will print one single apostrophe
            string path03 = "C:\\data\\data.txt";
            //path04 @ means treat the following string literally - use when there's quotation marks etc.
            string path04 = @"C:\data\data.txt";
            //Environment variables: my documents path
            string path05 = Environment.ExpandEnvironmentVariables("%userprofile%") + "\\Documents\\data.txt";
            Console.WriteLine(path05);
            string path06 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data.txt";
            
            
            //StreamReader
            //Create StreamReader Object 
            //Enclose in 'using' block' (complete 'cleanup' afterwards)
            //ReadLine() stream and read line by line. 


            //Instead of ReadLine(), we can also use just Read() which reads character by character. 
            //Test for end of data with reader.Peek = -1
                //Peek ==> looks at next item but not remove it 
                //Queue, Stack also have this method

                //e.g. 
                    // while(reader.Peek != -1) { //get next character: char c = reader.Read(); }



            using (var reader = new StreamReader(path06))
            {
                string output; 

                //read every line
                //output to string
                //test each time the string is not null
                //continue looping until out of data.
                while ((output = reader.ReadLine()) != null)
                {
                    listed.Add(output);
                }
            }

            listed.ForEach(output => Console.WriteLine(output));

        }
    }
}
