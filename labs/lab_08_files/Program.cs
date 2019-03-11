using System;
using System.IO;
using System.Text;


namespace lab_08_files
{
    class Program
    {
        static void Main(string[] args)
        {
            //read file
            string data01 = File.ReadAllText("file.txt");
            Console.WriteLine(data01);

            //add encoding (optional)
            string data02 = File.ReadAllText("file.txt", Encoding.UTF8);

            // \n = new line 
            Console.WriteLine($"\n\n\n {data02}");

            // -20 = 20 spaces
            Console.WriteLine($"\n\n\n {"You", -20}{"are...", -20}");

            // read as array .. will return 1st, 2nd and 3rd line in file
            string[] data03 = File.ReadAllLines("file.txt");
            Console.WriteLine(data03[0]);
            Console.WriteLine(data03[1]);
            Console.WriteLine(data03[2]);

            //insert new written data
            File.WriteAllText("file2.txt", "here is \nsome \ndata");
            Console.WriteLine(File.ReadAllText("file2.txt"));

            //
            Console.WriteLine("\nNow write an array to text\n");
            File.WriteAllLines("file3.txt", data03);
            Console.WriteLine("\nAnd read it back\n");
            Console.WriteLine(File.ReadAllText("file3.txt"));

            //copy file
            File.Copy("file.txt", "copyoffile1.txt", true); //overwrite (true)

            //delete file
            File.Delete("copyoffile1.txt");

            Console.WriteLine("does my file exist?\n");
            Console.WriteLine(File.Exists("file.txt"));

            Console.WriteLine(File.GetCreationTime("file.txt"));
            Console.WriteLine(File.GetLastWriteTime("file.txt"));

            //EXTRA INFO
            var fileinfo = new FileInfo("file.txt");
            Console.WriteLine(fileinfo.DirectoryName);
            Console.WriteLine(fileinfo.Extension);

            //directory
            Directory.CreateDirectory("folderA");
            Directory.CreateDirectory("folderB");
            Directory.Delete("folderB");
            File.Create("foldera/abc.txt");
            var fileArray = Directory.GetFiles("folderA");
            Console.WriteLine(fileArray[0]);

        }
    }
}
