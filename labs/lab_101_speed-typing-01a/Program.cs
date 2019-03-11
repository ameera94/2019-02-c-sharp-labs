using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lab_101_speed_typing_01a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inputList = new List<char>();
            List<char> alphabet = new List<char>();
            Stopwatch stopwatch = new Stopwatch();

            alphabet.Add('a');
            alphabet.Add('b');
            alphabet.Add('c');
            alphabet.Add('d');
            alphabet.Add('e');
            alphabet.Add('f');
            alphabet.Add('g');
            alphabet.Add('h');
            alphabet.Add('i');
            alphabet.Add('j');
            alphabet.Add('k');
            alphabet.Add('l');
            alphabet.Add('m');
            alphabet.Add('n');
            alphabet.Add('o');
            alphabet.Add('p');
            alphabet.Add('q');
            alphabet.Add('r');
            alphabet.Add('s');
            alphabet.Add('t');
            alphabet.Add('u');
            alphabet.Add('v');
            alphabet.Add('w');
            alphabet.Add('x');
            alphabet.Add('y');
            alphabet.Add('z');



            stopwatch.Start();
            bool strictGame = true;
            bool randomGame = false;

            while (randomGame == true)
            {

                char input = (Console.ReadKey().KeyChar);
                inputList.Add(input);
                Console.WriteLine(inputList.Count);
                if (stopwatch.Elapsed.TotalSeconds > 5)
                {
                    Console.WriteLine("Time's Up!");
                    Console.WriteLine($"You got {inputList.Count} letters!");
                    break;
                }

            }


            while (strictGame == true)
            {
                char input = (Console.ReadKey().KeyChar);
                if (input == alphabet[0])
                {
                    alphabet.RemoveAt(0);
                }
                else
                {

                    Console.WriteLine("\nWrong Key! Try again");

                }
                if (alphabet.Count <= 0)
                {

                    Console.WriteLine("\nAlphabet done");
                    break;
                }
                if (stopwatch.Elapsed.TotalSeconds > 10)
                {
                    Console.WriteLine("\nTime's Up!");
                    Console.WriteLine($"\nYou got {26 - (alphabet.Count)} out of 26!");
                    break;
                }



            }

            stopwatch.Stop();

        }
    }
}
