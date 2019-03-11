using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_practive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kata.CountBits(1234);
            Kata.Divisors(37);
            //Kata.AlphabetPosition("The sunset sets at twelve o' clock");
            //Kata.DnaStrand("ATTGC");
        }
    }

    public class Kata
    {
        public static int CountBits(int n)
        {
            //convert int to binary 
            string binary = Convert.ToString(n, 2);
            int count = 0;
            //count how many times there is a 1 in the binary form
            foreach (char c in binary)
            {
                if (c == '1')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        //Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. If the number is prime return the string '(integer) is prime' (null in C#).
        public static int[] Divisors(int n)
        {

            List<int> divs = new List<int>();

            for (int i = 1; i < n; i++)
            {

                if (i > 1 && n % i == 0)
                {
                    divs.Add(i);
                }
            }

            int[] divisors = new int[divs.Count];
            divs.Sort();
            if (divs.Count == 0)
            {
                Console.WriteLine($"{n} is prime");
                return null;
            }

            for (int j = 0; j < divs.Count; j++)
            {
                divisors[j] = divs[j];
            }
            for (int i = 0; i < divisors.Length; i++)
            {
                Console.WriteLine(divisors[i]);
            }
            return divisors;

        }

        public static string AlphabetPosition(string text)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string checkText = text.ToUpper();

            string alString = "";
            foreach (char letter in checkText)
            {
                if (alphabet.Contains(letter))
                {
                    int alPos = alphabet.IndexOf(letter) + 1;
                    alString += $"{alPos.ToString()} ";
                }
            }

            Console.WriteLine(alString.TrimEnd());

            return alString.TrimEnd();
        }

        public static string DnaStrand(string dna)
        {
            string compStrand = "";
            foreach (char nuc in dna)
            {
                switch (nuc)
                {
                    case 'A':
                        compStrand += 'T';
                        break;
                    case 'T':
                        compStrand += 'A';
                        break;
                    case 'G':
                        compStrand += 'C';
                        break;
                    case 'C':
                        compStrand += 'G';
                        break;
                }
            }
            Console.WriteLine(compStrand);
            return compStrand;


        }

        public static string PigIt(string str)
        {


            return str;
        }
    }
}
