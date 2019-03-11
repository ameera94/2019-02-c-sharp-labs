
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
            Kata.CountBits(1234);
            Kata.Divisors(9);
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

        //Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. If the number is prime return the string '(integer) is prime' (null in C#) (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).
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

    }

}
