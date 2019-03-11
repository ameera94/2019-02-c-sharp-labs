using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_112_collections
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Collections
    {

        /*
         * Recieve 3 numbers
         * 
         * Put these 3 numbers into array
         * 
         * Output numbers, double each one and store in STACK
         * 
         * Repeat ie output numbers, double and store in QUEUE
         * 
         * Output numbers, SQUARE them then store in LIST<int>
         * 
         * Add up numbers in the List<int> and return total
             
             */
        public int Collections20MinuteLab(int num1, int num2, int num3)
        {
            int[] numArray = new int[] { num1, num2, num3 };

            
            Stack<int> numStack = new Stack<int>();

            foreach (var item in numArray)
            {
                numStack.Push(item * 2);
            }

            Queue<int> numQueue = new Queue<int>();

            foreach (var item in numStack)
            {
                numQueue.Enqueue(item * 2);
            }

            List<double> numList = new List<double>();

            foreach (var item in numQueue)
            {
                numList.Add(Math.Pow(item, 2));
            }

            int total = 0;

            foreach (var item in numList)
            {
                total += (int)item;
            }

            return total;
        }
    }
}
