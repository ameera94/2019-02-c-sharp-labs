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
            //Kata.Divisors(37);
            //Kata.AlphabetPosition("The sunset sets at twelve o' clock");
            //Kata.DnaStrand("ATTGC");
            //Kata.PigIt("Phil is awesome.");
            //Kata.FirstNonRepeatingLetter("Hello");
            //Kata.MoveZeroes( new int[]{ 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            //Kata.ExpandedForm(70304);

            Kata.arrays();
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
        //Move the first letter of each word to the end of it, then add "ay" to the end of the word.Leave punctuation marks untouched.
        //Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
        public static string PigIt(string str)
        {
            string piglat = "";
            string[] separated = str.Split();
            List<char> chars = new List<char>();
            string newWord = "";
            char punct = ' ';
            foreach (var word in separated)
            {
                foreach (char c in word)
                {
                    if(char.IsPunctuation(c) == false)
                    {
                        chars.Add(c);                      
                    }
                    else
                    {
                        punct = c;
                    }
                }
                string first = chars.ElementAt(0).ToString();
                chars.RemoveAt(0);
                string prefix = "";
                foreach (var item in chars)
                {
                    prefix += item;
                }               
                if (punct != 'g')
                {
                    newWord = $"{prefix}{first}ay{punct}";
                }
                piglat += newWord;
                chars.Clear();
                punct = ' ';
            }           
            Console.WriteLine(piglat.TrimEnd());
            return piglat.TrimEnd();
        }

        //public static string FirstNonRepeatingLetter(string s)
        //{           
        //    Queue<char> myQ = new Queue<char>();          
        //    foreach (char c in s)
        //    {
        //        if (s.Any(c))
        //        {
        //            myQ.Enqueue(c);
        //        }               
        //    }
        //    Console.WriteLine(myQ.Dequeue());
        //    return myQ.Dequeue().ToString();
        //}

        //Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> nums = new List<int>();
            int count = 0;
            foreach (var num in arr)
            {
                if (num == 0)
                {
                    count++;
                }
                else
                {
                    nums.Add(num);
                }
            }

            for (int i = 0; i < count; i++)
            {
                nums.Add(0);
            }

            int[] arr2 = new int[nums.Count];
            for (int i = 0; i < nums.Count; i++)
            {
                arr2[i] = nums[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            return arr2;
        }

        //Kata.ExpandedForm(42); # Should return "40 + 2"
        //Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"
        public static string ExpandedForm(long num)
        {
            
            string nums = num.ToString();
            string expanded = "";
            int conv = 0;
            int zeroes = 0;
            List<int> numbers = new List<int>();
            foreach (char n in nums)
            {
                conv = Convert.ToInt32(n.ToString());
                numbers.Add(conv);
            }

            Console.WriteLine("\t==========LIST OF NUMBERS=======\t\t");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    zeroes = numbers.Count - i - 1;
                    expanded += $"{(numbers[i] * Math.Pow(10, zeroes))} + ";
                }
                
            }
            Console.WriteLine(expanded.Substring(0, expanded.Length - 3));
            return expanded.Substring(0, expanded.Length - 3);
        }

        //Three 1's => 1000 points
        //Three 6's =>  600 points
        //Three 5's =>  500 points
        //Three 4's =>  400 points
        //Three 3's =>  300 points
        //Three 2's =>  200 points
        //One   1   =>  100 points
        //One   5   =>   50 point

        //public static int Score(int[] dice)
        //{
            
        //    foreach (var item in dice)
        //    {
        //        switch (item)
        //        {
        //            case 1: 
                        
        //            default:
        //                break;
        //        }
        //    }
        //    return dice[0];
        //}

        
    }
}
  